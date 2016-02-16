/////////////////////////////////////////////////
//
// Scripted by W00DY
// 
//
/////////////////////////////////////////////////
using System;
using Server;
using Server.Items;

namespace Server.Items
{
	public class InstantGardenAddon : BaseAddon
	{
		public override BaseAddonDeed Deed
		{
			get
			{
				return new InstantGardenAddonDeed();
			}
		}

		[ Constructable ]
		public InstantGardenAddon()
		{
			AddComponent( new AddonComponent( 1342 ), 0, -1, 0 );
			AddComponent( new AddonComponent( 1339 ), 0, -1, 0 );
			AddComponent( new AddonComponent( 1342 ), 1, -1, 0 );
			AddComponent( new AddonComponent( 1342 ), 1, -2, 0 );
			AddComponent( new AddonComponent( 3025 ), 3, 4, 0 );
			AddComponent( new AddonComponent( 949 ), 3, 0, 0 );
			AddComponent( new AddonComponent( 1342 ), 3, 0, 0 );
			AddComponent( new AddonComponent( 949 ), 3, -2, 0 );
			AddComponent( new AddonComponent( 1342 ), 3, -2, 0 );
			AddComponent( new AddonComponent( 948 ), 3, -3, 0 );
			AddComponent( new AddonComponent( 948 ), -2, -3, 0 );
			AddComponent( new AddonComponent( 1339 ), -2, -2, 0 );
			AddComponent( new AddonComponent( 1339 ), -2, -1, 0 );
			AddComponent( new AddonComponent( 1339 ), -2, 0, 0 );
			AddComponent( new AddonComponent( 1342 ), -2, 1, 0 );
			AddComponent( new AddonComponent( 1342 ), -2, 2, 0 );
			AddComponent( new AddonComponent( 948 ), -2, 3, 0 );
			AddComponent( new AddonComponent( 1342 ), -2, 3, 0 );
			AddComponent( new AddonComponent( 948 ), -1, 3, 0 );
			AddComponent( new AddonComponent( 1342 ), -1, 3, 0 );
			AddComponent( new AddonComponent( 1342 ), -1, 2, 0 );
			AddComponent( new AddonComponent( 1342 ), -1, 1, 0 );
			AddComponent( new AddonComponent( 1339 ), -1, 0, 0 );
			AddComponent( new AddonComponent( 1339 ), -1, -1, 0 );
			AddComponent( new AddonComponent( 1339 ), -1, -2, 0 );
			AddComponent( new AddonComponent( 948 ), -1, -3, 0 );
			AddComponent( new AddonComponent( 948 ), 0, -3, 0 );
			AddComponent( new AddonComponent( 949 ), 3, -1, 0 );
			AddComponent( new AddonComponent( 1342 ), 3, -1, 0 );
			AddComponent( new AddonComponent( 1342 ), 2, 1, 0 );
			AddComponent( new AddonComponent( 1342 ), 2, 2, 0 );
			AddComponent( new AddonComponent( 948 ), 2, 3, 0 );
			AddComponent( new AddonComponent( 1342 ), 2, 3, 0 );
			AddComponent( new AddonComponent( 948 ), 3, 3, 0 );
			AddComponent( new AddonComponent( 949 ), 3, 3, 0 );
			AddComponent( new AddonComponent( 1342 ), 3, 3, 0 );
			AddComponent( new AddonComponent( 949 ), 3, 2, 0 );
			AddComponent( new AddonComponent( 1342 ), 3, 2, 0 );
			AddComponent( new AddonComponent( 949 ), 3, 1, 0 );
			AddComponent( new AddonComponent( 1342 ), 3, 1, 0 );
			AddComponent( new AddonComponent( 1342 ), 1, 1, 0 );
			AddComponent( new AddonComponent( 1342 ), 1, 0, 0 );
			AddComponent( new AddonComponent( 1342 ), 1, 3, 0 );
			AddComponent( new AddonComponent( 2111 ), 1, 3, 0 );
			AddComponent( new AddonComponent( 1342 ), 1, 2, 0 );
			AddComponent( new AddonComponent( 948 ), 1, -3, 0 );
			AddComponent( new AddonComponent( 948 ), 2, -3, 0 );
			AddComponent( new AddonComponent( 1342 ), 2, -2, 0 );
			AddComponent( new AddonComponent( 1342 ), 2, -1, 0 );
			AddComponent( new AddonComponent( 1342 ), 2, 0, 0 );
			AddComponent( new AddonComponent( 949 ), -3, -1, 0 );
			AddComponent( new AddonComponent( 949 ), -3, -2, 0 );
			AddComponent( new AddonComponent( 949 ), -3, 1, 0 );
			AddComponent( new AddonComponent( 949 ), -3, 0, 0 );
			AddComponent( new AddonComponent( 949 ), -3, 3, 0 );
			AddComponent( new AddonComponent( 949 ), -3, 2, 0 );
			AddComponent( new AddonComponent( 1342 ), 0, 2, 0 );
			AddComponent( new AddonComponent( 1342 ), 0, 3, 0 );
			AddComponent( new AddonComponent( 2109 ), 0, 3, 0 );
			AddComponent( new AddonComponent( 1342 ), 0, 0, 0 );
			AddComponent( new AddonComponent( 1339 ), 0, 0, 0 );
			AddComponent( new AddonComponent( 1342 ), 0, 1, 0 );
			AddComponent( new AddonComponent( 1342 ), 0, -2, 0 );
			AddComponent( new AddonComponent( 1339 ), 0, -2, 0 );
			AddonComponent ac = null;
			ac = new AddonComponent( 949 );
			AddComponent( ac, 3, -1, 0 );
			ac = new AddonComponent( 949 );
			AddComponent( ac, 3, 0, 0 );
			ac = new AddonComponent( 949 );
			AddComponent( ac, 3, 1, 0 );
			ac = new AddonComponent( 948 );
			AddComponent( ac, 0, -3, 0 );
			ac = new AddonComponent( 948 );
			AddComponent( ac, 1, -3, 0 );
			ac = new AddonComponent( 948 );
			AddComponent( ac, 2, -3, 0 );
			ac = new AddonComponent( 948 );
			AddComponent( ac, 3, -3, 0 );
			ac = new AddonComponent( 949 );
			AddComponent( ac, 3, -2, 0 );
			ac = new AddonComponent( 949 );
			AddComponent( ac, -3, 1, 0 );
			ac = new AddonComponent( 949 );
			AddComponent( ac, -3, 2, 0 );
			ac = new AddonComponent( 949 );
			AddComponent( ac, -3, 3, 0 );
			ac = new AddonComponent( 948 );
			AddComponent( ac, -2, 3, 0 );
			ac = new AddonComponent( 948 );
			AddComponent( ac, -1, 3, 0 );
			ac = new AddonComponent( 948 );
			AddComponent( ac, 2, 3, 0 );
			ac = new AddonComponent( 948 );
			AddComponent( ac, 3, 3, 0 );
			ac = new AddonComponent( 949 );
			AddComponent( ac, 3, 2, 0 );
			ac = new AddonComponent( 949 );
			AddComponent( ac, 3, 3, 0 );
			ac = new AddonComponent( 1342 );
			AddComponent( ac, -2, 1, 0 );
			ac = new AddonComponent( 1342 );
			AddComponent( ac, -2, 2, 0 );
			ac = new AddonComponent( 1342 );
			AddComponent( ac, -2, 3, 0 );
			ac = new AddonComponent( 1342 );
			AddComponent( ac, -1, 1, 0 );
			ac = new AddonComponent( 1342 );
			AddComponent( ac, -1, 2, 0 );
			ac = new AddonComponent( 1342 );
			AddComponent( ac, -1, 3, 0 );
			ac = new AddonComponent( 1342 );
			AddComponent( ac, 0, -2, 0 );
			ac = new AddonComponent( 1342 );
			AddComponent( ac, 0, -1, 0 );
			ac = new AddonComponent( 1342 );
			AddComponent( ac, 0, 0, 0 );
			ac = new AddonComponent( 1342 );
			AddComponent( ac, 0, 1, 0 );
			ac = new AddonComponent( 1342 );
			AddComponent( ac, 0, 2, 0 );
			ac = new AddonComponent( 1342 );
			AddComponent( ac, 0, 3, 0 );
			ac = new AddonComponent( 1342 );
			AddComponent( ac, 1, -2, 0 );
			ac = new AddonComponent( 1342 );
			AddComponent( ac, 1, -1, 0 );
			ac = new AddonComponent( 1342 );
			AddComponent( ac, 1, 0, 0 );
			ac = new AddonComponent( 1342 );
			AddComponent( ac, 1, 1, 0 );
			ac = new AddonComponent( 1342 );
			AddComponent( ac, 1, 2, 0 );
			ac = new AddonComponent( 1342 );
			AddComponent( ac, 1, 3, 0 );
			ac = new AddonComponent( 1342 );
			AddComponent( ac, 2, -2, 0 );
			ac = new AddonComponent( 1342 );
			AddComponent( ac, 2, -1, 0 );
			ac = new AddonComponent( 1342 );
			AddComponent( ac, 2, 0, 0 );
			ac = new AddonComponent( 1342 );
			AddComponent( ac, 2, 1, 0 );
			ac = new AddonComponent( 1342 );
			AddComponent( ac, 2, 2, 0 );
			ac = new AddonComponent( 1342 );
			AddComponent( ac, 2, 3, 0 );
			ac = new AddonComponent( 1342 );
			AddComponent( ac, 3, -2, 0 );
			ac = new AddonComponent( 1342 );
			AddComponent( ac, 3, -1, 0 );
			ac = new AddonComponent( 1342 );
			AddComponent( ac, 3, 0, 0 );
			ac = new AddonComponent( 1342 );
			AddComponent( ac, 3, 1, 0 );
			ac = new AddonComponent( 1342 );
			AddComponent( ac, 3, 2, 0 );
			ac = new AddonComponent( 1342 );
			AddComponent( ac, 3, 3, 0 );
			ac = new AddonComponent( 1339 );
			AddComponent( ac, -2, -2, 0 );
			ac = new AddonComponent( 1339 );
			AddComponent( ac, -2, -1, 0 );
			ac = new AddonComponent( 1339 );
			AddComponent( ac, -2, 0, 0 );
			ac = new AddonComponent( 1339 );
			AddComponent( ac, -1, -2, 0 );
			ac = new AddonComponent( 1339 );
			AddComponent( ac, -1, -1, 0 );
			ac = new AddonComponent( 1339 );
			AddComponent( ac, -1, 0, 0 );
			ac = new AddonComponent( 1339 );
			AddComponent( ac, 0, -2, 0 );
			ac = new AddonComponent( 1339 );
			AddComponent( ac, 0, -1, 0 );
			ac = new AddonComponent( 1339 );
			AddComponent( ac, 0, 0, 0 );
			ac = new AddonComponent( 948 );
			AddComponent( ac, -2, -3, 0 );
			ac = new AddonComponent( 948 );
			AddComponent( ac, -1, -3, 0 );
			ac = new AddonComponent( 949 );
			AddComponent( ac, -3, -2, 0 );
			ac = new AddonComponent( 949 );
			AddComponent( ac, -3, -1, 0 );
			ac = new AddonComponent( 949 );
			AddComponent( ac, -3, 0, 0 );

		}

		public InstantGardenAddon( Serial serial ) : base( serial )
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

	public class InstantGardenAddonDeed : BaseAddonDeed
	{
		public override BaseAddon Addon
		{
			get
			{
				return new InstantGardenAddon();
			}
		}

		[Constructable]
		public InstantGardenAddonDeed()
		{
			Name = "InstantGarden";
		}

		public InstantGardenAddonDeed( Serial serial ) : base( serial )
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