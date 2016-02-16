using System;
using Server;
using Server.Items;
using Server.Mobiles;
using Server.Network; 
using System.Collections;

namespace Server.Gumps
{
	public class StartStopBuccaneersDentram : Gump
	{
		private Mobile m_Mobile;
		public StartStopBuccaneersDentram(Mobile from) : base(0,0)
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
                                    from.CloseGump( typeof( StartStopBuccaneersDentram ) ); 
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

			point.Name = "BuccaneersDenInvasionTrammel";
			point1.Name = "BuccaneersDenInvasionTrammel";
			point2.Name = "BuccaneersDenInvasionTrammel";
			point3.Name = "BuccaneersDenInvasionTrammel";
			point4.Name = "BuccaneersDenInvasionTrammel";
			point5.Name = "BuccaneersDenInvasionTrammel";
			point6.Name = "BuccaneersDenInvasionTrammel";
			point7.Name = "BuccaneersDenInvasionTrammel";
			point8.Name = "BuccaneersDenInvasionTrammel";
			point9.Name = "BuccaneersDenInvasionTrammel";

			point10.Name = "BuccaneersDenInvasionTrammel";
			point11.Name = "BuccaneersDenInvasionTrammel";
			point12.Name = "BuccaneersDenInvasionTrammel";
			point13.Name = "BuccaneersDenInvasionTrammel";
			point14.Name = "BuccaneersDenInvasionTrammel";
			point15.Name = "BuccaneersDenInvasionTrammel";
			point16.Name = "BuccaneersDenInvasionTrammel";
			point17.Name = "BuccaneersDenInvasionTrammel";
			point18.Name = "BuccaneersDenInvasionTrammel";
			point19.Name = "BuccaneersDenInvasionTrammel";

			point20.Name = "BuccaneersDenInvasionTrammel";
			point21.Name = "BuccaneersDenInvasionTrammel";
			point22.Name = "BuccaneersDenInvasionTrammel";
			point23.Name = "BuccaneersDenInvasionTrammel";
			point24.Name = "BuccaneersDenInvasionTrammel";
			point25.Name = "BuccaneersDenInvasionTrammel";
			point26.Name = "BuccaneersDenInvasionTrammel";
			point27.Name = "BuccaneersDenInvasionTrammel";
			point28.Name = "BuccaneersDenInvasionTrammel";
			point29.Name = "BuccaneersDenInvasionTrammel";

			point30.Name = "BuccaneersDenInvasionTrammel";
			point31.Name = "BuccaneersDenInvasionTrammel";
			point32.Name = "BuccaneersDenInvasionTrammel";
			point33.Name = "BuccaneersDenInvasionTrammel";
			point34.Name = "BuccaneersDenInvasionTrammel";
			point35.Name = "BuccaneersDenInvasionTrammel";
			point36.Name = "BuccaneersDenInvasionTrammel";
			point37.Name = "BuccaneersDenInvasionTrammel";
			point38.Name = "BuccaneersDenInvasionTrammel";
			point39.Name = "BuccaneersDenInvasionTrammel";

			point40.Name = "BuccaneersDenInvasionTrammel";
			point41.Name = "BuccaneersDenInvasionTrammel";
			point42.Name = "BuccaneersDenInvasionTrammel";
			point43.Name = "BuccaneersDenInvasionTrammel";
			point44.Name = "BuccaneersDenInvasionTrammel";
			point45.Name = "BuccaneersDenInvasionTrammel";
			point46.Name = "BuccaneersDenInvasionTrammel";
			point47.Name = "BuccaneersDenInvasionTrammel";
			point48.Name = "BuccaneersDenInvasionTrammel";
			point49.Name = "BuccaneersDenInvasionTrammel";

			point50.Name = "BuccaneersDenInvasionTrammel";
			point51.Name = "BuccaneersDenInvasionTrammel";
			point52.Name = "BuccaneersDenInvasionTrammel";
			point53.Name = "BuccaneersDenInvasionTrammel";
			point54.Name = "BuccaneersDenInvasionTrammel";
			point55.Name = "BuccaneersDenInvasionTrammel";
			point56.Name = "BuccaneersDenInvasionTrammel";
			point57.Name = "BuccaneersDenInvasionTrammel";
			point58.Name = "BuccaneersDenInvasionTrammel";
			point59.Name = "BuccaneersDenInvasionTrammel";

