using System;

namespace Server.Items
{
    public class GreenCatfish : BaseHighSeasFish
    {
        [Constructable]
        public GreenCatfish() 
        {
        	ItemID = 0x44C6;
        	Name = "green catfish";
        }

        public GreenCatfish(Serial serial)
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