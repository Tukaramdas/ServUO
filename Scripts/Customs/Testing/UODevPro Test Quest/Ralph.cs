//===============================================================================
//                      This script was created by Gizmo's UoDevPro
//                      This script was created on 6/15/2016 18:19:06
//===============================================================================


using System;
using Server;
using Server.Items;
using System.Collections.Generic;

namespace Server.Mobiles
{
	[CorpseName( "an Ralph coprse" )]
	public class Ralph : Balron
	{
		[Constructable]
		public Ralph() : base()
		{
			Name = "Ralph";
			Hue = 0;
			SetStr( 120 );
			SetDex( 120 );
			SetInt( 120 );
			SetHits( 500 );
			SetStam( 200 );
			SetMana( 200 );

			//Skills
			SetSkill( SkillName.Anatomy, 50.0, 100.0 );
			SetSkill( SkillName.EvalInt, 50.0, 100.0 );
			SetSkill( SkillName.Magery, 50.0, 100.0 );
			SetSkill( SkillName.MagicResist, 50.0, 100.0 );
			SetSkill( SkillName.Tactics, 50.0, 100.0 );
			SetSkill( SkillName.Wrestling, 50.0, 100.0 );

			Fame = 10000;
			Karma = -10000;
		}


		//Generate Loot
		public override void GenerateLoot()
		{
			AddLoot( LootPack.FilthyRich, 1 );
			AddLoot( LootPack.Gems, 4 );
		}


		//Generate Special Loot
		public override void OnDeath( Container c )
		{
			base.OnDeath(c);
			if ( Utility.RandomMinMax( 1, 1 ) == 1 )
				c.DropItem( new GingerbreadDough(  ) );
		}

        public Ralph(Serial serial) : base(serial)
        {
        }

       

		public override void Serialize(GenericWriter writer)
		{
			base.Serialize(writer);
			writer.Write((int)0); // version
		}
		public override void Deserialize(GenericReader reader)
		{
			base.Deserialize(reader);
			int version = reader.ReadInt();
		}
	}
}
