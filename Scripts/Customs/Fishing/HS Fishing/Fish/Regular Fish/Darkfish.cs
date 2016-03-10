using System;

namespace Server.Items
{
    public class Darkfish : BaseHighSeasFish
    {
        [Constructable]
        public Darkfish() 
        {
        	ItemID = 0x4307;
        	Name = "darkfish";
        }

        public Darkfish(Serial serial)
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