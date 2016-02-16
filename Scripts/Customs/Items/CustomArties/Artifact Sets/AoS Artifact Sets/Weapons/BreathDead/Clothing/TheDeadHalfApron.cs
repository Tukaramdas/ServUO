using System;
using Server;

namespace Server.Items
{
	public class TheDeadHalfApron : HalfApron
	{
		public override int LabelNumber{ get{ return 1061111; } } // TheDeadHalf Apron
		public override int ArtifactRarity{ get{ return 11; } }
		
		public override int InitMinHits{ get{ return 255; } }
		public override int InitMaxHits{ get{ return 255; } }

		[Constructable]
		public TheDeadHalfApron()
		{
			Name = "Half Apron of the Dead";
			Hue = 0x455;
			Attributes.RegenHits = 5;
			Attributes.BonusInt = 5;
			Attributes.SpellDamage = 5;
			Attributes.WeaponDamage = 10;
		}

		public TheDeadHalfApron( Serial serial ) : base( serial )
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