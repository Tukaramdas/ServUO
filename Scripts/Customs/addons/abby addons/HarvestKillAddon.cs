// Automatically generated by the
// AddonGenerator script by Arya
// Generator edited 10.Mar.07 by Papler
using System;
using Server;
using Server.Items;
namespace Server.Items
{
	public class HarvestKillAddon : BaseAddon {
		public override BaseAddonDeed Deed{get{return new HarvestKillAddonDeed();}}
		[ Constructable ]
		public HarvestKillAddon()
		{
			AddonComponent ac = null;
			ac = new AddonComponent( 2143 );
			AddComponent( ac, -3, -2, 0 );

			ac = new AddonComponent( 2144 );
			AddComponent( ac, -2, 1, 0 );

			ac = new AddonComponent( 2142 );
			AddComponent( ac, -3, 1, 0 );

			ac = new AddonComponent( 2144 );
			AddComponent( ac, -2, -2, 0 );

			ac = new AddonComponent( 2145 );
			AddComponent( ac, -3, 0, 0 );

			ac = new AddonComponent( 2145 );
			AddComponent( ac, -3, -1, 0 );

			ac = new AddonComponent( 7869 );
			AddComponent( ac, -3, -2, 3 );

			ac = new AddonComponent( 5193 );
			AddComponent( ac, -2, 0, 0 );

			ac = new AddonComponent( 5193 );
			AddComponent( ac, -2, -2, 6 );

			ac = new AddonComponent( 7869 );
			AddComponent( ac, -2, -2, 2 );

			ac = new AddonComponent( 7869 );
			AddComponent( ac, -3, -1, 3 );

			ac = new AddonComponent( 9890 );
			ac.Hue = 1510;
			ac.Name = "turkey";
			AddComponent( ac, 3, 2, 11 );

			ac = new AddonComponent( 9890 );
			ac.Hue = 1504;
			AddComponent( ac, 3, 2, 10 );

			ac = new AddonComponent( 9889 );
			ac.Hue = 1504;
			ac.Name = "turkey";
			AddComponent( ac, 2, 1, 0 );

			ac = new AddonComponent( 8401 );
			ac.Hue = 546;
			ac.Name = "turkey";
			AddComponent( ac, 3, 2, 6 );

			ac = new AddonComponent( 3670 );
			AddComponent( ac, -1, 0, 4 );

			ac = new AddonComponent( 2140 );
			AddComponent( ac, 0, 1, 0 );

			ac = new AddonComponent( 2144 );
			AddComponent( ac, -1, 1, 0 );

			ac = new AddonComponent( 2144 );
			AddComponent( ac, -1, -2, 0 );

			ac = new AddonComponent( 2145 );
			AddComponent( ac, 0, 0, 0 );

			ac = new AddonComponent( 2141 );
			AddComponent( ac, 0, -2, 0 );

			ac = new AddonComponent( 2145 );
			AddComponent( ac, 0, -1, 0 );

			ac = new AddonComponent( 4650 );
			AddComponent( ac, -1, 0, 3 );

			ac = new AddonComponent( 5193 );
			AddComponent( ac, -1, -1, 0 );

			ac = new AddonComponent( 3893 );
			AddComponent( ac, 0, 1, 0 );


		}
		public HarvestKillAddon( Serial serial ) : base( serial ){}
		public override void Serialize( GenericWriter writer ){base.Serialize( writer );writer.Write( 0 );}
		public override void Deserialize( GenericReader reader ){base.Deserialize( reader );reader.ReadInt();}
	}

	public class HarvestKillAddonDeed : BaseAddonDeed {
		public override BaseAddon Addon{get{return new HarvestKillAddon();}}
		[Constructable]
		public HarvestKillAddonDeed(){Name = "HarvestKill";}
		public HarvestKillAddonDeed( Serial serial ) : base( serial ){}
		public override void Serialize( GenericWriter writer ){	base.Serialize( writer );writer.Write( 0 );}
		public override void	Deserialize( GenericReader reader )	{base.Deserialize( reader );reader.ReadInt();}
	}
}