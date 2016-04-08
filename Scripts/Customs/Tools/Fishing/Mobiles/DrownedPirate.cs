using System;
using System.Collections;
using Server;
using Server.Items;
using Server.ContextMenus;
using Server.Misc;
using Server.Network;

namespace Server.Mobiles
{
	[CorpseName( "a corpse of a drowned pirate" )]
	public class DrownedPirate : BaseCreature
	{
		private static bool m_Talked;
		string[] DrownedPirateSay = new string[]
		{
			"Come, join me in Davey Jones' Locker",
			"Jump in me hearty, the waters fine!",
			"uhhhhhhhh",
		};

		public override bool ShowFameTitle{ get{ return false; } }

		[Constructable]
		public DrownedPirate() : base( AIType.AI_Melee, FightMode.Closest, 10, 1, 0.15, 0.4 )
		{
			SpeechHue = Utility.RandomDyedHue();
			Title = "the drowned pirate";
			Hue = Utility.RandomSkinHue();

			Body = 0x190;
            Name = NameList.RandomName("male");
            Hue = 0x2B8;

			SetStr( 120, 170 );
			SetDex( 800, 115 );
			SetInt( 20, 35 );
			SetHits( 520, 1050 );

			SetDamage( 20, 32 );

            SetDamageType(ResistanceType.Physical, 40);
            SetDamageType(ResistanceType.Cold, 60);

			Cutlass cutlass = new Cutlass();
			cutlass.Movable = false;
			cutlass.Skill = SkillName.Wrestling;
			AddItem( cutlass );

			AddItem( new Shirt( Utility.RandomNeutralHue()) );
			AddItem( new ShortPants( Utility.RandomNeutralHue()) );
			AddItem( new SkullCap( Utility.RandomRedHue()) );

            Utility.AssignRandomHair(this);

            SetSkill(SkillName.Fencing, 90.5, 115.0);
            SetSkill(SkillName.Healing, 60.3, 90.0);
            SetSkill(SkillName.Macing, 90.5, 115.0);
            SetSkill(SkillName.Poisoning, 60.0, 82.5);
            SetSkill(SkillName.MagicResist, 72.5, 95.0);
            SetSkill(SkillName.Swords, 90.5, 115.0);
            SetSkill(SkillName.Tactics, 90.5, 115.0);

			Fame = 3000;
			Karma = -3000;

            PackItem(new Bandage(Utility.RandomMinMax(1, 15)));
		}

		public override bool CanRummageCorpses{ get{ return true; } }
		public override bool Uncalmable{ get{ return true; } }
		public override Poison PoisonImmune{ get{ return Poison.Lethal; } }
		public override int TreasureMapLevel{ get{ return 3; } }
		public override bool AlwaysMurderer{ get{ return true; } }

		public override void GenerateLoot()
		{
			AddLoot( LootPack.Average );
		}


        public override void OnMovement( Mobile m, Point3D oldLocation )
		{
			if( m_Talked == false )
			{
				if ( m.InRange( this, 3 ) && m is PlayerMobile)
				{
					m_Talked = true;
					SayRandom( DrownedPirateSay, this );
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
			PackItem(new Gold(300));

			return base.OnBeforeDeath();
		}

		public DrownedPirate( Serial serial ) : base( serial )
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
