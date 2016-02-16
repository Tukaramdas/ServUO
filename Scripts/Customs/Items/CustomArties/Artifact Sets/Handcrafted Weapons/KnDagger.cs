using System;
using Server;

namespace Server.Items
{
	public class KnDagger : Leafblade
	{
		public override int ArtifactRarity{ get{ return 40; } }
		
		public override int InitMinHits{ get{ return 255; } }
		public override int InitMaxHits{ get{ return 255; } }

		[Constructable]
		public KnDagger()
		{
			
			
			Name = "Knight's Guilded Dagger";
			Weight = 3.0;
			Hue = 2835;
			Attributes.WeaponSpeed = 50;
			Attributes.WeaponDamage = 10;
			Attributes.AttackChance = 5;
			WeaponAttributes.ResistEnergyBonus = 10;
			WeaponAttributes.UseBestSkill = 1;		
		}

		public override void GetDamageTypes( Mobile wielder, out int phys, out int fire, out int cold, out int pois, out int nrgy, out int direct, out int chaos )
		{

			fire = cold = phys = pois = nrgy = 20;
			direct = chaos = 0;
		}

		public KnDagger( Serial serial ) : base( serial )
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