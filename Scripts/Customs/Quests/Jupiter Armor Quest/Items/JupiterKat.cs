//Created by Wicked2006
using System;
using Server;

namespace Server.Items

{
              
              public class JupiterKatana : Katana
              {
              public override int ArtifactRarity{ get{ return 1471; } } 
              public override int AosMinDamage{ get{ return 45; } }
              public override int AosMaxDamage{ get{ return 55; } }
              
                      [Constructable]
                      public JupiterKatana() 
                      {
                                        Weight = 0;
                                        Name = "Jupiter Katana";
                                        Hue = 1153;
              
                                        WeaponAttributes.DurabilityBonus = 50;
                                       WeaponAttributes.HitColdArea = 100;
                                        WeaponAttributes.HitDispel = 100;
                                        WeaponAttributes.HitEnergyArea = 100;
                                        WeaponAttributes.HitFireArea = 100;
                                        WeaponAttributes.HitHarm = 100;
                                        WeaponAttributes.HitLeechHits = 100;
                                        WeaponAttributes.HitLeechMana = 100;
                                        WeaponAttributes.HitLeechStam = 100;
                                        WeaponAttributes.HitLightning = 100;
                                        WeaponAttributes.HitLowerAttack = 100;
                                        WeaponAttributes.HitMagicArrow = 100;
                                        WeaponAttributes.HitPhysicalArea = 100;
                                        WeaponAttributes.HitPoisonArea = 100;
                                        WeaponAttributes.LowerStatReq = 100;
                                        WeaponAttributes.SelfRepair = 100;
                                        WeaponAttributes.UseBestSkill = 1;
              
                                        Attributes.AttackChance = 100;
                                        Attributes.BonusDex = 30;
                                        Attributes.BonusHits = 50;
                                        Attributes.BonusInt = 40;
                                        Attributes.BonusMana = 20 ;
                                        Attributes.BonusStam = 10;
                                       Attributes.CastRecovery = 1;
                                        Attributes.CastSpeed = 1;
                                        Attributes.DefendChance = 100;
                                        Attributes.EnhancePotions = 10;
                                        Attributes.LowerManaCost = 10;
                                        Attributes.LowerRegCost = 10;
                                        Attributes.Luck = 1000;
                                        Attributes.NightSight = 1;
                                       Attributes.ReflectPhysical = 100;
                                        Attributes.RegenHits = 10;
                                        Attributes.RegenMana = 10;
                                        Attributes.RegenStam = 10;
                                        Attributes.SpellChanneling = 1;
                                        Attributes.SpellDamage = 100;
                                        Attributes.WeaponDamage = 50;
                                        Attributes.WeaponSpeed = 100;
              
                                                      Slayer = SlayerName.Silver;
                                                      LootType = LootType.Blessed;
                                    }
              
                      public JupiterKatana( Serial serial ) : base( serial )  
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
