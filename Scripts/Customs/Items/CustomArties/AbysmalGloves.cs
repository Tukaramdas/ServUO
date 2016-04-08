using System;
using Server;
namespace Server.Items
{
 public class AbysmalGloves : LeatherGloves, ITokunoDyable
 {
 public override int InitMinHits{ get{ return 255;}}
 public override int InitMaxHits{ get{ return 255;}}
 public override int ArtifactRarity{ get{ return 12; } }
 [Constructable]
 public AbysmalGloves()
     {
        Hue = 1172;
         Name = "Abysmal Gloves";
         ColdBonus = 13;
         EnergyBonus = 19;
         PhysicalBonus = 17;
         PoisonBonus = 17;
         FireBonus = 10;
         ArmorAttributes.SelfRepair = 10;
         Attributes.BonusInt = 5;
         Attributes.LowerManaCost = 15;
         Attributes.LowerRegCost = 20;
         Attributes.SpellDamage = 35;;
         Attributes.RegenMana = 5;
     }
public AbysmalGloves( Serial serial ) : base( serial )
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
