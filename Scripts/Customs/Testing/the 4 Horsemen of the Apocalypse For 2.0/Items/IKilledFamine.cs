using System; 
using Server.Items; 

namespace Server.Items 
{
    public class IkilledFamine : Item
   {
        

       [Constructable]
       public IkilledFamine() : base( 0x2106) 
      {
          Name = "I killed Famine";
          Hue = 927;
         

      }



        public IkilledFamine(Serial serial)
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