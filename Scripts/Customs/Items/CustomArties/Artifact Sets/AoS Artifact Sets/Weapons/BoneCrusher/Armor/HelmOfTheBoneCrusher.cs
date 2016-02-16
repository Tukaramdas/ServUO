using System;
using Server;

namespace Server.Items
{
	public class HelmOfTheBoneCrusher : BoneHelm
	{
		public override int LabelNumber{ get{ return 1061095; } } // Ornate Crown of the Harrower
		public override int ArtifactRarity{ get{ return 11; } }

		public override int BasePoisonResistance{ get{ return 17; } }

		public override int InitMinHits{ get{ return 255; } }
		public override int InitMaxHits{ get{ return 255; } }

		[Constructable]
		public HelmOfTheBoneCrusher()
		{
			Name = "Helmet of The Bone Crusher";
			Hue = 0x60C;
			Attributes.ReflectPhysical = 5;
			Attributes.DefendChance = 5;
			Attributes.WeaponDamage = 5;
			Attributes.BonusStr = 5;
		}

		public HelmOfTheBoneCrusher( Serial serial ) : base( serial )
		{
		}

		public override void Serialize( GenericWriter writer )
		{
			base.Serialize( writer );

			writer.Write( (int) 1 );
		}
		
		public override void Deserialize(GenericReader reader)
		{
			base.Deserialize( reader );

			int version = reader.ReadInt();

			if ( version < 1 )
			{
				if ( Hue == 0x55A )
					Hue = 0x4F6;

				PoisonBonus = 0;
			}
		}
	}
}