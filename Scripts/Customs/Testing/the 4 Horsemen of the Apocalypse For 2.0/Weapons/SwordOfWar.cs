// Created with UO Weapon Generator
// Created On: 10/29/2007 10:39:46 PM
// By: Prplbeast

using System;
using Server;

namespace Server.Items
{
    public class SwordOfWar : Broadsword
    {
        public override int ArtifactRarity{ get{ return 666; } }

	public override WeaponAbility PrimaryAbility{ get{ return WeaponAbility.CrushingBlow; } }
	public override WeaponAbility SecondaryAbility{ get{ return WeaponAbility.ArmorIgnore; } }

	public override float MlSpeed{ get{ return 2.50f; } }

	public override int InitMinHits{ get{ return 225; } }
        public override int InitMaxHits{ get{ return 225; } }

        [Constructable]
        public SwordOfWar()
        {
            Name = "War's Sword";
            Hue = 32;
            Attributes.SpellChanneling = 1;
            Attributes.NightSight = 1;
            Attributes.RegenHits = 5;
	        Attributes.BonusStr = 10;
            //Attributes.BonusDex = 20;
            //WeaponAttributes.UseBestSkill = 1;
            WeaponAttributes.HitLeechHits = 50;
            //Attributes.AttackChance = 25;
            Attributes.DefendChance = 5;
	        Attributes.WeaponDamage = 66;
            Attributes.WeaponSpeed = 40;
            Attributes.Luck = 666;
            //WeaponAttributes.ResistPhysicalBonus = 5;
            //WeaponAttributes.ResistColdBonus = 5;
            //WeaponAttributes.ResistFireBonus = 5;
            //WeaponAttributes.ResistEnergyBonus = 5;
            //WeaponAttributes.ResistPoisonBonus = 5;
            WeaponAttributes.SelfRepair = 2;
            WeaponAttributes.HitHarm = 40;
            WeaponAttributes.HitFireball = 58;
            //WeaponAttributes.HitLightning = 45;
        }

        public SwordOfWar(Serial serial) : base( serial )
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
