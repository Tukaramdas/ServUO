using System;

namespace Server.Items
{
    public class Cobia : BaseHighSeasFish
    {
        [Constructable]
        public Cobia() 
        {
        	ItemID = 0x4303;
        	Name = "cobia";
        }

        public Cobia(Serial serial)
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