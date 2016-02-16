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
					"World Travel Atlas",
					"looks like a regular",
					"rune book but acts",
					"almost like a moongate.",
					" Open the book and see"
				),
				new BookPageInfo
				(
					"all the options of",
					"where to go!  The",
					"command for the loot",
					"system is [Loot.  If",
					"you single click the",
					"MasterLootBackpack you",
					"can set options for",
					"what and how it loots. "
				),
				new BookPageInfo
				(
					"The",
					"Trash4TokensBackpack is",
					"a trash bag with a",
					"3minute timer.  It will",
					"give Tokens for some",
					"items.  No telling how",
					"much.  It will not give",
					"Tokens for any"
				),
				new BookPageInfo
				(
					"stackable items - but",
					"will delete them!  The",
					"Tokens can be used to",
					"buy some items at the",
					"Token Stone (one in New",
					"Haven, and one at the",
					"Casino).  The Casino is",
					"in the Travel Atlas"
				),
				new BookPageInfo
				(
					"under Custom. The",
					"skillball will let you",
					"choose 7 skills to GM.",
					"But will reset all",
					"otherskills to zero.",
					"You may want to finish",
					"the newbie quests",
					"before using the skill"
				),
				new BookPageInfo
				(
					"ball. That will give",
					"you time to decide what",
					"to GM. You got a free",
					"house and a bankstone",
					"for bank access at",
					"home. Use the command",
					"[Spellbar to get your",
					"spell icons setup"
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