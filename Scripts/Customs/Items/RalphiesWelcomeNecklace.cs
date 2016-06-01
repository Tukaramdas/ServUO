//=================================================
//This script was created by Gizmo's Uo Quest Maker
//This script was created on 5/13/2016 15:08:09
//=================================================

using System;
using Server;

namespace Server.Items
{
	public class RalphiesWelcomeNecklace : Necklace
	{

		[Constructable]
		public RalphiesWelcomeNecklace()
		{
			Name = "Ralphie's Welcome Necklace";
			Hue = 1196;
			LootType = LootType.Blessed;
			Weight = 1;
			Attributes.BonusMana = 10;
			Attributes.BonusInt = 10;
			Attributes.BonusStam = 10;
			Attributes.BonusDex = 10;
			Attributes.Luck = 1000;
			Attributes.LowerRegCost = 100;
		}

		public RalphiesWelcomeNecklace( Serial serial ) : base( serial )
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
