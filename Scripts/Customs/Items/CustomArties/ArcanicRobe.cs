using System;
using Server.Network;
using Server.Items;
using Server.Targeting;

namespace Server.Items
{
	public class ArcanicRobe : Robe, ITokunoDyable

  {
      public override int ArtifactRarity{ get{ return 12; } }
      [Constructable]
		public ArcanicRobe()
		{

          Name = "Arcanic Robe";
          Hue = 1150;
      Attributes.CastRecovery = 2;
      Attributes.CastSpeed = 2;
      Attributes.LowerRegCost = 15;
      Attributes.LowerManaCost = 15;
      Attributes.Luck = 295;
		}

		public ArcanicRobe( Serial serial ) : base( serial )
		{
		}

		public override void Serialize( GenericWriter writer )
		{
			base.Serialize( writer );
			writer.Write( (int) 0 ); // version
		}

		public override void Deserialize( GenericReader reader )
		{
			base.Deserialize( reader );

			int version = reader.ReadInt();
		}
	}
}
