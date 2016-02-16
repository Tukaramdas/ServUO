using System;
using Server;
using Server.Regions;
using Server.Items;
using Server.Mobiles;
using System.Collections;
using Server.Network;
using Server.Commands;
using Server.Accounting;
using Server.Misc;

namespace Server.Mobiles
{
	public class EffectsSystem
	{
        public static void EffectsCheck(PlayerMobile from)
        {
            PlayerMobile mplayer = from as PlayerMobile;
            Account acct = mplayer.Account as Account;
            // null check
            if (mplayer == null || mplayer.Backpack == null)
                return;

            // check if alive
            if (!mplayer.Alive)
                return;
                   
                    // effects override
                     if (acct.GetTag("VoidEffect") == "yes") 
                        return;

                    RegionEffectsCheck(mplayer);

                    if (acct.GetTag("PDarkEffect") == "yes")
                        DarkEffect(mplayer);
                    if (acct.GetTag("PFireEffect") == "yes")
                        FireEffect(mplayer);
                    if (acct.GetTag("PIceEffect") == "yes")
                        IceEffect(mplayer);
                    if (acct.GetTag("PToxicEffect") == "yes")
                         ToxicEffect(mplayer);   
                    if (acct.GetTag("PElectEffect") == "yes")
                        ElectEffect(mplayer);
                    if (acct.GetTag("PWaterEffect") == "yes")
                        WaterEffect(mplayer);
                    if (acct.GetTag("PMistEffect") == "yes")
                        MistEffect(mplayer);
                    if (acct.GetTag("PExplosionEffect") == "yes")
                        ExplosionEffect(mplayer);
                    if (acct.GetTag("PStoneEffect") == "yes")
                        StoneEffect(mplayer);
                    if (acct.GetTag("PShineyEffect") == "yes")
                        ShineyEffect(mplayer);
                    if (acct.GetTag("PFireFlyEffect") == "yes")
                        FireFlyEffect(mplayer);
                }

