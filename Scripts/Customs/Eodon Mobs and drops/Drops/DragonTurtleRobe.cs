using System;
using Server;

namespace Server.Items
{
	public class DragonTurtleRobe : Robe
	{
		public override int ArtifactRarity{ get{ return 20; } }
		
		[Constructable]
		public DragonTurtleRobe()
		{
			Name = "Dragon Turtle Robe";
			Hue = 2871;
			LootType = LootType.Blessed;

			Resistances.Cold = 15;
			Resistances.Energy = 14;
			Resistances.Fire = 11;
			Resistances.Physical = 12;
			Resistances.Poison = 10;
		}

		public DragonTurtleRobe( Serial serial ) : base( serial )
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
}