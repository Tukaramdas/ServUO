using System;

namespace Server.Items
{
    public class Harpoon : Item, ICommodity
    {
        [Constructable]
        public Harpoon()
            : this(1)
        {
        }

        [Constructable]
        public Harpoon(int amount)
            : base(0x1BFB)
        {
        	this.Name = "a harpoon";
        	this.Hue = 1175;
            this.Stackable = true;
            this.Amount = amount;
        }

        public Harpoon(Serial serial)
            : base(serial)
        {
        }

        public override double DefaultWeight
        {
            get
            {
                return 0.1;
            }
        }
        int ICommodity.DescriptionNumber
        {
            get
            {
                return this.LabelNumber;
            }
        }
        bool ICommodity.IsDeedable
        {
            get
            {
                return true;
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
}