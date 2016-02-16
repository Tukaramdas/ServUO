using System; 
using Server; 
using Server.Commands;
using Server.Gumps; 
using Server.Network;
using Server.Items;
using Server.Mobiles;

namespace Server.Gumps
{ 
   public class VacarJamesGump : Gump 
   { 
      public static void Initialize() 
      { 
         CommandSystem.Register( "VacarJamesGump", AccessLevel.GameMaster, new CommandEventHandler( VacarJamesGump_OnCommand ) ); 
      } 

      private static void VacarJamesGump_OnCommand( CommandEventArgs e ) 
      { 
         e.Mobile.SendGump( new VacarJamesGump( e.Mobile ) ); 
      } 

      public VacarJamesGump( Mobile owner ) : base( 50,50 ) 
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
			AddLabel( 140, 60, 0x34, "The Fair Elain" );
			

			AddHtml( 107, 140, 300, 230, "<BODY>" +
//----------------------/----------------------------------------------/
"<BASEFONT COLOR=YELLOW>This is all crap! Oh, hello. Yes,<BR>I suppose you want me to write a love<BR>letter for your fair Elain. No? Not<BR>you? Then for who?<BR><BR>" +
"<BASEFONT COLOR=YELLOW>Alecsander? It's too bad I'm already<BR>writing one for Erik Sullivan. You<BR>need to talk to him before I can<BR>change the order. Now off with you.<BR><BR>" +
"<BASEFONT COLOR=YELLOW>Hm? Oh, you can find Erik at the West<BR>gate to the city. <BR>He's one of the guards." +

						     "</BODY>", false, true);
			
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

			AddButton( 225, 390, 0xF7, 0xF8, 0, GumpButtonType.Reply, 0 ); 

//--------------------------------------------------------------------------------------------------------------
      } 

      public override void OnResponse( NetState state, RelayInfo info ) //Function for GumpButtonType.Reply Buttons 
      { 
         Mobile from = state.Mobile; 

         switch ( info.ButtonID ) 
         { 
            case 0: //Case uses the ActionIDs defenied above. Case 0 defenies the actions for the button with the action id 0 
            { 
               //Cancel 
               from.SendMessage( "This is all crap!" );
               break; 
            } 

         }
      }
   }
}
