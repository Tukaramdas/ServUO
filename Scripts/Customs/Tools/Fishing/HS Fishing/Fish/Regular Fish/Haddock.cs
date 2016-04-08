using System;

namespace Server.Items
{
    public class Haddock : BaseHighSeasFish
    {
        [Constructable]
        public Haddock() 
        {
        	ItemID = 0x09CC;
        	Name = "haddock";
        }

        public Haddock(Serial serial)
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