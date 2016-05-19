using System; 
using Server;
using System.Collections; 
using Server.Misc; 
using Server.Items; 
using Server.Mobiles; 
using Server.Targeting;

namespace Server.Mobiles 
{ 
	public class SpawnHelper : BaseBlue
	{ 
		private bool m_Bandaging;
		public static TimeSpan TalkDelay = TimeSpan.FromSeconds( 15.0 );
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
                           		switch (Utility.Random(19))
                           		{
                           	 		case 0: Emote("Hello " + m.Name + " have you come to play?"); break;
                                		case 1: Emote("" + m.Name + "?"); break;
                        	     	 	case 2: Emote("" + m.Name + " where do you think your going?"); break;
                         	    		case 3: Emote("Hey " + m.Name + " want to play tag?"); break;
                         	    		case 4: Emote(" Hey " + m.Name + " , did you hear about Moonglow?"); break;
                         	   		case 5: Emote("" + m.Name + " How are ya?"); break;
                         	    		case 6: Emote("To adventure, " + m.Name + "."); break;
                         	    		case 7: Emote("" + m.Name + "!!"); break;
                         	  		case 8: Emote("Hi " + m.Name + "!"); break;
                         	  		case 9: Emote("Oh Hi " + m.Name + "!"); break;
                         	  		case 10: Emote("Nice Weapon there " + m.Name + ""); break;
                         	  		case 11: Emote("Can't wait for the next Patch"); break;
                         	  		case 12: Emote("You looking at me, " + m.Name + "?"); break;
                         	  		case 13: Emote("Nice name " + m.Name + ""); break;
                         	  		case 14: Emote("I killed 5 succubus at once yesterday " + m.Name + ""); break;
                         	  		case 15: Emote("Hey, I didn't know you still played " + m.Name + ""); break;
                         	  		case 16: Emote("I got this."); break;
                         	  		case 17: Emote("I hate arties, t2a was the best, don't you think so " + m.Name + "?"); break;
                         	  		case 18: Emote("Darn, another one "); break;
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
		public SpawnHelper() : base( AIType.AI_Melee, FightMode.Closest, 25, 1, 0.4, 0.3 ) 
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

            SetDamage(18, 22);

            SetDamageType(ResistanceType.Physical, 120);

            SetResistance(ResistanceType.Physical, 65, 80);
            SetResistance(ResistanceType.Fire, 65, 80);
            SetResistance(ResistanceType.Cold, 65, 80);
            SetResistance(ResistanceType.Poison, 65, 80);
            SetResistance(ResistanceType.Energy, 65, 80);

            SetSkill(SkillName.Swords, 89.0, 120.0);
            SetSkill(SkillName.Tactics, 89.0, 120.0);
            SetSkill(SkillName.MagicResist, 89.0, 120.0);
            SetSkill(SkillName.Tactics, 89.0, 120.0);
            SetSkill(SkillName.Parry, 89.0, 120.0);
            SetSkill(SkillName.Anatomy, 85.0, 120.0);
            SetSkill(SkillName.Healing, 85.0, 120.0);
            SetSkill(SkillName.Magery, 85.0, 120.0);
            SetSkill(SkillName.EvalInt, 85.0, 120.0);

            Fame = 18000;
            Karma = 10000;

            VirtualArmor = 50;

                           	 switch (Utility.Random(4))
                           	 {
                           	 	case 0: BattleAxe weapona = new BattleAxe();
						weapona.Hue = 1168;
                      				weapona.LootType = LootType.Newbied;
						weapona.Attributes.SpellChanneling = 1;
						weapona.WeaponAttributes.HitEnergyArea = 80;
                      				weapona.Movable = false;
						AddItem( weapona );
						break;
                           	 	case 1: Axe weaponb = new Axe();
						weaponb.Hue = 1260;
                      				weaponb.LootType = LootType.Newbied;
						weaponb.Attributes.SpellChanneling = 1;
						weaponb.WeaponAttributes.HitFireArea = 80;
                      				weaponb.Movable = false;
						AddItem( weaponb );
						break;
                           	 	case 2: Bardiche weaponc = new Bardiche();
						weaponc.Hue = 1266;
                      				weaponc.LootType = LootType.Newbied;
						weaponc.Attributes.SpellChanneling = 1;
						weaponc.WeaponAttributes.HitColdArea = 80;
                      				weaponc.Movable = false;
						AddItem( weaponc );
						break;
                           	 	case 3: Hatchet weapond = new Hatchet();
						weapond.Hue = 1272;
                      				weapond.LootType = LootType.Newbied;
						weapond.Attributes.SpellChanneling = 1;
						weapond.WeaponAttributes.HitPoisonArea = 80;
                      				weapond.Movable = false;
						AddItem( weapond );
						break;
                            	} 



                           	 Item Robe =  new Robe( );			
                        	Robe.Name = "Britania Electric Co.";
                        	Robe.Movable = false; 
				Robe.Hue = 1109;
				AddItem( Robe );



                           	 switch (Utility.Random(3))
                           	 {
                           	 	case 0: AddItem( new LongPants(1050)); break;
                           	 	case 1: Item LegsOfBane = new LeggingsOfBane();
						LegsOfBane.Hue = 1269;
                      				LegsOfBane.LootType = LootType.Newbied;
                      				LegsOfBane.Movable = false;
						AddItem( LegsOfBane );
						break;
                           	 	case 2: break;
                            	} 

                           	 switch (Utility.Random(3))
                           	 {
                           	 	case 0:	AddItem( new Boots() ); break;
                           	 	case 1: Item Sandals = new Sandals();
						Sandals.Hue = 1195;
                        			Sandals.LootType = LootType.Blessed;
                        			Sandals.Movable = false;
						AddItem( Sandals );
						break;
                           	 	case 2: break;
                            	} 


						Item PlateHelm = new PlateHelm();
						PlateHelm.Hue = 1195;
                      				PlateHelm.LootType = LootType.Newbied;
                      				PlateHelm.Movable = false;
						AddItem( PlateHelm );


                           	 switch (Utility.Random(3))
                           	 {
                           	 	case 0:	AddItem( new LeatherGloves() ); break;
                           	 	case 1: break;
                           	 	case 2: break;
                            	} 


			AddItem( new Shirt(743) );

			

			
			Utility.AssignRandomHair( this );

			for (int i = 0; i < 10; i++)
			{
				PackItem( new GreaterCurePotion() );
				PackItem( new GreaterHealPotion() );
				PackItem( new TotalRefreshPotion() );
			}

          		  PackItem(new Bandage(Utility.RandomMinMax(100, 200)));

			Horse ns = new Horse();
//			ns.Controlled = true;
			ns.Hue = 1109;
//			ns.ControlMaster = this;
//			ns.ControlOrder = OrderType.Stay;
			ns.Rider = this; 
}

		public override void GenerateLoot()
			{
				AddLoot( LootPack.Average );
			}



		public override bool CanRummageCorpses{ get{ return true; } }
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
			private SpawnHelper pk;

			public BandageTimer( SpawnHelper o ) : base( TimeSpan.FromSeconds( 4 ) ) 
			{ 
				pk = o;
				Priority = TimerPriority.OneSecond; 
			} 
		
 			protected override void OnTick() 
			{ 
				pk.m_Bandaging = false; 
			} 
		}


		public SpawnHelper( Serial serial ) : base( serial ) 
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