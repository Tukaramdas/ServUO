//=================================================
//This script was created by Gizmo's Uo Quest Maker
//This script was created on 6/9/2016 10:03:56
//=================================================
using System;
using Server;
using Server.Items;
using System.Collections.Generic;

namespace Server.Mobiles
{
	[CorpseName( "an QuestMonster corpse" )]
	public class QuestMonster : Drake
	{
		[Constructable]
		public QuestMonster()
		{
			Name = "QuestMonster";
			SetStr( 80, 80 );
			SetDex( 80, 80 );
			SetInt( 80, 80 );

			SetHits( 300, 300 );
			SetStam( 80, 80 );
			SetMana( 80, 80 );

			SetSkill( SkillName.Magery, 80, 90 );
			SetSkill( SkillName.EvalInt, 80, 90 );

			SetResistance( ResistanceType.Physical, 40, 40 );
			SetResistance( ResistanceType.Fire, 40, 40 );
			SetResistance( ResistanceType.Cold, 40, 40 );
			SetResistance( ResistanceType.Poison, 40, 40 );
			SetResistance( ResistanceType.Energy, 40, 40 );

			Fame = 10000;
		}

		public override void GenerateLoot()
		{
			AddLoot( LootPack.UltraRich, 1 );
			AddLoot( LootPack.SuperBoss, 1 );
		}

		public override void OnDeath( Container c )
		{
			base.OnDeath( c );	
				
				c.DropItem( new RavanasHead(  ) );
		}

		public QuestMonster( Serial serial ) : base( serial )
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
