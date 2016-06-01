//Created by Script Creator
using System;
using Server;

namespace Server.Items

{
          
      public class ScytheOfDeath : Scythe
      {
      public override int ArtifactRarity{ get{ return 666; } }

      public override WeaponAbility PrimaryAbility{ get{ return WeaponAbility.BleedAttack; } }
      public override WeaponAbility SecondaryAbility{ get{ return WeaponAbility.ParalyzingBlow; } }

	public override float MlSpeed{ get{ return 3.50f; } }

      public override int InitMinHits{ get{ return 225; } }
      public override int InitMaxHits{ get{ return 225; } } 
          
      [Constructable]
      public ScytheOfDeath() 
      {
        Weight = 10;
        Name = "Scythe Of Death";
        Hue = 161;
              
        WeaponAttributes.HitLightning = 55;
	    Attributes.BonusStr = 15;
        Attributes.BonusDex = 15;
        WeaponAttributes.HitLowerAttack = 45;
        WeaponAttributes.HitMagicArrow = 45;
        //WeaponAttributes.ResistColdBonus = 5;
        //WeaponAttributes.ResistEnergyBonus = 5;
        //WeaponAttributes.ResistPhysicalBonus = 5;
        //WeaponAttributes.ResistPoisonBonus = 5;
        //WeaponAttributes.ResistFireBonus = 5;
        WeaponAttributes.SelfRepair = 2;
        WeaponAttributes.UseBestSkill = 1;
        Attributes.Luck = 666;
        Attributes.NightSight = 1;
        //Attributes.ReflectPhysical = 5;
        Attributes.SpellChanneling = 1;
        Attributes.WeaponDamage = 66;      
    }
              
      public ScytheOfDeath( Serial serial ) : base( serial )  
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
