using System;

namespace Server.Items
{
    [Flipable(0x981C, 0x9821)]
    public class AdvancedTrainingDummy : AddonComponent
    {
        private double m_MinSkill;
        private double m_MaxSkill;
        private Timer m_Timer;
        [Constructable]
        public AdvancedTrainingDummy()
            : this(0x981C)
        {
        }

        [Constructable]
        public AdvancedTrainingDummy(int itemID)
            : base(itemID)
        {
            this.m_MinSkill = -60.0;
            this.m_MaxSkill = +60.0;
        }

        public AdvancedTrainingDummy(Serial serial)
            : base(serial)
        {
        }

        [CommandProperty(AccessLevel.GameMaster)]
        public double MinSkill
        {
            get
            {
                return this.m_MinSkill;
            }
            set
            {
                this.m_MinSkill = value;
            }
        }
        [CommandProperty(AccessLevel.GameMaster)]
        public double MaxSkill
        {
            get
            {
                return this.m_MaxSkill;
            }
            set
            {
                this.m_MaxSkill = value;
            }
        }
        [CommandProperty(AccessLevel.GameMaster)]
        public bool Swinging
        {
            get
            {
                return (this.m_Timer != null);
            }
        }
        public void UpdateItemID()
        {
            int baseItemID = (this.ItemID / 2) * 2;

            this.ItemID = baseItemID + (this.Swinging ? 1 : 0);
        }

        public void BeginSwing()
        {
            if (this.m_Timer != null)
                this.m_Timer.Stop();

            this.m_Timer = new InternalTimer(this);
            this.m_Timer.Start();
        }

        public void EndSwing()
        {
            if (this.m_Timer != null)
                this.m_Timer.Stop();

            this.m_Timer = null;

            this.UpdateItemID();
        }

        public void OnHit()
        {
            this.UpdateItemID();
            Effects.PlaySound(this.GetWorldLocation(), this.Map, Utility.RandomList(0x3A4, 0x3A6, 0x3A9, 0x3AE, 0x3B4, 0x3B6));
        }

        public void Use(Mobile from, BaseWeapon weapon)
        {
            this.BeginSwing();

            from.Direction = from.GetDirectionTo(this.GetWorldLocation());
            weapon.PlaySwingAnimation(from);

            from.CheckSkill(weapon.Skill, this.m_MinSkill, this.m_MaxSkill);
        }

        public override void OnDoubleClick(Mobile from)
        {
            BaseWeapon weapon = from.Weapon as BaseWeapon;

            if (weapon is BaseRanged)
                this.SendLocalizedMessageTo(from, 501822); // You can't practice ranged weapons on this.
            else if (weapon == null || !from.InRange(this.GetWorldLocation(), weapon.MaxRange))
                this.SendLocalizedMessageTo(from, 501816); // You are too far away to do that.
            else if (this.Swinging)
                this.SendLocalizedMessageTo(from, 501815); // You have to wait until it stops swinging.
            else if (from.Skills[weapon.Skill].Base >= this.m_MaxSkill)
                this.SendLocalizedMessageTo(from, 501828); // Your skill cannot improve any further by simply practicing with a dummy.
            else if (from.Mounted)
                this.SendLocalizedMessageTo(from, 501829); // You can't practice on this while on a mount.
            else
                this.Use(from, weapon);
        }

        public override void Serialize(GenericWriter writer)
        {
            base.Serialize(writer);

            writer.Write((int)0);

            writer.Write(this.m_MinSkill);
            writer.Write(this.m_MaxSkill);
        }

        public override void Deserialize(GenericReader reader)
        {
            base.Deserialize(reader);

            int version = reader.ReadInt();

            switch ( version )
            {
                case 0:
                    {
                        this.m_MinSkill = reader.ReadDouble();
                        this.m_MaxSkill = reader.ReadDouble();

                        if (this.m_MinSkill == 0.0 && this.m_MaxSkill == 60.0)
                        {
                            this.m_MinSkill = -60.0;
                            this.m_MaxSkill = +60.0;
                        }

                        break;
                    }
            }

            this.UpdateItemID();
        }

        private class InternalTimer : Timer
        {
            private readonly AdvancedTrainingDummy m_Dummy;
            private bool m_Delay = true;
            public InternalTimer(AdvancedTrainingDummy dummy)
                : base(TimeSpan.FromSeconds(0.25), TimeSpan.FromSeconds(2.75))
            {
                this.m_Dummy = dummy;
                this.Priority = TimerPriority.FiftyMS;
            }

