using System;
using Server;

namespace Server.Items
{
	public class OrcishMauling : Club
	{
		public override int LabelNumber{ get{ return 1063472; } }

		public override int InitMinHits{ get{ return 255; } }
		public override int InitMaxHits{ get{ return 255; } }

		[Constructable]
		public OrcishMauling()
		{
			Name = "Orcish Mauling";
			Hue = 0x592;
			Attributes.BonusStr = 10;
			
			Attributes.WeaponSpeed = 15;
			Attributes.WeaponDamage = 25;
		}

		public OrcishMauling( Serial serial ) : base( serial )
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