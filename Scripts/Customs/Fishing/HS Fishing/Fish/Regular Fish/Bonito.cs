using System;

namespace Server.Items
{
    public class Bonito : BaseHighSeasFish
    {
        [Constructable]
        public Bonito() 
        {
        	ItemID = 0x4303;
        	Name = "bonito";
        }

        public Bonito(Serial serial)
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