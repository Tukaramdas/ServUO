using System;
using Server;
using Server.Ethics;
using Server.Items;
using System.Collections.Generic;

namespace Server.Mobiles
{
	[CorpseName( " Ravana corpse" )]
	public class Ravana : Daemon
    {
		[Constructable]
		public Ravana()
		{
			Name = "Ravana";

            Body = 40;
            Hue = 1281;
            SetStr( 1000, 1000 );
			SetDex( 100, 100 );
			SetInt( 100, 100 );

			SetHits( 2000, 2000 );
			SetStam( 100, 100 );
			SetMana( 100, 100 );

            SetDamage(22, 35);

            SetSkill( SkillName.Anatomy, 100, 120 );
			SetSkill( SkillName.EvalInt, 100, 120 );
			SetSkill( SkillName.Magery, 100, 120 );
			SetSkill( SkillName.Tactics, 100, 120 );
			SetSkill( SkillName.Wrestling, 100, 120 );
            SetSkill(SkillName.Meditation, 100, 120);
            SetSkill(SkillName.MagicResist, 100, 120);
            


            SetResistance( ResistanceType.Physical, 50, 50 );
			SetResistance( ResistanceType.Fire, 50, 50 );
			SetResistance( ResistanceType.Cold, 50, 50 );
			SetResistance( ResistanceType.Poison, 50, 50 );
			SetResistance( ResistanceType.Energy, 50, 50 );

			Fame = 25000;
            Karma = -25000;

            VirtualArmor = 90;

            PackItem(new RavanasHead());
        }


        public override Poison PoisonImmune
        {
            get
            {
                return Poison.Deadly;
            }
        }
        public override Ethic EthicAllegiance
        {
            get { return Ethic.Evil; }
        }
        public override bool CanFly
        {
            get { return true; }
        }
        public override void GenerateLoot()
		{
			
		}


		public Ravana( Serial serial ) : base( serial )
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
