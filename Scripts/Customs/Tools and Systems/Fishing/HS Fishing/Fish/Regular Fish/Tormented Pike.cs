using System;

namespace Server.Items
{
    public class TormentedPike : BaseHighSeasFish
    {
        [Constructable]
        public TormentedPike() 
        {
        	ItemID = 0x44C3;
        	Name = "tormented pike";
        }

        public TormentedPike(Serial serial)
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