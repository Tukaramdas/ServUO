using System;
using Server;

namespace Server.Items
{
	public class InsanitySandals : Sandals
	{
		public override int LabelNumber{ get{ return 1061088; } } // Insanity Sandals
		public override int ArtifactRarity{ get{ return 11; } }

		public override int InitMinHits{ get{ return 255; } }
		public override int InitMaxHits{ get{ return 255; } }

		[Constructable]
		public InsanitySandals()
		{
			Name = "Insanity Sandals";
		
			Hue = Utility.RandomBool() ? 0x76D : 0x44F;
			Attributes.RegenStam = 5;
			Attributes.WeaponSpeed = 10;
			Attributes.WeaponDamage = 15;
		}

		public InsanitySandals( Serial serial ) : base( serial )
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