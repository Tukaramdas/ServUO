//Created with Script Creator By Marak & Rockstar
//Kevin Evans helped too xD
using System;
using Server.Network;
using Server.Items;
using Server.Targeting;

namespace Server.Items
{
	public class TheSash : BodySash
  {
public override int ArtifactRarity{ get{ return 10; } }


      
      [Constructable]
		public TheSash()
		{
			Weight = 1;
          Name = "The Sash";
          Hue = 40;
      Attributes.BonusHits = 25;
      Attributes.BonusMana = 25;
      Attributes.BonusStam = 25;
      Attributes.RegenHits = 5;
      Attributes.RegenMana = 5;
      Attributes.RegenStam = 5;
      Attributes.CastRecovery = 6;
      Attributes.CastSpeed = 4;
      Attributes.LowerManaCost = 50;
      Attributes.Luck = 1000;
      Attributes.NightSight = 1;
      LootType = LootType.Blessed;
		}

		public TheSash( Serial serial ) : base( serial )
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
