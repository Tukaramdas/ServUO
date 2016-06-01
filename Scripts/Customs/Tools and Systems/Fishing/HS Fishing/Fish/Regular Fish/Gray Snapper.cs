using System;

namespace Server.Items
{
    public class GraySnapper : BaseHighSeasFish
    {
        [Constructable]
        public GraySnapper() 
        {
        	ItemID = 0x4302;
        	Name = "gray snapper";
        }

        public GraySnapper(Serial serial)
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