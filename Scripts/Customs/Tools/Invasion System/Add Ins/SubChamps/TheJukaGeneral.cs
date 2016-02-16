using System;
using Server;
using Server.Items;
using Server.Engines.CannedEvil;

namespace Server.Mobiles
{
	public class TheJukaGeneral : BaseSubChampion
	{
		public override ChampionSkullType SkullType{ get{ return ChampionSkullType.Pain; } }
		
                [Constructable]
		public TheJukaGeneral() : base( AIType.AI_Melee )
		{
			Name = "The Juka General";
			Body = 766;
			//Hue = 1404;
			//BaseSoundID = 0x45A;

			SetStr( 959, 1182 );
			SetDex( 95, 99 );
			SetInt( 60, 90 );

			SetHits( 2500, 4000 );

			SetDamage( 50, 65 );
   
                        MF_Displacer = true;
                        MF_MassPeace = true;
                        
			SetDamageType( ResistanceType.Physical, 94 );
			SetDamageType( ResistanceType.Cold, 32 );

			SetResistance( ResistanceType.Physical, 60, 70 );
			SetResistance( ResistanceType.Fire, 60, 70 );
			SetResistance( ResistanceType.Cold, 60, 70 );
			SetResistance( ResistanceType.Poison, 60, 70 );
			SetResistance( ResistanceType.Energy, 60, 70 );

			SetSkill( SkillName.Macing, 112.1, 125.0 );
			SetSkill( SkillName.MagicResist, 125.5, 188.0 );
			SetSkill( SkillName.Tactics, 122.6, 125.0 );
			SetSkill( SkillName.Wrestling, 122.6, 125.0 );

			Fame = 20000;
			Karma = -20000;

			VirtualArmor = 63;
		}

		public override void GenerateLoot()
		{
			AddLoot( LootPack.UltraRich, 2 );
		}
  
                public override bool DoesSummoning { get { return true; } }
                public override bool DoesTeleporting { get { return false; } }
                
                public override bool AlwaysMurderer{ get{ return true; } }
		public override bool BardImmune{ get{ return !Core.AOS; } }
		public override bool CanRummageCorpses{ get{ return true; } }
		public override Poison PoisonImmune{ get{ return Poison.Regular; } }
		public override int TreasureMapLevel{ get{ return 5; } }
  
		public override void OnDamagedBySpell( Mobile caster )
		{
			if ( caster == this )
				return;
			SpawnJukaMage( caster );
		}
                public override void OnDamage( int amount, Mobile from, bool willKill )
		{
                         SpawnJukaLord( from );
                        if ( from != null && !willKill && amount > 5 && from.Player && 5 > Utility.Random( 100 ) )
		        {
				string[] toSay = new string[]
					{
						"{0}!!  You will have to do better than that!",
						"{0}!!  Prepare to meet your doom!",
						"{0}!!  My armies will crush you!",
						"{0}!!  You will pay for that!"
					};

				this.Say( true, String.Format( toSay[Utility.Random( toSay.Length )], from.Name ) );
			}
			base.OnDamage( amount, from, willKill );
		}
		public void SpawnJukaLord( Mobile target )
		{
			Map map = target.Map;

			if ( map == null )
				return;

			int jukas = 0;

			foreach ( Mobile m in this.GetMobilesInRange( 10 ) )
			{
				if ( m is JukaLord )
					++jukas;
			}

			if ( jukas < 10 )
			{
				BaseCreature juka = new JukaLord();

				juka.Team = this.Team;

				Point3D loc = target.Location;
				bool validLocation = false;

				for ( int j = 0; !validLocation && j < 10; ++j )
				{
					int x = target.X + Utility.Random( 3 ) - 1;
					int y = target.Y + Utility.Random( 3 ) - 1;
					int z = map.GetAverageZ( x, y );

					if ( validLocation = map.CanFit( x, y, this.Z, 16, false, false ) )
						loc = new Point3D( x, y, Z );
					else if ( validLocation = map.CanFit( x, y, z, 16, false, false ) )
						loc = new Point3D( x, y, z );
				}

				juka.MoveToWorld( loc, map );

				juka.Combatant = target;
			}
		}
                public void SpawnJukaMage( Mobile target )
		{
			Map map = target.Map;

			if ( map == null )
				return;

			int mjukas = 0;

			foreach ( Mobile m in this.GetMobilesInRange( 10 ) )
			{
				if ( m is JukaMage )
					++mjukas;
			}

			if ( mjukas < 10 )
			{
				BaseCreature mjuka = new JukaMage();

				mjuka.Team = this.Team;

				Point3D loc = target.Location;
				bool validLocation = false;

				for ( int j = 0; !validLocation && j < 10; ++j )
				{
					int x = target.X + Utility.Random( 3 ) - 1;
					int y = target.Y + Utility.Random( 3 ) - 1;
					int z = map.GetAverageZ( x, y );

					if ( validLocation = map.CanFit( x, y, this.Z, 16, false, false ) )
						loc = new Point3D( x, y, Z );
					else if ( validLocation = map.CanFit( x, y, z, 16, false, false ) )
						loc = new Point3D( x, y, z );
				}

				mjuka.MoveToWorld( loc, map );

				mjuka.Combatant = target;
			}
		}
  
		public TheJukaGeneral( Serial serial ) : base( serial )
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
