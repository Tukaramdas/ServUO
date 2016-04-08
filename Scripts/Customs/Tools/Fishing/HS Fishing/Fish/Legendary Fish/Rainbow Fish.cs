using System;

namespace Server.Items
{
    public class RainbowFish : BaseHighSeasFish
    {
        [Constructable]
        public RainbowFish() 
        {
        	ItemID = 0x4302;
        	Name = "rainbow fish";
        	Hue = 1283;
        }

        public RainbowFish(Serial serial)
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