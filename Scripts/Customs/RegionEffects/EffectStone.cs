using System;
using Server;
using Server.Gumps;
using Server.Mobiles;
using System.Collections;
using Server.Items;
using Server.Network;
using Server.Commands;
 
namespace Server.Items
{
    public enum MoongateRegion
   {
       None,
       DarkEffect,
       FireEffect,
       IceEffect,
       ToxicEffect,
       ElectEffect,
       WaterEffect,
       MistEffect,
       ExplosionEffect,
       StoneEffect,
       ShineyEffect,
       FireFlyEffect
   }
    public enum CoveRegion
    {
        None,
        DarkEffect,
        FireEffect,
        IceEffect,
        ToxicEffect,
        ElectEffect,
        WaterEffect,
        MistEffect,
        ExplosionEffect,
        StoneEffect,
        ShineyEffect,
        FireFlyEffect
    }
    public enum BritainRegion
    {
        None,
        DarkEffect,
        FireEffect,
        IceEffect,
        ToxicEffect,
        ElectEffect,
        WaterEffect,
        MistEffect,
        ExplosionEffect,
        StoneEffect,
        ShineyEffect,
        FireFlyEffect
    }
    public enum BritainGRegion
    {
        None,
        DarkEffect,
        FireEffect,
        IceEffect,
        ToxicEffect,
        ElectEffect,
        WaterEffect,
        MistEffect,
        ExplosionEffect,
        StoneEffect,
        ShineyEffect,
        FireFlyEffect
    }
    public enum JhelomIsRegion
    {
        None,
        DarkEffect,
        FireEffect,
        IceEffect,
        ToxicEffect,
        ElectEffect,
        WaterEffect,
        MistEffect,
        ExplosionEffect,
        StoneEffect,
        ShineyEffect,
        FireFlyEffect
    }
    public enum JhelomRegion
    {
        None,
        DarkEffect,
        FireEffect,
        IceEffect,
        ToxicEffect,
        ElectEffect,
        WaterEffect,
        MistEffect,
        ExplosionEffect,
        StoneEffect,
        ShineyEffect,
        FireFlyEffect
    }
    public enum MinocRegion
    {
        None,
        DarkEffect,
        FireEffect,
        IceEffect,
        ToxicEffect,
        ElectEffect,
        WaterEffect,
        MistEffect,
        ExplosionEffect,
        StoneEffect,
        ShineyEffect,
        FireFlyEffect
    }
    public enum OclloRegion
    {
        None,
        DarkEffect,
        FireEffect,
        IceEffect,
        ToxicEffect,
        ElectEffect,
        WaterEffect,
        MistEffect,
        ExplosionEffect,
        StoneEffect,
        ShineyEffect,
        FireFlyEffect
    }
    public enum TrinsicRegion
   {
       None,
       DarkEffect,
       FireEffect,
       IceEffect,
       ToxicEffect,
       ElectEffect,
       WaterEffect,
       MistEffect,
       ExplosionEffect,
       StoneEffect,
       ShineyEffect,
       FireFlyEffect
   }
    public enum VesperRegion
    {
        None,
        DarkEffect,
        FireEffect,
        IceEffect,
        ToxicEffect,
        ElectEffect,
        WaterEffect,
        MistEffect,
        ExplosionEffect,
        StoneEffect,
        ShineyEffect,
        FireFlyEffect
    }
    public enum YewRegion
    {
        None,
        DarkEffect,
        FireEffect,
        IceEffect,
        ToxicEffect,
        ElectEffect,
        WaterEffect,
        MistEffect,
        ExplosionEffect,
        StoneEffect,
        ShineyEffect,
        FireFlyEffect
    }
    public enum WindRegion
    {
        None,
        DarkEffect,
        FireEffect,
        IceEffect,
        ToxicEffect,
        ElectEffect,
        WaterEffect,
        MistEffect,
        ExplosionEffect,
        StoneEffect,
        ShineyEffect,
        FireFlyEffect
    }
    public enum SerpHoldRegion
    {
        None,
        DarkEffect,
        FireEffect,
        IceEffect,
        ToxicEffect,
        ElectEffect,
        WaterEffect,
        MistEffect,
        ExplosionEffect,
        StoneEffect,
        ShineyEffect,
        FireFlyEffect
    }
    public enum SkaraBraeRegion
    {
        None,
        DarkEffect,
        FireEffect,
        IceEffect,
        ToxicEffect,
        ElectEffect,
        WaterEffect,
        MistEffect,
        ExplosionEffect,
        StoneEffect,
        ShineyEffect,
        FireFlyEffect
    }
    public enum NujelmRegion
    {
        None,
        DarkEffect,
        FireEffect,
        IceEffect,
        ToxicEffect,
        ElectEffect,
        WaterEffect,
        MistEffect,
        ExplosionEffect,
        StoneEffect,
        ShineyEffect,
        FireFlyEffect
    }
    public enum MoonglowRegion
    {
        None,
        DarkEffect,
        FireEffect,
        IceEffect,
        ToxicEffect,
        ElectEffect,
        WaterEffect,
        MistEffect,
        ExplosionEffect,
        StoneEffect,
        ShineyEffect,
        FireFlyEffect
    }
    public enum MaginciaRegion
   {
       None,
       DarkEffect,
       FireEffect,
       IceEffect,
       ToxicEffect,
       ElectEffect,
       WaterEffect,
       MistEffect,
       ExplosionEffect,
       StoneEffect,
       ShineyEffect,
       FireFlyEffect
   }
    public enum BucsDenRegion
    {
        None,
        DarkEffect,
        FireEffect,
        IceEffect,
        ToxicEffect,
        ElectEffect,
        WaterEffect,
        MistEffect,
        ExplosionEffect,
        StoneEffect,
        ShineyEffect,
        FireFlyEffect
    }
    public enum CovetousRegion
    {
        None,
        DarkEffect,
        FireEffect,
        IceEffect,
        ToxicEffect,
        ElectEffect,
        WaterEffect,
        MistEffect,
        ExplosionEffect,
        StoneEffect,
        ShineyEffect,
        FireFlyEffect
    }
    public enum DeceitRegion
    {
        None,
        DarkEffect,
        FireEffect,
        IceEffect,
        ToxicEffect,
        ElectEffect,
        WaterEffect,
        MistEffect,
        ExplosionEffect,
        StoneEffect,
        ShineyEffect,
        FireFlyEffect
    }
    public enum DespiseRegion
    {
        None,
        DarkEffect,
        FireEffect,
        IceEffect,
        ToxicEffect,
        ElectEffect,
        WaterEffect,
        MistEffect,
        ExplosionEffect,
        StoneEffect,
        ShineyEffect,
        FireFlyEffect
    }
    public enum DestardRegion
    {
        None,
        DarkEffect,
        FireEffect,
        IceEffect,
        ToxicEffect,
        ElectEffect,
        WaterEffect,
        MistEffect,
        ExplosionEffect,
        StoneEffect,
        ShineyEffect,
        FireFlyEffect
    }
    public enum HythlothRegion
    {
        None,
        DarkEffect,
        FireEffect,
        IceEffect,
        ToxicEffect,
        ElectEffect,
        WaterEffect,
        MistEffect,
        ExplosionEffect,
        StoneEffect,
        ShineyEffect,
        FireFlyEffect
    }
    public enum KhaldunRegion
    {
        None,
        DarkEffect,
        FireEffect,
        IceEffect,
        ToxicEffect,
        ElectEffect,
        WaterEffect,
        MistEffect,
        ExplosionEffect,
        StoneEffect,
        ShineyEffect,
        FireFlyEffect
    }
    public enum ShameRegion
   {
       None,
       DarkEffect,
       FireEffect,
       IceEffect,
       ToxicEffect,
       ElectEffect,
       WaterEffect,
       MistEffect,
       ExplosionEffect,
       StoneEffect,
       ShineyEffect,
       FireFlyEffect
   }
    public enum WrongRegion
    {
        None,
        DarkEffect,
        FireEffect,
        IceEffect,
        ToxicEffect,
        ElectEffect,
        WaterEffect,
        MistEffect,
        ExplosionEffect,
        StoneEffect,
        ShineyEffect,
        FireFlyEffect
    }
    public enum Cave1Region
    {
        None,
        DarkEffect,
        FireEffect,
        IceEffect,
        ToxicEffect,
        ElectEffect,
        WaterEffect,
        MistEffect,
        ExplosionEffect,
        StoneEffect,
        ShineyEffect,
        FireFlyEffect
    }
    public enum Cave2Region
    {
        None,
        DarkEffect,
        FireEffect,
        IceEffect,
        ToxicEffect,
        ElectEffect,
        WaterEffect,
        MistEffect,
        ExplosionEffect,
        StoneEffect,
        ShineyEffect,
        FireFlyEffect
    }
    public enum Cave3Region
    {
        None,
        DarkEffect,
        FireEffect,
        IceEffect,
        ToxicEffect,
        ElectEffect,
        WaterEffect,
        MistEffect,
        ExplosionEffect,
        StoneEffect,
        ShineyEffect,
        FireFlyEffect
    }
    public enum Cave4Region
    {
        None,
        DarkEffect,
        FireEffect,
        IceEffect,
        ToxicEffect,
        ElectEffect,
        WaterEffect,
        MistEffect,
        ExplosionEffect,
        StoneEffect,
        ShineyEffect,
        FireFlyEffect
    }
    public enum BritMine1Region
    {
        None,
        DarkEffect,
        FireEffect,
        IceEffect,
        ToxicEffect,
        ElectEffect,
        WaterEffect,
        MistEffect,
        ExplosionEffect,
        StoneEffect,
        ShineyEffect,
        FireFlyEffect
    }
    public enum BritMine2Region
    {
        None,
        DarkEffect,
        FireEffect,
        IceEffect,
        ToxicEffect,
        ElectEffect,
        WaterEffect,
        MistEffect,
        ExplosionEffect,
        StoneEffect,
        ShineyEffect,
        FireFlyEffect
    }
    public enum MinocCave1Region
    {
        None,
        DarkEffect,
        FireEffect,
        IceEffect,
        ToxicEffect,
        ElectEffect,
        WaterEffect,
        MistEffect,
        ExplosionEffect,
        StoneEffect,
        ShineyEffect,
        FireFlyEffect
    }
    public enum MinocCave2Region
    {
        None,
        DarkEffect,
        FireEffect,
        IceEffect,
        ToxicEffect,
        ElectEffect,
        WaterEffect,
        MistEffect,
        ExplosionEffect,
        StoneEffect,
        ShineyEffect,
        FireFlyEffect
    }
    public enum MinocCave3Region
    {
        None,
        DarkEffect,
        FireEffect,
        IceEffect,
        ToxicEffect,
        ElectEffect,
        WaterEffect,
        MistEffect,
        ExplosionEffect,
        StoneEffect,
        ShineyEffect,
        FireFlyEffect
    }
    public enum MinocCaveRegion
    {
        None,
        DarkEffect,
        FireEffect,
        IceEffect,
        ToxicEffect,
        ElectEffect,
        WaterEffect,
        MistEffect,
        ExplosionEffect,
        StoneEffect,
        ShineyEffect,
        FireFlyEffect
    }
    public enum AvatarIsleCaveRegion
    {
        None,
        DarkEffect,
        FireEffect,
        IceEffect,
        ToxicEffect,
        ElectEffect,
        WaterEffect,
        MistEffect,
        ExplosionEffect,
        StoneEffect,
        ShineyEffect,
        FireFlyEffect
    }
    public enum IceIsleCave1Region
    {
        None,
        DarkEffect,
        FireEffect,
        IceEffect,
        ToxicEffect,
        ElectEffect,
        WaterEffect,
        MistEffect,
        ExplosionEffect,
        StoneEffect,
        ShineyEffect,
        FireFlyEffect
    }
    public enum IceIsleCave2Region
    {
        None,
        DarkEffect,
        FireEffect,
        IceEffect,
        ToxicEffect,
        ElectEffect,
        WaterEffect,
        MistEffect,
        ExplosionEffect,
        StoneEffect,
        ShineyEffect,
        FireFlyEffect
    }
    public enum NorthTerritoryCaveRegion
    {
        None,
        DarkEffect,
        FireEffect,
        IceEffect,
        ToxicEffect,
        ElectEffect,
        WaterEffect,
        MistEffect,
        ExplosionEffect,
        StoneEffect,
        ShineyEffect,
        FireFlyEffect
    }
    public enum YewCaveRegion
    {
        None,
        DarkEffect,
        FireEffect,
        IceEffect,
        ToxicEffect,
        ElectEffect,
        WaterEffect,
        MistEffect,
        ExplosionEffect,
        StoneEffect,
        ShineyEffect,
        FireFlyEffect
    }
    public enum NorthTerritoryMine1Region
    {
        None,
        DarkEffect,
        FireEffect,
        IceEffect,
        ToxicEffect,
        ElectEffect,
        WaterEffect,
        MistEffect,
        ExplosionEffect,
        StoneEffect,
        ShineyEffect,
        FireFlyEffect
    }
    public enum NorthTerritoryMine2Region
    {
        None,
        DarkEffect,
        FireEffect,
        IceEffect,
        ToxicEffect,
        ElectEffect,
        WaterEffect,
        MistEffect,
        ExplosionEffect,
        StoneEffect,
        ShineyEffect,
        FireFlyEffect
    }
    public enum MtKendallRegion
    {
        None,
        DarkEffect,
        FireEffect,
        IceEffect,
        ToxicEffect,
        ElectEffect,
        WaterEffect,
        MistEffect,
        ExplosionEffect,
        StoneEffect,
        ShineyEffect,
        FireFlyEffect
    }
    public enum CovetousMineRegion
    {
        None,
        DarkEffect,
        FireEffect,
        IceEffect,
        ToxicEffect,
        ElectEffect,
        WaterEffect,
        MistEffect,
        ExplosionEffect,
        StoneEffect,
        ShineyEffect,
        FireFlyEffect
    }
    public enum TerathanKeepRegion
    {
        None,
        DarkEffect,
        FireEffect,
        IceEffect,
        ToxicEffect,
        ElectEffect,
        WaterEffect,
        MistEffect,
        ExplosionEffect,
        StoneEffect,
        ShineyEffect,
        FireFlyEffect
    }
    public enum FireRegion
    {
        None,
        DarkEffect,
        FireEffect,
        IceEffect,
        ToxicEffect,
        ElectEffect,
        WaterEffect,
        MistEffect,
        ExplosionEffect,
        StoneEffect,
        ShineyEffect,
        FireFlyEffect
    }
    public enum IceRegion
    {
        None,
        DarkEffect,
        FireEffect,
        IceEffect,
        ToxicEffect,
        ElectEffect,
        WaterEffect,
        MistEffect,
        ExplosionEffect,
        StoneEffect,
        ShineyEffect,
        FireFlyEffect
    }
    public enum DeluciaRegion
    {
        None,
        DarkEffect,
        FireEffect,
        IceEffect,
        ToxicEffect,
        ElectEffect,
        WaterEffect,
        MistEffect,
        ExplosionEffect,
        StoneEffect,
        ShineyEffect,
        FireFlyEffect
    }
    public enum PapuaRegion
    {
        None,
        DarkEffect,
        FireEffect,
        IceEffect,
        ToxicEffect,
        ElectEffect,
        WaterEffect,
        MistEffect,
        ExplosionEffect,
        StoneEffect,
        ShineyEffect,
        FireFlyEffect
    }
    public enum CovetousEntRegion
    {
        None,
        DarkEffect,
        FireEffect,
        IceEffect,
        ToxicEffect,
        ElectEffect,
        WaterEffect,
        MistEffect,
        ExplosionEffect,
        StoneEffect,
        ShineyEffect,
        FireFlyEffect
    }
    public enum WrongEntrRegion
    {
        None,
        DarkEffect,
        FireEffect,
        IceEffect,
        ToxicEffect,
        ElectEffect,
        WaterEffect,
        MistEffect,
        ExplosionEffect,
        StoneEffect,
        ShineyEffect,
        FireFlyEffect
    }
    public enum DespiseEntRegion
    {
        None,
        DarkEffect,
        FireEffect,
        IceEffect,
        ToxicEffect,
        ElectEffect,
        WaterEffect,
        MistEffect,
        ExplosionEffect,
        StoneEffect,
        ShineyEffect,
        FireFlyEffect
    }
    public enum DespisePassRegion
    {
        None,
        DarkEffect,
        FireEffect,
        IceEffect,
        ToxicEffect,
        ElectEffect,
        WaterEffect,
        MistEffect,
        ExplosionEffect,
        StoneEffect,
        ShineyEffect,
        FireFlyEffect
    }
    public enum NthTerrMine1Region
    {
        None,
        DarkEffect,
        FireEffect,
        IceEffect,
        ToxicEffect,
        ElectEffect,
        WaterEffect,
        MistEffect,
        ExplosionEffect,
        StoneEffect,
        ShineyEffect,
        FireFlyEffect
    }
    public enum MiscDungRegion
    {
        None,
        DarkEffect,
        FireEffect,
        IceEffect,
        ToxicEffect,
        ElectEffect,
        WaterEffect,
        MistEffect,
        ExplosionEffect,
        StoneEffect,
        ShineyEffect,
        FireFlyEffect
    }
    public enum OrcCaveRegion
    {
        None,
        DarkEffect,
        FireEffect,
        IceEffect,
        ToxicEffect,
        ElectEffect,
        WaterEffect,
        MistEffect,
        ExplosionEffect,
        StoneEffect,
        ShineyEffect,
        FireFlyEffect
    }
    public enum HavenIsleRegion
    {
        None,
        DarkEffect,
        FireEffect,
        IceEffect,
        ToxicEffect,
        ElectEffect,
        WaterEffect,
        MistEffect,
        ExplosionEffect,
        StoneEffect,
        ShineyEffect,
        FireFlyEffect
    }
    public enum ShrineofValorRegion
    {
        None,
        DarkEffect,
        FireEffect,
        IceEffect,
        ToxicEffect,
        ElectEffect,
        WaterEffect,
        MistEffect,
        ExplosionEffect,
        StoneEffect,
        ShineyEffect,
        FireFlyEffect
    }
    public enum ChaosShrineRegion
    {
        None,
        DarkEffect,
        FireEffect,
        IceEffect,
        ToxicEffect,
        ElectEffect,
        WaterEffect,
        MistEffect,
        ExplosionEffect,
        StoneEffect,
        ShineyEffect,
        FireFlyEffect
    }
    public enum ShrineofSacrificeRegion
    {
        None,
        DarkEffect,
        FireEffect,
        IceEffect,
        ToxicEffect,
        ElectEffect,
        WaterEffect,
        MistEffect,
        ExplosionEffect,
        StoneEffect,
        ShineyEffect,
        FireFlyEffect
    }
    public enum ShrineofHonestyRegion
    {
        None,
        DarkEffect,
        FireEffect,
        IceEffect,
        ToxicEffect,
        ElectEffect,
        WaterEffect,
        MistEffect,
        ExplosionEffect,
        StoneEffect,
        ShineyEffect,
        FireFlyEffect
    }
    public enum ShrineofCompassionRegion
    {
        None,
        DarkEffect,
        FireEffect,
        IceEffect,
        ToxicEffect,
        ElectEffect,
        WaterEffect,
        MistEffect,
        ExplosionEffect,
        StoneEffect,
        ShineyEffect,
        FireFlyEffect
    }
    public enum ShrineofSpiritualityRegion
    {
        None,
        DarkEffect,
        FireEffect,
        IceEffect,
        ToxicEffect,
        ElectEffect,
        WaterEffect,
        MistEffect,
        ExplosionEffect,
        StoneEffect,
        ShineyEffect,
        FireFlyEffect
    }
    public enum HumilityRegion
    {
        None,
        DarkEffect,
        FireEffect,
        IceEffect,
        ToxicEffect,
        ElectEffect,
        WaterEffect,
        MistEffect,
        ExplosionEffect,
        StoneEffect,
        ShineyEffect,
        FireFlyEffect
    }
    public enum HonorRegion
    {
        None,
        DarkEffect,
        FireEffect,
        IceEffect,
        ToxicEffect,
        ElectEffect,
        WaterEffect,
        MistEffect,
        ExplosionEffect,
        StoneEffect,
        ShineyEffect,
        FireFlyEffect
    }
    public enum TerortSkitasRegion
    {
        None,
        DarkEffect,
        FireEffect,
        IceEffect,
        ToxicEffect,
        ElectEffect,
        WaterEffect,
        MistEffect,
        ExplosionEffect,
        StoneEffect,
        ShineyEffect,
        FireFlyEffect
    }
    public enum GargoyleCityRegion
    {
        None,
        DarkEffect,
        FireEffect,
        IceEffect,
        ToxicEffect,
        ElectEffect,
        WaterEffect,
        MistEffect,
        ExplosionEffect,
        StoneEffect,
        ShineyEffect,
        FireFlyEffect
    }
    public enum PormirHarmRegion
    {
        None,
        DarkEffect,
        FireEffect,
        IceEffect,
        ToxicEffect,
        ElectEffect,
        WaterEffect,
        MistEffect,
        ExplosionEffect,
        StoneEffect,
        ShineyEffect,
        FireFlyEffect
    }
    public enum PormirFelwisRegion
    {
        None,
        DarkEffect,
        FireEffect,
        IceEffect,
        ToxicEffect,
        ElectEffect,
        WaterEffect,
        MistEffect,
        ExplosionEffect,
        StoneEffect,
        ShineyEffect,
        FireFlyEffect
    }
    public enum CyclopsTempleRegion
    {
        None,
        DarkEffect,
        FireEffect,
        IceEffect,
        ToxicEffect,
        ElectEffect,
        WaterEffect,
        MistEffect,
        ExplosionEffect,
        StoneEffect,
        ShineyEffect,
        FireFlyEffect
    }
    public enum RatFortRegion
    {
        None,
        DarkEffect,
        FireEffect,
        IceEffect,
        ToxicEffect,
        ElectEffect,
        WaterEffect,
        MistEffect,
        ExplosionEffect,
        StoneEffect,
        ShineyEffect,
        FireFlyEffect
    }
    public enum RatFortCellarRegion
    {
        None,
        DarkEffect,
        FireEffect,
        IceEffect,
        ToxicEffect,
        ElectEffect,
        WaterEffect,
        MistEffect,
        ExplosionEffect,
        StoneEffect,
        ShineyEffect,
        FireFlyEffect
    }
    public enum EntCentIlsh1Region
    {
        None,
        DarkEffect,
        FireEffect,
        IceEffect,
        ToxicEffect,
        ElectEffect,
        WaterEffect,
        MistEffect,
        ExplosionEffect,
        StoneEffect,
        ShineyEffect,
        FireFlyEffect
    }
    public enum EntCentIlsh2Region
    {
        None,
        DarkEffect,
        FireEffect,
        IceEffect,
        ToxicEffect,
        ElectEffect,
        WaterEffect,
        MistEffect,
        ExplosionEffect,
        StoneEffect,
        ShineyEffect,
        FireFlyEffect
    }
    public enum MontorRegion
    {
        None,
        DarkEffect,
        FireEffect,
        IceEffect,
        ToxicEffect,
        ElectEffect,
        WaterEffect,
        MistEffect,
        ExplosionEffect,
        StoneEffect,
        ShineyEffect,
        FireFlyEffect
    }
    public enum TermirFlamRegion
    {
        None,
        DarkEffect,
        FireEffect,
        IceEffect,
        ToxicEffect,
        ElectEffect,
        WaterEffect,
        MistEffect,
        ExplosionEffect,
        StoneEffect,
        ShineyEffect,
        FireFlyEffect
    }
    public enum AncientCitadelRegion
    {
        None,
        DarkEffect,
        FireEffect,
        IceEffect,
        ToxicEffect,
        ElectEffect,
        WaterEffect,
        MistEffect,
        ExplosionEffect,
        StoneEffect,
        ShineyEffect,
        FireFlyEffect
    }
    public enum AlexandrettasBowlRegion
    {
        None,
        DarkEffect,
        FireEffect,
        IceEffect,
        ToxicEffect,
        ElectEffect,
        WaterEffect,
        MistEffect,
        ExplosionEffect,
        StoneEffect,
        ShineyEffect,
        FireFlyEffect
    }
    public enum EntRockDungRegion
    {
        None,
        DarkEffect,
        FireEffect,
        IceEffect,
        ToxicEffect,
        ElectEffect,
        WaterEffect,
        MistEffect,
        ExplosionEffect,
        StoneEffect,
        ShineyEffect,
        FireFlyEffect
    }
    public enum RockDungRegion
    {
        None,
        DarkEffect,
        FireEffect,
        IceEffect,
        ToxicEffect,
        ElectEffect,
        WaterEffect,
        MistEffect,
        ExplosionEffect,
        StoneEffect,
        ShineyEffect,
        FireFlyEffect
    }
    public enum LenmirAnfinmotasRegion
    {
        None,
        DarkEffect,
        FireEffect,
        IceEffect,
        ToxicEffect,
        ElectEffect,
        WaterEffect,
        MistEffect,
        ExplosionEffect,
        StoneEffect,
        ShineyEffect,
        FireFlyEffect
    }
    public enum EntSpiderCaveRegion
    {
        None,
        DarkEffect,
        FireEffect,
        IceEffect,
        ToxicEffect,
        ElectEffect,
        WaterEffect,
        MistEffect,
        ExplosionEffect,
        StoneEffect,
        ShineyEffect,
        FireFlyEffect
    }
    public enum SpiderCaveRegion
    {
        None,
        DarkEffect,
        FireEffect,
        IceEffect,
        ToxicEffect,
        ElectEffect,
        WaterEffect,
        MistEffect,
        ExplosionEffect,
        StoneEffect,
        ShineyEffect,
        FireFlyEffect
    }
    public enum TwinOaksRegion
    {
        None,
        DarkEffect,
        FireEffect,
        IceEffect,
        ToxicEffect,
        ElectEffect,
        WaterEffect,
        MistEffect,
        ExplosionEffect,
        StoneEffect,
        ShineyEffect,
        FireFlyEffect
    }
    public enum RegVolonRegion
    {
        None,
        DarkEffect,
        FireEffect,
        IceEffect,
        ToxicEffect,
        ElectEffect,
        WaterEffect,
        MistEffect,
        ExplosionEffect,
        StoneEffect,
        ShineyEffect,
        FireFlyEffect
    }
    public enum EntSpectreDungRegion
    {
        None,
        DarkEffect,
        FireEffect,
        IceEffect,
        ToxicEffect,
        ElectEffect,
        WaterEffect,
        MistEffect,
        ExplosionEffect,
        StoneEffect,
        ShineyEffect,
        FireFlyEffect
    }
    public enum SpectreDungRegion
    {
        None,
        DarkEffect,
        FireEffect,
        IceEffect,
        ToxicEffect,
        ElectEffect,
        WaterEffect,
        MistEffect,
        ExplosionEffect,
        StoneEffect,
        ShineyEffect,
        FireFlyEffect
    }
    public enum EntBloodDungRegion
    {
        None,
        DarkEffect,
        FireEffect,
        IceEffect,
        ToxicEffect,
        ElectEffect,
        WaterEffect,
        MistEffect,
        ExplosionEffect,
        StoneEffect,
        ShineyEffect,
        FireFlyEffect
    }
    public enum BloodDungRegion
    {
        None,
        DarkEffect,
        FireEffect,
        IceEffect,
        ToxicEffect,
        ElectEffect,
        WaterEffect,
        MistEffect,
        ExplosionEffect,
        StoneEffect,
        ShineyEffect,
        FireFlyEffect
    }
    public enum EntMushroomCaveRegion
    {
        None,
        DarkEffect,
        FireEffect,
        IceEffect,
        ToxicEffect,
        ElectEffect,
        WaterEffect,
        MistEffect,
        ExplosionEffect,
        StoneEffect,
        ShineyEffect,
        FireFlyEffect
    }
    public enum MushroomCaveRegion
    {
        None,
        DarkEffect,
        FireEffect,
        IceEffect,
        ToxicEffect,
        ElectEffect,
        WaterEffect,
        MistEffect,
        ExplosionEffect,
        StoneEffect,
        ShineyEffect,
        FireFlyEffect
    }
    public enum LakeShireRegion
    {
        None,
        DarkEffect,
        FireEffect,
        IceEffect,
        ToxicEffect,
        ElectEffect,
        WaterEffect,
        MistEffect,
        ExplosionEffect,
        StoneEffect,
        ShineyEffect,
        FireFlyEffect
    }
    public enum EntRatCaveRegion
    {
        None,
        DarkEffect,
        FireEffect,
        IceEffect,
        ToxicEffect,
        ElectEffect,
        WaterEffect,
        MistEffect,
        ExplosionEffect,
        StoneEffect,
        ShineyEffect,
        FireFlyEffect
    }
    public enum RatCaveTerritoryRegion
    {
        None,
        DarkEffect,
        FireEffect,
        IceEffect,
        ToxicEffect,
        ElectEffect,
        WaterEffect,
        MistEffect,
        ExplosionEffect,
        StoneEffect,
        ShineyEffect,
        FireFlyEffect
    }
    public enum RatManCaveRegion
    {
        None,
        DarkEffect,
        FireEffect,
        IceEffect,
        ToxicEffect,
        ElectEffect,
        WaterEffect,
        MistEffect,
        ExplosionEffect,
        StoneEffect,
        ShineyEffect,
        FireFlyEffect
    }
    public enum BetLemRegRegion
    {
        None,
        DarkEffect,
        FireEffect,
        IceEffect,
        ToxicEffect,
        ElectEffect,
        WaterEffect,
        MistEffect,
        ExplosionEffect,
        StoneEffect,
        ShineyEffect,
        FireFlyEffect
    }
    public enum MistasRegion
    {
        None,
        DarkEffect,
        FireEffect,
        IceEffect,
        ToxicEffect,
        ElectEffect,
        WaterEffect,
        MistEffect,
        ExplosionEffect,
        StoneEffect,
        ShineyEffect,
        FireFlyEffect
    }
    public enum SerpentinePassageRegion
    {
        None,
        DarkEffect,
        FireEffect,
        IceEffect,
        ToxicEffect,
        ElectEffect,
        WaterEffect,
        MistEffect,
        ExplosionEffect,
        StoneEffect,
        ShineyEffect,
        FireFlyEffect
    }
    public enum AnkhDungeonRegion
    {
        None,
        DarkEffect,
        FireEffect,
        IceEffect,
        ToxicEffect,
        ElectEffect,
        WaterEffect,
        MistEffect,
        ExplosionEffect,
        StoneEffect,
        ShineyEffect,
        FireFlyEffect
    }
    public enum KirinPassageRegion
    {
        None,
        DarkEffect,
        FireEffect,
        IceEffect,
        ToxicEffect,
        ElectEffect,
        WaterEffect,
        MistEffect,
        ExplosionEffect,
        StoneEffect,
        ShineyEffect,
        FireFlyEffect
    }
    public enum EntLizardsPassageRegion
    {
        None,
        DarkEffect,
        FireEffect,
        IceEffect,
        ToxicEffect,
        ElectEffect,
        WaterEffect,
        MistEffect,
        ExplosionEffect,
        StoneEffect,
        ShineyEffect,
        FireFlyEffect
    }
    public enum WispDungeonRegion
    {
        None,
        DarkEffect,
        FireEffect,
        IceEffect,
        ToxicEffect,
        ElectEffect,
        WaterEffect,
        MistEffect,
        ExplosionEffect,
        StoneEffect,
        ShineyEffect,
        FireFlyEffect
    }
    public enum LizardPassageRegion
    {
        None,
        DarkEffect,
        FireEffect,
        IceEffect,
        ToxicEffect,
        ElectEffect,
        WaterEffect,
        MistEffect,
        ExplosionEffect,
        StoneEffect,
        ShineyEffect,
        FireFlyEffect
    }
    public enum ExodusDungeonRegion
    {
        None,
        DarkEffect,
        FireEffect,
        IceEffect,
        ToxicEffect,
        ElectEffect,
        WaterEffect,
        MistEffect,
        ExplosionEffect,
        StoneEffect,
        ShineyEffect,
        FireFlyEffect
    }
    public enum LizardManHutsRegion
    {
        None,
        DarkEffect,
        FireEffect,
        IceEffect,
        ToxicEffect,
        ElectEffect,
        WaterEffect,
        MistEffect,
        ExplosionEffect,
        StoneEffect,
        ShineyEffect,
        FireFlyEffect
    }
    public enum NoxTeregRegion
    {
        None,
        DarkEffect,
        FireEffect,
        IceEffect,
        ToxicEffect,
        ElectEffect,
        WaterEffect,
        MistEffect,
        ExplosionEffect,
        StoneEffect,
        ShineyEffect,
        FireFlyEffect
    }
    public enum SorcerersDungeonRegion
    {
        None,
        DarkEffect,
        FireEffect,
        IceEffect,
        ToxicEffect,
        ElectEffect,
        WaterEffect,
        MistEffect,
        ExplosionEffect,
        StoneEffect,
        ShineyEffect,
        FireFlyEffect
    }
    public enum EntAncientLairRegion
    {
        None,
        DarkEffect,
        FireEffect,
        IceEffect,
        ToxicEffect,
        ElectEffect,
        WaterEffect,
        MistEffect,
        ExplosionEffect,
        StoneEffect,
        ShineyEffect,
        FireFlyEffect
    }
    public enum AncientLairRegion
    {
        None,
        DarkEffect,
        FireEffect,
        IceEffect,
        ToxicEffect,
        ElectEffect,
        WaterEffect,
        MistEffect,
        ExplosionEffect,
        StoneEffect,
        ShineyEffect,
        FireFlyEffect
    }
    public enum GypsyCampRegion
    {
        None,
        DarkEffect,
        FireEffect,
        IceEffect,
        ToxicEffect,
        ElectEffect,
        WaterEffect,
        MistEffect,
        ExplosionEffect,
        StoneEffect,
        ShineyEffect,
        FireFlyEffect
    }
    public enum GypsyCamp1Region
    {
        None,
        DarkEffect,
        FireEffect,
        IceEffect,
        ToxicEffect,
        ElectEffect,
        WaterEffect,
        MistEffect,
        ExplosionEffect,
        StoneEffect,
        ShineyEffect,
        FireFlyEffect
    }
    public enum GypsyCamp2Region
    {
        None,
        DarkEffect,
        FireEffect,
        IceEffect,
        ToxicEffect,
        ElectEffect,
        WaterEffect,
        MistEffect,
        ExplosionEffect,
        StoneEffect,
        ShineyEffect,
        FireFlyEffect
    }
    public enum JukaCampRegion
    {
        None,
        DarkEffect,
        FireEffect,
        IceEffect,
        ToxicEffect,
        ElectEffect,
        WaterEffect,
        MistEffect,
        ExplosionEffect,
        StoneEffect,
        ShineyEffect,
        FireFlyEffect
    }
    public enum GypsyCamp3Region
    {
        None,
        DarkEffect,
        FireEffect,
        IceEffect,
        ToxicEffect,
        ElectEffect,
        WaterEffect,
        MistEffect,
        ExplosionEffect,
        StoneEffect,
        ShineyEffect,
        FireFlyEffect
    }
    public enum GypsyCamp4Region
    {
        None,
        DarkEffect,
        FireEffect,
        IceEffect,
        ToxicEffect,
        ElectEffect,
        WaterEffect,
        MistEffect,
        ExplosionEffect,
        StoneEffect,
        ShineyEffect,
        FireFlyEffect
    }
    public enum GypsyCamp5Region
    {
        None,
        DarkEffect,
        FireEffect,
        IceEffect,
        ToxicEffect,
        ElectEffect,
        WaterEffect,
        MistEffect,
        ExplosionEffect,
        StoneEffect,
        ShineyEffect,
        FireFlyEffect
    }
    public enum GypsyCamp6Region
    {
        None,
        DarkEffect,
        FireEffect,
        IceEffect,
        ToxicEffect,
        ElectEffect,
        WaterEffect,
        MistEffect,
        ExplosionEffect,
        StoneEffect,
        ShineyEffect,
        FireFlyEffect
    }
    public enum BlackthornsIlshCastleRegion
    {
        None,
        DarkEffect,
        FireEffect,
        IceEffect,
        ToxicEffect,
        ElectEffect,
        WaterEffect,
        MistEffect,
        ExplosionEffect,
        StoneEffect,
        ShineyEffect,
        FireFlyEffect
    }
    public enum ShrineofVirtuesRegion
    {
        None,
        DarkEffect,
        FireEffect,
        IceEffect,
        ToxicEffect,
        ElectEffect,
        WaterEffect,
        MistEffect,
        ExplosionEffect,
        StoneEffect,
        ShineyEffect,
        FireFlyEffect
    }
    public enum PassofKarnaughRegion
    {
        None,
        DarkEffect,
        FireEffect,
        IceEffect,
        ToxicEffect,
        ElectEffect,
        WaterEffect,
        MistEffect,
        ExplosionEffect,
        StoneEffect,
        ShineyEffect,
        FireFlyEffect
    }
    public enum VinculumInnRegion
    {
        None,
        DarkEffect,
        FireEffect,
        IceEffect,
        ToxicEffect,
        ElectEffect,
        WaterEffect,
        MistEffect,
        ExplosionEffect,
        StoneEffect,
        ShineyEffect,
        FireFlyEffect
    }
    public enum LunaRegion
    {
        None,
        DarkEffect,
        FireEffect,
        IceEffect,
        ToxicEffect,
        ElectEffect,
        WaterEffect,
        MistEffect,
        ExplosionEffect,
        StoneEffect,
        ShineyEffect,
        FireFlyEffect
    }
    public enum UmbraRegion
    {
        None,
        DarkEffect,
        FireEffect,
        IceEffect,
        ToxicEffect,
        ElectEffect,
        WaterEffect,
        MistEffect,
        ExplosionEffect,
        StoneEffect,
        ShineyEffect,
        FireFlyEffect
    }
    public enum DoomRegion
    {
        None,
        DarkEffect,
        FireEffect,
        IceEffect,
        ToxicEffect,
        ElectEffect,
        WaterEffect,
        MistEffect,
        ExplosionEffect,
        StoneEffect,
        ShineyEffect,
        FireFlyEffect
    }
    public enum DoomGauntletRegion
    {
        None,
        DarkEffect,
        FireEffect,
        IceEffect,
        ToxicEffect,
        ElectEffect,
        WaterEffect,
        MistEffect,
        ExplosionEffect,
        StoneEffect,
        ShineyEffect,
        FireFlyEffect
    }
    public enum OrcFortressRegion
    {
        None,
        DarkEffect,
        FireEffect,
        IceEffect,
        ToxicEffect,
        ElectEffect,
        WaterEffect,
        MistEffect,
        ExplosionEffect,
        StoneEffect,
        ShineyEffect,
        FireFlyEffect
    }
    public enum CrystalCaveEntRegion
    {
        None,
        DarkEffect,
        FireEffect,
        IceEffect,
        ToxicEffect,
        ElectEffect,
        WaterEffect,
        MistEffect,
        ExplosionEffect,
        StoneEffect,
        ShineyEffect,
        FireFlyEffect
    }
    public enum ProtectedIslandRegion
    {
        None,
        DarkEffect,
        FireEffect,
        IceEffect,
        ToxicEffect,
        ElectEffect,
        WaterEffect,
        MistEffect,
        ExplosionEffect,
        StoneEffect,
        ShineyEffect,
        FireFlyEffect
    }
    public enum GrandArenaRegion
    {
        None,
        DarkEffect,
        FireEffect,
        IceEffect,
        ToxicEffect,
        ElectEffect,
        WaterEffect,
        MistEffect,
        ExplosionEffect,
        StoneEffect,
        ShineyEffect,
        FireFlyEffect
    }
    public enum HansesHostelRegion
    {
        None,
        DarkEffect,
        FireEffect,
        IceEffect,
        ToxicEffect,
        ElectEffect,
        WaterEffect,
        MistEffect,
        ExplosionEffect,
        StoneEffect,
        ShineyEffect,
        FireFlyEffect
    }
    public enum YomotsuMinesRegion
    {
        None,
        DarkEffect,
        FireEffect,
        IceEffect,
        ToxicEffect,
        ElectEffect,
        WaterEffect,
        MistEffect,
        ExplosionEffect,
        StoneEffect,
        ShineyEffect,
        FireFlyEffect
    }
    public enum FanDancerDojoRegion
    {
        None,
        DarkEffect,
        FireEffect,
        IceEffect,
        ToxicEffect,
        ElectEffect,
        WaterEffect,
        MistEffect,
        ExplosionEffect,
        StoneEffect,
        ShineyEffect,
        FireFlyEffect
    }
    public enum ZentoRegion
    {
        None,
        DarkEffect,
        FireEffect,
        IceEffect,
        ToxicEffect,
        ElectEffect,
        WaterEffect,
        MistEffect,
        ExplosionEffect,
        StoneEffect,
        ShineyEffect,
        FireFlyEffect
    }
    public enum BeetlescapeRegion
    {
        None,
        DarkEffect,
        FireEffect,
        IceEffect,
        ToxicEffect,
        ElectEffect,
        WaterEffect,
        MistEffect,
        ExplosionEffect,
        StoneEffect,
        ShineyEffect,
        FireFlyEffect
    }
    public enum BushidoDojoRegion
    {
        None,
        DarkEffect,
        FireEffect,
        IceEffect,
        ToxicEffect,
        ElectEffect,
        WaterEffect,
        MistEffect,
        ExplosionEffect,
        StoneEffect,
        ShineyEffect,
        FireFlyEffect
    }
    public class EffectStone : Item
	{
        private MoongateRegion m_MoongateRegion;
        [CommandProperty( AccessLevel.GameMaster )]
        public MoongateRegion MoongateRegion
		{
            get { return m_MoongateRegion; }
            set { m_MoongateRegion = value; }
		}
        private CoveRegion m_CoveRegion;
        [CommandProperty(AccessLevel.GameMaster)]
        public CoveRegion CoveRegion
        {
            get { return m_CoveRegion; }
            set { m_CoveRegion = value; }
        }
        private BritainRegion m_BritainRegion;
        [CommandProperty(AccessLevel.GameMaster)]
        public BritainRegion BritainRegion
        {
            get { return m_BritainRegion; }
            set { m_BritainRegion = value; }
        }
        private BritainGRegion m_BritainGRegion;
        [CommandProperty(AccessLevel.GameMaster)]
        public BritainGRegion BritainGRegion
        {
            get { return m_BritainGRegion; }
            set { m_BritainGRegion = value; }
        }
        private JhelomIsRegion m_JhelomIsRegion;
        [CommandProperty(AccessLevel.GameMaster)]
        public JhelomIsRegion JhelomIsRegion
        {
            get { return m_JhelomIsRegion; }
            set { m_JhelomIsRegion = value; }
        }
        private JhelomRegion m_JhelomRegion;
        [CommandProperty(AccessLevel.GameMaster)]
        public JhelomRegion JhelomRegion
        {
            get { return m_JhelomRegion; }
            set { m_JhelomRegion = value; }
        }
        private MinocRegion m_MinocRegion;
        [CommandProperty(AccessLevel.GameMaster)]
        public MinocRegion MinocRegion
        {
            get { return m_MinocRegion; }
            set { m_MinocRegion = value; }
        }
        private OclloRegion m_OclloRegion;
        [CommandProperty(AccessLevel.GameMaster)]
        public OclloRegion OclloRegion
        {
            get { return m_OclloRegion; }
            set { m_OclloRegion = value; }
        }
        private TrinsicRegion m_TrinsicRegion;
        [CommandProperty( AccessLevel.GameMaster )]
        public TrinsicRegion TrinsicRegion
		{
            get { return m_TrinsicRegion; }
            set { m_TrinsicRegion = value; }
		}
        private VesperRegion m_VesperRegion;
        [CommandProperty(AccessLevel.GameMaster)]
        public VesperRegion VesperRegion
        {
            get { return m_VesperRegion; }
            set { m_VesperRegion = value; }
        }
        private YewRegion m_YewRegion;
        [CommandProperty(AccessLevel.GameMaster)]
        public YewRegion YewRegion
        {
            get { return m_YewRegion; }
            set { m_YewRegion = value; }
        }
        private WindRegion m_WindRegion;
        [CommandProperty(AccessLevel.GameMaster)]
        public WindRegion WindRegion
        {
            get { return m_WindRegion; }
            set { m_WindRegion = value; }
        }
        private SerpHoldRegion m_SerpHoldRegion;
        [CommandProperty(AccessLevel.GameMaster)]
        public SerpHoldRegion SerpHoldRegion
        {
            get { return m_SerpHoldRegion; }
            set { m_SerpHoldRegion = value; }
        }
        private SkaraBraeRegion m_SkaraBraeRegion;
        [CommandProperty(AccessLevel.GameMaster)]
        public SkaraBraeRegion SkaraBraeRegion
        {
            get { return m_SkaraBraeRegion; }
            set { m_SkaraBraeRegion = value; }
        }
        private NujelmRegion m_NujelmRegion;
        [CommandProperty(AccessLevel.GameMaster)]
        public NujelmRegion NujelmRegion
        {
            get { return m_NujelmRegion; }
            set { m_NujelmRegion = value; }
        }
        private MoonglowRegion m_MoonglowRegion;
        [CommandProperty(AccessLevel.GameMaster)]
        public MoonglowRegion MoonglowRegion
        {
            get { return m_MoonglowRegion; }
            set { m_MoonglowRegion = value; }
        }
        private MaginciaRegion m_MaginciaRegion;
        [CommandProperty( AccessLevel.GameMaster )]
        public MaginciaRegion MaginciaRegion
		{
            get { return m_MaginciaRegion; }
            set { m_MaginciaRegion = value; }
		}
        private BucsDenRegion m_BucsDenRegion;
        [CommandProperty(AccessLevel.GameMaster)]
        public BucsDenRegion BucsDenRegion
        {
            get { return m_BucsDenRegion; }
            set { m_BucsDenRegion = value; }
        }
        private CovetousRegion m_CovetousRegion;
        [CommandProperty(AccessLevel.GameMaster)]
        public CovetousRegion CovetousRegion
        {
            get { return m_CovetousRegion; }
            set { m_CovetousRegion = value; }
        }
        private DeceitRegion m_DeceitRegion;
        [CommandProperty(AccessLevel.GameMaster)]
        public DeceitRegion DeceitRegion
        {
            get { return m_DeceitRegion; }
            set { m_DeceitRegion = value; }
        }
        private DespiseRegion m_DespiseRegion;
        [CommandProperty(AccessLevel.GameMaster)]
        public DespiseRegion DespiseRegion
        {
            get { return m_DespiseRegion; }
            set { m_DespiseRegion = value; }
        }
        private DestardRegion m_DestardRegion;
        [CommandProperty(AccessLevel.GameMaster)]
        public DestardRegion DestardRegion
        {
            get { return m_DestardRegion; }
            set { m_DestardRegion = value; }
        }
        private HythlothRegion m_HythlothRegion;
        [CommandProperty(AccessLevel.GameMaster)]
        public HythlothRegion HythlothRegion
        {
            get { return m_HythlothRegion; }
            set { m_HythlothRegion = value; }
        }
        private KhaldunRegion m_KhaldunRegion;
        [CommandProperty(AccessLevel.GameMaster)]
        public KhaldunRegion KhaldunRegion
        {
            get { return m_KhaldunRegion; }
            set { m_KhaldunRegion = value; }
        }
        private ShameRegion m_ShameRegion;
        [CommandProperty(AccessLevel.GameMaster)]
        public ShameRegion ShameRegion
        {
            get { return m_ShameRegion; }
            set { m_ShameRegion = value; }
        }
        private WrongRegion m_WrongRegion;
        [CommandProperty( AccessLevel.GameMaster )]
        public WrongRegion WrongRegion
		{
            get { return m_WrongRegion; }
            set { m_WrongRegion = value; }
		}
        private Cave1Region m_Cave1Region;
        [CommandProperty(AccessLevel.GameMaster)]
        public Cave1Region Cave1Region
        {
            get { return m_Cave1Region; }
            set { m_Cave1Region = value; }
        }
        private Cave2Region m_Cave2Region;
        [CommandProperty(AccessLevel.GameMaster)]
        public Cave2Region Cave2Region
        {
            get { return m_Cave2Region; }
            set { m_Cave2Region = value; }
        }
        private Cave3Region m_Cave3Region;
        [CommandProperty(AccessLevel.GameMaster)]
        public Cave3Region Cave3Region
        {
            get { return m_Cave3Region; }
            set { m_Cave3Region = value; }
        }
        private Cave4Region m_Cave4Region;
        [CommandProperty(AccessLevel.GameMaster)]
        public Cave4Region Cave4Region
        {
            get { return m_Cave4Region; }
            set { m_Cave4Region = value; }
        }
        private BritMine1Region m_BritMine1Region;
        [CommandProperty(AccessLevel.GameMaster)]
        public BritMine1Region BritMine1Region
        {
            get { return m_BritMine1Region; }
            set { m_BritMine1Region = value; }
        }
        private BritMine2Region m_BritMine2Region;
        [CommandProperty(AccessLevel.GameMaster)]
        public BritMine2Region BritMine2Region
        {
            get { return m_BritMine2Region; }
            set { m_BritMine2Region = value; }
        }
        private MinocCave1Region m_MinocCave1Region;
        [CommandProperty(AccessLevel.GameMaster)]
        public MinocCave1Region MinocCave1Region
        {
            get { return m_MinocCave1Region; }
            set { m_MinocCave1Region = value; }
        }
        private MinocCave2Region m_MinocCave2Region;
        [CommandProperty(AccessLevel.GameMaster)]
        public MinocCave2Region MinocCave2Region
        {
            get { return m_MinocCave2Region; }
            set { m_MinocCave2Region = value; }
        }
        private MinocCave3Region m_MinocCave3Region;
        [CommandProperty(AccessLevel.GameMaster)]
        public MinocCave3Region MinocCave3Region
        {
            get { return m_MinocCave3Region; }
            set { m_MinocCave3Region = value; }
        }
        private MinocCaveRegion m_MinocCaveRegion;
        [CommandProperty(AccessLevel.GameMaster)]
        public MinocCaveRegion MinocCaveRegion
        {
            get { return m_MinocCaveRegion; }
            set { m_MinocCaveRegion = value; }
        }
        private AvatarIsleCaveRegion m_AvatarIsleCaveRegion;
        [CommandProperty(AccessLevel.GameMaster)]
        public AvatarIsleCaveRegion AvatarIsleCaveRegion
        {
            get { return m_AvatarIsleCaveRegion; }
            set { m_AvatarIsleCaveRegion = value; }
        }
        private IceIsleCave1Region m_IceIsleCave1Region;
        [CommandProperty(AccessLevel.GameMaster)]
        public IceIsleCave1Region IceIsleCave1Region
        {
            get { return m_IceIsleCave1Region; }
            set { m_IceIsleCave1Region = value; }
        }
        private IceIsleCave2Region m_IceIsleCave2Region;
        [CommandProperty(AccessLevel.GameMaster)]
        public IceIsleCave2Region IceIsleCave2Region
        {
            get { return m_IceIsleCave2Region; }
            set { m_IceIsleCave2Region = value; }
        }
        private NorthTerritoryCaveRegion m_NorthTerritoryCaveRegion;
        [CommandProperty(AccessLevel.GameMaster)]
        public NorthTerritoryCaveRegion NorthTerritoryCaveRegion
        {
            get { return m_NorthTerritoryCaveRegion; }
            set { m_NorthTerritoryCaveRegion = value; }
        }
        private YewCaveRegion m_YewCaveRegion;
        [CommandProperty(AccessLevel.GameMaster)]
        public YewCaveRegion YewCaveRegion
        {
            get { return m_YewCaveRegion; }
            set { m_YewCaveRegion = value; }
        }
        private NorthTerritoryMine1Region m_NorthTerritoryMine1Region;
        [CommandProperty(AccessLevel.GameMaster)]
        public NorthTerritoryMine1Region NorthTerritoryMine1Region
        {
            get { return m_NorthTerritoryMine1Region; }
            set { m_NorthTerritoryMine1Region = value; }
        }
        private NorthTerritoryMine2Region m_NorthTerritoryMine2Region;
        [CommandProperty(AccessLevel.GameMaster)]
        public NorthTerritoryMine2Region NorthTerritoryMine2Region
        {
            get { return m_NorthTerritoryMine2Region; }
            set { m_NorthTerritoryMine2Region = value; }
        }
        private MtKendallRegion m_MtKendallRegion;
        [CommandProperty(AccessLevel.GameMaster)]
        public MtKendallRegion MtKendallRegion
        {
            get { return m_MtKendallRegion; }
            set { m_MtKendallRegion = value; }
        }
        private CovetousMineRegion m_CovetousMineRegion;
        [CommandProperty(AccessLevel.GameMaster)]
        public CovetousMineRegion CovetousMineRegion
        {
            get { return m_CovetousMineRegion; }
            set { m_CovetousMineRegion = value; }
        }
        private TerathanKeepRegion m_TerathanKeepRegion;
        [CommandProperty(AccessLevel.GameMaster)]
        public TerathanKeepRegion TerathanKeepRegion
        {
            get { return m_TerathanKeepRegion; }
            set { m_TerathanKeepRegion = value; }
        }
        private FireRegion m_FireRegion;
        [CommandProperty(AccessLevel.GameMaster)]
        public FireRegion FireRegion
        {
            get { return m_FireRegion; }
            set { m_FireRegion = value; }
        }
        private IceRegion m_IceRegion;
        [CommandProperty(AccessLevel.GameMaster)]
        public IceRegion IceRegion
        {
            get { return m_IceRegion; }
            set { m_IceRegion = value; }
        }
        private DeluciaRegion m_DeluciaRegion;
        [CommandProperty(AccessLevel.GameMaster)]
        public DeluciaRegion DeluciaRegion
        {
            get { return m_DeluciaRegion; }
            set { m_DeluciaRegion = value; }
        }
        private PapuaRegion m_PapuaRegion;
        [CommandProperty(AccessLevel.GameMaster)]
        public PapuaRegion PapuaRegion
        {
            get { return m_PapuaRegion; }
            set { m_PapuaRegion = value; }
        }
        private CovetousEntRegion m_CovetousEntRegion;
        [CommandProperty(AccessLevel.GameMaster)]
        public CovetousEntRegion CovetousEntRegion
        {
            get { return m_CovetousEntRegion; }
            set { m_CovetousEntRegion = value; }
        }
        private WrongEntrRegion m_WrongEntrRegion;
        [CommandProperty(AccessLevel.GameMaster)]
        public WrongEntrRegion WrongEntrRegion
        {
            get { return m_WrongEntrRegion; }
            set { m_WrongEntrRegion = value; }
        }
        private DespiseEntRegion m_DespiseEntRegion;
        [CommandProperty(AccessLevel.GameMaster)]
        public DespiseEntRegion DespiseEntRegion
        {
            get { return m_DespiseEntRegion; }
            set { m_DespiseEntRegion = value; }
        }
        private DespisePassRegion m_DespisePassRegion;
        [CommandProperty(AccessLevel.GameMaster)]
        public DespisePassRegion DespisePassRegion
        {
            get { return m_DespisePassRegion; }
            set { m_DespisePassRegion = value; }
        }
        private NthTerrMine1Region m_NthTerrMine1Region;
        [CommandProperty(AccessLevel.GameMaster)]
        public NthTerrMine1Region NthTerrMine1Region
        {
            get { return m_NthTerrMine1Region; }
            set { m_NthTerrMine1Region = value; }
        }
        private MiscDungRegion m_MiscDungRegion;
        [CommandProperty(AccessLevel.GameMaster)]
        public MiscDungRegion MiscDungRegion
        {
            get { return m_MiscDungRegion; }
            set { m_MiscDungRegion = value; }
        }
        private OrcCaveRegion m_OrcCaveRegion;
        [CommandProperty(AccessLevel.GameMaster)]
        public OrcCaveRegion OrcCaveRegion
        {
            get { return m_OrcCaveRegion; }
            set { m_OrcCaveRegion = value; }
        }
        private HavenIsleRegion m_HavenIsleRegion;
        [CommandProperty(AccessLevel.GameMaster)]
        public HavenIsleRegion HavenIsleRegion
        {
            get { return m_HavenIsleRegion; }
            set { m_HavenIsleRegion = value; }
        }
        private ShrineofValorRegion m_ShrineofValorRegion;
        [CommandProperty(AccessLevel.GameMaster)]
        public ShrineofValorRegion ShrineofValorRegion
        {
            get { return m_ShrineofValorRegion; }
            set { m_ShrineofValorRegion = value; }
        }
        private ChaosShrineRegion m_ChaosShrineRegion;
        [CommandProperty(AccessLevel.GameMaster)]
        public ChaosShrineRegion ChaosShrineRegion
        {
            get { return m_ChaosShrineRegion; }
            set { m_ChaosShrineRegion = value; }
        }
        private ShrineofSacrificeRegion m_ShrineofSacrificeRegion;
        [CommandProperty(AccessLevel.GameMaster)]
        public ShrineofSacrificeRegion ShrineofSacrificeRegion
        {
            get { return m_ShrineofSacrificeRegion; }
            set { m_ShrineofSacrificeRegion = value; }
        }
        private ShrineofHonestyRegion m_ShrineofHonestyRegion;
        [CommandProperty(AccessLevel.GameMaster)]
        public ShrineofHonestyRegion ShrineofHonestyRegion
        {
            get { return m_ShrineofHonestyRegion; }
            set { m_ShrineofHonestyRegion = value; }
        }
        private ShrineofCompassionRegion m_ShrineofCompassionRegion;
        [CommandProperty(AccessLevel.GameMaster)]
        public ShrineofCompassionRegion ShrineofCompassionRegion
        {
            get { return m_ShrineofCompassionRegion; }
            set { m_ShrineofCompassionRegion = value; }
        }
        private ShrineofSpiritualityRegion m_ShrineofSpiritualityRegion;
        [CommandProperty(AccessLevel.GameMaster)]
        public ShrineofSpiritualityRegion ShrineofSpiritualityRegion
        {
            get { return m_ShrineofSpiritualityRegion; }
            set { m_ShrineofSpiritualityRegion = value; }
        }
        private HumilityRegion m_HumilityRegion;
        [CommandProperty(AccessLevel.GameMaster)]
        public HumilityRegion HumilityRegion
        {
            get { return m_HumilityRegion; }
            set { m_HumilityRegion = value; }
        }
        private HonorRegion m_HonorRegion;
        [CommandProperty(AccessLevel.GameMaster)]
        public HonorRegion HonorRegion
        {
            get { return m_HonorRegion; }
            set { m_HonorRegion = value; }
        }
        private TerortSkitasRegion m_TerortSkitasRegion;
        [CommandProperty(AccessLevel.GameMaster)]
        public TerortSkitasRegion TerortSkitasRegion
        {
            get { return m_TerortSkitasRegion; }
            set { m_TerortSkitasRegion = value; }
        }
        private GargoyleCityRegion m_GargoyleCityRegion;
        [CommandProperty(AccessLevel.GameMaster)]
        public GargoyleCityRegion GargoyleCityRegion
        {
            get { return m_GargoyleCityRegion; }
            set { m_GargoyleCityRegion = value; }
        }
        private PormirHarmRegion m_PormirHarmRegion;
        [CommandProperty(AccessLevel.GameMaster)]
        public PormirHarmRegion PormirHarmRegion
        {
            get { return m_PormirHarmRegion; }
            set { m_PormirHarmRegion = value; }
        }
        private PormirFelwisRegion m_PormirFelwisRegion;
        [CommandProperty(AccessLevel.GameMaster)]
        public PormirFelwisRegion PormirFelwisRegion
        {
            get { return m_PormirFelwisRegion; }
            set { m_PormirFelwisRegion = value; }
        }
        private CyclopsTempleRegion m_CyclopsTempleRegion;
        [CommandProperty(AccessLevel.GameMaster)]
        public CyclopsTempleRegion CyclopsTempleRegion
        {
            get { return m_CyclopsTempleRegion; }
            set { m_CyclopsTempleRegion = value; }
        }
        private RatFortRegion m_RatFortRegion;
        [CommandProperty(AccessLevel.GameMaster)]
        public RatFortRegion RatFortRegion
        {
            get { return m_RatFortRegion; }
            set { m_RatFortRegion = value; }
        }
        private RatFortCellarRegion m_RatFortCellarRegion;
        [CommandProperty(AccessLevel.GameMaster)]
        public RatFortCellarRegion RatFortCellarRegion
        {
            get { return m_RatFortCellarRegion; }
            set { m_RatFortCellarRegion = value; }
        }
        private EntCentIlsh1Region m_EntCentIlsh1Region;
        [CommandProperty(AccessLevel.GameMaster)]
        public EntCentIlsh1Region EntCentIlsh1Region
        {
            get { return m_EntCentIlsh1Region; }
            set { m_EntCentIlsh1Region = value; }
        }
        private EntCentIlsh2Region m_EntCentIlsh2Region;
        [CommandProperty(AccessLevel.GameMaster)]
        public EntCentIlsh2Region EntCentIlsh2Region
        {
            get { return m_EntCentIlsh2Region; }
            set { m_EntCentIlsh2Region = value; }
        }
        private MontorRegion m_MontorRegion;
        [CommandProperty(AccessLevel.GameMaster)]
        public MontorRegion MontorRegion
        {
            get { return m_MontorRegion; }
            set { m_MontorRegion = value; }
        }
        private TermirFlamRegion m_TermirFlamRegion;
        [CommandProperty(AccessLevel.GameMaster)]
        public TermirFlamRegion TermirFlamRegion
        {
            get { return m_TermirFlamRegion; }
            set { m_TermirFlamRegion = value; }
        }
        private AncientCitadelRegion m_AncientCitadelRegion;
        [CommandProperty(AccessLevel.GameMaster)]
        public AncientCitadelRegion AncientCitadelRegion
        {
            get { return m_AncientCitadelRegion; }
            set { m_AncientCitadelRegion = value; }
        }
        private AlexandrettasBowlRegion m_AlexandrettasBowlRegion;
        [CommandProperty(AccessLevel.GameMaster)]
        public AlexandrettasBowlRegion AlexandrettasBowlRegion
        {
            get { return m_AlexandrettasBowlRegion; }
            set { m_AlexandrettasBowlRegion = value; }
        }
        private EntRockDungRegion m_EntRockDungRegion;
        [CommandProperty(AccessLevel.GameMaster)]
        public EntRockDungRegion EntRockDungRegion
        {
            get { return m_EntRockDungRegion; }
            set { m_EntRockDungRegion = value; }
        }
        private RockDungRegion m_RockDungRegion;
        [CommandProperty(AccessLevel.GameMaster)]
        public RockDungRegion RockDungRegion
        {
            get { return m_RockDungRegion; }
            set { m_RockDungRegion = value; }
        }
        private LenmirAnfinmotasRegion m_LenmirAnfinmotasRegion;
        [CommandProperty(AccessLevel.GameMaster)]
        public LenmirAnfinmotasRegion LenmirAnfinmotasRegion
        {
            get { return m_LenmirAnfinmotasRegion; }
            set { m_LenmirAnfinmotasRegion = value; }
        }
        private EntSpiderCaveRegion m_EntSpiderCaveRegion;
        [CommandProperty(AccessLevel.GameMaster)]
        public EntSpiderCaveRegion EntSpiderCaveRegion
        {
            get { return m_EntSpiderCaveRegion; }
            set { m_EntSpiderCaveRegion = value; }
        }
        private SpiderCaveRegion m_SpiderCaveRegion;
        [CommandProperty(AccessLevel.GameMaster)]
        public SpiderCaveRegion SpiderCaveRegion
        {
            get { return m_SpiderCaveRegion; }
            set { m_SpiderCaveRegion = value; }
        }
        private TwinOaksRegion m_TwinOaksRegion;
        [CommandProperty(AccessLevel.GameMaster)]
        public TwinOaksRegion TwinOaksRegion
        {
            get { return m_TwinOaksRegion; }
            set { m_TwinOaksRegion = value; }
        }
        private RegVolonRegion m_RegVolonRegion;
        [CommandProperty(AccessLevel.GameMaster)]
        public RegVolonRegion RegVolonRegion
        {
            get { return m_RegVolonRegion; }
            set { m_RegVolonRegion = value; }
        }
        private EntSpectreDungRegion m_EntSpectreDungRegion;
        [CommandProperty(AccessLevel.GameMaster)]
        public EntSpectreDungRegion EntSpectreDungRegion
        {
            get { return m_EntSpectreDungRegion; }
            set { m_EntSpectreDungRegion = value; }
        }
        private SpectreDungRegion m_SpectreDungRegion;
        [CommandProperty(AccessLevel.GameMaster)]
        public SpectreDungRegion SpectreDungRegion
        {
            get { return m_SpectreDungRegion; }
            set { m_SpectreDungRegion = value; }
        }
        private EntBloodDungRegion m_EntBloodDungRegion;
        [CommandProperty(AccessLevel.GameMaster)]
        public EntBloodDungRegion EntBloodDungRegion
        {
            get { return m_EntBloodDungRegion; }
            set { m_EntBloodDungRegion = value; }
        }
        private BloodDungRegion m_BloodDungRegion;
        [CommandProperty(AccessLevel.GameMaster)]
        public BloodDungRegion BloodDungRegion
        {
            get { return m_BloodDungRegion; }
            set { m_BloodDungRegion = value; }
        }
        private EntMushroomCaveRegion m_EntMushroomCaveRegion;
        [CommandProperty(AccessLevel.GameMaster)]
        public EntMushroomCaveRegion EntMushroomCaveRegion
        {
            get { return m_EntMushroomCaveRegion; }
            set { m_EntMushroomCaveRegion = value; }
        }
        private MushroomCaveRegion m_MushroomCaveRegion;
        [CommandProperty(AccessLevel.GameMaster)]
        public MushroomCaveRegion MushroomCaveRegion
        {
            get { return m_MushroomCaveRegion; }
            set { m_MushroomCaveRegion = value; }
        }
        private LakeShireRegion m_LakeShireRegion;
        [CommandProperty(AccessLevel.GameMaster)]
        public LakeShireRegion LakeShireRegion
        {
            get { return m_LakeShireRegion; }
            set { m_LakeShireRegion = value; }
        }
        private EntRatCaveRegion m_EntRatCaveRegion;
        [CommandProperty(AccessLevel.GameMaster)]
        public EntRatCaveRegion EntRatCaveRegion
        {
            get { return m_EntRatCaveRegion; }
            set { m_EntRatCaveRegion = value; }
        }
        private RatCaveTerritoryRegion m_RatCaveTerritoryRegion;
        [CommandProperty(AccessLevel.GameMaster)]
        public RatCaveTerritoryRegion RatCaveTerritoryRegion
        {
            get { return m_RatCaveTerritoryRegion; }
            set { m_RatCaveTerritoryRegion = value; }
        }
        private RatManCaveRegion m_RatManCaveRegion;
        [CommandProperty(AccessLevel.GameMaster)]
        public RatManCaveRegion RatManCaveRegion
        {
            get { return m_RatManCaveRegion; }
            set { m_RatManCaveRegion = value; }
        }
        private BetLemRegRegion m_BetLemRegRegion;
        [CommandProperty(AccessLevel.GameMaster)]
        public BetLemRegRegion BetLemRegRegion
        {
            get { return m_BetLemRegRegion; }
            set { m_BetLemRegRegion = value; }
        }
        private MistasRegion m_MistasRegion;
        [CommandProperty(AccessLevel.GameMaster)]
        public MistasRegion MistasRegion
        {
            get { return m_MistasRegion; }
            set { m_MistasRegion = value; }
        }
        private SerpentinePassageRegion m_SerpentinePassageRegion;
        [CommandProperty(AccessLevel.GameMaster)]
        public SerpentinePassageRegion SerpentinePassageRegion
        {
            get { return m_SerpentinePassageRegion; }
            set { m_SerpentinePassageRegion = value; }
        }
        private AnkhDungeonRegion m_AnkhDungeonRegion;
        [CommandProperty(AccessLevel.GameMaster)]
        public AnkhDungeonRegion AnkhDungeonRegion
        {
            get { return m_AnkhDungeonRegion; }
            set { m_AnkhDungeonRegion = value; }
        }
        private KirinPassageRegion m_KirinPassageRegion;
        [CommandProperty(AccessLevel.GameMaster)]
        public KirinPassageRegion KirinPassageRegion
        {
            get { return m_KirinPassageRegion; }
            set { m_KirinPassageRegion = value; }
        }
        private EntLizardsPassageRegion m_EntLizardsPassageRegion;
        [CommandProperty(AccessLevel.GameMaster)]
        public EntLizardsPassageRegion EntLizardsPassageRegion
        {
            get { return m_EntLizardsPassageRegion; }
            set { m_EntLizardsPassageRegion = value; }
        }
        private WispDungeonRegion m_WispDungeonRegion;
        [CommandProperty(AccessLevel.GameMaster)]
        public WispDungeonRegion WispDungeonRegion
        {
            get { return m_WispDungeonRegion; }
            set { m_WispDungeonRegion = value; }
        }
        private LizardPassageRegion m_LizardPassageRegion;
        [CommandProperty(AccessLevel.GameMaster)]
        public LizardPassageRegion LizardPassageRegion
        {
            get { return m_LizardPassageRegion; }
            set { m_LizardPassageRegion = value; }
        }
        private ExodusDungeonRegion m_ExodusDungeonRegion;
        [CommandProperty(AccessLevel.GameMaster)]
        public ExodusDungeonRegion ExodusDungeonRegion
        {
            get { return m_ExodusDungeonRegion; }
            set { m_ExodusDungeonRegion = value; }
        }
        private LizardManHutsRegion m_LizardManHutsRegion;
        [CommandProperty(AccessLevel.GameMaster)]
        public LizardManHutsRegion LizardManHutsRegion
        {
            get { return m_LizardManHutsRegion; }
            set { m_LizardManHutsRegion = value; }
        }
        private NoxTeregRegion m_NoxTeregRegion;
        [CommandProperty(AccessLevel.GameMaster)]
        public NoxTeregRegion NoxTeregRegion
        {
            get { return m_NoxTeregRegion; }
            set { m_NoxTeregRegion = value; }
        }
        private SorcerersDungeonRegion m_SorcerersDungeonRegion;
        [CommandProperty(AccessLevel.GameMaster)]
        public SorcerersDungeonRegion SorcerersDungeonRegion
        {
            get { return m_SorcerersDungeonRegion; }
            set { m_SorcerersDungeonRegion = value; }
        }
        private EntAncientLairRegion m_EntAncientLairRegion;
        [CommandProperty(AccessLevel.GameMaster)]
        public EntAncientLairRegion EntAncientLairRegion
        {
            get { return m_EntAncientLairRegion; }
            set { m_EntAncientLairRegion = value; }
        }
        private AncientLairRegion m_AncientLairRegion;
        [CommandProperty(AccessLevel.GameMaster)]
        public AncientLairRegion AncientLairRegion
        {
            get { return m_AncientLairRegion; }
            set { m_AncientLairRegion = value; }
        }
        private GypsyCampRegion m_GypsyCampRegion;
        [CommandProperty(AccessLevel.GameMaster)]
        public GypsyCampRegion GypsyCampRegion
        {
            get { return m_GypsyCampRegion; }
            set { m_GypsyCampRegion = value; }
        }
        private GypsyCamp1Region m_GypsyCamp1Region;
        [CommandProperty(AccessLevel.GameMaster)]
        public GypsyCamp1Region GypsyCamp1Region
        {
            get { return m_GypsyCamp1Region; }
            set { m_GypsyCamp1Region = value; }
        }
        private GypsyCamp2Region m_GypsyCamp2Region;
        [CommandProperty(AccessLevel.GameMaster)]
        public GypsyCamp2Region GypsyCamp2Region
        {
            get { return m_GypsyCamp2Region; }
            set { m_GypsyCamp2Region = value; }
        }
        private JukaCampRegion m_JukaCampRegion;
        [CommandProperty(AccessLevel.GameMaster)]
        public JukaCampRegion JukaCampRegion
        {
            get { return m_JukaCampRegion; }
            set { m_JukaCampRegion = value; }
        }
        private GypsyCamp3Region m_GypsyCamp3Region;
        [CommandProperty(AccessLevel.GameMaster)]
        public GypsyCamp3Region GypsyCamp3Region
        {
            get { return m_GypsyCamp3Region; }
            set { m_GypsyCamp3Region = value; }
        }
        private GypsyCamp4Region m_GypsyCamp4Region;
        [CommandProperty(AccessLevel.GameMaster)]
        public GypsyCamp4Region GypsyCamp4Region
        {
            get { return m_GypsyCamp4Region; }
            set { m_GypsyCamp4Region = value; }
        }
        private GypsyCamp5Region m_GypsyCamp5Region;
        [CommandProperty(AccessLevel.GameMaster)]
        public GypsyCamp5Region GypsyCamp5Region
        {
            get { return m_GypsyCamp5Region; }
            set { m_GypsyCamp5Region = value; }
        }
        private GypsyCamp6Region m_GypsyCamp6Region;
        [CommandProperty(AccessLevel.GameMaster)]
        public GypsyCamp6Region GypsyCamp6Region
        {
            get { return m_GypsyCamp6Region; }
            set { m_GypsyCamp6Region = value; }
        }
        private BlackthornsIlshCastleRegion m_BlackthornsIlshCastleRegion;
        [CommandProperty(AccessLevel.GameMaster)]
        public BlackthornsIlshCastleRegion BlackthornsIlshCastleRegion
        {
            get { return m_BlackthornsIlshCastleRegion; }
            set { m_BlackthornsIlshCastleRegion = value; }
        }
        private ShrineofVirtuesRegion m_ShrineofVirtuesRegion;
        [CommandProperty(AccessLevel.GameMaster)]
        public ShrineofVirtuesRegion ShrineofVirtuesRegion
        {
            get { return m_ShrineofVirtuesRegion; }
            set { m_ShrineofVirtuesRegion = value; }
        }
        private PassofKarnaughRegion m_PassofKarnaughRegion;
        [CommandProperty(AccessLevel.GameMaster)]
        public PassofKarnaughRegion PassofKarnaughRegion
        {
            get { return m_PassofKarnaughRegion; }
            set { m_PassofKarnaughRegion = value; }
        }
        private VinculumInnRegion m_VinculumInnRegion;
        [CommandProperty(AccessLevel.GameMaster)]
        public VinculumInnRegion VinculumInnRegion
        {
            get { return m_VinculumInnRegion; }
            set { m_VinculumInnRegion = value; }
        }
        private LunaRegion m_LunaRegion;
        [CommandProperty(AccessLevel.GameMaster)]
        public LunaRegion LunaRegion
        {
            get { return m_LunaRegion; }
            set { m_LunaRegion = value; }
        }
        private UmbraRegion m_UmbraRegion;
        [CommandProperty(AccessLevel.GameMaster)]
        public UmbraRegion UmbraRegion
        {
            get { return m_UmbraRegion; }
            set { m_UmbraRegion = value; }
        }
        private DoomRegion m_DoomRegion;
        [CommandProperty(AccessLevel.GameMaster)]
        public DoomRegion DoomRegion
        {
            get { return m_DoomRegion; }
            set { m_DoomRegion = value; }
        }
        private DoomGauntletRegion m_DoomGauntletRegion;
        [CommandProperty(AccessLevel.GameMaster)]
        public DoomGauntletRegion DoomGauntletRegion
        {
            get { return m_DoomGauntletRegion; }
            set { m_DoomGauntletRegion = value; }
        }
        private OrcFortressRegion m_OrcFortressRegion;
        [CommandProperty(AccessLevel.GameMaster)]
        public OrcFortressRegion OrcFortressRegion
        {
            get { return m_OrcFortressRegion; }
            set { m_OrcFortressRegion = value; }
        }
        private CrystalCaveEntRegion m_CrystalCaveEntRegion;
        [CommandProperty(AccessLevel.GameMaster)]
        public CrystalCaveEntRegion CrystalCaveEntRegion
        {
            get { return m_CrystalCaveEntRegion; }
            set { m_CrystalCaveEntRegion = value; }
        }
        private ProtectedIslandRegion m_ProtectedIslandRegion;
        [CommandProperty(AccessLevel.GameMaster)]
        public ProtectedIslandRegion ProtectedIslandRegion
        {
            get { return m_ProtectedIslandRegion; }
            set { m_ProtectedIslandRegion = value; }
        }
        private GrandArenaRegion m_GrandArenaRegion;
        [CommandProperty(AccessLevel.GameMaster)]
        public GrandArenaRegion GrandArenaRegion
        {
            get { return m_GrandArenaRegion; }
            set { m_GrandArenaRegion = value; }
        }
        private HansesHostelRegion m_HansesHostelRegion;
        [CommandProperty(AccessLevel.GameMaster)]
        public HansesHostelRegion HansesHostelRegion
        {
            get { return m_HansesHostelRegion; }
            set { m_HansesHostelRegion = value; }
        }
        private YomotsuMinesRegion m_YomotsuMinesRegion;
        [CommandProperty(AccessLevel.GameMaster)]
        public YomotsuMinesRegion YomotsuMinesRegion
        {
            get { return m_YomotsuMinesRegion; }
            set { m_YomotsuMinesRegion = value; }
        }
        private FanDancerDojoRegion m_FanDancerDojoRegion;
        [CommandProperty(AccessLevel.GameMaster)]
        public FanDancerDojoRegion FanDancerDojoRegion
        {
            get { return m_FanDancerDojoRegion; }
            set { m_FanDancerDojoRegion = value; }
        }
        private ZentoRegion m_ZentoRegion;
        [CommandProperty(AccessLevel.GameMaster)]
        public ZentoRegion ZentoRegion
        {
            get { return m_ZentoRegion; }
            set { m_ZentoRegion = value; }
        }
        private BeetlescapeRegion m_BeetlescapeRegion;
        [CommandProperty(AccessLevel.GameMaster)]
        public BeetlescapeRegion BeetlescapeRegion
        {
            get { return m_BeetlescapeRegion; }
            set { m_BeetlescapeRegion = value; }
        }
        private BushidoDojoRegion m_BushidoDojoRegion;
        [CommandProperty(AccessLevel.GameMaster)]
        public BushidoDojoRegion BushidoDojoRegion
        {
            get { return m_BushidoDojoRegion; }
            set { m_BushidoDojoRegion = value; }
        }
        [Constructable]
        public EffectStone()
            : base(0xED4)
		{
			Name = "Effects Stone";
			Visible = false;
			Movable = false;
		}

