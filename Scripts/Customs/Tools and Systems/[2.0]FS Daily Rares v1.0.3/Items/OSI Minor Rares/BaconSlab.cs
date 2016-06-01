using System;

namespace Server.Items
{
	[Flipable( 0x976, 0x977)]
	public class BaconSlab : Food
	{
		[Constructable]
		public BaconSlab() : this( 1 )
		{
		}

		[Constructable]
		public BaconSlab( int amount ) : base( 0x976 )
		{
			ItemID = Utility.RandomList( 2422, 2423 );
			Stackable = true;
			Weight = 1.0;
			Amount = amount;
		}

		/*public override Item Dupe( int amount )
		{
			return base.Dupe( new BaconSlab( amount ), amount );
		}*/

		public BaconSlab( Serial serial ) : base( serial )
		{
		}

		public override void Serialize( GenericWriter writer )
		{
			base.Serialize( writer );

			writer.Write( (int) 0 );
		}

		public override void Deserialize( GenericReader reader )
		{
			base.Deserialize( reader );

			int version = reader.ReadInt();
		}
	}
}