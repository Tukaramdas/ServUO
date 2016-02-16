using System;
using Server.Items;

namespace Server.Items
{
	[FlipableAttribute( 0x1414, 0x1418 )]
	public class OrcGloves : BaseArmor
	{
		public override int BasePhysicalResistance{ get{ return 8; } }
		public override int BaseFireResistance{ get{ return 4; } }
		public override int BaseColdResistance{ get{ return 2; } }
		public override int BasePoisonResistance{ get{ return 4; } }
		public override int BaseEnergyResistance{ get{ return 2; } }

		public override int InitMinHits{ get{ return 70; } }
		public override int InitMaxHits{ get{ return 90; } }

		public override int AosStrReq{ get{ return 120; } }
		public override int OldStrReq{ get{ return 120; } }

		public override int OldDexBonus{ get{ return -2; } }

		public override int ArmorBase{ get{ return 40; } }

		public override ArmorMaterialType MaterialType{ get{ return ArmorMaterialType.Plate; } }

		[Constructable]
		public OrcGloves() : base( 0x1414 )
		{
                        Name = "orcish Gloves";
			Hue = 0x455;
			Weight = 2.0;
		}

		public OrcGloves( Serial serial ) : base( serial )
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

			if ( Weight == 1.0 )
				Weight = 2.0;
		}
	}
}