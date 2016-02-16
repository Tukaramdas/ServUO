
using System;
using Server;
using Server.Items;

namespace Server.Items
{
    public class Armsofjupiter :PlateArms
    {
        [Constructable]
        public Armsofjupiter()
        {
            
            this.Hue = 1152;
            this.Name = "Arms of jupiter";

            this.Attributes.AttackChance = 56;
            this.Attributes.BonusDex = 45;
            this.Attributes.BonusHits = 34;
            this.Attributes.BonusInt = 35;
            this.Attributes.BonusMana = 36;
            this.Attributes.BonusStam = 35;
            this.Attributes.CastRecovery = 4;
            this.Attributes.CastSpeed = 6;
            this.Attributes.DefendChance = 45;
            this.Attributes.EnhancePotions = 75;
            this.Attributes.LowerManaCost = 75;
            this.Attributes.LowerRegCost = 50;
            this.Attributes.Luck = 100;
            this.Attributes.NightSight = 1;
            this.Attributes.ReflectPhysical = 50;
            this.Attributes.RegenHits = 25;
            this.Attributes.RegenMana = 30;
            this.Attributes.RegenStam = 30;
            this.Attributes.SpellDamage = 50;
            this.Attributes.WeaponDamage = 55;

            this.ArmorAttributes.DurabilityBonus = 100;
            this.ArmorAttributes.SelfRepair = 100;

            this.ColdBonus = 35;
            this.EnergyBonus = 35;
            this.FireBonus = 30;
            this.PhysicalBonus = 36;
            this.PoisonBonus = 30;
            this.StrBonus = 35;

            this.LootType = LootType.Blessed;
        }

        public Armsofjupiter( Serial serial ) : base( serial )
        {
        }

		public override int ArtifactRarity{ get{ return 100; } }
             
        public override void Serialize( GenericWriter writer )
        {
            base.Serialize( writer );
            writer.Write( (int) 0 );
        }
              
        public override void Deserialize(GenericReader reader)
        {
            base.Deserialize( reader );
            int version = reader.ReadInt();
        }
    }
}