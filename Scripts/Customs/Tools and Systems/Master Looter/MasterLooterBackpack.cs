#define USE_TOKENS

using Server;
using System.Collections;
using Server.Multis;
using Server.ContextMenus;
using System.Collections.Generic;
using Server.Mobiles;
using Server.Items;
using System;
using Server.Targeting;
using Server.Mobiles;
using Server.Gumps;
using Server.Network;





namespace Daat99MasterLooterSystem
{
    public class MasterLooterBackpack : Backpack
    {
		//Change this to set the default loot settings for your players
		public void RestoreDefaultSettings()
		{
			RestoreDefaultList();
			lootSettings = LootSettingsEnum.From_List; //players loot items from their list only
			DeleteAllCorpses = false; //deletes all the corpses or just empty ones
			GoldLedger = true; //enables the gold ledger
			TokenLedger = true; //enables the token ledger
		}
		
		public void RestoreDefaultList()
		{
			activeBaseTypes = new List<Type>(Daat99MasterLootersUtils.DefaultBaseTypes); //see and/or change list in Utils file
			activeLootTypes = new List<Type>(Daat99MasterLootersUtils.DefaultItemTypes); //see and/or change list in Utils file
		}

		public enum LootSettingsEnum { Everything, From_List, Currency_Only };
		private LootSettingsEnum lootsettings = LootSettingsEnum.From_List;
		public LootSettingsEnum lootSettings
		{
			get { return lootsettings; }
			set { lootsettings = value; InvalidateProperties(); }
		}

		public string LootSettingsString { get { return lootSettings.ToString().Replace("_", " "); } }
		
		private static readonly string DefaultLooterName = "Master Looter";
		
		private int owner;
		[CommandProperty(AccessLevel.GameMaster)]
		public int Owner { get { return owner; } set { owner = value; } }
		
		private bool goldLedger;
		[CommandProperty(AccessLevel.GameMaster)]
		public bool GoldLedger { get { return goldLedger; } set { goldLedger = value; InvalidateProperties(); } }
		
		private bool tokenLedger;
		[CommandProperty(AccessLevel.GameMaster)]
		public bool TokenLedger 
		{ 
			get 
			{ 
#if USE_TOKENS
				return tokenLedger; 
#else
				return false;
#endif
			} 
			set 
			{ 
				tokenLedger = value; InvalidateProperties(); 
			} 
		}
		
		private bool deleteAllCorpses;
		[CommandProperty(AccessLevel.GameMaster)]
		public bool DeleteAllCorpses { get { return deleteAllCorpses; } set { deleteAllCorpses = value; InvalidateProperties(); } }

		private ulong goldAmount;
		[CommandProperty(AccessLevel.GameMaster)]
		public ulong GoldAmount
		{
			get { return goldAmount; }
			set 
			{
				if (value > ulong.MaxValue || value < ulong.MinValue)
					return;
				goldAmount = value;
				InvalidateProperties();
			}
		}

		private ulong tokensAmount;
		[CommandProperty(AccessLevel.GameMaster)]
		public ulong TokensAmount
		{
			get { return tokensAmount; }
			set
			{
				if (value > ulong.MaxValue || value < ulong.MinValue)
					return;
				tokensAmount = value;
				InvalidateProperties();
			}
		}
		
		private List<Type> baseTypesA, baseTypesB;
		private List<Type> lootTypesA, lootTypesB;
		private List<Type> activeBaseTypes 
		{
			get
			{
				return (activeListA ? baseTypesA : baseTypesB);
			}
			set 
			{
				if ( activeListA )
					baseTypesA = value;
				else
					baseTypesB = value;
			}
		}
		private List<Type> activeLootTypes
		{
			get
			{
				return (activeListA ? lootTypesA : lootTypesB);
			}
			set 
			{
				if ( activeListA )
					lootTypesA = value;
				else
					lootTypesB = value;
			}
		}

		private bool activeListA;
		public string ActiveListName { get { return ( activeListA ? "Primary" : "Secondary"); } }
		public void SwitchActiveList()
		{
			activeListA = !activeListA;
		}

		public int TypesCount 
		{ 
			get 
			{ 
				return (activeBaseTypes == null ? 0 : activeBaseTypes.Count) + (activeLootTypes == null ? 0 : activeLootTypes.Count);
			}
		}

