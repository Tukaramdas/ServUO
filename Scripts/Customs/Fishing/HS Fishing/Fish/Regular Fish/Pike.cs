using System;

namespace Server.Items
{
    public class PikeFish : BaseHighSeasFish
    {
        [Constructable]
        public PikeFish() 
        {
        	ItemID = 0x44C4;
        	Name = "pike";
        }

        public PikeFish(Serial serial)
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