//===============================================================================
//                      This script was created by Gizmo's UoDevPro
//                      This script was created on 6/15/2016 17:57:16
//===============================================================================


using System;
using Server;
using Server.Items;
using Server.Mobiles;

namespace Server.Engines.Quests
{
	public class Welcome : BaseQuest
	{
		public Welcome() : base()
		{
			//The player must slay 1 Balron
			this.AddObjective(new SlayObjective(typeof(Balron), "Balron", 1));
			//The player must collect 1 of GingerbreadDough
			this.AddObjective(new ObtainObjective(typeof(Item), "GingerbreadDough", 1));
			//Reward the Player Gold
			this.AddReward(new BaseReward("500-1000 Gold"));
			//Reward the Player Magic Item(s)
			this.AddReward(new BaseReward("2 Magic Item(s)"));
			//Quest Has Chance at Special Item
			this.AddReward(new BaseReward("Chance of Item(s)"));
		}


		//Quest Title
		public override object Title { get { return "Welcome"; } }
		//Quest Description
		public override object Description { get { return "Hey welcome home.  We have a small errand for you if you are interested... A very small criter needs to be slayed, if you would like to help...."; } }
		//Quest Refuse Message
		public override object Refuse { get { return "Aww...it would have been fun"; } }
		//Quest Uncompleted Message
		public override object Uncomplete { get { return "Please hurry"; } }
		//Quest Completed Message
		public override object Complete { get { return "Thank you for killing that horrid monster. Don't be angry with me for tricking you ha ha"; } }

		public override void GiveRewards()
		{
			//Give Gold to player in form of a bank check
			BankCheck gold = new BankCheck(Utility.RandomMinMax(500, 1000));
			if(!Owner.AddToBackpack( gold ))
				gold.MoveToWorld(Owner.Location,Owner.Map);

			Item item;

			//Random Magic Item #1
			item = Loot.RandomArmorOrShieldOrWeaponOrJewelry();
			if( item is BaseWeapon )
				BaseRunicTool.ApplyAttributesTo((BaseWeapon)item, 3, 10, 50 );
			if( item is BaseArmor )
				BaseRunicTool.ApplyAttributesTo((BaseArmor)item, 3, 10, 50 );
			if( item is BaseJewel )
				BaseRunicTool.ApplyAttributesTo((BaseJewel)item, 3, 10, 50 );
			if( item is BaseHat )
				BaseRunicTool.ApplyAttributesTo((BaseHat)item, 3, 10, 50 );
			if(!Owner.AddToBackpack( item ) )
			{
				item.MoveToWorld(Owner.Location,Owner.Map);
			}

			//Random Magic Item #2
			item = Loot.RandomArmorOrShieldOrWeaponOrJewelry();
			if( item is BaseWeapon )
				BaseRunicTool.ApplyAttributesTo((BaseWeapon)item, 3, 10, 50 );
			if( item is BaseArmor )
				BaseRunicTool.ApplyAttributesTo((BaseArmor)item, 3, 10, 50 );
			if( item is BaseJewel )
				BaseRunicTool.ApplyAttributesTo((BaseJewel)item, 3, 10, 50 );
			if( item is BaseHat )
				BaseRunicTool.ApplyAttributesTo((BaseHat)item, 3, 10, 50 );
			if(!Owner.AddToBackpack( item ) )
			{
				item.MoveToWorld(Owner.Location,Owner.Map);
			}

			//Chance of Special Item
			if ( Utility.RandomMinMax( 1, 1 ) == 1 )
			{
				item = new RalphiesWelcomeNecklace(  );
				if(!Owner.AddToBackpack( item ) )
				{
					item.MoveToWorld(Owner.Location,Owner.Map);
				}
			}


			base.GiveRewards();
		}

		public override void Serialize(GenericWriter writer)
		{
			base.Serialize(writer);
			writer.Write((int)0); // version
		}
		public override void Deserialize(GenericReader reader)
		{
			base.Deserialize(reader);
			int version = reader.ReadInt();
		}
	}
}
