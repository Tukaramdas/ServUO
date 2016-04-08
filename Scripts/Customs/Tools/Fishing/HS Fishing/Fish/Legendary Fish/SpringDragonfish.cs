using System;

namespace Server.Items
{
    public class SpringDragonfish : BaseHighSeasFish
    {
        [Constructable]
        public SpringDragonfish() 
        {
        	ItemID = 0x44E6;
        	Name = "spring dragonfish";
        }

        public SpringDragonfish(Serial serial)
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