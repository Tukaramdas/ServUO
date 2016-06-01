using System; 
using Server; 
using Server.Items; 

namespace Server.Items 
{ 
   public class RunicGolemAssemblyBag : Bag
   { 
      [Constructable] 
      public RunicGolemAssemblyBag() : this( 1 )
      { 
        Movable = true; 
        //Hue = 0x386;
        Name = "Runic Golem Assembly Bag";
      } 
      [Constructable] 
      public RunicGolemAssemblyBag( int amount )
      { 
         DropItem( new RunicGolemPowerCore() );
         DropItem( new IronIngot(150) );
         DropItem( new BronzeIngot(75) );
         DropItem( new Gears(25) );
        //DropItem( new DaemonBone(50) );
         DropItem( new RunicClockworkAssembly() );
         DropItem( new AssemblyUpgradeKit() );
      } 


      public RunicGolemAssemblyBag( Serial serial ) : base( serial )
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
