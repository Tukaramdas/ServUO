using System;

namespace Server.Items
{
    public class ReaperFish : BaseHighSeasFish
    {
        [Constructable]
        public ReaperFish() 
        {
        	ItemID = 0x44C3;
        	Name = "reaper fish";
        	Hue = 2075;
        }

        public ReaperFish(Serial serial)
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