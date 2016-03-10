using System;

namespace Server.Items
{
    public class DungeonChub : BaseHighSeasFish
    {
        [Constructable]
        public DungeonChub() 
        {
        	ItemID = 0x4306;
        	Name = "dungeon chub";
        }

        public DungeonChub(Serial serial)
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