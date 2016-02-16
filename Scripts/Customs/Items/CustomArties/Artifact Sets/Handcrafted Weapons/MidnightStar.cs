using System;
using Server;

namespace Server.Items
{
	public class MidnightStar : MagicalShortbow
	{
		public override int ArtifactRarity{ get{ return 30; } }
		
		public override int InitMinHits{ get{ return 255; } }
		public override int InitMaxHits{ get{ return 255; } }

		[Constructable]
		public MidnightStar()
		{
			
			
			Name = "Midnight Star";
			
			Weight = 5.0;
			Hue = 1993;
			WeaponAttributes.HitLightning = 50;
			Attributes.AttackChance = 45;
			Attributes.WeaponDamage = 10;
			WeaponAttributes.UseBestSkill = 1;
			
				
		}

		public override void GetDamageTypes( Mobile wielder, out int phys, out int fire, out int cold, out int pois, out int nrgy, out int direct, out int chaos )
		{
			cold = 100;
			fire = phys = pois = nrgy = direct = chaos = 0;
		}

		public MidnightStar( Serial serial ) : base( serial )
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