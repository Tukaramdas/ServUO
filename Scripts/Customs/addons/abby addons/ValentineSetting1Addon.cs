// Automatically generated by the
// AddonGenerator script by Arya
// Generator edited 10.Mar.07 by Papler
using System;
using Server;
using Server.Items;
namespace Server.Items
{
	public class ValentineSetting1Addon : BaseAddon {
		public override BaseAddonDeed Deed{get{return new ValentineSetting1AddonDeed();}}
		[ Constructable ]
		public ValentineSetting1Addon()
		{
			AddonComponent ac = null;
			ac = new AddonComponent( 1801 );
			ac.Hue = 33;
			AddComponent( ac, 0, 1, 0 );

			ac = new AddonComponent( 1805 );
			ac.Hue = 33;
			AddComponent( ac, -1, 1, 0 );

			ac = new AddonComponent( 1802 );
			ac.Hue = 33;
			AddComponent( ac, 0, 2, 0 );

			ac = new AddonComponent( 1812 );
			ac.Hue = 33;
			AddComponent( ac, -1, 2, 0 );

			ac = new AddonComponent( 1814 );
			ac.Hue = 33;
			AddComponent( ac, 0, 0, 0 );

			ac = new AddonComponent( 1810 );
			ac.Hue = 33;
			AddComponent( ac, -1, 0, 0 );

			ac = new AddonComponent( 1810 );
			ac.Hue = 33;
			AddComponent( ac, 0, -1, 0 );

			ac = new AddonComponent( 6816 );
			ac.Name = "Vines";
			AddComponent( ac, 0, 2, 11 );

			ac = new AddonComponent( 9037 );
			ac.Hue = 33;
			ac.Name = "Bunch of Roses";
			AddComponent( ac, 0, 1, 30 );

			ac = new AddonComponent( 2874 );
			ac.Hue = 1153;
			AddComponent( ac, 0, 1, 2 );

			ac = new AddonComponent( 2458 );
			ac.Hue = 26;
			ac.Name = "Pink champagne";
			AddComponent( ac, 0, 1, 8 );

			ac = new AddonComponent( 2503 );
			ac.Hue = 26;
			ac.Name = "pink champagne";
			AddComponent( ac, 0, 1, 3 );

			ac = new AddonComponent( 2602 );
			ac.Hue = 1153;
			AddComponent( ac, -1, 1, 1 );

			ac = new AddonComponent( 3149 );
			AddComponent( ac, 0, 2, 2 );

			ac = new AddonComponent( 3149 );
			AddComponent( ac, 0, 0, 2 );

			ac = new AddonComponent( 12689 );
			ac.Name = "flowers";
			AddComponent( ac, 0, 2, 33 );

			ac = new AddonComponent( 7186 );
			ac.Name = "Bell of Love";
			AddComponent( ac, 0, 0, 18 );

			ac = new AddonComponent( 8513 );
			AddComponent( ac, 0, 3, 0 );

			ac = new AddonComponent( 8515 );
			AddComponent( ac, -1, 3, 0 );

			ac = new AddonComponent( 8515 );
			AddComponent( ac, -2, 2, 0 );

			ac = new AddonComponent( 8512 );
			AddComponent( ac, -2, 3, 0 );

			ac = new AddonComponent( 8512 );
			AddComponent( ac, -1, -1, 0 );

			ac = new AddonComponent( 8512 );
			AddComponent( ac, 0, -2, 0 );

			ac = new AddonComponent( 8512 );
			AddComponent( ac, -2, 0, 0 );

			ac = new AddonComponent( 8512 );
			AddComponent( ac, -2, 1, 0 );

			ac = new AddonComponent( 8512 );
			AddComponent( ac, -1, -2, 0 );

			ac = new AddonComponent( 8515 );
			AddComponent( ac, -2, -2, 0 );

			ac = new AddonComponent( 8515 );
			AddComponent( ac, -2, -1, 0 );

			ac = new AddonComponent( 3211 );
			AddComponent( ac, 0, 3, 8 );

			ac = new AddonComponent( 9037 );
			ac.Hue = 33;
			ac.Name = "Bunch of Roses";
			AddComponent( ac, 1, 1, 37 );

			ac = new AddonComponent( 9037 );
			ac.Hue = 33;
			ac.Name = "Bunch of Roses";
			AddComponent( ac, 1, 0, 30 );

			ac = new AddonComponent( 1801 );
			ac.Hue = 33;
			AddComponent( ac, 1, 1, 0 );

			ac = new AddonComponent( 1801 );
			ac.Hue = 33;
			AddComponent( ac, 1, 0, 0 );

			ac = new AddonComponent( 1804 );
			ac.Hue = 33;
			AddComponent( ac, 1, -1, 0 );

			ac = new AddonComponent( 1802 );
			ac.Hue = 33;
			AddComponent( ac, 1, 2, 0 );

			ac = new AddonComponent( 1803 );
			ac.Hue = 33;
			AddComponent( ac, 2, 0, 0 );

			ac = new AddonComponent( 1803 );
			ac.Hue = 33;
			AddComponent( ac, 2, 1, 0 );

			ac = new AddonComponent( 1807 );
			ac.Hue = 33;
			AddComponent( ac, 2, 2, 0 );

			ac = new AddonComponent( 1813 );
			ac.Hue = 33;
			AddComponent( ac, 2, -1, 0 );

			ac = new AddonComponent( 6814 );
			ac.Name = "Vines";
			AddComponent( ac, 2, 0, 11 );

			ac = new AddonComponent( 2870 );
			ac.Hue = 1153;
			AddComponent( ac, 2, 2, 11 );

			ac = new AddonComponent( 2874 );
			ac.Hue = 1153;
			AddComponent( ac, 1, 0, 2 );

			ac = new AddonComponent( 2458 );
			ac.Hue = 26;
			ac.Name = "Pink Champagne";
			AddComponent( ac, 1, 0, 8 );

			ac = new AddonComponent( 2429 );
			AddComponent( ac, 2, 1, 14 );

			ac = new AddonComponent( 2602 );
			ac.Hue = 1153;
			AddComponent( ac, 1, -1, 1 );

			ac = new AddonComponent( 3149 );
			AddComponent( ac, 2, 2, 2 );

			ac = new AddonComponent( 3147 );
			AddComponent( ac, 2, 0, 12 );

			ac = new AddonComponent( 3149 );
			AddComponent( ac, 2, 0, 2 );

			ac = new AddonComponent( 3149 );
			AddComponent( ac, 2, 2, 2 );

			ac = new AddonComponent( 7188 );
			ac.Light = LightType.Circle225;
			AddComponent( ac, 2, 2, 18 );

			ac = new AddonComponent( 12689 );
			ac.Name = "flowers";
			AddComponent( ac, 2, 0, 32 );

			ac = new AddonComponent( 12689 );
			ac.Name = "flowers";
			AddComponent( ac, 2, 2, 44 );

			ac = new AddonComponent( 3195 );
			ac.Hue = 33;
			ac.Name = "Deep red rose of Passion";
			AddComponent( ac, 2, 2, 16 );

			ac = new AddonComponent( 3976 );
			ac.Name = "stem";
			AddComponent( ac, 2, 2, 14 );

			ac = new AddonComponent( 3878 );
			ac.Hue = 35;
			ac.Name = "Deep red rose of Passion";
			AddComponent( ac, 2, 2, 17 );

			ac = new AddonComponent( 3888 );
			ac.Hue = 33;
			ac.Name = "Deep red rose of Passion";
			AddComponent( ac, 2, 2, 19 );

			ac = new AddonComponent( 1173 );
			AddComponent( ac, 1, -1, 0 );

			ac = new AddonComponent( 1173 );
			AddComponent( ac, 1, 0, 0 );

			ac = new AddonComponent( 8514 );
			AddComponent( ac, 3, 2, 0 );

			ac = new AddonComponent( 8515 );
			AddComponent( ac, 3, 1, 0 );

			ac = new AddonComponent( 8515 );
			AddComponent( ac, 2, 3, 0 );

			ac = new AddonComponent( 8511 );
			AddComponent( ac, 3, 3, 0 );

			ac = new AddonComponent( 8512 );
			AddComponent( ac, 1, 3, 0 );

			ac = new AddonComponent( 8512 );
			AddComponent( ac, 3, 0, 0 );

			ac = new AddonComponent( 8513 );
			AddComponent( ac, 3, -1, 0 );

			ac = new AddonComponent( 8515 );
			AddComponent( ac, 2, -2, 0 );

			ac = new AddonComponent( 8512 );
			AddComponent( ac, 3, -2, 0 );

			ac = new AddonComponent( 8512 );
			AddComponent( ac, 1, -2, 0 );

			ac = new AddonComponent( 3212 );
			AddComponent( ac, 3, 0, 7 );


		}
		public ValentineSetting1Addon( Serial serial ) : base( serial ){}
		public override void Serialize( GenericWriter writer ){base.Serialize( writer );writer.Write( 0 );}
		public override void Deserialize( GenericReader reader ){base.Deserialize( reader );reader.ReadInt();}
	}

	public class ValentineSetting1AddonDeed : BaseAddonDeed {
		public override BaseAddon Addon{get{return new ValentineSetting1Addon();}}
		[Constructable]
		public ValentineSetting1AddonDeed(){Name = "ValentineSetting1";}
		public ValentineSetting1AddonDeed( Serial serial ) : base( serial ){}
		public override void Serialize( GenericWriter writer ){	base.Serialize( writer );writer.Write( 0 );}
		public override void	Deserialize( GenericReader reader )	{base.Deserialize( reader );reader.ReadInt();}
	}
}