
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
	public class WheelChair3Addon : BaseAddon
	{
         
            
		public override BaseAddonDeed Deed
		{
			get
			{
				return new WheelChair3AddonDeed();
			}
		}

		[ Constructable ]
		public WheelChair3Addon()
		{



			AddComplexComponent( (BaseAddon) this, 6279, 0, 0, 0, 0, -1, "wheelchair", 1);// 1
			AddComplexComponent( (BaseAddon) this, 6281, 0, 0, 0, 0, -1, "wheelchair", 1);// 2
			AddComplexComponent( (BaseAddon) this, 6279, 0, 1, 0, 0, -1, "wheelchair", 1);// 3
			AddComplexComponent( (BaseAddon) this, 6281, 0, 1, 0, 0, -1, "wheelchair", 1);// 4
			AddComplexComponent( (BaseAddon) this, 2864, 0, 0, 0, 1001, -1, "wheelchair", 1);// 5

		}

		public WheelChair3Addon( Serial serial ) : base( serial )
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

	public class WheelChair3AddonDeed : BaseAddonDeed
	{
		public override BaseAddon Addon
		{
			get
			{
				return new WheelChair3Addon();
			}
		}

		[Constructable]
		public WheelChair3AddonDeed()
		{
			Name = "WheelChair3";
		}

		public WheelChair3AddonDeed( Serial serial ) : base( serial )
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