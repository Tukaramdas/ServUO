using System;
using Server;
using Server.Items;
using Server.Mobiles;
using Server.Network;
using Server.Gumps;
using Server.Misc;
 
namespace Server
{
    public class SkillPickGump : Gump
    {
        private int switches = 7;
            private SkillBallPlus  m_SkillBallPlus;
            private double val = 100;
        private static Item MakeNewbie( Item item )
        {
            if ( !Core.AOS )
                item.LootType = LootType.Newbied;
 
            return item;
        }
        public SkillPickGump( SkillBallPlus ball )
            : base( 0, 0 )
        {
            this.Closable=true;
            this.Disposable=true;
            this.Dragable=true;
            this.Resizable=true;
                        m_SkillBallPlus = ball;
 
                  this.AddPage(0);
            this.AddBackground(39, 33, 563, 460, 5120);
            this.AddLabel(67, 41, 1160, "Select 7 starting skills for your character.");
            this.AddButton(460, 470, 2119, 2120, (int)Buttons.Close, GumpButtonType.Reply, 0);
            this.AddBackground(52, 60, 539, 407, 9350);
            this.AddImage(488, 338, 9000);
            this.AddPage(1);
                    this.AddButton(530, 470, 2128, 2129, (int)Buttons.FinishButton, GumpButtonType.Reply, 0);
           
 
    //********************************************************
        this.AddCheck(55, 65, 210, 211, false, 40);        // Tactics
        this.AddCheck(55, 90, 210, 211, false, 2);        // Anatomy
        this.AddCheck(55, 115, 210, 211, false, 39);    // Swordsmanship
        this.AddCheck(55, 140, 210, 211, false, 36);    // Fencing
        this.AddCheck(55, 165, 210, 211, false, 5);        // Archery
        this.AddCheck(55, 190, 210, 211, false, 37);    // Macefighting
        this.AddCheck(55, 215, 210, 211, false, 38);    // Parry
        this.AddCheck(55, 240, 210, 211, false, 6);        // Arms Lore
        this.AddCheck(55, 265, 210, 211, false, 41);    // Wrestling
        this.AddCheck(55, 290, 210, 211, false, 9);        // Blacksmithing
          this.AddCheck(55, 315, 210, 211, false, 13);    // Carpentry
          this.AddCheck(55, 340, 210, 211, false, 34);    // Tinkering
          this.AddCheck(55, 365, 210, 211, false, 33);    // Tailoring
          this.AddCheck(55, 390, 210, 211, false, 15);    // Fishing
          this.AddCheck(55, 415, 210, 211, false, 14);    // Cooking
          this.AddCheck(55, 440, 210, 211, false, 56);    // Fletching
        this.AddLabel(80, 65, 0, @"Tactics");            //40
        this.AddLabel(80, 90, 0, @"Anatomy");              //2
        this.AddLabel(80, 115, 0, @"Swordsmanship");      //39
        this.AddLabel(80, 140, 0, @"Fencing");            //36
        this.AddLabel(80, 165, 0, @"Archery");            //5
        this.AddLabel(80, 190, 0, @"Macefighting");        //37
        this.AddLabel(80, 215, 0, @"Parry");              //38
        this.AddLabel(80, 240, 0, @"Arms Lore");          //6
        this.AddLabel(80, 265, 0, @"Wrestling");          //41
        this.AddLabel(80, 290, 0, @"Blacksmithing");    //9
        this.AddLabel(80, 315, 0, @"Carpentry");        //13
        this.AddLabel(80, 340, 0, @"Tinkering");          //34
        this.AddLabel(80, 365, 0, @"Tailoring");          //33
        this.AddLabel(80, 390, 0, @"Fishing");            //15
        this.AddLabel(80, 415, 0, @"Cooking");            //14
        this.AddLabel(80, 440, 0, @"Fletching");          //56
          //********************************************************
                this.AddCheck(200, 65, 210, 211, false, 23);
                this.AddCheck(200, 90, 210, 211, false, 20);
                this.AddCheck(200, 115, 210, 211, false, 1);
                this.AddCheck(200, 140, 210, 211, false, 44);
                this.AddCheck(200, 165, 210, 211, false, 21);
                this.AddCheck(200, 190, 210, 211, false, 48);
                this.AddCheck(200, 215, 210, 211, false, 50);
                this.AddCheck(200, 240, 210, 211, false, 22);
                this.AddCheck(200, 265, 210, 211, false, 55);
                this.AddCheck(200, 290, 210, 211, false, 32);
                this.AddCheck(200, 315, 210, 211, false, 29);
                this.AddCheck(200, 340, 210, 211, false, 31);
                this.AddCheck(200, 365, 210, 211, false, 19);
                this.AddCheck(200, 390, 210, 211, false, 43);
                this.AddCheck(200, 415, 210, 211, false, 27);
                this.AddCheck(200, 440, 210, 211, false, 45);
            this.AddLabel(225, 65, 0, @"Mining");            //23
            this.AddLabel(225, 90, 0, @"Lumberjacking");      //20
            this.AddLabel(225, 115, 0, @"Alchemy");            //1
            this.AddLabel(225, 140, 0, @"Inscription");        //44
            this.AddLabel(225, 165, 0, @"Magery");            //21
            this.AddLabel(225, 190, 0, @"Spirit Speak");      //48
            this.AddLabel(225, 215, 0, @"Evaluating Int");    //50
            this.AddLabel(225, 240, 0, @"Meditation");        //22
            this.AddLabel(225, 265, 0, @"Hiding");              //55
            this.AddLabel(225, 290, 0, @"Stealth");            //32
            this.AddLabel(225, 315, 0, @"Snooping");          //29
            this.AddLabel(225, 340, 0, @"Stealing");          //31
            this.AddLabel(225, 365, 0, @"Lockpicking");        //19
            this.AddLabel(225, 390, 0, @"Detecting Hidden");    //43
            this.AddLabel(225, 415, 0, @"Remove Trap");        //27
            this.AddLabel(225, 440, 0, @"Tracking");            //45
        //**********************************************************
                this.AddCheck(345, 65, 210, 211, false, 46);
                this.AddCheck(345, 90, 210, 211, false, 4);
                this.AddCheck(345, 115, 210, 211, false, 3);
                this.AddCheck(345, 140, 210, 211, false, 11);
                this.AddCheck(345, 165, 210, 211, false, 24);
                this.AddCheck(345, 190, 210, 211, false, 47);
                this.AddCheck(345, 215, 210, 211, false, 45);
                this.AddCheck(345, 240, 210, 211, false, 52);
                this.AddCheck(345, 265, 210, 211, false, 53);
                this.AddCheck(345, 290, 210, 211, false, 51);
                this.AddCheck(345, 315, 210, 211, false, 7);
                this.AddCheck(345, 340, 210, 211, false, 17);
                this.AddCheck(345, 365, 210, 211, false, 18);
                this.AddCheck(345, 390, 210, 211, false, 28);
                this.AddCheck(345, 415, 210, 211, false, 35);
                this.AddCheck(345, 440, 210, 211, false, 42);
            this.AddLabel(370, 65, 0, @"Poisoning");          //46
            this.AddLabel(370, 90, 0, @"Animal Taming");      //4
            this.AddLabel(370, 115, 0, @"Animal Lore");        //3
            this.AddLabel(370, 140, 0, @"Camping");            //11
            this.AddLabel(370, 165, 0, @"Musicianship");      //24
            this.AddLabel(370, 190, 0, @"Provocation");        //47
            this.AddLabel(370, 215, 0, @"Peacemaking");        //45
            this.AddLabel(370, 240, 0, @"Item Ident");        //52
            this.AddLabel(370, 265, 0, @"Taste Ident");    //53
            this.AddLabel(370, 290, 0, @"Foresic Evaluation");  //51
            this.AddLabel(370, 315, 0, @"Begging");        //7
            this.AddLabel(370, 340, 0, @"Healing");        //17
            this.AddLabel(370, 365, 0, @"Herding");        //18
            this.AddLabel(370, 390, 0, @"Resisting Spells");    //28
            this.AddLabel(370, 415, 0, @"Veterinary");        //35
            this.AddLabel(370, 440, 0, @"Cartography");        //42
    //**********************************************************
                this.AddCheck(490, 65,  210, 211, false, 57);
                this.AddCheck(490, 90,  210, 211, false, 59);
                this.AddCheck(490, 115, 210, 211, false, 60);
                this.AddCheck(490, 140, 210, 211, false, 63);
                this.AddCheck(490, 165, 210, 211, false, 64);
                this.AddCheck(490, 190, 210, 211, false, 65);
                this.AddCheck(490, 215, 210, 211, false, 66);
        this.AddLabel(515, 65,  0, @"Focus");              //57
            this.AddLabel(515, 90,  0, @"Bushido");          //59
            this.AddLabel(515, 115, 0, @"chivalry");        //60
            this.AddLabel(515, 140, 0, @"Necromancy");      //63
            this.AddLabel(515, 165, 0, @"Ninjitsu");          //64
            this.AddLabel(515, 190, 0, @"Spellweaving");    //65
            this.AddLabel(515, 215, 0, @"Discordance");      //66
       
    //**********************************************************
    //stygians abyss Skills. Comment-out if not needed.
   
        this.AddCheck(490, 240, 210, 211, false, 62);
                this.AddCheck(490, 265, 210, 211, false, 61);
                this.AddCheck(490, 290, 210, 211, false, 58);
        this.AddLabel(515, 240, 0, @"Mysticism");        //62
            this.AddLabel(515, 265, 0, @"Imbuing");            //61
            this.AddLabel(515, 290, 0, @"Throwing");          //58                                   
    //**********************************************************   
           
        }
       
