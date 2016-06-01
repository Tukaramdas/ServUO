using System;

namespace Server.Items
{
    public class CutthroatTrout : BaseHighSeasFish
    {
        [Constructable]
        public CutthroatTrout() 
        {
        	ItemID = 0x4303;
        	Name = "cutthroat trout";
        }

        public CutthroatTrout(Serial serial)
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