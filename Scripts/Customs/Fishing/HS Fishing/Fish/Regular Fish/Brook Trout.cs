using System;

namespace Server.Items
{
    public class BrookTrout : BaseHighSeasFish
    {
        [Constructable]
        public BrookTrout() 
        {
        	ItemID = 0x09CC;
        	Name = "brook trout";
        }

        public BrookTrout(Serial serial)
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