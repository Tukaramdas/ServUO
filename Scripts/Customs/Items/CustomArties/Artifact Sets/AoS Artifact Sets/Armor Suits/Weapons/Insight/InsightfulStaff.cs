using System;
using Server;

namespace Server.Items
{
	public class InsightfulStaff : BlackStaff
	{
		public override int LabelNumber{ get{ return 1061096; } } // Insightful Staff
		public override int ArtifactRarity{ get{ return 11; } }

		public override int InitMinHits{ get{ return 255; } }
		public override int InitMaxHits{ get{ return 255; } }

		[Constructable]
		public InsightfulStaff()
		{
			Name = "Insightful Staff";
			Hue = 0x554;
			Attributes.BonusInt = 10;
			Attributes.BonusMana = 5;
			Attributes.RegenMana = 2;
			Attributes.LowerManaCost = 5;
			Attributes.SpellChanneling = 1;
		}
		
		public override void GetDamageTypes( Mobile wielder, out int phys, out int fire, out int cold, out int pois, out int nrgy, out int chaos, out int direct )
		{
			phys = 75;
			nrgy = 25;
			cold = fire = pois = chaos = direct = 0;
		}

		public InsightfulStaff( Serial serial ) : base( serial )
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