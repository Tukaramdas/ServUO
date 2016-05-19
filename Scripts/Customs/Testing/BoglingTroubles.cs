//=================================================
//This script was created by Gizmo's Uo Quest Maker
//This script was created on 5/13/2016 12:51:59
//=================================================

using System;
using Server;
using Server.Items;
using Server.Mobiles;

namespace Server.Engines.Quests
{
	public class BoglingTroubles : BaseQuest
	{
		//The player will have a delay before they can redo quest again
		public override TimeSpan RestartDelay { get { return TimeSpan.FromMinutes(5); } }

		//This is the Quest Title the player sees at the top of the Gump
		public override object Title{ get{ return "Bogling Troubles"; } }
		//This tells the story of the quest
		public override object Description { get { return "I am in need of assistance. I cannot go out in the woods as I am scared of boglings. Could you please kill somne for me to make the woods safer? If you kill 10 boglings I will reward thee with some gold."; } }
		//This decides how the npc reacts in text the player refusing the quest
		public override object Refuse{ get{ return "Oh, that is ok... I am safer staying home."; } }
		//This is what the npc says when the player returns without completing the objective(s)
		public override object Uncomplete{ get{ return "Please keep trying, I would like to explore the woods - when they are safe."; } }
		//This is what the Quest Giver says when the player completes the quest.
		public override object Complete{ get{ return "Thank you so much! You are a great hero. Here is your reward"; } }

		public BoglingTroubles() : base()
		{
		}

		public override void GiveRewards()
		{
			//Random gold amount to add
			BankCheck gold = new BankCheck( Utility.RandomMinMax( 1000, 1500 ) );
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
			base.GiveRewards();
		}

		public override bool CanOffer()
		{
			return true;
		}
	}
}
