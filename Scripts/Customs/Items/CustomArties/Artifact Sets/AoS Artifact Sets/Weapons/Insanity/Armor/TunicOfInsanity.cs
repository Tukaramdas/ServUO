using System;
using Server;

namespace Server.Items
{
	public class TunicOfInsanity : LeatherChest
	{
		public override int LabelNumber{ get{ return 1061094; } } // Tunic Of Insanity
		public override int ArtifactRarity{ get{ return 11; } }

		public override int BasePhysicalResistance{ get{ return 15; } }
		public override int BaseColdResistance{ get{ return 10; } }

		public override int InitMinHits{ get{ return 255; } }
		public override int InitMaxHits{ get{ return 255; } }

		[Constructable]
		public TunicOfInsanity()
		{
			Name = "Tunic Of Insanity";
		
			Hue = Utility.RandomBool() ? 0x76D : 0x44F;
			
			Attributes.RegenStam = 5;
			Attributes.WeaponSpeed = 10;
			Attributes.WeaponDamage = 15;
		}

		public TunicOfInsanity( Serial serial ) : base( serial )
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
				if ( Hue == 0x551 )
					Hue = 0x76D;

				ColdBonus = 0;
				EnergyBonus = 0;
			}
		}
	}
}