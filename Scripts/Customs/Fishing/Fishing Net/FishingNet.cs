/*
 * 
 * This fishing net system is blatantly stolen... borrowed... from Unleashed. He submitted a Lobster trap to ServUO on 18MAY2015.
 * Unleashed has a great Lobster Trap and I modified it to look like a net, was not stackable, and has more types of fish drops. 
 * Mainly I wanted mulitple fish per toss (a net is big, right?). It worked fine stackable but the net would not show the count, the
 * lobster traps do. So I made them unstackable.
 * 
 * I am using the list of fish from the High Seas fishing addon (so I will have to remember to include that with this release, in 
 * case you do not have it). The High Seas fishing was by RoninGT 30AUG2013, and cleaned up by Dian 11SEP2014. If you do not want 
 * to use the new fish types it is easy enough to edit the drops - they start around line 315 of this script.
 * 
 * In this zip I am including the original fishing net, that spawned the idea for me (It is labeled "Basic Fishing Net". I do not 
 * know where I found it), the Lobster Trap (by Unleashed), the High Seas Fishing (by RoninGT & Dian), as well as my Fishing Net.
 * 
 * I take no credit for the script as it is just adapted from the work provided by Unleashed.  It took no scripting skill for me,
 * just a lot of editing! I think it is a fun system, hope you enjoy it.  :)
 * 
 * 
 * Tukaram 9MAR2016
 * 
 */
using System;
using System.Collections;
using Server.Network;
using Server.Mobiles;
using Server.Items;
using Server.Gumps;
using Server.Targeting;

namespace Server.Items.Crops
{
	public class EmptyFishingNet : BaseFishingNet
	{
        public override bool CanSetNet { get { return true; } }

		[Constructable]
		public EmptyFishingNet() : this( 1 ) { }

		[Constructable]
        public EmptyFishingNet(int amount)
            : base(0x0DCA)
		{
            Stackable = false;
			Weight = .1;
			Movable = true;
            Name = "Empty Fishing Net";
		}

		public override void OnDoubleClick( Mobile from )
		{
            if (from.Mounted && !NetHelper.CanWorkMounted)
            {
                from.SendMessage( "You cannot deploy a Fishing Net while mounted." );
                return;
            }

            from.BeginTarget(-1, true, TargetFlags.None, new TargetCallback(OnTarget));
		}

        public void OnTarget(Mobile from, object obj)
        {

            IPoint3D p3D = obj as IPoint3D;

            if (p3D == null)
                return;

            Point3D m_pnt = from.Location;
            Map m_map = from.Map;
            int x = p3D.X, y = p3D.Y;
            Point3D p = new Point3D(x, y, m_map.GetAverageZ(x, y));

            if (!IsChildOf(from.Backpack))
            {
                from.SendLocalizedMessage(1042010);
                return;
            }
            else if (!from.InRange(p3D, 4))
            {
                from.SendMessage("The net is too cumbersome to deploy that far away.");
                return;
            }

            ArrayList netshere = NetHelper.CheckNet(p, m_map, 0);
            if (netshere.Count > 0)
            {
                from.SendMessage("This location is too close to another net. ");
                return;
            }

            ArrayList netsnear = NetHelper.CheckNet(p, m_map, 1);
            if ((netsnear.Count > 0))
            {
                from.SendMessage("You can't place any more");
                return;
            }

            if (this.BumpZ)
                ++m_pnt.Z;

            if (!from.Mounted)
                from.Animate(32, 5, 1, true, false, 0);

            from.SendMessage("You deploy the Fishing Net.");

            this.Consume();

            Item item = new NetBuoy(from);
            item.MoveToWorld(p, m_map);
        }

