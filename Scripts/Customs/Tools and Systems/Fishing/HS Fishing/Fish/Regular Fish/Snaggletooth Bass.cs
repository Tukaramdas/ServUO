using System;

namespace Server.Items
{
    public class SnaggletoothBass
    	: BaseHighSeasFish
    {
        [Constructable]
        public SnaggletoothBass() 
        {
        	ItemID = 0x409CF;
        	Name = "snaggletooth bass";
        }

        public SnaggletoothBass(Serial serial)
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