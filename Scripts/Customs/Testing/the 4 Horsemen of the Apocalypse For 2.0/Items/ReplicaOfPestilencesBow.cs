using System; 
using Server.Items; 

namespace Server.Items 
{
    public class ReplicaOfPestilencesBow : Item
   {
        

       [Constructable]
       public ReplicaOfPestilencesBow() : base( 0x27af) 
      {
          Name = "Replica Of Pestilence's Bow";
          Hue = 1153;
         

      }



        public ReplicaOfPestilencesBow(Serial serial)
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