			point60.Name = "BuccaneersDenInvasionTrammel";
			point61.Name = "BuccaneersDenInvasionTrammel";
			point62.Name = "BuccaneersDenInvasionTrammel";
			point63.Name = "BuccaneersDenInvasionTrammel";
			point64.Name = "BuccaneersDenInvasionTrammel";
			point65.Name = "BuccaneersDenInvasionTrammel";
			point66.Name = "BuccaneersDenInvasionTrammel";
			point67.Name = "BuccaneersDenInvasionTrammel";
			point68.Name = "BuccaneersDenInvasionTrammel";
			point69.Name = "BuccaneersDenInvasionTrammel";

			point70.Name = "BuccaneersDenInvasionTrammel";
			point71.Name = "BuccaneersDenInvasionTrammel";
			point72.Name = "BuccaneersDenInvasionTrammel";
			point73.Name = "BuccaneersDenInvasionTrammel";
			point74.Name = "BuccaneersDenInvasionTrammel";
			point75.Name = "BuccaneersDenInvasionTrammel";
			point76.Name = "BuccaneersDenInvasionTrammel";
			point77.Name = "BuccaneersDenInvasionTrammel";
			point78.Name = "BuccaneersDenInvasionTrammel";
			point79.Name = "BuccaneersDenInvasionTrammel";
			point80.Name = "BuccaneersDenInvasionTrammel";
			point81.Name = "BuccaneersDenInvasionTrammel";


			Spawner spawner1 = new Spawner( 4, 5, 15, 0, 4, "OrcBomber" );
			spawner1.MoveToWorld( new Point3D(  2734, 1978, 0  ), Map.Trammel );
			spawner1.WayPoint = point;
			point.MoveToWorld( new Point3D(  2744, 2098, 15  ), Map.Trammel );
			point.NextPoint = point1;
			point1.MoveToWorld( new Point3D(  2726, 2160, 0  ), Map.Trammel );
			point1.NextPoint = point2;
			point2.MoveToWorld( new Point3D(  2703, 2164, 0  ), Map.Trammel );
			point2.NextPoint = point3;
			point3.MoveToWorld( new Point3D(  2685, 2164, 0  ), Map.Trammel );
			point3.NextPoint = point4;
			point4.MoveToWorld( new Point3D(  2673, 2191, 0  ), Map.Trammel );
			point4.NextPoint = point5;
			point5.MoveToWorld( new Point3D(  2673, 2215, 0  ), Map.Trammel );
			point5.NextPoint = point6;
			point6.MoveToWorld( new Point3D(  2746, 2240, 0  ), Map.Trammel );
			point6.NextPoint = point7;
			point7.MoveToWorld( new Point3D(  2703, 2240, 0  ), Map.Trammel );
			point7.NextPoint = point8;
			point8.MoveToWorld( new Point3D(  2630, 2308, 0  ), Map.Trammel );
			point8.NextPoint = point9;
			point9.MoveToWorld( new Point3D(  2620, 2171, 0  ), Map.Trammel );
			point9.NextPoint = point;
          			spawner1.Name = "BuccaneersDenInvasionTrammel";
			spawner1.Respawn();

			Spawner spawner2 = new Spawner( 4, 5, 15, 0, 20, "Orc" );
			spawner2.MoveToWorld( new Point3D(  2809, 2253, 0  ), Map.Trammel );
			spawner2.WayPoint = point10;
			point10.MoveToWorld( new Point3D(  2746, 2237, 0  ), Map.Trammel );
			point10.NextPoint = point11;
			point11.MoveToWorld( new Point3D(  2673, 2215, 0  ), Map.Trammel );
			point11.NextPoint = point12;
			point12.MoveToWorld( new Point3D(  2673, 2191, 0  ), Map.Trammel );
			point12.NextPoint = point13;
			point13.MoveToWorld( new Point3D(  2687, 2164, 0  ), Map.Trammel );
			point13.NextPoint = point14;
			point14.MoveToWorld( new Point3D(  2722, 2164, 0  ), Map.Trammel );
			point14.NextPoint = point15;
			point15.MoveToWorld( new Point3D(  2718, 2115, 0  ), Map.Trammel );
			point15.NextPoint = point16;
			point16.MoveToWorld( new Point3D(  2685, 2115, 0  ), Map.Trammel );
			point16.NextPoint = point17;
			point17.MoveToWorld( new Point3D(  2639, 2099, 10  ), Map.Trammel );
			point17.NextPoint = point18;
			point18.MoveToWorld( new Point3D(  2673, 2191, 0  ), Map.Trammel );
			point18.NextPoint = point19;
			point19.MoveToWorld( new Point3D(  2673, 2215, 0  ), Map.Trammel );
			point19.NextPoint = point10;
			spawner2.Name = "BuccaneersDenInvasionTrammel";
			spawner2.Respawn();

