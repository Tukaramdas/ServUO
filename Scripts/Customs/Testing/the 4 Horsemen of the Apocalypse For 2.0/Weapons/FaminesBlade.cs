// Created with UO Weapon Generator
// Created On: 10/29/2007 10:46:13 PM
// By: Prplbeast

using System;
using Server;

namespace Server.Items
{
    public class FaminesBlade : LargeBattleAxe
    {
        public override int ArtifactRarity { get { return 666; } }

	public override WeaponAbility PrimaryAbility{ get{ return WeaponAbility.WhirlwindAttack; } }
	public override WeaponAbility SecondaryAbility{ get{ return WeaponAbility.BleedAttack; } }

	public override float MlSpeed{ get{ return 3.50f; } }


	public override int InitMinHits{ get{ return 225; } }
	public override int InitMaxHits{ get{ return 225; } }

        [Constructable]
        public FaminesBlade()
        {
            Name = "Famine's Blade";
            Hue = 38;
            Attributes.SpellChanneling = 1;
            Attributes.NightSight = 1;
            Attributes.BonusStr = 10;
            //Attributes.BonusInt = 10;
            //Attributes.BonusDex = 10;
            Attributes.RegenHits = 3;
            WeaponAttributes.UseBestSkill = 1;
            WeaponAttributes.HitLeechMana = 57;
            Attributes.WeaponDamage = 66;
            Attributes.WeaponSpeed = 30;
            Attributes.Luck = 75;
            //WeaponAttributes.ResistPhysicalBonus = 5;
            //WeaponAttributes.ResistColdBonus = 5;
            //WeaponAttributes.ResistFireBonus = 5;
            //WeaponAttributes.ResistEnergyBonus = 5;
            //WeaponAttributes.ResistPoisonBonus = 5;
            WeaponAttributes.SelfRepair = 2;
        }

        public FaminesBlade(Serial serial) : base( serial )
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
    } // End Class
} // End Namespace
