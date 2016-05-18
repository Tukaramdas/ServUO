///Talon Nyte///
using System;
using Server;

namespace Server.Items
{
	public class AbyssShield : BaseShield
	{
                public override int ArtifactRarity { get { return 60; } }
		public override int BasePhysicalResistance{ get{ return 10; } }
		public override int BaseFireResistance{ get{ return 10; } }
		public override int BaseColdResistance{ get{ return 10; } }
		public override int BasePoisonResistance{ get{ return 10; } }
		public override int BaseEnergyResistance{ get{ return 10; } }

		public override int InitMinHits{ get{ return 150; } }
		public override int InitMaxHits{ get{ return 400; } }

		public override int AosStrReq{ get{ return 0; } }

		public override int ArmorBase{ get{ return 400; } }

        

		[Constructable]
        public AbyssShield()
            : base(0x2B01)
		{
            Name = "Abyss Shield";
		    Hue = 1172;
            Weight = 3.0;
         Attributes.LowerRegCost = 25;
         Attributes.CastRecovery = Utility.RandomMinMax(3, 7);
         Attributes.CastSpeed = Utility.RandomMinMax(2, 10);
         Attributes.SpellDamage = Utility.RandomMinMax(15, 35);
         Attributes.Luck = Utility.RandomMinMax(100, 500);
         Attributes.BonusStr = Utility.RandomMinMax(15, 35);
         Attributes.WeaponSpeed = Utility.RandomMinMax(15, 35);
         Attributes.SpellChanneling = 1;

            PhysicalBonus = Utility.RandomMinMax(10, 30);
            ColdBonus = Utility.RandomMinMax(10, 30);
            EnergyBonus = Utility.RandomMinMax(10, 30);
            PoisonBonus = Utility.RandomMinMax(10, 30);
            FireBonus =   Utility.RandomMinMax(10, 30);
		}

        public AbyssShield(Serial serial)
            : base(serial)
		{
		}

		public override void Deserialize( GenericReader reader )
		{
			base.Deserialize( reader );

			int version = reader.ReadInt();
		}

		public override void Serialize( GenericWriter writer )
		{
			base.Serialize( writer );

			writer.Write( (int)0 );//version
		}
	}
}
