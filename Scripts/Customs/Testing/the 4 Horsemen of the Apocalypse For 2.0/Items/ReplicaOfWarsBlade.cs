using System; 
using Server.Items; 

namespace Server.Items 
{
    public class ReplicaOfWarsBlade : Item
   {
        

       [Constructable]
       public ReplicaOfWarsBlade() : base( 0xf5e) 
      {
          Name = "Replica Of War's Blade";
          Hue = 1153;
         

      }



        public ReplicaOfWarsBlade(Serial serial)
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