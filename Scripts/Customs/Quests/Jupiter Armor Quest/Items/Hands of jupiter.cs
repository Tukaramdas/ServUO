
using System;
using Server;
using Server.Items;

namespace Server.Items
{
    public class Glovesofjupiter : PlateGloves
    {
        [Constructable]
        public Glovesofjupiter()
        {
            
            this.Hue = 1152;
            this.Name = "Gloves of jupiter";

            this.Attributes.AttackChance = 75;
            this.Attributes.BonusDex = 55;
            this.Attributes.BonusHits = 45;
            this.Attributes.BonusInt = 50;
            this.Attributes.BonusMana = 46;
            this.Attributes.BonusStam = 45;
            this.Attributes.CastRecovery = 5;
            this.Attributes.CastSpeed = 7;
            this.Attributes.DefendChance = 55;
            this.Attributes.EnhancePotions = 85;
            this.Attributes.LowerManaCost = 85;
            this.Attributes.LowerRegCost = 60;
            this.Attributes.Luck = 100;
            this.Attributes.NightSight = 1;
            this.Attributes.ReflectPhysical = 60;
            this.Attributes.RegenHits = 35;
            this.Attributes.RegenMana = 35;
            this.Attributes.RegenStam = 35;
            this.Attributes.SpellDamage = 60;
            this.Attributes.WeaponDamage = 65;

            this.ArmorAttributes.DurabilityBonus = 100;
            this.ArmorAttributes.SelfRepair = 100;

            this.ColdBonus = 45;
            this.EnergyBonus = 45;
            this.FireBonus = 35;
            this.PhysicalBonus = 46;
            this.PoisonBonus = 35;
            this.StrBonus = 35;

            this.LootType = LootType.Blessed;
        }

        public Glovesofjupiter( Serial serial ) : base( serial )
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