using System;

namespace Server.Items
{
    public class LurkerFish : BaseHighSeasFish
    {
        [Constructable]
        public LurkerFish() 
        {
        	ItemID = 0x09CE;
        	Name = "lurker fish";
        }

        public LurkerFish(Serial serial)
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