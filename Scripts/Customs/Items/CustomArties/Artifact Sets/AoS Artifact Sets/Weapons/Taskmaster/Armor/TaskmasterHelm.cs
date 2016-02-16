using System;
using Server;

namespace Server.Items
{
	public class TaskmasterHelm : Bascinet
	{
		public override int LabelNumber{ get{ return 1061110; } } // Taskmaster
		public override int ArtifactRarity{ get{ return 10; } }
		
		public override int BasePoisonResistance{ get{ return 25; } }

		public override int InitMinHits{ get{ return 255; } }
		public override int InitMaxHits{ get{ return 255; } }

		[Constructable]
		public TaskmasterHelm()
		{
			Name = "Taskmaster Helm";
		
			Hue = 0x4F8;
			
			Attributes.BonusDex = 5;
			Attributes.AttackChance = 5;
			Attributes.WeaponDamage = 10;
		}

		public TaskmasterHelm( Serial serial ) : base( serial )
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