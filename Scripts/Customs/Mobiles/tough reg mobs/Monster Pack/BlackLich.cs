using System;
using Server;
using Server.Items;

namespace Server.Mobiles
{
	[CorpseName( "a black liche's corpse" )]
	public class BlackLich : BaseCreature
	{
		[Constructable]
		public BlackLich() : base( AIType.AI_Mage, FightMode.Closest, 10, 1, 0.2, 0.4 )
		{
			Name = "a black lich";
			Body = 79;
			BaseSoundID = 412;
			Hue = 2019;

			SetStr( 416, 505 );
			SetDex( 146, 165 );
			SetInt( 566, 655 );

			SetHits( 720, 902 );

			SetDamage( 10, 16 );

			SetDamageType( ResistanceType.Physical, 0 );
			SetDamageType( ResistanceType.Cold, 60 );
			SetDamageType( ResistanceType.Energy, 45 );

			SetResistance( ResistanceType.Physical, 44, 56 );
			SetResistance( ResistanceType.Fire, 30, 40 );
			SetResistance( ResistanceType.Cold, 50, 60 );
			SetResistance( ResistanceType.Poison, 50, 60 );
			SetResistance( ResistanceType.Energy, 52, 60 );

			SetSkill( SkillName.EvalInt, 97.1, 110.0 );
			SetSkill( SkillName.Magery, 97.1, 105.0 );
			SetSkill( SkillName.MagicResist, 150.5, 205.0 );
			SetSkill( SkillName.Tactics, 50.1, 70.0 );
			SetSkill( SkillName.Wrestling, 60.1, 80.0 );

			Fame = 18000;
			Karma = -18000;

			VirtualArmor = 50;
			PackItem( new GnarledStaff() );
			PackNecroReg( 52, 80 );
            AddItem(new RandomTalisman());
		}

		public override OppositionGroup OppositionGroup
		{
			get{ return OppositionGroup.FeyAndUndead; }
		}

		public override void GenerateLoot()
		{
			AddLoot( LootPack.FilthyRich, 4 );
            AddLoot(LootPack.Gems, 2);
			
		}

		public override bool CanRummageCorpses{ get{ return true; } }
		public override bool BleedImmune{ get{ return true; } }
		public override Poison PoisonImmune{ get{ return Poison.Lethal; } }
		public override int TreasureMapLevel{ get{ return 5; } }
        public override bool AlwaysMurderer { get { return true; } }

		public override void OnDeath( Container c )
		{
			base.OnDeath( c );		
			
			if ( Utility.RandomDouble() < 0.3 )	
				c.DropItem( new BlackDyeTub() );
				
		}

		public BlackLich( Serial serial ) : base( serial )
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