using System;

namespace Server.Items
{
    public class BlueMarlin : BaseHighSeasFish
    {
        [Constructable]
        public BlueMarlin() 
        {
        	ItemID = 0x4304;
        	Name = "blue marlin";
        	Hue = 1927;
        }

        public BlueMarlin(Serial serial)
            : base(serial)
        {
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
    }
}