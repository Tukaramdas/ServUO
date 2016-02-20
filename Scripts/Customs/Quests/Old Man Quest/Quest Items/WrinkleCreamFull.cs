using System;
using Server.Items;
using Server.Network;

namespace Server.Items
{
	public class WrinkleCreamFull : Item
	{
		[Constructable]
		public WrinkleCreamFull() : base( 0x182b )
		{
                  Name = "Wrinkle Cream Jar (It's Full)";
                  Hue = 0;
		  Weight = 1.0;
			
		}

		public WrinkleCreamFull( Serial serial ) : base( serial )
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