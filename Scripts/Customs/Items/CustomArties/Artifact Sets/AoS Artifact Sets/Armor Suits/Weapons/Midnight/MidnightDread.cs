using System;
using Server;

namespace Server.Items
{
	public class MidnightDread : BoneHarvester
	{
		public override int LabelNumber{ get{ return 1061093; } } // Midnight Dread
		public override int ArtifactRarity{ get{ return 11; } }

		public override int InitMinHits{ get{ return 255; } }
		public override int InitMaxHits{ get{ return 255; } }

		[Constructable]
		public MidnightDread()
		{
			Name = "Midnight Dread";
			Hue = 0x455;
			SkillBonuses.SetValues( 0, SkillName.Necromancy, 5.0 );
			Attributes.RegenMana = 3;
			Attributes.SpellDamage = 10;
			Attributes.SpellChanneling = 1;
		}
		
		public override void GetDamageTypes( Mobile wielder, out int phys, out int fire, out int cold, out int pois, out int nrgy, out int chaos, out int direct )
		{
			phys = 80;
			pois = 20;
			cold = nrgy = fire = chaos = direct = 0;
		}

		public MidnightDread( Serial serial ) : base( serial )
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
		}
	}
}