		public override void OnDoubleClick( Mobile m )
		{
			m.SendGump( new PropertiesGump( m, this ) );
		}

		public EffectStone( Serial serial ) : base( serial )
		{
		}

		public override void Serialize( GenericWriter writer )
		{
			base.Serialize( writer );

			writer.Write( (int) 0 ); // version

            writer.WriteEncodedInt((int)m_MoongateRegion);
            writer.WriteEncodedInt((int)m_CoveRegion);
            writer.WriteEncodedInt((int)m_BritainRegion);
            writer.WriteEncodedInt((int)m_BritainGRegion);
            writer.WriteEncodedInt((int)m_JhelomIsRegion);
            writer.WriteEncodedInt((int)m_JhelomRegion);
            writer.WriteEncodedInt((int)m_MinocRegion);
            writer.WriteEncodedInt((int)m_OclloRegion);
            writer.WriteEncodedInt((int)m_TrinsicRegion);
            writer.WriteEncodedInt((int)m_VesperRegion);
            writer.WriteEncodedInt((int)m_YewRegion);
            writer.WriteEncodedInt((int)m_WindRegion);
            writer.WriteEncodedInt((int)m_SerpHoldRegion);
            writer.WriteEncodedInt((int)m_SkaraBraeRegion);
            writer.WriteEncodedInt((int)m_NujelmRegion);
            writer.WriteEncodedInt((int)m_MoonglowRegion);
            writer.WriteEncodedInt((int)m_MaginciaRegion);
            writer.WriteEncodedInt((int)m_BucsDenRegion);
            writer.WriteEncodedInt((int)m_CovetousRegion);
            writer.WriteEncodedInt((int)m_DeceitRegion);
            writer.WriteEncodedInt((int)m_DespiseRegion);
            writer.WriteEncodedInt((int)m_DestardRegion);
            writer.WriteEncodedInt((int)m_HythlothRegion);
            writer.WriteEncodedInt((int)m_KhaldunRegion);
            writer.WriteEncodedInt((int)m_ShameRegion);
            writer.WriteEncodedInt((int)m_WrongRegion);
            writer.WriteEncodedInt((int)m_Cave1Region);
            writer.WriteEncodedInt((int)m_Cave2Region);
            writer.WriteEncodedInt((int)m_Cave3Region);
            writer.WriteEncodedInt((int)m_Cave4Region);
            writer.WriteEncodedInt((int)m_BritMine1Region);
            writer.WriteEncodedInt((int)m_BritMine2Region);
            writer.WriteEncodedInt((int)m_MinocCave1Region);
            writer.WriteEncodedInt((int)m_MinocCave2Region);
            writer.WriteEncodedInt((int)m_MinocCave3Region);
            writer.WriteEncodedInt((int)m_MinocCaveRegion);
            writer.WriteEncodedInt((int)m_AvatarIsleCaveRegion);
            writer.WriteEncodedInt((int)m_IceIsleCave1Region);
            writer.WriteEncodedInt((int)m_IceIsleCave2Region);
            writer.WriteEncodedInt((int)m_NorthTerritoryCaveRegion);
            writer.WriteEncodedInt((int)m_YewCaveRegion);
            writer.WriteEncodedInt((int)m_NorthTerritoryMine1Region);
            writer.WriteEncodedInt((int)m_NorthTerritoryMine2Region);
            writer.WriteEncodedInt((int)m_MtKendallRegion);
            writer.WriteEncodedInt((int)m_CovetousMineRegion);
            writer.WriteEncodedInt((int)m_TerathanKeepRegion);
            writer.WriteEncodedInt((int)m_FireRegion);
            writer.WriteEncodedInt((int)m_IceRegion);
            writer.WriteEncodedInt((int)m_DeluciaRegion);
            writer.WriteEncodedInt((int)m_PapuaRegion);
            writer.WriteEncodedInt((int)m_CovetousEntRegion);
            writer.WriteEncodedInt((int)m_WrongEntrRegion);
            writer.WriteEncodedInt((int)m_DespiseEntRegion);
            writer.WriteEncodedInt((int)m_DespisePassRegion);
            writer.WriteEncodedInt((int)m_NthTerrMine1Region);
            writer.WriteEncodedInt((int)m_MiscDungRegion);
            writer.WriteEncodedInt((int)m_OrcCaveRegion);
            writer.WriteEncodedInt((int)m_HavenIsleRegion);
            writer.WriteEncodedInt((int)m_ShrineofValorRegion);
            writer.WriteEncodedInt((int)m_ChaosShrineRegion);
            writer.WriteEncodedInt((int)m_ShrineofSacrificeRegion);
            writer.WriteEncodedInt((int)m_ShrineofHonestyRegion);
            writer.WriteEncodedInt((int)m_ShrineofCompassionRegion);
            writer.WriteEncodedInt((int)m_ShrineofSpiritualityRegion);
            writer.WriteEncodedInt((int)m_HumilityRegion);
            writer.WriteEncodedInt((int)m_HonorRegion);
            writer.WriteEncodedInt((int)m_TerortSkitasRegion);
            writer.WriteEncodedInt((int)m_GargoyleCityRegion);
            writer.WriteEncodedInt((int)m_PormirHarmRegion);
            writer.WriteEncodedInt((int)m_PormirFelwisRegion);
            writer.WriteEncodedInt((int)m_CyclopsTempleRegion);
            writer.WriteEncodedInt((int)m_RatFortRegion);
            writer.WriteEncodedInt((int)m_RatFortCellarRegion);
            writer.WriteEncodedInt((int)m_EntCentIlsh1Region);
            writer.WriteEncodedInt((int)m_EntCentIlsh2Region);
            writer.WriteEncodedInt((int)m_MontorRegion);
            writer.WriteEncodedInt((int)m_TermirFlamRegion);
            writer.WriteEncodedInt((int)m_AncientCitadelRegion);
            writer.WriteEncodedInt((int)m_AlexandrettasBowlRegion);
            writer.WriteEncodedInt((int)m_EntRockDungRegion);
            writer.WriteEncodedInt((int)m_RockDungRegion);
            writer.WriteEncodedInt((int)m_LenmirAnfinmotasRegion);
            writer.WriteEncodedInt((int)m_EntSpiderCaveRegion);
            writer.WriteEncodedInt((int)m_SpiderCaveRegion);
            writer.WriteEncodedInt((int)m_TwinOaksRegion);
            writer.WriteEncodedInt((int)m_RegVolonRegion);
            writer.WriteEncodedInt((int)m_EntSpectreDungRegion);
            writer.WriteEncodedInt((int)m_SpectreDungRegion);
            writer.WriteEncodedInt((int)m_EntBloodDungRegion);
            writer.WriteEncodedInt((int)m_BloodDungRegion);
            writer.WriteEncodedInt((int)m_EntMushroomCaveRegion);
            writer.WriteEncodedInt((int)m_MushroomCaveRegion);
            writer.WriteEncodedInt((int)m_LakeShireRegion);
            writer.WriteEncodedInt((int)m_EntRatCaveRegion);
            writer.WriteEncodedInt((int)m_RatCaveTerritoryRegion);
            writer.WriteEncodedInt((int)m_RatManCaveRegion);
            writer.WriteEncodedInt((int)m_BetLemRegRegion);
            writer.WriteEncodedInt((int)m_MistasRegion);
            writer.WriteEncodedInt((int)m_SerpentinePassageRegion);
            writer.WriteEncodedInt((int)m_AnkhDungeonRegion);
            writer.WriteEncodedInt((int)m_KirinPassageRegion);
            writer.WriteEncodedInt((int)m_EntLizardsPassageRegion);
            writer.WriteEncodedInt((int)m_WispDungeonRegion);
            writer.WriteEncodedInt((int)m_LizardPassageRegion);
            writer.WriteEncodedInt((int)m_ExodusDungeonRegion);
            writer.WriteEncodedInt((int)m_LizardManHutsRegion);
            writer.WriteEncodedInt((int)m_NoxTeregRegion);
            writer.WriteEncodedInt((int)m_SorcerersDungeonRegion);
            writer.WriteEncodedInt((int)m_EntAncientLairRegion);
            writer.WriteEncodedInt((int)m_AncientLairRegion);
            writer.WriteEncodedInt((int)m_GypsyCampRegion);
            writer.WriteEncodedInt((int)m_GypsyCamp1Region);
            writer.WriteEncodedInt((int)m_GypsyCamp2Region);
            writer.WriteEncodedInt((int)m_JukaCampRegion);
            writer.WriteEncodedInt((int)m_GypsyCamp3Region);
            writer.WriteEncodedInt((int)m_GypsyCamp4Region);
            writer.WriteEncodedInt((int)m_GypsyCamp5Region);
            writer.WriteEncodedInt((int)m_GypsyCamp6Region);
            writer.WriteEncodedInt((int)m_BlackthornsIlshCastleRegion);
            writer.WriteEncodedInt((int)m_ShrineofVirtuesRegion);
            writer.WriteEncodedInt((int)m_PassofKarnaughRegion);
            writer.WriteEncodedInt((int)m_VinculumInnRegion);
            writer.WriteEncodedInt((int)m_LunaRegion);
            writer.WriteEncodedInt((int)m_UmbraRegion);
            writer.WriteEncodedInt((int)m_DoomRegion);
            writer.WriteEncodedInt((int)m_DoomGauntletRegion);
            writer.WriteEncodedInt((int)m_OrcFortressRegion);
            writer.WriteEncodedInt((int)m_CrystalCaveEntRegion);
            writer.WriteEncodedInt((int)m_ProtectedIslandRegion);
            writer.WriteEncodedInt((int)m_GrandArenaRegion);
            writer.WriteEncodedInt((int)m_HansesHostelRegion);
            writer.WriteEncodedInt((int)m_YomotsuMinesRegion);
            writer.WriteEncodedInt((int)m_FanDancerDojoRegion);
            writer.WriteEncodedInt((int)m_ZentoRegion);
            writer.WriteEncodedInt((int)m_BeetlescapeRegion);
            writer.WriteEncodedInt((int)m_BushidoDojoRegion);
		}

