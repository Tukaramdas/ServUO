/***************************
**      All Hues					**
**     X-SirSly-X					**
** www.LandofObsidian.com **
**       ver 1.0					**
**      2006.04.12				**
***************************/
using System;
using Server;
//////ALL HUES/////////
using Server.AllHues;
//////ALL HUES/////////


namespace Server.Items
{
	public class AllHuesTestItem : BaseCloak
	{

		[Constructable]
		public AllHuesTestItem( ) : base( 0x1515 )
		{
			Name = "All Hues Test Item";

			//////ALL HUES/////////
			Hue = AllHuesInfo.OddNeon;
			//////ALL HUES/////////

			Weight = 1;
		}

		public AllHuesTestItem( Serial serial ) : base( serial )
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