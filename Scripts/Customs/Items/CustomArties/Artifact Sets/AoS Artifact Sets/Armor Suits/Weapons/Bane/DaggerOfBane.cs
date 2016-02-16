using System;
using Server;

namespace Server.Items
{
	public class DaggerOfBane : Dagger
	{
		public override int LabelNumber{ get{ return 1063475; } }

		public override int InitMinHits{ get{ return 255; } }
		public override int InitMaxHits{ get{ return 255; } }

		[Constructable]
		public DaggerOfBane()
		{
			Name = "Dagger of Bane";
			ItemID = 0xF51;
			Hue = 0x4F5;
			WeaponAttributes.DurabilityBonus = 100;
			this.HitPoints = this.MaxHitPoints = 255;	//Cause the Durability bonus and such and the min/max hits as well as all other hits being whole #'s...
			Attributes.BonusStam = 10;
			Attributes.AttackChance = 20;
		}

		public override void GetDamageTypes( Mobile wielder, out int phys, out int fire, out int cold, out int pois, out int nrgy, out int chaos, out int direct )
		{
			phys = 60;
			fire = 20;
			pois = 20;
			cold = nrgy = chaos = direct = 0;
		}
		
		public DaggerOfBane( Serial serial ) : base( serial )
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