		public override void Deserialize( GenericReader reader )
		{
			base.Deserialize( reader );

			int version = reader.ReadInt();
            m_MoongateRegion = (MoongateRegion)reader.ReadEncodedInt();
            m_CoveRegion = (CoveRegion)reader.ReadEncodedInt();
            m_BritainRegion = (BritainRegion)reader.ReadEncodedInt();
            m_BritainGRegion = (BritainGRegion)reader.ReadEncodedInt();
            m_JhelomIsRegion = (JhelomIsRegion)reader.ReadEncodedInt();
            m_JhelomRegion = (JhelomRegion)reader.ReadEncodedInt();
            m_MinocRegion = (MinocRegion)reader.ReadEncodedInt();
            m_OclloRegion = (OclloRegion)reader.ReadEncodedInt();
            m_TrinsicRegion = (TrinsicRegion)reader.ReadEncodedInt();
            m_VesperRegion = (VesperRegion)reader.ReadEncodedInt();
            m_YewRegion = (YewRegion)reader.ReadEncodedInt();
            m_WindRegion = (WindRegion)reader.ReadEncodedInt();
            m_SerpHoldRegion = (SerpHoldRegion)reader.ReadEncodedInt();
            m_SkaraBraeRegion = (SkaraBraeRegion)reader.ReadEncodedInt();
            m_NujelmRegion = (NujelmRegion)reader.ReadEncodedInt();
            m_MoonglowRegion = (MoonglowRegion)reader.ReadEncodedInt();
            m_MaginciaRegion = (MaginciaRegion)reader.ReadEncodedInt();
            m_BucsDenRegion = (BucsDenRegion)reader.ReadEncodedInt();
            m_CovetousRegion = (CovetousRegion)reader.ReadEncodedInt();
            m_DeceitRegion = (DeceitRegion)reader.ReadEncodedInt();
            m_DespiseRegion = (DespiseRegion)reader.ReadEncodedInt();
            m_DestardRegion = (DestardRegion)reader.ReadEncodedInt();
            m_HythlothRegion = (HythlothRegion)reader.ReadEncodedInt();
            m_KhaldunRegion = (KhaldunRegion)reader.ReadEncodedInt();
            m_ShameRegion = (ShameRegion)reader.ReadEncodedInt();
            m_WrongRegion = (WrongRegion)reader.ReadEncodedInt();
            m_Cave1Region = (Cave1Region)reader.ReadEncodedInt();
            m_Cave2Region = (Cave2Region)reader.ReadEncodedInt();
            m_Cave3Region = (Cave3Region)reader.ReadEncodedInt();
            m_Cave4Region = (Cave4Region)reader.ReadEncodedInt();
            m_BritMine1Region = (BritMine1Region)reader.ReadEncodedInt();
            m_BritMine2Region = (BritMine2Region)reader.ReadEncodedInt();
            m_MinocCave1Region = (MinocCave1Region)reader.ReadEncodedInt();
            m_MinocCave2Region = (MinocCave2Region)reader.ReadEncodedInt();
            m_MinocCave3Region = (MinocCave3Region)reader.ReadEncodedInt();
            m_MinocCaveRegion = (MinocCaveRegion)reader.ReadEncodedInt();
            m_AvatarIsleCaveRegion = (AvatarIsleCaveRegion)reader.ReadEncodedInt();
            m_IceIsleCave1Region = (IceIsleCave1Region)reader.ReadEncodedInt();
            m_IceIsleCave2Region = (IceIsleCave2Region)reader.ReadEncodedInt();
            m_NorthTerritoryCaveRegion = (NorthTerritoryCaveRegion)reader.ReadEncodedInt();
            m_YewCaveRegion = (YewCaveRegion)reader.ReadEncodedInt();
            m_NorthTerritoryMine1Region = (NorthTerritoryMine1Region)reader.ReadEncodedInt();
            m_NorthTerritoryMine2Region = (NorthTerritoryMine2Region)reader.ReadEncodedInt();
            m_MtKendallRegion = (MtKendallRegion)reader.ReadEncodedInt();
            m_CovetousMineRegion = (CovetousMineRegion)reader.ReadEncodedInt();
            m_TerathanKeepRegion = (TerathanKeepRegion)reader.ReadEncodedInt();
            m_FireRegion = (FireRegion)reader.ReadEncodedInt();
            m_IceRegion = (IceRegion)reader.ReadEncodedInt();
            m_DeluciaRegion = (DeluciaRegion)reader.ReadEncodedInt();
            m_PapuaRegion = (PapuaRegion)reader.ReadEncodedInt();
            m_CovetousEntRegion = (CovetousEntRegion)reader.ReadEncodedInt();
            m_WrongEntrRegion = (WrongEntrRegion)reader.ReadEncodedInt();
            m_DespiseEntRegion = (DespiseEntRegion)reader.ReadEncodedInt();
            m_DespisePassRegion = (DespisePassRegion)reader.ReadEncodedInt();
            m_NthTerrMine1Region = (NthTerrMine1Region)reader.ReadEncodedInt();
            m_MiscDungRegion = (MiscDungRegion)reader.ReadEncodedInt();
            m_OrcCaveRegion = (OrcCaveRegion)reader.ReadEncodedInt();
            m_HavenIsleRegion = (HavenIsleRegion)reader.ReadEncodedInt();
            m_ShrineofValorRegion = (ShrineofValorRegion)reader.ReadEncodedInt();
            m_ChaosShrineRegion = (ChaosShrineRegion)reader.ReadEncodedInt();
            m_ShrineofSacrificeRegion = (ShrineofSacrificeRegion)reader.ReadEncodedInt();
            m_ShrineofHonestyRegion = (ShrineofHonestyRegion)reader.ReadEncodedInt();
            m_ShrineofCompassionRegion = (ShrineofCompassionRegion)reader.ReadEncodedInt();
            m_ShrineofSpiritualityRegion = (ShrineofSpiritualityRegion)reader.ReadEncodedInt();
            m_HumilityRegion = (HumilityRegion)reader.ReadEncodedInt();
            m_HonorRegion = (HonorRegion)reader.ReadEncodedInt();
            m_TerortSkitasRegion = (TerortSkitasRegion)reader.ReadEncodedInt();
            m_GargoyleCityRegion = (GargoyleCityRegion)reader.ReadEncodedInt();
            m_PormirHarmRegion = (PormirHarmRegion)reader.ReadEncodedInt();
            m_PormirFelwisRegion = (PormirFelwisRegion)reader.ReadEncodedInt();
            m_CyclopsTempleRegion = (CyclopsTempleRegion)reader.ReadEncodedInt();
            m_RatFortRegion = (RatFortRegion)reader.ReadEncodedInt();
            m_RatFortCellarRegion = (RatFortCellarRegion)reader.ReadEncodedInt();
            m_EntCentIlsh1Region = (EntCentIlsh1Region)reader.ReadEncodedInt();
            m_EntCentIlsh2Region = (EntCentIlsh2Region)reader.ReadEncodedInt();
            m_MontorRegion = (MontorRegion)reader.ReadEncodedInt();
            m_TermirFlamRegion = (TermirFlamRegion)reader.ReadEncodedInt();
            m_AncientCitadelRegion = (AncientCitadelRegion)reader.ReadEncodedInt();
            m_AlexandrettasBowlRegion = (AlexandrettasBowlRegion)reader.ReadEncodedInt();
            m_EntRockDungRegion = (EntRockDungRegion)reader.ReadEncodedInt();
            m_RockDungRegion = (RockDungRegion)reader.ReadEncodedInt();
            m_LenmirAnfinmotasRegion = (LenmirAnfinmotasRegion)reader.ReadEncodedInt();
            m_EntSpiderCaveRegion = (EntSpiderCaveRegion)reader.ReadEncodedInt();
            m_SpiderCaveRegion = (SpiderCaveRegion)reader.ReadEncodedInt();
            m_TwinOaksRegion = (TwinOaksRegion)reader.ReadEncodedInt();
            m_RegVolonRegion = (RegVolonRegion)reader.ReadEncodedInt();
            m_EntSpectreDungRegion = (EntSpectreDungRegion)reader.ReadEncodedInt();
            m_SpectreDungRegion = (SpectreDungRegion)reader.ReadEncodedInt();
            m_EntBloodDungRegion = (EntBloodDungRegion)reader.ReadEncodedInt();
            m_BloodDungRegion = (BloodDungRegion)reader.ReadEncodedInt();
            m_EntMushroomCaveRegion = (EntMushroomCaveRegion)reader.ReadEncodedInt();
            m_MushroomCaveRegion = (MushroomCaveRegion)reader.ReadEncodedInt();
            m_LakeShireRegion = (LakeShireRegion)reader.ReadEncodedInt();
            m_EntRatCaveRegion = (EntRatCaveRegion)reader.ReadEncodedInt();
            m_RatCaveTerritoryRegion = (RatCaveTerritoryRegion)reader.ReadEncodedInt();
            m_RatManCaveRegion = (RatManCaveRegion)reader.ReadEncodedInt();
            m_BetLemRegRegion = (BetLemRegRegion)reader.ReadEncodedInt();
            m_MistasRegion = (MistasRegion)reader.ReadEncodedInt();
            m_SerpentinePassageRegion = (SerpentinePassageRegion)reader.ReadEncodedInt();
            m_AnkhDungeonRegion = (AnkhDungeonRegion)reader.ReadEncodedInt();
            m_KirinPassageRegion = (KirinPassageRegion)reader.ReadEncodedInt();
            m_EntLizardsPassageRegion = (EntLizardsPassageRegion)reader.ReadEncodedInt();
            m_WispDungeonRegion = (WispDungeonRegion)reader.ReadEncodedInt();
            m_LizardPassageRegion = (LizardPassageRegion)reader.ReadEncodedInt();
            m_ExodusDungeonRegion = (ExodusDungeonRegion)reader.ReadEncodedInt();
            m_LizardManHutsRegion = (LizardManHutsRegion)reader.ReadEncodedInt();
            m_NoxTeregRegion = (NoxTeregRegion)reader.ReadEncodedInt();
            m_SorcerersDungeonRegion = (SorcerersDungeonRegion)reader.ReadEncodedInt();
            m_EntAncientLairRegion = (EntAncientLairRegion)reader.ReadEncodedInt();
            m_AncientLairRegion = (AncientLairRegion)reader.ReadEncodedInt();
            m_GypsyCampRegion = (GypsyCampRegion)reader.ReadEncodedInt();
            m_GypsyCamp1Region = (GypsyCamp1Region)reader.ReadEncodedInt();
            m_GypsyCamp2Region = (GypsyCamp2Region)reader.ReadEncodedInt();
            m_JukaCampRegion = (JukaCampRegion)reader.ReadEncodedInt();
            m_GypsyCamp3Region = (GypsyCamp3Region)reader.ReadEncodedInt();
            m_GypsyCamp4Region = (GypsyCamp4Region)reader.ReadEncodedInt();
            m_GypsyCamp5Region = (GypsyCamp5Region)reader.ReadEncodedInt();
            m_GypsyCamp6Region = (GypsyCamp6Region)reader.ReadEncodedInt();
            m_BlackthornsIlshCastleRegion = (BlackthornsIlshCastleRegion)reader.ReadEncodedInt();
            m_ShrineofVirtuesRegion = (ShrineofVirtuesRegion)reader.ReadEncodedInt();
            m_PassofKarnaughRegion = (PassofKarnaughRegion)reader.ReadEncodedInt();
            m_VinculumInnRegion = (VinculumInnRegion)reader.ReadEncodedInt();
            m_LunaRegion = (LunaRegion)reader.ReadEncodedInt();
            m_UmbraRegion = (UmbraRegion)reader.ReadEncodedInt();
            m_DoomRegion = (DoomRegion)reader.ReadEncodedInt();
            m_DoomGauntletRegion = (DoomGauntletRegion)reader.ReadEncodedInt();
            m_OrcFortressRegion = (OrcFortressRegion)reader.ReadEncodedInt();
            m_CrystalCaveEntRegion = (CrystalCaveEntRegion)reader.ReadEncodedInt();
            m_ProtectedIslandRegion = (ProtectedIslandRegion)reader.ReadEncodedInt();
            m_GrandArenaRegion = (GrandArenaRegion)reader.ReadEncodedInt();
            m_HansesHostelRegion = (HansesHostelRegion)reader.ReadEncodedInt();
            m_YomotsuMinesRegion = (YomotsuMinesRegion)reader.ReadEncodedInt();
            m_FanDancerDojoRegion = (FanDancerDojoRegion)reader.ReadEncodedInt();
            m_ZentoRegion = (ZentoRegion)reader.ReadEncodedInt();
            m_BeetlescapeRegion = (BeetlescapeRegion)reader.ReadEncodedInt();
            m_BushidoDojoRegion = (BushidoDojoRegion)reader.ReadEncodedInt();
		}
    }
 
}
public class SEffectsTimer : Timer
{
    public static void Initialize()
    {
        new SEffectsTimer();
    }

    public SEffectsTimer()
        : base(TimeSpan.FromSeconds(8), TimeSpan.FromMinutes(25))

    // *****************************************************************************************
    // *****************************************************************************************
    // *****************************************************************************************
    {
        this.Start();
    }
    protected override void OnTick()
    {
        World.Broadcast(0x35, true, "Effects System Message...");
        Console.WriteLine("Effects System Tick.");

        ArrayList listEffectStones = new ArrayList();
        foreach (Item item in World.Items.Values)
        {
            if (item is EffectStone)
                listEffectStones.Add(item);
        }

        if (listEffectStones.Count == 1)
        {
            World.Broadcast(0x35, true, "Effects System Active.");
            Console.WriteLine("Effects Stone Dectected, Effects System Active.");
            this.Stop();
        }

        if (listEffectStones.Count == 0)
        {
            World.Broadcast(0x35, true, "Effects System Not Active.");
            Console.WriteLine("Effects System Not Active, No Effects Stone Found.");
            this.Stop();
        }

    }
}