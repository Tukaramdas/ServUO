//=================================================
//This script was created by Gizmo's Uo Quest Maker
//This script was created on 6/9/2016 10:10:58
//=================================================

using System;
using Server;
using Server.Items;
using Server.Mobiles;

namespace Server.Engines.Quests
{
	public class QuestPart2 : BaseQuest
	{
		//This is the Quest Title the player sees at the top of the Gump
		public override object Title{ get{ return "QuestPart2"; } }
		//This tells the story of the quest
		public override object Description { get { return "cool, if you are up to it go kill the QuestMonster and bring me his head. I will give you his earrings for dude. "; } }
		//This decides how the npc reacts in text the player refusing the quest
		public override object Refuse{ get{ return "lame"; } }
		//This is what the npc says when the player returns without completing the objective(s)
		public override object Uncomplete{ get{ return "try again"; } }
		//This is what the Quest Giver says when the player completes the quest.
		public override object Complete{ get{ return "awesome"; } }

		public QuestPart2() : base()
		{
			//Slay Objective #1
			AddObjective(new SlayObjective(typeof(Drake),"QuestMonster",1, ""));
			//Obtain Objective #1
			AddObjective(new ObtainObjective(typeof(RavanasHead),"Ravana's Head",1));
		}

		public override void GiveRewards()
		{
			Item bonusitem;
			bonusitem = new RavanasEarrings( );
			//Adding Bonus Item #1
			if(!Owner.AddToBackpack( bonusitem ) )
			{
				bonusitem.MoveToWorld(Owner.Location,Owner.Map);
			}

			base.GiveRewards();
		}

		public override bool CanOffer()
		{
			return true;
		}
	}
}
