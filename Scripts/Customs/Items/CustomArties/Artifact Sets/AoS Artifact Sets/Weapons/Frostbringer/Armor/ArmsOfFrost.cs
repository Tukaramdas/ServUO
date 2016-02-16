using System;
using Server;

namespace Server.Items
{
	public class ArmsOfFrost : StuddedArms
	{
		public override int LabelNumber{ get{ return 1061098; } } // Arms of Frost
		public override int ArtifactRarity{ get{ return 11; } }
		
		public override int BasePhysicalResistance{ get{ return 15; } }

		public override int InitMinHits{ get{ return 255; } }
		public override int InitMaxHits{ get{ return 255; } }

		[Constructable]
		public ArmsOfFrost()
		{
			Name = "Arms of Frost";
		
			Hue = 0x4F2;
			Attributes.RegenStam = 5;
			Attributes.WeaponDamage = 5;
			Attributes.WeaponSpeed = 15;
		}

		public ArmsOfFrost( Serial serial ) : base( serial )
		{
		}

		public override void Serialize( GenericWriter writer )
		{
			base.Serialize( writer );

			writer.Write( (int) 0 );
		}
		
		public override void Deserialize(GenericReader reader)
		{
			base.Deserialize( reader );

			int version = reader.ReadInt();
		}
	}
}