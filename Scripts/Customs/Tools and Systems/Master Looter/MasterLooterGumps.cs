#define USE_TOKENS
using System;
using Server;
using Server.Items;
using Server.Gumps;
using Server.Network;
using Server.Commands;
using Server.Mobiles;

namespace Daat99MasterLooterSystem
{
    public class MasterLooterSetupGump : Gump
    {
		public static void SendGump(Mobile from, MasterLooterBackpack backpack, int page)
		{
			CloseGump(from);
			if ( backpack == null || backpack.Deleted || !backpack.IsOwner(from as PlayerMobile))
				return;
			from.SendGump(new MasterLooterSetupGump(backpack, page));
		}
		public static void CloseGump(Mobile from)
		{
			if (from.HasGump(typeof(MasterLooterSetupGump)))
				from.CloseGump(typeof(MasterLooterSetupGump));
		}
		private static readonly int LINE_HEIGHT=25;

		int lineIndex;
		MasterLooterBackpack backpack;
		int page;
		Type[] types;
		enum BUTTONS_ENUM 
		{ 
			OK = 0, 			PREVIOUS_PAGE, 		NEXT_PAGE, 				ADD_ITEM, 
			ADD_TYPE, 			LOOT_SETTINGS, 		DELETE_ALL_CORPSES, 	RESTORE_DEFAULTS,
			SWITCH_ACTIVE_LIST,
			REMOVE_TYPE_START=100 
		};

        public MasterLooterSetupGump(MasterLooterBackpack backpack) 
			: this( backpack, 0) { }

        public MasterLooterSetupGump(MasterLooterBackpack backpack, int page) : base(20, 20)
        {
			this.backpack = backpack;
			this.page = page;
			int typesCount = backpack.TypesCount;
			int lastPage = typesCount/10;
			if ( lastPage*11 == typesCount && lastPage > 0 )
				--lastPage;
			if ( this.page == -1 || this.page > lastPage ) //last page
				this.page = lastPage;
			if ( this.page < 0 )
				this.page = 0;
			
			initialize(); 
			addTop(typesCount);
			addAddSettingsSection();
			addTypesPage();
			addPageControls();
        }

		private void initialize()
		{
			Closable = true;
            Disposable = true;
            Dragable = true;
            Resizable = false;
			lineIndex = 1;
            AddPage(0);
			types = backpack.GetTypesForPage(page);
		}
		
