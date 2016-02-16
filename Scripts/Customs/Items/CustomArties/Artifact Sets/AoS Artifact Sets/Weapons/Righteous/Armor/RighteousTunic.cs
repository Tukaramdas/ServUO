using System;
using Server.Network;
using Server.Items;

namespace Server.Items
{
	public class RighteousTunic : ChainChest
	{
		public override int LabelNumber{ get{ return 1061088; } } // Righteous Tunic
		public override int ArtifactRarity{ get{ return 11; } }

		public override int BasePhysicalResistance{ get{ return 10; } }
		public override int BaseColdResistance{ get{ return 10; } }
		public override int BaseEnergyResistance{ get{ return 10; } }

		public override int InitMinHits{ get{ return 255; } }
		public override int InitMaxHits{ get { return 255; } }


		[Constructable]
		public RighteousTunic()
		{
			Name = "Righteous Bandana";
		
			Hue = 0x47E;
			Attributes.BonusHits = 10;
			Attributes.WeaponDamage = 5;
			Attributes.SpellDamage = 5;
			Attributes.AttackChance = 5;

			ArmorAttributes.MageArmor = 1;
		}

		public RighteousTunic( Serial serial ) : base( serial )
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