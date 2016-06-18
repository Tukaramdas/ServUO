//////////////////////////////////
//				                
//				                
//				                
// Just testing gump settings   
//				               
//	      For changes to gumps etc....
//
//  AddBackground(85, 30, 329, 408, 3500);
//
//  AddBackground(int x, int y, int width, int height, int gumpID)                  	
//				             
//////////////////////////////////	


using System;
using Server;
using Server.Gumps;
using Server.Network;
using Server.Mobiles;

namespace Server.Gumps
{
    public class GumpTest1Gump : Gump
    {
        public GumpTest1Gump()
            : base(0, 0)
        {

            this.Closable = true;
            this.Disposable = true;
            this.Dragable = true;
            this.Resizable = false;

            this.AddPage(1);
            this.AddBackground(23, 50, 450, 166, 9300);

            this.AddLabel(195, 65, 0, @"Player Guide");//Gump Title
            this.AddLabel(85, 90, 0, @"Commands");//Button1 
            this.AddLabel(85, 120, 0, @"Shard Info");//Button2 
            this.AddLabel(85, 150, 0, @"Getting Started");//Button3 
            this.AddLabel(225, 90, 0, @"Skills I");// Button 4
            this.AddLabel(225, 120, 0, @"Skills II");//Button 5
            this.AddLabel(225, 150, 4030, @"Web Pages");

            this.AddButton(40, 90, 4023, 4025, (int)Buttons.Button1, GumpButtonType.Page, 2);//Go to page 2 Player Commands
            this.AddButton(40, 120, 5541, 5542, (int)Buttons.Button2, GumpButtonType.Page, 3);//Go to page 3 Shard Info
            this.AddButton(40, 150, 4005, 4007, (int)Buttons.Button3, GumpButtonType.Page, 4);//Go to page 4 Getting Started
            this.AddButton(180, 90, 5538, 5539, (int)Buttons.Button4, GumpButtonType.Page, 5);//Go to page 5 - Skill I
            this.AddButton(180, 120, 4005, 4007, (int)Buttons.Button5, GumpButtonType.Page, 6);//Go to page 6 - Skill II
            this.AddButton(180, 150, 9721, 9724, (int)Buttons.Button6, GumpButtonType.Page, 7);//Go to page 7- Old web info
            //this.AddButton(180, 150, 9721, 9724, 16, GumpButtonType.Reply, 0);
            ////////////////////////////////////////////Page Break/////////////////////////////////////////////////////////
            this.AddPage(5);
            this.AddBackground(23, 50, 525, 303, 302);

            this.AddLabel(195, 65, 0, @"Skill Part II");//Gump Title
            this.AddButton(35, 320, 4014, 4015, (int)Buttons.BackButton1, GumpButtonType.Page, 1);//Back to page 1
            this.AddImage(455, 71, 9000);
            this.AddHtml(42, 85, 407, 224, @"The following is basic information on the skills available
Put stuff here", (bool)true, (bool)true);


            ////////////////////////////////////////////Page Break/////////////////////////////////////////////////////////
            this.AddPage(6);
            this.AddBackground(23, 50, 525, 303, 311);

            this.AddLabel(195, 65, 0, @"Skill Part II");//Gump Title
            this.AddButton(35, 320, 4014, 4014, (int)Buttons.BackButton1, GumpButtonType.Page, 1);//Back to page 1
            this.AddImage(455, 71, 9000);
            this.AddHtml(42, 85, 407, 224, @"The following is basic information on the skills available
MAGIC
Bushido: Defensive spells used by Samurai
Chivalry: Magic for warriors-defense, offense & healing
Evaluating Intelligence: Gives bonus to magery spells
Magery: The skill of casting spells with reagents
Meditation: The skill of focusing your mind to replenish mana
Mysticism: Magery designed by Gargoyles (can be used by any race)
Necromancy: Dark magic
Ninjitsu: Stealthy warriors
Resisting Spells: The skill of resisting magic cast on you
Spellweaving: Magic cast by teams.
Spirit Speak: Gives bonus to Necrmancy spells, and speak to the dead
WILD 
Animal Lore: View animal stats. Works with taming and veterinary
Animal Taming: The skill of domesticating animals
Camping: Used to logout in the wilderness 
Herding: The skill of convincing animals to go where you direct them
Fishing: Requires a fishing pole. Fishing from a boat can yield many things
Tracking: allows tracking of players and monsters
Veterinary: The ability to heal pets (Requires bandages, gets bonus from Anatomy)
THIEF
Detect Hidden: will reveal sneaky people who are hiding
Hiding: The skill of hiding in the shadows (works with Stealth)
Lockpicking: The skill of picking locks, open treasure chests and other containers
Poisoning: The skill of applying poisons
Removing Traps: The skill of removing a trap from a container
Snooping: The skill of peaking into another players backpack
Stealing: The skill of taking what isn't yours
Stealth: The skill of moving unnoticed (works with Hiding)
BARD
Musicianship: The skill to play various instruments
Musicianship adds bonuses to all music type skills
Discordance: Use music to disorientate a creature
Peacemaking: Use music to calm monsters
Provocation: Use music to make monsters aggressive
Discord, Peace & Provo all require an instrument and musicianship
", (bool)true, (bool)true);

            ////////////////////////////////////////////Page Break/////////////////////////////////////////////////////////

            this.AddPage(4);
            this.AddBackground(23, 50, 525, 303, 3000);

            this.AddLabel(195, 65, 0, @"Getting Started");//Gump Title
            this.AddButton(35, 320, 4014, 4014, (int)Buttons.BackButton1, GumpButtonType.Page, 1);//Back to page 1
            this.AddImage(455, 71, 9000);
            this.AddHtml(42, 85, 407, 224, @"The following is general information to help new players get started in the world of Ultima Online.
When you create your character you will start the game in the town of New Haven. In your pack you will find lots of useful items. More about them on the 'Commands' tab of this gump. Look around Haven and you see will see many Quest Givers. Talk to everyone-some you double click, some you right click. You may want to set your stats right away, but wait for the skills. Double-click your gold ledger and Token ledger to mark them as yours.
Take the road out the East side of town and you will find a ruined house. Inside is a Training Elemental and numerous Training Weapons. The Elementals do no damage, so remove your armor or it will wear out. You can train all your combat skills to GM here. WARNING: If you get your skills high enough to lose your 'Young' status you will be attackable by wandering critters.
In this house you will also find the start of the 'Newbie Quest'. Give the Letter of Apprenticeship to the correct NPC to start your quest. Read and follow the directions. The armor & weapons you receive will get you started. It is a good starter set, but not 'too' good. 
This is a true 'sandbox game'. It is an open world for you to explore. There is no hand holding or path to follow. The world is what you make of it. Warrior, crafter, mage, bard, fisherman, treasure hunter, whatever you want. There are numerous quests, lots of dungeons, and many continents & oceans to explore. 
Enjoy your stay!

", (bool)true, (bool)true);//

            ////////////////////////////////////////////Page Break/////////////////////////////////////////////////////////
            this.AddPage(2);
            this.AddBackground(23, 50, 525, 303, 83);

            this.AddLabel(195, 65, 0, @"Player Commands");//......Gump Title
            this.AddButton(35, 320, 4014, 4014, (int)Buttons.BackButton1, GumpButtonType.Page, 1);//......Back to page 1
            this.AddImage(455, 71, 9000);
            this.AddHtml(42, 85, 407, 224, @"General Commands
[Recall - automatically take you to Tito Tim's Casino. Good for getting away for a break.
[BoatControl - to get a pop up gump to control your boat.
[TurnBackToDeed - instead of an axe to redeed a household item.
[ChangeHairStyle - to change your hair or beard, for a small fee.
[Band - to get bandage target icon. [BandSelf - to apply bandage to yourself.
[Spellbar - to get your spell icons setup. You must have the spellbook in your main bag for it to be found. Better to use the Enhanced Client for the hotbars, though.
[ShowTool - to get a very handy toolbar.
[Loot - If a critter has special loot, say for a quest, it is recommended you loot it by hand before using the loot command.
If you are at the bank [Bank - opens your banbox and [Balance - will check your gold amount.

Handy Starting Items
ATLAS The World Travel Atlas looks like a regular rune book but acts almost like a moongate. Open the book and see all the options of where to go!
MASTER LOOTER BACKPACK If you single click the MasterLootBackpack you can set options for what, and how, it loots - uses [loot command. (Right click it in EC). 
TOKENS The Trash4TokensBackpack is a trash bag with a 3 minute timer.  It will give Tokens for some items.  No telling how much.  It will not give Tokens for any stackable items - but will delete them!  
SKILLBALL The skillball will let you choose 7 skills to GM. You may consider GM'ing tedious, or expensive, skills. It does not reset any other skills to zero, so you can keep what you earned - but you will lose your 'young' status.
STATBALL Set your stats. Max 600, individual max 200 (Str,Dex, and Int)
BANKSTONE You got a bankstone for bank access at home. Simply stand where you want to place the stone and double click the deed. If you double click the stone it will re-deed. You can interact with the bank stone as you would a banker. 
Questing Commands
[QuestLog - Displays quest history
[QuestRanking - Displays the top players in the quest ranking", 

(bool)true, (bool)true);
            ////////////////////////////////////////////Page Break/////////////////////////////////////////////////////////

            this.AddPage(3);
            this.AddBackground(23, 50, 450, 228, 2600);

            this.AddLabel(195, 65, 0, @"Shard Information");//......Gump Title
            this.AddLabel(50, 95, 0, @"Houses per Account:");
            this.AddLabel(180, 95, 0, @"5");//
            this.AddLabel(50, 120, 0, @"Skillcap:");
            this.AddLabel(110, 120, 0, @"None");//
            this.AddLabel(50, 145, 0, @"Statcap:");
            this.AddLabel(110, 145, 0, @"600");//
            this.AddLabel(50, 170, 0, @"Individual Statcap:");
            this.AddLabel(165, 170, 0, @"200");//
            this.AddLabel(50, 195, 0, @"Accounts per IP:");
            this.AddLabel(160, 195, 0, @"3");//
            this.AddLabel(50, 220, 0, @"Characters per Account:");
            this.AddLabel(205, 220, 0, @"5");
            //this.AddLabel(50, 220, 0, @"Houses per Account:");
            //this.AddLabel(205, 220, 0, @"5");
            this.AddButton(35, 245, 4014, 4014, (int)Buttons.BackButton3, GumpButtonType.Page, 1);//ack to page 1
            this.AddImage(395, 200, 5608);
            ////////////////////////////////////////////Page Break/////////////////////////////////////////////////////////

                   this.AddPage(7);
                   this.AddBackground(23, 50, 450, 228, 9250);

                   this.AddLabel(195, 65, 0, @"General Information");//......Gump Title
                   this.AddLabel(85, 95, 0, @"Rules");//......Button title 1
                   this.AddLabel(85, 120, 0, @"Forums");//......Button title 2
                   this.AddLabel(85, 145, 0, @"Donate");//......Button title 3
                   this.AddLabel(85, 170, 0, @"Updates");//......Button title 4
                   this.AddLabel(85, 195, 0, @"How to Patch");//button 6
                   this.AddButton(50, 95, 4020, 4020, (int)Buttons.WebsiteButton2, GumpButtonType.Reply, 0);//......To shard rules on website
                   this.AddButton(50, 120, 4020, 4020, (int)Buttons.WebsiteButton3, GumpButtonType.Reply, 0);//......To shard features on website
                   this.AddButton(50, 145, 4020, 4020, (int)Buttons.WebsiteButton4, GumpButtonType.Reply, 0);//......To Donation store
                   this.AddButton(50, 170, 4020, 4020, (int)Buttons.WebsiteButton5, GumpButtonType.Reply, 0);//......To Shard updates on website
                   this.AddButton(50, 195, 4020, 4020, (int)Buttons.WebsiteButton6, GumpButtonType.Reply, 0);// Patching link
                   this.AddButton(35, 245, 4014, 4014, (int)Buttons.BackButton4, GumpButtonType.Page, 1);//......Back to page 1
                   this.AddImage(195, 120, 0x2C95);
        }

        public enum Buttons
        {
            Button1,
            Button2,
            Button3,
            Button4,
            Button5,
            Button6,
            BackButton1,
            BackButton3,
            BackButton4,
            WebsiteButton1,
            WebsiteButton2,
            WebsiteButton3,
            WebsiteButton4,
            WebsiteButton5,
            WebsiteButton6,
        }


      public override void OnResponse(NetState sender, RelayInfo info)
        {
            Mobile m = sender.Mobile;
            {
                switch (info.ButtonID)
                {
                    case (int)Buttons.WebsiteButton1:
                        sender.LaunchBrowser("http://in-uo.net/info/2011-11-06-11-05-03/regular--commands");//......Command List Url
                        break;

                    case (int)Buttons.WebsiteButton2:
                        sender.LaunchBrowser("http://in-uo.net/info/server-rules");//......Shard Rules Url
                        break;

                    case (int)Buttons.WebsiteButton3:
                        sender.LaunchBrowser("http://in-uo.net/forums");//......Forum Url
                        break;

                    case (int)Buttons.WebsiteButton4:
                        sender.LaunchBrowser("http://in-uo.net/donate");//......Shard Donation Store Url
                        break;

                    case (int)Buttons.WebsiteButton5:
                        sender.LaunchBrowser("http://in-uo.net/changelogs/2011-07-28-18-05-48");//......Shard Updates Url
                        break;

                    case (int)Buttons.WebsiteButton6:
                        sender.LaunchBrowser("http://in-uo.net/join");//how to patch
                        break;
     
                }
            }
        }
   
    }
}

