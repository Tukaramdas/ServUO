//Script Created with Script Creator by Marak and Rockstar
//and Kevin too =]
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
using Server.Gumps;
using Server.Commands;
namespace Server.Items
{
    public class MyQuestItem : Item
    {
        [Constructable]
        public MyQuestItem()
            : this(1)
        { }
        [Constructable]
        public MyQuestItem(int amountFrom, int amountTo)
            : this(Utility.RandomMinMax(amountFrom, amountTo))
        { }
        [Constructable]
        public MyQuestItem(int amount)
            : base(3553)
        {
            Name = "Broken Twig";
            Hue = 0;
            Weight = 0.0;
            Amount = amount;

        }
        public MyQuestItem(Serial serial)
            : base(serial)
        { }
        public override void Serialize(GenericWriter writer)
        {
            base.Serialize(writer);
            writer.Write((int)0); // version
        }
        public override void Deserialize(GenericReader reader)
        {
            base.Deserialize(reader); int version = reader.ReadInt();
        }
    }
}
namespace Server.Gumps
{
  public class MyQuestGump : Gump
  {
 public static void Initialize()
 {
 CommandSystem.Register("MyQuestGump", AccessLevel.GameMaster, new CommandEventHandler(MyQuestGump_OnCommand));
  }
 private static void MyQuestGump_OnCommand(CommandEventArgs e)
 {
    e.Mobile.SendGump(new MyQuestGump());
 }
    public MyQuestGump()
      : base( 0, 0 )
    {
      this.Closable=true;
      this.Disposable=true;
      this.Dragable=true;
      this.Resizable=false;
      this.AddPage(0);
      this.AddBackground(228, 116, 339, 387, 9380);
      this.AddBackground(265, 203, 274, 222, 9300);
      this.AddLabel(371, 117, 0, @"Find my stick");
      this.AddLabel(312, 164, 0, @"Help please");
      this.AddHtml( 272, 213, 257, 203, @"If you help me find my stick I will carve you soenthing nice.", (bool)false, (bool)false);
      this.AddButton(474, 440, 247, 248, (int)Buttons.Button1, GumpButtonType.Reply, 0);
      this.AddImage(270, 151, 9004);

    }
    
    public enum Buttons
    {
      Button1,
    }
        public override void OnResponse(NetState sender, RelayInfo info)
        {
            switch (info.ButtonID)
            {
                case (int)Buttons.Button1:
                    {break;}
            }
        }
  }
}
namespace Server.Mobiles
{
    [CorpseName("MyQuestGiver's Corpse")]
    public class MyQuestGiver : Mobile
    {
        public virtual bool IsInvulnerable { get { return true; } }
        [Constructable]
        public MyQuestGiver()
        {
            BodyValue = 400;
            Name = "Rockstar";
            Title = "the awezum";
            Hits = 10000;
            Hue = 33791;
            Utility.AssignRandomHair(this);
            FancyShirt torso = new FancyShirt();
            torso.Hue = 0;
            AddItem(torso);
            LongPants legs = new LongPants();
            legs.Hue = 0;
            AddItem(legs);
            ThighBoots feet = new ThighBoots();
            feet.Hue = 0;
            AddItem(feet);

            Blessed = true;
            CantWalk = true;


        }

        public MyQuestGiver(Serial serial) : base(serial) { }
        public override void GetContextMenuEntries(Mobile from, List<ContextMenuEntry> list)
        {
            base.GetContextMenuEntries(from, list);
            list.Add(new MyQuestGiverEntry(from, this));
        }
        public override void Serialize(GenericWriter writer)
        {
            base.Serialize(writer); writer.Write((int)0);
        }
        public override void Deserialize(GenericReader reader)
        {
            base.Deserialize(reader); int version = reader.ReadInt();
        }
        public class MyQuestGiverEntry : ContextMenuEntry
        {
            private Mobile m_Mobile; private Mobile m_Giver;
            public MyQuestGiverEntry(Mobile from, Mobile giver) : base(6146, 3) { m_Mobile = from; m_Giver = giver; }
            public override void OnClick()
            {
                if (!(m_Mobile is PlayerMobile))
                    return;
                PlayerMobile mobile = (PlayerMobile)m_Mobile;
                {


                    if (!mobile.HasGump(typeof(MyQuestGump)))
                    {
                        mobile.SendGump(new MyQuestGump());
                    }
                }
            }

        }
        public override bool OnDragDrop(Mobile from, Item dropped)
        {
            Mobile m = from; PlayerMobile mobile = m as PlayerMobile;
            if (mobile != null)
            {


                if (dropped is MyQuestItem)
                {
                    if (dropped.Amount != 1)
                    { this.PrivateOverheadMessage(MessageType.Regular, 1153, false, "There's not the right amount here!", mobile.NetState); return false; }
                    dropped.Delete();


                    mobile.AddToBackpack(new Gold(5000));
                    mobile.AddToBackpack(new WoodenBowl());

                    this.PrivateOverheadMessage(MessageType.Regular, 1153, false, "Thank you for your kindness!", mobile.NetState);


                    return true;
                }
                else if (dropped is Whip) { this.PrivateOverheadMessage(MessageType.Regular, 1153, 1060016, mobile.NetState); return false; } else { this.PrivateOverheadMessage(MessageType.Regular, 1153, false, "I have no need for this...", mobile.NetState); }
            } return false;
        }
    }
}
