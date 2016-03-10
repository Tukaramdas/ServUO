using System;

namespace Server.Items
{
    public class GreatBarracuda : BaseHighSeasFish
    {
        [Constructable]
        public GreatBarracuda() 
        {
        	ItemID = 0x44C3;
        	Name = "great barracuda";
        	Hue = 1287;
        }

        public GreatBarracuda(Serial serial)
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