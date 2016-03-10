using System;

namespace Server.Items
{
    public class Walleye
    	: BaseHighSeasFish
    {
        [Constructable]
        public Walleye() 
        {
        	ItemID = 0x409CF;
        	Name = "walleye";
        }

        public Walleye(Serial serial)
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