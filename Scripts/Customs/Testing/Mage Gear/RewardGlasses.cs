using System;
using Server;
using Server.Engines.VeteranRewards;

namespace Server.Items
{
    public class RewardGlasses : ElvenGlasses, IRewardItem
	{
		private bool m_IsRewardItem;
      [CommandProperty(AccessLevel.GameMaster)]
      public bool IsRewardItem
      {
          get { return m_IsRewardItem; }
          set { m_IsRewardItem = value; InvalidateProperties(); }
      }

		public override int BasePhysicalResistance{ get{ return 0; } }
		public override int BaseFireResistance{ get{ return 0; } }
		public override int BaseColdResistance{ get{ return 0; } }
		public override int BasePoisonResistance{ get{ return 0; } }
		public override int BaseEnergyResistance{ get{ return 0; } }

		public override int InitMinHits{ get{ return 255; } }
		public override int InitMaxHits{ get{ return 255; } }

		[Constructable]
        public RewardGlasses()
		{
            Name = "Mage Wear Glasses";
			Attributes.BonusMana = 3;
			Attributes.RegenMana = 2;
            Attributes.LowerRegCost = 10;
			Attributes.SpellDamage = 5;
           // Layer = Layer.Unused_xF;
			Hue = 0x5c;
            SkillBonuses.SetValues(0, SkillName.Magery, 2.0);
		}
        public RewardGlasses(Serial serial)
            : base(serial)
		{
		}

        public override bool OnEquip(Mobile from)
        {
            if (m_IsRewardItem && !RewardSystem.CheckIsUsableBy(from, this, null))
            {
                from.SendMessage("This does not belong to you!!");
                return false;
            }
            return base.OnEquip(from);
        }

		public override void Serialize( GenericWriter writer )
		{
			base.Serialize( writer );
			writer.Write( (int) 1 );
            writer.Write((bool)m_IsRewardItem);
		}
		
		public override void Deserialize(GenericReader reader)
		{
			base.Deserialize( reader );
			int version = reader.ReadInt();
            m_IsRewardItem = reader.ReadBool();
			if ( version == 0 && Hue == 0 )
				Hue = 0x2B0;
		}
	}
}
