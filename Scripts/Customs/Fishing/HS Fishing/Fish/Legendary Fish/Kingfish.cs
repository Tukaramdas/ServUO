using System;

namespace Server.Items
{
    public class Kingfish : BaseHighSeasFish
    {
        [Constructable]
        public Kingfish() 
        {
        	ItemID = 0x4306;
        	Name = "kingfish";
        	Hue = 2579;
        }

        public Kingfish(Serial serial)
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