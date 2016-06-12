using System;
namespace Server.Items
{
    [FlipableAttribute(0x26C3, 0x26CD)]
    public class HargrovesHarpoon : BaseRanged
    {
        public HargrovesHarpoon(Serial serial) : base(serial) { }

        public override int EffectID { get { return 0x1BFE; } }

        public override SkillName DefSkill { get { return SkillName.Fishing; } }

        public override Type AmmoType { get { return typeof(Harpoon); } }

        public override Item Ammo { get { return new Harpoon(); } }

        public override WeaponAbility PrimaryAbility { get { return WeaponAbility.DoubleStrike; } }

        public override WeaponAbility SecondaryAbility { get { return WeaponAbility.MovingShot; } }

        public override int AosStrengthReq { get { return 30; } }
        public override int AosMinDamage { get { return 24; } }
        public override int AosMaxDamage { get { return 30; } }
        public override int AosSpeed { get { return 48; } }

        public override float MlSpeed { get { return 3f; } }

        public override int OldStrengthReq { get { return 30; } }
        public override int OldMinDamage { get { return 10; } }
        public override int OldMaxDamage { get { return 12; } }
        public override int OldSpeed { get { return 41; } }

        public override int DefMaxRange { get { return 8; } }

        public override int InitMinHits { get { return 255; } }
        public override int InitMaxHits { get { return 255; } }

        [Constructable]
        public HargrovesHarpoon() : base(0x26C3)
        {
            this.Name = "Hargorve's Harpoon";
            this.Hue = 1175;
            this.Weight = 4.0;
       


            WeaponAttributes.HitLeechHits = 40;
            WeaponAttributes.HitLeechMana = 50;
            WeaponAttributes.HitLeechStam = 20;
            WeaponAttributes.HitLightning = 50;
            WeaponAttributes.SelfRepair = 10;

            Attributes.AttackChance = 20;
            Attributes.BonusStr = 15;
            Attributes.CastRecovery = 2;
            Attributes.CastSpeed = 2;
            Attributes.Luck = 500;
            Attributes.SpellChanneling = 1;
            Attributes.SpellDamage = 10;
            Attributes.WeaponDamage = 20;
            Attributes.WeaponSpeed = 20;
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

