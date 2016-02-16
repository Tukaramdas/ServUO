using System;
using Server;
using Server.Items;
using Server.Misc;

namespace Server.Items
{
    public class TokunoState
    {
        public static Serial serial = 0;
    }
    
    public class TokunoStone : Item
    {
        private int m_State = 0;
        private bool m_Broadcast = true;
		public Timer m_Timer;
        
        [Constructable]
        public TokunoStone() : base(10972)
        {
            Name = "Tokuno Stone";
            Movable = false;
            TreasuresOfTokuno.DropEra = TreasuresOfTokunoEra.None;
			//TreasuresOfTokuno.Enabled = false;
            if (TreasuresOfTokuno.DropEra != TreasuresOfTokunoEra.None)
            //if ( TreasuresOfTokuno.Enabled )
            Hue = 19; else
            Hue = 2103;
            m_Timer = new RefreshTimer(this);
	        m_Timer.Start();
	        if (TokunoState.serial == 0)
	        {
	           TokunoState.serial = Serial;
	        }
	        
        }

        public TokunoStone(Serial serial): base(serial)
        {
            TreasuresOfTokuno.DropEra = TreasuresOfTokunoEra.None;
			//TreasuresOfTokuno.Enabled = false;
            if (TreasuresOfTokuno.DropEra != TreasuresOfTokunoEra.None)
            //if ( TreasuresOfTokuno.Enabled )
            Hue = 19; else
            Hue = 2103;
            m_Timer = new RefreshTimer(this);
	        m_Timer.Start();
	        if (TokunoState.serial == 0)
	        {
	           TokunoState.serial = Serial;
	        }
	        InvalidateProperties();
        }  

        private class RefreshTimer : Timer
		{
			private TokunoStone m_Stone;

            public RefreshTimer( TokunoStone stone ) : base( TimeSpan.FromHours(1),TimeSpan.FromHours(1) )
			{
				m_Stone = stone;
				Priority = TimerPriority.OneSecond;
			}

			protected override void OnTick()
			{
			  if (m_Stone != null)
			  {
                 if (TokunoState.serial == m_Stone.Serial)
			     if (Utility.RandomDouble() >= 0.80) //20% chance
			     {
                     { // notice the parenthesis
                         TreasuresOfTokuno.DropEra = (TreasuresOfTokunoEra)Utility.RandomMinMax(1, 3);
                         TreasuresOfTokuno.RewardEra = (TreasuresOfTokunoEra)Utility.RandomMinMax(1, 3); // rewardEra in this case will be changed only with enabling of TOT event
                     }
  
			       //TreasuresOfTokuno.Enabled = true;  
                   m_Stone.Hue = 19;
                   if (m_Stone.m_Broadcast)
                   World.Broadcast(19, true, "Tokuno Stone: Enabling ToT Event!");
                 } else
                 {
                     TreasuresOfTokuno.DropEra = TreasuresOfTokunoEra.None;
			       //TreasuresOfTokuno.Enabled = false;  
                     m_Stone.Hue = 2103;
                   if (m_Stone.m_Broadcast)
                       World.Broadcast(2103, true, "Tokuno Stone: Disabling ToT Event!");
                 }
               m_Stone.InvalidateProperties();
			  } 
  		   }
		}
		

		public override void AddNameProperties( ObjectPropertyList list )
		{
			base.AddNameProperties( list );

            if (TreasuresOfTokuno.DropEra != TreasuresOfTokunoEra.None)
			//if ( TreasuresOfTokuno.Enabled )
			{
                Hue = 19;
			    list.Add("Treasures Of Tokuno Are Available");
			}
            	else
			{
                Hue = 2103;
            	list.Add("Treasures Of Tokuno Are Unavailable");
            }
			
		}

        public override void OnDelete()
        {
           if (m_Timer != null)
           m_Timer.Stop();            
        }
    
		public override void Serialize( GenericWriter writer )
		{
			base.Serialize( writer );
			writer.Write( (int) 0 ); // version
		}

		public override void Deserialize(GenericReader reader)
		{
			base.Deserialize( reader );
			int version = reader.ReadInt();
			switch (version) 
            {			
                case 1:
                {
                    goto case 0;
                }                
                case 0:
                {
                    break;
                }                
                
            }
			
		}
       
    }   
   
 }
