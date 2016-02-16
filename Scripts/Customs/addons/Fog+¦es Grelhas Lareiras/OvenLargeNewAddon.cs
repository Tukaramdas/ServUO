/////////////////////////////////////////////////
//                                             //
// Automatically generated by the              //
// AddonGenerator script by Arya               //
//                                             //
/////////////////////////////////////////////////

namespace Server.Items
{
    public class OvenLargeNewAddon : BaseAddon
	{
		public override BaseAddonDeed Deed
		{
			get
			{
				return new OvenLargeNewAddonDeed();
			}
		}

		[ Constructable ]
		public OvenLargeNewAddon()
		{
			AddonComponent ac;
			ac = new AddonComponent( 53 );
			AddComponent( ac, -1, -1, 0 );
			ac = new AddonComponent( 1801 );
			ac.Hue = 1102;
			ac.Name = "oven";
			AddComponent( ac, 0, -1, 0 );
			ac = new AddonComponent( 1801 );
			ac.Hue = 1102;
			ac.Name = "oven";
			AddComponent( ac, 1, -1, 0 );
			ac = new AddonComponent( 52 );
			AddComponent( ac, 0, -2, 0 );
			ac = new AddonComponent( 54 );
			AddComponent( ac, -1, -2, 0 );
			ac = new AddonComponent( 73 );
			AddComponent( ac, 0, -1, 0 );
			ac = new AddonComponent( 84 );
			AddComponent( ac, 0, -1, 18 );
			ac = new AddonComponent( 66 );
			AddComponent( ac, 1, -2, 0 );
			ac = new AddonComponent( 67 );
			AddComponent( ac, 1, -1, 0 );
			ac = new AddonComponent( 1305 );
			ac.Hue = 1102;
			ac.Name = "oven";
			AddComponent( ac, 0, -1, 7 );
			ac = new AddonComponent( 3561 );
			ac.Light = LightType.Circle225;
			AddComponent( ac, 0, -1, 4 );
			ac = new AddonComponent( 7386 );
			ac.Hue = 1891;
			ac.Name = "rack";
			AddComponent( ac, 0, -1, 8 );
			ac = new AddonComponent( 2252 );
			ac.Hue = 1891;
			ac.Name = "rack";
			AddComponent( ac, 0, -1, 8 );
			ac = new AddonComponent( 2254 );
			ac.Hue = 1891;
			AddComponent( ac, 0, -2, 10 );
			ac = new AddonComponent( 6571 );
			ac.Light = LightType.Circle225;
			AddComponent( ac, 0, -1, 5 );
			ac = new AddonComponent( 68 );
			AddComponent( ac, 0, -2, 4 );
			ac = new AddonComponent( 1305 );
			ac.Hue = 1891;
			AddComponent( ac, 2, -1, 0 );
			ac = new AddonComponent( 1305 );
			ac.Hue = 1891;
			AddComponent( ac, 2, -2, 0 );
			ac = new AddonComponent( 1305 );
			ac.Hue = 1891;
			AddComponent( ac, 1, -2, 0 );
			ac = new AddonComponent( 1305 );
			ac.Hue = 1891;
			AddComponent( ac, 0, -2, 0 );
			ac = new AddonComponent( 7807 );
			ac.Name = "table";
			AddComponent( ac, 2, -2, 0 );
			ac = new AddonComponent( 5353 );
			ac.Name = "bread board";
			AddComponent( ac, 2, -2, 7 );
			ac = new AddonComponent( 1307 );
			ac.Hue = 1891;
			ac.Name = "oven";
			AddComponent( ac, 0, -1, 20 );
			ac = new AddonComponent( 53 );
			AddComponent( ac, -1, 1, 0 );
			ac = new AddonComponent( 53 );
			AddComponent( ac, -1, 0, 0 );
			ac = new AddonComponent( 1801 );
			ac.Hue = 1102;
			ac.Name = "oven";
			AddComponent( ac, 0, 1, 0 );
			ac = new AddonComponent( 1801 );
			ac.Hue = 1102;
			ac.Name = "oven";
			AddComponent( ac, 0, 0, 0 );
			ac = new AddonComponent( 1801 );
			ac.Hue = 1102;
			ac.Name = "oven";
			AddComponent( ac, 1, 1, 0 );
			ac = new AddonComponent( 1801 );
			ac.Hue = 1102;
			ac.Name = "oven";
			AddComponent( ac, 1, 0, 0 );
			ac = new AddonComponent( 52 );
			AddComponent( ac, 0, 1, 0 );
			ac = new AddonComponent( 70 );
			AddComponent( ac, 0, 1, 0 );
			ac = new AddonComponent( 84 );
			AddComponent( ac, 0, 0, 18 );
			ac = new AddonComponent( 65 );
			AddComponent( ac, 1, 1, 0 );
			ac = new AddonComponent( 67 );
			AddComponent( ac, 1, 0, 0 );
			ac = new AddonComponent( 1305 );
			ac.Hue = 1102;
			ac.Name = "oven";
			AddComponent( ac, 0, 0, 7 );
			ac = new AddonComponent( 3561 );
			ac.Light = LightType.Circle225;
			AddComponent( ac, 0, 0, 4 );
			ac = new AddonComponent( 7386 );
			ac.Hue = 1891;
			ac.Name = "rack";
			AddComponent( ac, 0, 0, 8 );
			ac = new AddonComponent( 2253 );
			ac.Hue = 1891;
			ac.Name = "rack";
			AddComponent( ac, 0, 0, 8 );
			ac = new AddonComponent( 6571 );
			ac.Light = LightType.Circle225;
			AddComponent( ac, 0, 0, 5 );
			ac = new AddonComponent( 68 );
			AddComponent( ac, 0, 0, 5 );
			ac = new AddonComponent( 1305 );
			ac.Hue = 1891;
			AddComponent( ac, 2, 1, 0 );
			ac = new AddonComponent( 1305 );
			ac.Hue = 1891;
			AddComponent( ac, 2, 0, 0 );
			ac = new AddonComponent( 1305 );
			ac.Hue = 1891;
			AddComponent( ac, 2, 2, 0 );
			ac = new AddonComponent( 1305 );
			ac.Hue = 1891;
			AddComponent( ac, 1, 2, 0 );
			ac = new AddonComponent( 1305 );
			ac.Hue = 1891;
			AddComponent( ac, 0, 2, 0 );
			ac = new AddonComponent( 5354 );
			ac.Name = "pizza board";
			AddComponent( ac, 1, 2, 7 );
			ac = new AddonComponent( 7807 );
			ac.Name = "table";
			AddComponent( ac, 1, 2, 0 );
			ac = new AddonComponent( 1307 );
			ac.Hue = 1891;
			ac.Name = "oven";
			AddComponent( ac, 0, 1, 20 );
			ac = new AddonComponent( 1307 );
			ac.Hue = 1891;
			ac.Name = "oven";
			AddComponent( ac, 0, 0, 20 );

		}

		public OvenLargeNewAddon( Serial serial ) : base( serial )
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

	public class OvenLargeNewAddonDeed : BaseAddonDeed
	{
		public override BaseAddon Addon
		{
			get
			{
				return new OvenLargeNewAddon();
			}
		}

		[Constructable]
		public OvenLargeNewAddonDeed()
		{
            Name = "Large New Style Oven";
		}

		public OvenLargeNewAddonDeed( Serial serial ) : base( serial )
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