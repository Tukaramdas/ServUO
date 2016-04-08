using System;

namespace Server.Items
{
    public class GoldenTuna : BaseHighSeasFish
    {
        [Constructable]
        public GoldenTuna() 
        {
        	ItemID = 0x4302;
        	Name = "golden tuna";
        	Hue = 1161;
        }

        public GoldenTuna(Serial serial)
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