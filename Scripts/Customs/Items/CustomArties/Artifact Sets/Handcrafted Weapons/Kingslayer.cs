using System;
using Server;

namespace Server.Items
{
	public class Kingslayer : AssassinSpike
	{
		public override int ArtifactRarity{ get{ return 15; } }
		
		public override int InitMinHits{ get{ return 255; } }
		public override int InitMaxHits{ get{ return 255; } }

		[Constructable]
		public Kingslayer()
		{
			
			
			Name = "Kingslayer";
			
			Weight = 5.0;
			Hue = 2715;
			Attributes.AttackChance = 75;
			Attributes.WeaponDamage = 15;
			WeaponAttributes.UseBestSkill = 1;
			
				
		}

		public override void GetDamageTypes( Mobile wielder, out int phys, out int fire, out int cold, out int pois, out int nrgy, out int direct, out int chaos )
		{
			pois = 100;
			fire = cold = phys = nrgy = direct = chaos = 0;
		}

		public Kingslayer( Serial serial ) : base( serial )
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