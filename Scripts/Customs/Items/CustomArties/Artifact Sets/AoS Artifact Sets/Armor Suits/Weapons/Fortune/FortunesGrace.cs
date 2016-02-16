using System;
using Server;

namespace Server.Items
{
	public class FortunesGrace : LightweightShortbow
	{
		public override int LabelNumber{ get{ return 1061098; } } // Arms of Fortune
		public override int ArtifactRarity{ get{ return 11; } }

		public override int InitMinHits{ get{ return 255; } }
		public override int InitMaxHits{ get{ return 255; } }

		[Constructable]
		public FortunesGrace()
		{
			Name = "Fortune's Grace";
			Hue = 0x501;
			Attributes.Luck = 250;
			Attributes.LowerRegCost = 25;
			Attributes.SpellChanneling = 1;
		}
		
		public override void GetDamageTypes( Mobile wielder, out int phys, out int fire, out int cold, out int pois, out int nrgy, out int chaos, out int direct )
		{
			phys = 80;
			nrgy = 20;
			fire = pois = cold = chaos = direct = 0;
		}

		public FortunesGrace( Serial serial ) : base( serial )
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