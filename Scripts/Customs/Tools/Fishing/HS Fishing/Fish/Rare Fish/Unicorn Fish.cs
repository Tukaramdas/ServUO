using System;

namespace Server.Items
{
    public class UnicornFish : BaseHighSeasFish
    {
        [Constructable]
        public UnicornFish() 
        {
        	ItemID = 0x4304;
        	Name = "unicorn fish";
        	Hue = 1154;
        }

        public UnicornFish(Serial serial)
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