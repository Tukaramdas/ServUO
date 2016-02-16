// Created By Lucid Nagual - Admin of The Conjuring
// I'd like to thank all the wonderful people for sharing they're scripts & support.
// I hope by submitting this I can at least partially pay back the Runuo Community.

using System;
using Server.Mobiles;
using Server.Items;
using Server.Misc;
using Server.Multis;
using Server.Network;
using Server.Targeting;
using System.Collections;


namespace Server.Mobiles
{
	[CorpseName( "a wild horse corpse" )]
	[TypeAlias( "Server.Mobiles.BrownHorse", "Server.Mobiles.DirtyHorse", "Server.Mobiles.GrayHorse", "Server.Mobiles.TanHorse" )]
	public class WildHorse : BaseMount
	{
		private static int[] m_IDs = new int[]
			{
				0xC8, 0x3E9F,
				0xE2, 0x3EA0,
				0xE4, 0x3EA1,
				0xCC, 0x3EA2
			};

		[Constructable]
		public WildHorse() : this( "a wild horse" )
		{
		}

		[Constructable]
		public WildHorse( string name ) : base( name, 0xE2, 0x3EA0, AIType.AI_Animal, FightMode.Aggressor, 10, 1, 0.2, 0.4 )
		{
			int random = Utility.Random( 4 );

			Body = m_IDs[random * 2];
			ItemID = m_IDs[random * 2 + 1];
			BaseSoundID = 0xA8;

			SetStr( 22, 98 );
			SetDex( 56, 75 );
			SetInt( 6, 10 );

			SetHits( 28, 45 );
			SetMana( 0 );

			SetDamage( 3, 4 );

			SetDamageType( ResistanceType.Physical, 100 );

			SetResistance( ResistanceType.Physical, 15, 20 );

			SetSkill( SkillName.MagicResist, 25.1, 30.0 );
			SetSkill( SkillName.Tactics, 29.3, 44.0 );
			SetSkill( SkillName.Wrestling, 29.3, 44.0 );

			Fame = 300;
			Karma = 300;

			Tamable = true;
			ControlSlots = 1;
			MinTameSkill = 29.1;
	
		Timer PondTimer = new InternalTimer(this);
		PondTimer.Start();
		}

		public override int Meat{ get{ return 3; } }
		public override int Hides{ get{ return 10; } }
		public override FoodType FavoriteFood{ get{ return FoodType.FruitsAndVegies | FoodType.GrainsAndHay; } }

		public WildHorse( Serial serial ) : base( serial )
		{
		}

		public class InternalTimer: Timer
		{
			private WildHorse Mare;
			//Line Below This: (TimeSpan.FromSeconds (this is where u adjust how long it takes the horse to poop)
			public InternalTimer(Mobile p): base( TimeSpan.FromSeconds( 3600.0), TimeSpan.FromSeconds( 5400.0))
		{
			Priority = TimerPriority.FiftyMS;
			Mare = ((WildHorse) p);
		}

		protected override void OnTick()
		{
			object shit = new Shitpile();
			Shitpile spawn = (Shitpile) Activator.CreateInstance(shit.GetType() );
			spawn.Map = Mare.Map;
			spawn.Location = Mare.Location;
			Effects.PlaySound( spawn.Location, spawn.Map, 1064);
		}
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





