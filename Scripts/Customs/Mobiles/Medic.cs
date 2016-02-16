// Hireable Medic by Haazen Aug 2005  Requires NeRuns BaseHire.cs
using System;
using Server;
using Server.Items;
using Server.Spells;
using Server.Spells.First;
using Server.Mobiles;
using Server.Misc;
using System.Collections;

namespace Server.Mobiles
{

	[CorpseName( "a corpse" )]
	public class Medic : BaseHire
	{

		[Constructable]
		public Medic () : base( AIType.AI_Mage )
		{

                	Name = NameList.RandomName( "female" );
			Title = " the Medic";
			Body = 0x191;
			Female = true;
			Hue = 0x83EF;
			Blessed = true;
			ControlSlots = 3;

			SetStr( 400 );
			SetDex( 200 );
			SetInt( 400 );

			SetHits( 2500 );
			SetDamage( 25, 35 );

			SetSkill( SkillName.EvalInt, 200.0 );
			SetSkill( SkillName.Magery, 200.0 );
			SetSkill( SkillName.Meditation, 200.0 );
			SetSkill( SkillName.Anatomy, 300.0 );
			SetSkill( SkillName.Fencing, 200.0 );
			SetSkill( SkillName.MagicResist, 200.0 );
			SetSkill( SkillName.Tactics, 200.0 );

			AddItem( new PonyTail( Utility.RandomHairHue() ) );

			AddItem( new PlainDress( 1153 ) );

			AddItem( new ThighBoots() );

			AddItem( new Obi( 132 ) );
			AddItem( new TricorneHat( 1153 ) );

		}

		public override void GenerateLoot()
		{

		}


		public override void OnThink()
                {
				foreach ( Mobile m in this.GetMobilesInRange( 10 ) )                                                    
			if ( this.ControlMaster == m )
			{
           	 		if ( m.InRange( this, 10 ) ) 
            	 		{ 

					if ( m.Hits < (m.HitsMax - 15) )
					{
					if ( !new HealSpell( this, null ).Cast() )
						{
						new HealSpell( this, null ).Cast();
					m.Hits += 15; // increase here if you want more healing
						}
					}
				}
			}
	  	}
	

		public Medic( Serial serial ) : base( serial )
		{
		}



      		public override void Serialize( GenericWriter writer ) 
      		{ 
         	base.Serialize( writer ); 

         	writer.Write( (int) 0 ); // version 
      		} 

      		public override void Deserialize( GenericReader reader ) 
      		{ 
         	base.Deserialize( reader ); 

         	int version = reader.ReadInt(); 
		}
   	}
}
