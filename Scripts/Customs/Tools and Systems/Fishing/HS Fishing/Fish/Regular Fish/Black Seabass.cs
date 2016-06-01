using System;

namespace Server.Items
{
    public class BlackSeabass : BaseHighSeasFish
    {
        [Constructable]
        public BlackSeabass() 
        {
        	ItemID = 0x09CE;
        	Name = "black seabass";
        }

        public BlackSeabass(Serial serial)
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