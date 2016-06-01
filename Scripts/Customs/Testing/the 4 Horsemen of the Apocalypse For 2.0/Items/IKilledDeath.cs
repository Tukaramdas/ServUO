using System; 
using Server.Items; 

namespace Server.Items 
{
    public class IKilledDeath : Item
   {
        

       [Constructable]
       public IKilledDeath() : base( 0x2106) 
      {
          Name = "I Killed Death";
          Hue = 161;
         

      }



        public IKilledDeath(Serial serial)
           : base(serial)
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