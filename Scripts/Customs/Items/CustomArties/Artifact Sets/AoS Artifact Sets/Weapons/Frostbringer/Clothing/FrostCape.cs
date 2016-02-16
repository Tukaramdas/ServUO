using System;
using Server;

namespace Server.Items
{
	public class FrostCape : FurCape
	{
		public override int LabelNumber{ get{ return 1061111; } } // FrostCape
		public override int ArtifactRarity{ get{ return 11; } }
		
		public override int BaseEnergyResistance{ get{ return 15; } }

		public override int InitMinHits{ get{ return 255; } }
		public override int InitMaxHits{ get{ return 255; } }

		[Constructable]
		public FrostCape()
		{
			Name = "Frost Cape";
			Hue = 0x4F2;
			Attributes.RegenStam = 5;
			Attributes.WeaponDamage = 10;
		}

		public FrostCape( Serial serial ) : base( serial )
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