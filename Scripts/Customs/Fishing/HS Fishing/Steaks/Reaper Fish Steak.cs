using System;
using Server.Targeting;

namespace Server.Items
{
    public class ReaperFishSteak : CookableFood
    {
        public override double DefaultWeight
        {
            get
            {
                return 0.1;
            }
        }

        [Constructable]
        public ReaperFishSteak() : this(1)
        {
        }

        [Constructable]
        public ReaperFishSteak(int amount) : base(0x097A, 10)
        {
        	this.Name = "reaper fish steak";
            this.Stackable = true;
            this.Amount = amount;
            this.Hue = 1152;
        }

        public ReaperFishSteak(Serial serial)
            : base(serial)
        {
        }

        public override Food Cook()
        {
            return new FishSteak();
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