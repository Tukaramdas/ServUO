//=================================================
//This script was created by Gizmo's Uo Quest Maker
//This script was created on 5/14/2016 20:28:08
//=================================================

using System;
using Server;
using Server.Items;
using Server.Mobiles;

namespace Server.Engines.Quests
{
	public class Tooscaredtoexplore : BaseQuest
	{
		//Player can only do quest once
		public override bool DoneOnce{ get{ return false; } }

		//This is the Quest Title the player sees at the top of the Gump
		public override object Title{ get{ return "Too scared to explore"; } }
		//This tells the story of the quest
		public override object Description { get { return "Can you help me, please? I want to explore the woods but the living plants really creep me out.  It is kind of emberassing, really.  If you could kill 10 of those horrid Boglings, and bring me 40 of their lumber to prove it, I would be so thankful. "; } }
		//This decides how the npc reacts in text the player refusing the quest
		public override object Refuse{ get{ return "Tis a shame... I really wanted to expore."; } }
		//This is what the npc says when the player returns without completing the objective(s)
		public override object Uncomplete{ get{ return "Please help me."; } }
		//This is what the Quest Giver says when the player completes the quest.
		public override object Complete{ get{ return "Thanks you so much! Now I can explore the forest."; } }

		public Tooscaredtoexplore() : base()
		{
			//Slay Objective #1
			AddObjective(new SlayObjective(typeof(Bogling),"Bogling",10, ""));
			//Obtain Objective #1
			AddObjective(new ObtainObjective(typeof(Log),"Log",40));
		}

		public override void GiveRewards()
		{
			//Random gold amount to add
			BankCheck gold = new BankCheck( Utility.RandomMinMax( 500, 800 ) );
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
			Item item;
			//Add Reward Item #1
			item = new DreadPirateBoots();
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
