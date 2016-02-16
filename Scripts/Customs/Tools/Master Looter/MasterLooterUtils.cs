#define RunUO2_2
#define USE_TOKENS

using System;
using Server;
using Server.Mobiles;
using Server.Items;
using Daat99MasterLooterSystem;
using System.Collections.Generic;
using Server.Commands;

namespace Daat99MasterLooterSystem
{
    public static class Daat99MasterLootersUtils
    {
		//defaults types to loot
		//When editing this make sure you don't include types that have inheritance links
		public static Type[] DefaultBaseTypes = 
		{ 
			typeof(BaseReagent),		typeof(BaseWeapon), 		typeof(BaseArmor), 			typeof(BaseJewel),
			typeof(BaseContainer),		typeof(SpellScroll),		typeof(BaseInstrument), 	typeof(BasePotion),
			typeof(BaseTool),			typeof(BaseHarvestTool), 	typeof(ICommodity),			typeof(MapItem),
			typeof(BaseAddon),			typeof(BaseGranite)
		};
		
		//default items to loot
		//When editing this make sure you don't add items that inherits from one of the types in the DefaultBaseTypes list
		public static Type[] DefaultItemTypes = 
		{ 
			typeof(Amber), 			typeof(Amethyst), 	typeof(Citrine), 	typeof(Diamond), 
			typeof(Emerald), 		typeof(Ruby), 		typeof(Sapphire), 	typeof(StarSapphire), 
			typeof(Tourmaline), 	typeof(Board),		typeof(PowerScroll)
		};

		//This is the currency items types
		private static Type[] CurrencyTypes = 
		{ 
			typeof(Gold), 
			typeof(BankCheck), 
#if USE_TOKENS
			typeof(Daat99Tokens), 
			typeof(TokenCheck) 
#endif
		};
		
		public static bool IsCurrencyType( Type itemType )
		{
			foreach ( Type type in CurrencyTypes )
				if ( type == itemType )
					return true;
			return false;
		}
				
		private static Dictionary<Serial, MasterLooterBackpack> PlayersMasterLooterList = new Dictionary<Serial, MasterLooterBackpack>();

		private static void addToMasterLootersList(PlayerMobile player, MasterLooterBackpack bag)
		{
			if (bag == null)
				return;
			if (!Daat99MasterLootersUtils.PlayersMasterLooterList.ContainsKey(player.Serial))
				Daat99MasterLootersUtils.PlayersMasterLooterList.Add(player.Serial, bag);
		}

		public static void Initialize()
		{
#if RunUo2
            CommandSystem.Register("Loot", AccessLevel.Player, new CommandEventHandler(Loot_OnCommand));
#else
            CommandHandlers.Register( "Loot", AccessLevel.Player, new CommandEventHandler( Loot_OnCommand ) );
#endif
		}
		
		public static void Loot_OnCommand( CommandEventArgs e )
		{
			PlayerMobile player = e.Mobile as PlayerMobile;
			if (  player == null || !CanPlayerLoot(player) )
				return;
			MasterLooterBackpack backpack = GetMasterLooter(player);
			if ( backpack == null )
			{
				player.SendMessage("You must have a Master Looter in your backpack!");
				return;
			}
			if ( backpack.IsOwner(player) )
				backpack.Loot( player );
		}

		///WARNING!!! may return null!!!
		public static MasterLooterBackpack GetMasterLooter(PlayerMobile player)
		{
			if (player == null || player.Backpack == null)
				return null;
			Serial serial = player.Serial;
			MasterLooterBackpack bag = null;
			if (Daat99MasterLootersUtils.PlayersMasterLooterList.ContainsKey(serial))
			{
				bag = Daat99MasterLootersUtils.PlayersMasterLooterList[serial];
				if (bag.IsChildOf(player.Backpack) && !bag.Deleted)
					return bag;
				else
					Daat99MasterLootersUtils.PlayersMasterLooterList.Remove(serial);
			}
			bag = player.Backpack.FindItemByType(typeof(MasterLooterBackpack), false) as MasterLooterBackpack;
			if (bag != null && bag.Deleted)
				bag = null;
			if (bag != null && bag.IsOwner(player))
			{
				Daat99MasterLootersUtils.PlayersMasterLooterList.Add(serial, bag);
				return bag;
			}
			else
				return null;
		}
		
