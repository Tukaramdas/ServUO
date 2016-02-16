using System; 
using Server; 
using Server.Commands;
using Server.Gumps; 
using Server.Network;
using Server.Items;
using Server.Mobiles;

namespace Server.Gumps
{ 
   public class AndoraGump : Gump 
   { 
      public static void Initialize() 
      { 
         CommandSystem.Register( "AndoraGump", AccessLevel.GameMaster, new CommandEventHandler( AndoraGump_OnCommand ) ); 
      } 

      private static void AndoraGump_OnCommand( CommandEventArgs e ) 
      { 
         e.Mobile.SendGump( new AndoraGump( e.Mobile ) ); 
      } 

      public AndoraGump( Mobile owner ) : base( 50,50 ) 
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
"<BASEFONT COLOR=YELLOW>My blade? Sorry, friend, but you're<BR>not getting it for free. I've been<BR>tracking the evil mage Acaras through<BR>the woods nearby, but I've been unable<BR>to find him.<BR><BR>" +
"<BASEFONT COLOR=YELLOW>If you bring back his ring as proof<BR>that he is dead, I'll consider letting <BR>you have the blade.<BR><BR>" +
"<BASEFONT COLOR=YELLOW>The mage known as Acaras is an evil<BR>man who summons monsters to do his<BR>bidding. Please stop him. He can<BR>be found in the woods South of here." +

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
               from.SendMessage( "Do not return until you have the evil mage's ring!" );
               break; 
            } 

         }
      }
   }
}
