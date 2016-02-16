
using System;
using Server;
using Server.Items;

namespace Server.Items
{
	public class RotatingPigGrillAddon : BaseAddon
	{

		[ Constructable ]
		public RotatingPigGrillAddon()
		{			
                                        AddonComponent ac;
			ac = new AddonComponent( 39316 );  AddComponent( ac, 0, 1, 0 );
                                                                                ac = new AddonComponent( 39317 );  AddComponent( ac, 1, 0, 0 );
	        
                                        
		}

		public RotatingPigGrillAddon( Serial serial ) : base( serial )
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

        public class RotatingPigGrillAddonDeed : BaseAddonDeed
	{
		public override BaseAddon Addon
		{
			get
			{
				return new RotatingPigGrillAddon();
			}
		}

		[Constructable]
		public RotatingPigGrillAddonDeed()
		{
			Name = "Pig Grill";
		}

		public RotatingPigGrillAddonDeed( Serial serial ) : base( serial )
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