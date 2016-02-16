using System;
using Server;

namespace Server.Items
{
	public class NaturesWill : WildStaff
	{
		public override int ArtifactRarity{ get{ return 95; } }
		
		public override int InitMinHits{ get{ return 255; } }
		public override int InitMaxHits{ get{ return 255; } }

		[Constructable]
		public NaturesWill()
		{
		
			Name = "Nature's Will";
			Weight = 10.0;
			Hue = 2547;
			SkillBonuses.SetValues( 0, SkillName.AnimalLore, 15.0 );
			SkillBonuses.SetValues( 0, SkillName.AnimalTaming, 15.0 );
			Slayer = SlayerName.Silver;
			Attributes.WeaponSpeed = 40;
			Attributes.BonusStr = 10;
			Attributes.BonusInt = 10;
		}

		public override void GetDamageTypes( Mobile wielder, out int phys, out int fire, out int cold, out int pois, out int nrgy, out int direct, out int chaos )
		{

			cold = fire = phys = pois = nrgy = 20;
			direct = chaos = 0;
		}

		public NaturesWill( Serial serial ) : base( serial )
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