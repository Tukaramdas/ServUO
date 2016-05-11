using System;

namespace Server.Items
{
    [FlipableAddon(Direction.South, Direction.East)]
    public class VenusFlytrapAddon : BaseAddonContainer
    {
        private Timer m_Timer;
        [Constructable]
        public VenusFlytrapAddon()
        	: base(0x9967)
        {
        	this.Direction = Direction.South;
			this.Hue = Utility.RandomList( 967, 1161, 1151, 1152, 1372, 1376, 2787  ); 

        }

        public VenusFlytrapAddon(Serial serial)
            : base(serial)
        {
        }

        public override BaseAddonContainerDeed Deed
        {
            get
            {
                return new VenusFlytrapDeed();
            }
        }
        public override int LabelNumber
        {
            get
            {
                return 1154462;
            }
        }// Enormous Venus Flytrap
        public override int DefaultMaxWeight
        {
            get
            {
                return 0;
            }
        }
        public override int DefaultGumpID
        {
            get
            {
                return 0x107;
            }
        }
        public override int DefaultDropSound
        {
            get
            {
                return 0x42;
            }
        }
        public override bool OnDragDrop(Mobile from, Item dropped)
        {
            if (!base.OnDragDrop(from, dropped))
                return false;

            if (this.TotalItems >= 50)
            {
                this.SendLocalizedMessageTo(from, 501478); // The trash is full!  Emptying!
                this.Empty();
            }
            else
            {
                this.SendLocalizedMessageTo(from, 1010442); // The item will be deleted in three minutes

                if (this.m_Timer != null)
                    this.m_Timer.Stop();

                this.m_Timer = Timer.DelayCall(TimeSpan.FromMinutes(3), new TimerCallback(Empty));
            }

            return true;
        }

        public override bool OnDragDropInto(Mobile from, Item item, Point3D p, byte gridloc )
        {
            if (!base.OnDragDropInto(from, item, p, gridloc))
                return false;

            if (this.TotalItems >= 50)
            {
                this.SendLocalizedMessageTo(from, 501478); // The trash is full!  Emptying!
                this.Empty();
            }
            else
            {
                this.SendLocalizedMessageTo(from, 1010442); // The item will be deleted in three minutes

                if (this.m_Timer != null)
                    this.m_Timer.Stop();

                this.m_Timer = Timer.DelayCall(TimeSpan.FromMinutes(3), new TimerCallback(Empty));
            }

            return true;
        }

        public override void Serialize(GenericWriter writer)
        {
            base.Serialize(writer);

            writer.WriteEncodedInt(0); // version
        }

        public override void Deserialize(GenericReader reader)
        {
            base.Deserialize(reader);

            int version = reader.ReadEncodedInt();

            if (this.Items.Count > 0)
                this.m_Timer = Timer.DelayCall(TimeSpan.FromMinutes(3), new TimerCallback(Empty));
        }

        public virtual void Flip(Mobile from, Direction direction)
        {
            switch ( direction )
            {
                case Direction.East:
                    this.ItemID = 0x9968;
                    break;
                case Direction.South:
                    this.ItemID = 0x9967; 
                    break;
            }
        }

        public virtual void Empty()
        {
            if (this.Items.Count > 0)
            {
                Point3D location = this.Location;
                location.Z += 10;

                Effects.SendLocationEffect(location, this.Map, 0x3709, 10, 10, 0x356, 0);
                Effects.PlaySound(location, this.Map, 0x32E);

                if (this.Items.Count > 0)
                {
                    for (int i = this.Items.Count - 1; i >= 0; --i)
                    {
                        if (i >= this.Items.Count)
                            continue;

                        this.Items[i].Delete();
                    }
                }
            }

            if (this.m_Timer != null)
                this.m_Timer.Stop();

            this.m_Timer = null;
        }
    }

    public class VenusFlytrapDeed : BaseAddonContainerDeed
    {
        [Constructable]
        public VenusFlytrapDeed()
            : base()
        {
            this.LootType = LootType.Blessed;
        }

        public VenusFlytrapDeed(Serial serial)
            : base(serial)
        {
        }

        public override BaseAddonContainer Addon
        {
            get
            {
                return new VenusFlytrapAddon();
            }
        }
        public override int LabelNumber
        {
            get
            {
                return 1154462;
            }
        }// Enormous Venus Flytrap
        public override void Serialize(GenericWriter writer)
        {
            base.Serialize(writer);

            writer.WriteEncodedInt(0); // version
        }

        public override void Deserialize(GenericReader reader)
        {
            base.Deserialize(reader);

            int version = reader.ReadEncodedInt();
        }
    }
}