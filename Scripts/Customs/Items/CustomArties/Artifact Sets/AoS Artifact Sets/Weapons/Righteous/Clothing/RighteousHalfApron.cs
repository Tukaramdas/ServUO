using System;
using Server;

namespace Server.Items
{
	public class RighteousHalfApron: HalfApron
	{
		public override int LabelNumber{ get{ return 1061088; } } // Righteous Half Apron
		public override int ArtifactRarity{ get{ return 11; } }

		public override int InitMinHits{ get{ return 255; } }
		public override int InitMaxHits{ get{ return 255; } }

		[Constructable]
		public RighteousHalfApron()
		{
			Name = "Righteous Half Apron";
		
			Hue = 0x47E;
			Attributes.BonusHits = 10;
			Attributes.WeaponDamage = 5;
			Attributes.SpellDamage = 5;
			Attributes.AttackChance = 5;
		}

		public RighteousHalfApron( Serial serial ) : base( serial )
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

			if ( Hue == 0x44F )
				Hue = 0x76D;
		}
	}
}