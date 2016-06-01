using System;
using System.IO;
using Server.Gumps;
using Server.Items;
using Server.Guilds;
using Server.Network;
using Server.Mobiles;
using Server.Factions;
using Server.Targeting;
using Server.Accounting;
using System.Collections;

namespace Server.FSHSR
{
	public class HSRTournamentSystem
	{
        //Default set OFF; Dian
		public static readonly bool Enabled = false;																						// Default true. Disable or Enable tournaments
		
		public static readonly DayOfWeek TournyOne = DayOfWeek.Monday; 																		// Default Monday. Range: Monday - Sunday
		public static readonly DayOfWeek TournyTwo = DayOfWeek.Wednesday;																	// Default Wednesday. Range: Monday - Sunday
		public static readonly DayOfWeek TournyThree = DayOfWeek.Saturday; 																	// Default Saturday. Range: Monday - Sunday
		
		public static readonly DateTime StartTimeOne = new DateTime( DateTime.UtcNow.Year, DateTime.UtcNow.Month, DateTime.UtcNow.Day, 16, 0, 0 );	// Default 16, 0, 0 (4:00pm) Range: 0-23, 0-59, 0-59
		public static readonly DateTime StartTimeTwo = new DateTime( DateTime.UtcNow.Year, DateTime.UtcNow.Month, DateTime.UtcNow.Day, 13, 0, 0 ); 	// Default 13, 0, 0 (1:00pm) Range: 0-23, 0-59, 0-59
		public static readonly DateTime StartTimeThree = new DateTime( DateTime.UtcNow.Year, DateTime.UtcNow.Month, DateTime.UtcNow.Day, 10, 0, 0 ); // Default 10, 0, 0 (10:00am) Range: 0-23, 0-59, 0-59
		
		public static TimeSpan WarningDelay = TimeSpan.FromMinutes( 30.0 );																	// Default 30 minutes, Can adjust to hours or whatever you want.

		public static void Initialize()
		{
			if ( Enabled )
			{
				if ( DateTime.UtcNow.DayOfWeek == TournyOne )
				{
					new TournamentWarningTimer( StartTimeOne - WarningDelay ).Start();
					new TournamentStartTimer( StartTimeOne ).Start();
				}
				else if ( DateTime.UtcNow.DayOfWeek == TournyTwo )
				{
					new TournamentWarningTimer( StartTimeTwo - WarningDelay ).Start();
					new TournamentStartTimer( StartTimeTwo ).Start();
				}
				else if ( DateTime.UtcNow.DayOfWeek == TournyThree )
				{
					new TournamentWarningTimer( StartTimeThree - WarningDelay ).Start();
					new TournamentStartTimer( StartTimeThree ).Start();
				}
			}
		}

		public class TournamentWarningTimer : Timer
		{
			public TournamentWarningTimer( DateTime end ) : base( end - DateTime.UtcNow )
			{
			}
			
			protected override void OnTick()
			{
				string remaining = "shortly.";

				if ( WarningDelay.Hours > 0 )
				{
					int hour = WarningDelay.Hours;
					
					if ( hour > 1 )
						remaining = String.Format( "in {0} hours.", hour.ToString() );
					else
						remaining = String.Format( "in {0} hour.", hour.ToString() );
				}
				else if ( WarningDelay.Minutes > 0 )
				{
					int min = WarningDelay.Minutes;
					
					if ( min > 1 )
						remaining = String.Format( "in {0} minutes.", min.ToString() );
					else
						remaining = String.Format( "in {0} minute.", min.ToString() );
				}
				else if ( WarningDelay.Seconds > 0 )
				{
					int sec = WarningDelay.Seconds;
					
					if ( sec > 1 )
						remaining = String.Format( "in {0} seconds.", sec.ToString() );
					else
						remaining = String.Format( "in {0} second.", sec.ToString() );
				}
			
				if ( DateTime.UtcNow.DayOfWeek == TournyOne )
				{
					World.Broadcast( 0x35, true, "The toxic trout tournament will start {0}", remaining );
					World.Broadcast( 0x35, true, "Goto any fishing tournament master for details on todays tournament." );
				}
				else if ( DateTime.UtcNow.DayOfWeek == TournyTwo )
				{
					World.Broadcast( 0x35, true, "The cotton candy swordfish tournament will start {0}", remaining );
					World.Broadcast( 0x35, true, "Goto any fishing tournament master for details on todays tournament." );
				}
				else if ( DateTime.UtcNow.DayOfWeek == TournyThree )
				{
					World.Broadcast( 0x35, true, "The malas moonfish tournament will start {0}", remaining );
					World.Broadcast( 0x35, true, "Goto any fishing tournament master for details on todays tournament." );
				}
				
				Stop();
			}
		}

