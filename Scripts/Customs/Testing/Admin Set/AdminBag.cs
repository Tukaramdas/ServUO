/* This package was my VERY first attempt
 * Scripter in  RUNUO.COM  : WarlorZ
  * Feel free to custom this package, but leave main header ALONE :P
  * This is a package that works for RUNUO2 RC1 and higher
*/

using System;
using Server; 
using Server.Items;
namespace Server.Items
{ 
   public class AdminBag : Bag //ITEMNAME is AdminBag
   { 
   	
  [Constructable] 
  public AdminBag() : this( 1 ) 
  { 
   Movable = true; 
   Hue = 0x250; //SET hue you want here
   Name = "Admin Bag";
   Weight = 0.0;
   
  }
  [Constructable]
  public AdminBag( int amount )
  {
   DropItem( new AdminKatana() );
   DropItem( new AdminRing() );
   DropItem( new AdminEarrings() );
   DropItem( new AdminCollar() );
   DropItem( new AdminBoots() );
   DropItem( new AdminBandana() );
   
   DropItem( new AdminWatch() );
   DropItem( new AdminLeggings() );
   DropItem( new AdminShield() );
  
   DropItem( new AdminShadow() );
   DropItem( new AdminBreastplate() );
   DropItem( new AdminArms() );
  
    
  // DropItem( new RecallBag() ); - allow this package to also implement the recall stone package (bag)
  
  }
      public AdminBag( Serial serial ) : base( serial ) 
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
