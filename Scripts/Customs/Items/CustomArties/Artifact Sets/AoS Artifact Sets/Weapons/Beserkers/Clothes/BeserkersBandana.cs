using System;
using Server;

namespace Server.Items
{
	public class BeserkersBandana : Bandana
	{
		public override int LabelNumber{ get{ return 1061111; } } // BeserkersBandana
		public override int ArtifactRarity{ get{ return 11; } }
		
		public override int InitMinHits{ get{ return 255; } }
		public override int InitMaxHits{ get{ return 255; } }

		[Constructable]
		public BeserkersBandana()
		{
			Name = "Beserkers Bandana";
			Hue = 0x21;
			Attributes.WeaponSpeed = 5;
			Attributes.WeaponDamage = 5;
		}

		public BeserkersBandana( Serial serial ) : base( serial )
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