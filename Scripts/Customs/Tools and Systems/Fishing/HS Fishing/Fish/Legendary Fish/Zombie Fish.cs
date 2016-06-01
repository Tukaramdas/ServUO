using System;

namespace Server.Items
{
    public class ZombieFish : BaseHighSeasFish
    {
        [Constructable]
        public ZombieFish() 
        {
        	ItemID = 0x44C3;
        	Name = "zombie fish";
        	Hue = 2128;
        }

        public ZombieFish(Serial serial)
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