using System;

namespace Server.Items
{
    public class YellowPerch : BaseHighSeasFish
    {
        [Constructable]
        public YellowPerch() 
        {
        	ItemID = 0x4303;
        	Name = "yellow perch";
        }

        public YellowPerch(Serial serial)
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