		[Constructable]
		public MasterLooterBackpack()
			: base()
		{
			Weight = 0.0;
			Hue = 1169;
			ItemID = 0x9b2;
			Name = DefaultLooterName;
            LootType = LootType.Blessed;
			Owner = 0;

			//resets list B to default
			activeListA = false;
			RestoreDefaultList();
			
			//resets list A and loot settings to default
			SwitchActiveList();
			RestoreDefaultSettings();
		}

		public MasterLooterBackpack( Serial serial ) : base( serial ) { }

		public override void GetProperties(ObjectPropertyList list)
        {
			base.GetProperties( list );
			list.Add(1060660, "Gold\t" + (GoldLedger?GoldAmount.ToString():"Inactive"));
			list.Add(1060661, "Tokens\t" + (TokenLedger?TokensAmount.ToString():"Inactive"));
			list.Add(1060662, "Looting\t" + LootSettingsString); //value: ~1_val~
			list.Add(1060663, "Deleting\t" + (DeleteAllCorpses?"All Corpses":"Empty Corpses")); //value: ~1_val~
        }
		
		public override void GetContextMenuEntries( Mobile from, List<ContextMenuEntry> list )
		{
			base.GetContextMenuEntries( from, list );
			PlayerMobile player = from as PlayerMobile;
			if ( !IsOwner(player) )
				return;
			if ( GoldLedger || TokenLedger )
				list.Add( new MasterLooterLedgerContextMenu( player, this ) );
			list.Add( new MasterLooterSetupContextMenu( player, this ) );
			if ( GoldLedger || TokenLedger )
				list.Add( new MasterLooterFillContextMenu( player, this ) );
		}
		
		public void Loot( PlayerMobile player )
		{
			if ( !IsOwner(player) )
				return;
			List<Item> items = new List<Item>();
			List<Corpse> corpses = new List<Corpse>();

			foreach ( Item item in player.GetItemsInRange(3) )
			{
				if ( item is Corpse )
				{
					Corpse corpse = item as Corpse;
					if ( isCorpseLootable(player, corpse) )
						corpses.Add(corpse);
				}
				else if ( item.Movable && item.IsAccessibleTo(player) && isItemLootable(item) )
					items.Add(item);
 			}

			foreach ( Item item in items )
				TryDropItem(player, item, false);

				
			bool lootedAll = true;
			int totalTokens = 0;
			int retries = 3;
			foreach ( Corpse corpse in corpses )
			{
				if ( lootContainer(player, corpse) )
				{

					if ( DeleteAllCorpses || corpse.GetAmount(typeof(Item), false) == 0 )
					{

						int reward = getCorpseReward(corpse);

						if ( reward > 0 )
						{

							totalTokens += reward;
							AddTokensAmount((ulong)reward);
							AddGoldAmount((ulong)(reward*2));
						}

						corpse.Delete();
					}

				}
				else
				{
					lootedAll = false;
					if ( --retries == 0 )
						break;
				}
			}

			if ( totalTokens > 0 )
			{
				player.SendMessage(1173, "You gained " + totalTokens + " tokens for cleaning the shard.");
			}
			else
				player.SendMessage(1173, "You didn't gain a single token...");
			if ( !lootedAll )
				player.SendMessage(1173, "You can't loot all the items.");
		}
		
		private bool lootContainer( PlayerMobile player, Container container )
		{
			if ( !IsOwner(player) )
				return false;
			List<Item> items = new List<Item>( container.Items.Count );
			foreach ( Item item in container.Items )
				if ( item != null && isItemLootable( item ) )
					items.Add( item );

			foreach ( Item item in items )
				if ( !this.TryDropItem(player, item, false) )
					return false;
			return true;
		}
		
		private int getCorpseReward( Corpse c )
		{

			if (c == null || c.Owner == null)
				return 0;

			BaseCreature owner = c.Owner as BaseCreature;
			if ( owner == null )
				return 0;

			double resists = ((owner.PhysicalResistance + owner.FireResistance + owner.ColdResistance + owner.PoisonResistance + owner.EnergyResistance)/50); //set the amount of resists the monster have
			if (resists < 1.0) //if it have less then total on 100 resists set to 1
				resists = 1.0;
			int hits = (owner.HitsMax/10); //set the amount of max hp the creature had.
			double tempReward = (hits + ((hits * resists)/10) ); //set the temp reward
						
			int fameKarma = Math.Abs(owner.Fame) + Math.Abs(owner.Karma); //set fame\karma reward bonus
			fameKarma /= 250;
			tempReward += fameKarma; //add the fame\karma reward to the temp reward

			if (owner.AI == AIType.AI_Mage) //if it's mage add some tokens, it have spells
			{
				double mage = ((owner.Skills[SkillName.Meditation].Value + owner.Skills[SkillName.Magery].Value + owner.Skills[SkillName.EvalInt].Value)/8);
				tempReward += mage;
			}
							
			if (owner.HasBreath) //give bonus for creatures that have fire breath
			{
				double fireBreath = (owner.HitsMax/25);
				tempReward += fireBreath; //add the firebreath bonus to temp reward
			}	
							
			int reward = ((int)tempReward);
			reward = Utility.RandomMinMax((int)(reward*0.3), (int)(reward*0.6));

			if (reward < 1)
				reward = 1; //set minimum reward to 1

			return reward;
		}
		
