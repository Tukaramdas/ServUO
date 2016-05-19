using System;
using Server.Network;
using Server.Items;

namespace Server.Items
{
	[FlipableAttribute( 0x13FF, 0x13FE )]
	public class AdminKatana : BaseSword
	{
		public override WeaponAbility PrimaryAbility{ get{ return WeaponAbility.DoubleStrike; } }
		public override WeaponAbility SecondaryAbility{ get{ return WeaponAbility.ArmorIgnore; } }

		public override int AosStrengthReq{ get{ return 0; } }
		public override int AosMinDamage{ get{ return 9999999; } }
		public override int AosMaxDamage{ get{ return 9999999; } }
		public override int AosSpeed{ get{ return 9999999; } }

		public override int OldStrengthReq{ get{ return 0; } }
		public override int OldMinDamage{ get{ return 9999999; } }
		public override int OldMaxDamage{ get{ return 9999999; } }
		public override int OldSpeed{ get{ return 9999999; } }

		public override int DefHitSound{ get{ return 0x23B; } }
		public override int DefMissSound{ get{ return 0x23A; } }

		public override int InitMinHits{ get{ return 9999999; } }
		public override int InitMaxHits{ get{ return 9999999; } }
		


		[Constructable]
		public AdminKatana() : base( 0x13FF )
		{
			Hue = 0x461;
			Name = "Admin's Katana";
			Weight = 0.0;
			Quality = WeaponQuality.Exceptional;
			
			LootType = LootType.Blessed;

			SkillBonuses.SetValues( 0, SkillName.Discordance, 65535.5 );
			SkillBonuses.SetValues( 1, SkillName.EvalInt, 65535.5 );
			SkillBonuses.SetValues( 2, SkillName.Healing, 65535.5 );
			SkillBonuses.SetValues( 3, SkillName.Fishing, 65535.5 );
			SkillBonuses.SetValues( 4, SkillName.Forensics, 65535.5 );

			WeaponAttributes.HitLeechHits = 9999999;
			WeaponAttributes.HitLeechMana = 9999999;
			WeaponAttributes.HitLeechStam = 9999999;
			WeaponAttributes.DurabilityBonus = 9999999;
			WeaponAttributes.UseBestSkill = 1;
			WeaponAttributes.HitLightning = 9999999;
			WeaponAttributes.HitLowerAttack = 9999999;
			WeaponAttributes.HitLowerDefend = 9999999;

			WeaponAttributes.HitHarm = 9999999;
			WeaponAttributes.HitDispel = 9999999;
			WeaponAttributes.HitPoisonArea = 9999999;
			WeaponAttributes.HitColdArea = 9999999;
			WeaponAttributes.HitEnergyArea = 9999999;
			WeaponAttributes.HitFireArea = 9999999;
			WeaponAttributes.HitFireball = 9999999;
			WeaponAttributes.HitMagicArrow = 9999999;
			WeaponAttributes.HitPhysicalArea = 9999999;
			WeaponAttributes.LowerStatReq = 9999999;
			WeaponAttributes.ResistColdBonus = 9999999;
			WeaponAttributes.ResistEnergyBonus = 9999999;
			WeaponAttributes.ResistPhysicalBonus = 9999999;
			WeaponAttributes.SelfRepair = 9999999;
			WeaponAttributes.ResistPoisonBonus = 9999999;
			WeaponAttributes.MageWeapon = 9999999;
			WeaponAttributes.ResistFireBonus = 9999999;
						
			Poison = Poison.Lethal;
			PoisonCharges = 9999999;
			
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

		public AdminKatana( Serial serial ) : base( serial )
		{
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
