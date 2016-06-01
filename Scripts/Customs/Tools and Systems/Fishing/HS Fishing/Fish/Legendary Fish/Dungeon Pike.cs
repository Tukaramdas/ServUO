using System;

namespace Server.Items
{
    public class DungeonPike : BaseHighSeasFish
    {
        [Constructable]
        public DungeonPike() 
        {
        	ItemID = 0x44C3;
        	Name = "dungeon pike";
        	Hue = 2727;
        }

        public DungeonPike(Serial serial)
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