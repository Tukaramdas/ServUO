using System;
using Server;

namespace Server.Items
{
	public class ArmsOfTheHeavens : PlateArms
	{
		public override int LabelNumber{ get{ return 1061106; } } // Arms of the Heavens
		public override int ArtifactRarity{ get{ return 11; } }
		
		public override int BaseEnergyResistance{ get{ return 15; } }

		public override int InitMinHits{ get{ return 255; } }
		public override int InitMaxHits{ get{ return 255; } }

		[Constructable]
		public ArmsOfTheHeavens()
		{
			Name = "Arms of the Heavens";
			Hue = 0x4D5;
			Attributes.AttackChance = 10;
			Attributes.DefendChance = 10;
			Attributes.WeaponDamage = 15;
		}

		public ArmsOfTheHeavens( Serial serial ) : base( serial )
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