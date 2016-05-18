using System;
using Server;

namespace Server.Items
{

        public class PirateCutlass : Cutlass
        {

        public override int InitMinHits{ get{ return 200; } }
        public override int InitMaxHits{ get{ return 300; } }
                
                [Constructable]
                public PirateCutlass()
                {
                        Name = "Pirate Cutlass";
                        Hue = 1158;
                        WeaponAttributes.SelfRepair = 5;
                        WeaponAttributes.HitLightning = 35;
                        WeaponAttributes.HitHarm = 20;
                        WeaponAttributes.HitLeechStam = 25;
                        //WeaponAttributes.HitPoisonArea = 45;
                        Attributes.Luck = 150;
                        Attributes.WeaponSpeed = 40;
                        Attributes.WeaponDamage = 50;
                        Attributes.SpellChanneling = 1;
                        Attributes.CastSpeed = 2;
                        Attributes.CastRecovery = 3;
                        LootType = LootType.Blessed;
                        
                }

                public PirateCutlass( Serial Serial ) : base ( Serial )
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
                        