            protected override void OnTick()
            {
                if (this.m_Delay)
                    this.m_Dummy.OnHit();
                else
                    this.m_Dummy.EndSwing();

                this.m_Delay = !this.m_Delay;
            }
        }
    }

    public class AdvancedTrainingDummyEastAddon : BaseAddon
    {
        [Constructable]
        public AdvancedTrainingDummyEastAddon()
        { // - west/east + , + south/north - /z
            this.AddComponent(new AdvancedTrainingDummy(0x9821), 0, 0, 0);
            this.AddComponent(new AddonComponent(0x9830), 0, 0, 0);
            this.AddComponent(new AddonComponent(0x982F), -1, 1, 0);
            this.AddComponent(new AddonComponent(0x982E), 0, 1, 0);
            this.AddComponent(new AddonComponent(0x982C), 1, 1, 0);
            this.AddComponent(new AddonComponent(0x9833), -1, -1, 0);
            this.AddComponent(new AddonComponent(0x9832), 0, -1, 0);
            this.AddComponent(new AddonComponent(0x9831), 1, -1, 0);
        }

        public AdvancedTrainingDummyEastAddon(Serial serial)
            : base(serial)
        {
        }

        public override BaseAddonDeed Deed
        {
            get
            {
                return new AdvancedTrainingDummyEastDeed();
            }
        }
        public override void Serialize(GenericWriter writer)
        {
            base.Serialize(writer);

            writer.Write((int)0); // version
        }

        public override void Deserialize(GenericReader reader)
        {
            base.Deserialize(reader);

            int version = reader.ReadInt();
        }
    }

    public class AdvancedTrainingDummyEastDeed : BaseAddonDeed
    {
        [Constructable]
        public AdvancedTrainingDummyEastDeed()
        {
        }

        public AdvancedTrainingDummyEastDeed(Serial serial)
            : base(serial)
        {
        }

        public override BaseAddon Addon
        {
            get
            {
                return new AdvancedTrainingDummyEastAddon();
            }
        }
        public override int LabelNumber
        {
            get
            {
                return 1044335;
            }
        }// training dummy (east)
        public override void Serialize(GenericWriter writer)
        {
            base.Serialize(writer);

            writer.Write((int)0); // version
        }

        public override void Deserialize(GenericReader reader)
        {
            base.Deserialize(reader);

            int version = reader.ReadInt();
        }
    }

    public class AdvancedTrainingDummySouthAddon : BaseAddon
    {
        [Constructable]
        public AdvancedTrainingDummySouthAddon()
        { // - west/east + , + south/north - /z
            this.AddComponent(new AdvancedTrainingDummy(0x981C), 0, 0, 0);
            this.AddComponent(new AddonComponent(0x9829), 0, 0, 0);
            this.AddComponent(new AddonComponent(0x982A), -1, 1, 0);
            this.AddComponent(new AddonComponent(0x982B), -1, 0, 0);
            this.AddComponent(new AddonComponent(0x982C), -1, -1, 0);
            this.AddComponent(new AddonComponent(0x9827), 1, 0, 0);
            this.AddComponent(new AddonComponent(0x9826), 1, 1, 0);
            this.AddComponent(new AddonComponent(0x9828), 1, -1, 0);
        }

        public AdvancedTrainingDummySouthAddon(Serial serial)
            : base(serial)
        {
        }

        public override BaseAddonDeed Deed
        {
            get
            {
                return new AdvancedTrainingDummySouthDeed();
            }
        }
        public override void Serialize(GenericWriter writer)
        {
            base.Serialize(writer);

            writer.Write((int)0); // version
        }

        public override void Deserialize(GenericReader reader)
        {
            base.Deserialize(reader);

            int version = reader.ReadInt();
        }
    }

    public class AdvancedTrainingDummySouthDeed : BaseAddonDeed
    {
        [Constructable]
        public AdvancedTrainingDummySouthDeed()
        {
        }

        public AdvancedTrainingDummySouthDeed(Serial serial)
            : base(serial)
        {
        }

        public override BaseAddon Addon
        {
            get
            {
                return new AdvancedTrainingDummySouthAddon();
            }
        }
        public override int LabelNumber
        {
            get
            {
                return 1044336;
            }
        }// training dummy (south)
        public override void Serialize(GenericWriter writer)
        {
            base.Serialize(writer);

            writer.Write((int)0); // version
        }

        public override void Deserialize(GenericReader reader)
        {
            base.Deserialize(reader);

            int version = reader.ReadInt();
        }
    }
}