using System;
using Server;
using Server.Gumps;
using Server.Network;
using Server.Items;
using Server.Mobiles;

namespace Server
{
    public class RulesGump : Gump
    {
        public RulesGump()
            : base(0, 0)
        {
            this.Closable = true;
            this.Disposable = true;
            this.Dragable = true;
            this.Resizable = false;
            this.AddPage(0);
            this.AddBackground(154, 66, 499, 479, 5120);
            this.AddImageTiled(165, 76, 477, 459, 2624);
            this.AddPage(1);
            this.AddLabel(313, 84, 67, @"Welcome to Tito Tim's");
            this.AddAlphaRegion(175, 109, 456, 475);
            this.AddHtml(175, 110, 456, 38, @"<BODY><BASEFONT COLOR=#B3FFE8><u>Before you get started we would like to describe some of the toys you have in your backpack, and some game commands.</BODY>", (bool)false, (bool)false);
            this.AddHtml(178, 158, 450, 328, @"<BODY><BASEFONT COLOR=#B3FFE8>
1-) ATLAS The World Travel Atlas looks like a regular rune book but acts almost like a moongate. Open the book and see all the options of where to go!  <br>
2-) LOOT The command for the loot system is [Loot.  If you single click the MasterLootBackpack you can set options for what, and how, it loots. (Right click it in EC). If a critter has special loot, say for a quest, it is recommended you loot it by hand before using the loot command - just in case :) <br>
3-) TOKENS The Trash4TokensBackpack is a trash bag with a 3 minute timer.  It will give Tokens for some items.  No telling how much.  It will not give Tokens for any stackable items - but will delete them!  <br>
4-) SKILLBALL The skillball will let you choose 7 skills to GM. You may consider GM'ing tedious, or expensive, skills (hiding, lockpick, fishing, magery, taming etc). It does not reset any other skills to zero, so you can keep what you earned.<br>
5-) BANKSTONE You got a bankstone for bank access at home. Simply stand where you want to place the stone and double click the deed. If you double click the stone it will re-deed. You can interact with the bank stone as you would a banker. <br>
6-) SPELLBAR Use the command [Spellbar to get your spell icons setup. You must have the spellbook in your main bag for it to be found. Better to use the Enhanced Client for the hotbars, though. :)  <br>
7-) TOOLBAR Use the command [ShowTool to get a very handy toolbar. <br>
8-) TURN BACK TO DEED You can use the [TurnBackToDeed command instead of an axe to redeed a household item. <br>
9-) CHANGE HAIR STYLE You can use the [ChangeHairStyle command to change your hair or beard, for a small fee. <br>
10-) HEAL For bandaging there are 2 commands [Band and [BandSelf <br>
11-) BOATING If you no longer have your Sea Navigator you can use the [BoatControl command to get a pop up gump to control your boat.<br>
12-) RECALL There is a [Recall command that will automaically take you to Tito Tim's Casino. Good for getting away for a break.<br>
Please Enjoy your stay.

</BODY>", (bool)false, (bool)true);
            this.AddLabel(182, 502, 37, @"http://tukaram.net/ultima.htm");
            this.AddImage(105, 42, 10400);
            this.AddImage(619, 449, 10412);
            this.AddButton(584, 499, 2152, 2153, (int)Buttons.Button1, GumpButtonType.Reply, 0);
            this.AddLabel(538, 503, 67, @"Close");

        }

        public enum Buttons
        {
            Button1,
        }
    }
}
