using System;
using Server;
using Server.Gumps;
using Server.Network;
using Server.Items;
using Server.Mobiles;

namespace Server
{
    public class SantasBookGump : Gump
    {
        public SantasBookGump()
            : base(50, 50)
        {
            this.Closable = true;
            this.Disposable = true;
            this.Dragable = true;
            this.Resizable = false;
            AddPage(0);
            AddImageTiled(14, 10, 377, 433, 2524);
            AddImageTiled(14, 425, 379, 18, 3501);
            AddImage(14, 18, 2712, 37);
            AddImage(14, 220, 2712, 37);
            AddTextEntry(120, 44, 167, 25, 33, 0, @"Holiday Helper Quest");
            AddHtml(35, 83, 346, 281, @"<BODY><BASEFONT COLOR=#B3FFE8>
Find and tame each of the Reindeer and return them to Santa. Just say 'Santa' to get his attention. He will reward your efforts as will his lost reindeer. 
You must find: Rudolph, Dasher, Dancer, Prancer, Vixen. Comet, Cupid, Donner, and Blitzen. Bring each safely back to Santa. 
Collect all the Reindeer Shoes, as well as the Special Hammer. Double clickthe hammer with all the shoes in your backpack to make Santa's Gift. Take the gift you have made and bring it to Santa.  
Have fun and may your Holidays be filled with happiness! - Santa's Elves
</BODY>", (bool)false, (bool)true);

            AddImageTiled(14, 7, 379, 18, 3501);
            AddItem(44, 17, 14943);
            AddItem(311, 17, 14951);
            AddItem(61, 361, 14983);
            AddItem(79, 357, 14984);

            AddButton(163, 385, 247, 248, 0, GumpButtonType.Reply, 0);

        }


        public override void OnResponse(NetState sender, RelayInfo info)
        {
            Mobile from = sender.Mobile;

            switch (info.ButtonID)
            {
                case 0:
                    {
                        break;
                    }

            }
        }
    }
}
