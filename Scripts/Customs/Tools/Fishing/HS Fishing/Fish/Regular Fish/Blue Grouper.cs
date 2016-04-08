using System;

namespace Server.Items
{
    public class BlueGrouper : BaseHighSeasFish
    {
        [Constructable]
        public BlueGrouper() 
        {
        	ItemID = 0x4306;
        	Name = "blue grouper";
        }

        public BlueGrouper(Serial serial)
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