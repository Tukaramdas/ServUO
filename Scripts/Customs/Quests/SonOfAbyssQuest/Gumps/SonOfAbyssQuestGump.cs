/////////// Scripted By TALON NYTE ///////////

using System;
using Server;
using Server.Gumps;
using Server.Network;
using Server.Items;
using Server.Mobiles;
using Server.Commands;

namespace Server.Gumps
{
	public class SonOfAbyssQuestGump : Gump
	{
		public static void Initialize()
		{
            CommandSystem.Register("SonOfAbyssQuestGump", AccessLevel.GameMaster, new CommandEventHandler(SonOfAbyssQuestGump_OnCommand));
		}

		private static void SonOfAbyssQuestGump_OnCommand(CommandEventArgs e)
		{
			e.Mobile.SendGump(new SonOfAbyssQuestGump(e.Mobile));
		}

		public SonOfAbyssQuestGump(Mobile owner) : base(50, 50)
		{
			AddPage(0);
			AddImageTiled(54, 33, 369, 400, 2624);
			AddAlphaRegion(54, 33, 369, 400);
            		AddImageTiled(416, 39, 44, 389, 203);
			AddImage(97, 49, 9005);
			AddImageTiled(58, 39, 29, 390, 10460);
			AddImageTiled(412, 37, 31, 389, 10460);
            AddBackground(85, 30, 329, 408, 3500);
			AddLabel(140, 60, 0x34, "Halo Quest");
			AddHtml(107, 140, 300, 230, "<BODY>" +
                "<BASEFONT COLOR=YELLOW><I>*Lord Onyx Looks up at you and says*<BR><BR>" +
                "<BASEFONT COLOR=YELLOW>Please my armor was stolen by the Son Of Abyss." +
                "<BASEFONT COLOR=YELLOW>I need your help. If you can find him, and kill him for me before he destroys my lifes work!" +
                "<BASEFONT COLOR=YELLOW> He will be very hard to kill and may attack you on sight so you must take caution." +
                "<BASEFONT COLOR=YELLOW> My lifes work can be redone with the help of one thing, a 'Regeneration Crystal'.<BR><BR>" +
                "<BASEFONT COLOR=YELLOW>To obtain the 'Regeneration Crystal' seek out the Son Of Abyss and kill him." +
                "<BASEFONT COLOR=YELLOW> Bring me 1 'Regeneration Crystal' and I will craft you one piece of my armor.<BR><BR>" +
                "<BASEFONT COLOR=YELLOW>It is said that he hides in the Gypsy Camp South of Minoc. He does have the power of resurrection, " +
                "<BASEFONT COLOR=YELLOW>so each time you kill him I will craft you another piece of my amazing armor." +
			    "</BODY>", false, true);

			AddImage(430, 9, 10441);
			AddImageTiled(40, 38, 17, 391, 9263);
			AddImage(6, 25, 10421);
			AddImage(34, 12, 10420);
            		AddImageTiled(94, 25, 342, 15, 10304);
            		AddImageTiled(40, 427, 415, 16, 10304);
            		AddImage(-10, 314, 10402);
            		AddImage(56, 150, 10411);
            		AddImage(155, 120, 2103);
            		AddImage(136, 84, 96);
            
            AddButton(225, 390, 0xF7, 0xF8, 0, GumpButtonType.Reply, 0);
		}

		public override void OnResponse(NetState state, RelayInfo info)
		{
			Mobile from = state.Mobile;

			switch ( info.ButtonID )
			{
				case 0:
				{
					//Cancel
					from.SendMessage("BE CAREFUL!");
					break;
				}
			}
		}
	}
}
