using System;

namespace Server.Items
{
    public class RedbellyBream
    	: BaseHighSeasFish
    {
        [Constructable]
        public RedbellyBream() 
        {
        	ItemID = 0x4307;
        	Name = "redbelly bream";
        }

        public RedbellyBream(Serial serial)
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