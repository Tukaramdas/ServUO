using System;
using System.Collections.Generic;
using Server.Items;

namespace Server.Mobiles
{
    public class Cream : BaseVendor
    {
        private readonly List<SBInfo> m_SBInfos = new List<SBInfo>();
        [Constructable]
        public Cream()
            : base("Moisturizing Cream")
        {
            this.SetSkill(SkillName.EvalInt, 100.0);
            this.SetSkill(SkillName.Tactics, 70.0, 90.0);
            this.SetSkill(SkillName.Wrestling, 70.0, 90.0);
            this.SetSkill(SkillName.MagicResist, 70.0, 90.0);
            this.SetSkill(SkillName.Macing, 70.0, 90.0);
        }

        public Cream(Serial serial)
            : base(serial)
        {
        }

        protected override List<SBInfo> SBInfos
        {
            get
            {
                return this.m_SBInfos;
            }
        }
        public override void InitSBInfo()
        {
            this.m_SBInfos.Add(new SBCream());
        }

        public override void InitOutfit()
        {
            this.AddItem(new Sandals());
            this.AddItem(new MonkRobe());
        }

        public override void Serialize(GenericWriter writer)
        {
            base.Serialize(writer);

            writer.Write((int)0); // version
        }

        public override void Deserialize(GenericReader reader)
        {
            base.Deserialize(reader);

            int version = reader.ReadInt();
        }
    }
}