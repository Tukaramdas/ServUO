//Remade by Dwarf
using Server;
using Server.Network;
using System;
using Server.Items;
namespace Server.Items
{
	

[Flipable( 0x1541, 0x1542 )]
	public class AdminSash : BaseMiddleTorso
	{
		public SkillMod m_SkillMod;
		public SkillMod m_SkillMod1;
		public SkillMod m_SkillMod2;
		public SkillMod m_SkillMod3;
		
		[Constructable]
		public AdminSash() : this( 0 )
		{
		}
		
		[Constructable]
		public AdminSash( int hue ) : base( 0x1541 )
		{
			Weight = 0.0;
			Name = "A Sash Of Admin";
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

		
			Resistances.Energy = 9999999;
			Resistances.Cold = 9999999;
			Resistances.Fire = 9999999;
			Resistances.Physical = 9999999;
			Resistances.Poison = 9999999;

            LootType = LootType.Blessed;
			Hue = 1153;
		}
		public override bool OnEquip( Mobile m )
		{
			base.OnEquip( m );
			m_SkillMod1 = new DefaultSkillMod( SkillName.Archery, true, 10 );
			m.AddSkillMod(m_SkillMod1 );
			m_SkillMod2 = new DefaultSkillMod( SkillName.Tactics, true, 10 );
			m.AddSkillMod(m_SkillMod2 );
			m_SkillMod3 = new DefaultSkillMod( SkillName.Anatomy, true, 10 );
			m.AddSkillMod(m_SkillMod3 );
			return true;
			
			/// <summary>
	 	/// i with to make a gm clothing packet for my gm's ingame
	 	/// </summary>
	 	
	 	if ( m.AccessLevel <= AccessLevel.GameMaster )
		    {
	 			m.SendMessage( "You are not granted to wear this item" );
		    	this.Delete();
		    	return false;
	 		}
	 		else
	 		{
	 			m.SendMessage( "Access Granted mighty one" );
	 			return true;
	 		}
	 				
		}

		public override void OnRemoved( object parent )
		{
			base.OnRemoved( parent );

			if ( m_SkillMod1 != null ) 
			m_SkillMod1.Remove(); 
			
			
			if ( m_SkillMod2 != null ) 
			m_SkillMod2.Remove(); 
			
			
			if ( m_SkillMod3 != null ) 
			m_SkillMod3.Remove();
		}

		public AdminSash( Serial serial ) : base( serial )
		{
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
