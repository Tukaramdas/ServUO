using System;
using Server;

namespace Server.Items
{
    public class CBookWelcomeToTheShard : BlueBook
    {
        public static readonly BookContent Content = new BookContent
        (
            "Welcome To The Shard", "Tito Tim",

            new BookPageInfo
            (
                "In your pack you will",
                "find some handy toys to",
                "get you started. ATLAS",
                "The World Travel Atlas",
                "looks like a regular",
                "rune book but acts",
                "almost like a moongate.",
                "Open the book and see"
            ),
            new BookPageInfo
            (
                "all the options of",
                "where to go! LOOT The",
                "command for the loot",
                "system is [Loot. If you",
                "single click the",
                "MasterLootBackpack you",
                "can set options for",
                "what, and how, it"
            ),
            new BookPageInfo
            (
                "loots. TOKENS The",
                "Trash4TokensBackpack is",
                "a trash bag with a 3",
                "minute timer. It will",
                "give Tokens for some",
                "items. No telling how",
                "much. It will not give",
                "Tokens for any"
            ),
            new BookPageInfo
            (
                "stackable items - but",
                "will delete them! The",
                "Tokens can be used to",
                "buy some items at the",
                "Token Stone (one in New",
                "Haven, and one at the",
                "Casino). The Casino is",
                "in the Travel Atlas"
            ),
            new BookPageInfo
            (
                "under Custom. SKILLBALL",
                "The skillball will let",
                "you choose 7 skills to",
                "GM. But will reset all",
                "other skills to zero!",
                "You may want to finish",
                "the newbie quests",
                "before using the skill"
            ),
            new BookPageInfo
            (
                "ball. That will give",
                "you time to decide what",
                "to GM. You may consider",
                "GM'ing tedious, or",
                "expensive, skills",
                "(hiding, lockpick,",
                "magery, taming etc)",
                "BANKLSTONE You got a"
            ),
            new BookPageInfo
            (
                "bankstone for bank",
                "access at home.",
                "SPELLBAR Use the",
                "command [Spellbar to",
                "get your spell icons",
                "setup. You must have",
                "the spellbook in your",
                "main bag for it to be"
            ),
            new BookPageInfo
            (
                "found. TOOLBAR Use the",
                "command [ShowTool to",
                "get a nifty toolbar."
            )
        );

        public override BookContent DefaultContent { get { return Content; } }

        [Constructable]
        public CBookWelcomeToTheShard()
            : base(false)
        {
            Hue = 766;
        }

        public CBookWelcomeToTheShard(Serial serial)
            : base(serial)
        {
        }

        public override void Serialize(GenericWriter writer)
        {
            base.Serialize(writer);
            writer.WriteEncodedInt((int)0);
        }

        public override void Deserialize(GenericReader reader)
        {
            base.Deserialize(reader);
            int version = reader.ReadEncodedInt();
        }
    }
}