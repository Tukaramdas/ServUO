using System;
using Server;

namespace Server.Items
{
	public class HeavyCrossbowOfFire : HeavyCrossbow
	{
		public override int LabelNumber{ get{ return 1061099; } } // Coif of Fire
		public override int ArtifactRarity{ get{ return 11; } }

		
		public override int InitMinHits{ get{ return 255; } }
		public override int InitMaxHits{ get{ return 255; } }

		[Constructable]
		public HeavyCrossbowOfFire()
		{
			Name = "Heavy Crossbow of Fire";
			Hue = 0x54F;
			WeaponAttributes.SelfRepair = 5;
			Attributes.NightSight = 1;
			Attributes.ReflectPhysical = 15;
		}
		
		public override void GetDamageTypes( Mobile wielder, out int phys, out int fire, out int cold, out int pois, out int nrgy, out int chaos, out int direct )
		{
			phys = 45;
			fire = 55;
			cold = nrgy = pois = chaos = direct = 0;
		}

		public HeavyCrossbowOfFire( Serial serial ) : base( serial )
		{
		}

		public override void Serialize( GenericWriter writer )
		{
			base.Serialize( writer );

			writer.Write( (int) 1 );
		}
		
		public override void Deserialize(GenericReader reader)
		{
			base.Deserialize( reader );

			int version = reader.ReadInt();

			if ( version < 1 )
			{
				if ( Hue == 0x54E )
					Hue = 0x54F;

				if ( Attributes.NightSight == 0 )
					Attributes.NightSight = 1;
			}
		}
	}
}