		public class TournamentStartTimer : Timer
		{
			public TournamentStartTimer( DateTime end ) : base( end - DateTime.UtcNow )
			{
			}

			protected override void OnTick()
			{
				if ( DateTime.UtcNow.DayOfWeek == TournyOne )
				{
					World.Broadcast( 0x35, true, "The toxic trout weekly tournament has now started! Good luck!" );
				}
				else if ( DateTime.UtcNow.DayOfWeek == TournyTwo )
				{
					World.Broadcast( 0x35, true, "The cotton candy swordfish tournament has now started! Good luck!" );
				}
				else if ( DateTime.UtcNow.DayOfWeek == TournyThree )
				{
					World.Broadcast( 0x35, true, "The malas moonfish tournament has now started! Good luck!" );
				}
				
				isRunning = true;
				firstPlace = null;
				secondPlace = null;
				thirdPlace = null;
				Stop();
			}
		}
		
		public static bool isRunning = false;
		public static string firstPlace = null;
		public static string secondPlace = null;
		public static string thirdPlace = null;
		
		public static bool TournamentRunning()	// Simple check if the tournament is running.
		{
			if ( isRunning )
				return true;
			else
				return false;
		}
		
		public static Item GiveReward( Mobile winner, int place )
		{
			Bag bag = new Bag();
			Item trophy = new Item( 0x139C );
			bag.DropItem( new Harpoon( Utility.RandomMinMax( 2, 5 ) ) );
			
			if ( place == 1 )
			{
				bag.DropItem( new BankCheck( 50000 ) );
				trophy.Name = String.Format( "1st Place (Fishing) ({0:d})", DateTime.UtcNow.ToString() );
				trophy.LootType = LootType.Blessed;
				trophy.Hue = 2213;
				bag.DropItem( trophy );
				
				switch ( Utility.Random( 4 ) )
				{
					case 0: bag.DropItem( new FishingHat() ); break;
					case 1: bag.DropItem( new FishingPants() ); break;
					case 2: bag.DropItem( new FishingGloves() ); break;
					case 3: bag.DropItem( new FishingShirt() ); break;
				}
				
				if ( Utility.Random( 100 ) < 3 )
					bag.DropItem( new PowerScroll( SkillName.Fishing, 120 ) );
				
				if ( Utility.Random( 100 ) < 2 )
					bag.DropItem( new HarpoonGun() );
			}
			else if ( place == 2 )
			{
				bag.DropItem( new BankCheck( 35000 ) );
				trophy.Name = String.Format( "2nd Place (Fishing) ({0:d})", DateTime.UtcNow.ToString() );
				trophy.LootType = LootType.Blessed;
				trophy.Hue = 1150;
				bag.DropItem( trophy );
				bag.DropItem( new FishingSash() );
				
				if ( Utility.Random( 100 ) < 4 )
					bag.DropItem( new PowerScroll( SkillName.Fishing, 115 ) );
			}
			else
			{
				bag.DropItem( new BankCheck( 15000 ) );
				trophy.Name = String.Format( "3rd Place (Fishing) ({0:d})", DateTime.UtcNow.ToString() );
				trophy.LootType = LootType.Blessed;
				trophy.Hue = 2418;
				bag.DropItem( trophy );
				bag.DropItem( new FishingBoots() );
				
				if ( Utility.Random( 100 ) < 5 )
					bag.DropItem( new PowerScroll( SkillName.Fishing, 110 ) );
			}
			
			return bag;
		}
		
