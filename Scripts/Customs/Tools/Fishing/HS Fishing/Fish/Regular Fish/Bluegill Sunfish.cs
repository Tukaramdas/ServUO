using System;

namespace Server.Items
{
    public class BluegillSunfish : BaseHighSeasFish
    {
        [Constructable]
        public BluegillSunfish() 
        {
        	ItemID = 0x4306;
        	Name = "bluegill sunfish";
        }

        public BluegillSunfish(Serial serial)
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