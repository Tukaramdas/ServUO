using System;
using Server;

namespace Server.Items
{
	public class LegsOfTheDead : BoneLegs
	{
		public override int LabelNumber{ get{ return 1061095; } } // Legs Of The Dead
		public override int ArtifactRarity{ get{ return 11; } }

		public override int BaseEnergyResistance{ get{ return 20; } }

		public override int InitMinHits{ get{ return 255; } }
		public override int InitMaxHits{ get{ return 255; } }

		[Constructable]
		public LegsOfTheDead()
		{
			Name = "Leggings of the Dead";
			Hue = 0x455;
			Attributes.RegenHits = 5;
			Attributes.SpellDamage = 5;
			Attributes.WeaponDamage = 15;
		}

		public LegsOfTheDead( Serial serial ) : base( serial )
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