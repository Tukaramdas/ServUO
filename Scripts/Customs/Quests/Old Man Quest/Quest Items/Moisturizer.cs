using System;
using Server.Items;
using Server.Network;

namespace Server.Items
{
	public class Moisturizer : Item
	{
		[Constructable]
		public Moisturizer() : base( 0xE2b )
        //    0xE2b (glass bottle)  0x1006 (original moisturizer)
		{
                  Name = "Moisturizer";
                  Hue = 1152;
			
		}

		public Moisturizer( Serial serial ) : base( serial )
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