		public bool isItemLootable( Item item )
		{
			if ( item == null || item.Deleted || !item.Movable )
				return false;
			return isTypeLootable(item.GetType());
		}
		
		internal bool isTypeLootable(Type itemType)
		{
			if ( itemType == null )
				return false;

			if ( lootSettings == LootSettingsEnum.Everything )
				return true;

			if ( Daat99MasterLootersUtils.IsCurrencyType(itemType) )
				return true;
			
			if ( lootSettings == LootSettingsEnum.Currency_Only )
				return false;

			if ( activeLootTypes != null && activeLootTypes.Contains(itemType) )
				return true;

			if ( activeBaseTypes != null )
				foreach ( Type type in activeBaseTypes )
					if ( itemType.IsSubclassOf(type) )
						return true;
			return false;
		}

		internal bool AddItemType(Type type)
		{
			if ( type == null )
				return false;
			if ( isTypeLootable(type) )
				return false;
			activeLootTypes.Add(type);
			return true;
		}
		
		internal bool AddBaseType(Type type)
		{
			if ( type == null )
				return false;
			if ( isTypeLootable(type) )
				return false;
			
			List<Type> contained = new List<Type>();
			foreach ( Type t in activeBaseTypes )
				if ( t.IsSubclassOf(type) )
					contained.Add(t);
			foreach ( Type t in contained )
				activeBaseTypes.Remove(t);
			foreach ( Type t in activeLootTypes )
				if ( t.IsSubclassOf(type) )
					contained.Add(t);
			foreach ( Type t in contained )
				activeLootTypes.Remove(t);
			activeBaseTypes.Add(type);
			return true;
		}

		internal void RemoveType(Type type)
		{
			if ( type == null )
				return;

			if ( activeLootTypes.Contains(type) )
				activeLootTypes.Remove(type);
			else if ( activeBaseTypes.Contains(type) )
				activeBaseTypes.Remove(type);
		}

		public override void Serialize( GenericWriter writer )
		{
			base.Serialize( writer );

			writer.Write( (int) 4 ); // version
			//version 4
			writer.Write(activeListA);
			
			SerializeList( writer, true );
			SerializeList( writer, false );
			
			writer.Write( GoldLedger );
			writer.Write( TokenLedger );
			writer.Write( (int)lootSettings );
			writer.Write( GoldAmount );
			writer.Write( TokensAmount );
			writer.Write( Owner );
			// Version 2
			writer.Write( DeleteAllCorpses );
		}

		public override void Deserialize( GenericReader reader )
		{
			base.Deserialize( reader );

			int version = reader.ReadInt();

			if ( version >= 4 )
			{
				activeListA = reader.ReadBool();
				DeserializeList( reader, true );
				DeserializeList( reader, false );
			}
			else
			{
				activeListA = false;
				RestoreDefaultList();
				activeListA = true;
				DeserializeList( reader, true );
			}
			
			GoldLedger = reader.ReadBool();
			TokenLedger = reader.ReadBool();
			if ( version >= 3 )
			{
				try { lootSettings = (LootSettingsEnum)reader.ReadInt(); }
				catch { lootSettings = LootSettingsEnum.From_List; }
			}
			else
				lootSettings = reader.ReadBool()?LootSettingsEnum.Currency_Only:LootSettingsEnum.From_List;
			GoldAmount = reader.ReadULong();
			TokensAmount = reader.ReadULong();
			Owner = reader.ReadInt();
			if ( version > 1 )
				DeleteAllCorpses = reader.ReadBool();
		}
		
