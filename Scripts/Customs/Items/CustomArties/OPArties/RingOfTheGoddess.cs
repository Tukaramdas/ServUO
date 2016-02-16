using System;
using Server;
using Server.Items;

namespace Server.Items
{
              public class RingOfTheGoddess: SilverRing

{
             public override int ArtifactRarity{ get{ return 19; } } 

              [Constructable]
              public RingOfTheGoddess()
{

                          Weight = 1 ;
                          Name = "Ring of The Goddess";
                          Hue = 1150;
              
                        Attributes.NightSight = 1;
			Attributes.Luck = 10000;
			Attributes.CastSpeed  = 10;	
			Attributes.CastRecovery  = 10;
			Attributes.LowerRegCost = 100;		
			Resistances.Fire = 100;
			Resistances.Cold = 100;
			Resistances.Poison = 100;
			Resistances.Energy = 100;
                        Resistances.Physical = 100;
                        LootType = LootType.Blessed;

                  }
              public RingOfTheGoddess( Serial serial ) : base( serial )
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