			Spawner spawner3 = new Spawner( 6, 5, 15, 0, 20, "Orc" );
			spawner3.MoveToWorld( new Point3D(  2622, 2315, 0  ), Map.Trammel );
			spawner3.WayPoint = point20;
			point20.MoveToWorld( new Point3D(  2717, 2237, 0  ), Map.Trammel );
			point20.NextPoint = point21;
			point21.MoveToWorld( new Point3D(  2673, 2215, 0  ), Map.Trammel );
			point21.NextPoint = point22;
			point22.MoveToWorld( new Point3D(  2674, 2168, 0  ), Map.Trammel );
			point22.NextPoint = point23;
			point23.MoveToWorld( new Point3D(  2690, 2164, 0  ), Map.Trammel );
			point23.NextPoint = point24;
			point24.MoveToWorld( new Point3D(  2745, 2057, 28  ), Map.Trammel );
			point24.NextPoint = point25;
			point25.MoveToWorld( new Point3D(  2686, 2045, 0  ), Map.Trammel );
			point25.NextPoint = point26;
			point26.MoveToWorld( new Point3D(  2681, 2115, 0  ), Map.Trammel );
			point26.NextPoint = point27;
			point27.MoveToWorld( new Point3D(  2731, 2116, 0  ), Map.Trammel );
			point27.NextPoint = point28;
			point28.MoveToWorld( new Point3D(  2711, 2163, 0  ), Map.Trammel );
			point28.NextPoint = point29;
			point29.MoveToWorld( new Point3D(  2687, 2164, 0  ), Map.Trammel );
			point29.NextPoint = point30;
			point30.MoveToWorld( new Point3D(  2673, 2194, 0  ), Map.Trammel );
			point30.NextPoint = point20;
			spawner3.Name = "BuccaneersDenInvasionTrammel";
			spawner3.Respawn();

			Spawner spawner4 = new Spawner( 6, 5, 15, 0, 40, "Orc" );
			spawner4.MoveToWorld( new Point3D(  2812, 2322, 0  ), Map.Trammel );
			spawner4.WayPoint = point31;
			point31.MoveToWorld( new Point3D(  2757, 2234, 0  ), Map.Trammel );
			point31.NextPoint = point32;
			point32.MoveToWorld( new Point3D(  2673, 2211, 0  ), Map.Trammel );
			point32.NextPoint = point33;
			point33.MoveToWorld( new Point3D(  2635, 2103, 9  ), Map.Trammel );
			point33.NextPoint = point34;
			point34.MoveToWorld( new Point3D(  2689, 2116, 0  ), Map.Trammel );
			point34.NextPoint = point35;
			point35.MoveToWorld( new Point3D(  2728, 2116, 0  ), Map.Trammel );
			point35.NextPoint = point36;
			point36.MoveToWorld( new Point3D(  2770, 2136, 0  ), Map.Trammel );
			point36.NextPoint = point37;
			point37.MoveToWorld( new Point3D(  2720, 2136, 0  ), Map.Trammel );
			point37.NextPoint = point38;
			point38.MoveToWorld( new Point3D(  2703, 2164, 0  ), Map.Trammel );
			point38.NextPoint = point39;
			point39.MoveToWorld( new Point3D(  2652, 2162, 7  ), Map.Trammel );
			point39.NextPoint = point40;
			point40.MoveToWorld( new Point3D(  2683, 2100, 0  ), Map.Trammel );
			point40.NextPoint = point41;
			point41.MoveToWorld( new Point3D(  2687, 2160, 0  ), Map.Trammel );
			point41.NextPoint = point42;
			point42.MoveToWorld( new Point3D(  2673, 2194, 0  ), Map.Trammel );
			point42.NextPoint = point31;
			spawner4.Name = "BuccaneersDenInvasionTrammel";
			spawner4.Respawn();

