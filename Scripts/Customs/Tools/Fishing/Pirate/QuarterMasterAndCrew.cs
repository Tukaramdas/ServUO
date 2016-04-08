using System;
using Server.Mobiles;
using System.Collections;
using Server.Items;

namespace Server.Mobiles
{
	[CorpseName( "a Quarter Master's corpse" )]
	public class QuarterMaster : BaseCreature
	{
		private ArrayList m_crew;
		int crewCount = Utility.RandomMinMax( 2, 5 );

//		public override PackInstinct PackInstinct{ get{ return PackInstinct.Gang; } }
		public override bool CanRegenHits{ get{ return true; } }
		public override bool ShowFameTitle{ get{ return false; } }

		[CommandProperty( AccessLevel.GameMaster )]
		public bool RespawnCrew
		{
			get{ return false; }
			set{ if( value ) SpawnCrew(); }
		}

		[Constructable]
		public QuarterMaster() : base( AIType.AI_Melee,FightMode.Aggressor, 10, 1, 0.1, 0.3 )
		{
			Name = NameList.RandomName( "male" );
			Title = "the Quarter Master";
			Body = 400;

			SetStr( 491, 610 );
			SetDex( 176, 295 );
			SetInt( 331, 450 );

			SetHits( 3042, 4568 );
			SetMana( 500 );

			SetDamage( 21, 32 );

			SetDamageType( ResistanceType.Physical, 100 );

			SetResistance( ResistanceType.Physical, 55, 65 );
			SetResistance( ResistanceType.Fire, 30, 50 );
			SetResistance( ResistanceType.Cold, 50, 65 );
			SetResistance( ResistanceType.Poison, 25, 45 );
			SetResistance( ResistanceType.Energy, 40, 65 );

			SetSkill( SkillName.MagicResist, 130.6, 145.0 );
			SetSkill( SkillName.Tactics, 130.1, 140.0 );
			SetSkill( SkillName.Swords, 130.1, 155.0 );
			SetSkill( SkillName.Parry, 130.1, 145.0 );
			SetSkill( SkillName.EvalInt, 130.1, 145.0 );
			SetSkill( SkillName.Anatomy, 130.1, 135.0 );
			SetSkill( SkillName.Focus, 130.1, 145.0 );

			Fame = 20000;
			Karma = -20000;

			VirtualArmor = 40;

			AddItem( new TricorneHat( 1109 ) );
			AddItem( new ShortPants( 1109 ) );
			AddItem( new Shirt( 1109 ) );
			AddItem( new ThighBoots() );

			Scimitar weapon = new Scimitar();
			weapon.Movable = false;
			AddItem( weapon );

			m_crew = new ArrayList();
			Timer m_timer = new QuarterMasterFamilyTimer( this );
			m_timer.Start();
		}

		public override void GenerateLoot()
		{
			AddLoot( LootPack.UltraRich, 2 );
		}

		public override bool AlwaysAttackable{ get{ return true; } }

		/*public override bool OnBeforeDeath()
		{

			return base.OnBeforeDeath();
		}*/

		public void SpawnCrew()
		{

			Defrag();
			int family = m_crew.Count;

			if( family >= crewCount )
				return;

			Map map = this.Map;

			if ( map == null )
				return;

			int hr = (int)((this.RangeHome + 1) / 2);

			for ( int i = family; i < crewCount; ++i )
			{
				PirateCrew crew = new PirateCrew();

				bool validLocation = false;
				Point3D loc = this.Location;

				for ( int j = 0; !validLocation && j < 10; ++j )
				{
					int x = X + Utility.Random( 5 ) - 1;
					int y = Y + Utility.Random( 5 ) - 1;
					int z = map.GetAverageZ( x, y );

					if ( validLocation = map.CanFit( x, y, this.Z, 16, false, false ) )
						loc = new Point3D( x, y, Z );
					else if ( validLocation = map.CanFit( x, y, z, 16, false, false ) )
						loc = new Point3D( x, y, z );
				}

				crew.master = this;
				crew.Team = this.Team;
				crew.Home = this.Location;
				crew.RangeHome = ( hr > 4 ? 4 : hr );

				crew.MoveToWorld( loc, map );
				m_crew.Add( crew );
			}
		}

		protected override void OnLocationChange( Point3D oldLocation )
		{

			try
			{
				foreach( Mobile m in m_crew )
				{
					if( m is PirateCrew && m.Alive )
					{
						((PirateCrew)m).Home = this.Location;
					}
				}
			}
			catch{}

			base.OnLocationChange( oldLocation );
		}

