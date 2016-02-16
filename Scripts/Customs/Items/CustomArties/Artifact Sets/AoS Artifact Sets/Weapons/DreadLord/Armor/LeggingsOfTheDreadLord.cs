using System;
using Server;

namespace Server.Items
{
	public class LeggingsOfTheDreadLord : StuddedLegs
	{
		public override int LabelNumber{ get{ return 1061107; } } // Arms of the Righteous
		public override int ArtifactRarity{ get{ return 10; } }
		
		public override int BasePoisonResistance{ get{ return 10; } }
		public override int BaseEnergyResistance{ get{ return 10; } }


		public override int InitMinHits{ get{ return 255; } }
		public override int InitMaxHits{ get{ return 255; } }

		[Constructable]
		public LeggingsOfTheDreadLord()
		{
			Name = "Leggings of the Dread Lord";
			Hue = 0x676;
			ArmorAttributes.MageArmor = 1;
			Attributes.CastRecovery = 2;
			Attributes.WeaponSpeed = 10;
			Attributes.WeaponDamage = 5;
		}

		public LeggingsOfTheDreadLord( Serial serial ) : base( serial )
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