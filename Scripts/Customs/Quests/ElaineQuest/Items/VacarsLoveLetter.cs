using System;

namespace Server.Items
{
	public class VacarsLoveLetter : Item
	{
		[Constructable]
		public VacarsLoveLetter() : base( 0x14ED )
		{
		      Weight = 1.0;
              Name = "Vacar's Letter";
            }

		public VacarsLoveLetter( Serial serial ) : base( serial )
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