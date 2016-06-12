using System;
using Server;
using Server.Gumps;
using Server.Network;
using Server.Items;
using Server.Mobiles;

namespace Server
{
    public class LordSantasBookGump : Gump
    {
        public LordSantasBookGump()
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
            AddTextEntry(120, 44, 167, 25, 33, 0, @"Yellow Snow Quest");
            AddHtml(35, 83, 346, 281, @"<BODY><BASEFONT COLOR=#B3FFE8>
Ok I need you to find those kids that are making yellow snow beat them up and bring back the yellow as proof. 
Don't fail me if you bring back 10  yellow snows you will be given the best armor and clothes that Santa's little helpers can make. 
Show me the meaning Of haste. 
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
