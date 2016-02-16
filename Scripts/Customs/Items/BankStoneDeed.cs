using System; 
using Server.Network; 
using Server.Prompts; 
using Server.Guilds; 
using Server.Multis; 
using Server.Regions; 

namespace Server.Items 
{ 
   public class BankStoneDeed : Item 
   { 
      // public override int LabelNumber{ get{ return 1041055; } } // a guild deed 

      [Constructable] 
      public BankStoneDeed() : base( 0x14F0 ) 
      { 
         Name = "a bank stone deed"; 
         Weight = 1.0; 
      } 

      public BankStoneDeed( Serial serial ) : base( serial ) 
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

         if ( Weight == 0.0 ) 
            Weight = 1.0; 
      } 

      public override void OnDoubleClick( Mobile from ) 
      { 
         if ( !IsChildOf( from.Backpack ) ) 
         { 
            from.SendLocalizedMessage( 1042001 ); // That must be in your pack for you to use it. 
         } 
         else 
         { 
            BaseHouse house = BaseHouse.FindHouseAt( from ); 

            if ( house == null ) 
            { 
               from.SendMessage( "You can only place a bank stone in a house" ); 
            } 
            else if ( !house.IsOwner( from ) ) 
            { 
               from.SendMessage( "You can only place a bank stone in a house you own" ); 
            } 
            else 
            { 
               this.Delete(); 

               BankStone stone = new BankStone( ); 

               stone.MoveToWorld( from.Location, from.Map ); 
            } 
         } 
      } 
   } 
} 
// created on 9/17/2003 at 10:43 AM