        public EmptyFishingNet(Serial serial)
            : base(serial)
        {
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

	public class NetBuoy : BaseFishingNet
	{
		private static Mobile f_owner;
		public Timer thisTimer;

		[CommandProperty( AccessLevel.GameMaster )]
		public Mobile Owner{ get{ return f_owner; } set{ f_owner = value; } }

		[Constructable]
		public NetBuoy( Mobile Owner ) : base( 0x44CC )
		{
			Movable = false;
			Name = "Net Buoy";
			f_owner = Owner;
			init( this );
		}
        public static void init(NetBuoy netbuoy)
		{
            netbuoy.thisTimer = new NetHelper.CatchTimer(netbuoy, typeof(BobbingNetBouy), netbuoy.Owner);
            netbuoy.thisTimer.Start();
		}

		public override void OnDoubleClick( Mobile from )
		{
            if (from.Mounted && !NetHelper.CanWorkMounted)
            {
                from.SendMessage( "You cannot pull the net from the water when mounted!" );
                return;
            }
			else from.SendMessage( "The net is not ready yet!" );
		}

        public NetBuoy(Serial serial)
            : base(serial)
        {
        }

		public override void Serialize( GenericWriter writer )
        {
            base.Serialize( writer ); writer.Write( (int) 0 );
            writer.Write( f_owner );
        }

		public override void Deserialize( GenericReader reader )
		{
			base.Deserialize( reader );
			int version = reader.ReadInt();
			f_owner = reader.ReadMobile();
			init( this );
		}
	}

    public class BobbingNetBouy : BaseFishingNet
    {
        private Mobile f_owner;
        private DateTime m_lastvisit;
        private Timer m_Timer;

        [Constructable]
		public BobbingNetBouy() : this(null) 
        {
            this.m_Timer = new InternalTimer(this, TimeSpan.FromSeconds(5));
            this.m_Timer.Start();
        }

		[Constructable]
        public BobbingNetBouy(Mobile Owner)
            : base(0x44CB)
		{
			Movable = false;
			Name = "net buoy";
			f_owner = Owner;
			m_lastvisit = DateTime.UtcNow;

            this.m_Timer = new InternalTimer(this, TimeSpan.FromSeconds(5));
            this.m_Timer.Start();
		}

        public override void OnDoubleClick(Mobile from)
        {
            if (f_owner == null || f_owner.Deleted)
                f_owner = from;

            if (from != f_owner)
            {
                from.SendMessage("You realize that the net isn't yours so you leave it alone.");//1116391
                return;
            }

            FullNet net = new FullNet();
            from.AddToBackpack(net);
            this.Delete();
        }

        public BobbingNetBouy(Serial serial) : base(serial) { }

        public override void OnAfterDelete()
        {
            base.OnAfterDelete();

            if (this.m_Timer != null)
                this.m_Timer.Stop();
        }

		public override void Serialize( GenericWriter writer )
		{
			base.Serialize( writer );
			writer.Write( (int) 0 );
			writer.Write( m_lastvisit );
			writer.Write( f_owner );
		}

		public override void Deserialize( GenericReader reader )
		{
			base.Deserialize( reader );
			int version = reader.ReadInt();
			m_lastvisit = reader.ReadDateTime();
			f_owner = reader.ReadMobile();
            this.m_Timer = new InternalTimer(this, TimeSpan.Zero);
            this.m_Timer.Start();
		}

        private void ChangeDirection()
        {
            if (this.ItemID == 0x44CB)
                this.ItemID += 1;
            else if (this.ItemID == 0x44CC)
                this.ItemID += 1;
            else if (this.ItemID == 0x44CD)
                this.ItemID += 1;
            else if (this.ItemID == 0x44CE)
                this.ItemID -= 3;
        }

        private class InternalTimer : Timer
        {
            private readonly BobbingNetBouy netbouy;
            public InternalTimer(BobbingNetBouy b, TimeSpan delay) : base(delay, TimeSpan.FromMinutes(1))
            {
                this.netbouy = b;
                this.Priority = TimerPriority.OneMinute;
            }

            protected override void OnTick()
            {
                if (this.netbouy != null && !this.netbouy.Deleted)
                    this.netbouy.ChangeDirection();
                netbouy.Delete();
            }
        }
    }

	public class FullNet : BaseFishingNet
	{
        private string fullname;
		private DateTime lastpicked;
		private Mobile f_owner;
		private DateTime m_lastvisit;

		[CommandProperty( AccessLevel.GameMaster )]
		public DateTime LastSowerVisit{ get{ return m_lastvisit; } }

		[CommandProperty( AccessLevel.GameMaster )]
		public Mobile Owner{ get{ return f_owner; } set{ f_owner = value; } }

        public string FullName { get { return fullname; } set { fullname = value; } }
		public DateTime LastPick{ get{ return lastpicked; } set{ lastpicked = value; } }

		[Constructable]
		public FullNet() : this(null)
        { }

        [Constructable]
        public FullNet(Mobile Owner)
            : base(0x0DCA)
        {
            Movable = true;
            Stackable = false;
            Name = "Full Fishing Net";
            f_owner = Owner;
            m_lastvisit = DateTime.UtcNow;
        }

        public override void OnDoubleClick(Mobile from)
        {
            switch (Utility.Random(20))
            {
                case 0: from.AddToBackpack(new EmptyFishingNet());
                    from.SendMessage("There is nothing left in the net to remove.");
                    this.Delete();break;
                case 1:
                    from.AddToBackpack(new EmptyFishingNet());
                    from.AddToBackpack(new Fish(Utility.Random(1, 2)));
                    from.AddToBackpack(new SpringDragonfish());
                    from.SendMessage("You remove fish from the net and put it in your pack.");
                    this.Delete(); break;
                case 2:
                   switch (Utility.Random(3))
                    {
                        case 0: from.AddToBackpack(new EmptyFishingNet());
                            from.SendMessage("There is nothing left in the net to remove.");
                            this.Delete(); break;
                        case 1: from.AddToBackpack(new MessageInABottle());
                            from.SendMessage("You remove an MIB from the net and put it in your pack.");
                            this.Delete(); break;
                        case 2:
                            from.AddToBackpack(new EmptyFishingNet());
                            from.AddToBackpack(new Fish(Utility.Random(1, 2)));
                            from.SendMessage("You remove fish from the net and put it in your pack.");
                            this.Delete(); break;
                    }
                    break;
               
                case 3:
                    from.AddToBackpack(new EmptyFishingNet());
                    from.AddToBackpack(new Fish(Utility.Random(1, 2)));
                    from.AddToBackpack(new AbyssalDragonfish());
                    from.SendMessage("You remove fish from the net and put it in your pack.");
                    this.Delete(); break;
                case 4:
                    from.AddToBackpack(new EmptyFishingNet());
                    from.AddToBackpack(new Fish(Utility.Random(1, 2)));
                    from.AddToBackpack(new SpecialFishingNet());
                    from.SendMessage("You remove fish from the net and put it in your pack.");
                    this.Delete(); break;
                case 5:
                    from.AddToBackpack(new EmptyFishingNet());
                    from.AddToBackpack(new Fish(Utility.Random(1, 2)));
                    from.AddToBackpack(new AutumnDragonfish());
                    from.AddToBackpack(new Fish(Utility.Random(1, 2)));
                    from.SendMessage("You remove fish from the net and put it in your pack.");
                    this.Delete(); break;
                case 6:
                  switch (Utility.Random(3))
                    {
                        case 0: from.AddToBackpack(new EmptyFishingNet());
                            from.SendMessage("There is nothing left in the net to remove.");
                            this.Delete(); break;
                        case 1: from.AddToBackpack(new SmallPondAddonDeed());
                            from.SendMessage("You remove Pond Deed from the net and put it in your pack.");
                            this.Delete(); break;
                        case 2:
                            from.AddToBackpack(new EmptyFishingNet());
                            from.AddToBackpack(new Fish(Utility.Random(1, 2)));
                            from.SendMessage("You remove fish from the net and put it in your pack.");
                            this.Delete(); break;
                    }
                    break;
                  
                case 7:
                    switch (Utility.Random(3))
                    {
                        case 0: from.AddToBackpack(new EmptyFishingNet());
                            from.SendMessage("There is nothing left in the net to remove.");
                            this.Delete(); break;
                        case 1:  from.AddToBackpack(new FishingBoots());
                            from.SendMessage("You remove Boots from the net and put it in your pack.");
                            this.Delete(); break;
                        case 2:
                            from.AddToBackpack(new EmptyFishingNet());
                            from.AddToBackpack(new Fish(Utility.Random(1, 2)));
                            from.SendMessage("You remove fish from the net and put it in your pack.");
                            this.Delete(); break;
                    }
                    break; 
                case 8:
                    from.AddToBackpack(new EmptyFishingNet());
                    from.AddToBackpack(new Fish(Utility.Random(1, 2)));
                    from.AddToBackpack(new Fish(Utility.Random(1, 2)));
                    from.SendMessage("You remove fish from the net and put it in your pack.");
                    this.Delete(); break;
                case 9:
                    from.AddToBackpack(new EmptyFishingNet());
                    from.AddToBackpack(new Fish(Utility.Random(1, 2)));
                    from.AddToBackpack(new WinterDragonfish());
                    from.SendMessage("You remove fish from the net and put it in your pack.");
                    this.Delete(); break;
                case 10:
                    from.AddToBackpack(new EmptyFishingNet());
                    from.AddToBackpack(new Fish(Utility.Random(1, 2)));
                    from.AddToBackpack(new SeekerFish());
                    from.SendMessage("You remove fish from the net and put it in your pack.");
                    this.Delete(); break;
                case 11:
                    from.AddToBackpack(new EmptyFishingNet());
                    from.AddToBackpack(new Fish(Utility.Random(1, 2)));
                    from.AddToBackpack(new LavaFish());
                    from.SendMessage("You remove fish from the net and put it in your pack.");
                    this.Delete(); break;
                case 12:
                    from.AddToBackpack(new EmptyFishingNet());
                    from.AddToBackpack(new Fish(Utility.Random(1, 2)));
                    from.AddToBackpack(new CutthroatTrout());
                    from.SendMessage("You remove fish from the net and put it in your pack.");
                    this.Delete(); break;
                case 13:
                    from.AddToBackpack(new EmptyFishingNet());
                    from.AddToBackpack(new Fish(Utility.Random(1, 2)));
                    from.AddToBackpack(new KokaneeSalmon());
                    from.SendMessage("You remove fish from the net and put it in your pack.");
                    this.Delete(); break;
                case 14:
                    from.AddToBackpack(new EmptyFishingNet());
                    from.AddToBackpack(new Fish(Utility.Random(1, 2)));
                    from.AddToBackpack(new PumpkinseedSunfish());
                    from.SendMessage("You remove fish from the net and put it in your pack.");
                    this.Delete(); break;
                case 15:
                  switch (Utility.Random(3))
                    {
                        case 0: from.AddToBackpack(new EmptyFishingNet());
                            from.SendMessage("There is nothing left in the net to remove.");
                            this.Delete(); break;
                        case 1: from.AddToBackpack(new EmptyFishingNet());
                            from.AddToBackpack(new Fish(Utility.Random(1, 2)));
                            from.AddToBackpack(new CaptainBlackheartsFishingPole());
                            from.SendMessage("You remove fish, and Fishing Pole from the net and put it in your pack.");
                            this.Delete(); break;
                        case 2:
                            from.AddToBackpack(new EmptyFishingNet());
                            from.AddToBackpack(new Fish(Utility.Random(1, 2)));
                            from.SendMessage("You remove fish from the net and put it in your pack.");
                            this.Delete(); break;
                    }
                    break;
                   
                case 16:
                    from.AddToBackpack(new EmptyFishingNet());
                    from.AddToBackpack(new Fish(Utility.Random(1, 2)));
                    from.AddToBackpack(new MahiMahi());
                    from.SendMessage("You remove fish from the net and put it in your pack.");
                    this.Delete(); break;
                case 17:
                    from.AddToBackpack(new EmptyFishingNet());
                    from.AddToBackpack(new Fish(Utility.Random(1, 2)));
                    from.AddToBackpack(new RedDrum());
                    from.SendMessage("You remove fish from the net and put it in your pack.");
                    this.Delete(); break;
                case 18:
                    from.AddToBackpack(new EmptyFishingNet());
                    from.AddToBackpack(new Fish(Utility.Random(1, 2)));
                    from.AddToBackpack(new SnaggletoothBass());
                    from.SendMessage("You remove fish from the net and put it in your pack.");
                    this.Delete(); break;
                case 19:
                    from.AddToBackpack(new EmptyFishingNet());
                    from.AddToBackpack(new Fish(Utility.Random(1, 2)));
                    from.AddToBackpack(new Fish(Utility.Random(1, 2)));
                    from.AddToBackpack(new Fish(Utility.Random(1, 2)));
                    from.AddToBackpack(new ReaperFish());
                    from.SendMessage("You remove fish from the net and put it in your pack.");
                    this.Delete(); break;
            }
        }

        public FullNet(Serial serial) : base(serial) { }

		public override void Serialize( GenericWriter writer )
		{
			base.Serialize( writer );
			writer.Write( (int) 0 );
			writer.Write( m_lastvisit );
			writer.Write( f_owner );
		}

		public override void Deserialize( GenericReader reader )
		{
			base.Deserialize( reader );
			int version = reader.ReadInt();
			m_lastvisit = reader.ReadDateTime();
			f_owner = reader.ReadMobile();
            //init(this, true);
		}
	}
}