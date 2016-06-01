using System;

namespace Server.Items
{
    public class Bluefish : BaseHighSeasFish
    {
        [Constructable]
        public Bluefish() 
        {
        	ItemID = 0x09CC;
        	Name = "bluefish";
        }

        public Bluefish(Serial serial)
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