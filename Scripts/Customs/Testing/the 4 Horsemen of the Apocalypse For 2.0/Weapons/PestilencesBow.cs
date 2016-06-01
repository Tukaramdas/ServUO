// Created with UO Weapon Generator
// Created On: 10/29/2007 10:54:51 PM
// By: Prplbeast

using System;
using Server;

namespace Server.Items
{
    public class PestilencesBow : Yumi
    {
        public override int ArtifactRarity{ get{ return 666; } }

	public override WeaponAbility PrimaryAbility{ get{ return WeaponAbility.ArmorPierce; } }
	public override WeaponAbility SecondaryAbility{ get{ return WeaponAbility.DoubleShot; } }

	public override float MlSpeed{ get{ return 3.50f; } }

	public override int InitMinHits{ get{ return 225; } }
	public override int InitMaxHits{ get{ return 225; } }

        [Constructable]
        public PestilencesBow()
        {
            Name = "Pestilence's Bow";
            Hue = 1153;
            Attributes.SpellChanneling = 1;
            Attributes.NightSight = 1;
           // WeaponAttributes.UseBestSkill = 1;
	       // Attributes.BonusInt = 15;
            Attributes.BonusDex = 20;
	        WeaponAttributes.HitLowerAttack = 45;
            WeaponAttributes.HitMagicArrow = 45;
	        Attributes.WeaponDamage = 60;
            Attributes.WeaponSpeed = 35;
            WeaponAttributes.HitLeechStam = 60;
            Attributes.Luck = 666;
            //WeaponAttributes.ResistPhysicalBonus = 5;
            //WeaponAttributes.ResistColdBonus = 5;
            //WeaponAttributes.ResistFireBonus = 5;
            //WeaponAttributes.ResistEnergyBonus = 5;
            //WeaponAttributes.ResistPoisonBonus = 5;
            WeaponAttributes.SelfRepair = 2;
        }

        public PestilencesBow(Serial serial) : base( serial )
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
