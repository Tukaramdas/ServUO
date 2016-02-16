using System;
using Server;

namespace Server.Items
{
	public class ShadowDancerNeedle : AssassinSpike
	{
		public override int LabelNumber{ get{ return 1061598; } } // Shadow Dancer Needle
		public override int ArtifactRarity{ get{ return 11; } }

		public override int InitMinHits{ get{ return 255; } }
		public override int InitMaxHits{ get{ return 255; } }

		[Constructable]
		public ShadowDancerNeedle()
		{
			Name = "Shadow Dancer's Needle";
			Hue = 0x455;
			SkillBonuses.SetValues( 0, SkillName.Stealth, 5.0 );
			SkillBonuses.SetValues( 1, SkillName.Fencing, 5.0 );
			WeaponAttributes.HitLeechStam = 5;
			Attributes.BonusDex = 5;
			Attributes.RegenStam = 2;
		}
		
		public override void GetDamageTypes( Mobile wielder, out int phys, out int fire, out int cold, out int pois, out int nrgy, out int chaos, out int direct )
		{
			phys = 60;
			pois = 20;
			nrgy = 20;
			fire = cold = chaos = direct = 0;
		}

		public ShadowDancerNeedle( Serial serial ) : base( serial )
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