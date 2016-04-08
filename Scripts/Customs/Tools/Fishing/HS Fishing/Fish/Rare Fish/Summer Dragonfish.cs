using System;

namespace Server.Items
{
    public class SummerDragonfish : BaseHighSeasFish
    {
        [Constructable]
        public SummerDragonfish() 
        {
        	ItemID = 0x44E6;
        	Name = "summer dragonfish";
        	Hue = 2725;
        }

        public SummerDragonfish(Serial serial)
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