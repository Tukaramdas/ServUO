using System;

namespace Server.Items
{
    public class RedSnook
    	: BaseHighSeasFish
    {
        [Constructable]
        public RedSnook() 
        {
        	ItemID = 0x409CD;
        	Name = "red snook";
        }

        public RedSnook(Serial serial)
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