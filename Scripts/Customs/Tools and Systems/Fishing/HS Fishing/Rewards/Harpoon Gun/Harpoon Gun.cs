using System;

namespace Server.Items
{
    [FlipableAttribute(0x26C3, 0x26CD)]
    public class HarpoonGun : BaseRanged
    {
        [Constructable]
        public HarpoonGun()
            : base(0x26C3)
        {
        	this.Name = "a harpoon gun";
        	this.Hue = 1175;
            this.Weight = 6.0;
        }

        public HarpoonGun(Serial serial)
            : base(serial)
        {
        }

        public override int EffectID
        {
            get
            {
                return 0x1BFE;
            }
        }
        public override SkillName DefSkill
        {
            get
            {
                return SkillName.Fishing;
            }
        }
        public override Type AmmoType
        {
            get
            {
                return typeof( Harpoon );
            }
        }
        public override Item Ammo
        {
            get
            {
                return new Harpoon();
            }
        }
        public override WeaponAbility PrimaryAbility
        {
            get
            {
                return WeaponAbility.DoubleStrike;
            }
        }
        public override WeaponAbility SecondaryAbility
        {
            get
            {
                return WeaponAbility.MovingShot;
            }
        }
        public override int AosStrengthReq
        {
            get
            {
                return 30;
            }
        }
        public override int AosMinDamage
        {
            get
            {
                return 24;
            }
        }
        public override int AosMaxDamage
        {
            get
            {
                return 30;
            }
        }
        public override int AosSpeed
        {
            get
            {
                return 48;
            }
        }
        public override float MlSpeed
        {
            get
            {
                return 6.75f;
            }
        }
        public override int OldStrengthReq
        {
            get
            {
                return 30;
            }
        }
        public override int OldMinDamage
        {
            get
            {
                return 10;
            }
        }
        public override int OldMaxDamage
        {
            get
            {
                return 12;
            }
        }
        public override int OldSpeed
        {
            get
            {
                return 41;
            }
        }
        public override int DefMaxRange
        {
            get
            {
                return 8;
            }
        }
        public override int InitMinHits
        {
            get
            {
                return 255;
            }
        }
        public override int InitMaxHits
        {
            get
            {
                return 255;
            }
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