		private void addTop( int typesCount )
		{
			int itemsCount = typesCount-page*10;
			if ( itemsCount > 10 )
				itemsCount = 10;
			AddBackground(0, 0, 220, (11+itemsCount)*LINE_HEIGHT, 5120);
		}
		private void addTypesPage()
		{
			AddImage( 25, (lineIndex*LINE_HEIGHT), 57);
            AddLabel( 70, (lineIndex*LINE_HEIGHT), 48, @"Loot Selector");
            AddImage(175, (lineIndex*LINE_HEIGHT), 59);
			++lineIndex;
			for ( int i = 0; i < types.Length; ++i )
			{
				if ( types[i] == null )
					return;
			//	AddButton(25, (lineIndex*LINE_HEIGHT), 5409, 5408, (int)BUTTONS_ENUM.REMOVE_TYPE_START+i, GumpButtonType.Reply, 0);
            //testing button
                AddButton(23, (lineIndex * LINE_HEIGHT), 1210, 1209, (int)BUTTONS_ENUM.REMOVE_TYPE_START + i, GumpButtonType.Reply, 0);
                AddLabel(50, (lineIndex * LINE_HEIGHT), 60, "Remove-");
            //end test
				string typeName = types[i].ToString();
				int dotIndex = typeName.LastIndexOf(".");
				if ( dotIndex >= 0 )
					typeName = typeName.Substring(dotIndex+1);
				AddLabel(104, (lineIndex*LINE_HEIGHT), 60, typeName);
				++lineIndex;
			}
		}
		private void addAddSettingsSection()
		{
		    AddImage( 23, (lineIndex*LINE_HEIGHT), 57);
            AddLabel( 70, (lineIndex*LINE_HEIGHT), 48, "Add More Items");
            AddImage(175, (lineIndex*LINE_HEIGHT), 59);
			++lineIndex;
            AddButton(23, (lineIndex*LINE_HEIGHT), 1210, 1209, (int)BUTTONS_ENUM.ADD_ITEM, GumpButtonType.Reply, 0);
            AddLabel( 50, (lineIndex*LINE_HEIGHT), 60, "Add Single Item");
			++lineIndex;
            AddButton(23, (lineIndex*LINE_HEIGHT), 1210, 1209, (int)BUTTONS_ENUM.ADD_TYPE, GumpButtonType.Reply, 0);
            AddLabel( 50, (lineIndex*LINE_HEIGHT), 60, "Add Items Common Type");
			++lineIndex;
			AddButton(23, (lineIndex*LINE_HEIGHT), 1210, 1209, (int)BUTTONS_ENUM.LOOT_SETTINGS, GumpButtonType.Reply, 0);
			AddLabel( 50, (lineIndex*LINE_HEIGHT), 60, "Looting: "  + backpack.LootSettingsString);
			++lineIndex;
			AddButton(23, (lineIndex*LINE_HEIGHT), 1210, 1209, (int)BUTTONS_ENUM.DELETE_ALL_CORPSES, GumpButtonType.Reply, 0);
			AddLabel( 50, (lineIndex*LINE_HEIGHT), 60, "Deleting: "  + (backpack.DeleteAllCorpses? "All Corpses": "Empty Corpses"));
			++lineIndex;
			AddButton(23, (lineIndex*LINE_HEIGHT), 1210, 1209, (int)BUTTONS_ENUM.SWITCH_ACTIVE_LIST, GumpButtonType.Reply, 0);
			AddLabel( 50, (lineIndex*LINE_HEIGHT), 60, "Active List: "  + backpack.ActiveListName );
			++lineIndex;
			AddButton(80, (lineIndex*LINE_HEIGHT), 0xF5, 0xF4, (int)BUTTONS_ENUM.RESTORE_DEFAULTS, GumpButtonType.Reply, 0);
			++lineIndex;
		}
		private void addPageControls()
		{
			if ( page > 0 )
				AddButton( 23, (lineIndex*LINE_HEIGHT), 4014, 4016, (int)BUTTONS_ENUM.PREVIOUS_PAGE, GumpButtonType.Reply, 0 );
		
			AddLabel( 90, (lineIndex*LINE_HEIGHT), 48, "Page: " + (page+1));
			
			if ( backpack.TypesCount > page*10 + 10 )
				AddButton( 175, (lineIndex*LINE_HEIGHT), 4005, 4007, (int)BUTTONS_ENUM.NEXT_PAGE, GumpButtonType.Reply, 0 );
			++lineIndex;
		}
        public override void OnResponse(NetState sender, RelayInfo info)
        {
            Mobile from = sender.Mobile;
			CloseGump(from);
            PlayerMobile player = from as PlayerMobile;
			if ( player == null )
				return;
			switch (info.ButtonID)
            {
				case (int)BUTTONS_ENUM.OK:
					//don't send new gump
					break;
				case (int)BUTTONS_ENUM.ADD_ITEM:
					player.Target = new MasterLooterAddTypeTarget(backpack, player, MasterLooterAddTypeTarget.SELECTION.ITEM_SELECTION);
					break;
				case (int)BUTTONS_ENUM.ADD_TYPE:
					player.Target = new MasterLooterAddTypeTarget(backpack, player, MasterLooterAddTypeTarget.SELECTION.TYPE_SELECTION);
					break;
				case (int)BUTTONS_ENUM.PREVIOUS_PAGE:
					SendGump(from, backpack, page-1);
					break;
				case (int)BUTTONS_ENUM.NEXT_PAGE:
					SendGump(from, backpack, page+1);
					break;
				case (int)BUTTONS_ENUM.LOOT_SETTINGS:
					backpack.NextLootSettings();
					SendGump(from, backpack, page);
					break;
				case (int)BUTTONS_ENUM.DELETE_ALL_CORPSES:
					backpack.DeleteAllCorpses = !backpack.DeleteAllCorpses;
					SendGump(from, backpack, page);
					break;
				case (int)BUTTONS_ENUM.RESTORE_DEFAULTS:
					backpack.RestoreDefaultList();
					SendGump(from, backpack, page);
					break;
				case (int)BUTTONS_ENUM.SWITCH_ACTIVE_LIST:
					backpack.SwitchActiveList();
					SendGump(from, backpack, page);
					break;
				default:
					if ( info.ButtonID < (int)BUTTONS_ENUM.REMOVE_TYPE_START 
						|| info.ButtonID >= (int)BUTTONS_ENUM.REMOVE_TYPE_START+types.Length )
						return;
					backpack.RemoveType(types[info.ButtonID-(int)BUTTONS_ENUM.REMOVE_TYPE_START]);
					SendGump(from, backpack, page);
					break;
            }
        }
    }

