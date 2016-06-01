using System;

namespace Server.Items
{
    public class DrakeFish : BaseHighSeasFish
    {
        [Constructable]
        public DrakeFish() 
        {
        	ItemID = 0x44C5;
        	Name = "drake fish";
        }

        public DrakeFish(Serial serial)
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