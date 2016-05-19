/////////////////////////////////////////////////
//                                             //
// Automatically generated by the              //
// AddonGenerator script by Arya               //
//                                             //
/////////////////////////////////////////////////
using System;
using Server;
using Server.Items;

namespace Server.Items
{
	public class NewLoveSeatEastAddon : BaseAddon
	{
		public override BaseAddonDeed Deed
		{
			get
			{
				return new NewLoveSeatEastAddonDeed();
			}
		}

		[ Constructable ]
		public NewLoveSeatEastAddon()
		{
			AddonComponent ac;
			ac = new AddonComponent( 1801 );
			ac.Name = "love seat";
			AddComponent( ac, 1, -1, 0 );
			ac = new AddonComponent( 1801 );
			ac.Name = "love seat";
			AddComponent( ac, 1, 0, 0 );
			ac = new AddonComponent( 1801 );
			ac.Name = "love seat";
			AddComponent( ac, 1, 2, 0 );
			ac = new AddonComponent( 1801 );
			ac.Name = "love seat";
			AddComponent( ac, 0, 2, 0 );
			ac = new AddonComponent( 1801 );
			ac.Name = "love seat";
			AddComponent( ac, 0, -1, 0 );
			ac = new AddonComponent( 1801 );
			ac.Name = "love seat";
			AddComponent( ac, 1, 1, 0 );
			ac = new AddonComponent( 2915 );
			ac.Hue = 2307;
			ac.Name = "love seat";
			AddComponent( ac, 0, 0, 0 );
			ac = new AddonComponent( 2914 );
			ac.Hue = 2307;
			ac.Name = "love seat";
			AddComponent( ac, 0, 1, 0 );

		}

		public NewLoveSeatEastAddon( Serial serial ) : base( serial )
		{
		}

		public override void Serialize( GenericWriter writer )
		{
			base.Serialize( writer );
			writer.Write( 0 ); // Version
		}

		public override void Deserialize( GenericReader reader )
		{
			base.Deserialize( reader );
			int version = reader.ReadInt();
		}
	}

	public class NewLoveSeatEastAddonDeed : BaseAddonDeed
	{
		public override BaseAddon Addon
		{
			get
			{
				return new NewLoveSeatEastAddon();
			}
		}

		[Constructable]
		public NewLoveSeatEastAddonDeed()
		{
			Name = "NewLoveSeatEast";
		}

		public NewLoveSeatEastAddonDeed( Serial serial ) : base( serial )
		{
		}

		public override void Serialize( GenericWriter writer )
		{
			base.Serialize( writer );
			writer.Write( 0 ); // Version
		}

		public override void	Deserialize( GenericReader reader )
		{
			base.Deserialize( reader );
			int version = reader.ReadInt();
		}
	}
}