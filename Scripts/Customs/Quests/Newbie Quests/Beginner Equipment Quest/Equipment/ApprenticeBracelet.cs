using System;
using Server;

namespace Server.Items
{
	public class ApprenticeBracelet : SilverBracelet
	{

		[Constructable]
		public ApprenticeBracelet()
		{
			Name = "Apprentice Bracelet";
						
			Attributes.BonusDex = 5;
			Attributes.RegenStam = 3;
			Attributes.CastSpeed = 1;
            Attributes.LowerRegCost = 20;
            LootType = LootType.Blessed;
			
		}

		public ApprenticeBracelet( Serial serial ) : base( serial )
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