using System;
using Server;

namespace Server.Items
{
	public class ClawOfTheHarrower : ExecutionersAxe
	{
		public override int LabelNumber{ get{ return 1061095; } } // Arms of the Harrower
		public override int ArtifactRarity{ get{ return 11; } }

		public override int InitMinHits{ get{ return 255; } }
		public override int InitMaxHits{ get{ return 255; } }

		[Constructable]
		public ClawOfTheHarrower()
		{
			Name = "Claw of the Harrower";
			Hue = 0x4F6;
			WeaponAttributes.HitLeechHits = 10;
			WeaponAttributes.HitLeechStam = 5;
			Attributes.WeaponDamage = 15;
		}

		public override void GetDamageTypes( Mobile wielder, out int phys, out int fire, out int cold, out int pois, out int nrgy, out int chaos, out int direct )
		{
			phys = 80;
			pois = 20;			
			fire = cold = nrgy = chaos = direct = 0;
		}
		
		public ClawOfTheHarrower( Serial serial ) : base( serial )
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
			}
		}
	}
}