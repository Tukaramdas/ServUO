using System;

namespace Server.Items
{
    public class LavaFish : BaseHighSeasFish
    {
        [Constructable]
        public LavaFish() 
        {
        	ItemID = 0x4304;
        	Name = "lava fish";
        	Hue = 2075;
        }

        public LavaFish(Serial serial)
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