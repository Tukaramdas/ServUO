using System;
using Server;

namespace Server.Items
{
	public class DragonSlayerGloves : StuddedGloves
	{
		public override int LabelNumber{ get{ return 1061107; } } // Dragon Slayer Gloves
		public override int ArtifactRarity{ get{ return 11; } }
		
		public override int BaseFireResistance{ get{ return 10; } }

		public override int InitMinHits{ get{ return 255; } }
		public override int InitMaxHits{ get{ return 255; } }

		[Constructable]
		public DragonSlayerGloves()
		{
			Name = "Dragon Slayer Gloves";
			Hue = 0x530;
			Attributes.Luck = 110;
			Attributes.WeaponDamage = 5;
		}

		public DragonSlayerGloves( Serial serial ) : base( serial )
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