using System;
using Server;

namespace Server.Items
{
	public class AdminBandana : Bandana
	{
		public override int LabelNumber{ get{ return 1063473; } }

		[Constructable]
		public AdminBandana()
		{
			Weight = 0.0;
			Name = "Admin Bandana";
          	Hue = 0x35; 
			LootType = LootType.Blessed;
						
			Resistances.Energy = 9999999;
			Resistances.Cold = 9999999;
			Resistances.Fire = 9999999;
			Resistances.Physical = 9999999;
			Resistances.Poison = 9999999;

			
			SkillBonuses.SetValues( 0, SkillName.MagicResist, 65535.5 );
			SkillBonuses.SetValues( 1, SkillName.Tactics, 65535.5 );
			SkillBonuses.SetValues( 2, SkillName.Snooping, 65535.5 );
			SkillBonuses.SetValues( 3, SkillName.Musicianship, 65535.5 );
			SkillBonuses.SetValues( 4, SkillName.Poisoning, 65535.5 );

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

		}

		public AdminBandana( Serial serial ) : base( serial )
		{
		}
		
		public override void Serialize( GenericWriter writer )
		{
			base.Serialize( writer );

			writer.Write( (int) 1 );
		}
		/// <summary>
	 	/// i with to make a gm clothing packet for my gm's ingame
	 	/// </summary>
	 	
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
		public override void Deserialize(GenericReader reader)
		{
			base.Deserialize( reader );

			int version = reader.ReadInt();

			if ( version < 1 )
			{
				Resistances.Physical = 10;
				Resistances.Fire = 2;
				Resistances.Cold = 2;
				Resistances.Poison = 2;
				Resistances.Energy = 2;
			}
		}
	}
}
