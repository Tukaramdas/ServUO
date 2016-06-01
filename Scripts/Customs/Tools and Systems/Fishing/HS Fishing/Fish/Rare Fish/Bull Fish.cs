using System;

namespace Server.Items
{
    public class BullFish : BaseHighSeasFish
    {
        [Constructable]
        public BullFish() 
        {
        	ItemID = 0x44C5;
        	Name = "bull fish";
        	Hue = 2052;
        }

        public BullFish(Serial serial)
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