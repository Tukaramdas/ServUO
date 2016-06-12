using System;
using System.Collections;
using System.Collections.Generic;
using Server.Items;
using Server.Targeting;
using Server.ContextMenus;
using Server.Gumps;
using Server.Misc;
using Server.Network;
using Server.Spells;

namespace Server.Mobiles
{
    [CorpseName("a corpse")]
    public class GibberHunter : Mobile // BaseCreature
    {
        public virtual bool IsInvulnerable { get { return true; } }
        [Constructable]
        public GibberHunter ()
        {
            ///////////STR/DEX/INT
            InitStats(31, 41, 51);

            ///////////name
            Name = "Gabbie";

            ///////////title
            Title = "the Gibber Hunter";

            ///////////sex. 0x191 is female, 0x190 is male.
            Body = 0x190;

            ///////////skincolor
            Hue = Utility.RandomSkinHue();

            ///////////Random hair and haircolor
            Utility.AssignRandomHair(this);

            ///////////clothing and hues
            AddItem(new Server.Items.Shirt(Utility.RandomBlueHue()));
            AddItem(new Server.Items.LongPants(Utility.RandomBlueHue()));
            AddItem(new Server.Items.Sandals(Utility.RandomBlueHue()));

            ///////////immortal and frozen to-the-spot features below:
            Blessed = true;
            CantWalk = true;

            ///////////Adding a backpack
            Container pack = new Backpack();
            pack.DropItem(new Gold(250, 300));
            pack.Movable = false;
            AddItem(pack);

        }

        public override bool OnDragDrop(Mobile from, Item dropped)
        {

            Mobile m = from;

            PlayerMobile mobile = m as PlayerMobile;

            if (mobile != null)
            {
                if (dropped is GibberHead)
                {
                    dropped.Delete();
                    //   mobile.AddToBackpack(new GibberToken());
                    mobile.AddToBackpack(new RAD());
                    mobile.AddToBackpack(new BankCheck(5000));
                    this.PrivateOverheadMessage(MessageType.Regular, 1153, false, "Thank you. As I said here is a reward.", mobile.NetState);
                }
                else
                {
                    this.PrivateOverheadMessage(MessageType.Regular, 1153, false, "I have no need for this...", mobile.NetState); return true;
                }


            }

            return false;
        }

        public class TheHunterEntry : ContextMenuEntry
        {
            private Mobile m_Mobile; private Mobile m_Giver;

            public TheHunterEntry(Mobile from, Mobile giver)
                : base(6146, 3)
            {
                m_Mobile = from; m_Giver = giver;
            }

 
            public override void OnClick()
            {

                if (!(m_Mobile is PlayerMobile)) return;
                PlayerMobile mobile = (PlayerMobile)m_Mobile;
                {

                    if (!mobile.HasGump(typeof(HunterQuestGump)))
                    {
                       /* if (GibberToken.GibberTokenExistsOn(mobile))
                        {
                            mobile.SendMessage("You have already completed this task.");
                        }
                        else
                        { */
                            mobile.SendGump(new HunterQuestGump());
                       // }
                    }
                } 
            }


        }

        public override void GetContextMenuEntries(Mobile from, List<ContextMenuEntry> list)
        {
            base.GetContextMenuEntries(from, list);
            list.Add(new TheHunterEntry(from, this));
        }

        public GibberHunter(Serial serial)
            : base(serial)
		{
		}

		public override void Serialize( GenericWriter writer )
		{
			base.Serialize( writer );
			writer.Write( (int) 0 );
		}

		public override void Deserialize( GenericReader reader )
		{
			base.Deserialize( reader );
			int version = reader.ReadInt();
		}

    }

}
