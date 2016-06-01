using System;
using Server;
using Server.Items;
using Server.Misc;

namespace Server.Items
{
    public class VirtueState
    {
        public static Serial serial = 0;
    }
    
    [FlipableAttribute( 0x2ADC, 0x2AEC )]
    public class VirtueStone : Item
    {
        private int m_State = 0;
        private bool m_Broadcast = true;
		public Timer m_Timer;
        
        [Constructable]
        public VirtueStone() : base(0x2ADC)
        {
            Name = "Virtue Stone";
            Movable = false;
			VirtueArtifactSystem.Enabled = false;
            if ( VirtueArtifactSystem.Enabled )
            Hue = 2114; else
            Hue = 2103;
            m_Timer = new RefreshTimer(this);
	        m_Timer.Start();
	        if (VirtueState.serial == 0)
	        {
	           VirtueState.serial = Serial;
	        }
	        
        }

        public VirtueStone(Serial serial): base(serial)
        {
			VirtueArtifactSystem.Enabled = false;
            if ( VirtueArtifactSystem.Enabled )
            Hue = 2114; else
            Hue = 2103;
            m_Timer = new RefreshTimer(this);
	        m_Timer.Start();
	        if (VirtueState.serial == 0)
	        {
	           VirtueState.serial = Serial;
	        }
	        InvalidateProperties();
        }  

        private class RefreshTimer : Timer
		{
			private VirtueStone m_Stone;

            public RefreshTimer(VirtueStone stone) : base( TimeSpan.FromHours(1),TimeSpan.FromHours(1) )
			{
				m_Stone = stone;
				Priority = TimerPriority.OneSecond;
			}

			protected override void OnTick()
			{
			  if (m_Stone != null)
			  {
                 if (VirtueState.serial == m_Stone.Serial)
			     if (Utility.RandomDouble() >= 0.80) //20% chance
			     {
			       VirtueArtifactSystem.Enabled = true;  
                   m_Stone.Hue = 58;
                   if (m_Stone.m_Broadcast)
                   World.Broadcast(58, true, "Virtue Stone: Enabling Virtue Event!");
                 } else
                 {
			       VirtueArtifactSystem.Enabled = false;  
                   m_Stone.Hue = 2103;
                   if (m_Stone.m_Broadcast)
                   World.Broadcast(2103, true, "Virtue Stone: Disabling Virtue Event!");
                 }
               m_Stone.InvalidateProperties();
			  } 
  		   }
		}
		

		public override void AddNameProperties( ObjectPropertyList list )
		{
			base.AddNameProperties( list );

			if ( VirtueArtifactSystem.Enabled )
			{
                Hue = 58;
			    list.Add("Virtue Artifacts Are Available");
			}
            	else
			{
                Hue = 2103;
            	list.Add("Virtue Artifacts Are Unavailable");
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