			Spawner spawner5 = new Spawner( 5, 5, 15, 0, 30, "Orc");
			spawner5.MoveToWorld( new Point3D(  2600, 2048, 0  ), Map.Trammel );
			spawner5.WayPoint = point43;
			point43.MoveToWorld( new Point3D(  2634, 2094, 10  ), Map.Trammel );
			point43.NextPoint = point44;
			point44.MoveToWorld( new Point3D(  2685, 2115, 0  ), Map.Trammel );
			point44.NextPoint = point45;
			point45.MoveToWorld( new Point3D(  2735, 2115, 0  ), Map.Trammel );
			point45.NextPoint = point46;
			point46.MoveToWorld( new Point3D(  2723, 2187, 0  ), Map.Trammel );
			point46.NextPoint = point47;
			point47.MoveToWorld( new Point3D(  2699, 2162, 0  ), Map.Trammel );
			point47.NextPoint = point48;
			point48.MoveToWorld( new Point3D(  2685, 2164, 0  ), Map.Trammel );
			point48.NextPoint = point49;
			point49.MoveToWorld( new Point3D(  2673, 2191, 0  ), Map.Trammel );
			point49.NextPoint = point50;
			point50.MoveToWorld( new Point3D(  2673, 2215, 0  ), Map.Trammel );
			point50.NextPoint = point51;
			point51.MoveToWorld( new Point3D(  2706, 2237, 0  ), Map.Trammel );
			point51.NextPoint = point52;
			point52.MoveToWorld( new Point3D(  2609, 2280, 6  ), Map.Trammel );
			point52.NextPoint = point43;
			spawner5.Name = "BuccaneersDenInvasionTrammel";
			spawner5.Respawn();

			Spawner spawner6 = new Spawner( 1, 5, 15, 0, 10, "OrcishLord" );
			spawner6.MoveToWorld( new Point3D(  2840, 2112, 0  ), Map.Trammel );
			spawner6.WayPoint = point53;
			point53.MoveToWorld( new Point3D(  2759, 2126, 0  ), Map.Trammel );
			point53.NextPoint = point54;
			point54.MoveToWorld( new Point3D(  2707, 2116, 0  ), Map.Trammel );
			point54.NextPoint = point55;
			point55.MoveToWorld( new Point3D(  2681, 2115, 0  ), Map.Trammel );
			point55.NextPoint = point56;
			point56.MoveToWorld( new Point3D(  2685, 2164, 0  ), Map.Trammel );
			point56.NextPoint = point57;
			point57.MoveToWorld( new Point3D(  2673, 2191, 0  ), Map.Trammel );
			point57.NextPoint = point58;
			point58.MoveToWorld( new Point3D(  2673, 2211, 0  ), Map.Trammel );
			point58.NextPoint = point59;
			point59.MoveToWorld( new Point3D(  2757, 2234, 0  ), Map.Trammel );
			point59.NextPoint = point60;
			point60.MoveToWorld( new Point3D(  2673, 2211, 0  ), Map.Trammel );
			point60.NextPoint = point61;
			point61.MoveToWorld( new Point3D(  2673, 2191, 0  ), Map.Trammel );
			point61.NextPoint = point62;
			point62.MoveToWorld( new Point3D(  2689, 2164, 0  ), Map.Trammel );
			point62.NextPoint = point63;
			point63.MoveToWorld( new Point3D(  2723, 2187, 0  ), Map.Trammel );
			point63.NextPoint = point64;
			point64.MoveToWorld( new Point3D(  2725, 2193, 0  ), Map.Trammel );
			point64.NextPoint = point65;
			point65.MoveToWorld( new Point3D(  2731, 2193, 0  ), Map.Trammel );
			point65.NextPoint = point66;
			point66.MoveToWorld( new Point3D(  2731, 2187, 0  ), Map.Trammel );
			point66.NextPoint = point67;
			point67.MoveToWorld( new Point3D(  2731, 2193, 0  ), Map.Trammel );
			point67.NextPoint = point68;
			point68.MoveToWorld( new Point3D(  2725, 2193, 0  ), Map.Trammel );
			point68.NextPoint = point69;
			point69.MoveToWorld( new Point3D(  2723, 2127, 0  ), Map.Trammel );
			point69.NextPoint = point53;
			spawner6.Name = "BuccaneersDenInvasionTrammel";
			spawner6.Respawn();

