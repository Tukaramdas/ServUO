//=================================================
//This script was created by Gizmo's Uo Quest Maker
//This script was created on 5/15/2016 12:10:44
//=================================================

using System;
using Server;
using Server.Items;
using Server.Mobiles;

namespace Server.Engines.Quests
{
	public class Ramayan : BaseQuest
	{
		//Player can only do quest once
		public override bool DoneOnce{ get{ return false;
            }
        }

		//This is the Quest Title the player sees at the top of the Gump
		public override object Title{ get{ return "Ramayan";
            }
        }
		//This tells the story of the quest
		public override object Description
        {
            get
            {
                return "Alas, what a world we live in. The fair Princess Sita has been captured by the foul demon Ravana! We have our General, Hanuman, scouring the globe in search of her. If you could find Hanuman and help him resscue Sita we would be in your debt forever. Hanuman was last reported in Skara Brae.";
            }
        }
		//This decides how the npc reacts in text the player refusing the quest
		public override object Refuse
        {
            get
            {
                return "Poor Sita...never to be freed";
            }
        }
		//This is what the npc says when the player returns without completing the objective(s)
		public override object Uncomplete{ get{ return "Please keep searching for the Princess";
            }
        }
		//This is what the Quest Giver says when the player completes the quest.
		public override object Complete{ get{ return "Ah! What a warrior. Our eternal thanks. Take this small token of our appreciation. ";
            }
        }

		public Ramayan() : base()
		{
			//Obtain Objective #1
			AddObjective(new ObtainObjective(typeof(GoldEarrings),"RavanasEarrings",1));
		}

        public override void GiveRewards()
        {
            //Random gold amount to add
            BankCheck gold = new BankCheck(Utility.RandomMinMax(5000, 6000));
            if (!Owner.AddToBackpack(gold))
            {
                gold.MoveToWorld(Owner.Location, Owner.Map);
            }

            //Adding Quest Reward Token(s)
            for (int x = 0; x < 1; x++)
            {
                RandomTalisman talisman = new RandomTalisman();
                if (!Owner.AddToBackpack(talisman))
                {
                    talisman.MoveToWorld(Owner.Location, Owner.Map);
                }
            }
            Item bonusitem;
            bonusitem = new RamaRobe();
            //Adding Bonus Item #1
            if (!Owner.AddToBackpack(bonusitem))
            {
                bonusitem.MoveToWorld(Owner.Location, Owner.Map);
            }


            base.GiveRewards();
        }
        public override bool CanOffer()
		{
			return true;
		}
	}
}
