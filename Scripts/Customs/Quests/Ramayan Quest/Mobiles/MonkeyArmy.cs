/*
 * This script is based on the work originally released by deides on RunUO 3SEP11. 
 * runuo.com/community/threads/need-new-players-add-them-with-my-custom-blues-2-1-svn.488880/
 * I did some edits to his spawnhelper.cs to make my 'monkey' army.
 * You will need the baseblue.cs file for this guy to work (I put it in the quest package - hope it is still here). If you are already using that
 * script package simply delete one of the BaseBlue.cs scripts, it does not matter which one. I did no edits on that script.
 * I take that back - on line 40 (BaseBlue.cs) I had to remark out a reference to "townsperson". Don't know what it is for but it gave an error.
 * Tukaram 16MAY2016
 * */


using System; 
using Server;
using System.Collections; 
using Server.Misc; 
using Server.Items; 
using Server.Mobiles; 
using Server.Targeting;

namespace Server.Mobiles 
{ 
	public class MonkeyArmy : BaseBlue
	{ 
		private bool m_Bandaging;
		public static TimeSpan TalkDelay = TimeSpan.FromSeconds( 90.0 );
		public DateTime m_NextTalk;

		public override void OnMovement( Mobile m, Point3D oldLocation )
		{
			if ( InRange( m, 4 ) && !InRange( oldLocation, 4 ) && InLOS( m ) )
			{
				if ( !m.Frozen && DateTime.Now >= m_NextResurrect && !m.Alive )
				{
					m_NextResurrect = DateTime.Now + ResurrectDelay;

					if ( m.Map == null || !m.Map.CanFit( m.Location, 16, false, false ) )
					{
						m.SendLocalizedMessage( 502391 ); // Thou can not be resurrected there!
					}
					else if ( CheckResurrect( m ) )
					{
						OfferResurrection( m );
					}
				}
				else if ( DateTime.Now >= m_NextResurrect && this.HealsYoungPlayers && m.Hits < (m.HitsMax/2) && m is PlayerMobile || DateTime.Now >= m_NextResurrect && m.Hits < (m.HitsMax/2) && m is BaseBlue )
				{
					OfferHeal( (PlayerMobile) m );
				}
				else if ( DateTime.Now >= m_NextTalk ) // check if its time to talk
				{
					m_NextTalk = DateTime.Now + TalkDelay; // set next talk time
                           		switch (Utility.Random(15))
                           		{
                           	 		case 0: Emote("Hello " + m.Name + " General Hanuman said you were coming."); break;
                                	case 1: Emote("" + m.Name + "Let's rescue Sita"); break;
                        	     	case 2: Emote("" + m.Name + " All these demons must die!"); break;
                         	    	case 3: Emote("Hey " + m.Name + " Jai Hanuman!"); break;
                         	    	case 4: Emote(" Hey " + m.Name + " , where did you learn to fight so good?"); break;
                         	   		case 5: Emote("" + m.Name + " How are ya?"); break;
                         	    	case 6: Emote("To adventure, " + m.Name + "."); break;
                         	    	case 7: Emote("" + m.Name + "!!"); break;
                         	  		case 8: Emote("Oh Hi " + m.Name + "!"); break;
                         	  		case 9: Emote("Nice Weapon there " + m.Name + ""); break;
                         	  		case 10: Emote("You looking at me, " + m.Name + "?"); break;
                         	  		case 11: Emote("Nice name " + m.Name + ""); break;
                         	  		case 12: Emote("I killed 5 succubus at once yesterday " + m.Name + ""); break;
                         	  		case 13: Emote("I got this."); break;
                         	  		case 14: Emote("Darn, another one "); break;
                         	 	}
				
				}
			}

		}

		public override bool CheckResurrect( Mobile m )
		{
			if ( m.Criminal )
			{
				Say("You did something wrong, wait a bit"); // Thou art a criminal.  I shall not resurrect thee.
				return false;
			}
			else if ( m.Kills >= 5 )
			{
				Say("I don't help reds"); // Thou'rt not a decent and good person. I shall not resurrect thee.
				return false;
			}
			else if ( m.Karma < 0 )
			{
				Say("You have bad Karma, but OK."); // Thou hast strayed from the path of virtue, but thou still deservest a second chance.
			}
			return true;
		}

