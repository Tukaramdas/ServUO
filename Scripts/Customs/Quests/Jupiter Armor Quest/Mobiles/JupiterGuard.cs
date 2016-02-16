using System;
using Server;
using Server.Items;

namespace Server.Mobiles
{
	[CorpseName( "Corpse Of A Jupiter Guard" )]
	public class JupiterGuard : BaseCreature
	{
		[Constructable]
		public JupiterGuard () : base( AIType.AI_Mage, FightMode.Closest, 10, 1, 0.2, 0.4 )
		{
			Name = "Guard Of Jupiter";
			Body = 43;
			BaseSoundID = 357;
                        Hue = 193;

			SetStr( 600, 700 );
			SetDex( 600, 700 );
			SetInt( 750, 800 );

			SetHits( 1000, 2000 );

			SetDamage( 50, 60 );

			SetSkill( SkillName.EvalInt, 100.1, 120.0 );
			SetSkill( SkillName.Magery, 100.1, 120.0 );
			SetSkill( SkillName.MagicResist, 100.1, 120.0 );
			SetSkill( SkillName.Tactics, 100.1, 120.0 );
			SetSkill( SkillName.Wrestling, 100.1, 120.0 );

			SetResistance( ResistanceType.Physical, 60, 70 );
			SetResistance( ResistanceType.Fire, 60, 70 );
			SetResistance( ResistanceType.Cold, 60, 70 );
			SetResistance( ResistanceType.Poison, 60, 70 );
			SetResistance( ResistanceType.Energy, 60, 70 );

			Fame = 18000;
			Karma = -18000;
            PackItem( new RingOfJupiter() );
			VirtualArmor = 90;
		}

		public override void GenerateLoot()
		{
			AddLoot( LootPack.FilthyRich );
			AddLoot( LootPack.Average );
			AddLoot( LootPack.MedScrolls, 2 );
		}

		public override int Meat{ get{ return 1; } }

		public JupiterGuard( Serial serial ) : base( serial )
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