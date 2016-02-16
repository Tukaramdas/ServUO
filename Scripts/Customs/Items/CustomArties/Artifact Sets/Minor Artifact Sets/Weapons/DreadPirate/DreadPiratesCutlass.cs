using System;
using Server;

namespace Server.Items
{
	public class DreadPiratesCutlass : Cutlass
	{
		public override int LabelNumber{ get{ return 1063474; } }

		public override int InitMinHits{ get{ return 255; } }
		public override int InitMaxHits{ get{ return 255; } }

		[Constructable]
		public DreadPiratesCutlass()
		{
			Name = "Dread Pirates Cutlass";
			Hue = 0x497;

			SkillBonuses.SetValues( 0, Utility.RandomCombatSkill(), 10.0 );

			Attributes.BonusDex = 5;
			Attributes.AttackChance = 5;
			Attributes.WeaponSpeed = 15;
			Attributes.WeaponDamage = 50;
			WeaponAttributes.UseBestSkill = 1;
		}

		public DreadPiratesCutlass( Serial serial ) : base( serial )
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

			if( Attributes.AttackChance == 50 )
				Attributes.AttackChance = 10;
		}
	}
}