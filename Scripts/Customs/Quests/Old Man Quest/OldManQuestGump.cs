using System; 
using Server; 
using Server.Gumps; 
using Server.Network;
using Server.Items;
using Server.Mobiles;
using Server.Commands;
using System.Collections.Generic;
using Server.ContextMenus;


namespace Server.Gumps
{ 
   public class OldManIceQuestGump : Gump 
   { 
      public static void Initialize() 
      {
          CommandSystem.Register("OldManIceQuestGump", AccessLevel.GameMaster, new CommandEventHandler(OldManIceQuestGump_OnCommand)); 
      } 

      private static void OldManIceQuestGump_OnCommand( CommandEventArgs e ) 
      { 
         e.Mobile.SendGump( new OldManIceQuestGump( e.Mobile ) ); 
      } 

      public OldManIceQuestGump( Mobile owner ) : base( 50,50 ) 
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
			AddLabel( 140, 60, 0x34, "The Old Man Ice-God" );
			

			AddHtml( 107, 140, 300, 230, "<BODY>" +
//----------------------/----------------------------------------------/
"<BASEFONT COLOR=YELLOW><I>Ice-God the Eldest of them All looks up at you with his wrinkled face</I><BR><BR>Please Don't hurt me, you wouldent hurt an old man would ya?<BR><BR>" +
"<BASEFONT COLOR=YELLOW>Oh, oh you're here to help me! Well thats splended news!<BR><BR>" +
"<BASEFONT COLOR=YELLOW>What I need yee to do is travel thru the Vallys Search High and low and perheps you will find ye old Demon he's wrinkle free, you know <I>*Smiles*</I> Then kill him and kill them all until you can get enough wrinkle free powder!" +
"<BASEFONT COLOR=YELLOW>Then I need you to go to me old trusty vendor and buy me some Moisturizer<BR><BR>Then you fill up the jar! And mix them together and bring it back to me For a Great Reward!" +
 
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
               from.SendMessage( "Get Winkle Free Powder and Moisturizer and bring it back to Ice-God" );
               break; 
            } 

         }
      }
   }
}