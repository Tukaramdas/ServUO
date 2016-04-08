using System;

namespace Server.Items
{
    public class OrcBass : BaseHighSeasFish
    {
        [Constructable]
        public OrcBass() 
        {
        	ItemID = 0x09CC;
        	Name = "orc bass";
        }

        public OrcBass(Serial serial)
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