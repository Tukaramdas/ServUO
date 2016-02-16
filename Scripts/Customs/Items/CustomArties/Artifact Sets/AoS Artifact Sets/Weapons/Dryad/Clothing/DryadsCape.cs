using System;
using Server;

namespace Server.Items
{
	public class DryadsCape : FurCape
	{
		public override int LabelNumber{ get{ return 1061111; } } // DryadsCape
		public override int ArtifactRarity{ get{ return 11; } }
		
		public override int BasePoisonResistance{ get{ return 10; } }
		
		public override int InitMinHits{ get{ return 255; } }
		public override int InitMaxHits{ get{ return 255; } }

		[Constructable]
		public DryadsCape()
		{
			Name = "Dryads Cape";
			Hue = 0x48F;
			SkillBonuses.SetValues( 0, m_PossibleBonusSkills[Utility.Random(m_PossibleBonusSkills.Length)], (Utility.Random( 4 ) == 0 ? 10.0 : 5.0) );
			Attributes.WeaponSpeed = 5;
			Attributes.WeaponDamage = 10;
		}

		private static SkillName[] m_PossibleBonusSkills = new SkillName[]
			{
				SkillName.Archery,
				SkillName.Healing,
				SkillName.MagicResist,
				SkillName.Peacemaking,
				SkillName.Chivalry,
				SkillName.Ninjitsu
			};

		public DryadsCape( Serial serial ) : base( serial )
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