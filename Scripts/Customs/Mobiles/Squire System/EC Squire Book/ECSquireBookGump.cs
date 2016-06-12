using System;
using Server;
using Server.Gumps;
using Server.Network;
using Server.Mobiles;

namespace Server.Gumps
{
    public class ECSquireBookGump : Gump
    {
        public ECSquireBookGump()
            : base(0, 0)
        {

            this.Closable = true;
            this.Disposable = true;
            this.Dragable = true;
            this.Resizable = false;

            this.AddPage(1);
            this.AddBackground(23, 50, 450, 200, 9250);
            this.AddImage(235, 90, 0x2C95);

            this.AddLabel(100, 65, 0, @"Squire Commands List by Lord Montegro");//Gump Title
            this.AddLabel(85, 90, 0, @"Basic Care");//Button1 
            this.AddLabel(85, 120, 0, @"Combat");//Button2 
            this.AddLabel(85, 150, 0, @"Looting Barding & Potions");//Button3 
            this.AddLabel(85, 180, 0, @"Chivalry Spells");// Button 4
          
            this.AddButton(40, 90, 4005, 4007, (int)Buttons.Button1, GumpButtonType.Page, 2);//Go to page 2 Basic Care
            this.AddButton(40, 120, 4005, 4007, (int)Buttons.Button2, GumpButtonType.Page, 3);//Go to page 3 Combat
            this.AddButton(40, 150, 4005, 4007, (int)Buttons.Button3, GumpButtonType.Page, 4);//Go to page 4 Looting Barding & Potions
            this.AddButton(40, 180, 4005, 4007, (int)Buttons.Button4, GumpButtonType.Page, 5);//Go to page 5 Chivalry Spells
                        

            ////////////////////////////////////////////Page Break/////////////////////////////////////////////////////////
            this.AddPage(2);
            this.AddBackground(23, 50, 525, 303, 311);

            this.AddLabel(195, 65, 0, @"Basic Care");//Gump Title
            this.AddButton(35, 320, 4014, 4014, (int)Buttons.BackButton1, GumpButtonType.Page, 1);//Back to page 1
            this.AddImage(455, 71, 9000);
            this.AddHtml(42, 85, 407, 224, @"Backpack: orders your squire to show you the contents of their backpack.  
Be Quiet : will stop  your squire from talking until you tell them to  					
Talk Again : allows squire to start talking again
Change My Nickname: prompts your squire to change what they call you. 
Change Your Nickname : see Change My Nickname only applied to your   squire. They will respond to this nickname when you call out an order to it.   	
Change Title: Instructs your Squire to present you with a list of possible titles that they are qualified to be given. 
Dress: orders your squire to dress themselves using what is in their backpack.  
Undress: orders your quire to give you their clothing and equipment.  
Heal: orders your squire to use bandages on a target.  
Hide: orders your squire to hide.  
List: orders your squire to list what is in their inventory.  
Unload: orders your squire to give you all items in their pack. 
Meditate : Self Explanatory. 
Mount: orders your squire to mount a target.  
Dismount: orders your squire to dismount from their mount.  
Play Music: orders your squire to play a song using an instrument in their backpack.  
Quiver : tells your squire to present their quiver to you. 
Rename Yourself: orders your squire to pick a new name for themselves.  
Restyle: Allows you to restyle your squire's hair.  
Skills : See Stats command. Switches : See Stats command. 
Spirit Speak : have your squire channel the spirit world. 
Stats: displays your squire's skills and stats in a window.  
Throw: tells your squire to throw a snow ball at a target.  
Your squire will feed themselves with whatever food is in their inventory. They will not eat if not hungry so don't leave them out next to you instead bring them to an innkeeper or a room attendant to put them in a room for a while.
Squires will automatically use bandages to heal themselves and their masters when enough damage is dealt. Make sure they hold enough bandages in their backpacks to make sure they don't run out. 
", (bool)true, (bool)true);

            ////////////////////////////////////////////Page Break/////////////////////////////////////////////////////////
            this.AddPage(3);
            this.AddBackground(23, 50, 525, 303, 311);

            this.AddLabel(195, 65, 0, @"Combat");//Gump Title
            this.AddButton(35, 320, 4014, 4014, (int)Buttons.BackButton1, GumpButtonType.Page, 1);//Back to page 1
            this.AddImage(455, 71, 9000);
            this.AddHtml(42, 85, 407, 224, @"Arm: orders your squire to arm themselves with what is in their inventory.  
Attack: orders your squire to attack a target using weapon abilities.  
Kill: see Attack.  
Guard: orders your squire to guard you from any aggressive enemy and use their weapon skills.  
Guard Me : see Guard.  					 
Unarm : tells your squire to put their weapons away into their own backpack. 
Create Set One : tells your squire to create weapon set one saving it so they can equip it on command. This holds whatever is in their hands at the time the command is given.
Equip Set One : tells your squire to equip the set you had them save earlier. 
Create Set Two : see Create Set One. 
Equip Set Two : see Equip Set One. 
Create Set Three : see Create Set One. 
Equip Set Three : see Equip Set One. 
Set Team : tells your squire that you would like to assign them to a team.
Weapon Ability : tells your squire to use a weapon ability. 
Weapon Ability One : commands your squire to use their primary weapon ability. 
Weapon Ability Two : commands your squire to use their secondary weapon ability.", (bool)true, (bool)true);

            ////////////////////////////////////////////Page Break/////////////////////////////////////////////////////////
            this.AddPage(4);
            this.AddBackground(23, 50, 525, 303, 311);

            this.AddLabel(195, 65, 0, @"Looting Barding & Potions");//Gump Title
            this.AddButton(35, 320, 4014, 4014, (int)Buttons.BackButton1, GumpButtonType.Page, 1);//Back to page 1
            this.AddImage(455, 71, 9000);
            this.AddHtml(42, 85, 407, 224, @"Looting
Grab: orders your squire to pick an item off of the ground.  
Grab All: orders your squire to grab all items within their reach off the ground.  
Loot: orders your squire to loot a body. 
Loot All: orders your squire to loot all bodies around them.  

Barding
Make Peace : will order    your squire to use try to use peacemaking on  your target.  				   				  		
Discord : orders your   squire to play a song   of discord on your   target.   					 
Provoke : orders your  squire to play a song   of provocation on your  target.  	

Potions		   				  				 	
Drink Agility : tells your  squire to drink an agility   potion from their backpack.   					 
Drink Poison : tells your   squire to drink poison.   					 
Drink Refresh : tells your  squire to drink a refresh   potion.   					 
Drink Strength : tells your squire to drink a strength potion.   					 
Drink Cure : tells your  squire to drink a cure  potion.   
Drink Health : tells your squire to drink a health potion. 
Poison : Prompts your Squire to start the process of poisoning an item for you. You may select a potion and an item from their or your backpack.
Throw Explosion : Tells your Squire to throw an explosion potion where you indicate. ", (bool)true, (bool)true);//

            ////////////////////////////////////////////Page Break/////////////////////////////////////////////////////////
            this.AddPage(5);
            this.AddBackground(23, 50, 525, 303, 311);

            this.AddLabel(195, 65, 0, @"Chivalry Spells");//Gump Title
            this.AddButton(35, 320, 4014, 4014, (int)Buttons.BackButton1, GumpButtonType.Page, 1);//Back to page 1
            this.AddImage(455, 71, 9000);
            this.AddHtml(42, 85, 407, 224, @"Check Tithing Points : has your squire tell you how many tithing points they have. 
Tithe : tells your squire to tithe the gold in their inventory. 
Cleanse By Fire : tells your squire to cast the spell.
Close Wounds : tells your squire to cast the spell. Consecrate Weapon : tells your squire to cast the spell. 
Divine Fury : tells your squire to cast the spell. 
Dispel Evil : tells your squire to cast the spell.
Enemy Of One : tells yours quire to cast the spell. 
Holy Light : tells your squire to cast the spell. 
Noble Sacrifice : tells your squire to cast the spell.
Remove Curse : tells your squire to cast the spell.", 

(bool)true, (bool)true);
            ////////////////////////////////////////////Page Break/////////////////////////////////////////////////////////

        }

        public enum Buttons
        {
            Button1,
            Button2,
            Button3,
            Button4,
            Button5,
            BackButton1,
            BackButton3,
            BackButton4,
        }
    }
}

