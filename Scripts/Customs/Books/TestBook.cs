using System;
using Server;

namespace Server.Items
{
	public class CBooktest : BlueBook
	{
		public static readonly BookContent Content = new BookContent
		(
			"test", "tuka",

			new BookPageInfo
			(
				"just seeing if this",
				"works. How long can it",
				"be?"
			)
		);

		public override BookContent DefaultContent{ get{ return Content; } }

		[Constructable]
		public CBooktest() : base( false )
		{
			Hue = 645;
		}

		public CBooktest( Serial serial ) : base( serial )
		{
		}

		public override void Serialize( GenericWriter writer )
		{
			base.Serialize( writer );
			writer.WriteEncodedInt( (int)0 );
		}

		public override void Deserialize( GenericReader reader )
		{
			base.Deserialize( reader );
			int version = reader.ReadEncodedInt();
		}
	}
}