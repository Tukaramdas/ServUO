using System;
using System.Collections;
using Server;
using Server.Items;
using Server.ContextMenus;
using Server.Misc;
using Server.Network;

namespace Server.Mobiles
{
	[CorpseName( "a corpse of a pirate" )]
	public class Buccaneer : BaseCreature
	{
		private static bool m_Talked;
		string[] BuccaneerSay = new string[]
		{
			"Avast ye!",
			"Stand guard ye lubber",
			"I'll be sendin ye to Davey Jones' Locker"
		};

		public override bool ShowFameTitle{ get{ return false; } }

		[Constructable]
		public Buccaneer() : base( AIType.AI_Melee, FightMode.Closest, 10, 1, 0.2, 0.4 )
		{
			SpeechHue = Utility.RandomDyedHue();
			Title = "the Buccaneer";
			Hue = Utility.RandomSkinHue();

			Body = 0x190;
			Name = NameList.RandomName( "male" );

			Scimitar scimitar = new Scimitar();
			scimitar.Movable = false;
			scimitar.Skill = SkillName.Wrestling;
			AddItem( scimitar );

			AddItem( new FancyShirt() );
			AddItem( new LongPants( Utility.RandomGreenHue()) );
			AddItem( new Boots( Utility.RandomNeutralHue()) );
			AddItem( new Buckler() );
			AddItem( new FeatheredHat( Utility.RandomGreenHue()) );

			SetStr( 750, 950 );
			SetDex( 130, 155 );
			SetInt( 90, 125 );
			SetHits( 2000, 2950 );

			SetDamage( 12, 28 );

			SetDamageType( ResistanceType.Physical, 75 );
			SetDamageType( ResistanceType.Poison, 25 );

			SetResistance( ResistanceType.Physical, 60, 75 );
			SetResistance( ResistanceType.Fire, 50, 65 );
			SetResistance( ResistanceType.Cold, 50, 65 );
			SetResistance( ResistanceType.Poison, 100 );
			SetResistance( ResistanceType.Energy, 40, 50 );

			SetSkill( SkillName.Anatomy, 90.0, 100.3 );
			SetSkill( SkillName.MagicResist, 65.0, 77.5 );
			SetSkill( SkillName.Swords, 95.0, 100.5 );
			SetSkill( SkillName.Tactics, 75.0, 99.5 );

			Fame = 7000;
			Karma = -7000;

			PackArmor( 2, 5 );
			PackWeapon( 3, 5 );
			PackWeapon( 5, 5 );
			PackSlayer();
		}

			public override int TreasureMapLevel{ get{ return 4; } }
			public override bool CanRummageCorpses{ get{ return true; } }
			public override Poison PoisonImmune{ get{ return Poison.Deadly; } }

			public override void GenerateLoot()
			{
				AddLoot( LootPack.Average );
			}

			public override bool OnBeforeDeath()
			{
				switch ( Utility.Random( 20 ) )
				{
					//case 0: PackItem( new RewardTicket() ); break;
					//case 1: PackItem( LevelableItems.CreateRandomLevelable() ); break;
                    case 2: PackItem(new Gold(2500)); break;
				}

				return base.OnBeforeDeath();

			}

			public override bool AlwaysMurderer{ get{ return true; } }

        		public override void OnMovement( Mobile m, Point3D oldLocation )
                	{
       		  		if( m_Talked == false )
        	  		{
      		      			if ( m.InRange( this, 3 ) && m is PlayerMobile)
        				{
            		   			m_Talked = true;
            		   			SayRandom( BuccaneerSay, this );
           		   			this.Move( GetDirectionTo( m.Location ) );
             		   			SpamTimer t = new SpamTimer();
           		   			t.Start();
            				}
        	  		}
			}

    	  		private class SpamTimer : Timer
			{
		   		public SpamTimer() : base( TimeSpan.FromSeconds( 12 ) )
	       	   		{
          				Priority = TimerPriority.OneSecond;
       		   		}

         	   		protected override void OnTick()
        	   		{
           				m_Talked = false;
        	   		}
      			}

			private static void SayRandom( string[] say, Mobile m )
	        	{
	           		m.Say( say[Utility.Random( say.Length )] );
			}

			public Buccaneer( Serial serial ) : base( serial )
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