		private void DeserializeList( GenericReader reader, bool deserActiveListA )
		{
			bool tempActiveListA = activeListA;
			activeListA = deserActiveListA;
			
			activeBaseTypes = new List<Type>();
			int count = reader.ReadInt();
			for ( int i=0; i<count; ++i )
			{
				try
				{
					Type type = Type.GetType(reader.ReadString());
					if ( type != null && !isTypeLootable(type) )
						activeBaseTypes.Add(type);
				}
				catch { }
			}
			
			activeLootTypes = new List<Type>();
			count = reader.ReadInt();
			for ( int i=0; i<count; ++i )
			{
				try
				{
					Type type = Type.GetType(reader.ReadString());
					
					if ( type != null && !isTypeLootable(type) )
						activeLootTypes.Add(type);
				}
				catch { }
			}
			
			activeListA = tempActiveListA;
		}

		public void SerializeList( GenericWriter writer, bool serActiveListA )
		{
			bool tempActiveListA = activeListA;
			activeListA = serActiveListA;
			
			writer.Write( activeBaseTypes.Count );
			foreach ( Type type in activeBaseTypes )
				writer.Write( type.FullName );
				
			writer.Write( activeLootTypes.Count );
			foreach ( Type type in activeLootTypes )
				writer.Write( type.FullName );

			activeListA = tempActiveListA;
		}
		public override void DropItem( Item dropped )
		{
			if ( AddCurrency(dropped) )
				return;
			base.DropItem(dropped);
		}
		public override bool OnDragDropInto( Mobile from, Item item, Point3D p, byte gridloc )
		{
			if ( AddCurrency(item) )
				return true;
			return base.OnDragDropInto(from, item, p,  gridloc);
		}
		public override bool TryDropItem( Mobile from, Item dropped, bool sendFullMessage )
		{
			if ( AddCurrency(dropped) )
				return true;
			return base.TryDropItem(from, dropped, sendFullMessage);
		}
		public override bool OnDragDrop(Mobile from, Item dropped)
		{
			if ( AddCurrency(dropped) )
				return true;
			return base.OnDragDrop(from, dropped);
		}
		
		public void AddCurrencyFromBackpack( PlayerMobile player )
		{
			foreach ( Item item in player.Backpack.FindItemsByType(typeof(Item)) )
				AddCurrency(item);
		}
		public bool AddCurrency( Item currency )
		{
			if ( !Daat99MasterLootersUtils.IsCurrencyType(currency.GetType()) )
				return false;

			if (currency is Gold && GoldLedger)
				return AddGoldPile(currency as Gold);

			if (currency is BankCheck && GoldLedger)
				return AddGoldCheck(currency as BankCheck);

#if USE_TOKENS
			if (currency is Daat99Tokens && TokenLedger)
				return AddTokensPile(currency as Daat99Tokens);

			if (currency is TokenCheck && TokenLedger)
				return AddTokenCheck(currency as TokenCheck);
#endif
			return false;
		}

		public bool AddGoldPile(Gold gold)
		{
			if ( !GoldLedger )
				return false;
			gold.Amount = (int)AddGoldAmount((ulong)gold.Amount);
			if (gold.Amount == 0)
			{
				gold.Consume();
				return true;
			}
			return false;
		}
		public bool AddGoldCheck(BankCheck check)
		{
			if ( !GoldLedger )
				return false;
			check.Worth = (int)AddGoldAmount((ulong)check.Worth);
			if (check.Worth == 0)
			{
				check.Consume();
				return true;
			}
			return false;
		}

		public ulong AddGoldAmount(ulong amount)
		{
			if ( !GoldLedger )
				return amount;
			ulong max = ulong.MaxValue - GoldAmount;
			if (max > amount)
			{
				GoldAmount += amount;
				return (ulong)0;
			}
			GoldAmount += max;
			amount -= max;
			return amount;
		}

#if USE_TOKENS
		public bool AddTokensPile(Daat99Tokens tokens)
		{
			if ( !TokenLedger )
				return false;
			tokens.Amount = (int)AddTokensAmount((ulong)tokens.Amount);
			if (tokens.Amount == 0)
			{
				tokens.Consume();
				return true;
			}
			return false;
		}
		public bool AddTokenCheck(TokenCheck tokenCheck)
		{
			if ( !TokenLedger )
				return false;
			tokenCheck.tokensAmount = (int)AddTokensAmount((ulong)tokenCheck.tokensAmount);
			if (tokenCheck.tokensAmount == 0)
			{
				tokenCheck.Consume();
				return true;
			}
			return false;
		}
#else
		public bool AddTokensPile(object tokens) { return false; }
		public bool AddTokenCheck(object tokenCheck) { return false; }
#endif
		public ulong AddTokensAmount(ulong amount)
		{
			if ( !TokenLedger )
				return amount;
			ulong max = ulong.MaxValue - TokensAmount;
			if (max > amount)
			{
				TokensAmount += amount;
				return (ulong)0;
			}
			TokensAmount += max;
			amount -= max;
			return amount;
		}

