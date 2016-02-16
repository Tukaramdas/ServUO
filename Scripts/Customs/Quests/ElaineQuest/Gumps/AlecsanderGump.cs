using System; 
using Server; 
using Server.Commands;
using Server.Gumps; 
using Server.Network;
using Server.Items;
using Server.Mobiles;

namespace Server.Gumps
{ 
   public class AlecsanderGump : Gump 
   { 
      public static void Initialize() 
      { 
         CommandSystem.Register( "AlecsanderGump", AccessLevel.GameMaster, new CommandEventHandler( AlecsanderGump_OnCommand ) ); 
      } 

      private static void AlecsanderGump_OnCommand( CommandEventArgs e ) 
      { 
         e.Mobile.SendGump( new AlecsanderGump( e.Mobile ) ); 
      } 

      public AlecsanderGump( Mobile owner ) : base( 50,50 ) 
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
"<BASEFONT COLOR=YELLOW>Oh! Oh. You're not Elain. No, 'tis<BR>alright. I need a love letter from<BR>the great poet, Vacar James, to win<BR>the heart of my fair Elain.<BR><BR>" +
"<BASEFONT COLOR=YELLOW>If you bring me a love letter written<BR>by the poet, I'll hand over an item<BR>that's been in my family for<BR>generations.<BR><BR>" +
"<BASEFONT COLOR=YELLOW>Thank you, my friend, and good travels. Vacar is in the Inn...working..." +

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
               from.SendMessage( "Between you and me, we will win the love of my fair Elain!" );
               break; 
            } 

         }
      }
   }
}
