using System;

namespace Server.Items
{
    public class AutumnDragonfish : BaseHighSeasFish
    {
        [Constructable]
        public AutumnDragonfish() 
        {
        	ItemID = 0x44E6;
        	Name = "autumn dragonfish";
        	Hue = 2112;
        }

        public AutumnDragonfish(Serial serial)
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