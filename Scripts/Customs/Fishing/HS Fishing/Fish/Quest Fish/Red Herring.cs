using System;

namespace Server.Items
{
    public class Redherring : BaseHighSeasFish
    {
        [Constructable]
        public Redherring() 
        {
        	ItemID = 0x09CC;
        	Name = "red herring";
        }

        public Redherring(Serial serial)
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