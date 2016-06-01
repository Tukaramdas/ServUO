using System;
using Server;
using Server.Items;

namespace Server.Mobiles
{
	[CorpseName( "an Ghostly corpse" )]
	public class DaveyJones : BaseCreature
	{
		[Constructable]
		public DaveyJones() : base( AIType.AI_Thief, FightMode.Closest, 10, 1, 0.1, 0.2 )
		{
			Name = "Davey Jones";

			Body = 0xC7;
			Hue = 0x5B;

            SetStr(1500);
            SetDex(151, 175);
            SetInt(171, 220);

            SetHits(3800);

            SetDamage(32, 37);

            SetDamageType(ResistanceType.Physical, 50);
            SetDamageType(ResistanceType.Cold, 50);

			SetResistance( ResistanceType.Physical, 90 );
			SetResistance( ResistanceType.Fire, 90 );
			SetResistance( ResistanceType.Cold, 90 );
			SetResistance( ResistanceType.Poison, 90 );
			SetResistance( ResistanceType.Energy, 90 );

			SetSkill( SkillName.Magery, 60.1, 90.0 );
			SetSkill( SkillName.Meditation, 200.1, 301.0 );
			SetSkill( SkillName.Poisoning, 100.1, 161.0 );
			SetSkill( SkillName.MagicResist, 105.2, 150.0 );
			SetSkill( SkillName.Tactics, 90.1, 130.0 );
			SetSkill( SkillName.Wrestling, 75.1, 150.0 );
			SetSkill( SkillName.Macing, 175.1, 200.0 );
			SetSkill( SkillName.Parry, 105.1, 120.0 );
			SetSkill( SkillName.Fencing, 175.1, 200.0 );
			SetSkill( SkillName.Swords, 175.1, 200.0 );
			SetSkill( SkillName.Anatomy, 175.1, 200.0 );

			Fame = 0;
			Karma = -12000;

			VirtualArmor = 50;

			AddItem( new FancyShirt( 0x5B ) );
			AddItem( new TricorneHat( 0x5B ) );
			AddItem( new ThighBoots( 0x5B ) );

			PackGem();
		}

		public override bool Unprovokable{ get{ return true; } }
		public override bool CanRummageCorpses{ get{ return true; } }
		public override Poison HitPoison{ get{ return Poison.Lethal; } }
		public override bool AlwaysAttackable{ get{ return true; } }
		public override bool Uncalmable{ get{ return true; } }
		public override Poison PoisonImmune{ get{ return Poison.Lethal; } }
		public override int TreasureMapLevel{ get{ return 5; } }

		public override bool OnBeforeDeath()
		{
			switch ( Utility.Random( 15 ) )
			{
				//case 0: PackItem( new RewardTicket() ); break;
				case 2: PackItem( new Gold( 1000 ) ); break;
			}
			PackItem( new Gold( 500 ) );
			PackItem( new Gold( 500 ) );

			return base.OnBeforeDeath();
		}

		public DaveyJones( Serial serial ) : base( serial )
		{
		}

		public override void Serialize( GenericWriter writer )
		{
			base.Serialize( writer );
			writer.Write( (int) 0 );
		}

		public override void Deserialize( GenericReader reader )
		{
			base.Deserialize( reader );
			int version = reader.ReadInt();
		}
	}
}