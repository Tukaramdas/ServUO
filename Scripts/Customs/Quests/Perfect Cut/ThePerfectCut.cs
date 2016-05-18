//=================================================
//This script was created by Gizmo's Uo Quest Maker
//This script was created on 5/14/2016 21:32:26
//=================================================

using System;
using Server;
using Server.Items;
using Server.Mobiles;

namespace Server.Engines.Quests
{
	public class ThePerfectCut : BaseQuest
	{
		//The player will have a delay before they can redo quest again
		public override TimeSpan RestartDelay { get { return TimeSpan.FromMinutes(60); } }

		//This is the Quest Title the player sees at the top of the Gump
		public override object Title{ get{ return "The Perfect Cut"; } }
		//This tells the story of the quest
		public override object Description { get { return "I have had my fair share of gems come in and out of this place. But to find the truely rare cuts of gem is another story. Deep within the mines, the caverns and even along the mountain stretches riches beyond any mans dream. If you come across a gem I am looking for. Please bring it to me and I will reward you for your time."; } }
		//This decides how the npc reacts in text the player refusing the quest
		public override object Refuse{ get{ return "What a shame."; } }
		//This is what the npc says when the player returns without completing the objective(s)
		public override object Uncomplete{ get{ return "If you find a rare gem, bring it to me."; } }
		//This is what the Quest Giver says when the player completes the quest.
		public override object Complete{ get{ return "Sweet tator tots, look at the size of that thing. I really want to thank you for bringing me this. Im gonna make a.. I am going to put it in the display case so all can marvel at its rare beauty."; } }

		public ThePerfectCut() : base()
		{
			int which = Utility.RandomMinMax( 1, 6 );
			if( which == 1 )
				AddObjective(new ObtainObjective(typeof(DarkSapphire),"Dark Sapphire",1));
			if( which == 2 )
				AddObjective(new ObtainObjective(typeof(Turquoise),"Turquoise",1));
			if( which == 3 )
				AddObjective(new ObtainObjective(typeof(EcruCitrine),"Ecru Citrine",1));
			if( which == 4 )
				AddObjective(new ObtainObjective(typeof(FireRuby),"Fire Ruby",1));
			if( which == 5 )
				AddObjective(new ObtainObjective(typeof(BlueDiamond),"Blue Diamond",1));
			if( which == 6 )
				AddObjective(new ObtainObjective(typeof(PerfectEmerald),"Perfect Emerald",1));
		}

		public override void GiveRewards()
		{
			//Random gold amount to add
			BankCheck gold = new BankCheck( Utility.RandomMinMax( 500, 600 ) );
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
			bonusitem = new DullCopperIngot( 20 );
			//Adding Bonus Item #1
			if(!Owner.AddToBackpack( bonusitem ) )
			{
				bonusitem.MoveToWorld(Owner.Location,Owner.Map);
			}

			bonusitem = new ShadowIronIngot( 20 );
			//Adding Bonus Item #2
			if(!Owner.AddToBackpack( bonusitem ) )
			{
				bonusitem.MoveToWorld(Owner.Location,Owner.Map);
			}

			bonusitem = new CopperIngot( 20 );
			//Adding Bonus Item #3
			if(!Owner.AddToBackpack( bonusitem ) )
			{
				bonusitem.MoveToWorld(Owner.Location,Owner.Map);
			}

			bonusitem = new BronzeIngot( 20 );
			//Adding Bonus Item #4
			if(!Owner.AddToBackpack( bonusitem ) )
			{
				bonusitem.MoveToWorld(Owner.Location,Owner.Map);
			}

			bonusitem = new GoldIngot( 20 );
			//Adding Bonus Item #5
			if(!Owner.AddToBackpack( bonusitem ) )
			{
				bonusitem.MoveToWorld(Owner.Location,Owner.Map);
			}

			bonusitem = new AgapiteIngot( 20 );
			//Adding Bonus Item #6
			if(!Owner.AddToBackpack( bonusitem ) )
			{
				bonusitem.MoveToWorld(Owner.Location,Owner.Map);
			}

			bonusitem = new VeriteIngot( 20 );
			//Adding Bonus Item #7
			if(!Owner.AddToBackpack( bonusitem ) )
			{
				bonusitem.MoveToWorld(Owner.Location,Owner.Map);
			}

			bonusitem = new ValoriteIngot( 20 );
			//Adding Bonus Item #8
			if(!Owner.AddToBackpack( bonusitem ) )
			{
				bonusitem.MoveToWorld(Owner.Location,Owner.Map);
			}

			base.GiveRewards();
		}

		public override bool CanOffer()
		{
			return (Owner.Skills[SkillName.Mining].Base >= 100.0);
		}
	}
}
