using System;
using Server.Network;
using Server.Items;

namespace Server.Items
{
	public class SerpentsGloves : DragonGloves
	{
		public override int LabelNumber{ get{ return 1075047; } } // SerpentsGloves
		public override int ArtifactRarity{ get{ return 11; } }

		public override int BasePhysicalResistance{ get{ return 10; } }
		public override int BaseFireResistance{ get{ return 10; } }
		public override int BasePoisonResistance{ get{ return 5; } }

		public override ArmorMaterialType MaterialType{ get{ return ArmorMaterialType.Dragon; } }
		public override CraftResource DefaultResource{ get{ return CraftResource.Iron; } }

		public override int InitMinHits{ get{ return 255; } }
		public override int InitMaxHits{ get{ return 255; } }

		[Constructable]
		public SerpentsGloves()
		{
			Name = "Serpents Gloves";
		
			Hue = 0x488;
			Attributes.AttackChance = 15;
			Attributes.WeaponDamage = 10;
			Attributes.BonusDex = 5;
			Attributes.RegenStam = 5;
		}

		public SerpentsGloves( Serial serial ) : base( serial )
		{
		}

		public override void Serialize( GenericWriter writer )
		{
			base.Serialize( writer );

			writer.WriteEncodedInt( 0 ); // version
		}

		public override void Deserialize( GenericReader reader )
		{
			base.Deserialize( reader );

			int version = reader.ReadEncodedInt();
		}
	}
}