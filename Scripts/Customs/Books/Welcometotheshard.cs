//////////////////////////////////////////////
//
// Welcome to the shard by Tito Tim
//
// Created using Lokai's ReadBookFromTxt.cs
//
//////////////////////////////////////////////
using System;
using Server;

namespace Server.Items
{
	public class Welcometotheshard : BaseBook
	{
		public static readonly BookContent Content = new BookContent
			(
				"Welcome to the shard", "Tito Tim", 
				new BookPageInfo
				(
					"In your pack you will",
					"find some handy toys to",
					"get you started.  The",
					"command for info is",
					"[Welcome",
					"Please enjoy your stay.",
					" ",
					" "
				),
				
				new BookPageInfo
				(
					" ",
					"",
					"",
					"",
					"",
					"",
					"",
					""
				)
			);

		public override BookContent DefaultContent{ get{ return Content; } }

		[Constructable]
		public Welcometotheshard() : base( Utility.Random( 0xFEF, 2 ), false )
		{
		}

		public Welcometotheshard( Serial serial ) : base( serial )
		{
		}

		public override void Serialize( GenericWriter writer )
		{
			base.Serialize( writer );

			writer.WriteEncodedInt( (int) 0 ); // version
		}

		public override void Deserialize( GenericReader reader )
		{
			base.Deserialize( reader );

			int version = reader.ReadEncodedInt();
		}
	}
}