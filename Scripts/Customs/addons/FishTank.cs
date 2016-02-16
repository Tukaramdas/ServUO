using System;
using System.Collections;
using Server;
using Server.Items;
using Server.Network;
using Server.Mobiles;
using Server.Gumps;

namespace Server.Items
{
	public class FishTankAddon : BaseAddon
	{
       
		public override BaseAddonDeed Deed
		{
			get
			{
				return new FishTankAddonDeed();
			}
		}

		[ Constructable ]
        public FishTankAddon()
		{
            AddonComponent ac = null;
			ac = new 

AddonComponent( 1981 );
			ac.Hue = 1;
			ac.Name = "FishTank";
			AddComponent( ac, 0, 1, 12 );
            
			ac = new AddonComponent( 1981 );
			ac.Hue = 1;
			ac.Name = "FishTank";
			AddComponent( ac, 0, 2, 12 );

			ac = new AddonComponent( 1981 );
			ac.Hue = 1;
			ac.Name = "FishTank";
			AddComponent( ac, 0, 3, 12);
            
            ac = new AddonComponent(13591);
            ac.Hue = 0;
            ac.Name = "FishTank";
            AddComponent(ac, 0, 3, 2);

            ac = new AddonComponent(3248);
            ac.Hue = 0;
            ac.Name = "FishTank";
            AddComponent(ac, 1, 4, 9);

            ac = new AddonComponent(3542);
            ac.Hue = 0;
            ac.Name = "FishTank";
            AddComponent(ac, 1, 3, 13);

            ac = new AddonComponent(3542);
            ac.Hue = 0;
            ac.Name = "FishTank";
            AddComponent(ac, 1, 2, 13);

			ac = new AddonComponent( 13561 );
			ac.Hue = 0;
			ac.Name = "FishTank";
			AddComponent( ac, 0, 1, 2 );
            
			ac = new AddonComponent( 13561 );
			ac.Hue = 0;
			ac.Name = "FishTank";
			AddComponent( ac, 0, 2, 2 );

			ac = new AddonComponent( 13561 );
			ac.Hue = 0;
			ac.Name = "FishTank";
			AddComponent( ac, 0, 3, 2 );

			ac = new AddonComponent( 1981 );
			ac.Hue = 1;
			ac.Name = "FishTank";
			AddComponent( ac, 0, 1, 0 );

			ac = new AddonComponent( 1981 );
			ac.Hue = 1;
			ac.Name = "FishTank";
			AddComponent( ac, 0, 2, 0 );

			ac = new AddonComponent( 1981 );
			ac.Hue = 1;
			ac.Name = "FishTank";
			AddComponent( ac, 0, 3, 0 );
            
		}

		public FishTankAddon( Serial serial ) : base( serial )
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

	public class FishTankAddonDeed : BaseAddonDeed
	{
		public override BaseAddon Addon
		{
			get
			{
                return new FishTankAddon();
			}
		}

		[Constructable]
        public FishTankAddonDeed()
		{
			Name = "FishTank";
		}

        public FishTankAddonDeed(Serial serial)
            : base(serial)
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
