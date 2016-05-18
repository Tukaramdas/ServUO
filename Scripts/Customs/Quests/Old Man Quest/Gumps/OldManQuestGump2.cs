using System; 
using Server; 
using Server.Gumps; 
using Server.Network;
using Server.Items;
using Server.Mobiles;
using System.Collections.Generic;
using Server.Commands;
using Server.ContextMenus;

namespace Server.Gumps
{ 
   public class OldManIceQuestGump2 : Gump 
   { 
      public static void Initialize() 
      {
          CommandSystem.Register("OldManIceQuestGump2", AccessLevel.GameMaster, new CommandEventHandler(OldManIceQuestGump2_OnCommand)); 
      } 

      private static void OldManIceQuestGump2_OnCommand( CommandEventArgs e ) 
      { 
         e.Mobile.SendGump( new OldManIceQuestGump2( e.Mobile ) ); 
      } 

      public OldManIceQuestGump2( Mobile owner ) : base( 50,50 ) 
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
			AddLabel( 140, 60, 0x34, "The Old man Ice-God" );
			

			AddHtml( 107, 140, 300, 230, "<BODY>" +
//----------------------/----------------------------------------------/
"<BASEFONT COLOR=YELLOW><I>Ice-God Looks up at you</I><BR><BR>Thank you for helping such an old man.<BR><BR>" +
"<BASEFONT COLOR=YELLOW>I cannot thank you enough. I shall endow you with one of my powerful weapons<BR><BR><I>Ice-God hands over his Frozen Sword of Terror</I><BR><BR>" +
"<BASEFONT COLOR=YELLOW>It was a great sword in it's day. Mabye polish it up and make it look good again?" +
"<BASEFONT COLOR=YELLOW> I just can't handle it anymore<BR><BR> And don't forget to come help me again ya hear?" +						     
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
               from.SendMessage( "Thanks again for the Old man Wrinkle Cream" );
               break; 
            } 

         }
      }
   }
}