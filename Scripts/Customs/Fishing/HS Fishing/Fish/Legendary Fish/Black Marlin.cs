using System;

namespace Server.Items
{
    public class BlackMarlin : BaseHighSeasFish
    {
        [Constructable]
        public BlackMarlin() 
        {
        	ItemID = 0x4304;
        	Name = "black marlin";
        	Hue = 2301;
        }

        public BlackMarlin(Serial serial)
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