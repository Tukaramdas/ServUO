using System; 
using Server.Items; 

namespace Server.Items 
{
    public class IKilledPestilence : Item
   {
        

       [Constructable]
       public IKilledPestilence() : base( 0x2106) 
      {
          Name = "I Killed Pestilence";
          Hue = 1153;
         

      }



        public IKilledPestilence(Serial serial)
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