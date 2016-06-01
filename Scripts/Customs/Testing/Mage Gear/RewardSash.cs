using System;
using Server;
using Server.Engines.VeteranRewards;

namespace Server.Items
{
    public class RewardSash : BodySash, IDyable, IRewardItem
	{
        private bool m_IsRewardItem;
        [CommandProperty(AccessLevel.GameMaster)]
        public bool IsRewardItem
        {
            get { return m_IsRewardItem; }
            set { m_IsRewardItem = value; InvalidateProperties(); }
        }

		[Constructable]
		public RewardSash()
		{
			Name = "Mage Wear Sash";
            Attributes.BonusMana = 3;
            Attributes.RegenMana = 2;
            Attributes.LowerRegCost = 10;
            Attributes.SpellDamage = 5;
            Hue = 0x5c;
			SkillBonuses.SetValues( 0, SkillName.Magery, 2.0 );
		}

        public RewardSash(Serial serial)
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

        public override void Serialize(GenericWriter writer)
        {
            base.Serialize(writer);
            writer.Write((int)0); // version
            writer.Write((bool)m_IsRewardItem);
        }

        public override void Deserialize(GenericReader reader)
        {
            base.Deserialize(reader);
            int version = reader.ReadInt();
            m_IsRewardItem = reader.ReadBool();
        }
		
		
	}
}