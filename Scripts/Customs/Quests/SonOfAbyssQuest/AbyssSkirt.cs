/////////// Scripted By TALON NYTE ///////////

using System;
using Server;
namespace Server.Items
{
 public class AbyssSkirt : LeatherSkirt
 {
 public override int InitMinHits{ get{ return 300;}}
 public override int InitMaxHits{ get{ return 300;}}
 public override bool AllowMaleWearer { get { return false; } }
 [Constructable]
 public AbyssSkirt()
     {
         Hue = 1172;
         Name = "Abyss Skirt";
         
            Attributes.LowerRegCost = 25;
         Attributes.CastRecovery = Utility.RandomMinMax(3, 7);
         Attributes.CastSpeed = Utility.RandomMinMax(2, 10);
         Attributes.SpellDamage = Utility.RandomMinMax(15, 35);
         Attributes.Luck = Utility.RandomMinMax(100, 500);
         Attributes.BonusStr = Utility.RandomMinMax(15, 35);
         Attributes.WeaponSpeed = Utility.RandomMinMax(15, 35);
         Attributes.SpellChanneling = 1;

            PhysicalBonus = Utility.RandomMinMax(10, 30);
            ColdBonus = Utility.RandomMinMax(10, 30);
            EnergyBonus = Utility.RandomMinMax(10, 30);
            PoisonBonus = Utility.RandomMinMax(10, 30);
            FireBonus =   Utility.RandomMinMax(10, 30);
     }
public AbyssSkirt( Serial serial ) : base( serial )
   
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
