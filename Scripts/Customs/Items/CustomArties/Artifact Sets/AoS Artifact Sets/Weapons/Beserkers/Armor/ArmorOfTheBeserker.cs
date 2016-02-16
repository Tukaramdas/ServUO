using System;
using Server;

namespace Server.Items
{
	public class ArmorOfTheBeserker : RingmailChest
	{
		public override int LabelNumber{ get{ return 1061092; } } // Armor of TheBeserker
		public override int ArtifactRarity{ get{ return 11; } }

		public override int BasePhysicalResistance{ get{ return 22; } }
		public override int BasePoisonResistance{ get{ return 25; } }

		public override int InitMinHits{ get{ return 255; } }
		public override int InitMaxHits{ get{ return 255; } }

		[Constructable]
		public ArmorOfTheBeserker()
		{
			Name = "Armor of The Beserker";
			Hue = 0x21;
			Attributes.WeaponSpeed = 15;
			Attributes.WeaponDamage = 10;
		}

		public ArmorOfTheBeserker( Serial serial ) : base( serial )
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
				if ( Hue == 0x562 )
					Hue = 0x4FE;

				PhysicalBonus = 0;
				PoisonBonus = 0;
			}
		}
	}
}