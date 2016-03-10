using System;

namespace Server.Items
{
    public class Bonefish : BaseHighSeasFish
    {
        [Constructable]
        public Bonefish() 
        {
        	ItemID = 0x44C3;
        	Name = "bonefish";
        }

        public Bonefish(Serial serial)
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