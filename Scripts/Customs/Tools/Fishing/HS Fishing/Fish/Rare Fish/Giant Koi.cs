using System;

namespace Server.Items
{
    public class GiantKoi : BaseHighSeasFish
    {
        [Constructable]
        public GiantKoi() 
        {
        	ItemID = 0x44C5;
        	Name = "giant koi";
        	Hue = 2114;
        }

        public GiantKoi(Serial serial)
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