        public static void RegionEffectsCheck(PlayerMobile from)
        {
            PlayerMobile mp = from as PlayerMobile;
            // check if alive
            if (!mp.Alive)
                return;
            Account acc = mp.Account as Account;
            foreach (Item item in World.Items.Values)
            {
                if (item is EffectStone)
                {
                    EffectStone es = (EffectStone)item;
                    
                    if (mp.Region.IsPartOf("Moongates"))
                    {
                        
                        if (es.MoongateRegion == MoongateRegion.DarkEffect)
                        {
                            acc.SetTag("PDarkEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PDarkEffect", "no");
                        }
                        if (es.MoongateRegion == MoongateRegion.FireEffect)
                        {
                            acc.SetTag("PFireEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PFireEffect", "no");
                        }
                        if (es.MoongateRegion == MoongateRegion.IceEffect)
                        {
                            acc.SetTag("PIceEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PIceEffect", "no");
                        }
                        if (es.MoongateRegion == MoongateRegion.ToxicEffect)
                        {
                            acc.SetTag("PToxicEffect", "yes"); return;
                        }
                        else
                        { 
                            acc.SetTag("PToxicEffect", "no");
                        }
                        if (es.MoongateRegion == MoongateRegion.ElectEffect)
                        {
                            acc.SetTag("PElectEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PElectEffect", "no");
                        }
                        if (es.MoongateRegion == MoongateRegion.WaterEffect)
                        {
                            acc.SetTag("PWaterEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PWaterEffect", "no");
                        }
                        if (es.MoongateRegion == MoongateRegion.MistEffect)
                        {
                            acc.SetTag("PMistEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PMistEffect", "no");
                        }
                        if (es.MoongateRegion == MoongateRegion.ExplosionEffect)
                        {
                            acc.SetTag("PExplosionEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PExplosionEffect", "no");
                        }
                        if (es.MoongateRegion == MoongateRegion.StoneEffect)
                        {
                            acc.SetTag("PStoneEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PStoneEffect", "no");
                        }
                        if (es.MoongateRegion == MoongateRegion.ShineyEffect)
                        {
                            acc.SetTag("PShineyEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PShineyEffect", "no");
                        }
                        if (es.MoongateRegion == MoongateRegion.FireFlyEffect)
                        {
                            acc.SetTag("PFireFlyEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PFireFlyEffect", "no");
                        }
                    }
                    else if (mp.Region.IsPartOf("Cove"))
                    {     
                        if (es.CoveRegion == CoveRegion.DarkEffect)
                        {
                            acc.SetTag("PDarkEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PDarkEffect", "no");
                        }
                        if (es.CoveRegion == CoveRegion.FireEffect)
                        {
                            acc.SetTag("PFireEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PFireEffect", "no");
                        }
                        if (es.CoveRegion == CoveRegion.IceEffect)
                        {
                            acc.SetTag("PIceEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PIceEffect", "no");
                        }
                        if (es.CoveRegion == CoveRegion.ToxicEffect)
                        {
                            acc.SetTag("PToxicEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PToxicEffect", "no");
                        }
                        if (es.CoveRegion == CoveRegion.ElectEffect)
                        {
                            acc.SetTag("PElectEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PElectEffect", "no");
                        }
                        if (es.CoveRegion == CoveRegion.WaterEffect)
                        {
                            acc.SetTag("PWaterEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PWaterEffect", "no");
                        }
                        if (es.CoveRegion == CoveRegion.MistEffect)
                        {
                            acc.SetTag("PMistEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PMistEffect", "no");
                        }
                        if (es.CoveRegion == CoveRegion.ExplosionEffect)
                        {
                            acc.SetTag("PExplosionEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PExplosionEffect", "no");
                        }
                        if (es.CoveRegion == CoveRegion.StoneEffect)
                        {
                            acc.SetTag("PStoneEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PStoneEffect", "no");
                        }
                        if (es.CoveRegion == CoveRegion.ShineyEffect)
                        {
                            acc.SetTag("PShineyEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PShineyEffect", "no");
                        }
                        if (es.CoveRegion == CoveRegion.FireFlyEffect)
                        {
                            acc.SetTag("PFireFlyEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PFireFlyEffect", "no");
                        }
                    }
                    else if (mp.Region.IsPartOf("Britain"))
                    {
                        if (es.BritainRegion == BritainRegion.DarkEffect)
                        {
                            acc.SetTag("PDarkEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PDarkEffect", "no");
                        }
                        if (es.BritainRegion == BritainRegion.FireEffect)
                        {
                            acc.SetTag("PFireEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PFireEffect", "no");
                        }
                        if (es.BritainRegion == BritainRegion.IceEffect)
                        {
                            acc.SetTag("PIceEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PIceEffect", "no");
                        }
                        if (es.BritainRegion == BritainRegion.ToxicEffect)
                        {
                            acc.SetTag("PToxicEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PToxicEffect", "no");
                        }
                        if (es.BritainRegion == BritainRegion.ElectEffect)
                        {
                            acc.SetTag("PElectEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PElectEffect", "no");
                        }
                        if (es.BritainRegion == BritainRegion.WaterEffect)
                        {
                            acc.SetTag("PWaterEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PWaterEffect", "no");
                        }
                        if (es.BritainRegion == BritainRegion.MistEffect)
                        {
                            acc.SetTag("PMistEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PMistEffect", "no");
                        }
                        if (es.BritainRegion == BritainRegion.ExplosionEffect)
                        {
                            acc.SetTag("PExplosionEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PExplosionEffect", "no");
                        }
                        if (es.BritainRegion == BritainRegion.StoneEffect)
                        {
                            acc.SetTag("PStoneEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PStoneEffect", "no");
                        }
                        if (es.BritainRegion == BritainRegion.ShineyEffect)
                        {
                            acc.SetTag("PShineyEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PShineyEffect", "no");
                        }
                        if (es.BritainRegion == BritainRegion.FireFlyEffect)
                        {
                            acc.SetTag("PFireFlyEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PFireFlyEffect", "no");
                        }
                    }
                    else if (mp.Region.IsPartOf("Britain Graveyard"))
                    {
                        if (es.BritainGRegion == BritainGRegion.DarkEffect)
                        {
                            acc.SetTag("PDarkEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PDarkEffect", "no");
                        }
                        if (es.BritainGRegion == BritainGRegion.FireEffect)
                        {
                            acc.SetTag("PFireEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PFireEffect", "no");
                        }
                        if (es.BritainGRegion == BritainGRegion.IceEffect)
                        {
                            acc.SetTag("PIceEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PIceEffect", "no");
                        }
                        if (es.BritainGRegion == BritainGRegion.ToxicEffect)
                        {
                            acc.SetTag("PToxicEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PToxicEffect", "no");
                        }
                        if (es.BritainGRegion == BritainGRegion.ElectEffect)
                        {
                            acc.SetTag("PElectEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PElectEffect", "no");
                        }
                        if (es.BritainGRegion == BritainGRegion.WaterEffect)
                        {
                            acc.SetTag("PWaterEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PWaterEffect", "no");
                        }
                        if (es.BritainGRegion == BritainGRegion.MistEffect)
                        {
                            acc.SetTag("PMistEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PMistEffect", "no");
                        }
                        if (es.BritainGRegion == BritainGRegion.ExplosionEffect)
                        {
                            acc.SetTag("PExplosionEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PExplosionEffect", "no");
                        }
                        if (es.BritainGRegion == BritainGRegion.StoneEffect)
                        {
                            acc.SetTag("PStoneEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PStoneEffect", "no");
                        }
                        if (es.BritainGRegion == BritainGRegion.ShineyEffect)
                        {
                            acc.SetTag("PShineyEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PShineyEffect", "no");
                        }
                        if (es.BritainGRegion == BritainGRegion.FireFlyEffect)
                        {
                            acc.SetTag("PFireFlyEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PFireFlyEffect", "no");
                        }
                    }
                    else if (mp.Region.IsPartOf("Jhelom Islands"))
                    {
                        if (es.JhelomIsRegion == JhelomIsRegion.DarkEffect)
                        {
                            acc.SetTag("PDarkEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PDarkEffect", "no");
                        }
                        if (es.JhelomIsRegion == JhelomIsRegion.FireEffect)
                        {
                            acc.SetTag("PFireEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PFireEffect", "no");
                        }
                        if (es.JhelomIsRegion == JhelomIsRegion.IceEffect)
                        {
                            acc.SetTag("PIceEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PIceEffect", "no");
                        }
                        if (es.JhelomIsRegion == JhelomIsRegion.ToxicEffect)
                        {
                            acc.SetTag("PToxicEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PToxicEffect", "no");
                        }
                        if (es.JhelomIsRegion == JhelomIsRegion.ElectEffect)
                        {
                            acc.SetTag("PElectEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PElectEffect", "no");
                        }
                        if (es.JhelomIsRegion == JhelomIsRegion.WaterEffect)
                        {
                            acc.SetTag("PWaterEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PWaterEffect", "no");
                        }
                        if (es.JhelomIsRegion == JhelomIsRegion.MistEffect)
                        {
                            acc.SetTag("PMistEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PMistEffect", "no");
                        }
                        if (es.JhelomIsRegion == JhelomIsRegion.ExplosionEffect)
                        {
                            acc.SetTag("PExplosionEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PExplosionEffect", "no");
                        }
                        if (es.JhelomIsRegion == JhelomIsRegion.StoneEffect)
                        {
                            acc.SetTag("PStoneEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PStoneEffect", "no");
                        }
                        if (es.JhelomIsRegion == JhelomIsRegion.ShineyEffect)
                        {
                            acc.SetTag("PShineyEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PShineyEffect", "no");
                        }
                        if (es.JhelomIsRegion == JhelomIsRegion.FireFlyEffect)
                        {
                            acc.SetTag("PFireFlyEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PFireFlyEffect", "no");
                        }
                    }
                    else if (mp.Region.IsPartOf("Jhelom"))
                    {
                        if (es.JhelomRegion == JhelomRegion.DarkEffect)
                       {
                            acc.SetTag("PDarkEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PDarkEffect", "no");
                        }
                        if (es.JhelomRegion == JhelomRegion.FireEffect)
                        {
                            acc.SetTag("PFireEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PFireEffect", "no");
                        }
                        if (es.JhelomRegion == JhelomRegion.IceEffect)
                        {
                            acc.SetTag("PIceEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PIceEffect", "no");
                        }
                        if (es.JhelomRegion == JhelomRegion.ToxicEffect)
                        {
                            acc.SetTag("PToxicEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PToxicEffect", "no");
                        }
                        if (es.JhelomRegion == JhelomRegion.ElectEffect)
                        {
                            acc.SetTag("PElectEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PElectEffect", "no");
                        }
                        if (es.JhelomRegion == JhelomRegion.WaterEffect)
                        {
                            acc.SetTag("PWaterEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PWaterEffect", "no");
                        }
                        if (es.JhelomRegion == JhelomRegion.MistEffect)
                        {
                            acc.SetTag("PMistEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PMistEffect", "no");
                        }
                        if (es.JhelomRegion == JhelomRegion.ExplosionEffect)
                        {
                            acc.SetTag("PExplosionEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PExplosionEffect", "no");
                        }
                        if (es.JhelomRegion == JhelomRegion.StoneEffect)
                        {
                            acc.SetTag("PStoneEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PStoneEffect", "no");
                        }
                        if (es.JhelomRegion == JhelomRegion.ShineyEffect)
                        {
                            acc.SetTag("PShineyEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PShineyEffect", "no");
                        }
                        if (es.JhelomRegion == JhelomRegion.FireFlyEffect)
                        {
                            acc.SetTag("PFireFlyEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PFireFlyEffect", "no");
                        }
                    }
                    else if (mp.Region.IsPartOf("Minoc"))
                    {
                        if (es.MinocRegion == MinocRegion.DarkEffect)
                        {
                            acc.SetTag("PDarkEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PDarkEffect", "no");
                        }
                        if (es.MinocRegion == MinocRegion.FireEffect)
                        {
                            acc.SetTag("PFireEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PFireEffect", "no");
                        }
                        if (es.MinocRegion == MinocRegion.IceEffect)
                        {
                            acc.SetTag("PIceEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PIceEffect", "no");
                        }
                        if (es.MinocRegion == MinocRegion.ToxicEffect)
                        {
                            acc.SetTag("PToxicEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PToxicEffect", "no");
                        }
                        if (es.MinocRegion == MinocRegion.ElectEffect)
                        {
                            acc.SetTag("PElectEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PElectEffect", "no");
                        }
                        if (es.MinocRegion == MinocRegion.WaterEffect)
                        {
                            acc.SetTag("PWaterEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PWaterEffect", "no");
                        }
                        if (es.MinocRegion == MinocRegion.MistEffect)
                        {
                            acc.SetTag("PMistEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PMistEffect", "no");
                        }
                        if (es.MinocRegion == MinocRegion.ExplosionEffect)
                        {
                            acc.SetTag("PExplosionEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PExplosionEffect", "no");
                        }
                        if (es.MinocRegion == MinocRegion.StoneEffect)
                        {
                            acc.SetTag("PStoneEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PStoneEffect", "no");
                        }
                        if (es.MinocRegion == MinocRegion.ShineyEffect)
                        {
                            acc.SetTag("PShineyEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PShineyEffect", "no");
                        }
                        if (es.MinocRegion == MinocRegion.FireFlyEffect)
                        {
                            acc.SetTag("PFireFlyEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PFireFlyEffect", "no");
                        }
                    }
                    else if (mp.Region.IsPartOf("Ocllo"))
                    {
                        if (es.OclloRegion == OclloRegion.DarkEffect)
                        {
                            acc.SetTag("PDarkEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PDarkEffect", "no");
                        }
                        if (es.OclloRegion == OclloRegion.FireEffect)
                        {
                            acc.SetTag("PFireEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PFireEffect", "no");
                        }
                        if (es.OclloRegion == OclloRegion.IceEffect)
                        {
                            acc.SetTag("PIceEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PIceEffect", "no");
                        }
                        if (es.OclloRegion == OclloRegion.ToxicEffect)
                        {
                            acc.SetTag("PToxicEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PToxicEffect", "no");
                        }
                        if (es.OclloRegion == OclloRegion.ElectEffect)
                        {
                            acc.SetTag("PElectEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PElectEffect", "no");
                        }
                        if (es.OclloRegion == OclloRegion.WaterEffect)
                        {
                            acc.SetTag("PWaterEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PWaterEffect", "no");
                        }
                        if (es.OclloRegion == OclloRegion.MistEffect)
                        {
                            acc.SetTag("PMistEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PMistEffect", "no");
                        }
                        if (es.OclloRegion == OclloRegion.ExplosionEffect)
                        {
                            acc.SetTag("PExplosionEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PExplosionEffect", "no");
                        }
                        if (es.OclloRegion == OclloRegion.StoneEffect)
                        {
                            acc.SetTag("PStoneEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PStoneEffect", "no");
                        }
                        if (es.OclloRegion == OclloRegion.ShineyEffect)
                        {
                            acc.SetTag("PShineyEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PShineyEffect", "no");
                        }
                        if (es.OclloRegion == OclloRegion.FireFlyEffect)
                        {
                            acc.SetTag("PFireFlyEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PFireFlyEffect", "no");
                        }
                    }
                    else if (mp.Region.IsPartOf("Trinsic"))
                    {
                        if (es.TrinsicRegion == TrinsicRegion.DarkEffect)
                        {
                            acc.SetTag("PDarkEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PDarkEffect", "no");
                        }
                        if (es.TrinsicRegion == TrinsicRegion.FireEffect)
                        {
                            acc.SetTag("PFireEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PFireEffect", "no");
                        }
                        if (es.TrinsicRegion == TrinsicRegion.IceEffect)
                        {
                            acc.SetTag("PIceEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PIceEffect", "no");
                        }
                        if (es.TrinsicRegion == TrinsicRegion.ToxicEffect)
                        {
                            acc.SetTag("PToxicEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PToxicEffect", "no");
                        }
                        if (es.TrinsicRegion == TrinsicRegion.ElectEffect)
                        {
                            acc.SetTag("PElectEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PElectEffect", "no");
                        }
                        if (es.TrinsicRegion == TrinsicRegion.WaterEffect)
                        {
                            acc.SetTag("PWaterEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PWaterEffect", "no");
                        }
                        if (es.TrinsicRegion == TrinsicRegion.MistEffect)
                        {
                            acc.SetTag("PMistEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PMistEffect", "no");
                        }
                        if (es.TrinsicRegion == TrinsicRegion.ExplosionEffect)
                        {
                            acc.SetTag("PExplosionEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PExplosionEffect", "no");
                        }
                        if (es.TrinsicRegion == TrinsicRegion.StoneEffect)
                        {
                            acc.SetTag("PStoneEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PStoneEffect", "no");
                        }
                        if (es.TrinsicRegion == TrinsicRegion.ShineyEffect)
                        {
                            acc.SetTag("PShineyEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PShineyEffect", "no");
                        }
                        if (es.TrinsicRegion == TrinsicRegion.FireFlyEffect)
                        {
                            acc.SetTag("PFireFlyEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PFireFlyEffect", "no");
                        }
                    }

                    else if (mp.Region.IsPartOf("Vesper"))
                    {
                        if (es.VesperRegion == VesperRegion.DarkEffect)
                        {
                            acc.SetTag("PDarkEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PDarkEffect", "no");
                        }
                        if (es.VesperRegion == VesperRegion.FireEffect)
                        {
                            acc.SetTag("PFireEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PFireEffect", "no");
                        }
                        if (es.VesperRegion == VesperRegion.IceEffect)
                        {
                            acc.SetTag("PIceEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PIceEffect", "no");
                        }
                        if (es.VesperRegion == VesperRegion.ToxicEffect)
                        {
                            acc.SetTag("PToxicEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PToxicEffect", "no");
                        }
                        if (es.VesperRegion == VesperRegion.ElectEffect)
                        {
                            acc.SetTag("PElectEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PElectEffect", "no");
                        }
                        if (es.VesperRegion == VesperRegion.WaterEffect)
                        {
                            acc.SetTag("PWaterEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PWaterEffect", "no");
                        }
                        if (es.VesperRegion == VesperRegion.MistEffect)
                        {
                            acc.SetTag("PMistEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PMistEffect", "no");
                        }
                        if (es.VesperRegion == VesperRegion.ExplosionEffect)
                        {
                            acc.SetTag("PExplosionEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PExplosionEffect", "no");
                        }
                        if (es.VesperRegion == VesperRegion.StoneEffect)
                        {
                            acc.SetTag("PStoneEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PStoneEffect", "no");
                        }
                        if (es.VesperRegion == VesperRegion.ShineyEffect)
                        {
                            acc.SetTag("PShineyEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PShineyEffect", "no");
                        }
                        if (es.VesperRegion == VesperRegion.FireFlyEffect)
                        {
                            acc.SetTag("PFireFlyEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PFireFlyEffect", "no");
                        }
                    }
                    else if (mp.Region.IsPartOf("Yew"))
                    {
                        if (es.YewRegion == YewRegion.DarkEffect)
                        {
                            acc.SetTag("PDarkEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PDarkEffect", "no");
                        }
                        if (es.YewRegion == YewRegion.FireEffect)
                        {
                            acc.SetTag("PFireEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PFireEffect", "no");
                        }
                        if (es.YewRegion == YewRegion.IceEffect)
                        {
                            acc.SetTag("PIceEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PIceEffect", "no");
                        }
                        if (es.YewRegion == YewRegion.ToxicEffect)
                        {
                            acc.SetTag("PToxicEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PToxicEffect", "no");
                        }
                        if (es.YewRegion == YewRegion.ElectEffect)
                        {
                            acc.SetTag("PElectEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PElectEffect", "no");
                        }
                        if (es.YewRegion == YewRegion.WaterEffect)
                        {
                            acc.SetTag("PWaterEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PWaterEffect", "no");
                        }
                        if (es.YewRegion == YewRegion.MistEffect)
                        {
                            acc.SetTag("PMistEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PMistEffect", "no");
                        }
                        if (es.YewRegion == YewRegion.ExplosionEffect)
                        {
                            acc.SetTag("PExplosionEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PExplosionEffect", "no");
                        }
                        if (es.YewRegion == YewRegion.StoneEffect)
                        {
                            acc.SetTag("PStoneEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PStoneEffect", "no");
                        }
                        if (es.YewRegion == YewRegion.ShineyEffect)
                        {
                            acc.SetTag("PShineyEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PShineyEffect", "no");
                        }
                        if (es.YewRegion == YewRegion.FireFlyEffect)
                        {
                            acc.SetTag("PFireFlyEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PFireFlyEffect", "no");
                        }
                    }
                    else if (mp.Region.IsPartOf("Wind"))
                    {
                        if (es.WindRegion == WindRegion.DarkEffect)
                        {
                            acc.SetTag("PDarkEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PDarkEffect", "no");
                        }
                        if (es.WindRegion == WindRegion.FireEffect)
                        {
                            acc.SetTag("PFireEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PFireEffect", "no");
                        }
                        if (es.WindRegion == WindRegion.IceEffect)
                        {
                            acc.SetTag("PIceEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PIceEffect", "no");
                        }
                        if (es.WindRegion == WindRegion.ToxicEffect)
                        {
                            acc.SetTag("PToxicEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PToxicEffect", "no");
                        }
                        if (es.WindRegion == WindRegion.ElectEffect)
                        {
                            acc.SetTag("PElectEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PElectEffect", "no");
                        }
                        if (es.WindRegion == WindRegion.WaterEffect)
                        {
                            acc.SetTag("PWaterEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PWaterEffect", "no");
                        }
                        if (es.WindRegion == WindRegion.MistEffect)
                        {
                            acc.SetTag("PMistEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PMistEffect", "no");
                        }
                        if (es.WindRegion == WindRegion.ExplosionEffect)
                        {
                            acc.SetTag("PExplosionEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PExplosionEffect", "no");
                        }
                        if (es.WindRegion == WindRegion.StoneEffect)
                        {
                            acc.SetTag("PStoneEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PStoneEffect", "no");
                        }
                        if (es.WindRegion == WindRegion.ShineyEffect)
                        {
                            acc.SetTag("PShineyEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PShineyEffect", "no");
                        }
                        if (es.WindRegion == WindRegion.FireFlyEffect)
                        {
                            acc.SetTag("PFireFlyEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PFireFlyEffect", "no");
                        }
                    }
                    if (mp.Region.IsPartOf("Serpent's Hold"))
                    {
                        if (es.SerpHoldRegion == SerpHoldRegion.DarkEffect)
                        {
                            acc.SetTag("PDarkEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PDarkEffect", "no");
                        }
                        if (es.SerpHoldRegion == SerpHoldRegion.FireEffect)
                        {
                            acc.SetTag("PFireEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PFireEffect", "no");
                        }
                        if (es.SerpHoldRegion == SerpHoldRegion.IceEffect)
                        {
                            acc.SetTag("PIceEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PIceEffect", "no");
                        }
                        if (es.SerpHoldRegion == SerpHoldRegion.ToxicEffect)
                        {
                            acc.SetTag("PToxicEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PToxicEffect", "no");
                        }
                        if (es.SerpHoldRegion == SerpHoldRegion.ElectEffect)
                        {
                            acc.SetTag("PElectEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PElectEffect", "no");
                        }
                        if (es.SerpHoldRegion == SerpHoldRegion.WaterEffect)
                        {
                            acc.SetTag("PWaterEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PWaterEffect", "no");
                        }
                        if (es.SerpHoldRegion == SerpHoldRegion.MistEffect)
                        {
                            acc.SetTag("PMistEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PMistEffect", "no");
                        }
                        if (es.SerpHoldRegion == SerpHoldRegion.ExplosionEffect)
                        {
                            acc.SetTag("PExplosionEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PExplosionEffect", "no");
                        }
                        if (es.SerpHoldRegion == SerpHoldRegion.StoneEffect)
                        {
                            acc.SetTag("PStoneEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PStoneEffect", "no");
                        }
                        if (es.SerpHoldRegion == SerpHoldRegion.ShineyEffect)
                        {
                            acc.SetTag("PShineyEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PShineyEffect", "no");
                        }
                        if (es.SerpHoldRegion == SerpHoldRegion.FireFlyEffect)
                        {
                            acc.SetTag("PFireFlyEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PFireFlyEffect", "no");
                        }
                    }
                    else if (mp.Region.IsPartOf("Skara Brae"))
                    {
                        if (es.SkaraBraeRegion == SkaraBraeRegion.DarkEffect)
                        {
                            acc.SetTag("PDarkEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PDarkEffect", "no");
                        }
                        if (es.SkaraBraeRegion == SkaraBraeRegion.FireEffect)
                        {
                            acc.SetTag("PFireEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PFireEffect", "no");
                        }
                        if (es.SkaraBraeRegion == SkaraBraeRegion.IceEffect)
                        {
                            acc.SetTag("PIceEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PIceEffect", "no");
                        }
                        if (es.SkaraBraeRegion == SkaraBraeRegion.ToxicEffect)
                        {
                            acc.SetTag("PToxicEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PToxicEffect", "no");
                        }
                        if (es.SkaraBraeRegion == SkaraBraeRegion.ElectEffect)
                        {
                            acc.SetTag("PElectEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PElectEffect", "no");
                        }
                        if (es.SkaraBraeRegion == SkaraBraeRegion.WaterEffect)
                        {
                            acc.SetTag("PWaterEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PWaterEffect", "no");
                        }
                        if (es.SkaraBraeRegion == SkaraBraeRegion.MistEffect)
                        {
                            acc.SetTag("PMistEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PMistEffect", "no");
                        }
                        if (es.SkaraBraeRegion == SkaraBraeRegion.ExplosionEffect)
                        {
                            acc.SetTag("PExplosionEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PExplosionEffect", "no");
                        }
                        if (es.SkaraBraeRegion == SkaraBraeRegion.StoneEffect)
                        {
                            acc.SetTag("PStoneEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PStoneEffect", "no");
                        }
                        if (es.SkaraBraeRegion == SkaraBraeRegion.ShineyEffect)
                        {
                            acc.SetTag("PShineyEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PShineyEffect", "no");
                        }
                        if (es.SkaraBraeRegion == SkaraBraeRegion.FireFlyEffect)
                        {
                            acc.SetTag("PFireFlyEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PFireFlyEffect", "no");
                        }
                    }
                    else if (mp.Region.IsPartOf("Nujel'm"))
                    {
                        if (es.NujelmRegion == NujelmRegion.DarkEffect)
                        {
                            acc.SetTag("PDarkEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PDarkEffect", "no");
                        }
                        if (es.NujelmRegion == NujelmRegion.FireEffect)
                        {
                            acc.SetTag("PFireEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PFireEffect", "no");
                        }
                        if (es.NujelmRegion == NujelmRegion.IceEffect)
                        {
                            acc.SetTag("PIceEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PIceEffect", "no");
                        }
                        if (es.NujelmRegion == NujelmRegion.ToxicEffect)
                        {
                            acc.SetTag("PToxicEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PToxicEffect", "no");
                        }
                        if (es.NujelmRegion == NujelmRegion.ElectEffect)
                        {
                            acc.SetTag("PElectEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PElectEffect", "no");
                        }
                        if (es.NujelmRegion == NujelmRegion.WaterEffect)
                        {
                            acc.SetTag("PWaterEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PWaterEffect", "no");
                        }
                        if (es.NujelmRegion == NujelmRegion.MistEffect)
                        {
                            acc.SetTag("PMistEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PMistEffect", "no");
                        }
                        if (es.NujelmRegion == NujelmRegion.ExplosionEffect)
                        {
                            acc.SetTag("PExplosionEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PExplosionEffect", "no");
                        }
                        if (es.NujelmRegion == NujelmRegion.StoneEffect)
                        {
                            acc.SetTag("PStoneEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PStoneEffect", "no");
                        }
                        if (es.NujelmRegion == NujelmRegion.ShineyEffect)
                        {
                            acc.SetTag("PShineyEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PShineyEffect", "no");
                        }
                        if (es.NujelmRegion == NujelmRegion.FireFlyEffect)
                        {
                            acc.SetTag("PFireFlyEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PFireFlyEffect", "no");
                        }
                    }
                    else if (mp.Region.IsPartOf("Moonglow"))
                    {
                        if (es.MoonglowRegion == MoonglowRegion.DarkEffect)
                        {
                            acc.SetTag("PDarkEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PDarkEffect", "no");
                        }
                        if (es.MoonglowRegion == MoonglowRegion.FireEffect)
                        {
                            acc.SetTag("PFireEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PFireEffect", "no");
                        }
                        if (es.MoonglowRegion == MoonglowRegion.IceEffect)
                        {
                            acc.SetTag("PIceEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PIceEffect", "no");
                        }
                        if (es.MoonglowRegion == MoonglowRegion.ToxicEffect)
                        {
                            acc.SetTag("PToxicEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PToxicEffect", "no");
                        }
                        if (es.MoonglowRegion == MoonglowRegion.ElectEffect)
                        {
                            acc.SetTag("PElectEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PElectEffect", "no");
                        }
                        if (es.MoonglowRegion == MoonglowRegion.WaterEffect)
                        {
                            acc.SetTag("PWaterEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PWaterEffect", "no");
                        }
                        if (es.MoonglowRegion == MoonglowRegion.MistEffect)
                        {
                            acc.SetTag("PMistEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PMistEffect", "no");
                        }
                        if (es.MoonglowRegion == MoonglowRegion.ExplosionEffect)
                        {
                            acc.SetTag("PExplosionEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PExplosionEffect", "no");
                        }
                        if (es.MoonglowRegion == MoonglowRegion.StoneEffect)
                        {
                            acc.SetTag("PStoneEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PStoneEffect", "no");
                        }
                        if (es.MoonglowRegion == MoonglowRegion.ShineyEffect)
                        {
                            acc.SetTag("PShineyEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PShineyEffect", "no");
                        }
                        if (es.MoonglowRegion == MoonglowRegion.FireFlyEffect)
                        {
                            acc.SetTag("PFireFlyEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PFireFlyEffect", "no");
                        }
                    }
                    else if (mp.Region.IsPartOf("Magincia"))
                    {
                        if (es.MaginciaRegion == MaginciaRegion.DarkEffect)
                        {
                            acc.SetTag("PDarkEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PDarkEffect", "no");
                        }
                        if (es.MaginciaRegion == MaginciaRegion.FireEffect)
                        {
                            acc.SetTag("PFireEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PFireEffect", "no");
                        }
                        if (es.MaginciaRegion == MaginciaRegion.IceEffect)
                        {
                            acc.SetTag("PIceEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PIceEffect", "no");
                        }
                        if (es.MaginciaRegion == MaginciaRegion.ToxicEffect)
                        {
                            acc.SetTag("PToxicEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PToxicEffect", "no");
                        }
                        if (es.MaginciaRegion == MaginciaRegion.ElectEffect)
                        {
                            acc.SetTag("PElectEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PElectEffect", "no");
                        }
                        if (es.MaginciaRegion == MaginciaRegion.WaterEffect)
                        {
                            acc.SetTag("PWaterEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PWaterEffect", "no");
                        }
                        if (es.MaginciaRegion == MaginciaRegion.MistEffect)
                        {
                            acc.SetTag("PMistEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PMistEffect", "no");
                        }
                        if (es.MaginciaRegion == MaginciaRegion.ExplosionEffect)
                        {
                            acc.SetTag("PExplosionEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PExplosionEffect", "no");
                        }
                        if (es.MaginciaRegion == MaginciaRegion.StoneEffect)
                        {
                            acc.SetTag("PStoneEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PStoneEffect", "no");
                        }
                        if (es.MaginciaRegion == MaginciaRegion.ShineyEffect)
                        {
                            acc.SetTag("PShineyEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PShineyEffect", "no");
                        }
                        if (es.MaginciaRegion == MaginciaRegion.FireFlyEffect)
                        {
                            acc.SetTag("PFireFlyEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PFireFlyEffect", "no");
                        }
                    }
                    else if (mp.Region.IsPartOf("Buccaneer's Den"))
                    {
                        if (es.BucsDenRegion == BucsDenRegion.DarkEffect)
                        {
                            acc.SetTag("PDarkEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PDarkEffect", "no");
                        }
                        if (es.BucsDenRegion == BucsDenRegion.FireEffect)
                        {
                            acc.SetTag("PFireEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PFireEffect", "no");
                        }
                        if (es.BucsDenRegion == BucsDenRegion.IceEffect)
                        {
                            acc.SetTag("PIceEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PIceEffect", "no");
                        }
                        if (es.BucsDenRegion == BucsDenRegion.ToxicEffect)
                        {
                            acc.SetTag("PToxicEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PToxicEffect", "no");
                        }
                        if (es.BucsDenRegion == BucsDenRegion.ElectEffect)
                        {
                            acc.SetTag("PElectEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PElectEffect", "no");
                        }
                        if (es.BucsDenRegion == BucsDenRegion.WaterEffect)
                        {
                            acc.SetTag("PWaterEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PWaterEffect", "no");
                        }
                        if (es.BucsDenRegion == BucsDenRegion.MistEffect)
                        {
                            acc.SetTag("PMistEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PMistEffect", "no");
                        }
                        if (es.BucsDenRegion == BucsDenRegion.ExplosionEffect)
                        {
                            acc.SetTag("PExplosionEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PExplosionEffect", "no");
                        }
                        if (es.BucsDenRegion == BucsDenRegion.StoneEffect)
                        {
                            acc.SetTag("PStoneEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PStoneEffect", "no");
                        }
                        if (es.BucsDenRegion == BucsDenRegion.ShineyEffect)
                        {
                            acc.SetTag("PShineyEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PShineyEffect", "no");
                        }
                        if (es.BucsDenRegion == BucsDenRegion.FireFlyEffect)
                        {
                            acc.SetTag("PFireFlyEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PFireFlyEffect", "no");
                        }
                    }
                    else if (mp.Region.IsPartOf("Covetous"))
                    {
                        if (es.CovetousRegion == CovetousRegion.DarkEffect)
                        {
                            acc.SetTag("PDarkEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PDarkEffect", "no");
                        }
                        if (es.CovetousRegion == CovetousRegion.FireEffect)
                        {
                            acc.SetTag("PFireEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PFireEffect", "no");
                        }
                        if (es.CovetousRegion == CovetousRegion.IceEffect)
                        {
                            acc.SetTag("PIceEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PIceEffect", "no");
                        }
                        if (es.CovetousRegion == CovetousRegion.ToxicEffect)
                        {
                            acc.SetTag("PToxicEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PToxicEffect", "no");
                        }
                        if (es.CovetousRegion == CovetousRegion.ElectEffect)
                        {
                            acc.SetTag("PElectEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PElectEffect", "no");
                        }
                        if (es.CovetousRegion == CovetousRegion.WaterEffect)
                        {
                            acc.SetTag("PWaterEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PWaterEffect", "no");
                        }
                        if (es.CovetousRegion == CovetousRegion.MistEffect)
                        {
                            acc.SetTag("PMistEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PMistEffect", "no");
                        }
                        if (es.CovetousRegion == CovetousRegion.ExplosionEffect)
                        {
                            acc.SetTag("PExplosionEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PExplosionEffect", "no");
                        }
                        if (es.CovetousRegion == CovetousRegion.StoneEffect)
                        {
                            acc.SetTag("PStoneEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PStoneEffect", "no");
                        }
                        if (es.CovetousRegion == CovetousRegion.ShineyEffect)
                        {
                            acc.SetTag("PShineyEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PShineyEffect", "no");
                        }
                        if (es.CovetousRegion == CovetousRegion.FireFlyEffect)
                        {
                            acc.SetTag("PFireFlyEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PFireFlyEffect", "no");
                        }
                    }
                    else if (mp.Region.IsPartOf("Deceit"))
                    {
                        if (es.DeceitRegion == DeceitRegion.DarkEffect)
                        {
                            acc.SetTag("PDarkEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PDarkEffect", "no");
                        }
                        if (es.DeceitRegion == DeceitRegion.FireEffect)
                        {
                            acc.SetTag("PFireEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PFireEffect", "no");
                        }
                        if (es.DeceitRegion == DeceitRegion.IceEffect)
                        {
                            acc.SetTag("PIceEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PIceEffect", "no");
                        }
                        if (es.DeceitRegion == DeceitRegion.ToxicEffect)
                        {
                            acc.SetTag("PToxicEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PToxicEffect", "no");
                        }
                        if (es.DeceitRegion == DeceitRegion.ElectEffect)
                        {
                            acc.SetTag("PElectEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PElectEffect", "no");
                        }
                        if (es.DeceitRegion == DeceitRegion.WaterEffect)
                        {
                            acc.SetTag("PWaterEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PWaterEffect", "no");
                        }
                        if (es.DeceitRegion == DeceitRegion.MistEffect)
                        {
                            acc.SetTag("PMistEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PMistEffect", "no");
                        }
                        if (es.DeceitRegion == DeceitRegion.ExplosionEffect)
                        {
                            acc.SetTag("PExplosionEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PExplosionEffect", "no");
                        }
                        if (es.DeceitRegion == DeceitRegion.StoneEffect)
                        {
                            acc.SetTag("PStoneEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PStoneEffect", "no");
                        }
                        if (es.DeceitRegion == DeceitRegion.ShineyEffect)
                        {
                            acc.SetTag("PShineyEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PShineyEffect", "no");
                        }
                        if (es.DeceitRegion == DeceitRegion.FireFlyEffect)
                        {
                            acc.SetTag("PFireFlyEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PFireFlyEffect", "no");
                        }
                    }
                    else if (mp.Region.IsPartOf("Despise"))
                    {
                        if (es.DespiseRegion == DespiseRegion.DarkEffect)
                        {
                            acc.SetTag("PDarkEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PDarkEffect", "no");
                        }
                        if (es.DespiseRegion == DespiseRegion.FireEffect)
                        {
                            acc.SetTag("PFireEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PFireEffect", "no");
                        }
                        if (es.DespiseRegion == DespiseRegion.IceEffect)
                        {
                            acc.SetTag("PIceEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PIceEffect", "no");
                        }
                        if (es.DespiseRegion == DespiseRegion.ToxicEffect)
                        {
                            acc.SetTag("PToxicEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PToxicEffect", "no");
                        }
                        if (es.DespiseRegion == DespiseRegion.ElectEffect)
                        {
                            acc.SetTag("PElectEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PElectEffect", "no");
                        }
                        if (es.DespiseRegion == DespiseRegion.WaterEffect)
                        {
                            acc.SetTag("PWaterEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PWaterEffect", "no");
                        }
                        if (es.DespiseRegion == DespiseRegion.MistEffect)
                        {
                            acc.SetTag("PMistEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PMistEffect", "no");
                        }
                        if (es.DespiseRegion == DespiseRegion.ExplosionEffect)
                        {
                            acc.SetTag("PExplosionEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PExplosionEffect", "no");
                        }
                        if (es.DespiseRegion == DespiseRegion.StoneEffect)
                        {
                            acc.SetTag("PStoneEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PStoneEffect", "no");
                        }
                        if (es.DespiseRegion == DespiseRegion.ShineyEffect)
                        {
                            acc.SetTag("PShineyEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PShineyEffect", "no");
                        }
                        if (es.DespiseRegion == DespiseRegion.FireFlyEffect)
                        {
                            acc.SetTag("PFireFlyEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PFireFlyEffect", "no");
                        }
                    }
                    else if (mp.Region.IsPartOf("Destard"))
                    {
                        if (es.DestardRegion == DestardRegion.DarkEffect)
                        {
                            acc.SetTag("PDarkEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PDarkEffect", "no");
                        }
                        if (es.DestardRegion == DestardRegion.FireEffect)
                        {
                            acc.SetTag("PFireEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PFireEffect", "no");
                        }
                        if (es.DestardRegion == DestardRegion.IceEffect)
                        {
                            acc.SetTag("PIceEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PIceEffect", "no");
                        }
                        if (es.DestardRegion == DestardRegion.ToxicEffect)
                        {
                            acc.SetTag("PToxicEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PToxicEffect", "no");
                        }
                        if (es.DestardRegion == DestardRegion.ElectEffect)
                        {
                            acc.SetTag("PElectEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PElectEffect", "no");
                        }
                        if (es.DestardRegion == DestardRegion.WaterEffect)
                        {
                            acc.SetTag("PWaterEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PWaterEffect", "no");
                        }
                        if (es.DestardRegion == DestardRegion.MistEffect)
                        {
                            acc.SetTag("PMistEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PMistEffect", "no");
                        }
                        if (es.DestardRegion == DestardRegion.ExplosionEffect)
                        {
                            acc.SetTag("PExplosionEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PExplosionEffect", "no");
                        }
                        if (es.DestardRegion == DestardRegion.StoneEffect)
                        {
                            acc.SetTag("PStoneEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PStoneEffect", "no");
                        }
                        if (es.DestardRegion == DestardRegion.ShineyEffect)
                        {
                            acc.SetTag("PShineyEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PShineyEffect", "no");
                        }
                        if (es.DestardRegion == DestardRegion.FireFlyEffect)
                        {
                            acc.SetTag("PFireFlyEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PFireFlyEffect", "no");
                        }
                    }
                    else if (mp.Region.IsPartOf("Hythloth"))
                    {
                        if (es.HythlothRegion == HythlothRegion.DarkEffect)
                        {
                            acc.SetTag("PDarkEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PDarkEffect", "no");
                        }
                        if (es.HythlothRegion == HythlothRegion.FireEffect)
                        {
                            acc.SetTag("PFireEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PFireEffect", "no");
                        }
                        if (es.HythlothRegion == HythlothRegion.IceEffect)
                        {
                            acc.SetTag("PIceEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PIceEffect", "no");
                        }
                        if (es.HythlothRegion == HythlothRegion.ToxicEffect)
                        {
                            acc.SetTag("PToxicEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PToxicEffect", "no");
                        }
                        if (es.HythlothRegion == HythlothRegion.ElectEffect)
                        {
                            acc.SetTag("PElectEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PElectEffect", "no");
                        }
                        if (es.HythlothRegion == HythlothRegion.WaterEffect)
                        {
                            acc.SetTag("PWaterEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PWaterEffect", "no");
                        }
                        if (es.HythlothRegion == HythlothRegion.MistEffect)
                        {
                            acc.SetTag("PMistEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PMistEffect", "no");
                        }
                        if (es.HythlothRegion == HythlothRegion.ExplosionEffect)
                        {
                            acc.SetTag("PExplosionEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PExplosionEffect", "no");
                        }
                        if (es.HythlothRegion == HythlothRegion.StoneEffect)
                        {
                            acc.SetTag("PStoneEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PStoneEffect", "no");
                        }
                        if (es.HythlothRegion == HythlothRegion.ShineyEffect)
                        {
                            acc.SetTag("PShineyEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PShineyEffect", "no");
                        }
                        if (es.HythlothRegion == HythlothRegion.FireFlyEffect)
                        {
                            acc.SetTag("PFireFlyEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PFireFlyEffect", "no");
                        }
                    }
                    else if (mp.Region.IsPartOf("Khaldun"))
                    {
                        if (es.KhaldunRegion == KhaldunRegion.DarkEffect)
                        {
                            acc.SetTag("PDarkEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PDarkEffect", "no");
                        }
                        if (es.KhaldunRegion == KhaldunRegion.FireEffect)
                        {
                            acc.SetTag("PFireEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PFireEffect", "no");
                        }
                        if (es.KhaldunRegion == KhaldunRegion.IceEffect)
                        {
                            acc.SetTag("PIceEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PIceEffect", "no");
                        }
                        if (es.KhaldunRegion == KhaldunRegion.ToxicEffect)
                        {
                            acc.SetTag("PToxicEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PToxicEffect", "no");
                        }
                        if (es.KhaldunRegion == KhaldunRegion.ElectEffect)
                        {
                            acc.SetTag("PElectEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PElectEffect", "no");
                        }
                        if (es.KhaldunRegion == KhaldunRegion.WaterEffect)
                        {
                            acc.SetTag("PWaterEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PWaterEffect", "no");
                        }
                        if (es.KhaldunRegion == KhaldunRegion.MistEffect)
                        {
                            acc.SetTag("PMistEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PMistEffect", "no");
                        }
                        if (es.KhaldunRegion == KhaldunRegion.ExplosionEffect)
                        {
                            acc.SetTag("PExplosionEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PExplosionEffect", "no");
                        }
                        if (es.KhaldunRegion == KhaldunRegion.StoneEffect)
                        {
                            acc.SetTag("PStoneEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PStoneEffect", "no");
                        }
                        if (es.KhaldunRegion == KhaldunRegion.ShineyEffect)
                        {
                            acc.SetTag("PShineyEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PShineyEffect", "no");
                        }
                        if (es.KhaldunRegion == KhaldunRegion.FireFlyEffect)
                        {
                            acc.SetTag("PFireFlyEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PFireFlyEffect", "no");
                        }
                    }
                    else if (mp.Region.IsPartOf("Shame"))
                    {
                        if (es.ShameRegion == ShameRegion.DarkEffect)
                        {
                            acc.SetTag("PDarkEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PDarkEffect", "no");
                        }
                        if (es.ShameRegion == ShameRegion.FireEffect)
                        {
                            acc.SetTag("PFireEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PFireEffect", "no");
                        }
                        if (es.ShameRegion == ShameRegion.IceEffect)
                        {
                            acc.SetTag("PIceEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PIceEffect", "no");
                        }
                        if (es.ShameRegion == ShameRegion.ToxicEffect)
                        {
                            acc.SetTag("PToxicEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PToxicEffect", "no");
                        }
                        if (es.ShameRegion == ShameRegion.ElectEffect)
                        {
                            acc.SetTag("PElectEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PElectEffect", "no");
                        }
                        if (es.ShameRegion == ShameRegion.WaterEffect)
                        {
                            acc.SetTag("PWaterEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PWaterEffect", "no");
                        }
                        if (es.ShameRegion == ShameRegion.MistEffect)
                        {
                            acc.SetTag("PMistEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PMistEffect", "no");
                        }
                        if (es.ShameRegion == ShameRegion.ExplosionEffect)
                        {
                            acc.SetTag("PExplosionEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PExplosionEffect", "no");
                        }
                        if (es.ShameRegion == ShameRegion.StoneEffect)
                        {
                            acc.SetTag("PStoneEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PStoneEffect", "no");
                        }
                        if (es.ShameRegion == ShameRegion.ShineyEffect)
                        {
                            acc.SetTag("PShineyEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PShineyEffect", "no");
                        }
                        if (es.ShameRegion == ShameRegion.FireFlyEffect)
                        {
                            acc.SetTag("PFireFlyEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PFireFlyEffect", "no");
                        }
                    }
                    else if (mp.Region.IsPartOf("Wrong"))
                    {
                        if (es.WrongRegion == WrongRegion.DarkEffect)
                        {
                            acc.SetTag("PDarkEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PDarkEffect", "no");
                        }
                        if (es.WrongRegion == WrongRegion.FireEffect)
                        {
                            acc.SetTag("PFireEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PFireEffect", "no");
                        }
                        if (es.WrongRegion == WrongRegion.IceEffect)
                        {
                            acc.SetTag("PIceEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PIceEffect", "no");
                        }
                        if (es.WrongRegion == WrongRegion.ToxicEffect)
                        {
                            acc.SetTag("PToxicEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PToxicEffect", "no");
                        }
                        if (es.WrongRegion == WrongRegion.ElectEffect)
                        {
                            acc.SetTag("PElectEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PElectEffect", "no");
                        }
                        if (es.WrongRegion == WrongRegion.WaterEffect)
                        {
                            acc.SetTag("PWaterEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PWaterEffect", "no");
                        }
                        if (es.WrongRegion == WrongRegion.MistEffect)
                        {
                            acc.SetTag("PMistEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PMistEffect", "no");
                        }
                        if (es.WrongRegion == WrongRegion.ExplosionEffect)
                        {
                            acc.SetTag("PExplosionEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PExplosionEffect", "no");
                        }
                        if (es.WrongRegion == WrongRegion.StoneEffect)
                        {
                            acc.SetTag("PStoneEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PStoneEffect", "no");
                        }
                        if (es.WrongRegion == WrongRegion.ShineyEffect)
                        {
                            acc.SetTag("PShineyEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PShineyEffect", "no");
                        }
                        if (es.WrongRegion == WrongRegion.FireFlyEffect)
                        {
                            acc.SetTag("PFireFlyEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PFireFlyEffect", "no");
                        }
                    }
                    else if (mp.Region.IsPartOf("Cave 1"))
                    {
                        if (es.Cave1Region == Cave1Region.DarkEffect)
                        {
                            acc.SetTag("PDarkEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PDarkEffect", "no");
                        }
                        if (es.Cave1Region == Cave1Region.FireEffect)
                        {
                            acc.SetTag("PFireEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PFireEffect", "no");
                        }
                        if (es.Cave1Region == Cave1Region.IceEffect)
                        {
                            acc.SetTag("PIceEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PIceEffect", "no");
                        }
                        if (es.Cave1Region == Cave1Region.ToxicEffect)
                        {
                            acc.SetTag("PToxicEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PToxicEffect", "no");
                        }
                        if (es.Cave1Region == Cave1Region.ElectEffect)
                        {
                            acc.SetTag("PElectEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PElectEffect", "no");
                        }
                        if (es.Cave1Region == Cave1Region.WaterEffect)
                        {
                            acc.SetTag("PWaterEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PWaterEffect", "no");
                        }
                        if (es.Cave1Region == Cave1Region.MistEffect)
                        {
                            acc.SetTag("PMistEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PMistEffect", "no");
                        }
                        if (es.Cave1Region == Cave1Region.ExplosionEffect)
                        {
                            acc.SetTag("PExplosionEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PExplosionEffect", "no");
                        }
                        if (es.Cave1Region == Cave1Region.StoneEffect)
                        {
                            acc.SetTag("PStoneEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PStoneEffect", "no");
                        }
                        if (es.Cave1Region == Cave1Region.ShineyEffect)
                        {
                            acc.SetTag("PShineyEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PShineyEffect", "no");
                        }
                        if (es.Cave1Region == Cave1Region.FireFlyEffect)
                        {
                            acc.SetTag("PFireFlyEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PFireFlyEffect", "no");
                        }
                    }
                    else if (mp.Region.IsPartOf("Cave 2"))
                    {
                        if (es.Cave2Region == Cave2Region.DarkEffect)
                        {
                            acc.SetTag("PDarkEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PDarkEffect", "no");
                        }
                        if (es.Cave2Region == Cave2Region.FireEffect)
                        {
                            acc.SetTag("PFireEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PFireEffect", "no");
                        }
                        if (es.Cave2Region == Cave2Region.IceEffect)
                        {
                            acc.SetTag("PIceEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PIceEffect", "no");
                        }
                        if (es.Cave2Region == Cave2Region.ToxicEffect)
                        {
                            acc.SetTag("PToxicEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PToxicEffect", "no");
                        }
                        if (es.Cave2Region == Cave2Region.ElectEffect)
                        {
                            acc.SetTag("PElectEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PElectEffect", "no");
                        }
                        if (es.Cave2Region == Cave2Region.WaterEffect)
                        {
                            acc.SetTag("PWaterEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PWaterEffect", "no");
                        }
                        if (es.Cave2Region == Cave2Region.MistEffect)
                        {
                            acc.SetTag("PMistEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PMistEffect", "no");
                        }
                        if (es.Cave2Region == Cave2Region.ExplosionEffect)
                        {
                            acc.SetTag("PExplosionEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PExplosionEffect", "no");
                        }
                        if (es.Cave2Region == Cave2Region.StoneEffect)
                        {
                            acc.SetTag("PStoneEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PStoneEffect", "no");
                        }
                        if (es.Cave2Region == Cave2Region.ShineyEffect)
                        {
                            acc.SetTag("PShineyEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PShineyEffect", "no");
                        }
                        if (es.Cave2Region == Cave2Region.FireFlyEffect)
                        {
                            acc.SetTag("PFireFlyEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PFireFlyEffect", "no");
                        }
                    }
                    else if (mp.Region.IsPartOf("Cave 3"))
                    {
                        if (es.Cave3Region == Cave3Region.DarkEffect)
                        {
                            acc.SetTag("PDarkEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PDarkEffect", "no");
                        }
                        if (es.Cave3Region == Cave3Region.FireEffect)
                        {
                            acc.SetTag("PFireEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PFireEffect", "no");
                        }
                        if (es.Cave3Region == Cave3Region.IceEffect)
                        {
                            acc.SetTag("PIceEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PIceEffect", "no");
                        }
                        if (es.Cave3Region == Cave3Region.ToxicEffect)
                        {
                            acc.SetTag("PToxicEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PToxicEffect", "no");
                        }
                        if (es.Cave3Region == Cave3Region.ElectEffect)
                        {
                            acc.SetTag("PElectEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PElectEffect", "no");
                        }
                        if (es.Cave3Region == Cave3Region.WaterEffect)
                        {
                            acc.SetTag("PWaterEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PWaterEffect", "no");
                        }
                        if (es.Cave3Region == Cave3Region.MistEffect)
                        {
                            acc.SetTag("PMistEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PMistEffect", "no");
                        }
                        if (es.Cave3Region == Cave3Region.ExplosionEffect)
                        {
                            acc.SetTag("PExplosionEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PExplosionEffect", "no");
                        }
                        if (es.Cave3Region == Cave3Region.StoneEffect)
                        {
                            acc.SetTag("PStoneEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PStoneEffect", "no");
                        }
                        if (es.Cave3Region == Cave3Region.ShineyEffect)
                        {
                            acc.SetTag("PShineyEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PShineyEffect", "no");
                        }
                        if (es.Cave3Region == Cave3Region.FireFlyEffect)
                        {
                            acc.SetTag("PFireFlyEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PFireFlyEffect", "no");
                        }
                    }
                    else if (mp.Region.IsPartOf("Cave 4"))
                    {
                        if (es.Cave4Region == Cave4Region.DarkEffect)
                        {
                            acc.SetTag("PDarkEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PDarkEffect", "no");
                        }
                        if (es.Cave4Region == Cave4Region.FireEffect)
                        {
                            acc.SetTag("PFireEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PFireEffect", "no");
                        }
                        if (es.Cave4Region == Cave4Region.IceEffect)
                        {
                            acc.SetTag("PIceEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PIceEffect", "no");
                        }
                        if (es.Cave4Region == Cave4Region.ToxicEffect)
                        {
                            acc.SetTag("PToxicEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PToxicEffect", "no");
                        }
                        if (es.Cave4Region == Cave4Region.ElectEffect)
                        {
                            acc.SetTag("PElectEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PElectEffect", "no");
                        }
                        if (es.Cave4Region == Cave4Region.WaterEffect)
                        {
                            acc.SetTag("PWaterEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PWaterEffect", "no");
                        }
                        if (es.Cave4Region == Cave4Region.MistEffect)
                        {
                            acc.SetTag("PMistEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PMistEffect", "no");
                        }
                        if (es.Cave4Region == Cave4Region.ExplosionEffect)
                        {
                            acc.SetTag("PExplosionEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PExplosionEffect", "no");
                        }
                        if (es.Cave4Region == Cave4Region.StoneEffect)
                        {
                            acc.SetTag("PStoneEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PStoneEffect", "no");
                        }
                        if (es.Cave4Region == Cave4Region.ShineyEffect)
                        {
                            acc.SetTag("PShineyEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PShineyEffect", "no");
                        }
                        if (es.Cave4Region == Cave4Region.FireFlyEffect)
                        {
                            acc.SetTag("PFireFlyEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PFireFlyEffect", "no");
                        }
                    }
                    else if (mp.Region.IsPartOf("Britain Mine 1"))
                    {
                        if (es.BritMine1Region == BritMine1Region.DarkEffect)
                        {
                            acc.SetTag("PDarkEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PDarkEffect", "no");
                        }
                        if (es.BritMine1Region == BritMine1Region.FireEffect)
                        {
                            acc.SetTag("PFireEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PFireEffect", "no");
                        }
                        if (es.BritMine1Region == BritMine1Region.IceEffect)
                        {
                            acc.SetTag("PIceEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PIceEffect", "no");
                        }
                        if (es.BritMine1Region == BritMine1Region.ToxicEffect)
                        {
                            acc.SetTag("PToxicEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PToxicEffect", "no");
                        }
                        if (es.BritMine1Region == BritMine1Region.ElectEffect)
                        {
                            acc.SetTag("PElectEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PElectEffect", "no");
                        }
                        if (es.BritMine1Region == BritMine1Region.WaterEffect)
                        {
                            acc.SetTag("PWaterEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PWaterEffect", "no");
                        }
                        if (es.BritMine1Region == BritMine1Region.MistEffect)
                        {
                            acc.SetTag("PMistEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PMistEffect", "no");
                        }
                        if (es.BritMine1Region == BritMine1Region.ExplosionEffect)
                        {
                            acc.SetTag("PExplosionEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PExplosionEffect", "no");
                        }
                        if (es.BritMine1Region == BritMine1Region.StoneEffect)
                        {
                            acc.SetTag("PStoneEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PStoneEffect", "no");
                        }
                        if (es.BritMine1Region == BritMine1Region.ShineyEffect)
                        {
                            acc.SetTag("PShineyEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PShineyEffect", "no");
                        }
                        if (es.BritMine1Region == BritMine1Region.FireFlyEffect)
                        {
                            acc.SetTag("PFireFlyEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PFireFlyEffect", "no");
                        }
                    }
                    else if (mp.Region.IsPartOf("Britain Mine 2"))
                    {
                        if (es.BritMine2Region == BritMine2Region.DarkEffect)
                        {
                            acc.SetTag("PDarkEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PDarkEffect", "no");
                        }
                        if (es.BritMine2Region == BritMine2Region.FireEffect)
                        {
                            acc.SetTag("PFireEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PFireEffect", "no");
                        }
                        if (es.BritMine2Region == BritMine2Region.IceEffect)
                        {
                            acc.SetTag("PIceEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PIceEffect", "no");
                        }
                        if (es.BritMine2Region == BritMine2Region.ToxicEffect)
                        {
                            acc.SetTag("PToxicEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PToxicEffect", "no");
                        }
                        if (es.BritMine2Region == BritMine2Region.ElectEffect)
                        {
                            acc.SetTag("PElectEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PElectEffect", "no");
                        }
                        if (es.BritMine2Region == BritMine2Region.WaterEffect)
                        {
                            acc.SetTag("PWaterEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PWaterEffect", "no");
                        }
                        if (es.BritMine2Region == BritMine2Region.MistEffect)
                        {
                            acc.SetTag("PMistEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PMistEffect", "no");
                        }
                        if (es.BritMine2Region == BritMine2Region.ExplosionEffect)
                        {
                            acc.SetTag("PExplosionEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PExplosionEffect", "no");
                        }
                        if (es.BritMine2Region == BritMine2Region.StoneEffect)
                        {
                            acc.SetTag("PStoneEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PStoneEffect", "no");
                        }
                        if (es.BritMine2Region == BritMine2Region.ShineyEffect)
                        {
                            acc.SetTag("PShineyEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PShineyEffect", "no");
                        }
                        if (es.BritMine2Region == BritMine2Region.FireFlyEffect)
                        {
                            acc.SetTag("PFireFlyEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PFireFlyEffect", "no");
                        }
                    }
                    else if (mp.Region.IsPartOf("Minoc Cave 1"))
                    {
                        if (es.MinocCave1Region == MinocCave1Region.DarkEffect)
                        {
                            acc.SetTag("PDarkEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PDarkEffect", "no");
                        }
                        if (es.MinocCave1Region == MinocCave1Region.FireEffect)
                        {
                            acc.SetTag("PFireEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PFireEffect", "no");
                        }
                        if (es.MinocCave1Region == MinocCave1Region.IceEffect)
                        {
                            acc.SetTag("PIceEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PIceEffect", "no");
                        }
                        if (es.MinocCave1Region == MinocCave1Region.ToxicEffect)
                        {
                            acc.SetTag("PToxicEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PToxicEffect", "no");
                        }
                        if (es.MinocCave1Region == MinocCave1Region.ElectEffect)
                        {
                            acc.SetTag("PElectEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PElectEffect", "no");
                        }
                        if (es.MinocCave1Region == MinocCave1Region.WaterEffect)
                        {
                            acc.SetTag("PWaterEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PWaterEffect", "no");
                        }
                        if (es.MinocCave1Region == MinocCave1Region.MistEffect)
                        {
                            acc.SetTag("PMistEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PMistEffect", "no");
                        }
                        if (es.MinocCave1Region == MinocCave1Region.ExplosionEffect)
                        {
                            acc.SetTag("PExplosionEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PExplosionEffect", "no");
                        }
                        if (es.MinocCave1Region == MinocCave1Region.StoneEffect)
                        {
                            acc.SetTag("PStoneEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PStoneEffect", "no");
                        }
                        if (es.MinocCave1Region == MinocCave1Region.ShineyEffect)
                        {
                            acc.SetTag("PShineyEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PShineyEffect", "no");
                        }
                        if (es.MinocCave1Region == MinocCave1Region.FireFlyEffect)
                        {
                            acc.SetTag("PFireFlyEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PFireFlyEffect", "no");
                        }
                    }
                    else if (mp.Region.IsPartOf("Minoc Cave 2"))
                    {
                        if (es.MinocCave2Region == MinocCave2Region.DarkEffect)
                        {
                            acc.SetTag("PDarkEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PDarkEffect", "no");
                        }
                        if (es.MinocCave2Region == MinocCave2Region.FireEffect)
                        {
                            acc.SetTag("PFireEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PFireEffect", "no");
                        }
                        if (es.MinocCave2Region == MinocCave2Region.IceEffect)
                        {
                            acc.SetTag("PIceEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PIceEffect", "no");
                        }
                        if (es.MinocCave2Region == MinocCave2Region.ToxicEffect)
                        {
                            acc.SetTag("PToxicEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PToxicEffect", "no");
                        }
                        if (es.MinocCave2Region == MinocCave2Region.ElectEffect)
                        {
                            acc.SetTag("PElectEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PElectEffect", "no");
                        }
                        if (es.MinocCave2Region == MinocCave2Region.WaterEffect)
                        {
                            acc.SetTag("PWaterEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PWaterEffect", "no");
                        }
                        if (es.MinocCave2Region == MinocCave2Region.MistEffect)
                        {
                            acc.SetTag("PMistEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PMistEffect", "no");
                        }
                        if (es.MinocCave2Region == MinocCave2Region.ExplosionEffect)
                        {
                            acc.SetTag("PExplosionEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PExplosionEffect", "no");
                        }
                        if (es.MinocCave2Region == MinocCave2Region.StoneEffect)
                        {
                            acc.SetTag("PStoneEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PStoneEffect", "no");
                        }
                        if (es.MinocCave2Region == MinocCave2Region.ShineyEffect)
                        {
                            acc.SetTag("PShineyEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PShineyEffect", "no");
                        }
                        if (es.MinocCave2Region == MinocCave2Region.FireFlyEffect)
                        {
                            acc.SetTag("PFireFlyEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PFireFlyEffect", "no");
                        }
                    }
                    else if (mp.Region.IsPartOf("Minoc Cave 3"))
                    {
                        if (es.MinocCave3Region == MinocCave3Region.DarkEffect)
                        {
                            acc.SetTag("PDarkEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PDarkEffect", "no");
                        }
                        if (es.MinocCave3Region == MinocCave3Region.FireEffect)
                        {
                            acc.SetTag("PFireEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PFireEffect", "no");
                        }
                        if (es.MinocCave3Region == MinocCave3Region.IceEffect)
                        {
                            acc.SetTag("PIceEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PIceEffect", "no");
                        }
                        if (es.MinocCave3Region == MinocCave3Region.ToxicEffect)
                        {
                            acc.SetTag("PToxicEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PToxicEffect", "no");
                        }
                        if (es.MinocCave3Region == MinocCave3Region.ElectEffect)
                        {
                            acc.SetTag("PElectEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PElectEffect", "no");
                        }
                        if (es.MinocCave3Region == MinocCave3Region.WaterEffect)
                        {
                            acc.SetTag("PWaterEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PWaterEffect", "no");
                        }
                        if (es.MinocCave3Region == MinocCave3Region.MistEffect)
                        {
                            acc.SetTag("PMistEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PMistEffect", "no");
                        }
                        if (es.MinocCave3Region == MinocCave3Region.ExplosionEffect)
                        {
                            acc.SetTag("PExplosionEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PExplosionEffect", "no");
                        }
                        if (es.MinocCave3Region == MinocCave3Region.StoneEffect)
                        {
                            acc.SetTag("PStoneEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PStoneEffect", "no");
                        }
                        if (es.MinocCave3Region == MinocCave3Region.ShineyEffect)
                        {
                            acc.SetTag("PShineyEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PShineyEffect", "no");
                        }
                        if (es.MinocCave3Region == MinocCave3Region.FireFlyEffect)
                        {
                            acc.SetTag("PFireFlyEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PFireFlyEffect", "no");
                        }
                    }
                    else if (mp.Region.IsPartOf("Minoc Cave"))
                    {
                        if (es.MinocCaveRegion == MinocCaveRegion.DarkEffect)
                        {
                            acc.SetTag("PDarkEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PDarkEffect", "no");
                        }
                        if (es.MinocCaveRegion == MinocCaveRegion.FireEffect)
                        {
                            acc.SetTag("PFireEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PFireEffect", "no");
                        }
                        if (es.MinocCaveRegion == MinocCaveRegion.IceEffect)
                        {
                            acc.SetTag("PIceEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PIceEffect", "no");
                        }
                        if (es.MinocCaveRegion == MinocCaveRegion.ToxicEffect)
                        {
                            acc.SetTag("PToxicEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PToxicEffect", "no");
                        }
                        if (es.MinocCaveRegion == MinocCaveRegion.ElectEffect)
                        {
                            acc.SetTag("PElectEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PElectEffect", "no");
                        }
                        if (es.MinocCaveRegion == MinocCaveRegion.WaterEffect)
                        {
                            acc.SetTag("PWaterEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PWaterEffect", "no");
                        }
                        if (es.MinocCaveRegion == MinocCaveRegion.MistEffect)
                        {
                            acc.SetTag("PMistEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PMistEffect", "no");
                        }
                        if (es.MinocCaveRegion == MinocCaveRegion.ExplosionEffect)
                        {
                            acc.SetTag("PExplosionEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PExplosionEffect", "no");
                        }
                        if (es.MinocCaveRegion == MinocCaveRegion.StoneEffect)
                        {
                            acc.SetTag("PStoneEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PStoneEffect", "no");
                        }
                        if (es.MinocCaveRegion == MinocCaveRegion.ShineyEffect)
                        {
                            acc.SetTag("PShineyEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PShineyEffect", "no");
                        }
                        if (es.MinocCaveRegion == MinocCaveRegion.FireFlyEffect)
                        {
                            acc.SetTag("PFireFlyEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PFireFlyEffect", "no");
                        }
                    }
                    else if (mp.Region.IsPartOf("Avatar Isle Cave"))
                    {
                        if (es.AvatarIsleCaveRegion == AvatarIsleCaveRegion.DarkEffect)
                        {
                            acc.SetTag("PDarkEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PDarkEffect", "no");
                        }
                        if (es.AvatarIsleCaveRegion == AvatarIsleCaveRegion.FireEffect)
                        {
                            acc.SetTag("PFireEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PFireEffect", "no");
                        }
                        if (es.AvatarIsleCaveRegion == AvatarIsleCaveRegion.IceEffect)
                        {
                            acc.SetTag("PIceEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PIceEffect", "no");
                        }
                        if (es.AvatarIsleCaveRegion == AvatarIsleCaveRegion.ToxicEffect)
                        {
                            acc.SetTag("PToxicEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PToxicEffect", "no");
                        }
                        if (es.AvatarIsleCaveRegion == AvatarIsleCaveRegion.ElectEffect)
                        {
                            acc.SetTag("PElectEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PElectEffect", "no");
                        }
                        if (es.AvatarIsleCaveRegion == AvatarIsleCaveRegion.WaterEffect)
                        {
                            acc.SetTag("PWaterEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PWaterEffect", "no");
                        }
                        if (es.AvatarIsleCaveRegion == AvatarIsleCaveRegion.MistEffect)
                        {
                            acc.SetTag("PMistEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PMistEffect", "no");
                        }
                        if (es.AvatarIsleCaveRegion == AvatarIsleCaveRegion.ExplosionEffect)
                        {
                            acc.SetTag("PExplosionEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PExplosionEffect", "no");
                        }
                        if (es.AvatarIsleCaveRegion == AvatarIsleCaveRegion.StoneEffect)
                        {
                            acc.SetTag("PStoneEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PStoneEffect", "no");
                        }
                        if (es.AvatarIsleCaveRegion == AvatarIsleCaveRegion.ShineyEffect)
                        {
                            acc.SetTag("PShineyEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PShineyEffect", "no");
                        }
                        if (es.AvatarIsleCaveRegion == AvatarIsleCaveRegion.FireFlyEffect)
                        {
                            acc.SetTag("PFireFlyEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PFireFlyEffect", "no");
                        }
                    }
                    else if (mp.Region.IsPartOf("Ice Isle Cave 1"))
                    {
                        if (es.IceIsleCave1Region == IceIsleCave1Region.DarkEffect)
                        {
                            acc.SetTag("PDarkEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PDarkEffect", "no");
                        }
                        if (es.IceIsleCave1Region == IceIsleCave1Region.FireEffect)
                        {
                            acc.SetTag("PFireEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PFireEffect", "no");
                        }
                        if (es.IceIsleCave1Region == IceIsleCave1Region.IceEffect)
                        {
                            acc.SetTag("PIceEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PIceEffect", "no");
                        }
                        if (es.IceIsleCave1Region == IceIsleCave1Region.ToxicEffect)
                        {
                            acc.SetTag("PToxicEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PToxicEffect", "no");
                        }
                        if (es.IceIsleCave1Region == IceIsleCave1Region.ElectEffect)
                        {
                            acc.SetTag("PElectEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PElectEffect", "no");
                        }
                        if (es.IceIsleCave1Region == IceIsleCave1Region.WaterEffect)
                        {
                            acc.SetTag("PWaterEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PWaterEffect", "no");
                        }
                        if (es.IceIsleCave1Region == IceIsleCave1Region.MistEffect)
                        {
                            acc.SetTag("PMistEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PMistEffect", "no");
                        }
                        if (es.IceIsleCave1Region == IceIsleCave1Region.ExplosionEffect)
                        {
                            acc.SetTag("PExplosionEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PExplosionEffect", "no");
                        }
                        if (es.IceIsleCave1Region == IceIsleCave1Region.StoneEffect)
                        {
                            acc.SetTag("PStoneEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PStoneEffect", "no");
                        }
                        if (es.IceIsleCave1Region == IceIsleCave1Region.ShineyEffect)
                        {
                            acc.SetTag("PShineyEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PShineyEffect", "no");
                        }
                        if (es.IceIsleCave1Region == IceIsleCave1Region.FireFlyEffect)
                        {
                            acc.SetTag("PFireFlyEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PFireFlyEffect", "no");
                        }
                    }
                    else if (mp.Region.IsPartOf("Ice Isle Cave 2"))
                    {
                        if (es.IceIsleCave2Region == IceIsleCave2Region.DarkEffect)
                        {
                            acc.SetTag("PDarkEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PDarkEffect", "no");
                        }
                        if (es.IceIsleCave2Region == IceIsleCave2Region.FireEffect)
                        {
                            acc.SetTag("PFireEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PFireEffect", "no");
                        }
                        if (es.IceIsleCave2Region == IceIsleCave2Region.IceEffect)
                        {
                            acc.SetTag("PIceEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PIceEffect", "no");
                        }
                        if (es.IceIsleCave2Region == IceIsleCave2Region.ToxicEffect)
                        {
                            acc.SetTag("PToxicEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PToxicEffect", "no");
                        }
                        if (es.IceIsleCave2Region == IceIsleCave2Region.ElectEffect)
                        {
                            acc.SetTag("PElectEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PElectEffect", "no");
                        }
                        if (es.IceIsleCave2Region == IceIsleCave2Region.WaterEffect)
                        {
                            acc.SetTag("PWaterEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PWaterEffect", "no");
                        }
                        if (es.IceIsleCave2Region == IceIsleCave2Region.MistEffect)
                        {
                            acc.SetTag("PMistEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PMistEffect", "no");
                        }
                        if (es.IceIsleCave2Region == IceIsleCave2Region.ExplosionEffect)
                        {
                            acc.SetTag("PExplosionEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PExplosionEffect", "no");
                        }
                        if (es.IceIsleCave2Region == IceIsleCave2Region.StoneEffect)
                        {
                            acc.SetTag("PStoneEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PStoneEffect", "no");
                        }
                        if (es.IceIsleCave2Region == IceIsleCave2Region.ShineyEffect)
                        {
                            acc.SetTag("PShineyEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PShineyEffect", "no");
                        }
                        if (es.IceIsleCave2Region == IceIsleCave2Region.FireFlyEffect)
                        {
                            acc.SetTag("PFireFlyEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PFireFlyEffect", "no");
                        }
                    }
                    else if (mp.Region.IsPartOf("North Territory Cave"))
                    {
                        if (es.NorthTerritoryCaveRegion == NorthTerritoryCaveRegion.DarkEffect)
                        {
                            acc.SetTag("PDarkEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PDarkEffect", "no");
                        }
                        if (es.NorthTerritoryCaveRegion == NorthTerritoryCaveRegion.FireEffect)
                        {
                            acc.SetTag("PFireEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PFireEffect", "no");
                        }
                        if (es.NorthTerritoryCaveRegion == NorthTerritoryCaveRegion.IceEffect)
                        {
                            acc.SetTag("PIceEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PIceEffect", "no");
                        }
                        if (es.NorthTerritoryCaveRegion == NorthTerritoryCaveRegion.ToxicEffect)
                        {
                            acc.SetTag("PToxicEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PToxicEffect", "no");
                        }
                        if (es.NorthTerritoryCaveRegion == NorthTerritoryCaveRegion.ElectEffect)
                        {
                            acc.SetTag("PElectEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PElectEffect", "no");
                        }
                        if (es.NorthTerritoryCaveRegion == NorthTerritoryCaveRegion.WaterEffect)
                        {
                            acc.SetTag("PWaterEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PWaterEffect", "no");
                        }
                        if (es.NorthTerritoryCaveRegion == NorthTerritoryCaveRegion.MistEffect)
                        {
                            acc.SetTag("PMistEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PMistEffect", "no");
                        }
                        if (es.NorthTerritoryCaveRegion == NorthTerritoryCaveRegion.ExplosionEffect)
                        {
                            acc.SetTag("PExplosionEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PExplosionEffect", "no");
                        }
                        if (es.NorthTerritoryCaveRegion == NorthTerritoryCaveRegion.StoneEffect)
                        {
                            acc.SetTag("PStoneEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PStoneEffect", "no");
                        }
                        if (es.NorthTerritoryCaveRegion == NorthTerritoryCaveRegion.ShineyEffect)
                        {
                            acc.SetTag("PShineyEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PShineyEffect", "no");
                        }
                        if (es.NorthTerritoryCaveRegion == NorthTerritoryCaveRegion.FireFlyEffect)
                        {
                            acc.SetTag("PFireFlyEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PFireFlyEffect", "no");
                        }
                    }
                    else if (mp.Region.IsPartOf("Yew Cave"))
                    {
                        if (es.YewCaveRegion == YewCaveRegion.DarkEffect)
                        {
                            acc.SetTag("PDarkEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PDarkEffect", "no");
                        }
                        if (es.YewCaveRegion == YewCaveRegion.FireEffect)
                        {
                            acc.SetTag("PFireEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PFireEffect", "no");
                        }
                        if (es.YewCaveRegion == YewCaveRegion.IceEffect)
                        {
                            acc.SetTag("PIceEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PIceEffect", "no");
                        }
                        if (es.YewCaveRegion == YewCaveRegion.ToxicEffect)
                        {
                            acc.SetTag("PToxicEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PToxicEffect", "no");
                        }
                        if (es.YewCaveRegion == YewCaveRegion.ElectEffect)
                        {
                            acc.SetTag("PElectEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PElectEffect", "no");
                        }
                        if (es.YewCaveRegion == YewCaveRegion.WaterEffect)
                        {
                            acc.SetTag("PWaterEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PWaterEffect", "no");
                        }
                        if (es.YewCaveRegion == YewCaveRegion.MistEffect)
                        {
                            acc.SetTag("PMistEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PMistEffect", "no");
                        }
                        if (es.YewCaveRegion == YewCaveRegion.ExplosionEffect)
                        {
                            acc.SetTag("PExplosionEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PExplosionEffect", "no");
                        }
                        if (es.YewCaveRegion == YewCaveRegion.StoneEffect)
                        {
                            acc.SetTag("PStoneEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PStoneEffect", "no");
                        }
                        if (es.YewCaveRegion == YewCaveRegion.ShineyEffect)
                        {
                            acc.SetTag("PShineyEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PShineyEffect", "no");
                        }
                        if (es.YewCaveRegion == YewCaveRegion.FireFlyEffect)
                        {
                            acc.SetTag("PFireFlyEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PFireFlyEffect", "no");
                        }
                    }
                    else if (mp.Region.IsPartOf("North Territory Mine 1"))
                    {
                        if (es.NorthTerritoryMine1Region == NorthTerritoryMine1Region.DarkEffect)
                        {
                            acc.SetTag("PDarkEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PDarkEffect", "no");
                        }
                        if (es.NorthTerritoryMine1Region == NorthTerritoryMine1Region.FireEffect)
                        {
                            acc.SetTag("PFireEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PFireEffect", "no");
                        }
                        if (es.NorthTerritoryMine1Region == NorthTerritoryMine1Region.IceEffect)
                        {
                            acc.SetTag("PIceEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PIceEffect", "no");
                        }
                        if (es.NorthTerritoryMine1Region == NorthTerritoryMine1Region.ToxicEffect)
                        {
                            acc.SetTag("PToxicEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PToxicEffect", "no");
                        }
                        if (es.NorthTerritoryMine1Region == NorthTerritoryMine1Region.ElectEffect)
                        {
                            acc.SetTag("PElectEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PElectEffect", "no");
                        }
                        if (es.NorthTerritoryMine1Region == NorthTerritoryMine1Region.WaterEffect)
                        {
                            acc.SetTag("PWaterEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PWaterEffect", "no");
                        }
                        if (es.NorthTerritoryMine1Region == NorthTerritoryMine1Region.MistEffect)
                        {
                            acc.SetTag("PMistEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PMistEffect", "no");
                        }
                        if (es.NorthTerritoryMine1Region == NorthTerritoryMine1Region.ExplosionEffect)
                        {
                            acc.SetTag("PExplosionEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PExplosionEffect", "no");
                        }
                        if (es.NorthTerritoryMine1Region == NorthTerritoryMine1Region.StoneEffect)
                        {
                            acc.SetTag("PStoneEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PStoneEffect", "no");
                        }
                        if (es.NorthTerritoryMine1Region == NorthTerritoryMine1Region.ShineyEffect)
                        {
                            acc.SetTag("PShineyEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PShineyEffect", "no");
                        }
                        if (es.NorthTerritoryMine1Region == NorthTerritoryMine1Region.FireFlyEffect)
                        {
                            acc.SetTag("PFireFlyEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PFireFlyEffect", "no");
                        }
                    }
                    else if (mp.Region.IsPartOf("North Territory Mine 2"))
                    {
                        if (es.NorthTerritoryMine2Region == NorthTerritoryMine2Region.DarkEffect)
                        {
                            acc.SetTag("PDarkEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PDarkEffect", "no");
                        }
                        if (es.NorthTerritoryMine2Region == NorthTerritoryMine2Region.FireEffect)
                        {
                            acc.SetTag("PFireEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PFireEffect", "no");
                        }
                        if (es.NorthTerritoryMine2Region == NorthTerritoryMine2Region.IceEffect)
                        {
                            acc.SetTag("PIceEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PIceEffect", "no");
                        }
                        if (es.NorthTerritoryMine2Region == NorthTerritoryMine2Region.ToxicEffect)
                        {
                            acc.SetTag("PToxicEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PToxicEffect", "no");
                        }
                        if (es.NorthTerritoryMine2Region == NorthTerritoryMine2Region.ElectEffect)
                        {
                            acc.SetTag("PElectEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PElectEffect", "no");
                        }
                        if (es.NorthTerritoryMine2Region == NorthTerritoryMine2Region.WaterEffect)
                        {
                            acc.SetTag("PWaterEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PWaterEffect", "no");
                        }
                        if (es.NorthTerritoryMine2Region == NorthTerritoryMine2Region.MistEffect)
                        {
                            acc.SetTag("PMistEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PMistEffect", "no");
                        }
                        if (es.NorthTerritoryMine2Region == NorthTerritoryMine2Region.ExplosionEffect)
                        {
                            acc.SetTag("PExplosionEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PExplosionEffect", "no");
                        }
                        if (es.NorthTerritoryMine2Region == NorthTerritoryMine2Region.StoneEffect)
                        {
                            acc.SetTag("PStoneEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PStoneEffect", "no");
                        }
                        if (es.NorthTerritoryMine2Region == NorthTerritoryMine2Region.ShineyEffect)
                        {
                            acc.SetTag("PShineyEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PShineyEffect", "no");
                        }
                        if (es.NorthTerritoryMine2Region == NorthTerritoryMine2Region.FireFlyEffect)
                        {
                            acc.SetTag("PFireFlyEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PFireFlyEffect", "no");
                        }
                    }
                    else if (mp.Region.IsPartOf("Mt Kendall"))
                    {
                        if (es.MtKendallRegion == MtKendallRegion.DarkEffect)
                        {
                            acc.SetTag("PDarkEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PDarkEffect", "no");
                        }
                        if (es.MtKendallRegion == MtKendallRegion.FireEffect)
                        {
                            acc.SetTag("PFireEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PFireEffect", "no");
                        }
                        if (es.MtKendallRegion == MtKendallRegion.IceEffect)
                        {
                            acc.SetTag("PIceEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PIceEffect", "no");
                        }
                        if (es.MtKendallRegion == MtKendallRegion.ToxicEffect)
                        {
                            acc.SetTag("PToxicEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PToxicEffect", "no");
                        }
                        if (es.MtKendallRegion == MtKendallRegion.ElectEffect)
                        {
                            acc.SetTag("PElectEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PElectEffect", "no");
                        }
                        if (es.MtKendallRegion == MtKendallRegion.WaterEffect)
                        {
                            acc.SetTag("PWaterEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PWaterEffect", "no");
                        }
                        if (es.MtKendallRegion == MtKendallRegion.MistEffect)
                        {
                            acc.SetTag("PMistEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PMistEffect", "no");
                        }
                        if (es.MtKendallRegion == MtKendallRegion.ExplosionEffect)
                        {
                            acc.SetTag("PExplosionEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PExplosionEffect", "no");
                        }
                        if (es.MtKendallRegion == MtKendallRegion.StoneEffect)
                        {
                            acc.SetTag("PStoneEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PStoneEffect", "no");
                        }
                        if (es.MtKendallRegion == MtKendallRegion.ShineyEffect)
                        {
                            acc.SetTag("PShineyEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PShineyEffect", "no");
                        }
                        if (es.MtKendallRegion == MtKendallRegion.FireFlyEffect)
                        {
                            acc.SetTag("PFireFlyEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PFireFlyEffect", "no");
                        }
                    }
                    if (mp.Region.IsPartOf("Covetous Mine"))
                    {
                        if (es.CovetousMineRegion == CovetousMineRegion.DarkEffect)
                        {
                            acc.SetTag("PDarkEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PDarkEffect", "no");
                        }
                        if (es.CovetousMineRegion == CovetousMineRegion.FireEffect)
                        {
                            acc.SetTag("PFireEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PFireEffect", "no");
                        }
                        if (es.CovetousMineRegion == CovetousMineRegion.IceEffect)
                        {
                            acc.SetTag("PIceEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PIceEffect", "no");
                        }
                        if (es.CovetousMineRegion == CovetousMineRegion.ToxicEffect)
                        {
                            acc.SetTag("PToxicEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PToxicEffect", "no");
                        }
                        if (es.CovetousMineRegion == CovetousMineRegion.ElectEffect)
                        {
                            acc.SetTag("PElectEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PElectEffect", "no");
                        }
                        if (es.CovetousMineRegion == CovetousMineRegion.WaterEffect)
                        {
                            acc.SetTag("PWaterEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PWaterEffect", "no");
                        }
                        if (es.CovetousMineRegion == CovetousMineRegion.MistEffect)
                        {
                            acc.SetTag("PMistEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PMistEffect", "no");
                        }
                        if (es.CovetousMineRegion == CovetousMineRegion.ExplosionEffect)
                        {
                            acc.SetTag("PExplosionEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PExplosionEffect", "no");
                        }
                        if (es.CovetousMineRegion == CovetousMineRegion.StoneEffect)
                        {
                            acc.SetTag("PStoneEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PStoneEffect", "no");
                        }
                        if (es.CovetousMineRegion == CovetousMineRegion.ShineyEffect)
                        {
                            acc.SetTag("PShineyEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PShineyEffect", "no");
                        }
                        if (es.CovetousMineRegion == CovetousMineRegion.FireFlyEffect)
                        {
                            acc.SetTag("PFireFlyEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PFireFlyEffect", "no");
                        }
                    }
                    else if (mp.Region.IsPartOf("Terathan Keep"))
                    {
                        if (es.TerathanKeepRegion == TerathanKeepRegion.DarkEffect)
                        {
                            acc.SetTag("PDarkEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PDarkEffect", "no");
                        }
                        if (es.TerathanKeepRegion == TerathanKeepRegion.FireEffect)
                        {
                            acc.SetTag("PFireEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PFireEffect", "no");
                        }
                        if (es.TerathanKeepRegion == TerathanKeepRegion.IceEffect)
                        {
                            acc.SetTag("PIceEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PIceEffect", "no");
                        }
                        if (es.TerathanKeepRegion == TerathanKeepRegion.ToxicEffect)
                        {
                            acc.SetTag("PToxicEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PToxicEffect", "no");
                        }
                        if (es.TerathanKeepRegion == TerathanKeepRegion.ElectEffect)
                        {
                            acc.SetTag("PElectEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PElectEffect", "no");
                        }
                        if (es.TerathanKeepRegion == TerathanKeepRegion.WaterEffect)
                        {
                            acc.SetTag("PWaterEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PWaterEffect", "no");
                        }
                        if (es.TerathanKeepRegion == TerathanKeepRegion.MistEffect)
                        {
                            acc.SetTag("PMistEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PMistEffect", "no");
                        }
                        if (es.TerathanKeepRegion == TerathanKeepRegion.ExplosionEffect)
                        {
                            acc.SetTag("PExplosionEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PExplosionEffect", "no");
                        }
                        if (es.TerathanKeepRegion == TerathanKeepRegion.StoneEffect)
                        {
                            acc.SetTag("PStoneEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PStoneEffect", "no");
                        }
                        if (es.TerathanKeepRegion == TerathanKeepRegion.ShineyEffect)
                        {
                            acc.SetTag("PShineyEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PShineyEffect", "no");
                        }
                        if (es.TerathanKeepRegion == TerathanKeepRegion.FireFlyEffect)
                        {
                            acc.SetTag("PFireFlyEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PFireFlyEffect", "no");
                        }
                    }
                    else if (mp.Region.IsPartOf("Fire"))
                    {
                        if (es.FireRegion == FireRegion.DarkEffect)
                        {
                            acc.SetTag("PDarkEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PDarkEffect", "no");
                        }
                        if (es.FireRegion == FireRegion.FireEffect)
                        {
                            acc.SetTag("PFireEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PFireEffect", "no");
                        }
                        if (es.FireRegion == FireRegion.IceEffect)
                        {
                            acc.SetTag("PIceEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PIceEffect", "no");
                        }
                        if (es.FireRegion == FireRegion.ToxicEffect)
                        {
                            acc.SetTag("PToxicEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PToxicEffect", "no");
                        }
                        if (es.FireRegion == FireRegion.ElectEffect)
                        {
                            acc.SetTag("PElectEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PElectEffect", "no");
                        }
                        if (es.FireRegion == FireRegion.WaterEffect)
                        {
                            acc.SetTag("PWaterEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PWaterEffect", "no");
                        }
                        if (es.FireRegion == FireRegion.MistEffect)
                        {
                            acc.SetTag("PMistEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PMistEffect", "no");
                        }
                        if (es.FireRegion == FireRegion.ExplosionEffect)
                        {
                            acc.SetTag("PExplosionEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PExplosionEffect", "no");
                        }
                        if (es.FireRegion == FireRegion.StoneEffect)
                        {
                            acc.SetTag("PStoneEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PStoneEffect", "no");
                        }
                        if (es.FireRegion == FireRegion.ShineyEffect)
                        {
                            acc.SetTag("PShineyEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PShineyEffect", "no");
                        }
                        if (es.FireRegion == FireRegion.FireFlyEffect)
                        {
                            acc.SetTag("PFireFlyEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PFireFlyEffect", "no");
                        }
                    }
                    else if (mp.Region.IsPartOf("Ice"))
                    {
                        if (es.IceRegion == IceRegion.DarkEffect)
                        {
                            acc.SetTag("PDarkEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PDarkEffect", "no");
                        }
                        if (es.IceRegion == IceRegion.FireEffect)
                        {
                            acc.SetTag("PFireEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PFireEffect", "no");
                        }
                        if (es.IceRegion == IceRegion.IceEffect)
                        {
                            acc.SetTag("PIceEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PIceEffect", "no");
                        }
                        if (es.IceRegion == IceRegion.ToxicEffect)
                        {
                            acc.SetTag("PToxicEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PToxicEffect", "no");
                        }
                        if (es.IceRegion == IceRegion.ElectEffect)
                        {
                            acc.SetTag("PElectEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PElectEffect", "no");
                        }
                        if (es.IceRegion == IceRegion.WaterEffect)
                        {
                            acc.SetTag("PWaterEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PWaterEffect", "no");
                        }
                        if (es.IceRegion == IceRegion.MistEffect)
                        {
                            acc.SetTag("PMistEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PMistEffect", "no");
                        }
                        if (es.IceRegion == IceRegion.ExplosionEffect)
                        {
                            acc.SetTag("PExplosionEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PExplosionEffect", "no");
                        }
                        if (es.IceRegion == IceRegion.StoneEffect)
                        {
                            acc.SetTag("PStoneEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PStoneEffect", "no");
                        }
                        if (es.IceRegion == IceRegion.ShineyEffect)
                        {
                            acc.SetTag("PShineyEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PShineyEffect", "no");
                        }
                        if (es.IceRegion == IceRegion.FireFlyEffect)
                        {
                            acc.SetTag("PFireFlyEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PFireFlyEffect", "no");
                        }
                    }
                    else if (mp.Region.IsPartOf("Delucia"))
                    {
                        if (es.DeluciaRegion == DeluciaRegion.DarkEffect)
                        {
                            acc.SetTag("PDarkEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PDarkEffect", "no");
                        }
                        if (es.DeluciaRegion == DeluciaRegion.FireEffect)
                        {
                            acc.SetTag("PFireEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PFireEffect", "no");
                        }
                        if (es.DeluciaRegion == DeluciaRegion.IceEffect)
                        {
                            acc.SetTag("PIceEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PIceEffect", "no");
                        }
                        if (es.DeluciaRegion == DeluciaRegion.ToxicEffect)
                        {
                            acc.SetTag("PToxicEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PToxicEffect", "no");
                        }
                        if (es.DeluciaRegion == DeluciaRegion.ElectEffect)
                        {
                            acc.SetTag("PElectEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PElectEffect", "no");
                        }
                        if (es.DeluciaRegion == DeluciaRegion.WaterEffect)
                        {
                            acc.SetTag("PWaterEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PWaterEffect", "no");
                        }
                        if (es.DeluciaRegion == DeluciaRegion.MistEffect)
                        {
                            acc.SetTag("PMistEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PMistEffect", "no");
                        }
                        if (es.DeluciaRegion == DeluciaRegion.ExplosionEffect)
                        {
                            acc.SetTag("PExplosionEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PExplosionEffect", "no");
                        }
                        if (es.DeluciaRegion == DeluciaRegion.StoneEffect)
                        {
                            acc.SetTag("PStoneEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PStoneEffect", "no");
                        }
                        if (es.DeluciaRegion == DeluciaRegion.ShineyEffect)
                        {
                            acc.SetTag("PShineyEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PShineyEffect", "no");
                        }
                        if (es.DeluciaRegion == DeluciaRegion.FireFlyEffect)
                        {
                            acc.SetTag("PFireFlyEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PFireFlyEffect", "no");
                        }
                    }
                    else if (mp.Region.IsPartOf("Papua"))
                    {
                        if (es.PapuaRegion == PapuaRegion.DarkEffect)
                        {
                            acc.SetTag("PDarkEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PDarkEffect", "no");
                        }
                        if (es.PapuaRegion == PapuaRegion.FireEffect)
                        {
                            acc.SetTag("PFireEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PFireEffect", "no");
                        }
                        if (es.PapuaRegion == PapuaRegion.IceEffect)
                        {
                            acc.SetTag("PIceEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PIceEffect", "no");
                        }
                        if (es.PapuaRegion == PapuaRegion.ToxicEffect)
                        {
                            acc.SetTag("PToxicEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PToxicEffect", "no");
                        }
                        if (es.PapuaRegion == PapuaRegion.ElectEffect)
                        {
                            acc.SetTag("PElectEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PElectEffect", "no");
                        }
                        if (es.PapuaRegion == PapuaRegion.WaterEffect)
                        {
                            acc.SetTag("PWaterEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PWaterEffect", "no");
                        }
                        if (es.PapuaRegion == PapuaRegion.MistEffect)
                        {
                            acc.SetTag("PMistEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PMistEffect", "no");
                        }
                        if (es.PapuaRegion == PapuaRegion.ExplosionEffect)
                        {
                            acc.SetTag("PExplosionEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PExplosionEffect", "no");
                        }
                        if (es.PapuaRegion == PapuaRegion.StoneEffect)
                        {
                            acc.SetTag("PStoneEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PStoneEffect", "no");
                        }
                        if (es.PapuaRegion == PapuaRegion.ShineyEffect)
                        {
                            acc.SetTag("PShineyEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PShineyEffect", "no");
                        }
                        if (es.PapuaRegion == PapuaRegion.FireFlyEffect)
                        {
                            acc.SetTag("PFireFlyEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PFireFlyEffect", "no");
                        }
                    }
                    else if (mp.Region.IsPartOf("Covetous Entrance"))
                    {
                        if (es.CovetousEntRegion == CovetousEntRegion.DarkEffect)
                        {
                            acc.SetTag("PDarkEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PDarkEffect", "no");
                        }
                        if (es.CovetousEntRegion == CovetousEntRegion.FireEffect)
                        {
                            acc.SetTag("PFireEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PFireEffect", "no");
                        }
                        if (es.CovetousEntRegion == CovetousEntRegion.IceEffect)
                        {
                            acc.SetTag("PIceEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PIceEffect", "no");
                        }
                        if (es.CovetousEntRegion == CovetousEntRegion.ToxicEffect)
                        {
                            acc.SetTag("PToxicEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PToxicEffect", "no");
                        }
                        if (es.CovetousEntRegion == CovetousEntRegion.ElectEffect)
                        {
                            acc.SetTag("PElectEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PElectEffect", "no");
                        }
                        if (es.CovetousEntRegion == CovetousEntRegion.WaterEffect)
                        {
                            acc.SetTag("PWaterEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PWaterEffect", "no");
                        }
                        if (es.CovetousEntRegion == CovetousEntRegion.MistEffect)
                        {
                            acc.SetTag("PMistEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PMistEffect", "no");
                        }
                        if (es.CovetousEntRegion == CovetousEntRegion.ExplosionEffect)
                        {
                            acc.SetTag("PExplosionEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PExplosionEffect", "no");
                        }
                        if (es.CovetousEntRegion == CovetousEntRegion.StoneEffect)
                        {
                            acc.SetTag("PStoneEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PStoneEffect", "no");
                        }
                        if (es.CovetousEntRegion == CovetousEntRegion.ShineyEffect)
                        {
                            acc.SetTag("PShineyEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PShineyEffect", "no");
                        }
                        if (es.CovetousEntRegion == CovetousEntRegion.FireFlyEffect)
                        {
                            acc.SetTag("PFireFlyEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PFireFlyEffect", "no");
                        }
                    }
                    else if (mp.Region.IsPartOf("Wrong Entrance"))
                    {
                        if (es.WrongEntrRegion == WrongEntrRegion.DarkEffect)
                        {
                            acc.SetTag("PDarkEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PDarkEffect", "no");
                        }
                        if (es.WrongEntrRegion == WrongEntrRegion.FireEffect)
                        {
                            acc.SetTag("PFireEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PFireEffect", "no");
                        }
                        if (es.WrongEntrRegion == WrongEntrRegion.IceEffect)
                        {
                            acc.SetTag("PIceEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PIceEffect", "no");
                        }
                        if (es.WrongEntrRegion == WrongEntrRegion.ToxicEffect)
                        {
                            acc.SetTag("PToxicEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PToxicEffect", "no");
                        }
                        if (es.WrongEntrRegion == WrongEntrRegion.ElectEffect)
                        {
                            acc.SetTag("PElectEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PElectEffect", "no");
                        }
                        if (es.WrongEntrRegion == WrongEntrRegion.WaterEffect)
                        {
                            acc.SetTag("PWaterEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PWaterEffect", "no");
                        }
                        if (es.WrongEntrRegion == WrongEntrRegion.MistEffect)
                        {
                            acc.SetTag("PMistEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PMistEffect", "no");
                        }
                        if (es.WrongEntrRegion == WrongEntrRegion.ExplosionEffect)
                        {
                            acc.SetTag("PExplosionEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PExplosionEffect", "no");
                        }
                        if (es.WrongEntrRegion == WrongEntrRegion.StoneEffect)
                        {
                            acc.SetTag("PStoneEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PStoneEffect", "no");
                        }
                        if (es.WrongEntrRegion == WrongEntrRegion.ShineyEffect)
                        {
                            acc.SetTag("PShineyEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PShineyEffect", "no");
                        }
                        if (es.WrongEntrRegion == WrongEntrRegion.FireFlyEffect)
                        {
                            acc.SetTag("PFireFlyEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PFireFlyEffect", "no");
                        }
                    }
                    else if (mp.Region.IsPartOf("Despise Entrance"))
                    {
                        if (es.DespiseEntRegion == DespiseEntRegion.DarkEffect)
                        {
                            acc.SetTag("PDarkEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PDarkEffect", "no");
                        }
                        if (es.DespiseEntRegion == DespiseEntRegion.FireEffect)
                        {
                            acc.SetTag("PFireEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PFireEffect", "no");
                        }
                        if (es.DespiseEntRegion == DespiseEntRegion.IceEffect)
                        {
                            acc.SetTag("PIceEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PIceEffect", "no");
                        }
                        if (es.DespiseEntRegion == DespiseEntRegion.ToxicEffect)
                        {
                            acc.SetTag("PToxicEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PToxicEffect", "no");
                        }
                        if (es.DespiseEntRegion == DespiseEntRegion.ElectEffect)
                        {
                            acc.SetTag("PElectEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PElectEffect", "no");
                        }
                        if (es.DespiseEntRegion == DespiseEntRegion.WaterEffect)
                        {
                            acc.SetTag("PWaterEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PWaterEffect", "no");
                        }
                        if (es.DespiseEntRegion == DespiseEntRegion.MistEffect)
                        {
                            acc.SetTag("PMistEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PMistEffect", "no");
                        }
                        if (es.DespiseEntRegion == DespiseEntRegion.ExplosionEffect)
                        {
                            acc.SetTag("PExplosionEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PExplosionEffect", "no");
                        }
                        if (es.DespiseEntRegion == DespiseEntRegion.StoneEffect)
                        {
                            acc.SetTag("PStoneEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PStoneEffect", "no");
                        }
                        if (es.DespiseEntRegion == DespiseEntRegion.ShineyEffect)
                        {
                            acc.SetTag("PShineyEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PShineyEffect", "no");
                        }
                        if (es.DespiseEntRegion == DespiseEntRegion.FireFlyEffect)
                        {
                            acc.SetTag("PFireFlyEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PFireFlyEffect", "no");
                        }
                    }
                    else if (mp.Region.IsPartOf("Despise Passage"))
                    {
                        if (es.DespisePassRegion == DespisePassRegion.DarkEffect)
                        {
                            acc.SetTag("PDarkEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PDarkEffect", "no");
                        }
                        if (es.DespisePassRegion == DespisePassRegion.FireEffect)
                        {
                            acc.SetTag("PFireEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PFireEffect", "no");
                        }
                        if (es.DespisePassRegion == DespisePassRegion.IceEffect)
                        {
                            acc.SetTag("PIceEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PIceEffect", "no");
                        }
                        if (es.DespisePassRegion == DespisePassRegion.ToxicEffect)
                        {
                            acc.SetTag("PToxicEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PToxicEffect", "no");
                        }
                        if (es.DespisePassRegion == DespisePassRegion.ElectEffect)
                        {
                            acc.SetTag("PElectEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PElectEffect", "no");
                        }
                        if (es.DespisePassRegion == DespisePassRegion.WaterEffect)
                        {
                            acc.SetTag("PWaterEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PWaterEffect", "no");
                        }
                        if (es.DespisePassRegion == DespisePassRegion.MistEffect)
                        {
                            acc.SetTag("PMistEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PMistEffect", "no");
                        }
                        if (es.DespisePassRegion == DespisePassRegion.ExplosionEffect)
                        {
                            acc.SetTag("PExplosionEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PExplosionEffect", "no");
                        }
                        if (es.DespisePassRegion == DespisePassRegion.StoneEffect)
                        {
                            acc.SetTag("PStoneEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PStoneEffect", "no");
                        }
                        if (es.DespisePassRegion == DespisePassRegion.ShineyEffect)
                        {
                            acc.SetTag("PShineyEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PShineyEffect", "no");
                        }
                        if (es.DespisePassRegion == DespisePassRegion.FireFlyEffect)
                        {
                            acc.SetTag("PFireFlyEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PFireFlyEffect", "no");
                        }
                    }
                    else if (mp.Region.IsPartOf("North Territory Mine 1"))
                    {
                        if (es.NthTerrMine1Region == NthTerrMine1Region.DarkEffect)
                        {
                            acc.SetTag("PDarkEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PDarkEffect", "no");
                        }
                        if (es.NthTerrMine1Region == NthTerrMine1Region.FireEffect)
                        {
                            acc.SetTag("PFireEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PFireEffect", "no");
                        }
                        if (es.NthTerrMine1Region == NthTerrMine1Region.IceEffect)
                        {
                            acc.SetTag("PIceEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PIceEffect", "no");
                        }
                        if (es.NthTerrMine1Region == NthTerrMine1Region.ToxicEffect)
                        {
                            acc.SetTag("PToxicEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PToxicEffect", "no");
                        }
                        if (es.NthTerrMine1Region == NthTerrMine1Region.ElectEffect)
                        {
                            acc.SetTag("PElectEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PElectEffect", "no");
                        }
                        if (es.NthTerrMine1Region == NthTerrMine1Region.WaterEffect)
                        {
                            acc.SetTag("PWaterEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PWaterEffect", "no");
                        }
                        if (es.NthTerrMine1Region == NthTerrMine1Region.MistEffect)
                        {
                            acc.SetTag("PMistEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PMistEffect", "no");
                        }
                        if (es.NthTerrMine1Region == NthTerrMine1Region.ExplosionEffect)
                        {
                            acc.SetTag("PExplosionEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PExplosionEffect", "no");
                        }
                        if (es.NthTerrMine1Region == NthTerrMine1Region.StoneEffect)
                        {
                            acc.SetTag("PStoneEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PStoneEffect", "no");
                        }
                        if (es.NthTerrMine1Region == NthTerrMine1Region.ShineyEffect)
                        {
                            acc.SetTag("PShineyEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PShineyEffect", "no");
                        }
                        if (es.NthTerrMine1Region == NthTerrMine1Region.FireFlyEffect)
                        {
                            acc.SetTag("PFireFlyEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PFireFlyEffect", "no");
                        }
                    }
                    else if (mp.Region.IsPartOf("Misc Dungeons"))
                    {
                        if (es.MiscDungRegion == MiscDungRegion.DarkEffect)
                        {
                            acc.SetTag("PDarkEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PDarkEffect", "no");
                        }
                        if (es.MiscDungRegion == MiscDungRegion.FireEffect)
                        {
                            acc.SetTag("PFireEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PFireEffect", "no");
                        }
                        if (es.MiscDungRegion == MiscDungRegion.IceEffect)
                        {
                            acc.SetTag("PIceEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PIceEffect", "no");
                        }
                        if (es.MiscDungRegion == MiscDungRegion.ToxicEffect)
                        {
                            acc.SetTag("PToxicEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PToxicEffect", "no");
                        }
                        if (es.MiscDungRegion == MiscDungRegion.ElectEffect)
                        {
                            acc.SetTag("PElectEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PElectEffect", "no");
                        }
                        if (es.MiscDungRegion == MiscDungRegion.WaterEffect)
                        {
                            acc.SetTag("PWaterEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PWaterEffect", "no");
                        }
                        if (es.MiscDungRegion == MiscDungRegion.MistEffect)
                        {
                            acc.SetTag("PMistEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PMistEffect", "no");
                        }
                        if (es.MiscDungRegion == MiscDungRegion.ExplosionEffect)
                        {
                            acc.SetTag("PExplosionEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PExplosionEffect", "no");
                        }
                        if (es.MiscDungRegion == MiscDungRegion.StoneEffect)
                        {
                            acc.SetTag("PStoneEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PStoneEffect", "no");
                        }
                        if (es.MiscDungRegion == MiscDungRegion.ShineyEffect)
                        {
                            acc.SetTag("PShineyEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PShineyEffect", "no");
                        }
                        if (es.MiscDungRegion == MiscDungRegion.FireFlyEffect)
                        {
                            acc.SetTag("PFireFlyEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PFireFlyEffect", "no");
                        }
                    }
                    else if (mp.Region.IsPartOf("Orc Cave"))
                    {
                        if (es.OrcCaveRegion == OrcCaveRegion.DarkEffect)
                        {
                            acc.SetTag("PDarkEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PDarkEffect", "no");
                        }
                        if (es.OrcCaveRegion == OrcCaveRegion.FireEffect)
                        {
                            acc.SetTag("PFireEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PFireEffect", "no");
                        }
                        if (es.OrcCaveRegion == OrcCaveRegion.IceEffect)
                        {
                            acc.SetTag("PIceEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PIceEffect", "no");
                        }
                        if (es.OrcCaveRegion == OrcCaveRegion.ToxicEffect)
                        {
                            acc.SetTag("PToxicEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PToxicEffect", "no");
                        }
                        if (es.OrcCaveRegion == OrcCaveRegion.ElectEffect)
                        {
                            acc.SetTag("PElectEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PElectEffect", "no");
                        }
                        if (es.OrcCaveRegion == OrcCaveRegion.WaterEffect)
                        {
                            acc.SetTag("PWaterEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PWaterEffect", "no");
                        }
                        if (es.OrcCaveRegion == OrcCaveRegion.MistEffect)
                        {
                            acc.SetTag("PMistEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PMistEffect", "no");
                        }
                        if (es.OrcCaveRegion == OrcCaveRegion.ExplosionEffect)
                        {
                            acc.SetTag("PExplosionEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PExplosionEffect", "no");
                        }
                        if (es.OrcCaveRegion == OrcCaveRegion.StoneEffect)
                        {
                            acc.SetTag("PStoneEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PStoneEffect", "no");
                        }
                        if (es.OrcCaveRegion == OrcCaveRegion.ShineyEffect)
                        {
                            acc.SetTag("PShineyEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PShineyEffect", "no");
                        }
                        if (es.OrcCaveRegion == OrcCaveRegion.FireFlyEffect)
                        {
                            acc.SetTag("PFireFlyEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PFireFlyEffect", "no");
                        }
                    }
                    else if (mp.Region.IsPartOf("Haven Island"))
                    {
                        if (es.HavenIsleRegion == HavenIsleRegion.DarkEffect)
                        {
                            acc.SetTag("PDarkEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PDarkEffect", "no");
                        }
                        if (es.HavenIsleRegion == HavenIsleRegion.FireEffect)
                        {
                            acc.SetTag("PFireEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PFireEffect", "no");
                        }
                        if (es.HavenIsleRegion == HavenIsleRegion.IceEffect)
                        {
                            acc.SetTag("PIceEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PIceEffect", "no");
                        }
                        if (es.HavenIsleRegion == HavenIsleRegion.ToxicEffect)
                        {
                            acc.SetTag("PToxicEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PToxicEffect", "no");
                        }
                        if (es.HavenIsleRegion == HavenIsleRegion.ElectEffect)
                        {
                            acc.SetTag("PElectEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PElectEffect", "no");
                        }
                        if (es.HavenIsleRegion == HavenIsleRegion.WaterEffect)
                        {
                            acc.SetTag("PWaterEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PWaterEffect", "no");
                        }
                        if (es.HavenIsleRegion == HavenIsleRegion.MistEffect)
                        {
                            acc.SetTag("PMistEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PMistEffect", "no");
                        }
                        if (es.HavenIsleRegion == HavenIsleRegion.ExplosionEffect)
                        {
                            acc.SetTag("PExplosionEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PExplosionEffect", "no");
                        }
                        if (es.HavenIsleRegion == HavenIsleRegion.StoneEffect)
                        {
                            acc.SetTag("PStoneEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PStoneEffect", "no");
                        }
                        if (es.HavenIsleRegion == HavenIsleRegion.ShineyEffect)
                        {
                            acc.SetTag("PShineyEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PShineyEffect", "no");
                        }
                        if (es.HavenIsleRegion == HavenIsleRegion.FireFlyEffect)
                        {
                            acc.SetTag("PFireFlyEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PFireFlyEffect", "no");
                        }
                    }
                    else if (mp.Region.IsPartOf("Shrine of Valor"))
                    {
                        if (es.ShrineofValorRegion == ShrineofValorRegion.DarkEffect)
                        {
                            acc.SetTag("PDarkEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PDarkEffect", "no");
                        }
                        if (es.ShrineofValorRegion == ShrineofValorRegion.FireEffect)
                        {
                            acc.SetTag("PFireEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PFireEffect", "no");
                        }
                        if (es.ShrineofValorRegion == ShrineofValorRegion.IceEffect)
                        {
                            acc.SetTag("PIceEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PIceEffect", "no");
                        }
                        if (es.ShrineofValorRegion == ShrineofValorRegion.ToxicEffect)
                        {
                            acc.SetTag("PToxicEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PToxicEffect", "no");
                        }
                        if (es.ShrineofValorRegion == ShrineofValorRegion.ElectEffect)
                        {
                            acc.SetTag("PElectEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PElectEffect", "no");
                        }
                        if (es.ShrineofValorRegion == ShrineofValorRegion.WaterEffect)
                        {
                            acc.SetTag("PWaterEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PWaterEffect", "no");
                        }
                        if (es.ShrineofValorRegion == ShrineofValorRegion.MistEffect)
                        {
                            acc.SetTag("PMistEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PMistEffect", "no");
                        }
                        if (es.ShrineofValorRegion == ShrineofValorRegion.ExplosionEffect)
                        {
                            acc.SetTag("PExplosionEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PExplosionEffect", "no");
                        }
                        if (es.ShrineofValorRegion == ShrineofValorRegion.StoneEffect)
                        {
                            acc.SetTag("PStoneEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PStoneEffect", "no");
                        }
                        if (es.ShrineofValorRegion == ShrineofValorRegion.ShineyEffect)
                        {
                            acc.SetTag("PShineyEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PShineyEffect", "no");
                        }
                        if (es.ShrineofValorRegion == ShrineofValorRegion.FireFlyEffect)
                        {
                            acc.SetTag("PFireFlyEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PFireFlyEffect", "no");
                        }
                    }
                    else if (mp.Region.IsPartOf("Chaos Shrine"))
                    {
                        if (es.ChaosShrineRegion == ChaosShrineRegion.DarkEffect)
                        {
                            acc.SetTag("PDarkEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PDarkEffect", "no");
                        }
                        if (es.ChaosShrineRegion == ChaosShrineRegion.FireEffect)
                        {
                            acc.SetTag("PFireEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PFireEffect", "no");
                        }
                        if (es.ChaosShrineRegion == ChaosShrineRegion.IceEffect)
                        {
                            acc.SetTag("PIceEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PIceEffect", "no");
                        }
                        if (es.ChaosShrineRegion == ChaosShrineRegion.ToxicEffect)
                        {
                            acc.SetTag("PToxicEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PToxicEffect", "no");
                        }
                        if (es.ChaosShrineRegion == ChaosShrineRegion.ElectEffect)
                        {
                            acc.SetTag("PElectEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PElectEffect", "no");
                        }
                        if (es.ChaosShrineRegion == ChaosShrineRegion.WaterEffect)
                        {
                            acc.SetTag("PWaterEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PWaterEffect", "no");
                        }
                        if (es.ChaosShrineRegion == ChaosShrineRegion.MistEffect)
                        {
                            acc.SetTag("PMistEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PMistEffect", "no");
                        }
                        if (es.ChaosShrineRegion == ChaosShrineRegion.ExplosionEffect)
                        {
                            acc.SetTag("PExplosionEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PExplosionEffect", "no");
                        }
                        if (es.ChaosShrineRegion == ChaosShrineRegion.StoneEffect)
                        {
                            acc.SetTag("PStoneEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PStoneEffect", "no");
                        }
                        if (es.ChaosShrineRegion == ChaosShrineRegion.ShineyEffect)
                        {
                            acc.SetTag("PShineyEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PShineyEffect", "no");
                        }
                        if (es.ChaosShrineRegion == ChaosShrineRegion.FireFlyEffect)
                        {
                            acc.SetTag("PFireFlyEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PFireFlyEffect", "no");
                        }
                    }
                    else if (mp.Region.IsPartOf("Shrine of Sacrifice"))
                    {
                        if (es.ShrineofSacrificeRegion == ShrineofSacrificeRegion.DarkEffect)
                        {
                            acc.SetTag("PDarkEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PDarkEffect", "no");
                        }
                        if (es.ShrineofSacrificeRegion == ShrineofSacrificeRegion.FireEffect)
                        {
                            acc.SetTag("PFireEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PFireEffect", "no");
                        }
                        if (es.ShrineofSacrificeRegion == ShrineofSacrificeRegion.IceEffect)
                        {
                            acc.SetTag("PIceEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PIceEffect", "no");
                        }
                        if (es.ShrineofSacrificeRegion == ShrineofSacrificeRegion.ToxicEffect)
                        {
                            acc.SetTag("PToxicEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PToxicEffect", "no");
                        }
                        if (es.ShrineofSacrificeRegion == ShrineofSacrificeRegion.ElectEffect)
                        {
                            acc.SetTag("PElectEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PElectEffect", "no");
                        }
                        if (es.ShrineofSacrificeRegion == ShrineofSacrificeRegion.WaterEffect)
                        {
                            acc.SetTag("PWaterEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PWaterEffect", "no");
                        }
                        if (es.ShrineofSacrificeRegion == ShrineofSacrificeRegion.MistEffect)
                        {
                            acc.SetTag("PMistEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PMistEffect", "no");
                        }
                        if (es.ShrineofSacrificeRegion == ShrineofSacrificeRegion.ExplosionEffect)
                        {
                            acc.SetTag("PExplosionEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PExplosionEffect", "no");
                        }
                        if (es.ShrineofSacrificeRegion == ShrineofSacrificeRegion.StoneEffect)
                        {
                            acc.SetTag("PStoneEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PStoneEffect", "no");
                        }
                        if (es.ShrineofSacrificeRegion == ShrineofSacrificeRegion.ShineyEffect)
                        {
                            acc.SetTag("PShineyEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PShineyEffect", "no");
                        }
                        if (es.ShrineofSacrificeRegion == ShrineofSacrificeRegion.FireFlyEffect)
                        {
                            acc.SetTag("PFireFlyEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PFireFlyEffect", "no");
                        }
                    }
                    else if (mp.Region.IsPartOf("Shrine of Honesty"))
                    {
                        if (es.ShrineofHonestyRegion == ShrineofHonestyRegion.DarkEffect)
                        {
                            acc.SetTag("PDarkEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PDarkEffect", "no");
                        }
                        if (es.ShrineofHonestyRegion == ShrineofHonestyRegion.FireEffect)
                        {
                            acc.SetTag("PFireEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PFireEffect", "no");
                        }
                        if (es.ShrineofHonestyRegion == ShrineofHonestyRegion.IceEffect)
                        {
                            acc.SetTag("PIceEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PIceEffect", "no");
                        }
                        if (es.ShrineofHonestyRegion == ShrineofHonestyRegion.ToxicEffect)
                        {
                            acc.SetTag("PToxicEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PToxicEffect", "no");
                        }
                        if (es.ShrineofHonestyRegion == ShrineofHonestyRegion.ElectEffect)
                        {
                            acc.SetTag("PElectEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PElectEffect", "no");
                        }
                        if (es.ShrineofHonestyRegion == ShrineofHonestyRegion.WaterEffect)
                        {
                            acc.SetTag("PWaterEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PWaterEffect", "no");
                        }
                        if (es.ShrineofHonestyRegion == ShrineofHonestyRegion.MistEffect)
                        {
                            acc.SetTag("PMistEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PMistEffect", "no");
                        }
                        if (es.ShrineofHonestyRegion == ShrineofHonestyRegion.ExplosionEffect)
                        {
                            acc.SetTag("PExplosionEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PExplosionEffect", "no");
                        }
                        if (es.ShrineofHonestyRegion == ShrineofHonestyRegion.StoneEffect)
                        {
                            acc.SetTag("PStoneEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PStoneEffect", "no");
                        }
                        if (es.ShrineofHonestyRegion == ShrineofHonestyRegion.ShineyEffect)
                        {
                            acc.SetTag("PShineyEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PShineyEffect", "no");
                        }
                        if (es.ShrineofHonestyRegion == ShrineofHonestyRegion.FireFlyEffect)
                        {
                            acc.SetTag("PFireFlyEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PFireFlyEffect", "no");
                        }
                    }
                    else if (mp.Region.IsPartOf("Shrine of Compassion"))
                    {
                        if (es.ShrineofCompassionRegion == ShrineofCompassionRegion.DarkEffect)
                        {
                            acc.SetTag("PDarkEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PDarkEffect", "no");
                        }
                        if (es.ShrineofCompassionRegion == ShrineofCompassionRegion.FireEffect)
                        {
                            acc.SetTag("PFireEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PFireEffect", "no");
                        }
                        if (es.ShrineofCompassionRegion == ShrineofCompassionRegion.IceEffect)
                        {
                            acc.SetTag("PIceEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PIceEffect", "no");
                        }
                        if (es.ShrineofCompassionRegion == ShrineofCompassionRegion.ToxicEffect)
                        {
                            acc.SetTag("PToxicEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PToxicEffect", "no");
                        }
                        if (es.ShrineofCompassionRegion == ShrineofCompassionRegion.ElectEffect)
                        {
                            acc.SetTag("PElectEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PElectEffect", "no");
                        }
                        if (es.ShrineofCompassionRegion == ShrineofCompassionRegion.WaterEffect)
                        {
                            acc.SetTag("PWaterEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PWaterEffect", "no");
                        }
                        if (es.ShrineofCompassionRegion == ShrineofCompassionRegion.MistEffect)
                        {
                            acc.SetTag("PMistEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PMistEffect", "no");
                        }
                        if (es.ShrineofCompassionRegion == ShrineofCompassionRegion.ExplosionEffect)
                        {
                            acc.SetTag("PExplosionEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PExplosionEffect", "no");
                        }
                        if (es.ShrineofCompassionRegion == ShrineofCompassionRegion.StoneEffect)
                        {
                            acc.SetTag("PStoneEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PStoneEffect", "no");
                        }
                        if (es.ShrineofCompassionRegion == ShrineofCompassionRegion.ShineyEffect)
                        {
                            acc.SetTag("PShineyEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PShineyEffect", "no");
                        }
                        if (es.ShrineofCompassionRegion == ShrineofCompassionRegion.FireFlyEffect)
                        {
                            acc.SetTag("PFireFlyEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PFireFlyEffect", "no");
                        }
                    }
                    else if (mp.Region.IsPartOf("Shrine of Spirituality"))
                    {
                        if (es.ShrineofSpiritualityRegion == ShrineofSpiritualityRegion.DarkEffect)
                        {
                            acc.SetTag("PDarkEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PDarkEffect", "no");
                        }
                        if (es.ShrineofSpiritualityRegion == ShrineofSpiritualityRegion.FireEffect)
                        {
                            acc.SetTag("PFireEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PFireEffect", "no");
                        }
                        if (es.ShrineofSpiritualityRegion == ShrineofSpiritualityRegion.IceEffect)
                        {
                            acc.SetTag("PIceEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PIceEffect", "no");
                        }
                        if (es.ShrineofSpiritualityRegion == ShrineofSpiritualityRegion.ToxicEffect)
                        {
                            acc.SetTag("PToxicEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PToxicEffect", "no");
                        }
                        if (es.ShrineofSpiritualityRegion == ShrineofSpiritualityRegion.ElectEffect)
                        {
                            acc.SetTag("PElectEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PElectEffect", "no");
                        }
                        if (es.ShrineofSpiritualityRegion == ShrineofSpiritualityRegion.WaterEffect)
                        {
                            acc.SetTag("PWaterEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PWaterEffect", "no");
                        }
                        if (es.ShrineofSpiritualityRegion == ShrineofSpiritualityRegion.MistEffect)
                        {
                            acc.SetTag("PMistEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PMistEffect", "no");
                        }
                        if (es.ShrineofSpiritualityRegion == ShrineofSpiritualityRegion.ExplosionEffect)
                        {
                            acc.SetTag("PExplosionEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PExplosionEffect", "no");
                        }
                        if (es.ShrineofSpiritualityRegion == ShrineofSpiritualityRegion.StoneEffect)
                        {
                            acc.SetTag("PStoneEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PStoneEffect", "no");
                        }
                        if (es.ShrineofSpiritualityRegion == ShrineofSpiritualityRegion.ShineyEffect)
                        {
                            acc.SetTag("PShineyEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PShineyEffect", "no");
                        }
                        if (es.ShrineofSpiritualityRegion == ShrineofSpiritualityRegion.FireFlyEffect)
                        {
                            acc.SetTag("PFireFlyEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PFireFlyEffect", "no");
                        }
                    }
                    else if (mp.Region.IsPartOf("Humility"))
                    {

                        if (es.HumilityRegion == HumilityRegion.DarkEffect)
                        {
                            acc.SetTag("PDarkEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PDarkEffect", "no");
                        }
                        if (es.HumilityRegion == HumilityRegion.FireEffect)
                        {
                            acc.SetTag("PFireEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PFireEffect", "no");
                        }
                        if (es.HumilityRegion == HumilityRegion.IceEffect)
                        {
                            acc.SetTag("PIceEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PIceEffect", "no");
                        }
                        if (es.HumilityRegion == HumilityRegion.ToxicEffect)
                        {
                            acc.SetTag("PToxicEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PToxicEffect", "no");
                        }
                        if (es.HumilityRegion == HumilityRegion.ElectEffect)
                        {
                            acc.SetTag("PElectEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PElectEffect", "no");
                        }
                        if (es.HumilityRegion == HumilityRegion.WaterEffect)
                        {
                            acc.SetTag("PWaterEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PWaterEffect", "no");
                        }
                        if (es.HumilityRegion == HumilityRegion.MistEffect)
                        {
                            acc.SetTag("PMistEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PMistEffect", "no");
                        }
                        if (es.HumilityRegion == HumilityRegion.ExplosionEffect)
                        {
                            acc.SetTag("PExplosionEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PExplosionEffect", "no");
                        }
                        if (es.HumilityRegion == HumilityRegion.StoneEffect)
                        {
                            acc.SetTag("PStoneEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PStoneEffect", "no");
                        }
                        if (es.HumilityRegion == HumilityRegion.ShineyEffect)
                        {
                            acc.SetTag("PShineyEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PShineyEffect", "no");
                        }
                        if (es.HumilityRegion == HumilityRegion.FireFlyEffect)
                        {
                            acc.SetTag("PFireFlyEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PFireFlyEffect", "no");
                        }
                    }
                    else if (mp.Region.IsPartOf("Honor"))
                    {
                        if (es.HonorRegion == HonorRegion.DarkEffect)
                        {

                            acc.SetTag("PDarkEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PDarkEffect", "no");
                        }
                        if (es.HonorRegion == HonorRegion.FireEffect)
                        {
                            acc.SetTag("PFireEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PFireEffect", "no");
                        }
                        if (es.HonorRegion == HonorRegion.IceEffect)
                        {
                            acc.SetTag("PIceEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PIceEffect", "no");
                        }
                        if (es.HonorRegion == HonorRegion.ToxicEffect)
                        {
                            acc.SetTag("PToxicEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PToxicEffect", "no");
                        }
                        if (es.HonorRegion == HonorRegion.ElectEffect)
                        {
                            acc.SetTag("PElectEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PElectEffect", "no");
                        }
                        if (es.HonorRegion == HonorRegion.WaterEffect)
                        {
                            acc.SetTag("PWaterEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PWaterEffect", "no");
                        }
                        if (es.HonorRegion == HonorRegion.MistEffect)
                        {
                            acc.SetTag("PMistEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PMistEffect", "no");
                        }
                        if (es.HonorRegion == HonorRegion.ExplosionEffect)
                        {
                            acc.SetTag("PExplosionEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PExplosionEffect", "no");
                        }
                        if (es.HonorRegion == HonorRegion.StoneEffect)
                        {
                            acc.SetTag("PStoneEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PStoneEffect", "no");
                        }
                        if (es.HonorRegion == HonorRegion.ShineyEffect)
                        {
                            acc.SetTag("PShineyEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PShineyEffect", "no");
                        }
                        if (es.HonorRegion == HonorRegion.FireFlyEffect)
                        {
                            acc.SetTag("PFireFlyEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PFireFlyEffect", "no");
                        }
                    }
                    else if (mp.Region.IsPartOf("Terort Skitas"))
                    {
                        if (es.TerortSkitasRegion == TerortSkitasRegion.DarkEffect)
                        {
                            acc.SetTag("PDarkEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PDarkEffect", "no");
                        }
                        if (es.TerortSkitasRegion == TerortSkitasRegion.FireEffect)
                        {
                            acc.SetTag("PFireEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PFireEffect", "no");
                        }
                        if (es.TerortSkitasRegion == TerortSkitasRegion.IceEffect)
                        {
                            acc.SetTag("PIceEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PIceEffect", "no");
                        }
                        if (es.TerortSkitasRegion == TerortSkitasRegion.ToxicEffect)
                        {
                            acc.SetTag("PToxicEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PToxicEffect", "no");
                        }
                        if (es.TerortSkitasRegion == TerortSkitasRegion.ElectEffect)
                        {
                            acc.SetTag("PElectEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PElectEffect", "no");
                        }
                        if (es.TerortSkitasRegion == TerortSkitasRegion.WaterEffect)
                        {
                            acc.SetTag("PWaterEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PWaterEffect", "no");
                        }
                        if (es.TerortSkitasRegion == TerortSkitasRegion.MistEffect)
                        {
                            acc.SetTag("PMistEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PMistEffect", "no");
                        }
                        if (es.TerortSkitasRegion == TerortSkitasRegion.ExplosionEffect)
                        {
                            acc.SetTag("PExplosionEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PExplosionEffect", "no");
                        }
                        if (es.TerortSkitasRegion == TerortSkitasRegion.StoneEffect)
                        {
                            acc.SetTag("PStoneEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PStoneEffect", "no");
                        }
                        if (es.TerortSkitasRegion == TerortSkitasRegion.ShineyEffect)
                        {
                            acc.SetTag("PShineyEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PShineyEffect", "no");
                        }
                        if (es.TerortSkitasRegion == TerortSkitasRegion.FireFlyEffect)
                        {
                            acc.SetTag("PFireFlyEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PFireFlyEffect", "no");
                        }
                    }
                    else if (mp.Region.IsPartOf("Gargoyle City"))
                    {
                        if (es.GargoyleCityRegion == GargoyleCityRegion.DarkEffect)
                        {
                            acc.SetTag("PDarkEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PDarkEffect", "no");
                        }
                        if (es.GargoyleCityRegion == GargoyleCityRegion.FireEffect)
                        {
                            acc.SetTag("PFireEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PFireEffect", "no");
                        }
                        if (es.GargoyleCityRegion == GargoyleCityRegion.IceEffect)
                        {
                            acc.SetTag("PIceEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PIceEffect", "no");
                        }
                        if (es.GargoyleCityRegion == GargoyleCityRegion.ToxicEffect)
                        {
                            acc.SetTag("PToxicEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PToxicEffect", "no");
                        }
                        if (es.GargoyleCityRegion == GargoyleCityRegion.ElectEffect)
                        {
                            acc.SetTag("PElectEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PElectEffect", "no");
                        }
                        if (es.GargoyleCityRegion == GargoyleCityRegion.WaterEffect)
                        {
                            acc.SetTag("PWaterEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PWaterEffect", "no");
                        }
                        if (es.GargoyleCityRegion == GargoyleCityRegion.MistEffect)
                        {
                            acc.SetTag("PMistEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PMistEffect", "no");
                        }
                        if (es.GargoyleCityRegion == GargoyleCityRegion.ExplosionEffect)
                        {
                            acc.SetTag("PExplosionEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PExplosionEffect", "no");
                        }
                        if (es.GargoyleCityRegion == GargoyleCityRegion.StoneEffect)
                        {
                            acc.SetTag("PStoneEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PStoneEffect", "no");
                        }
                        if (es.GargoyleCityRegion == GargoyleCityRegion.ShineyEffect)
                        {
                            acc.SetTag("PShineyEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PShineyEffect", "no");
                        }
                        if (es.GargoyleCityRegion == GargoyleCityRegion.FireFlyEffect)
                        {
                            acc.SetTag("PFireFlyEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PFireFlyEffect", "no");
                        }
                    }
                    else if (mp.Region.IsPartOf("Pormir Harm"))
                    {
                        if (es.PormirHarmRegion == PormirHarmRegion.DarkEffect)
                        {
                            acc.SetTag("PDarkEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PDarkEffect", "no");
                        }
                        if (es.PormirHarmRegion == PormirHarmRegion.FireEffect)
                        {
                            acc.SetTag("PFireEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PFireEffect", "no");
                        }
                        if (es.PormirHarmRegion == PormirHarmRegion.IceEffect)
                        {
                            acc.SetTag("PIceEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PIceEffect", "no");
                        }
                        if (es.PormirHarmRegion == PormirHarmRegion.ToxicEffect)
                        {
                            acc.SetTag("PToxicEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PToxicEffect", "no");
                        }
                        if (es.PormirHarmRegion == PormirHarmRegion.ElectEffect)
                        {
                            acc.SetTag("PElectEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PElectEffect", "no");
                        }
                        if (es.PormirHarmRegion == PormirHarmRegion.WaterEffect)
                        {
                            acc.SetTag("PWaterEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PWaterEffect", "no");
                        }
                        if (es.PormirHarmRegion == PormirHarmRegion.MistEffect)
                        {
                            acc.SetTag("PMistEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PMistEffect", "no");
                        }
                        if (es.PormirHarmRegion == PormirHarmRegion.ExplosionEffect)
                        {
                            acc.SetTag("PExplosionEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PExplosionEffect", "no");
                        }
                        if (es.PormirHarmRegion == PormirHarmRegion.StoneEffect)
                        {
                            acc.SetTag("PStoneEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PStoneEffect", "no");
                        }
                        if (es.PormirHarmRegion == PormirHarmRegion.ShineyEffect)
                        {
                            acc.SetTag("PShineyEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PShineyEffect", "no");
                        }
                        if (es.PormirHarmRegion == PormirHarmRegion.FireFlyEffect)
                        {
                            acc.SetTag("PFireFlyEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PFireFlyEffect", "no");
                        }
                    }
                    else if (mp.Region.IsPartOf("Pormir Felwis"))
                    {
                        if (es.PormirFelwisRegion == PormirFelwisRegion.DarkEffect)
                        {
                            acc.SetTag("PDarkEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PDarkEffect", "no");
                        }
                        if (es.PormirFelwisRegion == PormirFelwisRegion.FireEffect)
                        {
                            acc.SetTag("PFireEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PFireEffect", "no");
                        }
                        if (es.PormirFelwisRegion == PormirFelwisRegion.IceEffect)
                        {
                            acc.SetTag("PIceEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PIceEffect", "no");
                        }
                        if (es.PormirFelwisRegion == PormirFelwisRegion.ToxicEffect)
                        {
                            acc.SetTag("PToxicEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PToxicEffect", "no");
                        }
                        if (es.PormirFelwisRegion == PormirFelwisRegion.ElectEffect)
                        {
                            acc.SetTag("PElectEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PElectEffect", "no");
                        }
                        if (es.PormirFelwisRegion == PormirFelwisRegion.WaterEffect)
                        {
                            acc.SetTag("PWaterEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PWaterEffect", "no");
                        }
                        if (es.PormirFelwisRegion == PormirFelwisRegion.MistEffect)
                        {
                            acc.SetTag("PMistEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PMistEffect", "no");
                        }
                        if (es.PormirFelwisRegion == PormirFelwisRegion.ExplosionEffect)
                        {
                            acc.SetTag("PExplosionEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PExplosionEffect", "no");
                        }
                        if (es.PormirFelwisRegion == PormirFelwisRegion.StoneEffect)
                        {
                            acc.SetTag("PStoneEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PStoneEffect", "no");
                        }
                        if (es.PormirFelwisRegion == PormirFelwisRegion.ShineyEffect)
                        {
                            acc.SetTag("PShineyEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PShineyEffect", "no");
                        }
                        if (es.PormirFelwisRegion == PormirFelwisRegion.FireFlyEffect)
                        {
                            acc.SetTag("PFireFlyEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PFireFlyEffect", "no");
                        }
                    }
                    else if (mp.Region.IsPartOf("Cyclops Temple"))
                    {
                        if (es.CyclopsTempleRegion == CyclopsTempleRegion.DarkEffect)
                        {
                            acc.SetTag("PDarkEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PDarkEffect", "no");
                        }
                        if (es.CyclopsTempleRegion == CyclopsTempleRegion.FireEffect)
                        {
                            acc.SetTag("PFireEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PFireEffect", "no");
                        }
                        if (es.CyclopsTempleRegion == CyclopsTempleRegion.IceEffect)
                        {
                            acc.SetTag("PIceEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PIceEffect", "no");
                        }
                        if (es.CyclopsTempleRegion == CyclopsTempleRegion.ToxicEffect)
                        {
                            acc.SetTag("PToxicEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PToxicEffect", "no");
                        }
                        if (es.CyclopsTempleRegion == CyclopsTempleRegion.ElectEffect)
                        {
                            acc.SetTag("PElectEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PElectEffect", "no");
                        }
                        if (es.CyclopsTempleRegion == CyclopsTempleRegion.WaterEffect)
                        {
                            acc.SetTag("PWaterEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PWaterEffect", "no");
                        }
                        if (es.CyclopsTempleRegion == CyclopsTempleRegion.MistEffect)
                        {
                            acc.SetTag("PMistEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PMistEffect", "no");
                        }
                        if (es.CyclopsTempleRegion == CyclopsTempleRegion.ExplosionEffect)
                        {
                            acc.SetTag("PExplosionEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PExplosionEffect", "no");
                        }
                        if (es.CyclopsTempleRegion == CyclopsTempleRegion.StoneEffect)
                        {
                            acc.SetTag("PStoneEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PStoneEffect", "no");
                        }
                        if (es.CyclopsTempleRegion == CyclopsTempleRegion.ShineyEffect)
                        {
                            acc.SetTag("PShineyEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PShineyEffect", "no");
                        }
                        if (es.CyclopsTempleRegion == CyclopsTempleRegion.FireFlyEffect)
                        {
                            acc.SetTag("PFireFlyEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PFireFlyEffect", "no");
                        }
                    }
                    else if (mp.Region.IsPartOf("Rat Fort"))
                    {
                        if (es.RatFortRegion == RatFortRegion.DarkEffect)
                        {
                            acc.SetTag("PDarkEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PDarkEffect", "no");
                        }
                        if (es.RatFortRegion == RatFortRegion.FireEffect)
                        {
                            acc.SetTag("PFireEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PFireEffect", "no");
                        }
                        if (es.RatFortRegion == RatFortRegion.IceEffect)
                        {
                            acc.SetTag("PIceEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PIceEffect", "no");
                        }
                        if (es.RatFortRegion == RatFortRegion.ToxicEffect)
                        {
                            acc.SetTag("PToxicEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PToxicEffect", "no");
                        }
                        if (es.RatFortRegion == RatFortRegion.ElectEffect)
                        {
                            acc.SetTag("PElectEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PElectEffect", "no");
                        }
                        if (es.RatFortRegion == RatFortRegion.WaterEffect)
                        {
                            acc.SetTag("PWaterEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PWaterEffect", "no");
                        }
                        if (es.RatFortRegion == RatFortRegion.MistEffect)
                        {
                            acc.SetTag("PMistEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PMistEffect", "no");
                        }
                        if (es.RatFortRegion == RatFortRegion.ExplosionEffect)
                        {
                            acc.SetTag("PExplosionEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PExplosionEffect", "no");
                        }
                        if (es.RatFortRegion == RatFortRegion.StoneEffect)
                        {
                            acc.SetTag("PStoneEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PStoneEffect", "no");
                        }
                        if (es.RatFortRegion == RatFortRegion.ShineyEffect)
                        {
                            acc.SetTag("PShineyEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PShineyEffect", "no");
                        }
                        if (es.RatFortRegion == RatFortRegion.FireFlyEffect)
                        {
                            acc.SetTag("PFireFlyEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PFireFlyEffect", "no");
                        }
                    }
                    else if (mp.Region.IsPartOf("Rat Fort Cellar"))
                    {
                        if (es.RatFortCellarRegion == RatFortCellarRegion.DarkEffect)
                        {
                            acc.SetTag("PDarkEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PDarkEffect", "no");
                        }
                        if (es.RatFortCellarRegion == RatFortCellarRegion.FireEffect)
                        {
                            acc.SetTag("PFireEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PFireEffect", "no");
                        }
                        if (es.RatFortCellarRegion == RatFortCellarRegion.IceEffect)
                        {
                            acc.SetTag("PIceEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PIceEffect", "no");
                        }
                        if (es.RatFortCellarRegion == RatFortCellarRegion.ToxicEffect)
                        {
                            acc.SetTag("PToxicEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PToxicEffect", "no");
                        }
                        if (es.RatFortCellarRegion == RatFortCellarRegion.ElectEffect)
                        {
                            acc.SetTag("PElectEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PElectEffect", "no");
                        }
                        if (es.RatFortCellarRegion == RatFortCellarRegion.WaterEffect)
                        {
                            acc.SetTag("PWaterEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PWaterEffect", "no");
                        }
                        if (es.RatFortCellarRegion == RatFortCellarRegion.MistEffect)
                        {
                            acc.SetTag("PMistEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PMistEffect", "no");
                        }
                        if (es.RatFortCellarRegion == RatFortCellarRegion.ExplosionEffect)
                        {
                            acc.SetTag("PExplosionEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PExplosionEffect", "no");
                        }
                        if (es.RatFortCellarRegion == RatFortCellarRegion.StoneEffect)
                        {
                            acc.SetTag("PStoneEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PStoneEffect", "no");
                        }
                        if (es.RatFortCellarRegion == RatFortCellarRegion.ShineyEffect)
                        {
                            acc.SetTag("PShineyEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PShineyEffect", "no");
                        }
                        if (es.RatFortCellarRegion == RatFortCellarRegion.FireFlyEffect)
                        {
                            acc.SetTag("PFireFlyEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PFireFlyEffect", "no");
                        }
                    }
                    else if (mp.Region.IsPartOf("Entrace to Central Ilshenar 1"))
                    {
                        if (es.EntCentIlsh1Region == EntCentIlsh1Region.DarkEffect)
                        {
                            acc.SetTag("PDarkEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PDarkEffect", "no");
                        }
                        if (es.EntCentIlsh1Region == EntCentIlsh1Region.FireEffect)
                        {
                            acc.SetTag("PFireEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PFireEffect", "no");
                        }
                        if (es.EntCentIlsh1Region == EntCentIlsh1Region.IceEffect)
                        {
                            acc.SetTag("PIceEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PIceEffect", "no");
                        }
                        if (es.EntCentIlsh1Region == EntCentIlsh1Region.ToxicEffect)
                        {
                            acc.SetTag("PToxicEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PToxicEffect", "no");
                        }
                        if (es.EntCentIlsh1Region == EntCentIlsh1Region.ElectEffect)
                        {
                            acc.SetTag("PElectEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PElectEffect", "no");
                        }
                        if (es.EntCentIlsh1Region == EntCentIlsh1Region.WaterEffect)
                        {
                            acc.SetTag("PWaterEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PWaterEffect", "no");
                        }
                        if (es.EntCentIlsh1Region == EntCentIlsh1Region.MistEffect)
                        {
                            acc.SetTag("PMistEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PMistEffect", "no");
                        }
                        if (es.EntCentIlsh1Region == EntCentIlsh1Region.ExplosionEffect)
                        {
                            acc.SetTag("PExplosionEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PExplosionEffect", "no");
                        }
                        if (es.EntCentIlsh1Region == EntCentIlsh1Region.StoneEffect)
                        {
                            acc.SetTag("PStoneEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PStoneEffect", "no");
                        }
                        if (es.EntCentIlsh1Region == EntCentIlsh1Region.ShineyEffect)
                        {
                            acc.SetTag("PShineyEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PShineyEffect", "no");
                        }
                        if (es.EntCentIlsh1Region == EntCentIlsh1Region.FireFlyEffect)
                        {
                            acc.SetTag("PFireFlyEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PFireFlyEffect", "no");
                        }
                    }
                    else if (mp.Region.IsPartOf("Entrace to Central Ilshenar 2"))
                    {
                        if (es.EntCentIlsh2Region == EntCentIlsh2Region.DarkEffect)
                        {
                            acc.SetTag("PDarkEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PDarkEffect", "no");
                        }
                        if (es.EntCentIlsh2Region == EntCentIlsh2Region.FireEffect)
                        {
                            acc.SetTag("PFireEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PFireEffect", "no");
                        }
                        if (es.EntCentIlsh2Region == EntCentIlsh2Region.IceEffect)
                        {
                            acc.SetTag("PIceEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PIceEffect", "no");
                        }
                        if (es.EntCentIlsh2Region == EntCentIlsh2Region.ToxicEffect)
                        {
                            acc.SetTag("PToxicEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PToxicEffect", "no");
                        }
                        if (es.EntCentIlsh2Region == EntCentIlsh2Region.ElectEffect)
                        {
                            acc.SetTag("PElectEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PElectEffect", "no");
                        }
                        if (es.EntCentIlsh2Region == EntCentIlsh2Region.WaterEffect)
                        {
                            acc.SetTag("PWaterEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PWaterEffect", "no");
                        }
                        if (es.EntCentIlsh2Region == EntCentIlsh2Region.MistEffect)
                        {
                            acc.SetTag("PMistEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PMistEffect", "no");
                        }
                        if (es.EntCentIlsh2Region == EntCentIlsh2Region.ExplosionEffect)
                        {
                            acc.SetTag("PExplosionEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PExplosionEffect", "no");
                        }
                        if (es.EntCentIlsh2Region == EntCentIlsh2Region.StoneEffect)
                        {
                            acc.SetTag("PStoneEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PStoneEffect", "no");
                        }
                        if (es.EntCentIlsh2Region == EntCentIlsh2Region.ShineyEffect)
                        {
                            acc.SetTag("PShineyEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PShineyEffect", "no");
                        }
                        if (es.EntCentIlsh2Region == EntCentIlsh2Region.FireFlyEffect)
                        {
                            acc.SetTag("PFireFlyEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PFireFlyEffect", "no");
                        }
                    }
                    else if (mp.Region.IsPartOf("Montor"))
                    {
                        if (es.MontorRegion == MontorRegion.DarkEffect)
                        {
                            acc.SetTag("PDarkEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PDarkEffect", "no");
                        }
                        if (es.MontorRegion == MontorRegion.FireEffect)
                        {
                            acc.SetTag("PFireEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PFireEffect", "no");
                        }
                        if (es.MontorRegion == MontorRegion.IceEffect)
                        {
                            acc.SetTag("PIceEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PIceEffect", "no");
                        }
                        if (es.MontorRegion == MontorRegion.ToxicEffect)
                        {
                            acc.SetTag("PToxicEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PToxicEffect", "no");
                        }
                        if (es.MontorRegion == MontorRegion.ElectEffect)
                        {
                            acc.SetTag("PElectEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PElectEffect", "no");
                        }
                        if (es.MontorRegion == MontorRegion.WaterEffect)
                        {
                            acc.SetTag("PWaterEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PWaterEffect", "no");
                        }
                        if (es.MontorRegion == MontorRegion.MistEffect)
                        {
                            acc.SetTag("PMistEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PMistEffect", "no");
                        }
                        if (es.MontorRegion == MontorRegion.ExplosionEffect)
                        {
                            acc.SetTag("PExplosionEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PExplosionEffect", "no");
                        }
                        if (es.MontorRegion == MontorRegion.StoneEffect)
                        {
                            acc.SetTag("PStoneEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PStoneEffect", "no");
                        }
                        if (es.MontorRegion == MontorRegion.ShineyEffect)
                        {
                            acc.SetTag("PShineyEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PShineyEffect", "no");
                        }
                        if (es.MontorRegion == MontorRegion.FireFlyEffect)
                        {
                            acc.SetTag("PFireFlyEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PFireFlyEffect", "no");
                        }
                    }
                    if (mp.Region.IsPartOf("Termir Flam"))
                    {
                        if (es.TermirFlamRegion == TermirFlamRegion.DarkEffect)
                        {
                            acc.SetTag("PDarkEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PDarkEffect", "no");
                        }
                        if (es.TermirFlamRegion == TermirFlamRegion.FireEffect)
                        {
                            acc.SetTag("PFireEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PFireEffect", "no");
                        }
                        if (es.TermirFlamRegion == TermirFlamRegion.IceEffect)
                        {
                            acc.SetTag("PIceEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PIceEffect", "no");
                        }
                        if (es.TermirFlamRegion == TermirFlamRegion.ToxicEffect)
                        {
                            acc.SetTag("PToxicEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PToxicEffect", "no");
                        }
                        if (es.TermirFlamRegion == TermirFlamRegion.ElectEffect)
                        {
                            acc.SetTag("PElectEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PElectEffect", "no");
                        }
                        if (es.TermirFlamRegion == TermirFlamRegion.WaterEffect)
                        {
                            acc.SetTag("PWaterEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PWaterEffect", "no");
                        }
                        if (es.TermirFlamRegion == TermirFlamRegion.MistEffect)
                        {
                            acc.SetTag("PMistEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PMistEffect", "no");
                        }
                        if (es.TermirFlamRegion == TermirFlamRegion.ExplosionEffect)
                        {
                            acc.SetTag("PExplosionEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PExplosionEffect", "no");
                        }
                        if (es.TermirFlamRegion == TermirFlamRegion.StoneEffect)
                        {
                            acc.SetTag("PStoneEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PStoneEffect", "no");
                        }
                        if (es.TermirFlamRegion == TermirFlamRegion.ShineyEffect)
                        {
                            acc.SetTag("PShineyEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PShineyEffect", "no");
                        }
                        if (es.TermirFlamRegion == TermirFlamRegion.FireFlyEffect)
                        {
                            acc.SetTag("PFireFlyEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PFireFlyEffect", "no");
                        }
                    }
                    else if (mp.Region.IsPartOf("Ancient Citadel"))
                    {
                        if (es.AncientCitadelRegion == AncientCitadelRegion.DarkEffect)
                        {
                            acc.SetTag("PDarkEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PDarkEffect", "no");
                        }
                        if (es.AncientCitadelRegion == AncientCitadelRegion.FireEffect)
                        {
                            acc.SetTag("PFireEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PFireEffect", "no");
                        }
                        if (es.AncientCitadelRegion == AncientCitadelRegion.IceEffect)
                        {
                            acc.SetTag("PIceEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PIceEffect", "no");
                        }
                        if (es.AncientCitadelRegion == AncientCitadelRegion.ToxicEffect)
                        {
                            acc.SetTag("PToxicEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PToxicEffect", "no");
                        }
                        if (es.AncientCitadelRegion == AncientCitadelRegion.ElectEffect)
                        {
                            acc.SetTag("PElectEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PElectEffect", "no");
                        }
                        if (es.AncientCitadelRegion == AncientCitadelRegion.WaterEffect)
                        {
                            acc.SetTag("PWaterEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PWaterEffect", "no");
                        }
                        if (es.AncientCitadelRegion == AncientCitadelRegion.MistEffect)
                        {
                            acc.SetTag("PMistEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PMistEffect", "no");
                        }
                        if (es.AncientCitadelRegion == AncientCitadelRegion.ExplosionEffect)
                        {
                            acc.SetTag("PExplosionEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PExplosionEffect", "no");
                        }
                        if (es.AncientCitadelRegion == AncientCitadelRegion.StoneEffect)
                        {
                            acc.SetTag("PStoneEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PStoneEffect", "no");
                        }
                        if (es.AncientCitadelRegion == AncientCitadelRegion.ShineyEffect)
                        {
                            acc.SetTag("PShineyEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PShineyEffect", "no");
                        }
                        if (es.AncientCitadelRegion == AncientCitadelRegion.FireFlyEffect)
                        {
                            acc.SetTag("PFireFlyEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PFireFlyEffect", "no");
                        }
                    }
                    else if (mp.Region.IsPartOf("Alexandretta's Bowl"))
                    {
                        if (es.AlexandrettasBowlRegion == AlexandrettasBowlRegion.DarkEffect)
                        {
                            acc.SetTag("PDarkEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PDarkEffect", "no");
                        }
                        if (es.AlexandrettasBowlRegion == AlexandrettasBowlRegion.FireEffect)
                        {
                            acc.SetTag("PFireEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PFireEffect", "no");
                        }
                        if (es.AlexandrettasBowlRegion == AlexandrettasBowlRegion.IceEffect)
                        {
                            acc.SetTag("PIceEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PIceEffect", "no");
                        }
                        if (es.AlexandrettasBowlRegion == AlexandrettasBowlRegion.ToxicEffect)
                        {
                            acc.SetTag("PToxicEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PToxicEffect", "no");
                        }
                        if (es.AlexandrettasBowlRegion == AlexandrettasBowlRegion.ElectEffect)
                        {
                            acc.SetTag("PElectEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PElectEffect", "no");
                        }
                        if (es.AlexandrettasBowlRegion == AlexandrettasBowlRegion.WaterEffect)
                        {
                            acc.SetTag("PWaterEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PWaterEffect", "no");
                        }
                        if (es.AlexandrettasBowlRegion == AlexandrettasBowlRegion.MistEffect)
                        {
                            acc.SetTag("PMistEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PMistEffect", "no");
                        }
                        if (es.AlexandrettasBowlRegion == AlexandrettasBowlRegion.ExplosionEffect)
                        {
                            acc.SetTag("PExplosionEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PExplosionEffect", "no");
                        }
                        if (es.AlexandrettasBowlRegion == AlexandrettasBowlRegion.StoneEffect)
                        {
                            acc.SetTag("PStoneEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PStoneEffect", "no");
                        }
                        if (es.AlexandrettasBowlRegion == AlexandrettasBowlRegion.ShineyEffect)
                        {
                            acc.SetTag("PShineyEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PShineyEffect", "no");
                        }
                        if (es.AlexandrettasBowlRegion == AlexandrettasBowlRegion.FireFlyEffect)
                        {
                            acc.SetTag("PFireFlyEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PFireFlyEffect", "no");
                        }
                    }
                    else if (mp.Region.IsPartOf("Entrance to Rock Dungeon"))
                    {
                        if (es.EntRockDungRegion == EntRockDungRegion.DarkEffect)
                        {
                            acc.SetTag("PDarkEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PDarkEffect", "no");
                        }
                        if (es.EntRockDungRegion == EntRockDungRegion.FireEffect)
                        {
                            acc.SetTag("PFireEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PFireEffect", "no");
                        }
                        if (es.EntRockDungRegion == EntRockDungRegion.IceEffect)
                        {
                            acc.SetTag("PIceEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PIceEffect", "no");
                        }
                        if (es.EntRockDungRegion == EntRockDungRegion.ToxicEffect)
                        {
                            acc.SetTag("PToxicEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PToxicEffect", "no");
                        }
                        if (es.EntRockDungRegion == EntRockDungRegion.ElectEffect)
                        {
                            acc.SetTag("PElectEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PElectEffect", "no");
                        }
                        if (es.EntRockDungRegion == EntRockDungRegion.WaterEffect)
                        {
                            acc.SetTag("PWaterEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PWaterEffect", "no");
                        }
                        if (es.EntRockDungRegion == EntRockDungRegion.MistEffect)
                        {
                            acc.SetTag("PMistEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PMistEffect", "no");
                        }
                        if (es.EntRockDungRegion == EntRockDungRegion.ExplosionEffect)
                        {
                            acc.SetTag("PExplosionEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PExplosionEffect", "no");
                        }
                        if (es.EntRockDungRegion == EntRockDungRegion.StoneEffect)
                        {
                            acc.SetTag("PStoneEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PStoneEffect", "no");
                        }
                        if (es.EntRockDungRegion == EntRockDungRegion.ShineyEffect)
                        {
                            acc.SetTag("PShineyEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PShineyEffect", "no");
                        }
                        if (es.EntRockDungRegion == EntRockDungRegion.FireFlyEffect)
                        {
                            acc.SetTag("PFireFlyEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PFireFlyEffect", "no");
                        }
                    }
                    else if (mp.Region.IsPartOf("Rock Dungeon"))
                    {
                        if (es.RockDungRegion == RockDungRegion.DarkEffect)
                        {
                            acc.SetTag("PDarkEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PDarkEffect", "no");
                        }
                        if (es.RockDungRegion == RockDungRegion.FireEffect)
                        {
                            acc.SetTag("PFireEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PFireEffect", "no");
                        }
                        if (es.RockDungRegion == RockDungRegion.IceEffect)
                        {
                            acc.SetTag("PIceEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PIceEffect", "no");
                        }
                        if (es.RockDungRegion == RockDungRegion.ToxicEffect)
                        {
                            acc.SetTag("PToxicEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PToxicEffect", "no");
                        }
                        if (es.RockDungRegion == RockDungRegion.ElectEffect)
                        {
                            acc.SetTag("PElectEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PElectEffect", "no");
                        }
                        if (es.RockDungRegion == RockDungRegion.WaterEffect)
                        {
                            acc.SetTag("PWaterEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PWaterEffect", "no");
                        }
                        if (es.RockDungRegion == RockDungRegion.MistEffect)
                        {
                            acc.SetTag("PMistEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PMistEffect", "no");
                        }
                        if (es.RockDungRegion == RockDungRegion.ExplosionEffect)
                        {
                            acc.SetTag("PExplosionEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PExplosionEffect", "no");
                        }
                        if (es.RockDungRegion == RockDungRegion.StoneEffect)
                        {
                            acc.SetTag("PStoneEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PStoneEffect", "no");
                        }
                        if (es.RockDungRegion == RockDungRegion.ShineyEffect)
                        {
                            acc.SetTag("PShineyEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PShineyEffect", "no");
                        }
                        if (es.RockDungRegion == RockDungRegion.FireFlyEffect)
                        {
                            acc.SetTag("PFireFlyEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PFireFlyEffect", "no");
                        }
                    }
                    else if (mp.Region.IsPartOf("Lenmir Anfinmotas"))
                    {
                        if (es.LenmirAnfinmotasRegion == LenmirAnfinmotasRegion.DarkEffect)
                        {
                            acc.SetTag("PDarkEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PDarkEffect", "no");
                        }
                        if (es.LenmirAnfinmotasRegion == LenmirAnfinmotasRegion.FireEffect)
                        {
                            acc.SetTag("PFireEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PFireEffect", "no");
                        }
                        if (es.LenmirAnfinmotasRegion == LenmirAnfinmotasRegion.IceEffect)
                        {
                            acc.SetTag("PIceEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PIceEffect", "no");
                        }
                        if (es.LenmirAnfinmotasRegion == LenmirAnfinmotasRegion.ToxicEffect)
                        {
                            acc.SetTag("PToxicEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PToxicEffect", "no");
                        }
                        if (es.LenmirAnfinmotasRegion == LenmirAnfinmotasRegion.ElectEffect)
                        {
                            acc.SetTag("PElectEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PElectEffect", "no");
                        }
                        if (es.LenmirAnfinmotasRegion == LenmirAnfinmotasRegion.WaterEffect)
                        {
                            acc.SetTag("PWaterEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PWaterEffect", "no");
                        }
                        if (es.LenmirAnfinmotasRegion == LenmirAnfinmotasRegion.MistEffect)
                        {
                            acc.SetTag("PMistEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PMistEffect", "no");
                        }
                        if (es.LenmirAnfinmotasRegion == LenmirAnfinmotasRegion.ExplosionEffect)
                        {
                            acc.SetTag("PExplosionEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PExplosionEffect", "no");
                        }
                        if (es.LenmirAnfinmotasRegion == LenmirAnfinmotasRegion.StoneEffect)
                        {
                            acc.SetTag("PStoneEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PStoneEffect", "no");
                        }
                        if (es.LenmirAnfinmotasRegion == LenmirAnfinmotasRegion.ShineyEffect)
                        {
                            acc.SetTag("PShineyEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PShineyEffect", "no");
                        }
                        if (es.LenmirAnfinmotasRegion == LenmirAnfinmotasRegion.FireFlyEffect)
                        {
                            acc.SetTag("PFireFlyEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PFireFlyEffect", "no");
                        }
                    }
                    else if (mp.Region.IsPartOf("Entrance to Spider Cave"))
                    {
                        if (es.EntSpiderCaveRegion == EntSpiderCaveRegion.DarkEffect)
                        {
                            acc.SetTag("PDarkEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PDarkEffect", "no");
                        }
                        if (es.EntSpiderCaveRegion == EntSpiderCaveRegion.FireEffect)
                        {
                            acc.SetTag("PFireEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PFireEffect", "no");
                        }
                        if (es.EntSpiderCaveRegion == EntSpiderCaveRegion.IceEffect)
                        {
                            acc.SetTag("PIceEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PIceEffect", "no");
                        }
                        if (es.EntSpiderCaveRegion == EntSpiderCaveRegion.ToxicEffect)
                        {
                            acc.SetTag("PToxicEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PToxicEffect", "no");
                        }
                        if (es.EntSpiderCaveRegion == EntSpiderCaveRegion.ElectEffect)
                        {
                            acc.SetTag("PElectEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PElectEffect", "no");
                        }
                        if (es.EntSpiderCaveRegion == EntSpiderCaveRegion.WaterEffect)
                        {
                            acc.SetTag("PWaterEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PWaterEffect", "no");
                        }
                        if (es.EntSpiderCaveRegion == EntSpiderCaveRegion.MistEffect)
                        {
                            acc.SetTag("PMistEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PMistEffect", "no");
                        }
                        if (es.EntSpiderCaveRegion == EntSpiderCaveRegion.ExplosionEffect)
                        {
                            acc.SetTag("PExplosionEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PExplosionEffect", "no");
                        }
                        if (es.EntSpiderCaveRegion == EntSpiderCaveRegion.StoneEffect)
                        {
                            acc.SetTag("PStoneEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PStoneEffect", "no");
                        }
                        if (es.EntSpiderCaveRegion == EntSpiderCaveRegion.ShineyEffect)
                        {
                            acc.SetTag("PShineyEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PShineyEffect", "no");
                        }
                        if (es.EntSpiderCaveRegion == EntSpiderCaveRegion.FireFlyEffect)
                        {
                            acc.SetTag("PFireFlyEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PFireFlyEffect", "no");
                        }
                    }
                    else if (mp.Region.IsPartOf("Spider Cave"))
                    {
                        if (es.SpiderCaveRegion == SpiderCaveRegion.DarkEffect)
                        {
                            acc.SetTag("PDarkEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PDarkEffect", "no");
                        }
                        if (es.SpiderCaveRegion == SpiderCaveRegion.FireEffect)
                        {
                            acc.SetTag("PFireEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PFireEffect", "no");
                        }
                        if (es.SpiderCaveRegion == SpiderCaveRegion.IceEffect)
                        {
                            acc.SetTag("PIceEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PIceEffect", "no");
                        }
                        if (es.SpiderCaveRegion == SpiderCaveRegion.ToxicEffect)
                        {
                            acc.SetTag("PToxicEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PToxicEffect", "no");
                        }
                        if (es.SpiderCaveRegion == SpiderCaveRegion.ElectEffect)
                        {
                            acc.SetTag("PElectEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PElectEffect", "no");
                        }
                        if (es.SpiderCaveRegion == SpiderCaveRegion.WaterEffect)
                        {
                            acc.SetTag("PWaterEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PWaterEffect", "no");
                        }
                        if (es.SpiderCaveRegion == SpiderCaveRegion.MistEffect)
                        {
                            acc.SetTag("PMistEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PMistEffect", "no");
                        }
                        if (es.SpiderCaveRegion == SpiderCaveRegion.ExplosionEffect)
                        {
                            acc.SetTag("PExplosionEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PExplosionEffect", "no");
                        }
                        if (es.SpiderCaveRegion == SpiderCaveRegion.StoneEffect)
                        {
                            acc.SetTag("PStoneEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PStoneEffect", "no");
                        }
                        if (es.SpiderCaveRegion == SpiderCaveRegion.ShineyEffect)
                        {
                            acc.SetTag("PShineyEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PShineyEffect", "no");
                        }
                        if (es.SpiderCaveRegion == SpiderCaveRegion.FireFlyEffect)
                        {
                            acc.SetTag("PFireFlyEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PFireFlyEffect", "no");
                        }
                    }
                    else if (mp.Region.IsPartOf("Twin Oaks"))
                    {
                        if (es.TwinOaksRegion == TwinOaksRegion.DarkEffect)
                        {
                            acc.SetTag("PDarkEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PDarkEffect", "no");
                        }
                        if (es.TwinOaksRegion == TwinOaksRegion.FireEffect)
                        {
                            acc.SetTag("PFireEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PFireEffect", "no");
                        }
                        if (es.TwinOaksRegion == TwinOaksRegion.IceEffect)
                        {
                            acc.SetTag("PIceEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PIceEffect", "no");
                        }
                        if (es.TwinOaksRegion == TwinOaksRegion.ToxicEffect)
                        {
                            acc.SetTag("PToxicEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PToxicEffect", "no");
                        }
                        if (es.TwinOaksRegion == TwinOaksRegion.ElectEffect)
                        {
                            acc.SetTag("PElectEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PElectEffect", "no");
                        }
                        if (es.TwinOaksRegion == TwinOaksRegion.WaterEffect)
                        {
                            acc.SetTag("PWaterEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PWaterEffect", "no");
                        }
                        if (es.TwinOaksRegion == TwinOaksRegion.MistEffect)
                        {
                            acc.SetTag("PMistEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PMistEffect", "no");
                        }
                        if (es.TwinOaksRegion == TwinOaksRegion.ExplosionEffect)
                        {
                            acc.SetTag("PExplosionEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PExplosionEffect", "no");
                        }
                        if (es.TwinOaksRegion == TwinOaksRegion.StoneEffect)
                        {
                            acc.SetTag("PStoneEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PStoneEffect", "no");
                        }
                        if (es.TwinOaksRegion == TwinOaksRegion.ShineyEffect)
                        {
                            acc.SetTag("PShineyEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PShineyEffect", "no");
                        }
                        if (es.TwinOaksRegion == TwinOaksRegion.FireFlyEffect)
                        {
                            acc.SetTag("PFireFlyEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PFireFlyEffect", "no");
                        }
                    }
                    else if (mp.Region.IsPartOf("Reg Volon"))
                    {
                        if (es.RegVolonRegion == RegVolonRegion.DarkEffect)
                        {
                            acc.SetTag("PDarkEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PDarkEffect", "no");
                        }
                        if (es.RegVolonRegion == RegVolonRegion.FireEffect)
                        {
                            acc.SetTag("PFireEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PFireEffect", "no");
                        }
                        if (es.RegVolonRegion == RegVolonRegion.IceEffect)
                        {
                            acc.SetTag("PIceEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PIceEffect", "no");
                        }
                        if (es.RegVolonRegion == RegVolonRegion.ToxicEffect)
                        {
                            acc.SetTag("PToxicEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PToxicEffect", "no");
                        }
                        if (es.RegVolonRegion == RegVolonRegion.ElectEffect)
                        {
                            acc.SetTag("PElectEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PElectEffect", "no");
                        }
                        if (es.RegVolonRegion == RegVolonRegion.WaterEffect)
                        {
                            acc.SetTag("PWaterEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PWaterEffect", "no");
                        }
                        if (es.RegVolonRegion == RegVolonRegion.MistEffect)
                        {
                            acc.SetTag("PMistEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PMistEffect", "no");
                        }
                        if (es.RegVolonRegion == RegVolonRegion.ExplosionEffect)
                        {
                            acc.SetTag("PExplosionEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PExplosionEffect", "no");
                        }
                        if (es.RegVolonRegion == RegVolonRegion.StoneEffect)
                        {
                            acc.SetTag("PStoneEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PStoneEffect", "no");
                        }
                        if (es.RegVolonRegion == RegVolonRegion.ShineyEffect)
                        {
                            acc.SetTag("PShineyEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PShineyEffect", "no");
                        }
                        if (es.RegVolonRegion == RegVolonRegion.FireFlyEffect)
                        {
                            acc.SetTag("PFireFlyEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PFireFlyEffect", "no");
                        }
                    }
                    else if (mp.Region.IsPartOf("Entrace Spectre Dungeon"))
                    {
                        if (es.EntSpectreDungRegion == EntSpectreDungRegion.DarkEffect)
                        {
                            acc.SetTag("PDarkEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PDarkEffect", "no");
                        }
                        if (es.EntSpectreDungRegion == EntSpectreDungRegion.FireEffect)
                        {
                            acc.SetTag("PFireEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PFireEffect", "no");
                        }
                        if (es.EntSpectreDungRegion == EntSpectreDungRegion.IceEffect)
                        {
                            acc.SetTag("PIceEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PIceEffect", "no");
                        }
                        if (es.EntSpectreDungRegion == EntSpectreDungRegion.ToxicEffect)
                        {
                            acc.SetTag("PToxicEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PToxicEffect", "no");
                        }
                        if (es.EntSpectreDungRegion == EntSpectreDungRegion.ElectEffect)
                        {
                            acc.SetTag("PElectEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PElectEffect", "no");
                        }
                        if (es.EntSpectreDungRegion == EntSpectreDungRegion.WaterEffect)
                        {
                            acc.SetTag("PWaterEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PWaterEffect", "no");
                        }
                        if (es.EntSpectreDungRegion == EntSpectreDungRegion.MistEffect)
                        {
                            acc.SetTag("PMistEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PMistEffect", "no");
                        }
                        if (es.EntSpectreDungRegion == EntSpectreDungRegion.ExplosionEffect)
                        {
                            acc.SetTag("PExplosionEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PExplosionEffect", "no");
                        }
                        if (es.EntSpectreDungRegion == EntSpectreDungRegion.StoneEffect)
                        {
                            acc.SetTag("PStoneEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PStoneEffect", "no");
                        }
                        if (es.EntSpectreDungRegion == EntSpectreDungRegion.ShineyEffect)
                        {
                            acc.SetTag("PShineyEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PShineyEffect", "no");
                        }
                        if (es.EntSpectreDungRegion == EntSpectreDungRegion.FireFlyEffect)
                        {
                            acc.SetTag("PFireFlyEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PFireFlyEffect", "no");
                        }
                    }
                    else if (mp.Region.IsPartOf("Spectre Dungeon"))
                    {
                        if (es.SpectreDungRegion == SpectreDungRegion.DarkEffect)
                        {
                            acc.SetTag("PDarkEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PDarkEffect", "no");
                        }
                        if (es.SpectreDungRegion == SpectreDungRegion.FireEffect)
                        {
                            acc.SetTag("PFireEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PFireEffect", "no");
                        }
                        if (es.SpectreDungRegion == SpectreDungRegion.IceEffect)
                        {
                            acc.SetTag("PIceEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PIceEffect", "no");
                        }
                        if (es.SpectreDungRegion == SpectreDungRegion.ToxicEffect)
                        {
                            acc.SetTag("PToxicEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PToxicEffect", "no");
                        }
                        if (es.SpectreDungRegion == SpectreDungRegion.ElectEffect)
                        {
                            acc.SetTag("PElectEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PElectEffect", "no");
                        }
                        if (es.SpectreDungRegion == SpectreDungRegion.WaterEffect)
                        {
                            acc.SetTag("PWaterEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PWaterEffect", "no");
                        }
                        if (es.SpectreDungRegion == SpectreDungRegion.MistEffect)
                        {
                            acc.SetTag("PMistEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PMistEffect", "no");
                        }
                        if (es.SpectreDungRegion == SpectreDungRegion.ExplosionEffect)
                        {
                            acc.SetTag("PExplosionEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PExplosionEffect", "no");
                        }
                        if (es.SpectreDungRegion == SpectreDungRegion.StoneEffect)
                        {
                            acc.SetTag("PStoneEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PStoneEffect", "no");
                        }
                        if (es.SpectreDungRegion == SpectreDungRegion.ShineyEffect)
                        {
                            acc.SetTag("PShineyEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PShineyEffect", "no");
                        }
                        if (es.SpectreDungRegion == SpectreDungRegion.FireFlyEffect)
                        {
                            acc.SetTag("PFireFlyEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PFireFlyEffect", "no");
                        }
                    }
                    else if (mp.Region.IsPartOf("Entrace to Blood Dungeon"))
                    {
                        if (es.EntBloodDungRegion == EntBloodDungRegion.DarkEffect)
                        {
                            acc.SetTag("PDarkEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PDarkEffect", "no");
                        }
                        if (es.EntBloodDungRegion == EntBloodDungRegion.FireEffect)
                        {
                            acc.SetTag("PFireEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PFireEffect", "no");
                        }
                        if (es.EntBloodDungRegion == EntBloodDungRegion.IceEffect)
                        {
                            acc.SetTag("PIceEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PIceEffect", "no");
                        }
                        if (es.EntBloodDungRegion == EntBloodDungRegion.ToxicEffect)
                        {
                            acc.SetTag("PToxicEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PToxicEffect", "no");
                        }
                        if (es.EntBloodDungRegion == EntBloodDungRegion.ElectEffect)
                        {
                            acc.SetTag("PElectEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PElectEffect", "no");
                        }
                        if (es.EntBloodDungRegion == EntBloodDungRegion.WaterEffect)
                        {
                            acc.SetTag("PWaterEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PWaterEffect", "no");
                        }
                        if (es.EntBloodDungRegion == EntBloodDungRegion.MistEffect)
                        {
                            acc.SetTag("PMistEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PMistEffect", "no");
                        }
                        if (es.EntBloodDungRegion == EntBloodDungRegion.ExplosionEffect)
                        {
                            acc.SetTag("PExplosionEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PExplosionEffect", "no");
                        }
                        if (es.EntBloodDungRegion == EntBloodDungRegion.StoneEffect)
                        {
                            acc.SetTag("PStoneEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PStoneEffect", "no");
                        }
                        if (es.EntBloodDungRegion == EntBloodDungRegion.ShineyEffect)
                        {
                            acc.SetTag("PShineyEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PShineyEffect", "no");
                        }
                        if (es.EntBloodDungRegion == EntBloodDungRegion.FireFlyEffect)
                        {
                            acc.SetTag("PFireFlyEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PFireFlyEffect", "no");
                        }
                    }
                    else if (mp.Region.IsPartOf("Blood Dungeon"))
                    {
                        if (es.BloodDungRegion == BloodDungRegion.DarkEffect)
                        {
                            acc.SetTag("PDarkEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PDarkEffect", "no");
                        }
                        if (es.BloodDungRegion == BloodDungRegion.FireEffect)
                        {
                            acc.SetTag("PFireEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PFireEffect", "no");
                        }
                        if (es.BloodDungRegion == BloodDungRegion.IceEffect)
                        {
                            acc.SetTag("PIceEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PIceEffect", "no");
                        }
                        if (es.BloodDungRegion == BloodDungRegion.ToxicEffect)
                        {
                            acc.SetTag("PToxicEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PToxicEffect", "no");
                        }
                        if (es.BloodDungRegion == BloodDungRegion.ElectEffect)
                        {
                            acc.SetTag("PElectEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PElectEffect", "no");
                        }
                        if (es.BloodDungRegion == BloodDungRegion.WaterEffect)
                        {
                            acc.SetTag("PWaterEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PWaterEffect", "no");
                        }
                        if (es.BloodDungRegion == BloodDungRegion.MistEffect)
                        {
                            acc.SetTag("PMistEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PMistEffect", "no");
                        }
                        if (es.BloodDungRegion == BloodDungRegion.ExplosionEffect)
                        {
                            acc.SetTag("PExplosionEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PExplosionEffect", "no");
                        }
                        if (es.BloodDungRegion == BloodDungRegion.StoneEffect)
                        {
                            acc.SetTag("PStoneEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PStoneEffect", "no");
                        }
                        if (es.BloodDungRegion == BloodDungRegion.ShineyEffect)
                        {
                            acc.SetTag("PShineyEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PShineyEffect", "no");
                        }
                        if (es.BloodDungRegion == BloodDungRegion.FireFlyEffect)
                        {
                            acc.SetTag("PFireFlyEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PFireFlyEffect", "no");
                        }
                    }
                    else if (mp.Region.IsPartOf("Entrace Mushroom Cave"))
                    {
                        if (es.EntMushroomCaveRegion == EntMushroomCaveRegion.DarkEffect)
                        {
                            acc.SetTag("PDarkEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PDarkEffect", "no");
                        }
                        if (es.EntMushroomCaveRegion == EntMushroomCaveRegion.FireEffect)
                        {
                            acc.SetTag("PFireEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PFireEffect", "no");
                        }
                        if (es.EntMushroomCaveRegion == EntMushroomCaveRegion.IceEffect)
                        {
                            acc.SetTag("PIceEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PIceEffect", "no");
                        }
                        if (es.EntMushroomCaveRegion == EntMushroomCaveRegion.ToxicEffect)
                        {
                            acc.SetTag("PToxicEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PToxicEffect", "no");
                        }
                        if (es.EntMushroomCaveRegion == EntMushroomCaveRegion.ElectEffect)
                        {
                            acc.SetTag("PElectEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PElectEffect", "no");
                        }
                        if (es.EntMushroomCaveRegion == EntMushroomCaveRegion.WaterEffect)
                        {
                            acc.SetTag("PWaterEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PWaterEffect", "no");
                        }
                        if (es.EntMushroomCaveRegion == EntMushroomCaveRegion.MistEffect)
                        {
                            acc.SetTag("PMistEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PMistEffect", "no");
                        }
                        if (es.EntMushroomCaveRegion == EntMushroomCaveRegion.ExplosionEffect)
                        {
                            acc.SetTag("PExplosionEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PExplosionEffect", "no");
                        }
                        if (es.EntMushroomCaveRegion == EntMushroomCaveRegion.StoneEffect)
                        {
                            acc.SetTag("PStoneEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PStoneEffect", "no");
                        }
                        if (es.EntMushroomCaveRegion == EntMushroomCaveRegion.ShineyEffect)
                        {
                            acc.SetTag("PShineyEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PShineyEffect", "no");
                        }
                        if (es.EntMushroomCaveRegion == EntMushroomCaveRegion.FireFlyEffect)
                        {
                            acc.SetTag("PFireFlyEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PFireFlyEffect", "no");
                        }
                    }
                    else if (mp.Region.IsPartOf("Mushroom Cave"))
                    {
                        if (es.MushroomCaveRegion == MushroomCaveRegion.DarkEffect)
                        {
                            acc.SetTag("PDarkEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PDarkEffect", "no");
                        }
                        if (es.MushroomCaveRegion == MushroomCaveRegion.FireEffect)
                        {
                            acc.SetTag("PFireEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PFireEffect", "no");
                        }
                        if (es.MushroomCaveRegion == MushroomCaveRegion.IceEffect)
                        {
                            acc.SetTag("PIceEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PIceEffect", "no");
                        }
                        if (es.MushroomCaveRegion == MushroomCaveRegion.ToxicEffect)
                        {
                            acc.SetTag("PToxicEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PToxicEffect", "no");
                        }
                        if (es.MushroomCaveRegion == MushroomCaveRegion.ElectEffect)
                        {
                            acc.SetTag("PElectEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PElectEffect", "no");
                        }
                        if (es.MushroomCaveRegion == MushroomCaveRegion.WaterEffect)
                        {
                            acc.SetTag("PWaterEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PWaterEffect", "no");
                        }
                        if (es.MushroomCaveRegion == MushroomCaveRegion.MistEffect)
                        {
                            acc.SetTag("PMistEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PMistEffect", "no");
                        }
                        if (es.MushroomCaveRegion == MushroomCaveRegion.ExplosionEffect)
                        {
                            acc.SetTag("PExplosionEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PExplosionEffect", "no");
                        }
                        if (es.MushroomCaveRegion == MushroomCaveRegion.StoneEffect)
                        {
                            acc.SetTag("PStoneEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PStoneEffect", "no");
                        }
                        if (es.MushroomCaveRegion == MushroomCaveRegion.ShineyEffect)
                        {
                            acc.SetTag("PShineyEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PShineyEffect", "no");
                        }
                        if (es.MushroomCaveRegion == MushroomCaveRegion.FireFlyEffect)
                        {
                            acc.SetTag("PFireFlyEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PFireFlyEffect", "no");
                        }
                    }
                    else if (mp.Region.IsPartOf("Lake Shire"))
                    {
                        if (es.LakeShireRegion == LakeShireRegion.DarkEffect)
                        {
                            acc.SetTag("PDarkEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PDarkEffect", "no");
                        }
                        if (es.LakeShireRegion == LakeShireRegion.FireEffect)
                        {
                            acc.SetTag("PFireEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PFireEffect", "no");
                        }
                        if (es.LakeShireRegion == LakeShireRegion.IceEffect)
                        {
                            acc.SetTag("PIceEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PIceEffect", "no");
                        }
                        if (es.LakeShireRegion == LakeShireRegion.ToxicEffect)
                        {
                            acc.SetTag("PToxicEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PToxicEffect", "no");
                        }
                        if (es.LakeShireRegion == LakeShireRegion.ElectEffect)
                        {
                            acc.SetTag("PElectEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PElectEffect", "no");
                        }
                        if (es.LakeShireRegion == LakeShireRegion.WaterEffect)
                        {
                            acc.SetTag("PWaterEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PWaterEffect", "no");
                        }
                        if (es.LakeShireRegion == LakeShireRegion.MistEffect)
                        {
                            acc.SetTag("PMistEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PMistEffect", "no");
                        }
                        if (es.LakeShireRegion == LakeShireRegion.ExplosionEffect)
                        {
                            acc.SetTag("PExplosionEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PExplosionEffect", "no");
                        }
                        if (es.LakeShireRegion == LakeShireRegion.StoneEffect)
                        {
                            acc.SetTag("PStoneEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PStoneEffect", "no");
                        }
                        if (es.LakeShireRegion == LakeShireRegion.ShineyEffect)
                        {
                            acc.SetTag("PShineyEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PShineyEffect", "no");
                        }
                        if (es.LakeShireRegion == LakeShireRegion.FireFlyEffect)
                        {
                            acc.SetTag("PFireFlyEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PFireFlyEffect", "no");
                        }
                    }
                    else if (mp.Region.IsPartOf("Entrace Rat Cave"))
                    {
                        if (es.EntRatCaveRegion == EntRatCaveRegion.DarkEffect)
                        {
                            acc.SetTag("PDarkEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PDarkEffect", "no");
                        }
                        if (es.EntRatCaveRegion == EntRatCaveRegion.FireEffect)
                        {
                            acc.SetTag("PFireEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PFireEffect", "no");
                        }
                        if (es.EntRatCaveRegion == EntRatCaveRegion.IceEffect)
                        {
                            acc.SetTag("PIceEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PIceEffect", "no");
                        }
                        if (es.EntRatCaveRegion == EntRatCaveRegion.ToxicEffect)
                        {
                            acc.SetTag("PToxicEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PToxicEffect", "no");
                        }
                        if (es.EntRatCaveRegion == EntRatCaveRegion.ElectEffect)
                        {
                            acc.SetTag("PElectEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PElectEffect", "no");
                        }
                        if (es.EntRatCaveRegion == EntRatCaveRegion.WaterEffect)
                        {
                            acc.SetTag("PWaterEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PWaterEffect", "no");
                        }
                        if (es.EntRatCaveRegion == EntRatCaveRegion.MistEffect)
                        {
                            acc.SetTag("PMistEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PMistEffect", "no");
                        }
                        if (es.EntRatCaveRegion == EntRatCaveRegion.ExplosionEffect)
                        {
                            acc.SetTag("PExplosionEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PExplosionEffect", "no");
                        }
                        if (es.EntRatCaveRegion == EntRatCaveRegion.StoneEffect)
                        {
                            acc.SetTag("PStoneEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PStoneEffect", "no");
                        }
                        if (es.EntRatCaveRegion == EntRatCaveRegion.ShineyEffect)
                        {
                            acc.SetTag("PShineyEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PShineyEffect", "no");
                        }
                        if (es.EntRatCaveRegion == EntRatCaveRegion.FireFlyEffect)
                        {
                            acc.SetTag("PFireFlyEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PFireFlyEffect", "no");
                        }
                    }
                    else if (mp.Region.IsPartOf("Rat Cave Territory"))
                    {
                        if (es.RatCaveTerritoryRegion == RatCaveTerritoryRegion.DarkEffect)
                        {
                            acc.SetTag("PDarkEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PDarkEffect", "no");
                        }
                        if (es.RatCaveTerritoryRegion == RatCaveTerritoryRegion.FireEffect)
                        {
                            acc.SetTag("PFireEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PFireEffect", "no");
                        }
                        if (es.RatCaveTerritoryRegion == RatCaveTerritoryRegion.IceEffect)
                        {
                            acc.SetTag("PIceEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PIceEffect", "no");
                        }
                        if (es.RatCaveTerritoryRegion == RatCaveTerritoryRegion.ToxicEffect)
                        {
                            acc.SetTag("PToxicEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PToxicEffect", "no");
                        }
                        if (es.RatCaveTerritoryRegion == RatCaveTerritoryRegion.ElectEffect)
                        {
                            acc.SetTag("PElectEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PElectEffect", "no");
                        }
                        if (es.RatCaveTerritoryRegion == RatCaveTerritoryRegion.WaterEffect)
                        {
                            acc.SetTag("PWaterEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PWaterEffect", "no");
                        }
                        if (es.RatCaveTerritoryRegion == RatCaveTerritoryRegion.MistEffect)
                        {
                            acc.SetTag("PMistEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PMistEffect", "no");
                        }
                        if (es.RatCaveTerritoryRegion == RatCaveTerritoryRegion.ExplosionEffect)
                        {
                            acc.SetTag("PExplosionEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PExplosionEffect", "no");
                        }
                        if (es.RatCaveTerritoryRegion == RatCaveTerritoryRegion.StoneEffect)
                        {
                            acc.SetTag("PStoneEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PStoneEffect", "no");
                        }
                        if (es.RatCaveTerritoryRegion == RatCaveTerritoryRegion.ShineyEffect)
                        {
                            acc.SetTag("PShineyEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PShineyEffect", "no");
                        }
                        if (es.RatCaveTerritoryRegion == RatCaveTerritoryRegion.FireFlyEffect)
                        {
                            acc.SetTag("PFireFlyEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PFireFlyEffect", "no");
                        }
                    }
                    else if (mp.Region.IsPartOf("Ratman Cave"))
                    {
                        if (es.RatManCaveRegion == RatManCaveRegion.DarkEffect)
                        {
                            acc.SetTag("PDarkEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PDarkEffect", "no");
                        }
                        if (es.RatManCaveRegion == RatManCaveRegion.FireEffect)
                        {
                            acc.SetTag("PFireEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PFireEffect", "no");
                        }
                        if (es.RatManCaveRegion == RatManCaveRegion.IceEffect)
                        {
                            acc.SetTag("PIceEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PIceEffect", "no");
                        }
                        if (es.RatManCaveRegion == RatManCaveRegion.ToxicEffect)
                        {
                            acc.SetTag("PToxicEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PToxicEffect", "no");
                        }
                        if (es.RatManCaveRegion == RatManCaveRegion.ElectEffect)
                        {
                            acc.SetTag("PElectEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PElectEffect", "no");
                        }
                        if (es.RatManCaveRegion == RatManCaveRegion.WaterEffect)
                        {
                            acc.SetTag("PWaterEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PWaterEffect", "no");
                        }
                        if (es.RatManCaveRegion == RatManCaveRegion.MistEffect)
                        {
                            acc.SetTag("PMistEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PMistEffect", "no");
                        }
                        if (es.RatManCaveRegion == RatManCaveRegion.ExplosionEffect)
                        {
                            acc.SetTag("PExplosionEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PExplosionEffect", "no");
                        }
                        if (es.RatManCaveRegion == RatManCaveRegion.StoneEffect)
                        {
                            acc.SetTag("PStoneEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PStoneEffect", "no");
                        }
                        if (es.RatManCaveRegion == RatManCaveRegion.ShineyEffect)
                        {
                            acc.SetTag("PShineyEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PShineyEffect", "no");
                        }
                        if (es.RatManCaveRegion == RatManCaveRegion.FireFlyEffect)
                        {
                            acc.SetTag("PFireFlyEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PFireFlyEffect", "no");
                        }
                    }
                    else if (mp.Region.IsPartOf("Bet-Lem Reg"))
                    {
                        if (es.BetLemRegRegion == BetLemRegRegion.DarkEffect)
                        {
                            acc.SetTag("PDarkEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PDarkEffect", "no");
                        }
                        if (es.BetLemRegRegion == BetLemRegRegion.FireEffect)
                        {
                            acc.SetTag("PFireEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PFireEffect", "no");
                        }
                        if (es.BetLemRegRegion == BetLemRegRegion.IceEffect)
                        {
                            acc.SetTag("PIceEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PIceEffect", "no");
                        }
                        if (es.BetLemRegRegion == BetLemRegRegion.ToxicEffect)
                        {
                            acc.SetTag("PToxicEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PToxicEffect", "no");
                        }
                        if (es.BetLemRegRegion == BetLemRegRegion.ElectEffect)
                        {
                            acc.SetTag("PElectEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PElectEffect", "no");
                        }
                        if (es.BetLemRegRegion == BetLemRegRegion.WaterEffect)
                        {
                            acc.SetTag("PWaterEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PWaterEffect", "no");
                        }
                        if (es.BetLemRegRegion == BetLemRegRegion.MistEffect)
                        {
                            acc.SetTag("PMistEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PMistEffect", "no");
                        }
                        if (es.BetLemRegRegion == BetLemRegRegion.ExplosionEffect)
                        {
                            acc.SetTag("PExplosionEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PExplosionEffect", "no");
                        }
                        if (es.BetLemRegRegion == BetLemRegRegion.StoneEffect)
                        {
                            acc.SetTag("PStoneEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PStoneEffect", "no");
                        }
                        if (es.BetLemRegRegion == BetLemRegRegion.ShineyEffect)
                        {
                            acc.SetTag("PShineyEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PShineyEffect", "no");
                        }
                        if (es.BetLemRegRegion == BetLemRegRegion.FireFlyEffect)
                        {
                            acc.SetTag("PFireFlyEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PFireFlyEffect", "no");
                        }
                    }
                    else if (mp.Region.IsPartOf("Mistas"))
                    {
                        if (es.MistasRegion == MistasRegion.DarkEffect)
                        {
                            acc.SetTag("PDarkEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PDarkEffect", "no");
                        }
                        if (es.MistasRegion == MistasRegion.FireEffect)
                        {
                            acc.SetTag("PFireEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PFireEffect", "no");
                        }
                        if (es.MistasRegion == MistasRegion.IceEffect)
                        {
                            acc.SetTag("PIceEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PIceEffect", "no");
                        }
                        if (es.MistasRegion == MistasRegion.ToxicEffect)
                        {
                            acc.SetTag("PToxicEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PToxicEffect", "no");
                        }
                        if (es.MistasRegion == MistasRegion.ElectEffect)
                        {
                            acc.SetTag("PElectEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PElectEffect", "no");
                        }
                        if (es.MistasRegion == MistasRegion.WaterEffect)
                        {
                            acc.SetTag("PWaterEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PWaterEffect", "no");
                        }
                        if (es.MistasRegion == MistasRegion.MistEffect)
                        {
                            acc.SetTag("PMistEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PMistEffect", "no");
                        }
                        if (es.MistasRegion == MistasRegion.ExplosionEffect)
                        {
                            acc.SetTag("PExplosionEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PExplosionEffect", "no");
                        }
                        if (es.MistasRegion == MistasRegion.StoneEffect)
                        {
                            acc.SetTag("PStoneEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PStoneEffect", "no");
                        }
                        if (es.MistasRegion == MistasRegion.ShineyEffect)
                        {
                            acc.SetTag("PShineyEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PShineyEffect", "no");
                        }
                        if (es.MistasRegion == MistasRegion.FireFlyEffect)
                        {
                            acc.SetTag("PFireFlyEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PFireFlyEffect", "no");
                        }
                    }
                    else if (mp.Region.IsPartOf("Serpentine Passage"))
                    {
                        if (es.SerpentinePassageRegion == SerpentinePassageRegion.DarkEffect)
                        {
                            acc.SetTag("PDarkEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PDarkEffect", "no");
                        }
                        if (es.SerpentinePassageRegion == SerpentinePassageRegion.FireEffect)
                        {
                            acc.SetTag("PFireEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PFireEffect", "no");
                        }
                        if (es.SerpentinePassageRegion == SerpentinePassageRegion.IceEffect)
                        {
                            acc.SetTag("PIceEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PIceEffect", "no");
                        }
                        if (es.SerpentinePassageRegion == SerpentinePassageRegion.ToxicEffect)
                        {
                            acc.SetTag("PToxicEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PToxicEffect", "no");
                        }
                        if (es.SerpentinePassageRegion == SerpentinePassageRegion.ElectEffect)
                        {
                            acc.SetTag("PElectEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PElectEffect", "no");
                        }
                        if (es.SerpentinePassageRegion == SerpentinePassageRegion.WaterEffect)
                        {
                            acc.SetTag("PWaterEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PWaterEffect", "no");
                        }
                        if (es.SerpentinePassageRegion == SerpentinePassageRegion.MistEffect)
                        {
                            acc.SetTag("PMistEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PMistEffect", "no");
                        }
                        if (es.SerpentinePassageRegion == SerpentinePassageRegion.ExplosionEffect)
                        {
                            acc.SetTag("PExplosionEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PExplosionEffect", "no");
                        }
                        if (es.SerpentinePassageRegion == SerpentinePassageRegion.StoneEffect)
                        {
                            acc.SetTag("PStoneEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PStoneEffect", "no");
                        }
                        if (es.SerpentinePassageRegion == SerpentinePassageRegion.ShineyEffect)
                        {
                            acc.SetTag("PShineyEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PShineyEffect", "no");
                        }
                        if (es.SerpentinePassageRegion == SerpentinePassageRegion.FireFlyEffect)
                        {
                            acc.SetTag("PFireFlyEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PFireFlyEffect", "no");
                        }
                    }
                    else if (mp.Region.IsPartOf("Ankh Dungeon"))
                    {
                        if (es.AnkhDungeonRegion == AnkhDungeonRegion.DarkEffect)
                        {
                            acc.SetTag("PDarkEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PDarkEffect", "no");
                        }
                        if (es.AnkhDungeonRegion == AnkhDungeonRegion.FireEffect)
                        {
                            acc.SetTag("PFireEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PFireEffect", "no");
                        }
                        if (es.AnkhDungeonRegion == AnkhDungeonRegion.IceEffect)
                        {
                            acc.SetTag("PIceEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PIceEffect", "no");
                        }
                        if (es.AnkhDungeonRegion == AnkhDungeonRegion.ToxicEffect)
                        {
                            acc.SetTag("PToxicEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PToxicEffect", "no");
                        }
                        if (es.AnkhDungeonRegion == AnkhDungeonRegion.ElectEffect)
                        {
                            acc.SetTag("PElectEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PElectEffect", "no");
                        }
                        if (es.AnkhDungeonRegion == AnkhDungeonRegion.WaterEffect)
                        {
                            acc.SetTag("PWaterEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PWaterEffect", "no");
                        }
                        if (es.AnkhDungeonRegion == AnkhDungeonRegion.MistEffect)
                        {
                            acc.SetTag("PMistEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PMistEffect", "no");
                        }
                        if (es.AnkhDungeonRegion == AnkhDungeonRegion.ExplosionEffect)
                        {
                            acc.SetTag("PExplosionEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PExplosionEffect", "no");
                        }
                        if (es.AnkhDungeonRegion == AnkhDungeonRegion.StoneEffect)
                        {
                            acc.SetTag("PStoneEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PStoneEffect", "no");
                        }
                        if (es.AnkhDungeonRegion == AnkhDungeonRegion.ShineyEffect)
                        {
                            acc.SetTag("PShineyEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PShineyEffect", "no");
                        }
                        if (es.AnkhDungeonRegion == AnkhDungeonRegion.FireFlyEffect)
                        {
                            acc.SetTag("PFireFlyEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PFireFlyEffect", "no");
                        }
                    }
                    else if (mp.Region.IsPartOf("Kirin Passage"))
                    {
                        if (es.KirinPassageRegion == KirinPassageRegion.DarkEffect)
                        {
                            acc.SetTag("PDarkEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PDarkEffect", "no");
                        }
                        if (es.KirinPassageRegion == KirinPassageRegion.FireEffect)
                        {
                            acc.SetTag("PFireEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PFireEffect", "no");
                        }
                        if (es.KirinPassageRegion == KirinPassageRegion.IceEffect)
                        {
                            acc.SetTag("PIceEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PIceEffect", "no");
                        }
                        if (es.KirinPassageRegion == KirinPassageRegion.ToxicEffect)
                        {
                            acc.SetTag("PToxicEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PToxicEffect", "no");
                        }
                        if (es.KirinPassageRegion == KirinPassageRegion.ElectEffect)
                        {
                            acc.SetTag("PElectEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PElectEffect", "no");
                        }
                        if (es.KirinPassageRegion == KirinPassageRegion.WaterEffect)
                        {
                            acc.SetTag("PWaterEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PWaterEffect", "no");
                        }
                        if (es.KirinPassageRegion == KirinPassageRegion.MistEffect)
                        {
                            acc.SetTag("PMistEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PMistEffect", "no");
                        }
                        if (es.KirinPassageRegion == KirinPassageRegion.ExplosionEffect)
                        {
                            acc.SetTag("PExplosionEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PExplosionEffect", "no");
                        }
                        if (es.KirinPassageRegion == KirinPassageRegion.StoneEffect)
                        {
                            acc.SetTag("PStoneEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PStoneEffect", "no");
                        }
                        if (es.KirinPassageRegion == KirinPassageRegion.ShineyEffect)
                        {
                            acc.SetTag("PShineyEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PShineyEffect", "no");
                        }
                        if (es.KirinPassageRegion == KirinPassageRegion.FireFlyEffect)
                        {
                            acc.SetTag("PFireFlyEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PFireFlyEffect", "no");
                        }
                    }
                    else if (mp.Region.IsPartOf("Entrace Lizards Passage"))
                    {
                        if (es.EntLizardsPassageRegion == EntLizardsPassageRegion.DarkEffect)
                        {
                            acc.SetTag("PDarkEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PDarkEffect", "no");
                        }
                        if (es.EntLizardsPassageRegion == EntLizardsPassageRegion.FireEffect)
                        {
                            acc.SetTag("PFireEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PFireEffect", "no");
                        }
                        if (es.EntLizardsPassageRegion == EntLizardsPassageRegion.IceEffect)
                        {
                            acc.SetTag("PIceEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PIceEffect", "no");
                        }
                        if (es.EntLizardsPassageRegion == EntLizardsPassageRegion.ToxicEffect)
                        {
                            acc.SetTag("PToxicEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PToxicEffect", "no");
                        }
                        if (es.EntLizardsPassageRegion == EntLizardsPassageRegion.ElectEffect)
                        {
                            acc.SetTag("PElectEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PElectEffect", "no");
                        }
                        if (es.EntLizardsPassageRegion == EntLizardsPassageRegion.WaterEffect)
                        {
                            acc.SetTag("PWaterEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PWaterEffect", "no");
                        }
                        if (es.EntLizardsPassageRegion == EntLizardsPassageRegion.MistEffect)
                        {
                            acc.SetTag("PMistEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PMistEffect", "no");
                        }
                        if (es.EntLizardsPassageRegion == EntLizardsPassageRegion.ExplosionEffect)
                        {
                            acc.SetTag("PExplosionEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PExplosionEffect", "no");
                        }
                        if (es.EntLizardsPassageRegion == EntLizardsPassageRegion.StoneEffect)
                        {
                            acc.SetTag("PStoneEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PStoneEffect", "no");
                        }
                        if (es.EntLizardsPassageRegion == EntLizardsPassageRegion.ShineyEffect)
                        {
                            acc.SetTag("PShineyEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PShineyEffect", "no");
                        }
                        if (es.EntLizardsPassageRegion == EntLizardsPassageRegion.FireFlyEffect)
                        {
                            acc.SetTag("PFireFlyEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PFireFlyEffect", "no");
                        }
                    }
                    else if (mp.Region.IsPartOf("Wisp Dungeon"))
                    {
                        if (es.WispDungeonRegion == WispDungeonRegion.DarkEffect)
                        {
                            acc.SetTag("PDarkEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PDarkEffect", "no");
                        }
                        if (es.WispDungeonRegion == WispDungeonRegion.FireEffect)
                        {
                            acc.SetTag("PFireEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PFireEffect", "no");
                        }
                        if (es.WispDungeonRegion == WispDungeonRegion.IceEffect)
                        {
                            acc.SetTag("PIceEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PIceEffect", "no");
                        }
                        if (es.WispDungeonRegion == WispDungeonRegion.ToxicEffect)
                        {
                            acc.SetTag("PToxicEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PToxicEffect", "no");
                        }
                        if (es.WispDungeonRegion == WispDungeonRegion.ElectEffect)
                        {
                            acc.SetTag("PElectEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PElectEffect", "no");
                        }
                        if (es.WispDungeonRegion == WispDungeonRegion.WaterEffect)
                        {
                            acc.SetTag("PWaterEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PWaterEffect", "no");
                        }
                        if (es.WispDungeonRegion == WispDungeonRegion.MistEffect)
                        {
                            acc.SetTag("PMistEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PMistEffect", "no");
                        }
                        if (es.WispDungeonRegion == WispDungeonRegion.ExplosionEffect)
                        {
                            acc.SetTag("PExplosionEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PExplosionEffect", "no");
                        }
                        if (es.WispDungeonRegion == WispDungeonRegion.StoneEffect)
                        {
                            acc.SetTag("PStoneEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PStoneEffect", "no");
                        }
                        if (es.WispDungeonRegion == WispDungeonRegion.ShineyEffect)
                        {
                            acc.SetTag("PShineyEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PShineyEffect", "no");
                        }
                        if (es.WispDungeonRegion == WispDungeonRegion.FireFlyEffect)
                        {
                            acc.SetTag("PFireFlyEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PFireFlyEffect", "no");
                        }
                    }
                    else if (mp.Region.IsPartOf("Lizard Passage"))
                    {
                        if (es.LizardPassageRegion == LizardPassageRegion.DarkEffect)
                        {
                            acc.SetTag("PDarkEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PDarkEffect", "no");
                        }
                        if (es.LizardPassageRegion == LizardPassageRegion.FireEffect)
                        {
                            acc.SetTag("PFireEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PFireEffect", "no");
                        }
                        if (es.LizardPassageRegion == LizardPassageRegion.IceEffect)
                        {
                            acc.SetTag("PIceEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PIceEffect", "no");
                        }
                        if (es.LizardPassageRegion == LizardPassageRegion.ToxicEffect)
                        {
                            acc.SetTag("PToxicEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PToxicEffect", "no");
                        }
                        if (es.LizardPassageRegion == LizardPassageRegion.ElectEffect)
                        {
                            acc.SetTag("PElectEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PElectEffect", "no");
                        }
                        if (es.LizardPassageRegion == LizardPassageRegion.WaterEffect)
                        {
                            acc.SetTag("PWaterEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PWaterEffect", "no");
                        }
                        if (es.LizardPassageRegion == LizardPassageRegion.MistEffect)
                        {
                            acc.SetTag("PMistEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PMistEffect", "no");
                        }
                        if (es.LizardPassageRegion == LizardPassageRegion.ExplosionEffect)
                        {
                            acc.SetTag("PExplosionEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PExplosionEffect", "no");
                        }
                        if (es.LizardPassageRegion == LizardPassageRegion.StoneEffect)
                        {
                            acc.SetTag("PStoneEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PStoneEffect", "no");
                        }
                        if (es.LizardPassageRegion == LizardPassageRegion.ShineyEffect)
                        {
                            acc.SetTag("PShineyEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PShineyEffect", "no");
                        }
                        if (es.LizardPassageRegion == LizardPassageRegion.FireFlyEffect)
                        {
                            acc.SetTag("PFireFlyEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PFireFlyEffect", "no");
                        }
                    }
                    else if (mp.Region.IsPartOf("Exodus Dungeon"))
                    {
                        if (es.ExodusDungeonRegion == ExodusDungeonRegion.DarkEffect)
                        {
                            acc.SetTag("PDarkEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PDarkEffect", "no");
                        }
                        if (es.ExodusDungeonRegion == ExodusDungeonRegion.FireEffect)
                        {
                            acc.SetTag("PFireEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PFireEffect", "no");
                        }
                        if (es.ExodusDungeonRegion == ExodusDungeonRegion.IceEffect)
                        {
                            acc.SetTag("PIceEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PIceEffect", "no");
                        }
                        if (es.ExodusDungeonRegion == ExodusDungeonRegion.ToxicEffect)
                        {
                            acc.SetTag("PToxicEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PToxicEffect", "no");
                        }
                        if (es.ExodusDungeonRegion == ExodusDungeonRegion.ElectEffect)
                        {
                            acc.SetTag("PElectEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PElectEffect", "no");
                        }
                        if (es.ExodusDungeonRegion == ExodusDungeonRegion.WaterEffect)
                        {
                            acc.SetTag("PWaterEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PWaterEffect", "no");
                        }
                        if (es.ExodusDungeonRegion == ExodusDungeonRegion.MistEffect)
                        {
                            acc.SetTag("PMistEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PMistEffect", "no");
                        }
                        if (es.ExodusDungeonRegion == ExodusDungeonRegion.ExplosionEffect)
                        {
                            acc.SetTag("PExplosionEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PExplosionEffect", "no");
                        }
                        if (es.ExodusDungeonRegion == ExodusDungeonRegion.StoneEffect)
                        {
                            acc.SetTag("PStoneEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PStoneEffect", "no");
                        }
                        if (es.ExodusDungeonRegion == ExodusDungeonRegion.ShineyEffect)
                        {
                            acc.SetTag("PShineyEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PShineyEffect", "no");
                        }
                        if (es.ExodusDungeonRegion == ExodusDungeonRegion.FireFlyEffect)
                        {
                            acc.SetTag("PFireFlyEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PFireFlyEffect", "no");
                        }
                    }
                    else if (mp.Region.IsPartOf("Lizard Man's Huts"))
                    {
                        if (es.LizardManHutsRegion == LizardManHutsRegion.DarkEffect)
                        {
                            acc.SetTag("PDarkEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PDarkEffect", "no");
                        }
                        if (es.LizardManHutsRegion == LizardManHutsRegion.FireEffect)
                        {
                            acc.SetTag("PFireEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PFireEffect", "no");
                        }
                        if (es.LizardManHutsRegion == LizardManHutsRegion.IceEffect)
                        {
                            acc.SetTag("PIceEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PIceEffect", "no");
                        }
                        if (es.LizardManHutsRegion == LizardManHutsRegion.ToxicEffect)
                        {
                            acc.SetTag("PToxicEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PToxicEffect", "no");
                        }
                        if (es.LizardManHutsRegion == LizardManHutsRegion.ElectEffect)
                        {
                            acc.SetTag("PElectEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PElectEffect", "no");
                        }
                        if (es.LizardManHutsRegion == LizardManHutsRegion.WaterEffect)
                        {
                            acc.SetTag("PWaterEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PWaterEffect", "no");
                        }
                        if (es.LizardManHutsRegion == LizardManHutsRegion.MistEffect)
                        {
                            acc.SetTag("PMistEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PMistEffect", "no");
                        }
                        if (es.LizardManHutsRegion == LizardManHutsRegion.ExplosionEffect)
                        {
                            acc.SetTag("PExplosionEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PExplosionEffect", "no");
                        }
                        if (es.LizardManHutsRegion == LizardManHutsRegion.StoneEffect)
                        {
                            acc.SetTag("PStoneEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PStoneEffect", "no");
                        }
                        if (es.LizardManHutsRegion == LizardManHutsRegion.ShineyEffect)
                        {
                            acc.SetTag("PShineyEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PShineyEffect", "no");
                        }
                        if (es.LizardManHutsRegion == LizardManHutsRegion.FireFlyEffect)
                        {
                            acc.SetTag("PFireFlyEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PFireFlyEffect", "no");
                        }
                    }
                    else if (mp.Region.IsPartOf("Nox Tereg"))
                    {
                        if (es.NoxTeregRegion == NoxTeregRegion.DarkEffect)
                        {
                            acc.SetTag("PDarkEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PDarkEffect", "no");
                        }
                        if (es.NoxTeregRegion == NoxTeregRegion.FireEffect)
                        {
                            acc.SetTag("PFireEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PFireEffect", "no");
                        }
                        if (es.NoxTeregRegion == NoxTeregRegion.IceEffect)
                        {
                            acc.SetTag("PIceEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PIceEffect", "no");
                        }
                        if (es.NoxTeregRegion == NoxTeregRegion.ToxicEffect)
                        {
                            acc.SetTag("PToxicEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PToxicEffect", "no");
                        }
                        if (es.NoxTeregRegion == NoxTeregRegion.ElectEffect)
                        {
                            acc.SetTag("PElectEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PElectEffect", "no");
                        }
                        if (es.NoxTeregRegion == NoxTeregRegion.WaterEffect)
                        {
                            acc.SetTag("PWaterEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PWaterEffect", "no");
                        }
                        if (es.NoxTeregRegion == NoxTeregRegion.MistEffect)
                        {
                            acc.SetTag("PMistEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PMistEffect", "no");
                        }
                        if (es.NoxTeregRegion == NoxTeregRegion.ExplosionEffect)
                        {
                            acc.SetTag("PExplosionEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PExplosionEffect", "no");
                        }
                        if (es.NoxTeregRegion == NoxTeregRegion.StoneEffect)
                        {
                            acc.SetTag("PStoneEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PStoneEffect", "no");
                        }
                        if (es.NoxTeregRegion == NoxTeregRegion.ShineyEffect)
                        {
                            acc.SetTag("PShineyEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PShineyEffect", "no");
                        }
                        if (es.NoxTeregRegion == NoxTeregRegion.FireFlyEffect)
                        {
                            acc.SetTag("PFireFlyEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PFireFlyEffect", "no");
                        }
                    }
                    else if (mp.Region.IsPartOf("Sorcerer's Dungeon"))
                    {
                        if (es.SorcerersDungeonRegion == SorcerersDungeonRegion.DarkEffect)
                        {
                            acc.SetTag("PDarkEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PDarkEffect", "no");
                        }
                        if (es.SorcerersDungeonRegion == SorcerersDungeonRegion.FireEffect)
                        {
                            acc.SetTag("PFireEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PFireEffect", "no");
                        }
                        if (es.SorcerersDungeonRegion == SorcerersDungeonRegion.IceEffect)
                        {
                            acc.SetTag("PIceEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PIceEffect", "no");
                        }
                        if (es.SorcerersDungeonRegion == SorcerersDungeonRegion.ToxicEffect)
                        {
                            acc.SetTag("PToxicEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PToxicEffect", "no");
                        }
                        if (es.SorcerersDungeonRegion == SorcerersDungeonRegion.ElectEffect)
                        {
                            acc.SetTag("PElectEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PElectEffect", "no");
                        }
                        if (es.SorcerersDungeonRegion == SorcerersDungeonRegion.WaterEffect)
                        {
                            acc.SetTag("PWaterEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PWaterEffect", "no");
                        }
                        if (es.SorcerersDungeonRegion == SorcerersDungeonRegion.MistEffect)
                        {
                            acc.SetTag("PMistEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PMistEffect", "no");
                        }
                        if (es.SorcerersDungeonRegion == SorcerersDungeonRegion.ExplosionEffect)
                        {
                            acc.SetTag("PExplosionEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PExplosionEffect", "no");
                        }
                        if (es.SorcerersDungeonRegion == SorcerersDungeonRegion.StoneEffect)
                        {
                            acc.SetTag("PStoneEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PStoneEffect", "no");
                        }
                        if (es.SorcerersDungeonRegion == SorcerersDungeonRegion.ShineyEffect)
                        {
                            acc.SetTag("PShineyEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PShineyEffect", "no");
                        }
                        if (es.SorcerersDungeonRegion == SorcerersDungeonRegion.FireFlyEffect)
                        {
                            acc.SetTag("PFireFlyEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PFireFlyEffect", "no");
                        }
                    }
                    if (mp.Region.IsPartOf("Entrace Ancient Lair"))
                    {
                        if (es.EntAncientLairRegion == EntAncientLairRegion.DarkEffect)
                        {
                            acc.SetTag("PDarkEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PDarkEffect", "no");
                        }
                        if (es.EntAncientLairRegion == EntAncientLairRegion.FireEffect)
                        {
                            acc.SetTag("PFireEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PFireEffect", "no");
                        }
                        if (es.EntAncientLairRegion == EntAncientLairRegion.IceEffect)
                        {
                            acc.SetTag("PIceEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PIceEffect", "no");
                        }
                        if (es.EntAncientLairRegion == EntAncientLairRegion.ToxicEffect)
                        {
                            acc.SetTag("PToxicEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PToxicEffect", "no");
                        }
                        if (es.EntAncientLairRegion == EntAncientLairRegion.ElectEffect)
                        {
                            acc.SetTag("PElectEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PElectEffect", "no");
                        }
                        if (es.EntAncientLairRegion == EntAncientLairRegion.WaterEffect)
                        {
                            acc.SetTag("PWaterEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PWaterEffect", "no");
                        }
                        if (es.EntAncientLairRegion == EntAncientLairRegion.MistEffect)
                        {
                            acc.SetTag("PMistEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PMistEffect", "no");
                        }
                        if (es.EntAncientLairRegion == EntAncientLairRegion.ExplosionEffect)
                        {
                            acc.SetTag("PExplosionEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PExplosionEffect", "no");
                        }
                        if (es.EntAncientLairRegion == EntAncientLairRegion.StoneEffect)
                        {
                            acc.SetTag("PStoneEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PStoneEffect", "no");
                        }
                        if (es.EntAncientLairRegion == EntAncientLairRegion.ShineyEffect)
                        {
                            acc.SetTag("PShineyEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PShineyEffect", "no");
                        }
                        if (es.EntAncientLairRegion == EntAncientLairRegion.FireFlyEffect)
                        {
                            acc.SetTag("PFireFlyEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PFireFlyEffect", "no");
                        }
                    }
                    else if (mp.Region.IsPartOf("Ancient Lair"))
                    {
                        if (es.AncientLairRegion == AncientLairRegion.DarkEffect)
                        {
                            acc.SetTag("PDarkEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PDarkEffect", "no");
                        }
                        if (es.AncientLairRegion == AncientLairRegion.FireEffect)
                        {
                            acc.SetTag("PFireEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PFireEffect", "no");
                        }
                        if (es.AncientLairRegion == AncientLairRegion.IceEffect)
                        {
                            acc.SetTag("PIceEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PIceEffect", "no");
                        }
                        if (es.AncientLairRegion == AncientLairRegion.ToxicEffect)
                        {
                            acc.SetTag("PToxicEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PToxicEffect", "no");
                        }
                        if (es.AncientLairRegion == AncientLairRegion.ElectEffect)
                        {
                            acc.SetTag("PElectEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PElectEffect", "no");
                        }
                        if (es.AncientLairRegion == AncientLairRegion.WaterEffect)
                        {
                            acc.SetTag("PWaterEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PWaterEffect", "no");
                        }
                        if (es.AncientLairRegion == AncientLairRegion.MistEffect)
                        {
                            acc.SetTag("PMistEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PMistEffect", "no");
                        }
                        if (es.AncientLairRegion == AncientLairRegion.ExplosionEffect)
                        {
                            acc.SetTag("PExplosionEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PExplosionEffect", "no");
                        }
                        if (es.AncientLairRegion == AncientLairRegion.StoneEffect)
                        {
                            acc.SetTag("PStoneEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PStoneEffect", "no");
                        }
                        if (es.AncientLairRegion == AncientLairRegion.ShineyEffect)
                        {
                            acc.SetTag("PShineyEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PShineyEffect", "no");
                        }
                        if (es.AncientLairRegion == AncientLairRegion.FireFlyEffect)
                        {
                            acc.SetTag("PFireFlyEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PFireFlyEffect", "no");
                        }
                    }
                    else if (mp.Region.IsPartOf("Gypsy Camp"))
                    {
                        if (es.GypsyCampRegion == GypsyCampRegion.DarkEffect)
                        {
                            acc.SetTag("PDarkEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PDarkEffect", "no");
                        }
                        if (es.GypsyCampRegion == GypsyCampRegion.FireEffect)
                        {
                            acc.SetTag("PFireEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PFireEffect", "no");
                        }
                        if (es.GypsyCampRegion == GypsyCampRegion.IceEffect)
                        {
                            acc.SetTag("PIceEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PIceEffect", "no");
                        }
                        if (es.GypsyCampRegion == GypsyCampRegion.ToxicEffect)
                        {
                            acc.SetTag("PToxicEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PToxicEffect", "no");
                        }
                        if (es.GypsyCampRegion == GypsyCampRegion.ElectEffect)
                        {
                            acc.SetTag("PElectEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PElectEffect", "no");
                        }
                        if (es.GypsyCampRegion == GypsyCampRegion.WaterEffect)
                        {
                            acc.SetTag("PWaterEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PWaterEffect", "no");
                        }
                        if (es.GypsyCampRegion == GypsyCampRegion.MistEffect)
                        {
                            acc.SetTag("PMistEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PMistEffect", "no");
                        }
                        if (es.GypsyCampRegion == GypsyCampRegion.ExplosionEffect)
                        {
                            acc.SetTag("PExplosionEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PExplosionEffect", "no");
                        }
                        if (es.GypsyCampRegion == GypsyCampRegion.StoneEffect)
                        {
                            acc.SetTag("PStoneEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PStoneEffect", "no");
                        }
                        if (es.GypsyCampRegion == GypsyCampRegion.ShineyEffect)
                        {
                            acc.SetTag("PShineyEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PShineyEffect", "no");
                        }
                        if (es.GypsyCampRegion == GypsyCampRegion.FireFlyEffect)
                        {
                            acc.SetTag("PFireFlyEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PFireFlyEffect", "no");
                        }
                    }
                    else if (mp.Region.IsPartOf("Gypsy Camp 1"))
                    {
                        if (es.GypsyCamp1Region == GypsyCamp1Region.DarkEffect)
                        {
                            acc.SetTag("PDarkEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PDarkEffect", "no");
                        }
                        if (es.GypsyCamp1Region == GypsyCamp1Region.FireEffect)
                        {
                            acc.SetTag("PFireEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PFireEffect", "no");
                        }
                        if (es.GypsyCamp1Region == GypsyCamp1Region.IceEffect)
                        {
                            acc.SetTag("PIceEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PIceEffect", "no");
                        }
                        if (es.GypsyCamp1Region == GypsyCamp1Region.ToxicEffect)
                        {
                            acc.SetTag("PToxicEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PToxicEffect", "no");
                        }
                        if (es.GypsyCamp1Region == GypsyCamp1Region.ElectEffect)
                        {
                            acc.SetTag("PElectEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PElectEffect", "no");
                        }
                        if (es.GypsyCamp1Region == GypsyCamp1Region.WaterEffect)
                        {
                            acc.SetTag("PWaterEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PWaterEffect", "no");
                        }
                        if (es.GypsyCamp1Region == GypsyCamp1Region.MistEffect)
                        {
                            acc.SetTag("PMistEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PMistEffect", "no");
                        }
                        if (es.GypsyCamp1Region == GypsyCamp1Region.ExplosionEffect)
                        {
                            acc.SetTag("PExplosionEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PExplosionEffect", "no");
                        }
                        if (es.GypsyCamp1Region == GypsyCamp1Region.StoneEffect)
                        {
                            acc.SetTag("PStoneEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PStoneEffect", "no");
                        }
                        if (es.GypsyCamp1Region == GypsyCamp1Region.ShineyEffect)
                        {
                            acc.SetTag("PShineyEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PShineyEffect", "no");
                        }
                        if (es.GypsyCamp1Region == GypsyCamp1Region.FireFlyEffect)
                        {
                            acc.SetTag("PFireFlyEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PFireFlyEffect", "no");
                        }
                    }
                    else if (mp.Region.IsPartOf("Gypsy Camp 2"))
                    {
                        if (es.GypsyCamp2Region == GypsyCamp2Region.DarkEffect)
                        {
                            acc.SetTag("PDarkEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PDarkEffect", "no");
                        }
                        if (es.GypsyCamp2Region == GypsyCamp2Region.FireEffect)
                        {
                            acc.SetTag("PFireEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PFireEffect", "no");
                        }
                        if (es.GypsyCamp2Region == GypsyCamp2Region.IceEffect)
                        {
                            acc.SetTag("PIceEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PIceEffect", "no");
                        }
                        if (es.GypsyCamp2Region == GypsyCamp2Region.ToxicEffect)
                        {
                            acc.SetTag("PToxicEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PToxicEffect", "no");
                        }
                        if (es.GypsyCamp2Region == GypsyCamp2Region.ElectEffect)
                        {
                            acc.SetTag("PElectEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PElectEffect", "no");
                        }
                        if (es.GypsyCamp2Region == GypsyCamp2Region.WaterEffect)
                        {
                            acc.SetTag("PWaterEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PWaterEffect", "no");
                        }
                        if (es.GypsyCamp2Region == GypsyCamp2Region.MistEffect)
                        {
                            acc.SetTag("PMistEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PMistEffect", "no");
                        }
                        if (es.GypsyCamp2Region == GypsyCamp2Region.ExplosionEffect)
                        {
                            acc.SetTag("PExplosionEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PExplosionEffect", "no");
                        }
                        if (es.GypsyCamp2Region == GypsyCamp2Region.StoneEffect)
                        {
                            acc.SetTag("PStoneEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PStoneEffect", "no");
                        }
                        if (es.GypsyCamp2Region == GypsyCamp2Region.ShineyEffect)
                        {
                            acc.SetTag("PShineyEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PShineyEffect", "no");
                        }
                        if (es.GypsyCamp2Region == GypsyCamp2Region.FireFlyEffect)
                        {
                            acc.SetTag("PFireFlyEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PFireFlyEffect", "no");
                        }
                    }
                    else if (mp.Region.IsPartOf("Juka Camp"))
                    {
                        if (es.JukaCampRegion == JukaCampRegion.DarkEffect)
                        {
                            acc.SetTag("PDarkEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PDarkEffect", "no");
                        }
                        if (es.JukaCampRegion == JukaCampRegion.FireEffect)
                        {
                            acc.SetTag("PFireEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PFireEffect", "no");
                        }
                        if (es.JukaCampRegion == JukaCampRegion.IceEffect)
                        {
                            acc.SetTag("PIceEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PIceEffect", "no");
                        }
                        if (es.JukaCampRegion == JukaCampRegion.ToxicEffect)
                        {
                            acc.SetTag("PToxicEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PToxicEffect", "no");
                        }
                        if (es.JukaCampRegion == JukaCampRegion.ElectEffect)
                        {
                            acc.SetTag("PElectEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PElectEffect", "no");
                        }
                        if (es.JukaCampRegion == JukaCampRegion.WaterEffect)
                        {
                            acc.SetTag("PWaterEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PWaterEffect", "no");
                        }
                        if (es.JukaCampRegion == JukaCampRegion.MistEffect)
                        {
                            acc.SetTag("PMistEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PMistEffect", "no");
                        }
                        if (es.JukaCampRegion == JukaCampRegion.ExplosionEffect)
                        {
                            acc.SetTag("PExplosionEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PExplosionEffect", "no");
                        }
                        if (es.JukaCampRegion == JukaCampRegion.StoneEffect)
                        {
                            acc.SetTag("PStoneEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PStoneEffect", "no");
                        }
                        if (es.JukaCampRegion == JukaCampRegion.ShineyEffect)
                        {
                            acc.SetTag("PShineyEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PShineyEffect", "no");
                        }
                        if (es.JukaCampRegion == JukaCampRegion.FireFlyEffect)
                        {
                            acc.SetTag("PFireFlyEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PFireFlyEffect", "no");
                        }
                    }
                    else if (mp.Region.IsPartOf("Gypsy Camp 3"))
                    {
                        if (es.GypsyCamp3Region == GypsyCamp3Region.DarkEffect)
                        {
                            acc.SetTag("PDarkEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PDarkEffect", "no");
                        }
                        if (es.GypsyCamp3Region == GypsyCamp3Region.FireEffect)
                        {
                            acc.SetTag("PFireEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PFireEffect", "no");
                        }
                        if (es.GypsyCamp3Region == GypsyCamp3Region.IceEffect)
                        {
                            acc.SetTag("PIceEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PIceEffect", "no");
                        }
                        if (es.GypsyCamp3Region == GypsyCamp3Region.ToxicEffect)
                        {
                            acc.SetTag("PToxicEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PToxicEffect", "no");
                        }
                        if (es.GypsyCamp3Region == GypsyCamp3Region.ElectEffect)
                        {
                            acc.SetTag("PElectEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PElectEffect", "no");
                        }
                        if (es.GypsyCamp3Region == GypsyCamp3Region.WaterEffect)
                        {
                            acc.SetTag("PWaterEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PWaterEffect", "no");
                        }
                        if (es.GypsyCamp3Region == GypsyCamp3Region.MistEffect)
                        {
                            acc.SetTag("PMistEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PMistEffect", "no");
                        }
                        if (es.GypsyCamp3Region == GypsyCamp3Region.ExplosionEffect)
                        {
                            acc.SetTag("PExplosionEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PExplosionEffect", "no");
                        }
                        if (es.GypsyCamp3Region == GypsyCamp3Region.StoneEffect)
                        {
                            acc.SetTag("PStoneEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PStoneEffect", "no");
                        }
                        if (es.GypsyCamp3Region == GypsyCamp3Region.ShineyEffect)
                        {
                            acc.SetTag("PShineyEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PShineyEffect", "no");
                        }
                        if (es.GypsyCamp3Region == GypsyCamp3Region.FireFlyEffect)
                        {
                            acc.SetTag("PFireFlyEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PFireFlyEffect", "no");
                        }
                    }
                    else if (mp.Region.IsPartOf("Gypsy Camp 4"))
                    {
                        if (es.GypsyCamp4Region == GypsyCamp4Region.DarkEffect)
                        {
                            acc.SetTag("PDarkEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PDarkEffect", "no");
                        }
                        if (es.GypsyCamp4Region == GypsyCamp4Region.FireEffect)
                        {
                            acc.SetTag("PFireEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PFireEffect", "no");
                        }
                        if (es.GypsyCamp4Region == GypsyCamp4Region.IceEffect)
                        {
                            acc.SetTag("PIceEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PIceEffect", "no");
                        }
                        if (es.GypsyCamp4Region == GypsyCamp4Region.ToxicEffect)
                        {
                            acc.SetTag("PToxicEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PToxicEffect", "no");
                        }
                        if (es.GypsyCamp4Region == GypsyCamp4Region.ElectEffect)
                        {
                            acc.SetTag("PElectEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PElectEffect", "no");
                        }
                        if (es.GypsyCamp4Region == GypsyCamp4Region.WaterEffect)
                        {
                            acc.SetTag("PWaterEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PWaterEffect", "no");
                        }
                        if (es.GypsyCamp4Region == GypsyCamp4Region.MistEffect)
                        {
                            acc.SetTag("PMistEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PMistEffect", "no");
                        }
                        if (es.GypsyCamp4Region == GypsyCamp4Region.ExplosionEffect)
                        {
                            acc.SetTag("PExplosionEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PExplosionEffect", "no");
                        }
                        if (es.GypsyCamp4Region == GypsyCamp4Region.StoneEffect)
                        {
                            acc.SetTag("PStoneEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PStoneEffect", "no");
                        }
                        if (es.GypsyCamp4Region == GypsyCamp4Region.ShineyEffect)
                        {
                            acc.SetTag("PShineyEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PShineyEffect", "no");
                        }
                        if (es.GypsyCamp4Region == GypsyCamp4Region.FireFlyEffect)
                        {
                            acc.SetTag("PFireFlyEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PFireFlyEffect", "no");
                        }
                    }
                    else if (mp.Region.IsPartOf("Gypsy Camp 5"))
                    {
                        if (es.GypsyCamp5Region == GypsyCamp5Region.DarkEffect)
                        {
                            acc.SetTag("PDarkEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PDarkEffect", "no");
                        }
                        if (es.GypsyCamp5Region == GypsyCamp5Region.FireEffect)
                        {
                            acc.SetTag("PFireEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PFireEffect", "no");
                        }
                        if (es.GypsyCamp5Region == GypsyCamp5Region.IceEffect)
                        {
                            acc.SetTag("PIceEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PIceEffect", "no");
                        }
                        if (es.GypsyCamp5Region == GypsyCamp5Region.ToxicEffect)
                        {
                            acc.SetTag("PToxicEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PToxicEffect", "no");
                        }
                        if (es.GypsyCamp5Region == GypsyCamp5Region.ElectEffect)
                        {
                            acc.SetTag("PElectEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PElectEffect", "no");
                        }
                        if (es.GypsyCamp5Region == GypsyCamp5Region.WaterEffect)
                        {
                            acc.SetTag("PWaterEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PWaterEffect", "no");
                        }
                        if (es.GypsyCamp5Region == GypsyCamp5Region.MistEffect)
                        {
                            acc.SetTag("PMistEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PMistEffect", "no");
                        }
                        if (es.GypsyCamp5Region == GypsyCamp5Region.ExplosionEffect)
                        {
                            acc.SetTag("PExplosionEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PExplosionEffect", "no");
                        }
                        if (es.GypsyCamp5Region == GypsyCamp5Region.StoneEffect)
                        {
                            acc.SetTag("PStoneEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PStoneEffect", "no");
                        }
                        if (es.GypsyCamp5Region == GypsyCamp5Region.ShineyEffect)
                        {
                            acc.SetTag("PShineyEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PShineyEffect", "no");
                        }
                        if (es.GypsyCamp5Region == GypsyCamp5Region.FireFlyEffect)
                        {
                            acc.SetTag("PFireFlyEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PFireFlyEffect", "no");
                        }
                    }
                    else if (mp.Region.IsPartOf("Gypsy Camp 6"))
                    {
                        if (es.GypsyCamp6Region == GypsyCamp6Region.DarkEffect)
                        {
                            acc.SetTag("PDarkEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PDarkEffect", "no");
                        }
                        if (es.GypsyCamp6Region == GypsyCamp6Region.FireEffect)
                        {
                            acc.SetTag("PFireEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PFireEffect", "no");
                        }
                        if (es.GypsyCamp6Region == GypsyCamp6Region.IceEffect)
                        {
                            acc.SetTag("PIceEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PIceEffect", "no");
                        }
                        if (es.GypsyCamp6Region == GypsyCamp6Region.ToxicEffect)
                        {
                            acc.SetTag("PToxicEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PToxicEffect", "no");
                        }
                        if (es.GypsyCamp6Region == GypsyCamp6Region.ElectEffect)
                        {
                            acc.SetTag("PElectEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PElectEffect", "no");
                        }
                        if (es.GypsyCamp6Region == GypsyCamp6Region.WaterEffect)
                        {
                            acc.SetTag("PWaterEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PWaterEffect", "no");
                        }
                        if (es.GypsyCamp6Region == GypsyCamp6Region.MistEffect)
                        {
                            acc.SetTag("PMistEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PMistEffect", "no");
                        }
                        if (es.GypsyCamp6Region == GypsyCamp6Region.ExplosionEffect)
                        {
                            acc.SetTag("PExplosionEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PExplosionEffect", "no");
                        }
                        if (es.GypsyCamp6Region == GypsyCamp6Region.StoneEffect)
                        {
                            acc.SetTag("PStoneEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PStoneEffect", "no");
                        }
                        if (es.GypsyCamp6Region == GypsyCamp6Region.ShineyEffect)
                        {
                            acc.SetTag("PShineyEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PShineyEffect", "no");
                        }
                        if (es.GypsyCamp6Region == GypsyCamp6Region.FireFlyEffect)
                        {
                            acc.SetTag("PFireFlyEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PFireFlyEffect", "no");
                        }
                    }
                    else if (mp.Region.IsPartOf("Lord Blackthorn's Ilshenar Castle"))
                    {
                        if (es.BlackthornsIlshCastleRegion == BlackthornsIlshCastleRegion.DarkEffect)
                        {
                            acc.SetTag("PDarkEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PDarkEffect", "no");
                        }
                        if (es.BlackthornsIlshCastleRegion == BlackthornsIlshCastleRegion.FireEffect)
                        {
                            acc.SetTag("PFireEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PFireEffect", "no");
                        }
                        if (es.BlackthornsIlshCastleRegion == BlackthornsIlshCastleRegion.IceEffect)
                        {
                            acc.SetTag("PIceEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PIceEffect", "no");
                        }
                        if (es.BlackthornsIlshCastleRegion == BlackthornsIlshCastleRegion.ToxicEffect)
                        {
                            acc.SetTag("PToxicEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PToxicEffect", "no");
                        }
                        if (es.BlackthornsIlshCastleRegion == BlackthornsIlshCastleRegion.ElectEffect)
                        {
                            acc.SetTag("PElectEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PElectEffect", "no");
                        }
                        if (es.BlackthornsIlshCastleRegion == BlackthornsIlshCastleRegion.WaterEffect)
                        {
                            acc.SetTag("PWaterEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PWaterEffect", "no");
                        }
                        if (es.BlackthornsIlshCastleRegion == BlackthornsIlshCastleRegion.MistEffect)
                        {
                            acc.SetTag("PMistEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PMistEffect", "no");
                        }
                        if (es.BlackthornsIlshCastleRegion == BlackthornsIlshCastleRegion.ExplosionEffect)
                        {
                            acc.SetTag("PExplosionEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PExplosionEffect", "no");
                        }
                        if (es.BlackthornsIlshCastleRegion == BlackthornsIlshCastleRegion.StoneEffect)
                        {
                            acc.SetTag("PStoneEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PStoneEffect", "no");
                        }
                        if (es.BlackthornsIlshCastleRegion == BlackthornsIlshCastleRegion.ShineyEffect)
                        {
                            acc.SetTag("PShineyEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PShineyEffect", "no");
                        }
                        if (es.BlackthornsIlshCastleRegion == BlackthornsIlshCastleRegion.FireFlyEffect)
                        {
                            acc.SetTag("PFireFlyEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PFireFlyEffect", "no");
                        }
                    }
                    else if (mp.Region.IsPartOf("Shrine of Virtues"))
                    {
                        if (es.ShrineofVirtuesRegion == ShrineofVirtuesRegion.DarkEffect)
                        {
                            acc.SetTag("PDarkEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PDarkEffect", "no");
                        }
                        if (es.ShrineofVirtuesRegion == ShrineofVirtuesRegion.FireEffect)
                        {
                            acc.SetTag("PFireEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PFireEffect", "no");
                        }
                        if (es.ShrineofVirtuesRegion == ShrineofVirtuesRegion.IceEffect)
                        {
                            acc.SetTag("PIceEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PIceEffect", "no");
                        }
                        if (es.ShrineofVirtuesRegion == ShrineofVirtuesRegion.ToxicEffect)
                        {
                            acc.SetTag("PToxicEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PToxicEffect", "no");
                        }
                        if (es.ShrineofVirtuesRegion == ShrineofVirtuesRegion.ElectEffect)
                        {
                            acc.SetTag("PElectEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PElectEffect", "no");
                        }
                        if (es.ShrineofVirtuesRegion == ShrineofVirtuesRegion.WaterEffect)
                        {
                            acc.SetTag("PWaterEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PWaterEffect", "no");
                        }
                        if (es.ShrineofVirtuesRegion == ShrineofVirtuesRegion.MistEffect)
                        {
                            acc.SetTag("PMistEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PMistEffect", "no");
                        }
                        if (es.ShrineofVirtuesRegion == ShrineofVirtuesRegion.ExplosionEffect)
                        {
                            acc.SetTag("PExplosionEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PExplosionEffect", "no");
                        }
                        if (es.ShrineofVirtuesRegion == ShrineofVirtuesRegion.StoneEffect)
                        {
                            acc.SetTag("PStoneEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PStoneEffect", "no");
                        }
                        if (es.ShrineofVirtuesRegion == ShrineofVirtuesRegion.ShineyEffect)
                        {
                            acc.SetTag("PShineyEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PShineyEffect", "no");
                        }
                        if (es.ShrineofVirtuesRegion == ShrineofVirtuesRegion.FireFlyEffect)
                        {
                            acc.SetTag("PFireFlyEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PFireFlyEffect", "no");
                        }
                    }
                    else if (mp.Region.IsPartOf("Pass of Karnaugh"))
                    {
                        if (es.PassofKarnaughRegion == PassofKarnaughRegion.DarkEffect)
                        {
                            acc.SetTag("PDarkEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PDarkEffect", "no");
                        }
                        if (es.PassofKarnaughRegion == PassofKarnaughRegion.FireEffect)
                        {
                            acc.SetTag("PFireEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PFireEffect", "no");
                        }
                        if (es.PassofKarnaughRegion == PassofKarnaughRegion.IceEffect)
                        {
                            acc.SetTag("PIceEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PIceEffect", "no");
                        }
                        if (es.PassofKarnaughRegion == PassofKarnaughRegion.ToxicEffect)
                        {
                            acc.SetTag("PToxicEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PToxicEffect", "no");
                        }
                        if (es.PassofKarnaughRegion == PassofKarnaughRegion.ElectEffect)
                        {
                            acc.SetTag("PElectEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PElectEffect", "no");
                        }
                        if (es.PassofKarnaughRegion == PassofKarnaughRegion.WaterEffect)
                        {
                            acc.SetTag("PWaterEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PWaterEffect", "no");
                        }
                        if (es.PassofKarnaughRegion == PassofKarnaughRegion.MistEffect)
                        {
                            acc.SetTag("PMistEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PMistEffect", "no");
                        }
                        if (es.PassofKarnaughRegion == PassofKarnaughRegion.ExplosionEffect)
                        {
                            acc.SetTag("PExplosionEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PExplosionEffect", "no");
                        }
                        if (es.PassofKarnaughRegion == PassofKarnaughRegion.StoneEffect)
                        {
                            acc.SetTag("PStoneEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PStoneEffect", "no");
                        }
                        if (es.PassofKarnaughRegion == PassofKarnaughRegion.ShineyEffect)
                        {
                            acc.SetTag("PShineyEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PShineyEffect", "no");
                        }
                        if (es.PassofKarnaughRegion == PassofKarnaughRegion.FireFlyEffect)
                        {
                            acc.SetTag("PFireFlyEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PFireFlyEffect", "no");
                        }
                    }
                    else if (mp.Region.IsPartOf("Vinculum Inn"))
                    {
                        if (es.VinculumInnRegion == VinculumInnRegion.DarkEffect)
                        {
                            acc.SetTag("PDarkEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PDarkEffect", "no");
                        }
                        if (es.VinculumInnRegion == VinculumInnRegion.FireEffect)
                        {
                            acc.SetTag("PFireEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PFireEffect", "no");
                        }
                        if (es.VinculumInnRegion == VinculumInnRegion.IceEffect)
                        {
                            acc.SetTag("PIceEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PIceEffect", "no");
                        }
                        if (es.VinculumInnRegion == VinculumInnRegion.ToxicEffect)
                        {
                            acc.SetTag("PToxicEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PToxicEffect", "no");
                        }
                        if (es.VinculumInnRegion == VinculumInnRegion.ElectEffect)
                        {
                            acc.SetTag("PElectEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PElectEffect", "no");
                        }
                        if (es.VinculumInnRegion == VinculumInnRegion.WaterEffect)
                        {
                            acc.SetTag("PWaterEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PWaterEffect", "no");
                        }
                        if (es.VinculumInnRegion == VinculumInnRegion.MistEffect)
                        {
                            acc.SetTag("PMistEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PMistEffect", "no");
                        }
                        if (es.VinculumInnRegion == VinculumInnRegion.ExplosionEffect)
                        {
                            acc.SetTag("PExplosionEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PExplosionEffect", "no");
                        }
                        if (es.VinculumInnRegion == VinculumInnRegion.StoneEffect)
                        {
                            acc.SetTag("PStoneEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PStoneEffect", "no");
                        }
                        if (es.VinculumInnRegion == VinculumInnRegion.ShineyEffect)
                        {
                            acc.SetTag("PShineyEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PShineyEffect", "no");
                        }
                        if (es.VinculumInnRegion == VinculumInnRegion.FireFlyEffect)
                        {
                            acc.SetTag("PFireFlyEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PFireFlyEffect", "no");
                        }
                    }
                    else if (mp.Region.IsPartOf("Luna"))
                    {
                        if (es.LunaRegion == LunaRegion.DarkEffect)
                        {
                            acc.SetTag("PDarkEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PDarkEffect", "no");
                        }
                        if (es.LunaRegion == LunaRegion.FireEffect)
                        {
                            acc.SetTag("PFireEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PFireEffect", "no");
                        }
                        if (es.LunaRegion == LunaRegion.IceEffect)
                        {
                            acc.SetTag("PIceEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PIceEffect", "no");
                        }
                        if (es.LunaRegion == LunaRegion.ToxicEffect)
                        {
                            acc.SetTag("PToxicEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PToxicEffect", "no");
                        }
                        if (es.LunaRegion == LunaRegion.ElectEffect)
                        {
                            acc.SetTag("PElectEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PElectEffect", "no");
                        }
                        if (es.LunaRegion == LunaRegion.WaterEffect)
                        {
                            acc.SetTag("PWaterEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PWaterEffect", "no");
                        }
                        if (es.LunaRegion == LunaRegion.MistEffect)
                        {
                            acc.SetTag("PMistEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PMistEffect", "no");
                        }
                        if (es.LunaRegion == LunaRegion.ExplosionEffect)
                        {
                            acc.SetTag("PExplosionEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PExplosionEffect", "no");
                        }
                        if (es.LunaRegion == LunaRegion.StoneEffect)
                        {
                            acc.SetTag("PStoneEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PStoneEffect", "no");
                        }
                        if (es.LunaRegion == LunaRegion.ShineyEffect)
                        {
                            acc.SetTag("PShineyEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PShineyEffect", "no");
                        }
                        if (es.LunaRegion == LunaRegion.FireFlyEffect)
                        {
                            acc.SetTag("PFireFlyEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PFireFlyEffect", "no");
                        }
                    }
                    else if (mp.Region.IsPartOf("Umbra"))
                    {
                        if (es.UmbraRegion == UmbraRegion.DarkEffect)
                        {
                            acc.SetTag("PDarkEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PDarkEffect", "no");
                        }
                        if (es.UmbraRegion == UmbraRegion.FireEffect)
                        {
                            acc.SetTag("PFireEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PFireEffect", "no");
                        }
                        if (es.UmbraRegion == UmbraRegion.IceEffect)
                        {
                            acc.SetTag("PIceEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PIceEffect", "no");
                        }
                        if (es.UmbraRegion == UmbraRegion.ToxicEffect)
                        {
                            acc.SetTag("PToxicEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PToxicEffect", "no");
                        }
                        if (es.UmbraRegion == UmbraRegion.ElectEffect)
                        {
                            acc.SetTag("PElectEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PElectEffect", "no");
                        }
                        if (es.UmbraRegion == UmbraRegion.WaterEffect)
                        {
                            acc.SetTag("PWaterEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PWaterEffect", "no");
                        }
                        if (es.UmbraRegion == UmbraRegion.MistEffect)
                        {
                            acc.SetTag("PMistEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PMistEffect", "no");
                        }
                        if (es.UmbraRegion == UmbraRegion.ExplosionEffect)
                        {
                            acc.SetTag("PExplosionEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PExplosionEffect", "no");
                        }
                        if (es.UmbraRegion == UmbraRegion.StoneEffect)
                        {
                            acc.SetTag("PStoneEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PStoneEffect", "no");
                        }
                        if (es.UmbraRegion == UmbraRegion.ShineyEffect)
                        {
                            acc.SetTag("PShineyEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PShineyEffect", "no");
                        }
                        if (es.UmbraRegion == UmbraRegion.FireFlyEffect)
                        {
                            acc.SetTag("PFireFlyEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PFireFlyEffect", "no");
                        }
                    }
                    else if (mp.Region.IsPartOf("Doom"))
                    {
                        if (es.DoomRegion == DoomRegion.DarkEffect)
                        {
                            acc.SetTag("PDarkEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PDarkEffect", "no");
                        }
                        if (es.DoomRegion == DoomRegion.FireEffect)
                        {
                            acc.SetTag("PFireEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PFireEffect", "no");
                        }
                        if (es.DoomRegion == DoomRegion.IceEffect)
                        {
                            acc.SetTag("PIceEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PIceEffect", "no");
                        }
                        if (es.DoomRegion == DoomRegion.ToxicEffect)
                        {
                            acc.SetTag("PToxicEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PToxicEffect", "no");
                        }
                        if (es.DoomRegion == DoomRegion.ElectEffect)
                        {
                            acc.SetTag("PElectEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PElectEffect", "no");
                        }
                        if (es.DoomRegion == DoomRegion.WaterEffect)
                        {
                            acc.SetTag("PWaterEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PWaterEffect", "no");
                        }
                        if (es.DoomRegion == DoomRegion.MistEffect)
                        {
                            acc.SetTag("PMistEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PMistEffect", "no");
                        }
                        if (es.DoomRegion == DoomRegion.ExplosionEffect)
                        {
                            acc.SetTag("PExplosionEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PExplosionEffect", "no");
                        }
                        if (es.DoomRegion == DoomRegion.StoneEffect)
                        {
                            acc.SetTag("PStoneEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PStoneEffect", "no");
                        }
                        if (es.DoomRegion == DoomRegion.ShineyEffect)
                        {
                            acc.SetTag("PShineyEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PShineyEffect", "no");
                        }
                        if (es.DoomRegion == DoomRegion.FireFlyEffect)
                        {
                            acc.SetTag("PFireFlyEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PFireFlyEffect", "no");
                        }
                    }
                    else if (mp.Region.IsPartOf("Doom Gauntlet"))
                    {
                        if (es.DoomGauntletRegion == DoomGauntletRegion.DarkEffect)
                        {
                            acc.SetTag("PDarkEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PDarkEffect", "no");
                        }
                        if (es.DoomGauntletRegion == DoomGauntletRegion.FireEffect)
                        {
                            acc.SetTag("PFireEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PFireEffect", "no");
                        }
                        if (es.DoomGauntletRegion == DoomGauntletRegion.IceEffect)
                        {
                            acc.SetTag("PIceEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PIceEffect", "no");
                        }
                        if (es.DoomGauntletRegion == DoomGauntletRegion.ToxicEffect)
                        {
                            acc.SetTag("PToxicEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PToxicEffect", "no");
                        }
                        if (es.DoomGauntletRegion == DoomGauntletRegion.ElectEffect)
                        {
                            acc.SetTag("PElectEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PElectEffect", "no");
                        }
                        if (es.DoomGauntletRegion == DoomGauntletRegion.WaterEffect)
                        {
                            acc.SetTag("PWaterEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PWaterEffect", "no");
                        }
                        if (es.DoomGauntletRegion == DoomGauntletRegion.MistEffect)
                        {
                            acc.SetTag("PMistEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PMistEffect", "no");
                        }
                        if (es.DoomGauntletRegion == DoomGauntletRegion.ExplosionEffect)
                        {
                            acc.SetTag("PExplosionEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PExplosionEffect", "no");
                        }
                        if (es.DoomGauntletRegion == DoomGauntletRegion.StoneEffect)
                        {
                            acc.SetTag("PStoneEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PStoneEffect", "no");
                        }
                        if (es.DoomGauntletRegion == DoomGauntletRegion.ShineyEffect)
                        {
                            acc.SetTag("PShineyEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PShineyEffect", "no");
                        }
                        if (es.DoomGauntletRegion == DoomGauntletRegion.FireFlyEffect)
                        {
                            acc.SetTag("PFireFlyEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PFireFlyEffect", "no");
                        }
                    }
                    else if (mp.Region.IsPartOf("Orc Fortress"))
                    {
                        if (es.OrcFortressRegion == OrcFortressRegion.DarkEffect)
                        {
                            acc.SetTag("PDarkEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PDarkEffect", "no");
                        }
                        if (es.OrcFortressRegion == OrcFortressRegion.FireEffect)
                        {
                            acc.SetTag("PFireEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PFireEffect", "no");
                        }
                        if (es.OrcFortressRegion == OrcFortressRegion.IceEffect)
                        {
                            acc.SetTag("PIceEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PIceEffect", "no");
                        }
                        if (es.OrcFortressRegion == OrcFortressRegion.ToxicEffect)
                        {
                            acc.SetTag("PToxicEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PToxicEffect", "no");
                        }
                        if (es.OrcFortressRegion == OrcFortressRegion.ElectEffect)
                        {
                            acc.SetTag("PElectEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PElectEffect", "no");
                        }
                        if (es.OrcFortressRegion == OrcFortressRegion.WaterEffect)
                        {
                            acc.SetTag("PWaterEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PWaterEffect", "no");
                        }
                        if (es.OrcFortressRegion == OrcFortressRegion.MistEffect)
                        {
                            acc.SetTag("PMistEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PMistEffect", "no");
                        }
                        if (es.OrcFortressRegion == OrcFortressRegion.ExplosionEffect)
                        {
                            acc.SetTag("PExplosionEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PExplosionEffect", "no");
                        }
                        if (es.OrcFortressRegion == OrcFortressRegion.StoneEffect)
                        {
                            acc.SetTag("PStoneEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PStoneEffect", "no");
                        }
                        if (es.OrcFortressRegion == OrcFortressRegion.ShineyEffect)
                        {
                            acc.SetTag("PShineyEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PShineyEffect", "no");
                        }
                        if (es.OrcFortressRegion == OrcFortressRegion.FireFlyEffect)
                        {
                            acc.SetTag("PFireFlyEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PFireFlyEffect", "no");
                        }
                    }
                    else if (mp.Region.IsPartOf("Crystal Cave Entrance"))
                    {
                        if (es.CrystalCaveEntRegion == CrystalCaveEntRegion.DarkEffect)
                        {
                            acc.SetTag("PDarkEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PDarkEffect", "no");
                        }
                        if (es.CrystalCaveEntRegion == CrystalCaveEntRegion.FireEffect)
                        {
                            acc.SetTag("PFireEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PFireEffect", "no");
                        }
                        if (es.CrystalCaveEntRegion == CrystalCaveEntRegion.IceEffect)
                        {
                            acc.SetTag("PIceEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PIceEffect", "no");
                        }
                        if (es.CrystalCaveEntRegion == CrystalCaveEntRegion.ToxicEffect)
                        {
                            acc.SetTag("PToxicEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PToxicEffect", "no");
                        }
                        if (es.CrystalCaveEntRegion == CrystalCaveEntRegion.ElectEffect)
                        {
                            acc.SetTag("PElectEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PElectEffect", "no");
                        }
                        if (es.CrystalCaveEntRegion == CrystalCaveEntRegion.WaterEffect)
                        {
                            acc.SetTag("PWaterEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PWaterEffect", "no");
                        }
                        if (es.CrystalCaveEntRegion == CrystalCaveEntRegion.MistEffect)
                        {
                            acc.SetTag("PMistEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PMistEffect", "no");
                        }
                        if (es.CrystalCaveEntRegion == CrystalCaveEntRegion.ExplosionEffect)
                        {
                            acc.SetTag("PExplosionEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PExplosionEffect", "no");
                        }
                        if (es.CrystalCaveEntRegion == CrystalCaveEntRegion.StoneEffect)
                        {
                            acc.SetTag("PStoneEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PStoneEffect", "no");
                        }
                        if (es.CrystalCaveEntRegion == CrystalCaveEntRegion.ShineyEffect)
                        {
                            acc.SetTag("PShineyEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PShineyEffect", "no");
                        }
                        if (es.CrystalCaveEntRegion == CrystalCaveEntRegion.FireFlyEffect)
                        {
                            acc.SetTag("PFireFlyEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PFireFlyEffect", "no");
                        }
                    }
                    else if (mp.Region.IsPartOf("Protected Island"))
                    {

                        if (es.ProtectedIslandRegion == ProtectedIslandRegion.DarkEffect)
                        {
                            acc.SetTag("PDarkEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PDarkEffect", "no");
                        }
                        if (es.ProtectedIslandRegion == ProtectedIslandRegion.FireEffect)
                        {
                            acc.SetTag("PFireEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PFireEffect", "no");
                        }
                        if (es.ProtectedIslandRegion == ProtectedIslandRegion.IceEffect)
                        {
                            acc.SetTag("PIceEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PIceEffect", "no");
                        }
                        if (es.ProtectedIslandRegion == ProtectedIslandRegion.ToxicEffect)
                        {
                            acc.SetTag("PToxicEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PToxicEffect", "no");
                        }
                        if (es.ProtectedIslandRegion == ProtectedIslandRegion.ElectEffect)
                        {
                            acc.SetTag("PElectEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PElectEffect", "no");
                        }
                        if (es.ProtectedIslandRegion == ProtectedIslandRegion.WaterEffect)
                        {
                            acc.SetTag("PWaterEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PWaterEffect", "no");
                        }
                        if (es.ProtectedIslandRegion == ProtectedIslandRegion.MistEffect)
                        {
                            acc.SetTag("PMistEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PMistEffect", "no");
                        }
                        if (es.ProtectedIslandRegion == ProtectedIslandRegion.ExplosionEffect)
                        {
                            acc.SetTag("PExplosionEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PExplosionEffect", "no");
                        }
                        if (es.ProtectedIslandRegion == ProtectedIslandRegion.StoneEffect)
                        {
                            acc.SetTag("PStoneEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PStoneEffect", "no");
                        }
                        if (es.ProtectedIslandRegion == ProtectedIslandRegion.ShineyEffect)
                        {
                            acc.SetTag("PShineyEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PShineyEffect", "no");
                        }
                        if (es.ProtectedIslandRegion == ProtectedIslandRegion.FireFlyEffect)
                        {
                            acc.SetTag("PFireFlyEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PFireFlyEffect", "no");
                        }
                    }
                    else if (mp.Region.IsPartOf("Grand Arena"))
                    {
                        if (es.GrandArenaRegion == GrandArenaRegion.DarkEffect)
                        {
                            acc.SetTag("PDarkEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PDarkEffect", "no");
                        }
                        if (es.GrandArenaRegion == GrandArenaRegion.FireEffect)
                        {
                            acc.SetTag("PFireEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PFireEffect", "no");
                        }
                        if (es.GrandArenaRegion == GrandArenaRegion.IceEffect)
                        {
                            acc.SetTag("PIceEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PIceEffect", "no");
                        }
                        if (es.GrandArenaRegion == GrandArenaRegion.ToxicEffect)
                        {
                            acc.SetTag("PToxicEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PToxicEffect", "no");
                        }
                        if (es.GrandArenaRegion == GrandArenaRegion.ElectEffect)
                        {
                            acc.SetTag("PElectEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PElectEffect", "no");
                        }
                        if (es.GrandArenaRegion == GrandArenaRegion.WaterEffect)
                        {
                            acc.SetTag("PWaterEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PWaterEffect", "no");
                        }
                        if (es.GrandArenaRegion == GrandArenaRegion.MistEffect)
                        {
                            acc.SetTag("PMistEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PMistEffect", "no");
                        }
                        if (es.GrandArenaRegion == GrandArenaRegion.ExplosionEffect)
                        {
                            acc.SetTag("PExplosionEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PExplosionEffect", "no");
                        }
                        if (es.GrandArenaRegion == GrandArenaRegion.StoneEffect)
                        {
                            acc.SetTag("PStoneEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PStoneEffect", "no");
                        }
                        if (es.GrandArenaRegion == GrandArenaRegion.ShineyEffect)
                        {
                            acc.SetTag("PShineyEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PShineyEffect", "no");
                        }
                        if (es.GrandArenaRegion == GrandArenaRegion.FireFlyEffect)
                        {
                            acc.SetTag("PFireFlyEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PFireFlyEffect", "no");
                        }
                    }
                    else if (mp.Region.IsPartOf("Hanse's Hostel"))
                    {
                        if (es.HansesHostelRegion == HansesHostelRegion.DarkEffect)
                        {
                            acc.SetTag("PDarkEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PDarkEffect", "no");
                        }
                        if (es.HansesHostelRegion == HansesHostelRegion.FireEffect)
                        {
                            acc.SetTag("PFireEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PFireEffect", "no");
                        }
                        if (es.HansesHostelRegion == HansesHostelRegion.IceEffect)
                        {
                            acc.SetTag("PIceEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PIceEffect", "no");
                        }
                        if (es.HansesHostelRegion == HansesHostelRegion.ToxicEffect)
                        {
                            acc.SetTag("PToxicEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PToxicEffect", "no");
                        }
                        if (es.HansesHostelRegion == HansesHostelRegion.ElectEffect)
                        {
                            acc.SetTag("PElectEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PElectEffect", "no");
                        }
                        if (es.HansesHostelRegion == HansesHostelRegion.WaterEffect)
                        {
                            acc.SetTag("PWaterEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PWaterEffect", "no");
                        }
                        if (es.HansesHostelRegion == HansesHostelRegion.MistEffect)
                        {
                            acc.SetTag("PMistEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PMistEffect", "no");
                        }
                        if (es.HansesHostelRegion == HansesHostelRegion.ExplosionEffect)
                        {
                            acc.SetTag("PExplosionEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PExplosionEffect", "no");
                        }
                        if (es.HansesHostelRegion == HansesHostelRegion.StoneEffect)
                        {
                            acc.SetTag("PStoneEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PStoneEffect", "no");
                        }
                        if (es.HansesHostelRegion == HansesHostelRegion.ShineyEffect)
                        {
                            acc.SetTag("PShineyEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PShineyEffect", "no");
                        }
                        if (es.HansesHostelRegion == HansesHostelRegion.FireFlyEffect)
                        {
                            acc.SetTag("PFireFlyEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PFireFlyEffect", "no");
                        }
                    }
                    else if (mp.Region.IsPartOf("Yomotsu Mines"))
                    {
                        if (es.YomotsuMinesRegion == YomotsuMinesRegion.DarkEffect)
                        {
                            acc.SetTag("PDarkEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PDarkEffect", "no");
                        }
                        if (es.YomotsuMinesRegion == YomotsuMinesRegion.FireEffect)
                        {
                            acc.SetTag("PFireEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PFireEffect", "no");
                        }
                        if (es.YomotsuMinesRegion == YomotsuMinesRegion.IceEffect)
                        {
                            acc.SetTag("PIceEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PIceEffect", "no");
                        }
                        if (es.YomotsuMinesRegion == YomotsuMinesRegion.ToxicEffect)
                        {
                            acc.SetTag("PToxicEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PToxicEffect", "no");
                        }
                        if (es.YomotsuMinesRegion == YomotsuMinesRegion.ElectEffect)
                        {
                            acc.SetTag("PElectEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PElectEffect", "no");
                        }
                        if (es.YomotsuMinesRegion == YomotsuMinesRegion.WaterEffect)
                        {
                            acc.SetTag("PWaterEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PWaterEffect", "no");
                        }
                        if (es.YomotsuMinesRegion == YomotsuMinesRegion.MistEffect)
                        {
                            acc.SetTag("PMistEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PMistEffect", "no");
                        }
                        if (es.YomotsuMinesRegion == YomotsuMinesRegion.ExplosionEffect)
                        {
                            acc.SetTag("PExplosionEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PExplosionEffect", "no");
                        }
                        if (es.YomotsuMinesRegion == YomotsuMinesRegion.StoneEffect)
                        {
                            acc.SetTag("PStoneEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PStoneEffect", "no");
                        }
                        if (es.YomotsuMinesRegion == YomotsuMinesRegion.ShineyEffect)
                        {
                            acc.SetTag("PShineyEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PShineyEffect", "no");
                        }
                        if (es.YomotsuMinesRegion == YomotsuMinesRegion.FireFlyEffect)
                        {
                            acc.SetTag("PFireFlyEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PFireFlyEffect", "no");
                        }
                    }
                    else if (mp.Region.IsPartOf("Fan Dancer's Dojo"))
                    {
                        if (es.FanDancerDojoRegion == FanDancerDojoRegion.DarkEffect)
                        {
                            acc.SetTag("PDarkEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PDarkEffect", "no");
                        }
                        if (es.FanDancerDojoRegion == FanDancerDojoRegion.FireEffect)
                        {
                            acc.SetTag("PFireEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PFireEffect", "no");
                        }
                        if (es.FanDancerDojoRegion == FanDancerDojoRegion.IceEffect)
                        {
                            acc.SetTag("PIceEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PIceEffect", "no");
                        }
                        if (es.FanDancerDojoRegion == FanDancerDojoRegion.ToxicEffect)
                        {
                            acc.SetTag("PToxicEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PToxicEffect", "no");
                        }
                        if (es.FanDancerDojoRegion == FanDancerDojoRegion.ElectEffect)
                        {
                            acc.SetTag("PElectEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PElectEffect", "no");
                        }
                        if (es.FanDancerDojoRegion == FanDancerDojoRegion.WaterEffect)
                        {
                            acc.SetTag("PWaterEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PWaterEffect", "no");
                        }
                        if (es.FanDancerDojoRegion == FanDancerDojoRegion.MistEffect)
                        {
                            acc.SetTag("PMistEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PMistEffect", "no");
                        }
                        if (es.FanDancerDojoRegion == FanDancerDojoRegion.ExplosionEffect)
                        {
                            acc.SetTag("PExplosionEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PExplosionEffect", "no");
                        }
                        if (es.FanDancerDojoRegion == FanDancerDojoRegion.StoneEffect)
                        {
                            acc.SetTag("PStoneEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PStoneEffect", "no");
                        }
                        if (es.FanDancerDojoRegion == FanDancerDojoRegion.ShineyEffect)
                        {
                            acc.SetTag("PShineyEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PShineyEffect", "no");
                        }
                        if (es.FanDancerDojoRegion == FanDancerDojoRegion.FireFlyEffect)
                        {
                            acc.SetTag("PFireFlyEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PFireFlyEffect", "no");
                        }
                    }
                    else if (mp.Region.IsPartOf("Zento"))
                    {
                        if (es.ZentoRegion == ZentoRegion.DarkEffect)
                        {
                            acc.SetTag("PDarkEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PDarkEffect", "no");
                        }
                        if (es.ZentoRegion == ZentoRegion.FireEffect)
                        {
                            acc.SetTag("PFireEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PFireEffect", "no");
                        }
                        if (es.ZentoRegion == ZentoRegion.IceEffect)
                        {
                            acc.SetTag("PIceEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PIceEffect", "no");
                        }
                        if (es.ZentoRegion == ZentoRegion.ToxicEffect)
                        {
                            acc.SetTag("PToxicEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PToxicEffect", "no");
                        }
                        if (es.ZentoRegion == ZentoRegion.ElectEffect)
                        {
                            acc.SetTag("PElectEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PElectEffect", "no");
                        }
                        if (es.ZentoRegion == ZentoRegion.WaterEffect)
                        {
                            acc.SetTag("PWaterEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PWaterEffect", "no");
                        }
                        if (es.ZentoRegion == ZentoRegion.MistEffect)
                        {
                            acc.SetTag("PMistEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PMistEffect", "no");
                        }
                        if (es.ZentoRegion == ZentoRegion.ExplosionEffect)
                        {
                            acc.SetTag("PExplosionEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PExplosionEffect", "no");
                        }
                        if (es.ZentoRegion == ZentoRegion.StoneEffect)
                        {
                            acc.SetTag("PStoneEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PStoneEffect", "no");
                        }
                        if (es.ZentoRegion == ZentoRegion.ShineyEffect)
                        {
                            acc.SetTag("PShineyEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PShineyEffect", "no");
                        }
                        if (es.ZentoRegion == ZentoRegion.FireFlyEffect)
                        {
                            acc.SetTag("PFireFlyEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PFireFlyEffect", "no");
                        }
                    }
                    else if (mp.Region.IsPartOf("Beetlescape"))
                    {
                        if (es.BeetlescapeRegion == BeetlescapeRegion.DarkEffect)
                        {
                            acc.SetTag("PDarkEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PDarkEffect", "no");
                        }
                        if (es.BeetlescapeRegion == BeetlescapeRegion.FireEffect)
                        {
                            acc.SetTag("PFireEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PFireEffect", "no");
                        }
                        if (es.BeetlescapeRegion == BeetlescapeRegion.IceEffect)
                        {
                            acc.SetTag("PIceEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PIceEffect", "no");
                        }
                        if (es.BeetlescapeRegion == BeetlescapeRegion.ToxicEffect)
                        {
                            acc.SetTag("PToxicEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PToxicEffect", "no");
                        }
                        if (es.BeetlescapeRegion == BeetlescapeRegion.ElectEffect)
                        {
                            acc.SetTag("PElectEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PElectEffect", "no");
                        }
                        if (es.BeetlescapeRegion == BeetlescapeRegion.WaterEffect)
                        {
                            acc.SetTag("PWaterEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PWaterEffect", "no");
                        }
                        if (es.BeetlescapeRegion == BeetlescapeRegion.MistEffect)
                        {
                            acc.SetTag("PMistEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PMistEffect", "no");
                        }
                        if (es.BeetlescapeRegion == BeetlescapeRegion.ExplosionEffect)
                        {
                            acc.SetTag("PExplosionEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PExplosionEffect", "no");
                        }
                        if (es.BeetlescapeRegion == BeetlescapeRegion.StoneEffect)
                        {
                            acc.SetTag("PStoneEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PStoneEffect", "no");
                        }
                        if (es.BeetlescapeRegion == BeetlescapeRegion.ShineyEffect)
                        {
                            acc.SetTag("PShineyEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PShineyEffect", "no");
                        }
                        if (es.BeetlescapeRegion == BeetlescapeRegion.FireFlyEffect)
                        {
                            acc.SetTag("PFireFlyEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PFireFlyEffect", "no");
                        }
                    }
                    else if (mp.Region.IsPartOf("Bushido Dojo"))
                    {
                        if (es.BushidoDojoRegion == BushidoDojoRegion.DarkEffect)
                        {
                            acc.SetTag("PDarkEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PDarkEffect", "no");
                        }
                        if (es.BushidoDojoRegion == BushidoDojoRegion.FireEffect)
                        {
                            acc.SetTag("PFireEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PFireEffect", "no");
                        }
                        if (es.BushidoDojoRegion == BushidoDojoRegion.IceEffect)
                        {
                            acc.SetTag("PIceEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PIceEffect", "no");
                        }
                        if (es.BushidoDojoRegion == BushidoDojoRegion.ToxicEffect)
                        {
                            acc.SetTag("PToxicEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PToxicEffect", "no");
                        }
                        if (es.BushidoDojoRegion == BushidoDojoRegion.ElectEffect)
                        {
                            acc.SetTag("PElectEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PElectEffect", "no");
                        }
                        if (es.BushidoDojoRegion == BushidoDojoRegion.WaterEffect)
                        {
                            acc.SetTag("PWaterEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PWaterEffect", "no");
                        }
                        if (es.BushidoDojoRegion == BushidoDojoRegion.MistEffect)
                        {
                            acc.SetTag("PMistEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PMistEffect", "no");
                        }
                        if (es.BushidoDojoRegion == BushidoDojoRegion.ExplosionEffect)
                        {
                            acc.SetTag("PExplosionEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PExplosionEffect", "no");
                        }
                        if (es.BushidoDojoRegion == BushidoDojoRegion.StoneEffect)
                        {
                            acc.SetTag("PStoneEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PStoneEffect", "no");
                        }
                        if (es.BushidoDojoRegion == BushidoDojoRegion.ShineyEffect)
                        {
                            acc.SetTag("PShineyEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PShineyEffect", "no");
                        }
                        if (es.BushidoDojoRegion == BushidoDojoRegion.FireFlyEffect)
                        {
                            acc.SetTag("PFireFlyEffect", "yes"); return;
                        }
                        else
                        {
                            acc.SetTag("PFireFlyEffect", "no");
                        }
                    }
                    else
                    {
                        acc.SetTag("PDarkEffect", "no");
                        acc.SetTag("PFireEffect", "no");
                        acc.SetTag("PIceEffect", "no");
                        acc.SetTag("PToxicEffect", "no");
                        acc.SetTag("PElectEffect", "no");
                        acc.SetTag("PWaterEffect", "no");
                        acc.SetTag("PMistEffect", "no");
                        acc.SetTag("PExplosionEffect", "no");
                        acc.SetTag("PStoneEffect", "no");
                        acc.SetTag("PShineyEffect", "no");
                        acc.SetTag("PFireFlyEffect", "no");
                    }
                }
            }
        }