		public void Defrag()
		{
			for ( int i = 0; i < m_crew.Count; ++i )
			{
				try
				{
					object o = m_crew[i];

					PirateCrew crew = o as PirateCrew;

					if ( crew == null || !crew.Alive )
					{
						m_crew.RemoveAt( i );
						--i;
					}

				}
				catch{}
			}
		}

		public override void OnDelete()
		{
			Defrag();

			foreach( Mobile m in m_crew )
			{
				if( m.Alive )
					m.Delete();
			}

			base.OnDelete();
		}

		public QuarterMaster(Serial serial) : base(serial)
		{
			m_crew = new ArrayList();
			Timer m_timer = new QuarterMasterFamilyTimer( this );
			m_timer.Start();
		}

		public override void Serialize(GenericWriter writer)
		{
			base.Serialize(writer);
			writer.Write((int) 0);
			writer.WriteMobileList( m_crew, true );
		}

		public override void Deserialize(GenericReader reader)
		{
			base.Deserialize(reader);
			int version = reader.ReadInt();
			m_crew = reader.ReadMobileList();
		}
	}

	[CorpseName( "a ships crew corpse" )]
	public class PirateCrew : BaseCreature
	{
	//	public override PackInstinct PackInstinct{ get{ return PackInstinct.Gang; } }
		public override bool ShowFameTitle{ get{ return false; } }

		private QuarterMaster m_master;

		[CommandProperty( AccessLevel.GameMaster )]
		public QuarterMaster master
		{
			get{ return m_master; }
			set{ m_master = value; }
		}

		[Constructable]
		public PirateCrew() : base( AIType.AI_Melee, FightMode.Aggressor, 10, 1, 0.2, 0.4 )
		{
			Name = "Pirate Crew";
			Body = 400;

			SetStr( 391, 510 );
			SetDex( 176, 195 );
			SetInt( 231, 250 );

			SetHits( 942, 968 );
			SetMana( 500 );

			SetDamage( 21, 41 );

			SetDamageType( ResistanceType.Physical, 100 );

			SetResistance( ResistanceType.Physical, 45, 55 );
			SetResistance( ResistanceType.Fire, 20, 40 );
			SetResistance( ResistanceType.Cold, 40, 55 );
			SetResistance( ResistanceType.Poison, 15, 35 );
			SetResistance( ResistanceType.Energy, 30, 55 );

			SetSkill( SkillName.MagicResist, 120.6, 135.0 );
			SetSkill( SkillName.Tactics, 120.1, 130.0 );
			SetSkill( SkillName.Wrestling, 120.1, 145.0 );
			SetSkill( SkillName.Swords, 120.1, 145.0 );
			SetSkill( SkillName.Parry, 120.1, 145.0 );
			SetSkill( SkillName.Wrestling, 120.1, 145.0 );
			SetSkill( SkillName.EvalInt, 120.1, 145.0 );
			SetSkill( SkillName.Anatomy, 120.1, 145.0 );
			SetSkill( SkillName.Focus, 120.1, 145.0 );

			Fame = 10000;
			Karma = -10000;

			VirtualArmor = 30;

			AddItem( new ShortPants( 1109 ) );
			AddItem( new SkullCap( 1150 ) );
			AddItem( new Boots() );

			switch ( Utility.Random( 4 ) )
			{
				case 0: AddItem( new Hatchet() ); break;
				case 1: AddItem( new Dagger() ); break;
				case 2: AddItem( new Cutlass() ); break;
				case 3: AddItem( new Club() ); break;
			}
		}

		public override void GenerateLoot()
		{
			AddLoot( LootPack.UltraRich, 1 );
		}
		public override bool AlwaysAttackable{ get{ return true; } }

		public override void OnCombatantChange()
		{
			if( Combatant != null && Combatant.Alive && m_master != null && m_master.Combatant == null )
				m_master.Combatant = Combatant;
		}

		public PirateCrew(Serial serial) : base(serial)
		{
		}

		public override void Serialize(GenericWriter writer)
		{
			base.Serialize( writer );
			writer.Write( (int) 0 );
			writer.Write( m_master );
		}

		public override void Deserialize(GenericReader reader)
		{
			base.Deserialize(reader);
			int version = reader.ReadInt();
			m_master = (QuarterMaster)reader.ReadMobile();
		}
	}

	public class QuarterMasterFamilyTimer : Timer
	{
		private QuarterMaster m_from;

		public QuarterMasterFamilyTimer( QuarterMaster from  ) : base( TimeSpan.FromMinutes( 1 ), TimeSpan.FromMinutes( 20 ) )
		{
			Priority = TimerPriority.OneMinute;
			m_from = from;
		}

		protected override void OnTick()
		{
			if ( m_from != null && m_from.Alive )
				m_from.SpawnCrew();
			else
				Stop();
		}
	}
}