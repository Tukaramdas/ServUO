using System;

namespace Server.Items
{
    public class RainbowTrout : BaseHighSeasFish
    {
        [Constructable]
        public RainbowTrout() 
        {
        	ItemID = 0x4302;
        	Name = "rainbow trout";
        }

        public RainbowTrout(Serial serial)
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