		public static bool CanPlayerLoot(PlayerMobile player)
		{
			if ( player.AccessLevel > AccessLevel.Player )
				return true;
			if ( !player.Alive )
			{
				player.PlaySound( 1069 ); //hey
				player.SendMessage( "You are dead!" );
				return false;
			}
			if ( player.Blessed )
			{
				player.PlaySound( 1069 ); //hey
				player.SendMessage( "You can't loot while you are invulnerable!");
				return false;
			}
			foreach ( Mobile other in player.GetMobilesInRange( 5 ) )
			{
				if ( ! ( other is PlayerMobile ) )
					continue;
				if ( player != other && !other.Hidden && other.AccessLevel == AccessLevel.Player )
				{
					player.PlaySound(1069); //hey
					player.SendMessage("You are too close to another player to do that!");
					return false; //ignore self, staff and hidden
				}
			}
			return true;
		}
		
		public static bool GivePlayerGold( PlayerMobile player, int amount )
		{
			return GivePlayerGold(player, amount, true);
		}
		public static bool GivePlayerGold( PlayerMobile player, int amount, bool informPlayer )
		{
			int amountLeft = amount;
			if ( amount < 0 )
				return false;
			MasterLooterBackpack backpack = GetMasterLooter(player);
			if ( backpack != null )
				amountLeft = (int)backpack.AddGoldAmount((ulong)amountLeft);
			while ( amountLeft > 0 )
			{
				int pileAmount = amountLeft>60000?60000:amountLeft;
				amountLeft -= pileAmount;
				Gold gold = new Gold(pileAmount);
				if ( !DropItemInBagOrFeet(player, backpack, gold) )
					return false;
			}
			if ( informPlayer )
				player.SendMessage(1173, "You recieved " + (amount-amountLeft) + " gold.");
			if ( amountLeft == 0 )
				return true;
			return false;
		}
		public static bool GivePlayerTokens( PlayerMobile player, int amount )
		{
			return GivePlayerTokens(player, amount, true);
		}
		public static bool GivePlayerTokens( PlayerMobile player, int amount, bool informPlayer )
		{
#if USE_TOKENS
			int amountLeft = amount;
			if ( amount < 0 )
				return false;
			MasterLooterBackpack backpack = GetMasterLooter(player);
			if ( backpack != null )
				amountLeft = (int)backpack.AddTokensAmount((ulong)amountLeft);
			while ( amountLeft > 0 )
			{
				int pileAmount = amountLeft>60000?60000:amountLeft;
				amountLeft -= pileAmount;
				Daat99Tokens tokens = new Daat99Tokens(pileAmount);
				if ( !DropItemInBagOrFeet(player, backpack, tokens) )
					return false;
			}
			if ( informPlayer )
				player.SendMessage(1173, "You recieved " + (amount-amountLeft) + " tokens.");
			if ( amountLeft == 0 )
				return true;
#endif
			return false;
		}
		
		public static bool DropItemInBagOrFeet(PlayerMobile player, MasterLooterBackpack backpack, Item item)
		{
			if ( player == null || item == null )
				return false;
			if ( backpack == null )
				backpack = GetMasterLooter(player);
			if ( backpack != null && backpack.TryDropItem(player, item, false) )
				return true;
			if ( player.Backpack != null && player.Backpack.TryDropItem(player, item, false) )
				return true;
			
			Map map = player.Map;
            if (map == null)
                return false;

            List<Item> atFeet = new List<Item>();
            foreach (Item obj in player.GetItemsInRange(0))
                atFeet.Add(obj);
            for (int i = 0; i < atFeet.Count; ++i)
            {
                Item check = atFeet[i];

                if (check.StackWith(player, item, false))
                    break;
            }
            item.MoveToWorld(player.Location, map);
			return true;
		}
		
		public static bool CheckLoot(Corpse corpse, PlayerMobile player)
		{
			#if RunUO2_2
				return corpse.CheckLoot(player, null);
			#else
				return corpse.CheckLoot(player);
			#endif
		}
	}
}