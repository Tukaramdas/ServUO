using System;
using Server;

namespace Server.Items
{
	public class TaskmasterVest : JinBaori
	{
		public override int LabelNumber{ get{ return 1061111; } } // TaskmasterVest
		public override int ArtifactRarity{ get{ return 11; } }
		
		public override int BasePoisonResistance{ get{ return 5; } }
		
		public override int InitMinHits{ get{ return 255; } }
		public override int InitMaxHits{ get{ return 255; } }

		[Constructable]
		public TaskmasterVest()
		{
			Name = "Taskmaster Vest";
			Hue = 0x4F8;
			
			Attributes.BonusDex = 5;
			Attributes.AttackChance = 5;
			Attributes.WeaponDamage = 10;
		}

		public TaskmasterVest( Serial serial ) : base( serial )
		{
		}

		public override void Serialize( GenericWriter writer )
		{
			base.Serialize( writer );

			writer.Write( (int) 0 );
		}
		
		public override void Deserialize(GenericReader reader)
		{
			base.Deserialize( reader );

			int version = reader.ReadInt();
		}
	}
}