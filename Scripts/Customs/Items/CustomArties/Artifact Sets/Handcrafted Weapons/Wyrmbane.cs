using System;
using Server;

namespace Server.Items
{
	public class Wyrmbane : Bow
	{
		public override int ArtifactRarity{ get{ return 65; } }
		
		public override int InitMinHits{ get{ return 255; } }
		public override int InitMaxHits{ get{ return 255; } }

		[Constructable]
		public Wyrmbane()
		{
			
			
			Name = "Wyrmbane";
			Weight = 5.0;
			Hue = 1965;
			Slayer = SlayerName.ReptilianDeath;
			Attributes.WeaponDamage = 35;
			WeaponAttributes.ResistFireBonus = 20;
			WeaponAttributes.UseBestSkill = 1;
			Attributes.WeaponSpeed = 15;
		}

		public override void GetDamageTypes( Mobile wielder, out int phys, out int fire, out int cold, out int pois, out int nrgy, out int direct, out int chaos )
		{
			fire = cold = phys = pois = nrgy = 20;
			direct = chaos = 0;
		}

		public Wyrmbane( Serial serial ) : base( serial )
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