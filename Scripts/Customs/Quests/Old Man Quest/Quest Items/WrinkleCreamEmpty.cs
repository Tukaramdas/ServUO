using System;
using Server;
using Server.Gumps;
using Server.Network;
using System.Collections;
using Server.Multis;
using Server.Mobiles;
using Server.Items;

namespace Server.Items
{

	public class WrinkleCreamEmpty : Item
	{
		[Constructable]
		public WrinkleCreamEmpty() : this( null )
		{
		}

		[Constructable]
		public WrinkleCreamEmpty ( string name ) : base ( 0x182c )
		{
			Name = "Glass Jar *It says Old Man Wrinkle Cream on the side* (It's Empty)";
			Hue = 1153;
		}

		public WrinkleCreamEmpty ( Serial serial ) : base ( serial )
		{
		}

      		
	public override void OnDoubleClick( Mobile m )

		{	
			Item [] a = m.Backpack.FindItemsByType( typeof( WrinklePowder ) );
			if ( a!= null && a.Length >= 1)
			{
				
			Item b = m.Backpack.FindItemByType( typeof( WrinkleCreamEmpty ) );
			if ( b != null )
			{	
			Item c = m.Backpack.FindItemByType( typeof(Moisturizer) );
			if ( c != null )
			{
				for(int i=0;i<1;i++) a[i].Delete();
				b.Delete();
				c.Delete();
				m.AddToBackpack( new WrinkleCreamFull() );
				m.SendMessage("Congradulations, You have fill the Jar Return back to IcE-GoD and Claim your prize");
			}
			}						
			}
			else
			{
				m.SendMessage( "What is this? It Is no Full! Go Back and Fill it up!" ); 
			}
		}
		
		
		
		public override void Serialize ( GenericWriter writer)
		{
			base.Serialize ( writer );

			writer.Write ( (int) 0);
		}

		public override void Deserialize( GenericReader reader )
		{
			base.Deserialize ( reader );

			int version = reader.ReadInt();
		}
	}
}