		public static void CheckTournament( Mobile from, Mobile fisher, Item dropped )
		{
			if ( !isRunning )
			{
				// Only giving a extra reward for 10+ fish
				
        		from.SendMessage( "A reward has been placed in your bank box." );
        		Bag bag = new Bag();
        		bag.DropItem( new BankCheck( 250 * dropped.Amount ) );
        		bag.DropItem( new Harpoon( Utility.RandomMinMax( 2, 5 ) ) );
        		
        		switch ( Utility.Random( 2 ) )
				{
					case 0: bag.DropItem( new SpecialFishingNet() ); break;
					case 1: bag.DropItem( new MessageInABottle() ); break;
				}
        		
        		if ( dropped.Amount > 19 )
        		{
        			fisher.Say( "Wow! You caught {0}. You should have placed in the tournament! Better luck next time!", dropped.Amount.ToString() );
        			bag.DropItem( new PowerScroll( SkillName.Fishing, 105 ) );
        		}
        		else if ( dropped.Amount > 18 )
        		{
        			fisher.Say( "Wow! You caught 19. You were so close! Better luck next time!" );
        			bag.DropItem( new FabledFishingNet() );
        		}
        		else if ( dropped.Amount > 17 )
        		{
        			fisher.Say( "Wow! You caught 18. You did amazing. Better luck next time!" );
        			
        			FloppyHat fh = new FloppyHat();
        			fh.Hue = Utility.RandomMinMax( 2498, 2640 );
        			fh.Name = "a designer fishing hat";
        			fh.LootType = LootType.Blessed;
        			bag.DropItem( fh );
        		}
        		else if ( dropped.Amount > 16 )
        		{
        			fisher.Say( "Wow! You caught 17. Almost... Maybe next time!" );
        			
        			Sandals s = new Sandals();
        			s.Hue = Utility.RandomMinMax( 1910, 2040 );
        			s.Name = "a designer fishing sandals";
        			s.LootType = LootType.Blessed;
        			bag.DropItem( s );
        		}
        		else if ( dropped.Amount > 15 )
        		{
        			fisher.Say( "You caught 16. Thats not bad but you could have done better! Maybe next time!" );
        			
        			FishingPole fp = new FishingPole();
        			fp.Hue = Utility.RandomMinMax( 1150, 1175 );
        			fp.Name = "a painted fishing pole";
        			bag.DropItem( fp );
        		}
        		else if ( dropped.Amount > 14 )
        		{
        			fisher.Say( "You caught 15. Bad luck! Maybe next time!" );
        			
        			Item junk = new Item( Utility.RandomList( 17784, 17785 ) );
        			junk.Name = "a sea horse statue";
        			bag.DropItem( junk );
        		}
        		else if ( dropped.Amount > 13 )
        		{
        			fisher.Say( "You caught 14. Maybe try different waters next time!" );
        			
        			Item junk = new Item( Utility.RandomList( 17786, 17787 ) );
        			junk.Name = "a mermaid statue";
        			bag.DropItem( junk );
        		}
        		else if ( dropped.Amount > 12 )
        		{
        			fisher.Say( "You caught 13. Did you bring ale? You have to bring ale!" );
        			
        			Spellbook sb = new Spellbook();
        			sb.Name = "Fishing For Dummies";
        			sb.Hue = 52;
        			bag.DropItem( sb );
        		}
        		else if ( dropped.Amount > 11 )
        		{
        			fisher.Say( "You caught 12. Try different bait next time!" );
        			
        			Item junk = new Item( Utility.RandomList( 0x1EA3, 0x1EA4, 0x1EA5, 0x1EA6 ) );
        			junk.Name = "a worn fishing net";
        			bag.DropItem( junk );
        		}
        		else if ( dropped.Amount > 10 )
        		{
        			fisher.Say( "You caught 11..." );
        			
        			Item junk = new Item( 0x154D );
        			junk.Name = "a barrel of fish (Not for shooting)";
        			bag.DropItem( junk );
        		}
        		else if ( dropped.Amount > 9 )
        		{
        			fisher.Say( "You only caught 10. Half way... is still to far!" );
        		}
        		else if ( dropped.Amount > 8 )
        		{
        			fisher.Say( "You only caught 9. Half way... is still to far!" );
        		}
        		else if ( dropped.Amount > 7 )
        		{
        			fisher.Say( "You only caught 8... How long did you say you have been fishing?" );
        		}
        		else if ( dropped.Amount > 6 )
        		{
        			fisher.Say( "You only caught 7... Find a lot of shoes do you?" );
        		}
        		else if ( dropped.Amount > 5 )
        		{
        			fisher.Say( "You only caught 6... Ever consider taking up something more productivy like bird watching?" );
        		}
        		else if ( dropped.Amount > 4 )
        		{
        			fisher.Say( "You only caught 5... Ever consider taking up something more exciting like... baskit weaving?" );
        		}
        		else if ( dropped.Amount > 3 )
        		{
        			fisher.Say( "You caught 4!?! Was your cat on fire?" );
        		}
        		else if ( dropped.Amount > 2 )
        		{
        			fisher.Say( "You caught 3!?! Were you sleeping all this time?" );
        		}
        		else if ( dropped.Amount > 1 )
        		{
        			fisher.Say( "Two fish? Maybe you should keep them in a tank and hope they multiply!" );
        		}
        		else if ( dropped.Amount > 0 )
        		{
        			fisher.Say( "One... One fish? Did someone hand this to you? Did you find this flopping around town? Tell me you didn't fish and catch this one lonely fish?" );
        		}
        		
        		BankBox box = from.BankBox;
        		box.DropItem( bag );
        		dropped.Delete();
			}
			else if ( isRunning )
			{
				if ( DateTime.UtcNow.DayOfWeek == TournyOne )
				{
					BankBox box = from.BankBox;
					
					if ( from.Backpack.ConsumeTotal( typeof( ToxicTrout ), 20 ) &&  firstPlace == null )
					{
					    firstPlace = from.Name;
					    World.Broadcast( 0x35, true, "{0} has came in first in todays fishing tournament!", firstPlace );
					    fisher.Say( "Congrats! You are the first person to catch twenty toxic trout! Well done!" );
					    from.SendMessage( "Your reward has been placed into your bank box!" );
					    box.DropItem( GiveReward( from, 1 ) );
					}
					else if ( from.Backpack.ConsumeTotal( typeof( ToxicTrout ), 20 ) &&  secondPlace == null )
					{
					    secondPlace = from.Name;
					    World.Broadcast( 0x35, true, "{0} has placed 2nd in todays fishing tournament!", firstPlace );
					    fisher.Say( "Congrats! You are the second person to catch twenty toxic trout! Well done!" );
					    from.SendMessage( "Your reward has been placed into your bank box!" );
					   	box.DropItem( GiveReward( from, 2 ) );
					}
					else if ( from.Backpack.ConsumeTotal( typeof( ToxicTrout ), 20 ) &&  thirdPlace == null )
					{
					    isRunning = false;
					    thirdPlace = from.Name;
					    World.Broadcast( 0x35, true, "{0} has placed 3rd in todays fishing tournament!", firstPlace );
					    World.Broadcast( 0x35, true, "The tournament is now over! Congratulations to todays winners!", firstPlace );
					    World.Broadcast( 0x35, true, "If you didnt win today bring what fish you gathered and drop them on a tournament master to claim a consolation prize!", firstPlace );
					    fisher.Say( "Congrats! You are the third person to catch twenty toxic trout! Well done!" );
					    from.SendMessage( "Your reward has been placed into your bank box!" );
					    box.DropItem( GiveReward( from, 3 ) );
					}
					else
					{
						fisher.Say( "You need to catch and bring me twenty toxic trout before anyone else to win this tournament!" );
						fisher.Say( "Why are you standing around here! Go fish!!!" );
					}
				}
				else if ( DateTime.UtcNow.DayOfWeek == TournyTwo )
				{
					BankBox box = from.BankBox;
					
					if ( from.Backpack.ConsumeTotal( typeof( CottonCandySwordfish ), 20 ) &&  firstPlace == null )
					{
					    firstPlace = from.Name;
					    World.Broadcast( 0x35, true, "{0} has came in first in todays fishing tournament!", firstPlace );
					    fisher.Say( "Congrats! You are the first person to catch twenty cotton candy swordfish! Well done!" );
					    from.SendMessage( "Your reward has been placed into your bank box!" );
					    box.DropItem( GiveReward( from, 1 ) );
					}
					else if ( from.Backpack.ConsumeTotal( typeof( CottonCandySwordfish ), 20 ) &&  secondPlace == null )
					{
					    secondPlace = from.Name;
					    World.Broadcast( 0x35, true, "{0} has placed 2nd in todays fishing tournament!", firstPlace );
					    fisher.Say( "Congrats! You are the second person to catch twenty cotton candy swordfish! Well done!" );
					    from.SendMessage( "Your reward has been placed into your bank box!" );
					    box.DropItem( GiveReward( from, 2 ) );
					}
					else if ( from.Backpack.ConsumeTotal( typeof( CottonCandySwordfish ), 20 ) &&  thirdPlace == null )
					{
					    isRunning = false;
					    thirdPlace = from.Name;
					    World.Broadcast( 0x35, true, "{0} has placed 3rd in todays fishing tournament!", firstPlace );
					    World.Broadcast( 0x35, true, "The tournament is now over! Congratulations to todays winners!", firstPlace );
					    World.Broadcast( 0x35, true, "If you didnt win today bring what fish you gathered and drop them on a tournament master to claim a consolation prize!", firstPlace );
					    fisher.Say( "Congrats! You are the third person to catch twenty cotton candy swordfish! Well done!" );
					    from.SendMessage( "Your reward has been placed into your bank box!" );
					    box.DropItem( GiveReward( from, 3 ) );
					}
					else
					{
						fisher.Say( "You need to catch and bring me twenty cotton candy swordfish before anyone else to win this tournament!" );
						fisher.Say( "Why are you standing around here! Go fish!!!" );
					}
				}
				else if ( DateTime.UtcNow.DayOfWeek == TournyThree )
				{
					BankBox box = from.BankBox;
					
					if ( from.Backpack.ConsumeTotal( typeof( MalasMoonfish ), 20 ) &&  firstPlace == null )
					{
					    firstPlace = from.Name;
					    World.Broadcast( 0x35, true, "{0} has came in first in todays fishing tournament!", firstPlace );
					    fisher.Say( "Congrats! You are the first person to catch twenty malas moonfish! Well done!" );
					    from.SendMessage( "Your reward has been placed into your bank box!" );
					    box.DropItem( GiveReward( from, 1 ) );
					}
					else if ( from.Backpack.ConsumeTotal( typeof( MalasMoonfish ), 20 ) &&  secondPlace == null )
					{
					    secondPlace = from.Name;
					    World.Broadcast( 0x35, true, "{0} has placed 2nd in todays fishing tournament!", firstPlace );
					    fisher.Say( "Congrats! You are the second person to catch twenty malas moonfish! Well done!" );
					    from.SendMessage( "Your reward has been placed into your bank box!" );
					    box.DropItem( GiveReward( from, 2 ) );
					}
					else if ( from.Backpack.ConsumeTotal( typeof( MalasMoonfish ), 20 ) &&  thirdPlace == null )
					{
					    isRunning = false;
					    thirdPlace = from.Name;
					    World.Broadcast( 0x35, true, "{0} has placed 3rd in todays fishing tournament!", firstPlace );
					    World.Broadcast( 0x35, true, "The tournament is now over! Congratulations to todays winners!", firstPlace );
					    World.Broadcast( 0x35, true, "If you didnt win today bring what fish you gathered and drop them on a tournament master to claim a consolation prize!", firstPlace );
					    fisher.Say( "Congrats! You are the third person to catch twenty malas moonfish! Well done!" );
					    from.SendMessage( "Your reward has been placed into your bank box!" );
					    box.DropItem( GiveReward( from, 3 ) );
					}
					else
					{
						fisher.Say( "You need to catch and bring me twenty malas moonfish before anyone else to win this tournament!" );
						fisher.Say( "Why are you standing around here! Go fish!!!" );
					}
				}
				else // Why? Because thats the kinda world we live in...
				{
					fisher.Say( "I am sorry, I musta got my days mixxed up!" );
					isRunning = false;
				}
			}
			else
			{
				if ( firstPlace != null && secondPlace != null && thirdPlace != null )
					fisher.Say( "Todays tournament has ended! Todays winners are {0}, {1), and {2}!", firstPlace, secondPlace, thirdPlace );
				else
					fisher.Say( "Todays tournament has ended!" );
			}
		}
	}
}