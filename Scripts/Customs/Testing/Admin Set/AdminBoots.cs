using System;
using Server.Items;


namespace Server.Items
{
    public class AdminBoots : BaseArmor
    {
        public override int ArtifactRarity { get { return 9999999; } }  
        public override int InitMinHits{ get{ return 255; } }
		public override int InitMaxHits{ get{ return 255; } }
        public override int PhysicalResistance { get { return 9999999; } }
        public override int PoisonResistance { get { return 9999999; } }
        public override int FireResistance { get { return 9999999; } } 
        public override int EnergyResistance { get { return 9999999; } } 
        public override int ColdResistance { get { return 9999999; } } 
		public override ArmorMaterialType MaterialType{ get{ return ArmorMaterialType.Leather; } }
                
		[Constructable]
		public AdminBoots() : base( 0x1711 )
		{
			Weight = 0.0;
            Hue = 0x497;
            Name = "AdminBoots Boots";
		
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

			ArmorAttributes.MageArmor = 9999999;		
			ArmorAttributes.SelfRepair = 9999999;
			ArmorAttributes.DurabilityBonus = 9999999;
			ArmorAttributes.LowerStatReq = 9999999;
			
			FireBonus = 9999999;
			ColdBonus = 9999999;
			EnergyBonus = 9999999;
			PhysicalBonus = 9999999;
			PoisonBonus = 9999999;

			DexBonus  = 9999999;
			IntBonus = 9999999;
			StrBonus = 9999999;

			SkillBonuses.SetValues( 0, SkillName.Herding, 65535.5 );
			SkillBonuses.SetValues( 1, SkillName.Provocation, 65535.5 );
			SkillBonuses.SetValues( 2, SkillName.Inscribe, 65535.5 );
			SkillBonuses.SetValues( 3, SkillName.Lockpicking, 65535.5 );
			SkillBonuses.SetValues( 4, SkillName.Magery, 65535.5 );
            
		}

		public AdminBoots( Serial serial ) : base( serial )
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
			writer.Write( (int) 0 );
		}
		
		public override void Deserialize(GenericReader reader)
		{
			base.Deserialize( reader );
			int version = reader.ReadInt();
		}
	}
}