		[Constructable] 
		public MonkeyArmy() : base( AIType.AI_Melee, FightMode.Closest, 25, 1, 0.4, 0.3 ) 
		{ 
	



            		Title = "[BEC]";
			if ( Female = Utility.RandomBool() ) 
			{ 
				Body = 401; 
				Name = NameList.RandomName( "female" );
			
				
			}
			else 
			{ 
				Body = 400; 			
				Name = NameList.RandomName( "male" ); 


			}
//			Name.Hue = 2002;
//			Title.Hue = 2002;

 
       	    SetStr(200, 250);
            SetDex(150, 200);
            SetInt(125, 200);
		    ActiveSpeed = 0.2;
		    PassiveSpeed = 0;

            SetHits(200, 300);

            SetDamage(25, 42);

            SetDamageType(ResistanceType.Physical, 120);

            SetResistance(ResistanceType.Physical, 65, 80);
            SetResistance(ResistanceType.Fire, 65, 80);
            SetResistance(ResistanceType.Cold, 65, 80);
            SetResistance(ResistanceType.Poison, 65, 80);
            SetResistance(ResistanceType.Energy, 65, 80);

            SetSkill(SkillName.Swords, 100, 120.0);
            SetSkill(SkillName.Tactics, 100, 120.0);
            SetSkill(SkillName.MagicResist, 100, 120.0);
            SetSkill(SkillName.Tactics, 100, 120.0);
            SetSkill(SkillName.Parry, 100, 120.0);
            SetSkill(SkillName.Anatomy, 100, 120.0);
            SetSkill(SkillName.Healing, 100, 120.0);
            SetSkill(SkillName.Magery, 100, 120.0);
            SetSkill(SkillName.EvalInt, 100, 120.0);

            Fame = 18000;
            Karma = 10000;

            VirtualArmor = 50;


            AddItem(new TribalMask());
            AddItem(new HideChest());
            AddItem(new HidePauldrons());
            AddItem(new HideGloves());
            AddItem(new HidePants());
            AddItem(new ShortSpear());
            AddItem(new FurBoots());
           




            Utility.AssignRandomHair( this );

			for (int i = 0; i < 10; i++)
			{
				PackItem( new GreaterCurePotion() );
				PackItem( new GreaterHealPotion() );
				PackItem( new TotalRefreshPotion() );
			}

          		  PackItem(new Bandage(Utility.RandomMinMax(100, 200)));

		  /* This section was used in original sript
             Horse ns = new Horse();
             ns.Hue = 1109;
             ns.Rider = this;
             */

           /* This section was remarked out in original script
              ns.Controlled = true;
               ns.ControlMaster = this;
               ns.ControlOrder = OrderType.Stay;
             */
        }

        public override void GenerateLoot()
			{
				AddLoot( LootPack.Average );
			}



		public override bool CanRummageCorpses{ get{ return false; } }
       	public override bool CanHeal { get { return true; } }

		public override void OnThink()
		{
			base.OnThink();
			
			// Use bandages
			if ( (this.IsHurt() || this.Poisoned) && m_Bandaging == false )
			{
				Bandage m_Band = (Bandage)this.Backpack.FindItemByType( typeof ( Bandage ) );
				
				if ( m_Band != null )
				{
					m_Bandaging = true;
					
					if ( BandageContext.BeginHeal( this, this ) != null )
						m_Band.Consume();
					BandageTimer bt = new BandageTimer( this );
					bt.Start();
				}
			}
		}

		private class BandageTimer : Timer 
		{ 
			private MonkeyArmy pk;

			public BandageTimer( MonkeyArmy o ) : base( TimeSpan.FromSeconds( 4 ) ) 
			{ 
				pk = o;
				Priority = TimerPriority.OneSecond; 
			} 
		
 			protected override void OnTick() 
			{ 
				pk.m_Bandaging = false; 
			} 
		}


		public MonkeyArmy( Serial serial ) : base( serial ) 
		{ 
		} 



		public override void Serialize( GenericWriter writer ) 
		{ 
			base.Serialize( writer ); 

			writer.Write( (int) 0 ); // version 
		} 

		public override void Deserialize( GenericReader reader ) 
		{ 
			base.Deserialize( reader ); 

			int version = reader.ReadInt(); 
		} 
	} 
}   