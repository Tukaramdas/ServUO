using System; 
using Server; 

namespace Server.Items 
{ 
   public class RavanasHead : Item 
   { 
      [Constructable] 
      public RavanasHead() : this( 1 ) 
      { 
      } 

      [Constructable] 
      public RavanasHead( int amount ) : base( 0x1DA0 ) 
      {
	 Name = "Ravana's Head";
	        Stackable = false;
            Hue = 1281;
            Weight = 0.1; 
         Amount = amount; 
      } 

      public RavanasHead( Serial serial ) : base( serial ) 
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