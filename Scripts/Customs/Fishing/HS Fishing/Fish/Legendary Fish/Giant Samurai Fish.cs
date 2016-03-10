using System;

namespace Server.Items
{
    public class GiantSamuraiFish : BaseHighSeasFish
    {
        [Constructable]
        public GiantSamuraiFish() 
        {
        	ItemID = 0x4306;
        	Name = "giant samurai fish";
        	Hue = 2565;
        }

        public GiantSamuraiFish(Serial serial)
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