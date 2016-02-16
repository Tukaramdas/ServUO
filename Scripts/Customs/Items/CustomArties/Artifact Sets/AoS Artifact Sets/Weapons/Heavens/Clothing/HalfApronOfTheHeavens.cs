using System;
using Server;

namespace Server.Items
{
	public class HalfApronOfTheHeavens : HalfApron
	{
		public override int LabelNumber{ get{ return 1061106; } } // HalfApron of the Heavens
		public override int ArtifactRarity{ get{ return 11; } }

		public override int InitMinHits{ get{ return 255; } }
		public override int InitMaxHits{ get{ return 255; } }

		[Constructable]
		public HalfApronOfTheHeavens()
		{
			Name = " HalfApron of the Heavens";
			Hue = 0x4D5;
			Attributes.AttackChance = 5;
			Attributes.DefendChance = 10;
			Attributes.WeaponDamage = 5;
		}

		public HalfApronOfTheHeavens( Serial serial ) : base( serial )
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