			Spawner spawner7 = new Spawner( 1, 5, 15, 0, 0, "OrcCaptain" );
			spawner7.MoveToWorld( new Point3D(  2734, 2039, 0  ), Map.Trammel );
			spawner7.WayPoint = point70;
			point70.MoveToWorld( new Point3D(  2721, 2186, 0  ), Map.Trammel );
			point70.NextPoint = point71;
			point71.MoveToWorld( new Point3D(  2725, 2193, 0  ), Map.Trammel );
			point71.NextPoint = point72;
			point72.MoveToWorld( new Point3D(  2731, 2193, 0  ), Map.Trammel );
			point72.NextPoint = point73;
			point73.MoveToWorld( new Point3D(  2731, 2187, 0  ), Map.Trammel );
			point73.NextPoint = point74;
			point74.MoveToWorld( new Point3D(  2731, 2193, 0  ), Map.Trammel );
			point74.NextPoint = point75;
			point75.MoveToWorld( new Point3D(  2725, 2193, 0  ), Map.Trammel );
			point75.NextPoint = point70;
			spawner7.Name = "BuccaneersDenInvasionTrammel";
			spawner7.Respawn();

			Spawner spawner8 = new Spawner( 1, 10, 20, 0, 10, "OrcBrute" );
			spawner8.MoveToWorld( new Point3D(  2750, 1972, 0  ), Map.Trammel );
			spawner8.WayPoint = point76;
			point76.MoveToWorld( new Point3D(  2720, 2185, 0  ), Map.Trammel );
			point76.NextPoint = point77;
			point77.MoveToWorld( new Point3D(  2724, 2192, 0  ), Map.Trammel );
			point77.NextPoint = point78;
			point78.MoveToWorld( new Point3D(  2731, 2193, 0   ), Map.Trammel );
			point78.NextPoint = point79;
			point79.MoveToWorld( new Point3D(  2731, 2187, 0  ), Map.Trammel );
			point79.NextPoint = point80;
			point80.MoveToWorld( new Point3D(  2731, 2193, 0  ), Map.Trammel );
			point80.NextPoint = point81;
			point81.MoveToWorld( new Point3D(  2724, 2192, 0  ), Map.Trammel );
			point81.NextPoint = point76;
			spawner8.Name = "BuccaneersDenInvasionTrammel";
			spawner8.Respawn();

            Spawner spawner9 = new Spawner(1, 5, 15, 0, 1, "OrcCamp");
            spawner9.MoveToWorld(new Point3D(2642, 2170, 16), Map.Trammel);
            spawner9.Name = "BuccaneersDenInvasionTrammel";
            spawner9.Respawn();

            Spawner spawner10 = new Spawner(1, 5, 15, 0, 1, "OrcCamp");
            spawner10.MoveToWorld(new Point3D(2722, 2158, 0), Map.Trammel);
            spawner10.Name = "BuccaneersDenInvasionTrammel";
            spawner10.Respawn();

                                           World.Broadcast( 33, true, "Buccaneer's Den Trammel is under invasion." );
		               from.SendGump( new CityInvasion( from ) );
                                   	 break; 
                            }  
		case 2:
		{
			BuccaneersDenInvasionStone buctram = new BuccaneersDenInvasionStone();
			buctram.StopBuccaneersDenTrammel();
                                          World.Broadcast( 33, true, "Buccaneer's Den Trammel's invasion was successfully beaten back. No more invaders are left in the city." );
		              from.SendGump( new CityInvasion( from ) );
                                   	break; 
				}
			}
		}
	}
}