            public enum Buttons
            {
                Close,
                FinishButton,
            }
 
        public override void OnResponse( NetState state, RelayInfo info )
        {
            Mobile m = state.Mobile;
           
            switch( info.ButtonID )
            {
                case 0: {break;}
                case 1:
                {
                   
                if ( info.Switches.Length < switches )
                    {
                        m.SendGump( new SkillPickGump(m_SkillBallPlus) );
                        m.SendMessage( 0, "You must pick {0} more skills.", switches - info.Switches.Length );
                        break;
                    }
                    else if ( info.Switches.Length > switches )
                    {
                        m.SendGump( new SkillPickGump(m_SkillBallPlus) );
                        m.SendMessage( 0, "Please get rid of {0} skills, you have exceeded the 7 skills that are allowed.", info.Switches.Length - switches);
                        break;
                                }
 
                    else
                    {
                        Server.Skills skills = m.Skills;
 
                        for (int i = 0; i < skills.Length; ++i)
     //       skills[i].Base = 0;
                        if (info.IsSwitched(1)) // ------------------------------------------------ Alchemy
                        {
            m.Skills[SkillName.Alchemy].Base = val;
            Container pack = m.Backpack;
                if (pack != null)
                {
                    pack.DropItem( new Bottle( 10 ) );
                    pack.DropItem( new MortarPestle() );
                    pack.DropItem( new BagOfReagents( 50) );
                }
            }
                        if (info.IsSwitched(2)) // ------------------------------------------------ Anatomy
            {
            m.Skills[SkillName.Anatomy].Base = val;
            Container pack = m.Backpack;
                if (pack != null)
                {
                    pack.DropItem( new Bandage( 50 ) );
                }
            }
                        if (info.IsSwitched(3)) // ------------------------------------------------ AnimalLore
            {
            m.Skills[SkillName.AnimalLore].Base = val;
            Container pack = m.Backpack;
                if (pack != null)
                {
                    pack.DropItem( new ShepherdsCrook() );
                }
            }
                        if (info.IsSwitched(4)) // ------------------------------------------------ AnimalTaming
                        {
            m.Skills[SkillName.AnimalTaming].Base = val;
            Container pack = m.Backpack;
                if (pack != null)
                {
                    pack.DropItem( new Apple( 10 ) );
                }
            }
                        if (info.IsSwitched(5)) // ------------------------------------------------ Archery
            {
            m.Skills[SkillName.Archery].Base = val;
                        Container pack = m.Backpack;
                if (pack != null)
                {
                    pack.DropItem( new Arrow( 200 ) );
                    pack.DropItem( new Bow( ) );
 
                }
            }
            if (info.IsSwitched(6)) // ------------------------------------------------ ArmsLore
            {
            m.Skills[SkillName.ArmsLore].Base = val;
                        Container pack = m.Backpack;
                if (pack != null)
                {
                    pack.DropItem( new IronIngot( 50 ) );
                }
            }
            if (info.IsSwitched(7)) // ------------------------------------------------ Begging
            {
            m.Skills[SkillName.Begging].Base = val;
                        Container pack = m.Backpack;
                if (pack != null)
                {
                    pack.DropItem( new BankCheck( 5000 ) );
                }
            }
            if (info.IsSwitched(9)) // ------------------------------------------------ Blacksmith
            {
            m.Skills[SkillName.Blacksmith].Base = val;
                        Container pack = m.Backpack;
                if (pack != null)
                {
                    pack.DropItem( new IronIngot( 50 ) );
                    pack.DropItem( new Tongs() );
                    pack.DropItem( new Pickaxe() );
                    pack.DropItem( new Pickaxe() );
                    pack.DropItem( new Shovel() );
                }
            }
            if (info.IsSwitched(11)) // ------------------------------------------------ Camping
            {
            m.Skills[SkillName.Camping].Base = val;
                        Container pack = m.Backpack;
                if (pack != null)
                {
                    pack.DropItem( new Bedroll() );
                    pack.DropItem( new Kindling( 20 ) );
                }
            }
            if (info.IsSwitched(13)) // ------------------------------------------------ Carpentry
            {
            m.Skills[SkillName.Carpentry].Base = val;
                        Container pack = m.Backpack;
                if (pack != null)
                {
                    pack.DropItem( new Saw() );
                    pack.DropItem( new Board(100) );
                }
            }
            if (info.IsSwitched(14)) // ------------------------------------------------ Cooking
            {
            m.Skills[SkillName.Cooking].Base = val;
                        Container pack = m.Backpack;
                if (pack != null)
                {
                    pack.DropItem( new Kindling( 10 ) );
                    pack.DropItem( new RawLambLeg() );
                    pack.DropItem( new RawChickenLeg() );
                    pack.DropItem( new RawFishSteak() );
                    pack.DropItem( new SackFlour() );
                    pack.DropItem( new Pitcher( BeverageType.Water ) );
                }
            }
            if (info.IsSwitched(15)) // ------------------------------------------------ Fishing
            {
            m.Skills[SkillName.Fishing].Base = val;
                        Container pack = m.Backpack;
                if (pack != null)
                {
                    pack.DropItem( new FishingPole() );
                    pack.DropItem( new FishingPole() );
                    pack.DropItem( new FishingPole() );
                    pack.DropItem( new FloppyHat( Utility.RandomYellowHue() ) );
                }
            }
            if (info.IsSwitched(17)) // ------------------------------------------------ Healing
            {
            m.Skills[SkillName.Healing].Base = val;
                        Container pack = m.Backpack;
                if (pack != null)
                {
                    pack.DropItem( new Bandage( 50 ) );
                    pack.DropItem( new Scissors() );
                }
            }
            if (info.IsSwitched(18)) // ------------------------------------------------ Herding
            {
            m.Skills[SkillName.Herding].Base = val;
                        Container pack = m.Backpack;
                if (pack != null)
                {
                    pack.DropItem( new ShepherdsCrook() );
                }
            }
            if (info.IsSwitched(19)) // ------------------------------------------------ Lockpicking
            {
            m.Skills[SkillName.Lockpicking].Base = val;
                        Container pack = m.Backpack;
                if (pack != null)
                {
                    pack.DropItem( new Lockpick( 20 ) );
                }
            }
            if (info.IsSwitched(20)) // ------------------------------------------------ Lumberjacking
            {
            m.Skills[SkillName.Lumberjacking].Base = val;
                        Container pack = m.Backpack;
                if (pack != null)
                {
                    pack.DropItem( new Hatchet() );
                    pack.DropItem( new FullApron( Utility.RandomYellowHue() ) );
                }
            }
            if (info.IsSwitched(21)) // ------------------------------------------------ Magery
                        {
            m.Skills[SkillName.Magery].Base = val;
            Container pack = m.Backpack;
                if (pack != null)
                {
                    pack.DropItem( new Spellbook( UInt64.MaxValue ) );
                    pack.DropItem( new BagOfReagents( 50 ) );
                }
                        }
                        if (info.IsSwitched(22)) // ------------------------------------------------ Meditation
            {
            m.Skills[SkillName.Meditation].Base = val;
                        Container pack = m.Backpack;
                if (pack != null)
                {
                    pack.DropItem( new DecoCrystalBall() );
                }
            }
            if (info.IsSwitched(23)) // ------------------------------------------------ Mining
            {
            m.Skills[SkillName.Mining].Base = val;
                        Container pack = m.Backpack;
                if (pack != null)
                {
                    pack.DropItem( new Pickaxe() );
                    pack.DropItem( new Pickaxe() );
                    pack.DropItem( new Pickaxe() );
                    pack.DropItem( new Shovel() );
                    pack.DropItem( new Shovel() );
                    pack.DropItem( new Shovel() );
 
                }
            }
            if (info.IsSwitched(24)) // ------------------------------------------------ Musicianship
            {
            m.Skills[SkillName.Musicianship].Base = val;
                        Container pack = m.Backpack;
                if (pack != null)
                {
                    pack.DropItem( new Lute() );
                    pack.DropItem( new LapHarp() );
                    pack.DropItem( new TambourineTassel() );
                    pack.DropItem( new Drums() );
                }
            }
            if (info.IsSwitched(27)) // ------------------------------------------------ RemoveTrap
            {
            m.Skills[SkillName.RemoveTrap].Base = val;
                        Container pack = m.Backpack;
                if (pack != null)
                {
                    pack.DropItem( new GreaterHealPotion( 3 ) );
                }
            }
            if (info.IsSwitched(28)) // ------------------------------------------------ MagicResist
            {
            m.Skills[SkillName.MagicResist].Base = val;
                        Container pack = m.Backpack;
                if (pack != null)
                {
                    pack.DropItem( new FireballWand() );
                    pack.DropItem( new LightningWand() );
                    pack.DropItem( new MagicArrowWand() );
                }
            }
            if (info.IsSwitched(29)) // ------------------------------------------------ Snooping
            {
            m.Skills[SkillName.Snooping].Base = val;
                        Container pack = m.Backpack;
                if (pack != null)
                {
                    pack.DropItem( new BankCheck ( 5000 ) );
                }
            }
            if (info.IsSwitched(31)) // ------------------------------------------------ Stealing
            {
            m.Skills[SkillName.Stealing].Base = val;
                        Container pack = m.Backpack;
                if (pack != null)
                {
                    pack.DropItem( new BankCheck ( 5000 ) );
                }
            }
            if (info.IsSwitched(32)) // ------------------------------------------------ Stealth
            {
            m.Skills[SkillName.Stealth].Base = val;
                        Container pack = m.Backpack;
                if (pack != null)
                {
                    pack.DropItem( new BurglarsBandana() );
                }
            }
            if (info.IsSwitched(33)) // ------------------------------------------------ Tailoring
            {
            m.Skills[SkillName.Tailoring].Base = val;
                        Container pack = m.Backpack;
                if (pack != null)
                {
                    pack.DropItem( new BoltOfCloth( ) );
                    pack.DropItem( new Cloth( 100 ) );
                    pack.DropItem( new SewingKit( ) );
                    pack.DropItem( new SewingKit( ) );
                    pack.DropItem( new SewingKit( ) );
                }
            }
            if (info.IsSwitched(34)) // ------------------------------------------------ Tinkering
            {
            m.Skills[SkillName.Tinkering].Base = val;
                        Container pack = m.Backpack;
                if (pack != null)
                {
                    pack.DropItem( new TinkerTools () );
                    pack.DropItem( new IronIngot ( 20 ) );
                }
            }
            if (info.IsSwitched(35)) // ------------------------------------------------ Veterinary
            {
            m.Skills[SkillName.Veterinary].Base = val;
                        Container pack = m.Backpack;
                if (pack != null)
                {
                    pack.DropItem( new Bandage( 50 ) );
                }
            }
            if (info.IsSwitched(36)) // ------------------------------------------------ Fencing
            {
            m.Skills[SkillName.Fencing].Base = val;
                        Container pack = m.Backpack;
                if (pack != null)
                {
                    pack.DropItem( new Kryss() );
                }
            }
            if (info.IsSwitched(37)) // ------------------------------------------------ Macing
            {
            m.Skills[SkillName.Macing].Base = val;
                        Container pack = m.Backpack;
                if (pack != null)
                {
                    pack.DropItem( new Mace() );
                }
            }
            if (info.IsSwitched(38)) // ------------------------------------------------ Parry
            {
            m.Skills[SkillName.Parry].Base = val;
                        Container pack = m.Backpack;
                if (pack != null)
                {
                    pack.DropItem( new MetalKiteShield() );
                }
            }
            if (info.IsSwitched(39)) // ------------------------------------------------ Swords
            {
            m.Skills[SkillName.Swords].Base = val;
                        Container pack = m.Backpack;
                if (pack != null)
                {
                    pack.DropItem( new Longsword() );
                }
            }
            if (info.IsSwitched(40)) // ------------------------------------------------ Tactics
            {
            m.Skills[SkillName.Tactics].Base = val;
                        Container pack = m.Backpack;
                if (pack != null)
                {
                    pack.DropItem( new Gold (500) );
                }
            }
            if (info.IsSwitched(41)) // ------------------------------------------------ Wrestling
            {
            m.Skills[SkillName.Wrestling].Base = val;
                        Container pack = m.Backpack;
                if (pack != null)
                {
                    pack.DropItem( new LeatherGloves() );
                }
            }
            if (info.IsSwitched(42)) // ------------------------------------------------ Cartography
            {
            m.Skills[SkillName.Cartography].Base = val;
                        Container pack = m.Backpack;
                if (pack != null)
                {
                    pack.DropItem( new BlankMap() );
                    pack.DropItem( new BlankMap() );
                    pack.DropItem( new BlankMap() );
                    pack.DropItem( new BlankMap() );
                    pack.DropItem( new Sextant() );
                }
            }
            if (info.IsSwitched(43)) // ------------------------------------------------ DetectHidden
            {
            m.Skills[SkillName.DetectHidden].Base = val;
                        Container pack = m.Backpack;
                if (pack != null)
                {
                    pack.DropItem( new Cloak( 0x455 ) );
                }
            }
            if (info.IsSwitched(44)) // ------------------------------------------------ Inscribe
            {
            m.Skills[SkillName.Inscribe].Base = val;
                        Container pack = m.Backpack;
                if (pack != null)
                {
                    pack.DropItem( new BlankScroll( 10 ) );
                    pack.DropItem( new BlueBook( ) );
                }
            }
            if (info.IsSwitched(45)) // ------------------------------------------------ Peacemaking
            {
            m.Skills[SkillName.Peacemaking].Base = val;
                        Container pack = m.Backpack;
                if (pack != null)
                {
                    pack.DropItem( new Tambourine() );
                }
            }
            if (info.IsSwitched(46)) // ------------------------------------------------ Poisoning
            {
            m.Skills[SkillName.Poisoning].Base = val;
                        Container pack = m.Backpack;
                if (pack != null)
                {
                    pack.DropItem( new LesserPoisonPotion() );
                    pack.DropItem( new LesserPoisonPotion() );
                    pack.DropItem( new LesserPoisonPotion() );
                }
            }
            if (info.IsSwitched(47)) // ------------------------------------------------ Provocation
            {
            m.Skills[SkillName.Provocation].Base = val;
                        Container pack = m.Backpack;
                if (pack != null)
                {
                    pack.DropItem( new BambooFlute() );
                }
            }
            if (info.IsSwitched(48)) // ------------------------------------------------ SpiritSpeak
            {
            m.Skills[SkillName.SpiritSpeak].Base = val;
                        Container pack = m.Backpack;
                if (pack != null)
                {
                    pack.DropItem( new BagOfNecroReagents(50) );
                }
            }
            if (info.IsSwitched(49)) // ------------------------------------------------ Tracking
            {
            m.Skills[SkillName.Tracking].Base = val;
                        Container pack = m.Backpack;
                if (pack != null)
                {
                    pack.DropItem( new BearMask(0x1545) );
                }
            }
            if (info.IsSwitched(50)) // ------------------------------------------------ EvalInt
            {
            m.Skills[SkillName.EvalInt].Base = val;
                        Container pack = m.Backpack;
                if (pack != null)
                {
                    pack.DropItem( new BagOfReagents(50) );
 
                }
            }
            if (info.IsSwitched(51)) // ------------------------------------------------ Forensics
            {
            m.Skills[SkillName.Forensics].Base = val;
                        Container pack = m.Backpack;
                if (pack != null)
                {
                    pack.DropItem( new SkinningKnife(0xEC4) );
                }
            }
            if (info.IsSwitched(52)) // ------------------------------------------------ ItemID
            {
            m.Skills[SkillName.ItemID].Base = val;
                        Container pack = m.Backpack;
                if (pack != null)
                {
                    pack.DropItem( new IDWand(25) );
                }
            }
            if (info.IsSwitched(53)) // ------------------------------------------------ TasteID
            {
            m.Skills[SkillName.TasteID].Base = val;
                        Container pack = m.Backpack;
                if (pack != null)
                {
                    pack.DropItem( new GreaterHealPotion( 1 ) );
                    pack.DropItem( new GreaterAgilityPotion( 1 ) );
                    pack.DropItem( new GreaterStrengthPotion( 1 ) );
                }
            }
            if (info.IsSwitched(55)) // ------------------------------------------------ Hiding
 //           {
 //           m.Skills[SkillName.Hiding].Base = val;
 //                       Container pack = m.Backpack;
 //               if (pack != null)
 //               {
 //                   pack.DropItem( new BagOfSmokeBombs(20) );
 //               }
 //           }
            if (info.IsSwitched(56)) // ------------------------------------------------ Fletching
            {
            m.Skills[SkillName.Fletching].Base = val;
            Container pack = m.Backpack;
                if (pack != null)
                {
                    pack.DropItem( new FletcherTools(0x1022) );
                    pack.DropItem( new Shaft(50) );
                    pack.DropItem( new Feather(50) );
                   
                }
            }
            if (info.IsSwitched(57)) // ------------------------------------------------ Focus
            {
            m.Skills[SkillName.Focus].Base = val;
                        Container pack = m.Backpack;
                if (pack != null)
                {
                    pack.DropItem( new Chessboard(0xFA6) );
                }
            }
            if (info.IsSwitched(58)) // ------------------------------------------------ Throwing
            {
            m.Skills[SkillName.Throwing].Base = val;
            Container pack = m.Backpack;
                if (pack != null)
                {
                    pack.DropItem( new ThrowingDagger() );
                }
                        }
                        if (info.IsSwitched(59)) // ------------------------------------------------ Bushido
                        {
            m.Skills[SkillName.Bushido].Base = val;
            Container pack = m.Backpack;
                if (pack != null)
                {
                    pack.DropItem( new BookOfBushido() );
                }
                        }
                        if (info.IsSwitched(60)) // ------------------------------------------------ Chivalry
                        {
            m.Skills[SkillName.Chivalry].Base = val;
            Container pack = m.Backpack;
                if (pack != null)
                {
                    pack.DropItem( new BookOfChivalry( (UInt64)0x3FF ) );
                }
                        }
            if (info.IsSwitched(61)) // ------------------------------------------------ Imbuing
            {
            m.Skills[SkillName.Imbuing].Base = val;
                        Container pack = m.Backpack;
                if (pack != null)
                {
                    pack.DropItem( new RunicHammer (CraftResource.Valorite) );
                }
            }
            if (info.IsSwitched(62)) // ------------------------------------------------ Mysticism
            {
            m.Skills[SkillName.Mysticism].Base = val;
                        Container pack = m.Backpack;
                if (pack != null)
                {
                    pack.DropItem( new Bone(50) );
                    pack.DropItem( new DaemonBone(50) );
                    pack.DropItem( new FertileDirt(50) );
                   
                }
            }
            if (info.IsSwitched(63)) // ------------------------------------------------ Necromancy
                        {
            m.Skills[SkillName.Necromancy].Base = val;
            Container pack = m.Backpack;
                if (pack != null)
                {
                    pack.DropItem( new NecromancerSpellbook( (UInt64)0xFFFF ) );
                    pack.DropItem( new BagOfNecroReagents(50) );                   
                }
                        }
                        if (info.IsSwitched(64)) // ------------------------------------------------ Ninjitsu
                        {
            m.Skills[SkillName.Ninjitsu].Base = val;
            Container pack = m.Backpack;
                if (pack != null)
                {
                    pack.DropItem( new BookOfNinjitsu() );
                }
                        }
 
            if (info.IsSwitched(65)) // ------------------------------------------------ Spellweaving
            {
            m.Skills[SkillName.Spellweaving].Base = val;
                        Container pack = m.Backpack;
                if (pack != null)
                {
                    new SpellweavingBook((Int64)0xFFFF );
                }
            }
            if (info.IsSwitched(66)) // ------------------------------------------------ Discordance
            {
            m.Skills[SkillName.Discordance].Base = val;
            Container pack = m.Backpack;
                if (pack != null)
                {
                    pack.DropItem( new Harp() );
                }
            }
           
                        m_SkillBallPlus.Delete();
 
                    }
                   
                    break;
                }
               
            }
        }
       
    }
 
    public class SkillBallPlus : Item
    {
        [Constructable]
        public SkillBallPlus() :  base( 0xE73 )
        {
            Weight = 1.0;
            Hue = 1287;
            Name = "Quick Start 7x Skill Booster";
            Movable =  false;
        }
        public override void OnDoubleClick( Mobile m )
        {
 
            if (m.Backpack != null && m.Backpack.GetAmount(typeof(SkillBallPlus)) > 0)
            {
                m.SendMessage("Please choose  your 7 skills to boost.");
                m.CloseGump(typeof(SkillPickGump));
                m.SendGump(new SkillPickGump(this));
            }
            else
                m.SendMessage(" This must be in your backpack to function.");
           
        }
 
        public SkillBallPlus( Serial serial ) : base( serial )
        {
        }
 
    public override void Serialize( GenericWriter writer )
        {
            base.Serialize( writer );
            writer.Write( (int) 1 ); // version
        }
 
    public override void Deserialize( GenericReader reader )
        {
            base.Deserialize( reader );
            int version = reader.ReadInt();
            }
     
    }
 
             
}