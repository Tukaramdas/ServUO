using System;
using Server.Items;

namespace Server.Items
{
	public class FishingPants : LongPants
	{
		public override SetItem SetID{ get{ return SetItem.Fishing; } }
		public override int Pieces{ get{ return 6; } }

		[Constructable]
		public FishingPants() : base()
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

		public FishingPants( Serial serial ) : base( serial )
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