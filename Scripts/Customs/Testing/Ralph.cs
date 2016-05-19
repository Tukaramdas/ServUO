//=================================================
//This script was created by Gizmo's Uo Quest Maker
//This script was created on 5/13/2016 15:00:26
//=================================================
using System;
using Server;
using Server.Items;
using System.Collections.Generic;

namespace Server.Mobiles
{
	[CorpseName( "an Ralph corpse" )]
	public class Ralph : Centaur
	{
		[Constructable]
		public Ralph()
		{
			Name = "Ralph";
			// Hue = 7;
			SetStr( 60, 60 );
			SetDex( 60, 60 );
			SetInt( 60, 60 );

			SetHits( 200, 200 );
			SetStam( 50, 50 );
			SetMana( 50, 50 );

			SetSkill( SkillName.Anatomy, 100, 100 );
			SetSkill( SkillName.Wrestling, 100, 100 );
			SetSkill( SkillName.Tactics, 100, 100 );

			SetResistance( ResistanceType.Physical, 50, 50 );
			SetResistance( ResistanceType.Fire, 50, 50 );
			SetResistance( ResistanceType.Cold, 50, 50 );
			SetResistance( ResistanceType.Poison, 50, 50 );
			SetResistance( ResistanceType.Energy, 50, 50 );

			Fame = 1000;

            
        }

		public override void GenerateLoot()
		{
			AddLoot( LootPack.UltraRich, 1 );
			AddLoot( LootPack.Gems, 1 );
		}

		public Ralph( Serial serial ) : base( serial )
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
