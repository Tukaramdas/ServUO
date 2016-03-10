using System;

namespace Server.Items
{
    public class Amberjack : BaseHighSeasFish
    {
        [Constructable]
        public Amberjack() 
        {
        	ItemID = 0x44C6;
        	Name = "amberjack";
        }

        public Amberjack(Serial serial)
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