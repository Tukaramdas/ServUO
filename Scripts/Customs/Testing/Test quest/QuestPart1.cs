//=================================================
//This script was created by Gizmo's Uo Quest Maker
//This script was created on 6/9/2016 09:54:50
//=================================================

using System;
using Server;
using Server.Items;
using Server.Mobiles;

namespace Server.Engines.Quests
{
	public class QuestPart1 : BaseQuest
	{
		//This is the Quest Title the player sees at the top of the Gump
		public override object Title{ get{ return "QuestPart1"; } }
		//This tells the story of the quest
		public override object Description { get { return "Please help me. If yoiu say 'I will help thee' you will get a Letter of Introduction. Take this letter to QuestGiver2"; } }
		//This decides how the npc reacts in text the player refusing the quest
		public override object Refuse{ get{ return "bummer, dude"; } }
		//This is what the npc says when the player returns without completing the objective(s)
		public override object Uncomplete{ get{ return "please hurry"; } }
		//This is what the Quest Giver says when the player completes the quest.
		public override object Complete{ get{ return "Thanks, man."; } }

		public QuestPart1() : base()
		{
			
			//Obtain Objective #1
			AddObjective(new ObtainObjective(typeof(GoldEarrings),"RavanasEarrings",1));
            //Deliver Objective #1
          //  	AddObjective(new DeliverObjective( typeof( HanumanIntroduction ), "HanumanIntroduction", 1, typeof( MondainQuester ), "QuestGiver2"  ));
        }

        public override void GiveRewards()
		{
			//Random gold amount to add
			BankCheck gold = new BankCheck( Utility.RandomMinMax( 100, 150 ) );
			if( !Owner.AddToBackpack( gold ) )
			{
				gold.MoveToWorld(Owner.Location,Owner.Map);
			}

			base.GiveRewards();
		}

		public override bool CanOffer()
		{
			return true;
		}
	}
}
