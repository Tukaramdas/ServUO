//Origianl Script by Samuel of Lost Worlds, Admin//
// Scripted on 9/9/04//
//Modified to work with Wildhorse script. Lucid Nagual Admin of The Conjuring.

using System; 
using Server; 

namespace Server.Items 
{ 
	public class ShoutForShirt : Item
	{ 
		
		[Constructable]
		public ShoutForShirt() : base( 0xE29 ) 
		{
			Weight = 1.0; 
			Name = "Shout Stain Remover for Shirts"; 
		} 

		public ShoutForShirt( Serial serial ) : base( serial ) 
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
				Item shirt = from.FindItemOnLayer( Layer.Shirt );
				if (shirt == null)
				from.SendMessage( "you are not wearing a shirt needing cleaning!" );
			else
			{
				shirt.Hue = 0;
				shirt.Name = null;
				from.SendMessage( "Your shirt has been cleaned." );
				from.SendMessage( "It seems to have bleached your shirt out, you may need to re-dye it." );
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
