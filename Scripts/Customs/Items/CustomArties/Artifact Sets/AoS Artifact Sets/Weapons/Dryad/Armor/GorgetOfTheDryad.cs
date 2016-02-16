using System;
using Server;

namespace Server.Items
{
	public class GorgetOfTheDryad : LeatherGorget
	{
		public override int LabelNumber{ get{ return 1070690; } }

		public override int BasePoisonResistance{ get{ return 15; } }

		public override int InitMinHits{ get{ return 255; } }
		public override int InitMaxHits{ get{ return 255; } }

		[Constructable]
		public GorgetOfTheDryad()
		{
			Name = "Gorget of the Dryad";
			Hue = 0x48F;
			SkillBonuses.SetValues( 0, m_PossibleBonusSkills[Utility.Random(m_PossibleBonusSkills.Length)], (Utility.Random( 4 ) == 0 ? 10.0 : 5.0) );
			ArmorAttributes.SelfRepair = 5;
			Attributes.WeaponSpeed = 10;
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

		public GorgetOfTheDryad( Serial serial ) : base( serial )
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