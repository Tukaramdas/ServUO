using System;

namespace Server.Items
{
    public class KokaneeSalmon : BaseHighSeasFish
    {
        [Constructable]
        public KokaneeSalmon() 
        {
        	ItemID = 0x4303;
        	Name = "kokanee salmon";
        }

        public KokaneeSalmon(Serial serial)
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