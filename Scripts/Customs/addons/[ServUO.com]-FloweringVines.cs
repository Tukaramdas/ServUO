
using System;
using Server;
using Server.Network;
using Server.Items;

namespace Server.Items 
{ 
	public class FloweringVines : Item
	{

		[Constructable]
		public FloweringVines() : base( 0x2CFA )
		{
			Name = "Flowering Vines";
			Weight = 10.0;
            Hue = 0;
            LootType = LootType.Regular;
		} 

		public FloweringVines( Serial serial ) : base( serial )
		{
		} 

		public override void Serialize( GenericWriter writer ) 
		{ 
			base.Serialize( writer ); 
			writer.Write( (int) 0 ); 
		} 
       
		public override void Deserialize(GenericReader reader) 
		{ 
			base.Deserialize( reader ); 
			int version = reader.ReadInt(); 
		}
	}

    public class FloweringVines1 : Item
    {

        [Constructable]
        public FloweringVines1()
            : base(0x2CF9)
        {
            Name = "Flowering Vines";
            Weight = 10.0;
            Hue = 0;
            LootType = LootType.Regular;
        }

        public FloweringVines1(Serial serial)
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

    public class FloweringVines2 : Item
    {

        [Constructable]
        public FloweringVines2()
            : base(0x2CFB)
        {
            Name = "Flowering Vines";
            Weight = 10.0;
            Hue = 0;
            LootType = LootType.Regular;
        }

        public FloweringVines2(Serial serial)
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

    public class FloweringVines3 : Item
    {

        [Constructable]
        public FloweringVines3()
            : base(0x2CFC)
        {
            Name = "Flowering Vines";
            Weight = 10.0;
            Hue = 0;
            LootType = LootType.Regular;
        }

        public FloweringVines3(Serial serial)
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