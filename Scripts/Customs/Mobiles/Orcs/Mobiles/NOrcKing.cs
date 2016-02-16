using System;
using System.Collections;
using Server.Misc;
using Server.Items;
using Server.Targeting;

namespace Server.Mobiles
{
	public class NOrcKing : BaseCreature
	{
		[Constructable]
		public NOrcKing() : base( AIType.AI_Melee, FightMode.Closest, 10, 1, 0.2, 0.4 )
		{
			Name = "Kruschak";
			Title = "the orc king";
			Body = 0x190;
                        Hue = 667;
			BaseSoundID = 0x45A;

			SetStr( 900 );
			SetDex( 300 );
			SetInt( 750 );

			SetHits( 8000 );
			SetStam( 300 );

			SetDamage( 45, 55 );

			SetDamageType( ResistanceType.Physical, 100 );

			SetResistance( ResistanceType.Physical, 70 );
			SetResistance( ResistanceType.Fire, 60 );
			SetResistance( ResistanceType.Cold, 60 );
			SetResistance( ResistanceType.Poison, 50 );
			SetResistance( ResistanceType.Energy, 50 );

			SetSkill( SkillName.MagicResist, 100.0 );
			SetSkill( SkillName.Tactics, 100.0 );
			SetSkill( SkillName.Wrestling, 100.0 );

			Fame = 60000;
			Karma = -60000;

			VirtualArmor = 80;

			AddItem( new OrcLegs());
			AddItem( new Robe(Hue=32));
			AddItem( new OrcChest());
                        AddItem( new OrcGloves());
                        AddItem( new LargeOrcAxe());
                        AddItem( new OrcGorget());
                        AddItem( new OrcArms());
			AddItem( new OrcMask(Hue=667));
		}

		public override void GenerateLoot()
		{
			AddLoot( LootPack.UltraRich, 4 );
			AddLoot( LootPack.FilthyRich );
		}

		public override void OnDamage( int amount, Mobile from, bool willKill )
		{
			if ( from != null && !willKill && amount > 5 && from.Player && 5 > Utility.Random( 100 ) )
			{
				string[] toSay = new string[]
					{
						"You cant defeat this orcish invasion",  
						"We are too many. Give up!",
						"Help me, orcish dumps, I am under attack",
						"{0}!! You will pay for that!"
					};

				this.Say( true, String.Format( toSay[Utility.Random( toSay.Length )], from.Name ) );
			}

			base.OnDamage( amount, from, willKill );
		}

		public override bool AlwaysMurderer{ get{ return true; } }
		public override bool BardImmune{ get{ return true; } }
		public override Poison PoisonImmune{ get{ return Poison.Deadly; } }

		public override bool ShowFameTitle{ get{ return false; } }
		public override bool ClickTitle{ get{ return false; } }

		public void SpawnOrcs( Mobile target )
		{
			Map map = this.Map;

			if ( map == null )
				return;

			int orcs = 0;

			foreach ( Mobile m in this.GetMobilesInRange( 10 ) )
			{
				if ( m is OrcSoldier || m is OrcSoldier || m is OrcSoldier )
					++orcs;
			}

			if ( orcs < 16 )
			{
				PlaySound( 0x3D );

				int newOrcs = Utility.RandomMinMax( 3, 6 );

				for ( int i = 0; i < newOrcs; ++i )
				{
					BaseCreature orc;

					switch ( Utility.Random( 5 ) )
					{
						default:
						case 0: case 1:	orc = new OrcSoldier(); break;
						case 2: case 3:	orc = new OrcSoldier(); break;
						case 4:			orc = new OrcSoldier(); break;
					}

					orc.Team = this.Team;

					bool validLocation = false;
					Point3D loc = this.Location;

					for ( int j = 0; !validLocation && j < 10; ++j )
					{
						int x = X + Utility.Random( 3 ) - 1;
						int y = Y + Utility.Random( 3 ) - 1;
						int z = map.GetAverageZ( x, y );

						if ( validLocation = map.CanFit( x, y, this.Z, 16, false, false ) )
							loc = new Point3D( x, y, Z );
						else if ( validLocation = map.CanFit( x, y, z, 16, false, false ) )
							loc = new Point3D( x, y, z );
					}

					orc.MoveToWorld( loc, map );
					orc.Combatant = target;
				}
			}
		}

		public void DoSpecialAbility( Mobile target )
		{

			if ( 0.2 >= Utility.RandomDouble() ) // 20% chance to more ratmen
				SpawnOrcs( target );

		}

		public override void OnGotMeleeAttack( Mobile attacker )
		{
			base.OnGotMeleeAttack( attacker );

			DoSpecialAbility( attacker );
		}

		public override void OnGaveMeleeAttack( Mobile defender )
		{
			base.OnGaveMeleeAttack( defender );

			DoSpecialAbility( defender );
		}

		public NOrcKing( Serial serial ) : base( serial )
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