		public static void DarkEffect( PlayerMobile from )
		{
			PlayerMobile mplayer = from as PlayerMobile;

			if ( Utility.RandomDouble() < 0.1 )
			{
				if ( mplayer.LightLevel >= 6 )
				{
					mplayer.LightLevel = 5;
					mplayer.SendMessage("You feel the darkness fill the air around you!!!");
					return;
				}
				return;
			}
		}

		public static void FireEffect( PlayerMobile from )
		{
			PlayerMobile mplayer = from as PlayerMobile;

			if ( Utility.RandomDouble() < 0.1 )
			{
				mplayer.Stam -= 5; 
				mplayer.FixedParticles( 0x3735, 1, 30, 9503, EffectLayer.Waist );
				Effects.SendLocationEffect(mplayer.Location, mplayer.Map,0x371C, 20); 
				mplayer.PlaySound( 855 );
				mplayer.SendMessage("You feel as if your skin is burning!!!");
				mplayer.PlaySound( mplayer.Female ? 814 : 1088 );
				mplayer.Say( "*ahhhh!*" );
				mplayer.Damage( ( ( Utility.Random( 5, 15 ) ) - ( mplayer.FireResistance /2 ) ) );
				return;
			}
		}
		public static void IceEffect( PlayerMobile from )
		{
			PlayerMobile mplayer = from as PlayerMobile;

			if ( Utility.RandomDouble() < 0.8 )
			{
				mplayer.Stam -= 5; 
				mplayer.FixedParticles( 0x37CC, 1, 40, 97, 3, 9917, EffectLayer.Waist );
           			mplayer.FixedParticles( 0x374A, 1, 15, 9502, 97, 3, (EffectLayer)255 );
				mplayer.PlaySound( 20 );
				mplayer.SendMessage("You feel as if your skin is freezing!!!");
				mplayer.PlaySound( mplayer.Female ? 811 : 1085 );
				mplayer.Say( "*oooh!*" );
				mplayer.Damage( ( ( Utility.Random( 3, 8 ) ) - ( mplayer.ColdResistance /2 ) ) );
				return;
			}
		}
		public static void ToxicEffect( PlayerMobile from )
		{
			PlayerMobile mplayer = from as PlayerMobile;

			if ( Utility.RandomDouble() < 0.8 )
			{
				mplayer.Stam -= 5; 
				mplayer.FixedParticles( 0x36CB, 1, 9, 9911, 67, 5, EffectLayer.Head );
				mplayer.FixedParticles( 0x374A, 1, 17, 9502, 1108, 4, (EffectLayer)255 );
				mplayer.PlaySound( 1140 );
				mplayer.SendMessage("You feel as if you've been poisoned!!!");
				mplayer.PlaySound( mplayer.Female ? 785 : 1056 );
				mplayer.Say( "*cough!*" );
				mplayer.Damage( ( ( Utility.Random( 3, 8 ) ) - ( mplayer.PoisonResistance /2 ) ) );
				return;
			}
		}
		public static void ElectEffect( PlayerMobile from )
		{
			PlayerMobile mplayer = from as PlayerMobile;

			if ( Utility.RandomDouble() < 0.8 )
			{
				mplayer.Stam -= 5; 
				mplayer.BoltEffect( 0 );
				mplayer.PlaySound( 41 );
				mplayer.SendMessage("You feel a jolt of electricity run down your spine!!!");
				mplayer.PlaySound( mplayer.Female ? 799 : 1071 );
				mplayer.Say( "*huh?*" );
				mplayer.Damage( ( ( Utility.Random( 3, 8 ) ) - ( mplayer.EnergyResistance /2 ) ) );
				return;
			}
		}
		public static void WaterEffect( PlayerMobile from )
		{
			PlayerMobile mplayer = from as PlayerMobile;

			if ( Utility.RandomDouble() < 0.8 )
			{
				mplayer.Stam -= 5;
				mplayer.PlaySound( 868 ); 
				mplayer.FixedParticles( 0x3709, 1, 30, 9965, 5, 7, EffectLayer.Waist );
           			mplayer.FixedParticles( 0x376A, 1, 30, 9502, 5, 3, EffectLayer.Waist );
				mplayer.SendMessage("You feel your lungs fill up with water, Can't Breathe!!!");
				mplayer.PlaySound( mplayer.Female ? 793 : 1065 );
				mplayer.Say( "*gasp!*" );
				mplayer.Damage( ( ( Utility.Random( 3, 8 ) ) - ( mplayer.PhysicalResistance /2 ) ) );
				return;
			}
		}
		public static void MistEffect( PlayerMobile from )
		{
			PlayerMobile mplayer = from as PlayerMobile;

 			if ( Utility.RandomDouble() < 0.8 )
			{
				mplayer.Stam -= 5; 
				mplayer.FixedParticles( 0x375A, 1, 17, 9919, 33, 7, EffectLayer.Waist );
           			mplayer.FixedParticles( 0x3728, 1, 13, 9502, 33, 7, (EffectLayer)255 );
				mplayer.PlaySound( 252 );
				mplayer.SendMessage("You feel a bloody mist fill your mouth, Your viens begin to burn!!!");
				mplayer.PlaySound( mplayer.Female ? 813 : 1087 );
				mplayer.Say( "*pukes*" );
				mplayer.Damage( ( ( Utility.Random( 3, 8 ) ) - ( mplayer.PoisonResistance /2 ) ) );
				return;
			}
		}
		public static void ExplosionEffect( PlayerMobile from )
		{
			PlayerMobile mplayer = from as PlayerMobile;

			if ( Utility.RandomDouble() < 0.8 )
			{
				mplayer.Stam -= 5; 
				mplayer.FixedParticles( 0x36BD, 20, 10, 5044, EffectLayer.Head );
				mplayer.PlaySound( 519 );
				mplayer.SendMessage("You feel yourself explode with intence heat!!!");
				mplayer.PlaySound( mplayer.Female ? 814 : 1088 );
				mplayer.Say( "*aaah!*" );
				mplayer.Damage( ( ( Utility.Random( 3, 8 ) ) - ( mplayer.FireResistance /2 ) ) );
				return;
			}
		}
		public static void StoneEffect( PlayerMobile from )
		{
			PlayerMobile mplayer = from as PlayerMobile;

			if ( Utility.RandomDouble() < 0.8 )
			{
				mplayer.Stam -= 5; 
				mplayer.FixedParticles(0x376A, 1, 31, 9961, 1160, 0, EffectLayer.Waist );
           			mplayer.FixedParticles( 0x37C4, 1, 31, 9502, 43, 2, EffectLayer.Waist );
				mplayer.PlaySound( 515 );
				mplayer.SendMessage("Your laughing so hard it hurts!!!");
				mplayer.PlaySound( mplayer.Female ? 794 : 1066 );
				mplayer.Say( "*giggles*" );
				mplayer.Damage( ( ( Utility.Random( 3, 8 ) ) - ( mplayer.PhysicalResistance /2 ) ) );
				return;
			}
		}
		public static void ShineyEffect( PlayerMobile from )
		{
			PlayerMobile mplayer = from as PlayerMobile;

			if ( Utility.RandomDouble() < 0.8 )
			{
				mplayer.Stam += ( Utility.Random( 3, 8 ) );
				mplayer.Hits += ( Utility.Random( 3, 8 ) ); 
				mplayer.FixedParticles( 0x375A, 1, 30, 9966, 33, 2, EffectLayer.Head ); 
           			mplayer.FixedParticles( 0x37B9, 1, 30, 9502, 43, 3, EffectLayer.Head );
				mplayer.PlaySound( 492 );
				mplayer.SendMessage("You feel rejuvinated!!!");
				mplayer.PlaySound( mplayer.Female ? 778 : 1049 );
				mplayer.Say( "*ah!*" );
				return;
			}
		}
		public static void FireFlyEffect( PlayerMobile from )
		{
			PlayerMobile mplayer = from as PlayerMobile;

			if ( Utility.RandomDouble() < 0.8 )
			{
				mplayer.Stam += ( Utility.Random( 3, 8 ) );
				mplayer.Hits += ( Utility.Random( 3, 8 ) ); 
				mplayer.FixedParticles(0x376A, 1, 31, 9961, 1160, 0, EffectLayer.Waist );
           			mplayer.FixedParticles( 0x37C4, 1, 31, 9502, 43, 2, EffectLayer.Waist );
				mplayer.PlaySound( 957 );
				mplayer.SendMessage("You feel rejuvinated!!!");
				mplayer.PlaySound( mplayer.Female ? 778 : 1049 );
				mplayer.Say( "*ah!*" );
				return;
			}
		}
	}
}