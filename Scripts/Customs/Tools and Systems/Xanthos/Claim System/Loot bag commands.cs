using System;
using Server.Network;
using Server.Prompts;
using Server.Items;

namespace Server.Items
{
	public class LootBagCommands: Item
	{
		[Constructable]
		public LootBagCommands() : base( 0x14F0 )
		{
			base.Weight = 1.0;
			base.Name = "Loot bag Commands [Claim [CL [Grab [GR [GR -t Set options [Cl -t Set options";
			Hue = 319;
		}

		public LootBagCommands( Serial serial ) : base( serial )
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

		public override void OnDoubleClick( Mobile m )
		{
			m.SendMessage( "Loot bag Commands" );
		}
	}
}
