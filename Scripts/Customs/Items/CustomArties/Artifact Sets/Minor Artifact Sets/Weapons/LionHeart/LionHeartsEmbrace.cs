using System;
using Server;

namespace Server.Items
{
	public class LionHeartsFury : Broadsword
	{
		public override int LabelNumber{ get{ return 1061598; } } // Shadow Dancer Needle
		
		public override int InitMinHits{ get{ return 255; } }
		public override int InitMaxHits{ get{ return 255; } }

		[Constructable]
		public LionHeartsFury()
		{
			Name = "Lion Hearts Fury";
			Hue = 0x501;
			Attributes.Luck = 95;
			Attributes.DefendChance = 15;
		}
		
		public LionHeartsFury( Serial serial ) : base( serial )
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
				if ( ItemID == 0x13CB )
					ItemID = 0x13D2;
			}
		}
	}
}