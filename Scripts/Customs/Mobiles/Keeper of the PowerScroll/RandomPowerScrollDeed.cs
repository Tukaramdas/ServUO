/////Scripted By Talon Nyte/////
using System;
using Server;
using Server.Gumps;
using Server.Network;

namespace Server.Items
{

	public class RandomPowerScrollDeed : Item
	{

		[Constructable]
		public RandomPowerScrollDeed() : this( null )
		{
		}

		[Constructable]
		public RandomPowerScrollDeed ( string name ) : base ( 0x14F0 )
		{
			Name = "Random PowerScroll Deed";
			Hue = 1172;
		}

		public RandomPowerScrollDeed ( Serial serial ) : base ( serial )
		{
		}

      		public override void OnDoubleClick( Mobile from ) 
      		{
			if ( !IsChildOf( from.Backpack ) )
			{
                from.SendLocalizedMessage(1042001);
            }
            else
            {
                if (Utility.Random(55) < 98)
            		{

                		int level;

                		double random = Utility.RandomDouble();

                		if (0.50 >= random)
                    		level = 150;

                		else
                    		level = 120;

                		switch (Utility.Random(55))
                {
                    case 0: from.AddToBackpack(new PowerScroll (SkillName.Alchemy, level)); break;
                    case 1: from.AddToBackpack(new PowerScroll (SkillName.Anatomy, level)); break;
                    case 2: from.AddToBackpack(new PowerScroll (SkillName.AnimalLore, level)); break;
                    case 3: from.AddToBackpack(new PowerScroll (SkillName.AnimalTaming, level)); break;
                    case 4: from.AddToBackpack(new PowerScroll (SkillName.Archery, level)); break;
                    case 5: from.AddToBackpack(new PowerScroll (SkillName.ArmsLore, level)); break;
                    case 6: from.AddToBackpack(new PowerScroll (SkillName.Begging, level)); break;
                    case 7: from.AddToBackpack(new PowerScroll (SkillName.Blacksmith, level)); break;
                    case 8: from.AddToBackpack(new PowerScroll (SkillName.Bushido, level)); break;
                    case 9: from.AddToBackpack(new PowerScroll (SkillName.Camping, level)); break;
                    case 10: from.AddToBackpack(new PowerScroll (SkillName.Carpentry, level)); break;
                    case 11: from.AddToBackpack(new PowerScroll (SkillName.Cartography, level)); break;
                    case 12: from.AddToBackpack(new PowerScroll (SkillName.Chivalry, level)); break;
                    case 13: from.AddToBackpack(new PowerScroll (SkillName.Cooking, level)); break;
                    case 14: from.AddToBackpack(new PowerScroll (SkillName.DetectHidden, level)); break;
                    case 15: from.AddToBackpack(new PowerScroll (SkillName.Discordance, level)); break;
                    case 16: from.AddToBackpack(new PowerScroll (SkillName.EvalInt, level)); break;
                    case 17: from.AddToBackpack(new PowerScroll (SkillName.Fishing, level)); break;
                    case 18: from.AddToBackpack(new PowerScroll (SkillName.Fencing, level)); break;
                    case 19: from.AddToBackpack(new PowerScroll (SkillName.Fletching, level)); break;
                    case 20: from.AddToBackpack(new PowerScroll (SkillName.Focus, level)); break;
                    case 21: from.AddToBackpack(new PowerScroll (SkillName.Forensics, level)); break;
                    case 22: from.AddToBackpack(new PowerScroll (SkillName.Healing, level)); break;
                    case 23: from.AddToBackpack(new PowerScroll (SkillName.Herding, level)); break;
                    case 24: from.AddToBackpack(new PowerScroll (SkillName.Hiding, level)); break;
                    case 25: from.AddToBackpack(new PowerScroll (SkillName.Inscribe, level)); break;
                    case 26: from.AddToBackpack(new PowerScroll (SkillName.ItemID, level)); break;
                    case 27: from.AddToBackpack(new PowerScroll (SkillName.Lockpicking, level)); break;
                    case 28: from.AddToBackpack(new PowerScroll (SkillName.Lumberjacking, level)); break;
                    case 29: from.AddToBackpack(new PowerScroll (SkillName.Macing, level)); break;
                    case 30: from.AddToBackpack(new PowerScroll (SkillName.Magery, level)); break;
                    case 31: from.AddToBackpack(new PowerScroll (SkillName.MagicResist, level)); break;
                    case 32: from.AddToBackpack(new PowerScroll (SkillName.Meditation, level)); break;
                    case 33: from.AddToBackpack(new PowerScroll (SkillName.Mining, level)); break;
                    case 34: from.AddToBackpack(new PowerScroll (SkillName.Musicianship, level)); break;
                    case 35: from.AddToBackpack(new PowerScroll (SkillName.Necromancy, level)); break;
                    case 36: from.AddToBackpack(new PowerScroll (SkillName.Ninjitsu, level)); break;
                    case 37: from.AddToBackpack(new PowerScroll (SkillName.Parry, level)); break;
                    case 38: from.AddToBackpack(new PowerScroll (SkillName.Peacemaking, level)); break;
                    case 39: from.AddToBackpack(new PowerScroll (SkillName.Poisoning, level)); break;
                    case 40: from.AddToBackpack(new PowerScroll (SkillName.Provocation, level)); break;
                    case 41: from.AddToBackpack(new PowerScroll (SkillName.RemoveTrap, level)); break;
                    case 42: from.AddToBackpack(new PowerScroll (SkillName.Snooping, level)); break;
                    case 43: from.AddToBackpack(new PowerScroll (SkillName.SpiritSpeak, level)); break;
                    case 44: from.AddToBackpack(new PowerScroll (SkillName.Stealing, level)); break;
                    case 45: from.AddToBackpack(new PowerScroll (SkillName.Stealth, level)); break;
                    case 46: from.AddToBackpack(new PowerScroll (SkillName.Spellweaving, level)); break;
                    case 47: from.AddToBackpack(new PowerScroll (SkillName.Swords, level)); break;
                    case 48: from.AddToBackpack(new PowerScroll (SkillName.Tactics, level)); break;
                    case 49: from.AddToBackpack(new PowerScroll (SkillName.Tailoring, level)); break;
                    case 50: from.AddToBackpack(new PowerScroll (SkillName.TasteID, level)); break;
                    case 51: from.AddToBackpack(new PowerScroll (SkillName.Tinkering, level)); break;
                    case 52: from.AddToBackpack(new PowerScroll (SkillName.Tracking, level)); break;
                    case 53: from.AddToBackpack(new PowerScroll (SkillName.Veterinary, level)); break;
                    case 54: from.AddToBackpack(new PowerScroll (SkillName.Wrestling, level)); break;
                }
                this.Delete();
			}

		}
          }

		public override void Serialize ( GenericWriter writer)
		{
			base.Serialize ( writer );

			writer.Write ( (int) 0);
		}

		public override void Deserialize( GenericReader reader )
		{
			base.Deserialize ( reader );

			int version = reader.ReadInt();
		}
	}
}