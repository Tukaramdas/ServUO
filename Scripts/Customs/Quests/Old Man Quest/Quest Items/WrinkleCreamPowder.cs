using System;
using Server.Items;
using Server.Network;

namespace Server.Items
{
	public class WrinklePowder : Item
	{
		[Constructable]
		public WrinklePowder() : base( 0x1006 )
		{
                  Name = "Wrinkle Cream Powder";
                  Hue = 0;
			
		}

		public WrinklePowder( Serial serial ) : base( serial )
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