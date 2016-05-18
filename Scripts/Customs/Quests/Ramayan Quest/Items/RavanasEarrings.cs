//=================================================
//This script was created by Gizmo's Uo Quest Maker
//This script was created on 5/15/2016 09:09:54
//=================================================

using System;
using Server;

namespace Server.Items
{
	public class RavanasEarrings : GoldEarrings
	{

		[Constructable]
		public RavanasEarrings()
		{
			Name = "Ravana's Earrings";
            Hue = 1281;
        }

		public RavanasEarrings( Serial serial ) : base( serial )
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
