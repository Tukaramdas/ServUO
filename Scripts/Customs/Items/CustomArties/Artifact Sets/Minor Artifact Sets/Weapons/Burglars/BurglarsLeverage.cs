using System;
using Server;

namespace Server.Items
{
	public class BurglarsLeverage : Dagger
	{
		public override int LabelNumber{ get{ return 1063475; } }

		public override int InitMinHits{ get{ return 255; } }
		public override int InitMaxHits{ get{ return 255; } }

		[Constructable]
		public BurglarsLeverage()
		{
			Name = "Burglars Leverage";
			ItemID = 0xF51;
			
			Hue = Utility.RandomBool() ? 0x58C : 0x10;

			SkillBonuses.SetValues( 0, SkillName.Stealing, 5.0 );
			SkillBonuses.SetValues( 1, SkillName.Stealth, 5.0 );
			SkillBonuses.SetValues( 2, SkillName.Snooping, 5.0 );

			Attributes.BonusDex = 5;
			Attributes.WeaponSpeed = 10;
			Attributes.WeaponDamage = 15;
		}

		public BurglarsLeverage( Serial serial ) : base( serial )
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