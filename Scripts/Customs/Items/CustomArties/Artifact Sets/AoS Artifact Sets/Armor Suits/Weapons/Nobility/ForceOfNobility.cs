using System;
using Server;

namespace Server.Items
{
	public class ForceOfNobility : Scimitar
	{
		public override int LabelNumber{ get{ return 1061092; } } // Force of Nobility
		public override int ArtifactRarity{ get{ return 11; } }

		//public override int BasePhysicalResistance{ get{ return 22; } } These were used to calculate the Damage Types Below
		//public override int BasePoisonResistance{ get{ return 25; } }

		public override int InitMinHits{ get{ return 255; } }
		public override int InitMaxHits{ get{ return 255; } }

		[Constructable]
		public ForceOfNobility()
		{
			Name = "Force of Noility";
			Hue = 0x4FE;
			Attributes.RegenHits = 3;
			Attributes.BonusStr = 10;
			Attributes.Luck = 100;
			Attributes.WeaponDamage = 20;
		}
		
		public override void GetDamageTypes( Mobile wielder, out int phys, out int fire, out int cold, out int pois, out int nrgy, out int chaos, out int direct )
		{
			phys = 65;
			pois = 35;
			fire = nrgy = cold = chaos = direct = 0;
		}

		public ForceOfNobility( Serial serial ) : base( serial )
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
			}
		}
	}
}