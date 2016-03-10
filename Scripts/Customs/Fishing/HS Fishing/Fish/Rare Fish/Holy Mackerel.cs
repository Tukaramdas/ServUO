using System;

namespace Server.Items
{
    public class HolyMakerel : BaseHighSeasFish
    {
        [Constructable]
        public HolyMakerel() 
        {
        	ItemID = 0x4302;
        	Name = "holy mackerel";
        	Hue = 1150;
        }

        public HolyMakerel(Serial serial)
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