using System;

namespace Server.Items
{
    public class BronzedArmorOfValkyrie : FemaleLeatherChest
    {
        [Constructable]
        public BronzedArmorOfValkyrie()
        {
            this.Attributes.BonusHits = 5;
            this.Attributes.BonusStr = 5;
            this.Attributes.BonusDex = 5;
            this.Attributes.BonusStam = 5;
            this.Attributes.RegenStam = 5;
            this.Attributes.LowerManaCost = 10;
            this.Hue = 1457; // Hue not exact
            this.Name = ("Bronzed Armor of the Valkyrie");
        }

        public BronzedArmorOfValkyrie(Serial serial)
            : base(serial)
        {
        }

        public override int BasePhysicalResistance
        {
            get
            {
                return 15;
            }
        }
        public override int BaseFireResistance
        {
            get
            {
                return 10;
            }
        }
        public override int BaseColdResistance
        {
            get
            {
                return 10;
            }
        }
        public override int BasePoisonResistance
        {
            get
            {
                return 10;
            }
        }
        public override int BaseEnergyResistance
        {
            get
            {
                return 10;
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
            writer.Write((int)0);
        }

        public override void Deserialize(GenericReader reader)
        {
            base.Deserialize(reader);
            int version = reader.ReadInt();
        }
    }
}