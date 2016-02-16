using System;
using Server;

namespace Server.Items
{
	public class JackalsBite : Kryss
	{
		public override int LabelNumber{ get{ return 1061594; } } // Jackal's Bite
		public override int ArtifactRarity{ get{ return 11; } }

		public override int InitMinHits{ get{ return 255; } }
		public override int InitMaxHits{ get{ return 255; } }

		[Constructable]
		public JackalsBite()
		{
			Name = "Jackal's Bite";
			ItemID = 0x1400;
			Hue = 0x6D1;
			Attributes.BonusDex = 15;
			Attributes.RegenHits = 4;
		}
		
		public override void GetDamageTypes( Mobile wielder, out int phys, out int fire, out int cold, out int pois, out int nrgy, out int chaos, out int direct )
		{
			phys = 70;
			cold = 20;
			fire = 10;
			nrgy = pois = chaos = direct = 0;
		}

		public JackalsBite( Serial serial ) : base( serial )
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
				if ( Hue == 0x54B )
					Hue = 0x6D1;
			}
		}
	}
}