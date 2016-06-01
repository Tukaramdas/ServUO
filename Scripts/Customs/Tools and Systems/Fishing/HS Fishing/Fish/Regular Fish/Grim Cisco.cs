using System;

namespace Server.Items
{
    public class GrimCisco : BaseHighSeasFish
    {
        [Constructable]
        public GrimCisco() 
        {
        	ItemID = 0x44C3;
        	Name = "grim cisco";
        }

        public GrimCisco(Serial serial)
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