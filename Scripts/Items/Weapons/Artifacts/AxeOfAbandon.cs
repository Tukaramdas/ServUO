using System;

namespace Server.Items
{
    [FlipableAttribute(0xF47, 0xF48)]
    public class AxeOfAbandon : BattleAxe
    {
        [Constructable]
        public AxeOfAbandon() 
        {
            this.Name = ("Axe Of Abandon");
		
            this.Hue = 556;	
		
            this.WeaponAttributes.HitLowerDefend = 40;
            this.WeaponAttributes.BattleLust = 1;		
            this.Attributes.AttackChance = 15;
            this.Attributes.DefendChance = 10;	
            this.Attributes.CastSpeed = 1;	
            this.Attributes.WeaponSpeed = 30;
            this.Attributes.WeaponDamage = 50;
			this.StrRequirement = 80;
        }

        public AxeOfAbandon(Serial serial)
            : base(serial)
        {
        }

		public override int AosMinDamage
		{
			get
			{
				return 16;
			}
		}

		public override int AosMaxDamage
		{
			get
			{
				return 17;
			}
		}

		public override float MlSpeed
		{
			get
			{
				return 3.75f;
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