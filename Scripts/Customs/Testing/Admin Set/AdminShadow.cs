using System;
using Server;
namespace Server.Items
{

[Flipable( 0x2684, 0x2683 )]
	public class AdminShadow : BaseOuterTorso
	{
		[Constructable]
		public AdminShadow() : this( 0x455 )
		{
			Weight = 0.0;
            Hue = 0x497;
            Name = "Admin Shadow";
		
            Attributes.Luck = 9999999;
			Attributes.LowerManaCost = 9999999;
			Attributes.LowerRegCost = 9999999;

			Attributes.BonusStr = 9999999;
			Attributes.BonusHits = 9999999;
			Attributes.BonusDex = 9999999;
			Attributes.BonusMana = 9999999;
			Attributes.BonusInt = 9999999;
			Attributes.BonusStam = 9999999;
			Attributes.CastSpeed = 9999999;
			Attributes.EnhancePotions = 9999999;

			Attributes.WeaponDamage = 9999999;
			Attributes.AttackChance = 9999999;
			Attributes.DefendChance = 9999999;

			Attributes.RegenStam = 9999999;
			Attributes.RegenHits = 9999999;
			Attributes.RegenMana = 9999999;
			Attributes.NightSight = 9999999;

			Attributes.WeaponSpeed = 9999999;
			Attributes.SpellDamage = 9999999;
			Attributes.SpellChanneling = 1;
			Attributes.CastRecovery = 9999999;
			Attributes.WeaponSpeed = 9999999;
			Attributes.ReflectPhysical = 9999999;

			
			SkillBonuses.SetValues( 0, SkillName.Herding, 65535.5 );
			SkillBonuses.SetValues( 1, SkillName.Provocation, 65535.5 );
			SkillBonuses.SetValues( 2, SkillName.Inscribe, 65535.5 );
			SkillBonuses.SetValues( 3, SkillName.Lockpicking, 65535.5 );
			SkillBonuses.SetValues( 4, SkillName.Magery, 65535.5 );
		
		}

		[Constructable]
		public AdminShadow( int hue ) : base( 0x2684, hue )
		{
			LootType = LootType.Blessed;
			Weight = 3.0;
		}

		public override bool Dye( Mobile from, DyeTub sender )
		{
			from.SendLocalizedMessage( sender.FailMessage );
			return false;
		}

		public AdminShadow( Serial serial ) : base( serial )
		{
		}

		public override bool OnEquip( Mobile from )
	 	{     
	 		if ( from.AccessLevel <= AccessLevel.GameMaster )
		    {
	 			from.SendMessage( "You are not granted to wear this item" );
		    	this.Delete();
		    	return false;
	 		}
	 		else
	 		{
	 			from.SendMessage( "Access Granted mighty one" );
	 			return true;
	 		}
	 	}
		
		public override void Serialize( GenericWriter writer )
		{
			base.Serialize( writer );

			writer.Write( (int) 0 ); // version
		}

		public override void Deserialize( GenericReader reader )
		{
			base.Deserialize( reader );

			int version = reader.ReadInt();
		}
	}
}
