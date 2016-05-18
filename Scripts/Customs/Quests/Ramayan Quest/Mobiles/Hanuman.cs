using System;
using System.Collections;
using Server.Items;
using Server.Targeting;
using Server.ContextMenus;
using Server.Gumps;
using Server.Misc;
using Server.Network;
using Server.Spells;
using Server.Accounting;
using System.Collections.Generic;

namespace Server.Mobiles
{
    [CorpseName("Hanuman's corpse")]
    public class Hanuman : Mobile
    {
        public virtual bool IsInvulnerable { get { return true; } }
        [Constructable]
        public Hanuman()
        {
            Name = "Hanuman";
            Title = "Monkey General";
            Body = 400;
            Direction = Direction.East;
            CantWalk = true;
            Blessed = true;

            AddItem(new TribalMask());
            AddItem(new HideChest());
            AddItem(new HidePauldrons());
            AddItem(new HideGloves());
            AddItem(new HidePants());
            AddItem(new ShortSpear());
            AddItem(new FurBoots());


            AddItem(new ShortHair(56));

        }

        public Hanuman(Serial serial) : base(serial)
        {
        }

        public override void GetContextMenuEntries(Mobile from, List<ContextMenuEntry> list)
        {
            base.GetContextMenuEntries(from, list);
            list.Add(new HanumanEntry(from, this));
        }

        public override void Serialize(GenericWriter writer)
        {
            base.Serialize(writer);
            writer.Write((int)0);
        }

        public override void Deserialize(GenericReader reader)
        {
            base.Deserialize(reader);
            int version = reader.ReadInt();
        }

        public class HanumanEntry : ContextMenuEntry
        {
            private Mobile m_Mobile;
            private Mobile m_Giver;

            public HanumanEntry(Mobile from, Mobile giver) : base(6146, 3)
            {
                m_Mobile = from;
                m_Giver = giver;
            }

            public override void OnClick()
            {


                if (!(m_Mobile is PlayerMobile))
                    return;

                PlayerMobile mobile = (PlayerMobile)m_Mobile;

                {
                  //  mobile.AddToBackpack(new SitasRing());
                    mobile.AddToBackpack(new HanumanIntroduction());
                    if (!mobile.HasGump(typeof(HanumanGump)))
                    {
                        mobile.SendGump(new HanumanGump(mobile));

                    }
                }
            }
        }
    }
}