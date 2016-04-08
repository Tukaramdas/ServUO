using System;
using Server;
using Server.Items;

namespace Server.Items
{
    public class Fortifiedarms : BoneArms, ITokunoDyable
    {
	public override int ArtifactRarity { get { return 15; } }
	
        [Constructable]
        public Fortifiedarms()
        {
         Hue = 1165;
         Name = "Fortified Arms";

            Attributes.AttackChance = 15;
            Attributes.BonusDex = 5;
            Attributes.DefendChance = 10;
            Attributes.EnhancePotions = 20;
            Attributes.NightSight = 1;
            ArmorAttributes.SelfRepair = 5;

            ColdBonus = 10;
            EnergyBonus = 15;
            FireBonus = 18;
            PhysicalBonus = 19;
            PoisonBonus = 15;
            StrBonus = 10;

        }

        public Fortifiedarms( Serial serial ) : base( serial )
        {
        }
        
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