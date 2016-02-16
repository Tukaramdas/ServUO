// Created By Lucid Nagual - Admin of The Conjuring
// I'd like to thank all the wonderful people for sharing they're scripts & support.
// I hope by submitting this I can at least partially pay back the Runuo Community.

using System; 
using System.Collections; 
using Server.Network; 
using Server.Items; 
using Server.Targeting; 

namespace Server.Items 
{ 

   public class Shitpile : Item 
   { 
		
      [Constructable] 
      public Shitpile() : base( 0x913 ) 
      { 
      	Hue = Utility.RandomList( 0x0, 1161, 0x44  );
        	Name = "Smelly Dung";
		m_NextAbilityTime = DateTime.Now;
	} 

      public Shitpile( Serial serial ) : base( serial ) 
      { 
      } 

	private Shoes m_Shoes;
      private DateTime m_NextAbilityTime;
      public override void Serialize( GenericWriter writer ) 
      { 
         base.Serialize( writer ); 

         writer.Write( (int) 0 ); // version 
      } 

      public override void Deserialize( GenericReader reader ) 
      { 
      	base.Deserialize( reader ); 
      	int version = reader.ReadInt(); 
      	m_NextAbilityTime = DateTime.Now;
      } 

	public override bool OnMoveOver( Mobile from )
	{
		Item feet = from.FindItemOnLayer( Layer.Shoes );
		if (feet != null)
		{
		feet.Hue = 1161;
		feet.Name = "Shoes Covered In Crap";
		}
		Effects.PlaySound( from.Location, from.Map, 1064);
		from.SendMessage( "You stepped in some poop! I suggest finding a shoe shine kit!" );
		return true;
	}
       
      public override void OnSingleClick( Mobile from ) 
      { 
      	this.LabelTo( from, 1005578 ); 
      } 

      public override void OnDoubleClick( Mobile from ) 
      { 
      	if (!IsChildOf(from.Backpack)) 
         { 
            from.SendLocalizedMessage( 1042010 ); //You must have the object in your backpack to use it. 
            return; 
         } 
      	else 
         { 
            
            if ( DateTime.Now >= m_NextAbilityTime )
		{
               from.Target = new ShitTarget( from, this ); 
               from.SendMessage( "You carefully pack the poop into a ball..." );   // You carefully pack the poop into a ball... 
            } 
            else 
            { 
               from.SendLocalizedMessage( 1005574 ); 
            } 

         } 
	    
      } 
       
      private class ShitTarget : Target 
      { 
         private Mobile m_Thrower; 
		private Shitpile m_Shit;

         public ShitTarget( Mobile thrower, Shitpile shit ) : base ( 10, false, TargetFlags.None ) 
         { 
            m_Thrower = thrower; 
		m_Shit = shit;
         } 
          
         protected override void OnTarget( Mobile from, object target ) 
         { 
            if( target == from ) 
               from.SendLocalizedMessage( 1005576 ); 
             
            else if( target is Mobile) 
            { 
			Mobile m = (Mobile)target;
			Item Shirt = m.FindItemOnLayer( Layer.Shirt );
			from.Criminal = true;
			if (Shirt != null)
			{
				Shirt.Hue = 1161;
				Shirt.Name = "a crap covered shirt";
			}
			Item Pants = m.FindItemOnLayer( Layer.Pants );
			from.Criminal = true;
			if (Pants != null)
			{
				Pants.Hue = 1161;
				Pants.Name = "a crap covered pants";
			}		   	
               	from.PlaySound( 0x145 ); 
              	from.Animate( 9, 1, 1, true, false, 0 ); 
              	from.SendMessage( "You thrown the poopball and hit the target!" );   // You throw the poopball and hit the target! 
               	m.SendMessage( "You have just been hit by a poopball!"  ); // You have just been hit by a poopball! 
               	Effects.SendMovingEffect( from, m, 0x36E4, 7, 0, false, true, 0x44, 0 ); 
               	m_Shit.m_NextAbilityTime = DateTime.Now + TimeSpan.FromSeconds( 5.0 ) ;
        } 

            else 
            { 
               from.SendLocalizedMessage( 1005577 ); 
            } 
         } 
          
      } 
   } 
    

       
       
} 



