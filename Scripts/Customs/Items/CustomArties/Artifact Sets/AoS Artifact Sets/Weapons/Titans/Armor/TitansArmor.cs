using System;
using Server;

namespace Server.Items
{
	public class TitansArmor : RingmailChest
	{
		public override int LabelNumber{ get{ return 1061092; } } // Armor of Nobility
		public override int ArtifactRarity{ get{ return 11; } }

		public override int BasePhysicalResistance{ get{ return 25; } }
		public override int BaseEnergyResistance{ get{ return 20; } }

		public override int InitMinHits{ get{ return 255; } }
		public override int InitMaxHits{ get{ return 255; } }

		[Constructable]
		public TitansArmor()
		{
			Name = "Titans Armor";
			Hue = 0x482;
			Attributes.BonusStr = 5;
			Attributes.AttackChance = 5;
			Attributes.WeaponDamage = 5;
			Attributes.SpellDamage = 5;
			Attributes.Luck = 50;
		}

		public TitansArmor( Serial serial ) : base( serial )
		{
		}

		public override void Serialize( GenericWriter writer )
		{
			base.Serialize( writer );

			writer.Write( (int) 1 );
		}
		
		public override void Deserialize(GenericReader reader)
		{
			base.Deserialize( reader );

			int version = reader.ReadInt();

			if ( version < 1 )
			{
				if ( Hue == 0x562 )
					Hue = 0x4FE;

				PhysicalBonus = 0;
				PoisonBonus = 0;
			}
		}
	}
}