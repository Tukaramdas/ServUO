using System;
using Server;

namespace Server.Items
{
	public class TitansFolly : OrnateAxe
	{
		public override int ArtifactRarity{ get{ return 10; } }
		
		public override int InitMinHits{ get{ return 255; } }
		public override int InitMaxHits{ get{ return 255; } }

		[Constructable]
		public TitansFolly()
		{
			
			Name = "Titan's Folly";
			Hue = 2213;
			Weight = 9.0;
			Slayer = SlayerName.Repond;
			Attributes.Luck = 50;
			Attributes.WeaponSpeed = 20;
			WeaponAttributes.ResistEnergyBonus = 10;
		}

		public override void GetDamageTypes( Mobile wielder, out int phys, out int fire, out int cold, out int pois, out int nrgy, out int direct, out int chaos )
		{

			cold = fire = phys = pois = nrgy = 20;
			direct = chaos = 0;
		}

		public TitansFolly( Serial serial ) : base( serial )
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