		internal bool withdrawGold(PlayerMobile player, ulong amount, bool intoGoldCheck)
		{
			if ( !IsOwner(player) )
				return false;
			
			if ( !GoldLedger )
				return false;
			
			if (amount > GoldAmount)
				amount = GoldAmount;
			if (amount > int.MaxValue)
				amount = int.MaxValue;
			if (intoGoldCheck)
			{
				if (player.AddToBackpack(new BankCheck((int)amount)))
				{
					GoldAmount -= amount;
					return true;
				}
			}
			else
			{
				while (amount > 0)
				{
					if (amount > 60000 && player.AddToBackpack(new Gold(60000)))
					{
						amount -= 60000;
						GoldAmount -= 60000;
					}
					else if (amount < 60000)
					{
						if (player.AddToBackpack(new Gold((int)amount)))
						{
							GoldAmount -= amount;
							return true;
						}
						else
							return false;
					}
					else
						return false;
				}
			}
			return false;
		}

		internal bool withdrawTokens(PlayerMobile player, ulong amount, bool intoTokensCheck)
		{
#if USE_TOKENS
			if ( !IsOwner(player) )
				return false;
			if ( !TokenLedger )
				return false;
			if (amount > TokensAmount)
				amount = TokensAmount;
			if (amount > int.MaxValue)
				amount = int.MaxValue;
			if (intoTokensCheck)
			{
				if (player.AddToBackpack(new TokenCheck((int)amount)))
				{
					TokensAmount -= amount;
					return true;
				}
			}
			else
			{
				while (amount > 0)
				{
					if (amount > 60000 && player.AddToBackpack(new Daat99Tokens(60000)))
					{
						amount -= 60000;
						TokensAmount -= 60000;
					}
					else if (amount < 60000)
					{
						if (player.AddToBackpack(new Daat99Tokens((int)amount)))
						{
							TokensAmount -= amount;
							return true;
						}
						else
							return false;
					}
					else
						return false;
				}
			}
#endif
			return false;
		}
	
		private bool isContainerLootable(PlayerMobile player, Container container)
		{
			if (container.Movable || container.Deleted || container.IsAccessibleTo(player) )
				return false;
			if (container is Corpse)
				return isCorpseLootable(player, (Corpse)container);
			return true;
		}
		
		private bool isCorpseLootable(PlayerMobile player, Corpse corpse)
		{
			if ( corpse.Owner == null || corpse.Deleted || corpse.Owner is PlayerMobile 
				|| (corpse.Owner is BaseCreature && ((BaseCreature)corpse.Owner).IsBonded) 
				|| !Daat99MasterLootersUtils.CheckLoot(corpse, player) || corpse.IsCriminalAction(player)
				)
					return false;
			return true;
		}
		
		public Type[] GetTypesForPage( int page )
		{
			Type[] types =  new Type[10];
			int index = page*10;
			if ( index < 0 || index > TypesCount )
				return types;
			int added = 0;
			if ( index < activeBaseTypes.Count )
			{
				while ( added < 10 && index < activeBaseTypes.Count)
					types[added++] = activeBaseTypes[index++];
			}
			index -= activeBaseTypes.Count;
			while ( added < 10 && index < activeLootTypes.Count)
				types[added++] = activeLootTypes[index++];
			return types;
		}
		
		public bool IsOwner(PlayerMobile player)
		{
			if (player == null || this.Deleted || !IsChildOf( player.Backpack ))
				return false;
			if ( Owner == 0 )
			{
				Name = player.Name + "'s " + DefaultLooterName;
				Owner = player.Serial;
			}
			if ( Owner != player.Serial )
			{
				player.SendMessage("This isn't yours!");
				return false;
			}
			return true;
		}
		
		public void NextLootSettings()
		{
			switch ( lootSettings )
			{
				case LootSettingsEnum.Currency_Only:
					lootSettings = LootSettingsEnum.Everything;
					break;
				case LootSettingsEnum.Everything:
					lootSettings = LootSettingsEnum.From_List;
					break;
				default:
				case LootSettingsEnum.From_List:
					lootSettings = LootSettingsEnum.Currency_Only;
					break;
			}
		}
	}   
}

