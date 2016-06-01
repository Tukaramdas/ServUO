using System;
using Server;
using Server.Items;
using System.Collections;


namespace Server.Mobiles
{

	[CorpseName( "corpse war" )]
	public class War : BaseCreature
	{

	private static bool m_Talked;

        string[] kfcsay = new string[]
        { 
		 "I Am War!",
		 "The End Of Days Is Among Us",
		 "Welcome The Apocalypse ",
		 "I am one of the 4 horseman of the APOCALYPSE",
           
	}; 

		[Constructable]
		public War () : base( AIType.AI_Melee, FightMode.Closest, 10, 1, 0.2, 0.4 )
		{
			Name = "War";
            Title = "    The 2nd Horseman";
			Body = 400;
			SpeechHue = 2128;
			Hue = 32;
			VirtualArmor = 45;
			Kills = 10;

            SetStr(125);
            SetDex(251);
            SetInt(130);

            SetHits(12000);
            SetDamage(25, 45);
            SetDamageType(ResistanceType.Poison, 100);

            SetResistance(ResistanceType.Physical, 45, 55);
            SetResistance(ResistanceType.Fire, 45, 55);
            SetResistance(ResistanceType.Cold, 45, 55);
            SetResistance(ResistanceType.Energy, 45, 55);
            SetResistance(ResistanceType.Poison, 100);

            SetSkill(SkillName.Wrestling, 85.0, 92.5);
            SetSkill(SkillName.Tactics, 78.5, 87.2);
            SetSkill(SkillName.Anatomy, 68.7, 85.6);
            SetSkill(SkillName.Fencing, 92.5, 95.6);

			Fame = 0;
			Karma = -10000;
            Item Weapon = new SwordOfWar();

            Weapon.Movable = false;

            AddItem(Weapon);
           // PackItem(new MasterCoin(40));

            VirtualArmor = 30;

            new RedHorse().Rider = this;

			
            


			Item apron = new HalfApron( 1 );
            apron.Movable = false;
			AddItem( apron );

			Item hair = new ShortHair( 32 );
			hair.Movable = false;
			AddItem( hair );

			Item shoes = new Sandals( 32 );
            shoes.Movable = false;
			AddItem( shoes );

			Item mask = new OrcishKinMask(32);
           mask.Movable = false;
			AddItem( mask );

			Item robe = new Robe( 32 );
			robe.Movable = false;
			AddItem( robe );
			
			Item gloves = new LeatherGloves();
			gloves.Movable = false;
			gloves.Hue = 32;
			AddItem( gloves );

			Item gorget = new LeatherGorget();
			gorget.Movable = false;
			gorget.Hue = 32;
			AddItem( gorget );
			
		
         }
        public override void OnDeath(Container c)
        {
            base.OnDeath(c);

            c.DropItem(new Gold(600, 900));

            switch (Utility.Random(40))
            {
                case 0: c.DropItem(new ReplicaOfWarsBlade()); break;
                case 1: c.DropItem(new SwordOfWar()); break;
                case 2: c.DropItem(new IKilledWar()); break;
            }
        }
		

		public override void OnMovement( Mobile m, Point3D oldLocation ) 
               {                                                    
         	if( m_Talked == false ) 
               { 
            	if ( m.InRange( this, 3 ) ) 
               {                
               	m_Talked = true; 
               	SayRandom( kfcsay, this ); 
               	this.Move( GetDirectionTo( m.Location ) ); 
               	SpamTimer t = new SpamTimer(); 
               	t.Start(); 
               } 
	       }
	       }

           public override void OnDamagedBySpell(Mobile caster)
           {
               if (caster != this && 0.25 > Utility.RandomDouble())
               {
                   BaseCreature spawn = new SummonedWarriors(this);

                   spawn.Team = this.Team;
                   spawn.MoveToWorld(this.Location, this.Map);
                   spawn.Combatant = caster;

                  // Say(1053034); // * The plague beast creates another beast from its flesh! *
               }

               base.OnDamagedBySpell(caster);
           }

           public override bool AutoDispel { get { return true; } }

           public override void OnGotMeleeAttack(Mobile attacker)
           {
               if (attacker != this && 0.25 > Utility.RandomDouble())
               {
                   BaseCreature spawn = new SummonedWarriors(this);

                   spawn.Team = this.Team;
                   spawn.MoveToWorld(this.Location, this.Map);
                   spawn.Combatant = attacker;

                   //Say(1053034); // * The plague beast creates another beast from its flesh! *
               }

               base.OnGotMeleeAttack(attacker);
           }

	public override bool OnBeforeDeath() 
      { 
         IMount mount = this.Mount; 

         if ( mount != null ) 
            mount.Rider = null; 

         if ( mount is Mobile ) 
            ((Mobile)mount).Delete(); 

         return base.OnBeforeDeath(); 
      }




        public War(Serial serial)
            : base(serial)
		{
		}

     		private class SpamTimer : Timer 
      		{ 
         	public SpamTimer() : base( TimeSpan.FromSeconds( 5 ) ) 
         	{ 
		Priority = TimerPriority.OneSecond;
         	} 

	        protected override void OnTick() 
         	{ 
            	m_Talked = false; 
         	} 
	  	}

		private static void SayRandom( string[] say, Mobile m )
	  	{
		m.Say( say[Utility.Random( say.Length )] );
	  	}


		public override void Serialize( GenericWriter writer )
		{
			base.Serialize( writer );
			writer.Write( (int) 0 );
		}

		public override void Deserialize( GenericReader reader )
		{
			base.Deserialize( reader );
			int version = reader.ReadInt();
		}
	}
}
