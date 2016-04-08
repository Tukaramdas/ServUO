using System;
using Server.Items;

namespace Server.Items
{
	public class FishingGloves : LeatherGloves
	{
		public override SetItem SetID{ get{ return SetItem.Fishing; } }
		public override int Pieces{ get{ return 6; } }
	
		public override int BasePhysicalResistance{ get{ return 8; } }
		public override int BaseFireResistance{ get{ return 6; } }
		public override int BaseColdResistance{ get{ return 5; } }
		public override int BasePoisonResistance{ get{ return 7; } }
		public override int BaseEnergyResistance{ get{ return 4; } }
		public override int InitMinHits{ get{ return 255; } }
		public override int InitMaxHits{ get{ return 255; } }

		[Constructable]
		public FishingGloves() : base()
		{
			SetHue = 1177;	
			Weight = 2;	
			
			Attributes.BonusStr = 1;
			Attributes.BonusInt = 1;
			
			SetAttributes.BonusStr = 10;
			SetAttributes.BonusInt = 10;
			SetAttributes.DefendChance = 15;			
			SetPhysicalBonus = 35;
			SetFireBonus = 35;
			SetColdBonus = 35;
			SetPoisonBonus = 35;
			SetEnergyBonus = 35;
		}

		public FishingGloves( Serial serial ) : base( serial )
		{
		}
		
		public override void Serialize( GenericWriter writer )
		{
			base.Serialize( writer );
			
			writer.Write( (int) 0 ); // version
		}
		
		public override void Deserialize(GenericReader reader)
		{
			base.Deserialize( reader );
			
			int version = reader.ReadInt();
		}
	}
}