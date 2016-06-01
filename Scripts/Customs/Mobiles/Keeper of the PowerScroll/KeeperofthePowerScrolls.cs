/////Scripted By Talon Nyte/////
using Server;
using Server.Items;
using Server.Mobiles;
using Server.Targeting;
using System.Collections;

namespace Server.Mobiles
{
[CorpseName( "a PowerScroll Keeper corpse" )]
	public class KeeperofthePowerScrolls : BaseCreature
	{
		
		[Constructable]
		public KeeperofthePowerScrolls() : base( AIType.AI_Mage, FightMode.Closest, 10, 1, 0.2, 0.4 )
		{
			Name = " Keeper of the PowerScrolls";
                        Body = 400;
                        BaseSoundID = 0x4FB;
			Hue = 1072;

			SetStr( 300 );
			SetDex( 300);
			SetInt( 300);

			SetHits( 600, 700 );

			SetDamage( 30, 35 );

			SetDamageType( ResistanceType.Physical, 60 );
			SetDamageType( ResistanceType.Fire, 60 );
			SetDamageType( ResistanceType.Cold, 60 );
			SetDamageType( ResistanceType.Poison, 60 );
			SetDamageType( ResistanceType.Energy, 60 );

			SetResistance( ResistanceType.Physical, 50 );
			SetResistance( ResistanceType.Fire, 45 );
			SetResistance( ResistanceType.Cold, 45 );
			SetResistance( ResistanceType.Poison, 45 );
			SetResistance( ResistanceType.Energy, 50 );

			SetSkill( SkillName.EvalInt, 125.1, 130.0 );

			SetSkill( SkillName.Magery, 125.1, 130.0 );
			SetSkill( SkillName.Meditation, 125.1, 130.0 );
			SetSkill( SkillName.MagicResist, 140.5, 170.0 );
			SetSkill( SkillName.Tactics, 125.1, 130.0 );
			SetSkill( SkillName.Wrestling, 125.1, 130.0 );

			Fame = 20000;
			Karma = -20000;

			VirtualArmor = 60;

                        AddItem( new HoodedShroudOfShadows());

                        Katana weapon = new Katana();
                        weapon.Hue = 1153;
                        weapon.Movable = false;
                        AddItem(weapon);

			Tamable = false;
                        PackGem();
			PackGem();
			PackPotion();
			PackGold( 3000, 5000 );
			PackScroll( 2, 8 );
			PackMagicItems( 3, 5, 0.95, 0.95 );
			PackMagicItems( 4, 5, 0.80, 0.65 );
			PackMagicItems( 4, 5, 0.80, 0.65 );
			PackSlayer();

		        }
                        public override void OnDeath(Container c)
                        {
                         base.OnDeath(c);
                        
			c.DropItem( new RandomPowerScrollDeed() );
			
		}

		public override int GetAngerSound()
		{
			if ( !Controlled )
				return 0x16A;

			return base.GetAngerSound();
		}

		//public override bool HasBreath{ get{ return true; } } // fire breath enabled
		
		//public override bool CanRummageCorpses{ get{ return true; } }
		//public override Poison PoisonImmune{ get{ return Poison.Regular; } }		
		//public override Poison HitPoison{ get{ return Poison.Lethal; } }
		

		public override WeaponAbility GetWeaponAbility()
		{
			switch ( Utility.Random( 3 ) )
			{
				default:
				case 0: return WeaponAbility.MortalStrike;
				case 1: return WeaponAbility.WhirlwindAttack;
				case 2: return WeaponAbility.CrushingBlow;
			}
		}


		public KeeperofthePowerScrolls( Serial serial ) : base( serial )
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

			if ( BaseSoundID == 0x16A )
				BaseSoundID = 0xA8;
		}
	}
}