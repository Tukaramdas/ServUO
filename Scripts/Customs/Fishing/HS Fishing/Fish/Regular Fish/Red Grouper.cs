using System;

namespace Server.Items
{
    public class RedGrouper
    	: BaseHighSeasFish
    {
        [Constructable]
        public RedGrouper() 
        {
        	ItemID = 0x4307;
        	Name = "red grouper";
        }

        public RedGrouper(Serial serial)
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