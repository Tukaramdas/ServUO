
////////////////////////////////////////
//                                     //
//   Generated by CEO's YAAAG - Ver 2  //
// (Yet Another Arya Addon Generator)  //
//    Modified by Hammerhand for       //
//      SA & High Seas content         //
//                                     //
////////////////////////////////////////
using System;
using Server;
using Server.Items;

namespace Server.Items
{
	public class Desk1Addon : BaseAddon
	{
         
            
		public override BaseAddonDeed Deed
		{
			get
			{
				return new Desk1AddonDeed();
			}
		}

		[ Constructable ]
		public Desk1Addon()
		{



			AddComplexComponent( (BaseAddon) this, 2947, 0, 0, 0, 2500, -1, "Desk", 1);// 1
			AddComplexComponent( (BaseAddon) this, 2949, -1, 1, 0, 2500, -1, "Desk", 1);// 2
			AddComplexComponent( (BaseAddon) this, 2950, 0, 1, 0, 2500, -1, "Desk", 1);// 3
			AddComplexComponent( (BaseAddon) this, 2612, -1, 0, 4, 2500, -1, "Desk", 1);// 4
			AddComplexComponent( (BaseAddon) this, 7802, -1, 1, 4, 2674, -1, "Desk", 1);// 5
			AddComplexComponent( (BaseAddon) this, 7802, -1, 1, 11, 2674, -1, "Desk", 1);// 6
			AddComplexComponent( (BaseAddon) this, 2950, -1, 0, 0, 2500, -1, "Desk", 1);// 7
			AddComplexComponent( (BaseAddon) this, 7792, -1, 1, 11, 2674, -1, "Desk", 1);// 8
			AddComplexComponent( (BaseAddon) this, 10013, 0, 1, 4, 2500, -1, "Desk", 1);// 9
			AddComplexComponent( (BaseAddon) this, 10013, -1, 1, 4, 2500, -1, "Desk", 1);// 10
			AddComplexComponent( (BaseAddon) this, 7792, 0, 0, 6, 2674, -1, "Desk", 1);// 11
			AddComplexComponent( (BaseAddon) this, 2950, 1, 1, 0, 2500, -1, "Desk", 1);// 12
			AddComplexComponent( (BaseAddon) this, 2948, 2, 1, 0, 2500, -1, "Desk", 1);// 13
			AddComplexComponent( (BaseAddon) this, 2947, 2, 0, 0, 2500, -1, "Desk", 1);// 14
			AddComplexComponent( (BaseAddon) this, 10013, 1, 1, 4, 2500, -1, "Desk", 1);// 15
			AddComplexComponent( (BaseAddon) this, 10077, 2, 1, 5, 2500, -1, "Desk", 1);// 16
			AddComplexComponent( (BaseAddon) this, 10013, 2, 1, 4, 2500, -1, "Desk", 1);// 17

		}

		public Desk1Addon( Serial serial ) : base( serial )
		{
		}

        private static void AddComplexComponent(BaseAddon addon, int item, int xoffset, int yoffset, int zoffset, int hue, int lightsource)
        {
            AddComplexComponent(addon, item, xoffset, yoffset, zoffset, hue, lightsource, null, 1);
        }

        private static void AddComplexComponent(BaseAddon addon, int item, int xoffset, int yoffset, int zoffset, int hue, int lightsource, string name, int amount)
        {
            AddonComponent ac;
            ac = new AddonComponent(item);
            if (name != null && name.Length > 0)
                ac.Name = name;
            if (hue != 0)
                ac.Hue = hue;
            if (amount > 1)
            {
                ac.Stackable = true;
                ac.Amount = amount;
            }
            if (lightsource != -1)
                ac.Light = (LightType) lightsource;
            addon.AddComponent(ac, xoffset, yoffset, zoffset);
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

	public class Desk1AddonDeed : BaseAddonDeed
	{
		public override BaseAddon Addon
		{
			get
			{
				return new Desk1Addon();
			}
		}

		[Constructable]
		public Desk1AddonDeed()
		{
			Name = "Desk1";
		}

		public Desk1AddonDeed( Serial serial ) : base( serial )
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