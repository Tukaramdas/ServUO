using System;

namespace Server.Items
{
    public class Mudpuppy : BaseHighSeasFish
    {
        [Constructable]
        public Mudpuppy() 
        {
        	ItemID = 0x09CC;
        	Name = "mud puppy";
        }

        public Mudpuppy(Serial serial)
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