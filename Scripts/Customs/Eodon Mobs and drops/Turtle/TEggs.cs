using System;
using Server;
using Server.Items;
using Server.Mobiles;
using Server.Network;
using System.Collections;

namespace Server.Items
{
   public class TEggs : Item
   {
      [Constructable]
      public TEggs() : base( 2485 )
      {
         Name = "Dragon Turtle eggs";
         Hue = 0x489;

      }

      public override void OnDoubleClick( Mobile from )
      {

	PlayerMobile pm = from as PlayerMobile;

			if ( !IsChildOf( from.Backpack ) )
			{
				from.SendLocalizedMessage( 1042001 ); // That must be in your pack for you to use it.
			}
			else if( from.InRange( this.GetWorldLocation(), 1 ) ) 
		        {
           		from.FixedParticles( 0x373A, 10, 15, 5036, EffectLayer.Head ); 
               		from.PlaySound( 521 );
        		DragonTurtle DragonTurtle = new DragonTurtle();
        		DragonTurtle.Controlled = true;
        		DragonTurtle.ControlMaster = from;
        		DragonTurtle.IsBonded = true;
        		DragonTurtle.Location = from.Location;
        		DragonTurtle.Map = from.Map;
        		World.AddMobile( DragonTurtle );

               		from.SendMessage( "You raised a Dragon Turtle with loving care." );
      			this.Delete();
		        } 
		        else 
		        { 
		            from.SendLocalizedMessage( 500446 ); // That is too far away. 
		        }
      }

      public TEggs( Serial serial ) : base( serial )
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
