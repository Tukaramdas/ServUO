using System;
using Server;
using Server.Items;
using Server.Spells;
using Server.FSHSR;
using System.Collections;
using Server.ContextMenus;
using System.Collections.Generic;

namespace Server.Mobiles
{
	public class TournamentMaster : ContextMenuEntry
	{
		private BassMaster m_Fisher;

		public TournamentMaster( BassMaster fisher ) : base( 6146, 10 )
		{
			m_Fisher = fisher;
		}

		public override void OnClick()
		{
			Mobile from = Owner.From;
			
			if ( DateTime.UtcNow.DayOfWeek == FSHSR.HSRTournamentSystem.TournyOne || DateTime.UtcNow.DayOfWeek == FSHSR.HSRTournamentSystem.TournyTwo || DateTime.UtcNow.DayOfWeek == FSHSR.HSRTournamentSystem.TournyThree )
			{
				if ( DateTime.UtcNow.TimeOfDay < FSHSR.HSRTournamentSystem.StartTimeOne.TimeOfDay - FSHSR.HSRTournamentSystem.WarningDelay && DateTime.UtcNow.DayOfWeek == FSHSR.HSRTournamentSystem.TournyOne )
				{
					m_Fisher.Say( "The tournament will start at {0:t} today.", FSHSR.HSRTournamentSystem.StartTimeOne.ToString() );
				}
				else if ( DateTime.UtcNow.TimeOfDay < FSHSR.HSRTournamentSystem.StartTimeTwo.TimeOfDay - FSHSR.HSRTournamentSystem.WarningDelay && DateTime.UtcNow.DayOfWeek == FSHSR.HSRTournamentSystem.TournyTwo )
				{
					m_Fisher.Say( "The tournament will start at {0:t} today.", FSHSR.HSRTournamentSystem.StartTimeTwo.ToString() );
				}
				else if ( DateTime.UtcNow.TimeOfDay < FSHSR.HSRTournamentSystem.StartTimeThree.TimeOfDay - FSHSR.HSRTournamentSystem.WarningDelay && DateTime.UtcNow.DayOfWeek == FSHSR.HSRTournamentSystem.TournyThree )
				{
					m_Fisher.Say( "The tournament will start at {0:t} today.", FSHSR.HSRTournamentSystem.StartTimeThree.ToString() );
				}
				else if ( DateTime.UtcNow.TimeOfDay < FSHSR.HSRTournamentSystem.StartTimeOne.TimeOfDay && DateTime.UtcNow.DayOfWeek == FSHSR.HSRTournamentSystem.TournyOne )
				{
					m_Fisher.Say( "The tournament will be starting soon! Todays fish is the Toxic Trout these can only be found in dungeon lakes." );
				}
				else if ( DateTime.UtcNow.TimeOfDay < FSHSR.HSRTournamentSystem.StartTimeTwo.TimeOfDay && DateTime.UtcNow.DayOfWeek == FSHSR.HSRTournamentSystem.TournyTwo )
				{
					m_Fisher.Say( "The tournament will be starting soon! Todays fish is the Cotton Candy Swordfish these can only be found in deep wanter." );
				}
				else if ( DateTime.UtcNow.TimeOfDay < FSHSR.HSRTournamentSystem.StartTimeThree.TimeOfDay && DateTime.UtcNow.DayOfWeek == FSHSR.HSRTournamentSystem.TournyThree )
				{
					m_Fisher.Say( "The tournament will be starting soon! Todays fish is the Malas Moonfish these can only be found in Malas." );
				}
				else
				{
					if ( from.InRange( m_Fisher.Location, 3 ) )
						FSHSR.HSRTournamentSystem.CheckTournament( from, m_Fisher, null );
					else
						from.SendMessage( "You need to be closer to talk to them." );
				}
			}
			else
			{
				m_Fisher.Say( "There is a fishing tournament every {0} at {1:t}, {2} at {3:t}, and {4} at {5:t}.", FSHSR.HSRTournamentSystem.TournyOne.ToString(), FSHSR.HSRTournamentSystem.StartTimeOne, FSHSR.HSRTournamentSystem.TournyTwo.ToString(), FSHSR.HSRTournamentSystem.StartTimeTwo, FSHSR.HSRTournamentSystem.TournyThree.ToString(), FSHSR.HSRTournamentSystem.StartTimeThree );
			}
		}
	}
		
    public class BassMaster : BaseVendor
    {
        private readonly List<SBInfo> m_SBInfos = new List<SBInfo>();
        [Constructable]
        public BassMaster() : base("")
        {
            this.SetSkill(SkillName.Fishing, 75.0, 98.0);
        }

        public BassMaster(Serial serial) : base(serial)
        {
        }

        public override NpcGuild NpcGuild
        {
            get
            {
                return NpcGuild.FishermensGuild;
            }
        }
        protected override List<SBInfo> SBInfos
        {
            get
            {
                return this.m_SBInfos;
            }
        }
        
        public override bool OnDragDrop( Mobile from, Item dropped )
        {
        	if ( dropped is ToxicTrout || dropped is CottonCandySwordfish )
        		FSHSR.HSRTournamentSystem.CheckTournament( from, this, dropped );
        	
            return base.OnDragDrop( from, dropped );
        }
                
        public override void InitSBInfo()
        {
            this.m_SBInfos.Add(new SBFisherman());
        }
        
       	public override void AddCustomContextEntries( Mobile from, List<ContextMenuEntry> list )
		{
			list.Add( new TournamentMaster( this ) );
		}
       	
       	public override void GetProperties( ObjectPropertyList list )
		{
			base.GetProperties( list );
			
			list.Add( 1150301, "Tournament Master" );
		}

        public override void InitOutfit()
        {
            base.InitOutfit();

            this.AddItem(new Server.Items.FishingPole());
        }

        public override void Serialize(GenericWriter writer)
        {
            base.Serialize(writer);

            writer.Write((int)0); // version
        }

        public override void Deserialize(GenericReader reader)
        {
            base.Deserialize(reader);

            int version = reader.ReadInt();
        }
    }
}