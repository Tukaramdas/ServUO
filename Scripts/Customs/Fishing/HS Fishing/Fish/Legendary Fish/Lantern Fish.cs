using System;

namespace Server.Items
{
    public class LanternFish : BaseHighSeasFish
    {
        [Constructable]
        public LanternFish() 
        {
        	ItemID = 0x44C5;
        	Name = "lantern fish";
        	Hue = 2003;
        }

        public LanternFish(Serial serial)
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