using System;

namespace Server.Items
{
    public class CragSnapper : BaseHighSeasFish
    {
        [Constructable]
        public CragSnapper() 
        {
        	ItemID = 0x44C4;
        	Name = "crag snapper";
        }

        public CragSnapper(Serial serial)
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