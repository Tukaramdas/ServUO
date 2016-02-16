using System;
using Server;

namespace Server.Items
{
	public class TunicOfTheBoneCrusher : BoneChest
	{
		public override int LabelNumber{ get{ return 1061095; } } // Tunic of the Bone Crusher
		public override int ArtifactRarity{ get{ return 11; } }

		public override int BasePoisonResistance{ get{ return 25; } }

		public override int InitMinHits{ get{ return 255; } }
		public override int InitMaxHits{ get{ return 255; } }

		[Constructable]
		public TunicOfTheBoneCrusher()
		{
			Name = "Tunic of the Bone Crusher";
			Hue = 0x60C;
			Attributes.ReflectPhysical = 10;
			Attributes.DefendChance = 10;
			Attributes.WeaponDamage = 10;
			Attributes.BonusStr = 5;
		}

		public TunicOfTheBoneCrusher( Serial serial ) : base( serial )
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