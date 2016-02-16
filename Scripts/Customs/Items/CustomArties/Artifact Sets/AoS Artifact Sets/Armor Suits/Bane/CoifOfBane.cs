using System;
using Server;

namespace Server.Items
{
	public class CoifOfBane : ChainCoif
	{
		public override int LabelNumber{ get{ return 1061100; } } // Coif of Bane
		public override int ArtifactRarity{ get{ return 11; } }

		public override int BasePoisonResistance{ get{ return 16; } }

		public override int InitMinHits{ get{ return 255; } }
		public override int InitMaxHits{ get{ return 255; } }

		[Constructable]
		public CoifOfBane()
		{
			Name = "Coif of Bane";
			Hue = 0x4F5;
			ArmorAttributes.DurabilityBonus = 100;
			this.HitPoints = this.MaxHitPoints = 255;	//Cause the Durability bonus and such and the min/max hits as well as all other hits being whole #'s...
			Attributes.BonusStam = 8;
			Attributes.AttackChance = 20;
		}

		public CoifOfBane( Serial serial ) : base( serial )
		{
		}

		public override void Serialize( GenericWriter writer )
		{
			base.Serialize( writer );

			writer.Write( (int) 2 );
		}
		
		public override void Deserialize(GenericReader reader)
		{
			base.Deserialize( reader );

			int version = reader.ReadInt();

			if( version <= 1 )
			{
				if( this.HitPoints > 255 || this.MaxHitPoints > 255 )
					this.HitPoints = this.MaxHitPoints = 255;
			}

			if ( version < 1 )
			{
				if ( Hue == 0x559 )
					Hue = 0x4F5;

				if ( ArmorAttributes.DurabilityBonus == 0 )
					ArmorAttributes.DurabilityBonus = 100;

				PoisonBonus = 0;
			}
		}
	}
}