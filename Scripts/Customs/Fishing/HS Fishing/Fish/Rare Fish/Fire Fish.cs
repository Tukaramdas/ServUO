using System;

namespace Server.Items
{
    public class FireFish : BaseHighSeasFish
    {
        [Constructable]
        public FireFish() 
        {
        	ItemID = 0x4306;
        	Name = "fire fish";
        	Hue = 2118;
        }

        public FireFish(Serial serial)
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