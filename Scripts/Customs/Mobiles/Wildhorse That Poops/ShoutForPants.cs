//Origianl Script by Samuel of Lost Worlds, Admin//
// Scripted on 9/9/04//
//Modified to work with Wildhorse script. Lucid Nagual Admin of The Conjuring.

using System; 
using Server; 

namespace Server.Items 
{ 
	public class ShoutForPants : Item
	{ 
		
		[Constructable]
		public ShoutForPants() : base( 0xE29 ) 
		{
			Weight = 1.0; 
			Name = "Shout Stain Remover for Pants"; 
		} 

		public ShoutForPants( Serial serial ) : base( serial ) 
		{ 
		} 

		public override void Serialize( GenericWriter writer ) 
		{ 
			base.Serialize( writer ); 
			writer.Write( (int) 0 ); 
		} 
       
		public override void Deserialize(GenericReader reader) 
		{ 
			base.Deserialize( reader ); 
			int version = reader.ReadInt(); 
		}

		public override void OnDoubleClick( Mobile from ) 
		{ 
			if ( IsChildOf( from.Backpack ) )
			{               
				Item pants = from.FindItemOnLayer( Layer.Pants );
				if (pants == null)
				from.SendMessage( "you are not wearing pants that needing cleaning!" );
			else
			{
				pants.Hue = 0;
				pants.Name = null;
				from.SendMessage( "Your pants have been cleaned." );
				from.SendMessage( "It seems to have bleached your pants out, you may need to re-dye it." );
			    	from.PlaySound( 995 );
			    	Consume();
			}
		} 
			else 
			{ 
				from.SendLocalizedMessage( 1042001 ); // That must be in your pack to use. 
			} 
		}
	} 
}
