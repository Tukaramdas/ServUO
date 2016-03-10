using System;

namespace Server.Items
{
    public class UncommonShiner : BaseHighSeasFish
    {
        [Constructable]
        public UncommonShiner() 
        {
        	ItemID = 0x09CE;
        	Name = "uncommon shiner";
        }

        public UncommonShiner(Serial serial)
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