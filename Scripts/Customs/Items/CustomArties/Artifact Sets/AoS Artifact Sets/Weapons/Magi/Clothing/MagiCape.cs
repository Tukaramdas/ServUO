using System;
using Server;

namespace Server.Items
{
	public class MagiCape : FurCape
	{
		public override int LabelNumber{ get{ return 1061088; } } // Magi Cape
		public override int ArtifactRarity{ get{ return 11; } }

		public override int InitMinHits{ get{ return 255; } }
		public override int InitMaxHits{ get{ return 255; } }

		[Constructable]
		public MagiCape()
		{
			Name = "Magi Cape";
		
			Hue = 0x481;
			Attributes.CastSpeed = 1;
			Attributes.SpellDamage = 5;
			Attributes.RegenMana = 2;
			Attributes.AttackChance = 5;
		}

		public MagiCape( Serial serial ) : base( serial )
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

			if ( Hue == 0x44F )
				Hue = 0x76D;
		}
	}
}