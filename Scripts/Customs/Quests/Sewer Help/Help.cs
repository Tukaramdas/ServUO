//=================================================
//This script was created by Gizmo's Uo Quest Maker
//This script was created on 5/14/2016 21:45:54
//=================================================

using System;
using Server;
using Server.Items;
using Server.Mobiles;

namespace Server.Engines.Quests
{
	public class Help : BaseQuest
	{
		//This is the Quest Title the player sees at the top of the Gump
		public override object Title{ get{ return "Help"; } }
		//This tells the story of the quest
		public override object Description { get { return "Can you help clean out the sewers?"; } }
		//This decides how the npc reacts in text the player refusing the quest
		public override object Refuse{ get{ return "Oh well"; } }
		//This is what the npc says when the player returns without completing the objective(s)
		public override object Uncomplete{ get{ return "Keep working on it"; } }
		//This is what the Quest Giver says when the player completes the quest.
		public override object Complete{ get{ return "Thank you so much"; } }

		public Help() : base()
		{
			//Slay Objective #1
			AddObjective(new SlayObjective(typeof(Alligator),"Alligator",5, ""));
			//Slay Objective #2
			AddObjective(new SlayObjective(typeof(Sewerrat),"Sewer Rat",5, ""));
			//Obtain Objective #1
			AddObjective(new ObtainObjective(typeof(RawRibs),"Raw Ribs",5));
		}

		public override void GiveRewards()
		{
			//Random gold amount to add
			BankCheck gold = new BankCheck( Utility.RandomMinMax( 200, 300 ) );
			if( !Owner.AddToBackpack( gold ) )
			{
				gold.MoveToWorld(Owner.Location,Owner.Map);
			}

			//Adding Quest Reward Token(s)
			for(int x = 0; x < 1; x++)
			{
				RandomTalisman talisman = new RandomTalisman();
				if(!Owner.AddToBackpack( talisman ) )
				{
					talisman.MoveToWorld(Owner.Location,Owner.Map);
				}
			}
			Item bonusitem;
			bonusitem = new Bandage( 10 );
			//Adding Bonus Item #1
			if(!Owner.AddToBackpack( bonusitem ) )
			{
				bonusitem.MoveToWorld(Owner.Location,Owner.Map);
			}

			Item item;
			//Add Reward Item #1
			item = new AdventurersMachete();
			if( item is BaseWeapon )
				BaseRunicTool.ApplyAttributesTo((BaseWeapon)item,  Utility.RandomMinMax( 1,4 ), 10, 50 );
			if( item is BaseArmor )
				BaseRunicTool.ApplyAttributesTo((BaseArmor)item,  Utility.RandomMinMax( 1,4 ), 10, 50 );
			if( item is BaseJewel )
				BaseRunicTool.ApplyAttributesTo((BaseJewel)item,  Utility.RandomMinMax( 1,4 ), 10, 50 );
			if( item is BaseHat )
				BaseRunicTool.ApplyAttributesTo((BaseHat)item,  Utility.RandomMinMax( 1,4 ), 10, 50 );
			if(!Owner.AddToBackpack( item ) )
			{
				item.MoveToWorld(Owner.Location,Owner.Map);
			}

			base.GiveRewards();
		}

		public override bool CanOffer()
		{
			return true;
		}
	}
}
