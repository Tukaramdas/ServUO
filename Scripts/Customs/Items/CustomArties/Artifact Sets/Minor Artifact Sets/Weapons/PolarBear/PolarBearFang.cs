using System;
using Server;

namespace Server.Items
{
	public class PolarBearFang : AssassinSpike
	{
		public override int LabelNumber{ get{ return 1061598; } } // Shadow Dancer Needle
		
		public override int InitMinHits{ get{ return 255; } }
		public override int InitMaxHits{ get{ return 255; } }

		[Constructable]
		public PolarBearFang()
		{
			Name = "Polar Bear Fang";
			Hue = 0x481;
			Attributes.RegenHits = 3;
			Attributes.NightSight = 1;
		}
		
		public override void GetDamageTypes( Mobile wielder, out int phys, out int fire, out int cold, out int pois, out int nrgy, out int chaos, out int direct )
		{
			cold = 50;
			phys = 50;
			pois = nrgy = fire = chaos = direct = 0;
		}

		public PolarBearFang( Serial serial ) : base( serial )
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
				if ( ItemID == 0x13CB )
					ItemID = 0x13D2;
			}
		}
	}
}