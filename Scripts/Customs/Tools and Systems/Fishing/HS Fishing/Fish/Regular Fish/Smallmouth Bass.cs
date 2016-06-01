using System;

namespace Server.Items
{
    public class SmallmouthBass
    	: BaseHighSeasFish
    {
        [Constructable]
        public SmallmouthBass() 
        {
        	ItemID = 0x409CD;
        	Name = "smallmouth bass";
        }

        public SmallmouthBass(Serial serial)
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