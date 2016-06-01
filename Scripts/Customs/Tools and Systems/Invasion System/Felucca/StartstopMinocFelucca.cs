using System;
using Server;
using Server.Items;
using Server.Mobiles;
using Server.Network; 
using System.Collections;
using Server.Regions;

namespace Server.Gumps
{
	public class StartStopMinocfel : Gump
	{
		public static readonly bool DummyMessage = false;

		private Mobile m_Mobile;
		public StartStopMinocfel(Mobile from) : base(0,0)
		{
			m_Mobile = from;
			Closable = false;
			Dragable = true;

			AddPage(0);

			AddImage( 112, 73, 39);
			AddButton( 135, 123, 9804, 9806, 1, GumpButtonType.Reply, 1 );
			AddButton( 138, 194, 9804, 9806, 2, GumpButtonType.Reply, 2 );
			AddButton( 277, 311, 2453, 2455, 0, GumpButtonType.Reply, 0 );
			AddLabel( 216, 140, 0, "Start an Invasion");
			AddLabel( 218, 208, 0, "Stop an Invasion");

		}

		public override void OnResponse( NetState state, RelayInfo info )
		{
			Mobile from = state.Mobile;
			switch ( info.ButtonID ) 
		{ 
		case 0:
		{ 
                                    from.CloseGump( typeof( StartStopMinocfel ) ); 
		        from.SendGump( new CityInvasion( from ) );
                                    break;  
                             }  
		case 1:
		{


			Point3D loc = new Point3D( 568, 1311, 0 );

			WayPoint point = new WayPoint();
			WayPoint point1 = new WayPoint();
			WayPoint point2 = new WayPoint();
			WayPoint point3 = new WayPoint();
			WayPoint point4 = new WayPoint();
			WayPoint point5 = new WayPoint();
			WayPoint point6 = new WayPoint();
			WayPoint point7 = new WayPoint();
			WayPoint point8 = new WayPoint();
			WayPoint point9 = new WayPoint();

			WayPoint point10 = new WayPoint();
			WayPoint point11 = new WayPoint();
			WayPoint point12 = new WayPoint();
			WayPoint point13 = new WayPoint();
			WayPoint point14 = new WayPoint();
			WayPoint point15 = new WayPoint();
			WayPoint point16 = new WayPoint();
			WayPoint point17 = new WayPoint();
			WayPoint point18 = new WayPoint();
			WayPoint point19 = new WayPoint();

			WayPoint point20 = new WayPoint();
			WayPoint point21 = new WayPoint();
			WayPoint point22 = new WayPoint();
			WayPoint point23 = new WayPoint();
			WayPoint point24 = new WayPoint();
			WayPoint point25 = new WayPoint();
			WayPoint point26 = new WayPoint();
			WayPoint point27 = new WayPoint();
			WayPoint point28 = new WayPoint();
			WayPoint point29 = new WayPoint();

			WayPoint point30 = new WayPoint();
			WayPoint point31 = new WayPoint();
			WayPoint point32 = new WayPoint();
			WayPoint point33 = new WayPoint();
			WayPoint point34 = new WayPoint();
			WayPoint point35 = new WayPoint();
			WayPoint point36 = new WayPoint();
			WayPoint point37 = new WayPoint();
			WayPoint point38 = new WayPoint();
			WayPoint point39 = new WayPoint();

			WayPoint point40 = new WayPoint();
			WayPoint point41 = new WayPoint();
			WayPoint point42 = new WayPoint();
			WayPoint point43 = new WayPoint();
			WayPoint point44 = new WayPoint();
			WayPoint point45 = new WayPoint();
			WayPoint point46 = new WayPoint();
			WayPoint point47 = new WayPoint();
			WayPoint point48 = new WayPoint();
			WayPoint point49 = new WayPoint();

			WayPoint point50 = new WayPoint();
			WayPoint point51 = new WayPoint();
			WayPoint point52 = new WayPoint();
			WayPoint point53 = new WayPoint();
			WayPoint point54 = new WayPoint();
			WayPoint point55 = new WayPoint();
			WayPoint point56 = new WayPoint();
			WayPoint point57 = new WayPoint();
			WayPoint point58 = new WayPoint();
			WayPoint point59 = new WayPoint();

			WayPoint point60 = new WayPoint();
			WayPoint point61 = new WayPoint();
			WayPoint point62 = new WayPoint();
			WayPoint point63 = new WayPoint();
			WayPoint point64 = new WayPoint();
			WayPoint point65 = new WayPoint();
			WayPoint point66 = new WayPoint();
			WayPoint point67 = new WayPoint();
			WayPoint point68 = new WayPoint();
			WayPoint point69 = new WayPoint();

			WayPoint point70 = new WayPoint();
			WayPoint point71 = new WayPoint();
			WayPoint point72 = new WayPoint();
			WayPoint point73 = new WayPoint();
			WayPoint point74 = new WayPoint();
			WayPoint point75 = new WayPoint();
			WayPoint point76 = new WayPoint();
			WayPoint point77 = new WayPoint();
			WayPoint point78 = new WayPoint();
			WayPoint point79 = new WayPoint();
			WayPoint point80 = new WayPoint();
			WayPoint point81 = new WayPoint();

			WayPoint point82 = new WayPoint();
			WayPoint point83 = new WayPoint();
			WayPoint point84 = new WayPoint();
			WayPoint point85 = new WayPoint();
			WayPoint point86 = new WayPoint();
			WayPoint point87 = new WayPoint();
			WayPoint point88 = new WayPoint();
			WayPoint point89 = new WayPoint();
			WayPoint point90 = new WayPoint();
			WayPoint point91 = new WayPoint();
			WayPoint point92 = new WayPoint();
			WayPoint point93 = new WayPoint();

			WayPoint point94 = new WayPoint();
			WayPoint point95 = new WayPoint();
			WayPoint point96 = new WayPoint();
			WayPoint point97 = new WayPoint();
			WayPoint point98 = new WayPoint();
			WayPoint point99 = new WayPoint();
			WayPoint point100 = new WayPoint();
			WayPoint point101 = new WayPoint();
			WayPoint point102 = new WayPoint();
			WayPoint point103 = new WayPoint();
			WayPoint point104 = new WayPoint();
			WayPoint point105 = new WayPoint();

			WayPoint point106 = new WayPoint();
			WayPoint point107 = new WayPoint();
			WayPoint point108 = new WayPoint();
			WayPoint point109 = new WayPoint();
			WayPoint point110 = new WayPoint();
			WayPoint point111 = new WayPoint();
			WayPoint point112 = new WayPoint();
			WayPoint point113 = new WayPoint();
			WayPoint point114 = new WayPoint();
			WayPoint point115 = new WayPoint();
			WayPoint point116 = new WayPoint();
			WayPoint point117 = new WayPoint();
			WayPoint point118 = new WayPoint();
			WayPoint point119 = new WayPoint();
			WayPoint point120 = new WayPoint();

			point.Name = "MinocInvasionFelucca";
			point1.Name = "MinocInvasionFelucca";
			point2.Name = "MinocInvasionFelucca";
			point3.Name = "MinocInvasionFelucca";
			point4.Name = "MinocInvasionFelucca";
			point5.Name = "MinocInvasionFelucca";
			point6.Name = "MinocInvasionFelucca";
			point7.Name = "MinocInvasionFelucca";
			point8.Name = "MinocInvasionFelucca";
			point9.Name = "MinocInvasionFelucca";

			point10.Name = "MinocInvasionFelucca";
			point11.Name = "MinocInvasionFelucca";
			point12.Name = "MinocInvasionFelucca";
			point13.Name = "MinocInvasionFelucca";
			point14.Name = "MinocInvasionFelucca";
			point15.Name = "MinocInvasionFelucca";
			point16.Name = "MinocInvasionFelucca";
			point17.Name = "MinocInvasionFelucca";
			point18.Name = "MinocInvasionFelucca";
			point19.Name = "MinocInvasionFelucca";

			point20.Name = "MinocInvasionFelucca";
			point21.Name = "MinocInvasionFelucca";
			point22.Name = "MinocInvasionFelucca";
			point23.Name = "MinocInvasionFelucca";
			point24.Name = "MinocInvasionFelucca";
			point25.Name = "MinocInvasionFelucca";
			point26.Name = "MinocInvasionFelucca";
			point27.Name = "MinocInvasionFelucca";
			point28.Name = "MinocInvasionFelucca";
			point29.Name = "MinocInvasionFelucca";

			point30.Name = "MinocInvasionFelucca";
			point31.Name = "MinocInvasionFelucca";
			point32.Name = "MinocInvasionFelucca";
			point33.Name = "MinocInvasionFelucca";
			point34.Name = "MinocInvasionFelucca";
			point35.Name = "MinocInvasionFelucca";
			point36.Name = "MinocInvasionFelucca";
			point37.Name = "MinocInvasionFelucca";
			point38.Name = "MinocInvasionFelucca";
			point39.Name = "MinocInvasionFelucca";

			point40.Name = "MinocInvasionFelucca";
			point41.Name = "MinocInvasionFelucca";
			point42.Name = "MinocInvasionFelucca";
			point43.Name = "MinocInvasionFelucca";
			point44.Name = "MinocInvasionFelucca";
			point45.Name = "MinocInvasionFelucca";
			point46.Name = "MinocInvasionFelucca";
			point47.Name = "MinocInvasionFelucca";
			point48.Name = "MinocInvasionFelucca";
			point49.Name = "MinocInvasionFelucca";

			point50.Name = "MinocInvasionFelucca";
			point51.Name = "MinocInvasionFelucca";
			point52.Name = "MinocInvasionFelucca";
			point53.Name = "MinocInvasionFelucca";
			point54.Name = "MinocInvasionFelucca";
			point55.Name = "MinocInvasionFelucca";
			point56.Name = "MinocInvasionFelucca";
			point57.Name = "MinocInvasionFelucca";
			point58.Name = "MinocInvasionFelucca";
			point59.Name = "MinocInvasionFelucca";

			point60.Name = "MinocInvasionFelucca";
			point61.Name = "MinocInvasionFelucca";
			point62.Name = "MinocInvasionFelucca";
			point63.Name = "MinocInvasionFelucca";
			point64.Name = "MinocInvasionFelucca";
			point65.Name = "MinocInvasionFelucca";
			point66.Name = "MinocInvasionFelucca";
			point67.Name = "MinocInvasionFelucca";
			point68.Name = "MinocInvasionFelucca";
			point69.Name = "MinocInvasionFelucca";

			point70.Name = "MinocInvasionFelucca";
			point71.Name = "MinocInvasionFelucca";
			point72.Name = "MinocInvasionFelucca";
			point73.Name = "MinocInvasionFelucca";
			point74.Name = "MinocInvasionFelucca";
			point75.Name = "MinocInvasionFelucca";
			point76.Name = "MinocInvasionFelucca";
			point77.Name = "MinocInvasionFelucca";
			point78.Name = "MinocInvasionFelucca";
			point79.Name = "MinocInvasionFelucca";
			point80.Name = "MinocInvasionFelucca";
			point81.Name = "MinocInvasionFelucca";

			point82.Name = "MinocInvasionFelucca";
			point83.Name = "MinocInvasionFelucca";
			point84.Name = "MinocInvasionFelucca";
			point85.Name = "MinocInvasionFelucca";
			point86.Name = "MinocInvasionFelucca";
			point87.Name = "MinocInvasionFelucca";
			point88.Name = "MinocInvasionFelucca";
			point89.Name = "MinocInvasionFelucca";
			point90.Name = "MinocInvasionFelucca";
			point91.Name = "MinocInvasionFelucca";
			point92.Name = "MinocInvasionFelucca";
			point93.Name = "MinocInvasionFelucca";

			point94.Name = "MinocInvasionFelucca";
			point95.Name = "MinocInvasionFelucca";
			point96.Name = "MinocInvasionFelucca";
			point97.Name = "MinocInvasionFelucca";
			point98.Name = "MinocInvasionFelucca";
			point99.Name = "MinocInvasionFelucca";
			point100.Name = "MinocInvasionFelucca";
			point101.Name = "MinocInvasionFelucca";
			point102.Name = "MinocInvasionFelucca";
			point103.Name = "MinocInvasionFelucca";
			point104.Name = "MinocInvasionFelucca";
			point105.Name = "MinocInvasionFelucca";

			point106.Name = "MinocInvasionFelucca";
			point107.Name = "MinocInvasionFelucca";
			point108.Name = "MinocInvasionFelucca";
			point109.Name = "MinocInvasionFelucca";
			point110.Name = "MinocInvasionFelucca";
			point111.Name = "MinocInvasionFelucca";
			point112.Name = "MinocInvasionFelucca";
			point113.Name = "MinocInvasionFelucca";
			point114.Name = "MinocInvasionFelucca";
			point115.Name = "MinocInvasionFelucca";
			point116.Name = "MinocInvasionFelucca";
			point117.Name = "MinocInvasionFelucca";
			point118.Name = "MinocInvasionFelucca";
			point119.Name = "MinocInvasionFelucca";
			point120.Name = "MinocInvasionFelucca";

			GuardedRegion reg = from.Region as GuardedRegion;

			if ( reg == null )
			{
				from.SendMessage( 33, "You are not in the guarded part of Minoc, Felucca." );
				from.SendMessage( 33, "You will have to go there and use [toggleguarded to turn the guards off." );
			}
			 else  if ( reg.Disabled )
                                           {
				from.SendMessage( 3, "The guards in this region have not changed." );
                                           }
			 else if ( !reg.Disabled )
                                           {
				reg.Disabled = !reg.Disabled;
			              from.SendMessage( 3, "The guards in this region have been disabled." );
                                           }
                                           if ( DummyMessage  && reg != null )
                                          {
				from.SendMessage( 33, "If you are not in the guarded part of Magincia, Felucca." );
				from.SendMessage( 33, "You will have to go there and use [toggleguarded to turn the guards off." );
                                          }
			Spawner spawner1 = new Spawner( 4, 5, 15, 20, 10, "JukaLord" );
			spawner1.MoveToWorld( new Point3D(  2575, 647, 0  ), Map.Felucca );
			spawner1.WayPoint = point;
			point.MoveToWorld( new Point3D(  2518, 581, 0  ), Map.Felucca );
			point.NextPoint = point1;
			point1.MoveToWorld( new Point3D(  2518, 530, 0  ), Map.Felucca );
			point1.NextPoint = point2;
			point2.MoveToWorld( new Point3D(  2510, 530, 0  ), Map.Felucca );
			point2.NextPoint = point3;
			point3.MoveToWorld( new Point3D(  2510, 518, 0  ), Map.Felucca );
			point3.NextPoint = point4;
			point4.MoveToWorld( new Point3D(  2490, 518, 0  ), Map.Felucca );
			point4.NextPoint = point5;
			point5.MoveToWorld( new Point3D(  2489, 545, 0  ), Map.Felucca );
			point5.NextPoint = point6;
			point6.MoveToWorld( new Point3D(  2433, 545, 0  ), Map.Felucca );
			point6.NextPoint = point7;
			point7.MoveToWorld( new Point3D(   2489, 545, 0  ), Map.Felucca );
			point7.NextPoint = point8;
			point8.MoveToWorld( new Point3D(  2489, 482, 15  ), Map.Felucca );
			point8.NextPoint = point9;
			point9.MoveToWorld( new Point3D(  2490, 518, 0  ), Map.Felucca );
			point9.NextPoint = point10;
			point10.MoveToWorld( new Point3D(  2505, 518, 0  ), Map.Felucca );
			point10.NextPoint = point11;
			point11.MoveToWorld( new Point3D(  2518, 530, 0  ), Map.Felucca );
			point11.NextPoint = point;
          			spawner1.Name = "MinocInvasionFelucca";
			spawner1.Respawn();
   
   
                        Spawner spawner9 = new Spawner( 10, 20, 20, 20, 20, "JukaWarrior" );
			spawner9.MoveToWorld( new Point3D(  2575, 647, 0  ), Map.Felucca );
                        spawner9.Name = "MinocInvasionFelucca";
			spawner9.Respawn();
   
   
			Spawner spawner2 = new Spawner( 4, 5, 15, 20, 15, "JukaWarrior" );
			spawner2.MoveToWorld( new Point3D(  2694, 466, 18  ), Map.Felucca );
			spawner2.WayPoint = point12;
			point12.MoveToWorld( new Point3D(  2662, 469, 15  ), Map.Felucca );
			point12.NextPoint = point13;
			point13.MoveToWorld( new Point3D(  2625, 469, 15  ), Map.Felucca );
			point13.NextPoint = point14;
			point14.MoveToWorld( new Point3D(  2613, 507, 15  ), Map.Felucca );
			point14.NextPoint = point15;
			point15.MoveToWorld( new Point3D(  2558, 513, 15  ), Map.Felucca );
			point15.NextPoint = point16;
			point16.MoveToWorld( new Point3D(  2558, 496, 0  ), Map.Felucca );
			point16.NextPoint = point17;
			point17.MoveToWorld( new Point3D(  2576, 479, 0  ), Map.Felucca );
			point17.NextPoint = point18;
			point18.MoveToWorld( new Point3D(  2558, 496, 0  ), Map.Felucca );
			point18.NextPoint = point19;
			point19.MoveToWorld( new Point3D(  2558, 528, 15  ), Map.Felucca );
			point19.NextPoint = point20;
			point20.MoveToWorld( new Point3D(  2569, 537, 15  ), Map.Felucca );
			point20.NextPoint = point21;
			point21.MoveToWorld( new Point3D(  2599, 531, 15  ), Map.Felucca );
			point21.NextPoint = point22;
			point22.MoveToWorld( new Point3D(  2599, 504, 0  ), Map.Felucca );
			point22.NextPoint = point23;
			point23.MoveToWorld( new Point3D(  2606, 502, 0  ), Map.Felucca );
			point23.NextPoint = point24;
			point24.MoveToWorld( new Point3D(  2604, 496, 20  ), Map.Felucca );
			point24.NextPoint = point25;
			point25.MoveToWorld( new Point3D(  2578, 500, 22  ), Map.Felucca );
			point25.NextPoint = point26;
			point26.MoveToWorld( new Point3D(  2582, 493, 40  ), Map.Felucca );
			point26.NextPoint = point27;
			point27.MoveToWorld( new Point3D(  2609, 469, 40  ), Map.Felucca );
			point27.NextPoint = point28;
			point28.MoveToWorld( new Point3D(  2602, 466, 60  ), Map.Felucca );
			point28.NextPoint = point29;
			point29.MoveToWorld( new Point3D(  2604, 453, 60  ), Map.Felucca );
			point29.NextPoint = point30;
			point30.MoveToWorld( new Point3D(  2591, 457, 60  ), Map.Felucca );
			point30.NextPoint = point31;
			point31.MoveToWorld( new Point3D(  2604, 453, 60  ), Map.Felucca );
			point31.NextPoint = point32;
			point32.MoveToWorld( new Point3D(  2602, 466, 60  ), Map.Felucca );
			point32.NextPoint = point33;
			point33.MoveToWorld( new Point3D(  2609, 469, 40  ), Map.Felucca );
			point33.NextPoint = point34;
			point34.MoveToWorld( new Point3D(  2582, 493, 40   ), Map.Felucca );
			point34.NextPoint = point35;
			point35.MoveToWorld( new Point3D(  2578, 500, 22  ), Map.Felucca );
			point35.NextPoint = point36;
			point36.MoveToWorld( new Point3D(  2604, 496, 20  ), Map.Felucca );
			point36.NextPoint = point37;
			point37.MoveToWorld( new Point3D(  2606, 502, 0  ), Map.Felucca );
			point37.NextPoint = point14;
			spawner2.Name = "MinocInvasionFelucca";
			spawner2.Respawn();
   
   
                        Spawner spawner10 = new Spawner( 6, 20, 20, 20, 20, "JukaLord" );
			spawner10.MoveToWorld( new Point3D( 2694, 466, 18 ), Map.Felucca );
                        spawner10.Name = "MinocInvasionFelucca";
			spawner10.Respawn();
   
   
			Spawner spawner3 = new Spawner( 6, 5, 15, 20, 10, "JukaWarrior" );
			spawner3.MoveToWorld( new Point3D(  2555, 370, 15  ), Map.Felucca );
			spawner3.WayPoint = point38;
			point38.MoveToWorld( new Point3D(  2532, 389, 15  ), Map.Felucca );
			point38.NextPoint = point39;
			point39.MoveToWorld( new Point3D(  2510, 386, 15  ), Map.Felucca );
			point39.NextPoint = point40;
			point40.MoveToWorld( new Point3D(  2500, 419, 15  ), Map.Felucca );
			point40.NextPoint = point41;
			point41.MoveToWorld( new Point3D(  2445, 419, 15  ), Map.Felucca );
			point41.NextPoint = point42;
			point42.MoveToWorld( new Point3D(  2445, 447, 15  ), Map.Felucca );
			point42.NextPoint = point43;
			point43.MoveToWorld( new Point3D(  2501, 444, 15  ), Map.Felucca );
			point43.NextPoint = point44;
			point44.MoveToWorld( new Point3D(  2501, 485, 15  ), Map.Felucca );
			point44.NextPoint = point45;
			point45.MoveToWorld( new Point3D(  2469, 483, 15  ), Map.Felucca );
			point45.NextPoint = point46;
			point46.MoveToWorld( new Point3D(  2469, 461, 15  ), Map.Felucca );
			point46.NextPoint = point47;
			point47.MoveToWorld( new Point3D(  2476, 461, 15  ), Map.Felucca );
			point47.NextPoint = point48;
			point48.MoveToWorld( new Point3D(  2476, 435, 15  ), Map.Felucca );
			point48.NextPoint = point49;
			point49.MoveToWorld( new Point3D(  2467, 435, 15  ), Map.Felucca );
			point49.NextPoint = point50;
			point50.MoveToWorld( new Point3D(  2467, 418, 15  ), Map.Felucca );
			point50.NextPoint = point51;
			point51.MoveToWorld( new Point3D(  2500, 419, 15  ), Map.Felucca );
			point51.NextPoint = point39;
			spawner3.Name = "MinocInvasionFelucca";
			spawner3.Respawn();
   
   
                        Spawner spawner11 = new Spawner( 8, 20, 20, 20, 20, "JukaMage" );
			spawner11.MoveToWorld( new Point3D(  2555, 370, 15  ), Map.Felucca );
                        spawner11.Name = "MinocInvasionFelucca";
			spawner11.Respawn();
   
   
			Spawner spawner4 = new Spawner( 4, 5, 15, 20, 50, "JukaMage" );
			spawner4.MoveToWorld( new Point3D(  2598, 747, 0  ), Map.Felucca );
			spawner4.WayPoint = point52;
			point52.MoveToWorld( new Point3D(  2579, 690, 0  ), Map.Felucca );
			point52.NextPoint = point53;
			point53.MoveToWorld( new Point3D(  2561, 623, 0  ), Map.Felucca );
			point53.NextPoint = point54;
			point54.MoveToWorld( new Point3D(  2513, 620, 0  ), Map.Felucca );
			point54.NextPoint = point55;
			point55.MoveToWorld( new Point3D(  2517, 562, 0  ), Map.Felucca );
			point55.NextPoint = point56;
			point56.MoveToWorld( new Point3D(  2486, 564, 5  ), Map.Felucca );
			point56.NextPoint = point57;
			point57.MoveToWorld( new Point3D(  2486, 544, 0  ), Map.Felucca );
			point57.NextPoint = point58;
			point58.MoveToWorld( new Point3D(  2465, 543, 0  ), Map.Felucca );
			point58.NextPoint = point59;
			point59.MoveToWorld( new Point3D(  2465, 528, 15  ), Map.Felucca );
			point59.NextPoint = point60;
			point60.MoveToWorld( new Point3D(  2455, 528, 15  ), Map.Felucca );
			point60.NextPoint = point61;
			point61.MoveToWorld( new Point3D(  2455, 513, 15  ), Map.Felucca );
			point61.NextPoint = point62;
			point62.MoveToWorld( new Point3D(  2475, 513, 15  ), Map.Felucca );
			point62.NextPoint = point63;
			point63.MoveToWorld( new Point3D(  2475, 528, 15  ), Map.Felucca );
			point63.NextPoint = point60;
			spawner4.Name = "MinocInvasionFelucca";
			spawner4.Respawn();
   
                        Spawner spawner12 = new Spawner( 6, 20, 20, 20, 20, "JukaLord" );
			spawner12.MoveToWorld( new Point3D(  2598, 747, 0  ), Map.Felucca );
                        spawner12.Name = "MinocInvasionFelucca";
			spawner12.Respawn();
   
   
			Spawner spawner5 = new Spawner( 6, 5, 15, 20, 4, "JukaWarrior" );
			spawner5.MoveToWorld( new Point3D(  2579, 376, 5  ), Map.Felucca );
			spawner5.WayPoint = point65;
			point64.MoveToWorld( new Point3D(  2579, 398, 15  ), Map.Felucca );
			point64.NextPoint = point65;
			point65.MoveToWorld( new Point3D(  2623, 437, 15  ), Map.Felucca );
			point65.NextPoint = point66;
			point66.MoveToWorld( new Point3D(  2617, 506, 15  ), Map.Felucca );
			point66.NextPoint = point67;
			point67.MoveToWorld( new Point3D(  2562, 513, 15  ), Map.Felucca );
			point67.NextPoint = point68;
			point68.MoveToWorld( new Point3D(  2551, 501, 15  ), Map.Felucca );
			point68.NextPoint = point69;
			point69.MoveToWorld( new Point3D(  2525, 501, 15  ), Map.Felucca );
			point69.NextPoint = point70;
			point70.MoveToWorld( new Point3D(  2525, 516, 0  ), Map.Felucca );
			point70.NextPoint = point71;
			point71.MoveToWorld( new Point3D(  2489, 516, 0  ), Map.Felucca );
			point71.NextPoint = point72;
			point72.MoveToWorld( new Point3D(  2489, 482, 15  ), Map.Felucca );
			point72.NextPoint = point73;
			point73.MoveToWorld( new Point3D(  2500, 484, 15  ), Map.Felucca );
			point73.NextPoint = point74;
			point74.MoveToWorld( new Point3D(  2500, 442, 15  ), Map.Felucca );
			point74.NextPoint = point75;
			point75.MoveToWorld( new Point3D(  2514, 442, 15  ), Map.Felucca );
			point75.NextPoint = point76;
			point76.MoveToWorld( new Point3D(  2514, 419, 15  ), Map.Felucca );
			point76.NextPoint = point77;
			point77.MoveToWorld( new Point3D(  2445, 419, 15  ), Map.Felucca );
			point77.NextPoint = point78;
			point78.MoveToWorld( new Point3D(  2444, 444, 15  ), Map.Felucca );
			point78.NextPoint = point79;
			point79.MoveToWorld( new Point3D(  2531, 444, 15  ), Map.Felucca );
			point79.NextPoint = point69;
			spawner5.Name = "MinocInvasionFelucca";
			spawner5.Respawn();
   
                        Spawner spawner13 = new Spawner( 10, 20, 20, 20, 20, "JukaWarrior" );
	             	spawner13.MoveToWorld( new Point3D(  2579, 376, 5  ), Map.Felucca );
                        spawner13.Name = "MinocInvasionFelucca";
			spawner13.Respawn();
   
			Spawner spawner6 = new Spawner( 1, 5, 15, 20, 0, "JukaLord" );
			spawner6.MoveToWorld( new Point3D(  2420, 420, 15  ), Map.Felucca );
			spawner6.WayPoint = point80;
			point80.MoveToWorld( new Point3D(  2489, 419, 15  ), Map.Felucca );
			point80.NextPoint = point81;
			point81.MoveToWorld( new Point3D(  2491, 442, 15  ), Map.Felucca );
			point81.NextPoint = point82;
			point82.MoveToWorld( new Point3D(  2476, 442, 15  ), Map.Felucca );
			point82.NextPoint = point83;
			point83.MoveToWorld( new Point3D(  2475, 460, 15  ), Map.Felucca );
			point83.NextPoint = point84;
			point84.MoveToWorld( new Point3D(  2467, 460, 15  ), Map.Felucca );
			point84.NextPoint = point85;
			point85.MoveToWorld( new Point3D(  2469, 481, 15  ), Map.Felucca );
			point85.NextPoint = point86;
			point86.MoveToWorld( new Point3D(  2491, 481, 15  ), Map.Felucca );
			point86.NextPoint = point87;
			point87.MoveToWorld( new Point3D(  2488, 564, 5  ), Map.Felucca );
			point87.NextPoint = point88;
			point88.MoveToWorld( new Point3D(  2514, 561, 0  ), Map.Felucca );
			point88.NextPoint = point89;
			point89.MoveToWorld( new Point3D(  2516, 529, 0  ), Map.Felucca );
			point89.NextPoint = point90;
			point90.MoveToWorld( new Point3D(  2489, 529, 0  ), Map.Felucca );
			point90.NextPoint = point91;
			point91.MoveToWorld( new Point3D(  2489, 493, 15  ), Map.Felucca );
			point91.NextPoint = point92;
			point92.MoveToWorld( new Point3D(  2504, 482, 15  ), Map.Felucca );
			point92.NextPoint = point80;
			spawner6.Name = "MinocInvasionFelucca";
			spawner6.Respawn();
   
                        Spawner spawner14 = new Spawner( 6, 20, 20, 20, 20, "Swampdragon" );
			spawner14.MoveToWorld( new Point3D(  2420, 420, 15  ), Map.Felucca );
                        spawner14.Name = "MinocInvasionFelucca";
			spawner14.Respawn();
   
			Spawner spawner7 = new Spawner( 6, 5, 15, 20, 0, "JukaMage" );
			spawner7.MoveToWorld( new Point3D(  2534, 624, 0  ), Map.Felucca );
			spawner7.WayPoint = point93;
			point93.MoveToWorld( new Point3D(  2513, 620, 0  ), Map.Felucca );
			point93.NextPoint = point94;
			point94.MoveToWorld( new Point3D(  2517, 562, 0  ), Map.Felucca );
			point94.NextPoint = point95;
			point95.MoveToWorld( new Point3D(  2504, 562, 0  ), Map.Felucca );
			point95.NextPoint = point96;
			point96.MoveToWorld( new Point3D(  2504, 547, 0  ), Map.Felucca );
			point96.NextPoint = point97;
			point97.MoveToWorld( new Point3D(  2501, 547, 0  ), Map.Felucca );
			point97.NextPoint = point98;
			point98.MoveToWorld( new Point3D(   2504, 547, 0  ), Map.Felucca );
			point98.NextPoint = point99;
			point99.MoveToWorld( new Point3D(  2504, 562, 0  ), Map.Felucca );
			point99.NextPoint = point100;
			point100.MoveToWorld( new Point3D(  2492, 562, 0  ), Map.Felucca );
			point100.NextPoint = point101;
			point101.MoveToWorld( new Point3D(  2491, 540, 0  ), Map.Felucca );
			point101.NextPoint = point102;
			point102.MoveToWorld( new Point3D(  2517, 539, 0  ), Map.Felucca );
			point102.NextPoint = point94;
			spawner7.Name = "MinocInvasionFelucca";
			spawner7.Respawn();
   
   
                        Spawner spawner15 = new Spawner( 5, 20, 20, 20, 20, "JukaMage" );
			spawner15.MoveToWorld( new Point3D(  2534, 624, 0  ), Map.Felucca );
                        spawner15.Name = "MinocInvasionFelucca";
			spawner15.Respawn();
   
                        Spawner spawner18 = new Spawner( 5, 20, 20, 20, 20, "JukaLord" );
			spawner18.MoveToWorld( new Point3D(  2534, 624, 0  ), Map.Felucca );
                        spawner18.Name = "MinocInvasionFelucca";
			spawner18.Respawn();
   
   
			Spawner spawner8 = new Spawner( 3, 10, 20, 20, 10, "JukaLord" );
			spawner8.MoveToWorld( new Point3D(  2638, 652, 0  ), Map.Felucca );
			spawner8.WayPoint = point103;
			point103.MoveToWorld( new Point3D(  2591, 647, 0  ), Map.Felucca );
			point103.NextPoint = point104;
			point104.MoveToWorld( new Point3D(  2586, 641, 0  ), Map.Felucca );
			point104.NextPoint = point105;
			point105.MoveToWorld( new Point3D(  2584, 622, 0  ), Map.Felucca );
			point105.NextPoint = point106;
			point106.MoveToWorld( new Point3D(  2513, 620, 0  ), Map.Felucca );
			point106.NextPoint = point107;
			point107.MoveToWorld( new Point3D(  2517, 562, 0  ), Map.Felucca );
			point107.NextPoint = point108;
			point108.MoveToWorld( new Point3D(  2489, 563, 1  ), Map.Felucca );
			point108.NextPoint = point109;
			point109.MoveToWorld( new Point3D(  2489, 535, 0  ), Map.Felucca );
			point109.NextPoint = point110;
			point110.MoveToWorld( new Point3D(  2517, 535, 0  ), Map.Felucca );
			point110.NextPoint = point111;
			point111.MoveToWorld( new Point3D(  2514, 561, 0  ), Map.Felucca );
			point111.NextPoint = point112;
			point112.MoveToWorld( new Point3D(  2504, 562, 0  ), Map.Felucca );
			point112.NextPoint = point113;
			point113.MoveToWorld( new Point3D(  2504, 555, 0  ), Map.Felucca );
			point113.NextPoint = point114;
			point114.MoveToWorld( new Point3D( 2504, 562, 0  ), Map.Felucca );
			point114.NextPoint = point115;
			point115.MoveToWorld( new Point3D(  2540, 562, 0  ), Map.Felucca );
			point115.NextPoint = point116;
			point116.MoveToWorld( new Point3D(  2487, 570, 5  ), Map.Felucca );
			point116.NextPoint = point117;
			point117.MoveToWorld( new Point3D(  2473, 570, 5  ), Map.Felucca );
			point117.NextPoint = point118;
			point118.MoveToWorld( new Point3D(  2473, 565, 5  ), Map.Felucca );
			point118.NextPoint = point119;
			point119.MoveToWorld( new Point3D(  2473, 570, 5  ), Map.Felucca );
			point119.NextPoint = point120;
			point120.MoveToWorld( new Point3D(  2490, 570, 5  ), Map.Felucca );
			point120.NextPoint = point108;
			spawner8.Name = "MinocInvasionFelucca";
			spawner8.Respawn();


                        Spawner spawner16 = new Spawner( 10, 20, 20, 20, 20, "JukaWarrior" );
			spawner16.MoveToWorld( new Point3D(  2638, 652, 0  ), Map.Felucca );
                        spawner16.Name = "MinocInvasionFelucca";
			spawner16.Respawn();
   
                        Spawner spawner17 = new Spawner( 10, 20, 20, 20, 20, "JukaWarrior" );
			spawner17.MoveToWorld( new Point3D(  2476, 416, 15  ), Map.Felucca );
                        spawner17.Name = "MinocInvasionFelucca";
			spawner17.Respawn();
   
                        Spawner spawner19 = new Spawner( 5, 20, 20, 20, 20, "JukaMage" );
			spawner19.MoveToWorld( new Point3D(  2500, 463, 15  ), Map.Felucca );
                        spawner19.Name = "MinocInvasionFelucca";
			spawner19.Respawn();
   
                        Spawner spawner20 = new Spawner( 3, 20, 20, 20, 20, "JukaLord" );
			spawner20.MoveToWorld( new Point3D(  2500, 463, 15  ), Map.Felucca );
                        spawner20.Name = "MinocInvasionFelucca";
			spawner20.Respawn();
   
                        Spawner spawner21 = new Spawner( 5, 20, 20, 20, 20, "JukaWarrior" );
			spawner21.MoveToWorld( new Point3D( 2525, 479, 15 ), Map.Felucca );
                        spawner21.Name = "MinocInvasionFelucca";
			spawner21.Respawn();
   
                        Spawner spawner22 = new Spawner( 2, 2, 2, 20, 2, "JukaLord" );
			spawner22.MoveToWorld( new Point3D( 2539, 501, 30 ), Map.Felucca );
                        spawner22.Name = "MinocInvasionFelucca";
			spawner22.Respawn();
   
                        Spawner spawner23 = new Spawner( 4, 20, 20, 20, 20, "JukaLord" );
			spawner23.MoveToWorld( new Point3D( 2487, 518, 0 ), Map.Felucca );
                        spawner23.Name = "MinocInvasionFelucca";
			spawner23.Respawn();
   
                        Spawner spawner24 = new Spawner( 6, 20, 20, 20, 20, "JukaWarrior" );
			spawner24.MoveToWorld( new Point3D( 2526, 512, 7 ), Map.Felucca );
                        spawner24.Name = "MinocInvasionFelucca";
			spawner24.Respawn();
   
                        Spawner spawner25 = new Spawner( 5, 20, 20, 20, 10, "JukaWarrior" );
			spawner25.MoveToWorld( new Point3D( 2526, 512, 7 ), Map.Felucca );
                        spawner25.Name = "MinocInvasionFelucca";
			spawner25.Respawn();
   
                        Spawner spawner26 = new Spawner( 4, 20, 20, 20, 20, "JukaLord" );
			spawner26.MoveToWorld( new Point3D( 2508, 379, 0 ), Map.Felucca );
                        spawner26.Name = "MinocInvasionFelucca";
			spawner26.Respawn();
   
                        Spawner spawner27 = new Spawner( 5, 20, 20, 20, 10, "JukaWarrior" );
			spawner27.MoveToWorld( new Point3D( 2556, 342, 15 ), Map.Felucca );
                        spawner27.Name = "MinocInvasionFelucca";
			spawner27.Respawn();
   
                        Spawner spawner28 = new Spawner( 5, 20, 20, 20, 10, "JukaWarrior" );
			spawner28.MoveToWorld( new Point3D( 2527, 440, 15 ), Map.Felucca );
                        spawner28.Name = "MinocInvasionFelucca";
			spawner28.Respawn();
   
                        Spawner spawner29 = new Spawner( 3, 20, 20, 20, 10, "JukaLord" );
			spawner29.MoveToWorld( new Point3D( 2496, 572, 3 ), Map.Felucca );
                        spawner29.Name = "MinocInvasionFelucca";
			spawner29.Respawn();
   
                        Spawner spawner30 = new Spawner( 3, 20, 20, 20, 10, "JukaMage" );
			spawner30.MoveToWorld( new Point3D( 2496, 572, 3 ), Map.Felucca );
                        spawner30.Name = "MinocInvasionFelucca";
			spawner30.Respawn();
   
                        Spawner spawner31 = new Spawner( 5, 20, 20, 20, 10, "JukaWarrior" );
			spawner31.MoveToWorld( new Point3D( 2501, 619, 0 ), Map.Felucca );
                        spawner31.Name = "MinocInvasionFelucca";
			spawner31.Respawn();
   
                        Spawner spawner32 = new Spawner( 7, 20, 20, 20, 20, "JukaWarrior" );
			spawner32.MoveToWorld( new Point3D( 2519, 672, 0 ), Map.Felucca );
                        spawner32.Name = "MinocInvasionFelucca";
			spawner32.Respawn();
   
                        Spawner spawner33 = new Spawner( 3, 20, 20, 20, 10, "JukaLord" );
			spawner33.MoveToWorld( new Point3D( 2553, 706, 0 ), Map.Felucca );
                        spawner33.Name = "MinocInvasionFelucca";
			spawner33.Respawn();

                        Spawner spawner34 = new Spawner( 3, 20, 20, 20, 10, "JukaMage" );
			spawner34.MoveToWorld( new Point3D( 2553, 706, 0 ), Map.Felucca );
                        spawner34.Name = "MinocInvasionFelucca";
			spawner34.Respawn();
   
                        Spawner spawner35 = new Spawner( 10, 20, 20, 20, 20, "JukaWarrior" );
			spawner35.MoveToWorld( new Point3D( 2587, 685, 0 ), Map.Felucca );
                        spawner35.Name = "MinocInvasionFelucca";
			spawner35.Respawn();
   
                        Spawner spawner36 = new Spawner( 5, 20, 20, 20, 20, "Swampdragon" );
			spawner36.MoveToWorld( new Point3D(  2607, 669, 0  ), Map.Felucca );
                        spawner36.Name = "MinocInvasionFelucca";
			spawner36.Respawn();
   
                        Spawner spawner37 = new Spawner( 5, 20, 20, 20, 10, "JukaWarrior" );
			spawner37.MoveToWorld( new Point3D( 2453, 544, 0 ), Map.Felucca );
                        spawner37.Name = "MinocInvasionFelucca";
			spawner37.Respawn();
   
                        Spawner spawner38 = new Spawner( 8, 20, 20, 20, 10, "JukaWarrior" );
			spawner38.MoveToWorld( new Point3D( 2417, 506, 15 ), Map.Felucca );
                        spawner38.Name = "MinocInvasionFelucca";
			spawner38.Respawn();
   
                        Spawner spawner39 = new Spawner( 3, 20, 20, 20, 10, "JukaLord" );
			spawner39.MoveToWorld( new Point3D( 2426, 456, 15 ), Map.Felucca );
                        spawner39.Name = "MinocInvasionFelucca";
			spawner39.Respawn();

                        Spawner spawner40 = new Spawner( 3, 20, 20, 20, 10, "JukaMage" );
			spawner40.MoveToWorld( new Point3D( 2426, 456, 15 ), Map.Felucca );
                        spawner40.Name = "MinocInvasionFelucca";
			spawner40.Respawn();
   
                        Spawner spawner41 = new Spawner( 7, 20, 20, 20, 20, "JukaWarrior" );
			spawner41.MoveToWorld( new Point3D( 2446, 400, 15 ), Map.Felucca );
                        spawner41.Name = "MinocInvasionFelucca";
			spawner41.Respawn();
   
                        Spawner spawner42 = new Spawner( 7, 20, 20, 20, 10, "JukaWarrior" );
			spawner42.MoveToWorld( new Point3D( 2451, 469, 15 ), Map.Felucca );
                        spawner42.Name = "MinocInvasionFelucca";
			spawner42.Respawn();
   
                        Spawner spawner43 = new Spawner( 5, 20, 20, 20, 10, "JukaWarrior" );
			spawner43.MoveToWorld( new Point3D( 2511, 387, 15 ), Map.Felucca );
                        spawner43.Name = "MinocInvasionFelucca";
			spawner43.Respawn();
   
                        Spawner spawner44 = new Spawner( 1, 2, 2, 20, 1, "TheJukaGeneral" );
			spawner44.MoveToWorld( new Point3D( 2454, 477, 15 ), Map.Felucca );
                        spawner44.Name = "MinocInvasionFelucca";
			spawner44.Respawn();

                        Spawner spawner45 = new Spawner( 1, 1, 1, 20, 1, "JukaMage" );
			spawner45.MoveToWorld( new Point3D( 2449, 486, 15 ), Map.Felucca );
                        spawner45.Name = "MinocInvasionFelucca";
			spawner45.Respawn();

                        Spawner spawner46 = new Spawner( 1, 1, 1, 20, 1, "JukaMage" );
			spawner46.MoveToWorld( new Point3D( 2455, 493, 15 ), Map.Felucca );
                        spawner46.Name = "MinocInvasionFelucca";
			spawner46.Respawn();
   
                        Spawner spawner47 = new Spawner( 1, 1, 1, 20, 1, "JukaMage" );
			spawner47.MoveToWorld( new Point3D( 2458, 487, 15 ), Map.Felucca );
                        spawner47.Name = "MinocInvasionFelucca";
			spawner47.Respawn();

                        Spawner spawner48 = new Spawner( 2, 2, 2, 20, 2, "JukaLord" );
			spawner48.MoveToWorld( new Point3D( 2458, 487, 15 ), Map.Felucca );
                        spawner48.Name = "MinocInvasionFelucca";
			spawner48.Respawn();

                                           World.Broadcast( 33, true, "Minoc Felucca is under invasion." );
		               from.SendGump( new CityInvasion( from ) );
                                   	 break; 
                            }  
		case 2:
		{
			GuardedRegion reg = from.Region as GuardedRegion;

			if ( reg == null )
			{
				from.SendMessage( 33, "You are not in a The guarded part of Minoc, Felucca." );
				from.SendMessage( 33, "You will have to go there and use [toggleguarded to turn the guards on." );
			}
                                          else if ( DummyMessage)
                                          {
				from.SendMessage( 33, "If you are not in a The guarded part of Minoc, Felucca." );
				from.SendMessage( 33, "You will have to go there and use [toggleguarded to turn the guards on." );
                                           }
                                           else if ( !reg.Disabled )
                                           {
				from.SendMessage( 3, "The guards in THIS region have not changed." );
                                           }

                                           else if ( reg.Disabled )
                                           {
			              reg.Disabled = !reg.Disabled;
			              from.SendMessage( 3, "The guards in THIS region have been enabled." );
                                           }
                                           if ( DummyMessage  && reg != null )
                                          {
				from.SendMessage( 33, "If you are not in the guarded part of Magincia, Felucca." );
				from.SendMessage( 33, "You will have to go there and use [toggleguarded to turn the guards off." );
                                          }
			              MinocInvasionStone minocfel = new MinocInvasionStone();
			              minocfel.StopMinocFelucca();
                                                        World.Broadcast( 33, true, "Minoc Felucca's invasion was successfully beaten back. No more invaders are left in the city." );
		                            from.SendGump( new CityInvasion( from ) );
                                   	              break; 
				}
			}
		}
	}
}
