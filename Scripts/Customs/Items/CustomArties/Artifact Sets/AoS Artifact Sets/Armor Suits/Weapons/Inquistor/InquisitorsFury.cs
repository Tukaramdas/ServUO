using System;
using Server;

namespace Server.Items
{
	public class InquisitorsFury : ElvenMachete
	{
		public override int LabelNumber{ get{ return 1060206; } } // The Inquisitor's Fury
		public override int ArtifactRarity{ get{ return 10; } }

		public override int InitMinHits{ get{ return 255; } }
		public override int InitMaxHits{ get{ return 255; } }

		[Constructable]
		public InquisitorsFury()
		{
			Name = "The Inquisitor's Fury";
			Hue = 0x4F2;
			Attributes.CastRecovery = 3;
			Attributes.LowerManaCost = 5;
			Attributes.SpellChanneling = 1;
		}

		public override void GetDamageTypes( Mobile wielder, out int phys, out int fire, out int cold, out int pois, out int nrgy, out int chaos, out int direct )
		{
			phys = 75;
			cold = 15;
			nrgy = 10;
			fire = pois = chaos = direct = 0;
		}
		
		public InquisitorsFury( Serial serial ) : base( serial )
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