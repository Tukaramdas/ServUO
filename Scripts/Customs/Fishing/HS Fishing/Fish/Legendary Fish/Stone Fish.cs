using System;

namespace Server.Items
{
    public class StoneFish : BaseHighSeasFish
    {
        [Constructable]
        public StoneFish() 
        {
        	ItemID = 0x44C5;
        	Name = "stone fish";
        	Hue = 2009;
        }

        public StoneFish(Serial serial)
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