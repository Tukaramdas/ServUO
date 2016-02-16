using System;
using Server;

namespace Server.Items
{
	public class BoneCrushersBandana : Bandana
	{
		public override int LabelNumber{ get{ return 1061111; } } // BoneCrushersBandana
		public override int ArtifactRarity{ get{ return 11; } }
		
		public override int InitMinHits{ get{ return 255; } }
		public override int InitMaxHits{ get{ return 255; } }

		[Constructable]
		public BoneCrushersBandana()
		{
			Name = "Bone Crushers Bandana";
			Hue = 0x60C;
			Attributes.ReflectPhysical = 5;
			Attributes.DefendChance = 5;
			Attributes.WeaponDamage = 5;
		}

		public BoneCrushersBandana( Serial serial ) : base( serial )
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