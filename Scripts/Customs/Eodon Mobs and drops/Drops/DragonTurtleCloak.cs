using System;
using Server;

namespace Server.Items
{
	public class DragonTurtleCloak : Cloak
	{
		public override int ArtifactRarity{ get{ return 18; } }
		
		[Constructable]
		public DragonTurtleCloak()
		{
			Name = "Dragon Turtle Cloak";
			Hue = 2871;
			LootType = LootType.Blessed;

			Resistances.Cold = 11;
			Resistances.Energy = 13;
			Resistances.Fire = 9;
			Resistances.Physical = 10;
			Resistances.Poison = 8;
		}

		public DragonTurtleCloak( Serial serial ) : base( serial )
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