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
	public class DrunkenPirate : BaseCreature
	{
		private static bool m_Talked;
		string[] DrunkenPirateSay = new string[]
		{
			"*hic*",
			"Shiver me timbers, *hic*",
			"*burp*",
			"*burp*, Yo ho ho and a bottle of rum!",
		};

		public override bool ShowFameTitle{ get{ return false; } }

		[Constructable]
		public DrunkenPirate() : base( AIType.AI_Melee, FightMode.Closest, 10, 1, 0.2, 0.4 )
		{
			SpeechHue = Utility.RandomDyedHue();
			Title = "the drunken pirate";
			Hue = Utility.RandomSkinHue();

			Body = 0x190;
            Name = NameList.RandomName("male");

			SetStr( 220, 430 );
			SetDex( 100, 115 );
			SetInt( 20, 45 );
			SetHits( 3500, 6050 );

			SetDamage( 10, 32 );

			Cutlass cutlass = new Cutlass();
			cutlass.Movable = false;
			cutlass.Skill = SkillName.Wrestling;
			AddItem( cutlass );

			AddItem( new FancyShirt( Utility.RandomNeutralHue()) );
			AddItem( new LongPants( Utility.RandomNeutralHue()) );
			AddItem( new Boots( Utility.RandomNeutralHue()) );
			AddItem( new BodySash( Utility.RandomRedHue()) );
			AddItem( new SkullCap( Utility.RandomRedHue()) );

            Utility.AssignRandomHair(this);

			SetSkill( SkillName.MagicResist, 65.0, 67.5 );
			SetSkill( SkillName.Swords, 85.0, 117.5 );
			SetSkill( SkillName.Tactics, 75.0, 147.5 );
			SetSkill( SkillName.Wrestling, 100.0, 139.3 );

			Fame = 8000;
			Karma = -10000;
		}

		public override bool CanRummageCorpses{ get{ return true; } }
		public override bool Uncalmable{ get{ return true; } }
		public override Poison PoisonImmune{ get{ return Poison.Lethal; } }
		public override int TreasureMapLevel{ get{ return 3; } }
		public override bool AlwaysMurderer{ get{ return true; } }

		public override void GenerateLoot()
		{
			AddLoot( LootPack.Rich );
		}


        public override void OnMovement( Mobile m, Point3D oldLocation )
		{
			if( m_Talked == false )
			{
				if ( m.InRange( this, 3 ) && m is PlayerMobile)
				{
					m_Talked = true;
					SayRandom( DrunkenPirateSay, this );
					this.Move( GetDirectionTo( m.Location ) );
					SpamTimer t = new SpamTimer();
					t.Start();
				}
			}
		}

  		private class SpamTimer : Timer
		{
	   		public SpamTimer() : base( TimeSpan.FromSeconds( 6 ) )
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

		public override bool OnBeforeDeath()
		{
            //PirateCurse.CursedPirateLoot(this, 15);
			PackItem(new Gold(10));

			return base.OnBeforeDeath();
		}

		public DrunkenPirate( Serial serial ) : base( serial )
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
