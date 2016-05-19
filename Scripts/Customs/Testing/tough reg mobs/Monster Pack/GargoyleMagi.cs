using System;
using System.Collections;
using Server.Items;
using Server.Targeting;

namespace Server.Mobiles
{
	[CorpseName( "a gargoyle corpse" )]
	public class GargoyleMagi : BaseCreature
	{
		[Constructable]
		public GargoyleMagi() : base( AIType.AI_Mage, FightMode.Closest, 10, 1, 0.2, 0.4 )
		{
			Name = "a gargoyle magi";
			Body = 67;
			BaseSoundID = 0x174;
			Hue = 1764;

			SetStr( 246, 105 );
			SetDex( 76, 95 );
			SetInt( 196, 275 );

			SetHits( 148, 165 );
			SetMana( 366, 455 );

			SetDamage( 11, 17 );

			SetDamageType( ResistanceType.Physical, 100 );

			SetResistance( ResistanceType.Physical, 45, 55 );
			SetResistance( ResistanceType.Fire, 20, 30 );
			SetResistance( ResistanceType.Cold, 10, 20 );
			SetResistance( ResistanceType.Poison, 30, 40 );
			SetResistance( ResistanceType.Energy, 30, 40 );

			SetSkill( SkillName.MagicResist, 85.1, 100.0 );
			SetSkill( SkillName.Tactics, 80.1, 100.0 );
			SetSkill( SkillName.Wrestling, 60.1, 100.0 );
			SetSkill( SkillName.Magery, 99.0, 105.0 );

			Fame = 4500;
			Karma = -4500;

			VirtualArmor = 44;

			PackReg( 166 );

			if ( 0.10 > Utility.RandomDouble() )
				PackItem( new GargoylesPickaxe() );
		}

		public override void GenerateLoot()
		{
			AddLoot( LootPack.Rich, 3 );
			AddLoot( LootPack.Gems, 2 );
			AddLoot( LootPack.Potions );
		}

		public override int TreasureMapLevel{ get{ return 3; } }

		public GargoyleMagi( Serial serial ) : base( serial )
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