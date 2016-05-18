using System;
using Server;
using Server.Commands;
using Server.Gumps;
using Server.Network;
using Server.Items;
using Server.Mobiles;

namespace Server.Gumps
{ public class CrystalQuestGump : Gump
    { 
public static void Initialize()
        { 
CommandSystem.Register( "CrystalQuestGump", AccessLevel.GameMaster, new CommandEventHandler( CrystalQuestGump_OnCommand ) ); 
}
private static void CrystalQuestGump_OnCommand( CommandEventArgs e ) 
{
e.Mobile.SendGump( new CrystalQuestGump( e.Mobile ) );
        } 
public CrystalQuestGump( Mobile owner ) : base( 50,50 ) 
{
//----------------------------------------------------------------------------------------------------
AddPage( 0 );
            AddImageTiled(  54, 33, 369, 400, 2624 );
            AddAlphaRegion( 54, 33, 369, 400 );
            AddImageTiled( 416, 39, 44, 389, 203 );
//--------------------------------------Window size bar--------------------------------------------
AddImage( 97, 49, 9005 );
AddImageTiled( 58, 39, 29, 390, 10460 );
AddImageTiled( 412, 37, 31, 389, 10460 );
AddBackground(85, 30, 329, 408, 3500);
AddLabel( 140, 60, 0x34, "Please help" );
//----------------------/----------------------------------------------/
AddHtml( 107, 140, 300, 230, " < BODY > " + 
"<BASEFONT COLOR=YELLOW>I have lost my Crystal Crystal, could you<BR>" +
"<BASEFONT COLOR=YELLOW>help me?  <BR>" +
"<BASEFONT COLOR=YELLOW><BR>" +
"<BASEFONT COLOR=YELLOW>An imp stole my crystal crystal, I think <BR>" +
"<BASEFONT COLOR=YELLOW>they went to Honesty shrine. If you bring<BR>" +
"<BASEFONT COLOR=YELLOW>it to me I will reward you.<BR>" +
"<BASEFONT COLOR=YELLOW><BR>" +
"<BASEFONT COLOR=YELLOW>I do not have a lot of money...<BR>" +
"<BASEFONT COLOR=YELLOW>but I do have some good toys.<BR>" +
"<BASEFONT COLOR=YELLOW><BR>" +
"<BASEFONT COLOR=YELLOW>Once I get my crystal back I can<BR>" +
"<BASEFONT COLOR=YELLOW>continue crafting more magic items.<BR>" +
"<BASEFONT COLOR=YELLOW><BR>" +
"<BASEFONT COLOR=YELLOW><BR>" +
"</BODY>", false, true);
//----------------------/----------------------------------------------/
AddImage( 430, 9, 10441);
            AddImageTiled( 40, 38, 17, 391, 9263 );
            AddImage( 6, 25, 10421 );
            AddImage( 34, 12, 10420 );
            AddImageTiled( 94, 25, 342, 15, 10304 );
            AddImageTiled( 40, 427, 415, 16, 10304 );
            AddImage( -10, 314, 10402 );
            AddImage( 56, 150, 10411 );
            AddImage( 155, 120, 2103 );
            AddImage( 136, 84, 96 );
            AddButton( 225, 390, 0xF7, 0xF8, 0, GumpButtonType.Reply, 0 ); }
//----------------------/----------------------------------------------/
public override void OnResponse( NetState state, RelayInfo info ){ Mobile from = state.Mobile; switch ( info.ButtonID ) { case 0:{ break;
                    }
            }
        }
    }
}
