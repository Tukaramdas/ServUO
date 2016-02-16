using System;

namespace Server.Items
{
	public class AcarasRing : Item
	{
		[Constructable]
		public AcarasRing() : base( 0x1F09 )
		{
		      Weight = 1.0;
              Name = "Acara's Ring";

            }

		public AcarasRing( Serial serial ) : base( serial )
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
		      
                  if ( Weight == 4.0 )
				Weight = 1.0;

            }
	}
}