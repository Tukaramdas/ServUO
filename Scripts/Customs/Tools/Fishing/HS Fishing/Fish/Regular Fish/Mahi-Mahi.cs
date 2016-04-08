using System;

namespace Server.Items
{
    public class MahiMahi : BaseHighSeasFish
    {
        [Constructable]
        public MahiMahi() 
        {
        	ItemID = 0x44C5;
        	Name = "mahi-mahi";
        }

        public MahiMahi(Serial serial)
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