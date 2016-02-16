using System;
using Server;

namespace Server.Items
{
	public class DreadLordSandals : Sandals
	{
		public override int LabelNumber{ get{ return 1061111; } } // DreadLordSandals
		public override int ArtifactRarity{ get{ return 10; } }
		
		public override int InitMinHits{ get{ return 255; } }
		public override int InitMaxHits{ get{ return 255; } }

		[Constructable]
		public DreadLordSandals()
		{
			Name = "Dread Lord Sandals";
			Hue = 0x676;
			Attributes.CastRecovery = 2;
			Attributes.WeaponSpeed = 5;
			Attributes.WeaponDamage = 10;
		}

		public DreadLordSandals( Serial serial ) : base( serial )
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