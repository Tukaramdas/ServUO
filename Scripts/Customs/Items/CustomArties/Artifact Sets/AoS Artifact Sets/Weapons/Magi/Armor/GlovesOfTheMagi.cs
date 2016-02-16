using System;
using Server;

namespace Server.Items
{
	public class MagiGloves : LeatherGloves
	{
		public override int LabelNumber{ get{ return 1061600; } } // Gloves of the Magi
		public override int ArtifactRarity{ get{ return 11; } }
		
		public override int BaseEnergyResistance{ get{ return 15; } }

		public override int InitMinHits{ get{ return 255; } }
		public override int InitMaxHits{ get{ return 255; } }

		[Constructable]
		public MagiGloves()
		{
			Name = "Gloves of the Magi";
			Hue = 0x481;
			
			ArmorAttributes.MageArmor = 1;
			Attributes.RegenMana = 5;
			Attributes.CastSpeed = 1;
			Attributes.WeaponDamage = 15;
		}

		public MagiGloves( Serial serial ) : base( serial )
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