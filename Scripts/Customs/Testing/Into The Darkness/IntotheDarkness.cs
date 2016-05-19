//=================================================
//This script was created by Gizmo's Uo Quest Maker
//This script was created on 8/30/2008 4:22:40 AM
//=================================================

using System;
using Server;
using Server.Items;
using Server.Mobiles;

namespace Server.Engines.Quests
{
	public class IntotheDarkness : BaseQuest
	{
		//The player will have a delay before they can redo quest again
		public override TimeSpan RestartDelay { get { return TimeSpan.FromMinutes(5); } }

		//This is the Quest Title the player sees at the top of the Gump
		public override object Title{ get{ return "Into the Darkness"; } }
		//This tells the story of the quest
		public override object Description { get { return "We need to be as hasty as possible because the fight is not going to be quick nor easy. I need you to go collect me some reagents for my summoning of the demon. While your at it, clear out some of the nasties in the area so that our forces can make there way into this dark dreary place."; } }
		//This decides how the npc reacts in text the player refusing the quest
		public override object Refuse{ get{ return "Tis a shame you are so yellow."; } }
		//This is what the npc says when the player returns without completing the objective(s)
		public override object Uncomplete{ get{ return "Make haste... The time has come."; } }
		//This is what the Quest Giver says when the player completes the quest.
		public override object Complete{ get{ return "Now I can summon the demon."; } }

		public IntotheDarkness() : base()
		{
			//Slay Objective #1
			AddObjective(new SlayObjective(typeof(Mongbat),"Mongbats",5));
			//Slay Objective #2
			AddObjective(new SlayObjective(typeof(Bogling),"Boglings",5));
			//Obtain Objective #1
			AddObjective(new ObtainObjective(typeof(Log),"Logs",10));
		}

		public override void GiveRewards()
		{
			//Random gold amount to add
			BankCheck gold = new BankCheck( Utility.RandomMinMax( 2000, 3000 ) );
			if( !Owner.AddToBackpack( gold ) )
			{
				gold.MoveToWorld(Owner.Location,Owner.Map);
			}

			//Add Quest Reward Token(s)
			//Owner.AddToBackpack( new QuestRewardToken( 1 ) );

			//Adding Quest Reward Token(s)
			for(int x = 0; x < 1; x++)
			{
				RandomTalisman talisman = new RandomTalisman();
				if(!Owner.AddToBackpack( talisman ) )
				{
					talisman.MoveToWorld(Owner.Location,Owner.Map);
				}
			}
			base.GiveRewards();
		}

		public override bool CanOffer()
		{
			return true;
		}
	}
}