	public class MasterLooterLedgerGump : Gump
    {
		public static void SendGump(Mobile from, MasterLooterBackpack backpack)
		{
			CloseGump(from);
			if ( backpack == null || backpack.Deleted || (!backpack.GoldLedger && !backpack.TokenLedger) || !backpack.IsOwner(from as PlayerMobile))
				return;
			from.SendGump(new MasterLooterLedgerGump(backpack));
		}
		public static void CloseGump(Mobile from)
		{
			if (from.HasGump(typeof(MasterLooterLedgerGump)))
				from.CloseGump(typeof(MasterLooterLedgerGump));
		}
		
		private static readonly int LINE_HEIGHT=25;

		int lineIndex;
        MasterLooterBackpack backpack;
		enum BUTTONS { OK = 0, AMOUNT, ADD, FILL, TOKENS, TOKENS_CHECK, GOLD, GOLD_CHECK };

		public MasterLooterLedgerGump( MasterLooterBackpack backpack ) : base( 50, 50 )
		{
			this.backpack  = backpack;
			this.Closable=true;
			this.Disposable=true;
			this.Dragable=true;
			this.Resizable=false;
			this.AddPage(0);
			bool gold = backpack.GoldLedger;
			bool token = backpack.TokenLedger;
			int totalLines = 7 + (gold?2:0) + (token?2:0);
			int offset = 0;
			this.AddBackground(0, 0, 350, 75+25*totalLines, 5170);
			
			this.AddLabel(120, 25, 69, "Account information");
			
			if ( gold )
			{
				this.AddLabel(25, 50, 69, "You have " + backpack.GoldAmount + " gold.");
				offset += 25;
			}
			if ( token )
			{
				this.AddLabel(25, 50+offset, 88, "You have " + backpack.TokensAmount + " tokens.");
				offset += 25;
			}
			
			this.AddLabel(  25, 50+offset, 32, "Add Currency:");
			this.AddButton(180, 50+offset, 2443, 2444, (int)BUTTONS.ADD, GumpButtonType.Reply, 0);
			this.AddLabel( 190, 50+offset, 0, "Add Pile");
			this.AddButton(255, 50+offset, 2443, 2444, (int)BUTTONS.FILL, GumpButtonType.Reply, 0);
			this.AddLabel( 265, 50+offset, 0, "Add All");

			this.AddLabel(25, 98+offset, 0, @"How much to withdraw?");
			this.AddBackground(170, 85+offset, 150, 50, 9270);
			this.AddTextEntry(180, 98+offset, 130, 25, 39, (int)BUTTONS.AMOUNT, "");
			
			if ( gold )
			{
				this.AddButton( 25, 145+offset, 4027, 4028, (int)BUTTONS.GOLD, GumpButtonType.Reply, 0);
				this.AddLabel(  65, 145+offset, 69, "Gold Pile");
				this.AddButton(195, 145+offset, 4012, 4013, (int)BUTTONS.GOLD_CHECK, GumpButtonType.Reply, 0);
				this.AddLabel( 235, 145+offset, 69, "Gold Check");
				offset += 25;
			}
			if ( token )
			{
				this.AddButton( 25, 145+offset, 4027, 4028, (int)BUTTONS.TOKENS, GumpButtonType.Reply, 0);
				this.AddLabel(  65, 145+offset, 69, "Tokens Pile");
				this.AddButton(195, 145+offset, 4012, 4013, (int)BUTTONS.TOKENS_CHECK, GumpButtonType.Reply, 0);
				this.AddLabel( 235, 145+offset, 69, "Tokens Check");
				offset += 25;
			}
			
			this.AddImage(25, 150+offset, 7012);
			this.AddImage(250, 150+offset, 7012);
			this.AddLabel(150, 160+offset, 38, "Daat99's");
			this.AddLabel(130, 185+offset, 38, "Master Looter");
		}
		public override void OnResponse( NetState state, RelayInfo info )
		{
			Mobile from = state.Mobile;
			if ( info.ButtonID == (int)BUTTONS.OK || backpack.Deleted || !(from is PlayerMobile) )
			{
				CloseGump(from);
				return;
			}
			if ( info.ButtonID == (int)BUTTONS.ADD )
			{
				from.Target = new MasterLooterAddCurrencyTarget(from, backpack);
				return;
			}
			else if ( info.ButtonID == (int)BUTTONS.FILL )
				backpack.AddCurrencyFromBackpack(from as PlayerMobile);
			else
			{
				TextRelay amountRelay = info.GetTextEntry( (int)BUTTONS.AMOUNT );
				if ( amountRelay != null )
				{
					ulong amount = 0;
					try
					{
						int iAmount = Convert.ToInt32(amountRelay.Text, 10);
						if ( iAmount > 0 )
							amount = (ulong)iAmount;
					}
					catch { }
					if ( amount > 0 )
					{
						if ( info.ButtonID == (int)BUTTONS.GOLD && amount <= 60000 && amount <= backpack.GoldAmount )
						{
							backpack.GoldAmount -= amount;
							from.AddToBackpack( new Gold((int)amount) );
							from.SendMessage(1173, "You extracted {0} gold from your Master Looter Backpack.", amount);
						}
						else if ( info.ButtonID == (int)BUTTONS.GOLD_CHECK && amount <= 1000000 && amount <= backpack.GoldAmount )
						{
							backpack.GoldAmount -= amount;
							from.AddToBackpack( new BankCheck((int)amount) );
							from.SendMessage(1173, "You extracted {0} gold from your Master Looter Backpack.", amount);
						}
#if USE_TOKENS
						else if ( info.ButtonID == (int)BUTTONS.TOKENS && amount <= 60000 && amount <= backpack.TokensAmount )
						{
							backpack.TokensAmount -= amount;
							from.AddToBackpack( new Daat99Tokens((int)amount) );
							from.SendMessage(1173, "You extracted {0} tokens from your Master Looter Backpack.", amount);
						}
						else if ( info.ButtonID == (int)BUTTONS.TOKENS_CHECK && amount <= 1000000 && amount <= backpack.TokensAmount )
						{
							backpack.TokensAmount -= amount;
							from.AddToBackpack( new TokenCheck((int)amount) );
							from.SendMessage(1173, "You extracted {0} tokens from your Master Looter Backpack.", amount);
						}
#endif
						else
							from.SendMessage(1173, "You can't extract that.");
					}
				}
			}
			SendGump(from, backpack);
		}
    }	
}