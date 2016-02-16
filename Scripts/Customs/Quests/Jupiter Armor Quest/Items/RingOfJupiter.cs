////Jupitor Armor Quest Scripted By lllTalonlll////

using System;
using Server;
namespace Server.Items
{
 public class RingOfJupiter : GoldRing
 {
 [Constructable]
 public RingOfJupiter() 
     {
         Name = "Ring Of Jupiter";
         Hue = 193;
       
         
     }
public RingOfJupiter( Serial serial ) : base( serial )
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
