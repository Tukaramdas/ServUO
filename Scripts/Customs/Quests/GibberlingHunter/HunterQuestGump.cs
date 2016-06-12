using System;
using Server;
using Server.Mobiles;
using Server.Items;
using Server.Gumps;
using Server.Network;

namespace Server.Gumps
{
    public class HunterQuestGump : Gump
    {

        public HunterQuestGump()
            : base(0, 0)
        {

            this.Closable = false;
            this.Disposable = false;
            this.Dragable = true;
            this.Resizable = false;
            this.AddPage(0);

            this.AddBackground(232, 113, 289, 364, 9250);
            this.AddLabel(332, 146, 0, @"Gibberling Hunter");
            // Quest text 
            this.AddHtml(252, 190, 250, 225, "< BODY > " +
                "Usually I have no trouble fighting the gibberling " +
                "by myself, but now that has changed.<BR><BR> " +
                "They are being organized by a queen, " +
                "The Gibberling Queen, she is the strongest " +
                "gibberling I have ever fought, I am lucky " +
                "to have escaped with my life! Hordes of " +
                "gibberling follow her into battle " +
                "like nothing I have ever seen. " +
                "<BR><BR> " +
                "I will reward you if you dispose of " +
                "this beast for me, just bring me her " +
                " head when you are done. She was last seen South" +
                " of Umbra in the desert, thru the mountain passage, " +
                "gathering more gibberling, may you survive " +
                "your task and live to reap the reward."+
                                             " </BODY> ", (bool)true, (bool)true);// Quest text
            this.AddImage(246, 124, 9004);
            this.AddImage(469, 124, 9004);
            this.AddImage(246, 431, 9005);
            this.AddButton(339, 421, 1149, 1148, 0, GumpButtonType.Reply, 0);
        }

        public override void OnResponse(NetState state, RelayInfo info)
        {
            Mobile from = state.Mobile;

            switch (info.ButtonID)
            {
                case 0: // Close/Cancel
                    {
                        break;
                    }
            }
        }
    }

}
