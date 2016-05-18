using System;
using Server;

namespace Server.Items
{
	public class DirtyDiaper : Item
	{
		[Constructable]
		public DirtyDiaper() : base( 0x1C1D )
		{
			Weight = 1.0;
			Hue = 0x47E;
			Name = "a dirty diaper";
			Light = LightType.Empty;
		}

		public override void OnDoubleClick( Mobile from )
		{
		
			from.SendMessage("It would be best to leave that alone.");
		
		}

		public DirtyDiaper( Serial serial ) : base( serial )
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
