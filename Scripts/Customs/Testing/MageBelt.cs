using System;
using Server.Network;
using Server.Items;
using Server.Targeting;

namespace Server.Items
{
    [FlipableAttribute(0x2790, 0x27DB)]
    public class MageBelt : BaseWaist, IDyable, ITokunoDyable
  {
		public override int InitMinHits{ get{ return 255; } }
		public override int InitMaxHits{ get{ return 255; } }

	/*	public override int BaseColdResistance{ get{ return 21; } } 
		public override int BaseEnergyResistance{ get{ return 22; } } 
		public override int BasePhysicalResistance{ get{ return 22; } } 
		public override int BasePoisonResistance{ get{ return 28; } } 
		public override int BaseFireResistance{ get{ return 22; } } 
    */
      
      [Constructable]
		public MageBelt() : base(0x2790)
        {
            Name = "Mage Belt";
            Hue = 2062;
            Weight = 1;
            Layer = Layer.Waist;
            
            Attributes.BonusMana = 15;
            Attributes.SpellDamage = 50;
            Attributes.Luck = 1000;
            Attributes.BonusHits = 25;
            Attributes.BonusMana = 25;
            Attributes.BonusStam = 25;
            Attributes.RegenHits = 5;
            Attributes.RegenMana = 5;
            Attributes.RegenStam = 5;
            Attributes.CastRecovery = 6;
            Attributes.CastSpeed = 4;
            Attributes.LowerManaCost = 50;
            Attributes.NightSight = 1;
        //    Attributes.SoulCharge = 50;
            LootType = LootType.Blessed;
        }

		public MageBelt( Serial serial ) : base( serial )
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
