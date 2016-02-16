using System;
using System.Collections.Generic;
using Server;
using Server.Accounting;
using Server.Mobiles;

namespace Server.Engines.PlayerEffects
{
	public class EffectLogin
	{
		public static void Initialize()
		{
			EventSink.Login += new LoginEventHandler( OnLogin );
		}
       
		private static void OnLogin( LoginEventArgs e )
		{
            string value = "no";
			if ( e.Mobile is PlayerMobile )
			{
				PlayerMobile m = (PlayerMobile)e.Mobile;

				if ( m == null )
					return;

				if ( m.AccessLevel < AccessLevel.Counselor )
				{
                    Account acct = m.Account as Account;

                    if (acct != null)
                    {
                        if (acct.GetTag("VoidEffect") == null)
                        {
                            acct.AddTag("VoidEffect", value);
                        }
                        if (acct.GetTag("PDarkEffect") == null)
                        {
                        acct.AddTag("PDarkEffect", value);
                        }
                        if (acct.GetTag("PFireEffect") == null)
                        {
                        acct.AddTag("PFireEffect", value);
                        }
                        if (acct.GetTag("PIceEffect") == null)
                        {
                        acct.AddTag("PIceEffect", value);
                        }
                        if (acct.GetTag("PToxicEffect") == null)
                        {
                        acct.AddTag("PToxicEffect", value);
                        }
                        if (acct.GetTag("PElectEffect") == null)
                        {
                        acct.AddTag("PElectEffect", value);
                        }
                        if (acct.GetTag("PWaterEffect") == null)
                        {
                        acct.AddTag("PWaterEffect", value);
                        }
                        if (acct.GetTag("PMistEffect") == null)
                        {
                        acct.AddTag("PMistEffect", value);
                        }
                        if (acct.GetTag("PExplosionEffect") == null)
                        {
                        acct.AddTag("PExplosionEffect", value);
                        }
                        if (acct.GetTag("PStoneEffect") == null)
                        {
                        acct.AddTag("PStoneEffect", value);
                        }
                        if (acct.GetTag("PShineyEffect") == null)
                        {
                        acct.AddTag("PShineyEffect", value);
                        }
                        if (acct.GetTag("PFireFlyEffect") == null)
                        {
                        acct.AddTag("PFireFlyEffect", value);
                        }
                        
                        EffectsSystem.RegionEffectsCheck(m);
                        Timer m_timer = new EffectsTimer( m );
                        m_timer.Start();
                   }
				}
			}
		}
	}
}
