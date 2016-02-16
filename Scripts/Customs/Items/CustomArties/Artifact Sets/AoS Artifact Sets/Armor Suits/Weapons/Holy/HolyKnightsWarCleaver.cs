using System;
using Server;

namespace Server.Items
{
	public class HolyKnightsWarCleaver : WarCleaver
	{
		public override int LabelNumber{ get{ return 1061097; } } // Holy Knight's WarCleaver
		public override int ArtifactRarity{ get{ return 11; } }

		public override int InitMinHits{ get{ return 255; } }
		public override int InitMaxHits{ get{ return 255; } }

		[Constructable]
		public HolyKnightsWarCleaver()
		{
			Name = "Holy Knight's War Cleaver";
			Hue = 0x47E;
			Attributes.BonusHits = 10;
			Attributes.ReflectPhysical = 15;
		}
		
		public override void GetDamageTypes( Mobile wielder, out int phys, out int fire, out int cold, out int pois, out int nrgy, out int chaos, out int direct )
		{
			phys = 90;
			nrgy = 10;

			fire = cold = pois = chaos = direct = 0;
		}

		public HolyKnightsWarCleaver( Serial serial ) : base( serial )
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
		}
	}
}