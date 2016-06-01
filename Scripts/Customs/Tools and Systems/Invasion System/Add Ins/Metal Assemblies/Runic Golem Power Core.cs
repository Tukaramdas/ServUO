using System;
using Server;

namespace Server.Items
{
	public class RunicGolemPowerCore : Item
	{
		[Constructable]
		public RunicGolemPowerCore( ) : base( 0x1f1c )
		{
			Name = "runic golem power core";
			Weight = 5.0;
		}

		public RunicGolemPowerCore( Serial serial ) : base( serial )
		{
		}

		public override void Serialize( GenericWriter writer )
		{
			base.Serialize( writer );

			writer.Write( (int) 0 ); // version
		}

		public override void Deserialize( GenericReader reader )
		{
			base.Deserialize( reader );

			int version = reader.ReadInt();
		}
	}
}