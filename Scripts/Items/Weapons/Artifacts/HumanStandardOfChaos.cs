using System;

namespace Server.Items
{
    [FlipableAttribute(0x26BF, 0x26C9)]
    public class HumanStandardOfChaos : DoubleBladedStaff 
    {
        [Constructable]
        public HumanStandardOfChaos()
        {
            this.Name = ("Standard Of Chaos");
		
            this.Hue = 2209;
			
            this.WeaponAttributes.HitHarm = 30;	
            this.WeaponAttributes.HitFireball = 20;	
            this.WeaponAttributes.HitLightning = 10;
            this.WeaponAttributes.HitLowerDefend = 40;
            this.Attributes.WeaponSpeed = 30;
            this.Attributes.WeaponDamage = -40;
            this.Attributes.CastSpeed = 1;
            this.AosElementDamages.Chaos = 100;
        }

        public HumanStandardOfChaos(Serial serial)
            : base(serial)
        {
        }

		public override int AosMinDamage
		{
			get
			{
				return 12;
			}
		}

		public override int AosMaxDamage
		{
			get
			{
				return 13;
			}
		}

        //TODO: DoubleBladedSpear
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