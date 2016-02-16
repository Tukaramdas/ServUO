using System;
using Server;

namespace Server.Mobiles
{		
	public class EffectsTimer : Timer
	{
		private PlayerMobile m_player;

		public EffectsTimer( PlayerMobile m ) : base( TimeSpan.FromSeconds( 1 ), TimeSpan.FromSeconds( 3 ) ) 
		{
			m_player = m;
			Priority = TimerPriority.EveryTick;
		}

		protected override void OnTick()
		{
			if ( m_player == null || m_player.Map == Map.Internal )
			{
				Stop();
				return;
			}

            //EffectsSystem.RegionEffectsCheck( m_player);
			EffectsSystem.EffectsCheck( m_player );
            
		}
	}
}