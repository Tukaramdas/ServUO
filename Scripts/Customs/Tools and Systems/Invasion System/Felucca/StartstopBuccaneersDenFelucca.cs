using System;
using Server;
using Server.Items;
using Server.Mobiles;
using Server.Network; 
using System.Collections;

namespace Server.Gumps
{
	public class StartStopBuccaneersDenfel : Gump
	{
		private Mobile m_Mobile;
		public StartStopBuccaneersDenfel(Mobile from) : base(0,0)
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
                                    from.CloseGump( typeof( StartStopBuccaneersDenfel ) ); 
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

			point.Name = "BuccaneersDenInvasionFelucca";
			point1.Name = "BuccaneersDenInvasionFelucca";
			point2.Name = "BuccaneersDenInvasionFelucca";
			point3.Name = "BuccaneersDenInvasionFelucca";
			point4.Name = "BuccaneersDenInvasionFelucca";
			point5.Name = "BuccaneersDenInvasionFelucca";
			point6.Name = "BuccaneersDenInvasionFelucca";
			point7.Name = "BuccaneersDenInvasionFelucca";
			point8.Name = "BuccaneersDenInvasionFelucca";
			point9.Name = "BuccaneersDenInvasionFelucca";

			point10.Name = "BuccaneersDenInvasionFelucca";
			point11.Name = "BuccaneersDenInvasionFelucca";
			point12.Name = "BuccaneersDenInvasionFelucca";
			point13.Name = "BuccaneersDenInvasionFelucca";
			point14.Name = "BuccaneersDenInvasionFelucca";
			point15.Name = "BuccaneersDenInvasionFelucca";
			point16.Name = "BuccaneersDenInvasionFelucca";
			point17.Name = "BuccaneersDenInvasionFelucca";
			point18.Name = "BuccaneersDenInvasionFelucca";
			point19.Name = "BuccaneersDenInvasionFelucca";

			point20.Name = "BuccaneersDenInvasionFelucca";
			point21.Name = "BuccaneersDenInvasionFelucca";
			point22.Name = "BuccaneersDenInvasionFelucca";
			point23.Name = "BuccaneersDenInvasionFelucca";
			point24.Name = "BuccaneersDenInvasionFelucca";
			point25.Name = "BuccaneersDenInvasionFelucca";
			point26.Name = "BuccaneersDenInvasionFelucca";
			point27.Name = "BuccaneersDenInvasionFelucca";
			point28.Name = "BuccaneersDenInvasionFelucca";
			point29.Name = "BuccaneersDenInvasionFelucca";

			point30.Name = "BuccaneersDenInvasionFelucca";
			point31.Name = "BuccaneersDenInvasionFelucca";
			point32.Name = "BuccaneersDenInvasionFelucca";
			point33.Name = "BuccaneersDenInvasionFelucca";
			point34.Name = "BuccaneersDenInvasionFelucca";
			point35.Name = "BuccaneersDenInvasionFelucca";
			point36.Name = "BuccaneersDenInvasionFelucca";
			point37.Name = "BuccaneersDenInvasionFelucca";
			point38.Name = "BuccaneersDenInvasionFelucca";
			point39.Name = "BuccaneersDenInvasionFelucca";

			point40.Name = "BuccaneersDenInvasionFelucca";
			point41.Name = "BuccaneersDenInvasionFelucca";
			point42.Name = "BuccaneersDenInvasionFelucca";
			point43.Name = "BuccaneersDenInvasionFelucca";
			point44.Name = "BuccaneersDenInvasionFelucca";
			point45.Name = "BuccaneersDenInvasionFelucca";
			point46.Name = "BuccaneersDenInvasionFelucca";
			point47.Name = "BuccaneersDenInvasionFelucca";
			point48.Name = "BuccaneersDenInvasionFelucca";
			point49.Name = "BuccaneersDenInvasionFelucca";

			point50.Name = "BuccaneersDenInvasionFelucca";
			point51.Name = "BuccaneersDenInvasionFelucca";
			point52.Name = "BuccaneersDenInvasionFelucca";
			point53.Name = "BuccaneersDenInvasionFelucca";
			point54.Name = "BuccaneersDenInvasionFelucca";
			point55.Name = "BuccaneersDenInvasionFelucca";
			point56.Name = "BuccaneersDenInvasionFelucca";
			point57.Name = "BuccaneersDenInvasionFelucca";
			point58.Name = "BuccaneersDenInvasionFelucca";
			point59.Name = "BuccaneersDenInvasionFelucca";

			point60.Name = "BuccaneersDenInvasionFelucca";
			point61.Name = "BuccaneersDenInvasionFelucca";
			point62.Name = "BuccaneersDenInvasionFelucca";
			point63.Name = "BuccaneersDenInvasionFelucca";
			point64.Name = "BuccaneersDenInvasionFelucca";
			point65.Name = "BuccaneersDenInvasionFelucca";
			point66.Name = "BuccaneersDenInvasionFelucca";
			point67.Name = "BuccaneersDenInvasionFelucca";
			point68.Name = "BuccaneersDenInvasionFelucca";
			point69.Name = "BuccaneersDenInvasionFelucca";

			point70.Name = "BuccaneersDenInvasionFelucca";
			point71.Name = "BuccaneersDenInvasionFelucca";
			point72.Name = "BuccaneersDenInvasionFelucca";
			point73.Name = "BuccaneersDenInvasionFelucca";
			point74.Name = "BuccaneersDenInvasionFelucca";
			point75.Name = "BuccaneersDenInvasionFelucca";
			point76.Name = "BuccaneersDenInvasionFelucca";
			point77.Name = "BuccaneersDenInvasionFelucca";
			point78.Name = "BuccaneersDenInvasionFelucca";
			point79.Name = "BuccaneersDenInvasionFelucca";
			point80.Name = "BuccaneersDenInvasionFelucca";
			point81.Name = "BuccaneersDenInvasionFelucca";


			Spawner spawner1 = new Spawner( 4, 5, 15, 0, 4, "OrcBomber" );
			spawner1.MoveToWorld( new Point3D(  2734, 1978, 0  ), Map.Felucca );
			spawner1.WayPoint = point;
			point.MoveToWorld( new Point3D(  2744, 2098, 15  ), Map.Felucca );
			point.NextPoint = point1;
			point1.MoveToWorld( new Point3D(  2726, 2160, 0  ), Map.Felucca );
			point1.NextPoint = point2;
			point2.MoveToWorld( new Point3D(  2703, 2164, 0  ), Map.Felucca );
			point2.NextPoint = point3;
			point3.MoveToWorld( new Point3D(  2685, 2164, 0  ), Map.Felucca );
			point3.NextPoint = point4;
			point4.MoveToWorld( new Point3D(  2673, 2191, 0  ), Map.Felucca );
			point4.NextPoint = point5;
			point5.MoveToWorld( new Point3D(  2673, 2215, 0  ), Map.Felucca );
			point5.NextPoint = point6;
			point6.MoveToWorld( new Point3D(  2746, 2240, 0  ), Map.Felucca );
			point6.NextPoint = point7;
			point7.MoveToWorld( new Point3D(  2703, 2240, 0  ), Map.Felucca );
			point7.NextPoint = point8;
			point8.MoveToWorld( new Point3D(  2630, 2308, 0  ), Map.Felucca );
			point8.NextPoint = point9;
			point9.MoveToWorld( new Point3D(  2620, 2171, 0  ), Map.Felucca );
			point9.NextPoint = point;
          			spawner1.Name = "BuccaneersDenInvasionFelucca";
			spawner1.Respawn();

			Spawner spawner2 = new Spawner( 4, 5, 15, 0, 20, "Orc" );
			spawner2.MoveToWorld( new Point3D(  2809, 2253, 0  ), Map.Felucca );
			spawner2.WayPoint = point10;
			point10.MoveToWorld( new Point3D(  2746, 2237, 0  ), Map.Felucca );
			point10.NextPoint = point11;
			point11.MoveToWorld( new Point3D(  2673, 2215, 0  ), Map.Felucca );
			point11.NextPoint = point12;
			point12.MoveToWorld( new Point3D(  2673, 2191, 0  ), Map.Felucca );
			point12.NextPoint = point13;
			point13.MoveToWorld( new Point3D(  2687, 2164, 0  ), Map.Felucca );
			point13.NextPoint = point14;
			point14.MoveToWorld( new Point3D(  2722, 2164, 0  ), Map.Felucca );
			point14.NextPoint = point15;
			point15.MoveToWorld( new Point3D(  2718, 2115, 0  ), Map.Felucca );
			point15.NextPoint = point16;
			point16.MoveToWorld( new Point3D(  2685, 2115, 0  ), Map.Felucca );
			point16.NextPoint = point17;
			point17.MoveToWorld( new Point3D(  2639, 2099, 10  ), Map.Felucca );
			point17.NextPoint = point18;
			point18.MoveToWorld( new Point3D(  2673, 2191, 0  ), Map.Felucca );
			point18.NextPoint = point19;
			point19.MoveToWorld( new Point3D(  2673, 2215, 0  ), Map.Felucca );
			point19.NextPoint = point10;
			spawner2.Name = "BuccaneersDenInvasionFelucca";
			spawner2.Respawn();

			Spawner spawner3 = new Spawner( 6, 5, 15, 0, 20, "Orc" );
			spawner3.MoveToWorld( new Point3D(  2622, 2315, 0  ), Map.Felucca );
			spawner3.WayPoint = point20;
			point20.MoveToWorld( new Point3D(  2717, 2237, 0  ), Map.Felucca );
			point20.NextPoint = point21;
			point21.MoveToWorld( new Point3D(  2673, 2215, 0  ), Map.Felucca );
			point21.NextPoint = point22;
			point22.MoveToWorld( new Point3D(  2674, 2168, 0  ), Map.Felucca );
			point22.NextPoint = point23;
			point23.MoveToWorld( new Point3D(  2690, 2164, 0  ), Map.Felucca );
			point23.NextPoint = point24;
			point24.MoveToWorld( new Point3D(  2745, 2057, 28  ), Map.Felucca );
			point24.NextPoint = point25;
			point25.MoveToWorld( new Point3D(  2686, 2045, 0  ), Map.Felucca );
			point25.NextPoint = point26;
			point26.MoveToWorld( new Point3D(  2681, 2115, 0  ), Map.Felucca );
			point26.NextPoint = point27;
			point27.MoveToWorld( new Point3D(  2731, 2116, 0  ), Map.Felucca );
			point27.NextPoint = point28;
			point28.MoveToWorld( new Point3D(  2711, 2163, 0  ), Map.Felucca );
			point28.NextPoint = point29;
			point29.MoveToWorld( new Point3D(  2687, 2164, 0  ), Map.Felucca );
			point29.NextPoint = point30;
			point30.MoveToWorld( new Point3D(  2673, 2194, 0  ), Map.Felucca );
			point30.NextPoint = point20;
			spawner3.Name = "BuccaneersDenInvasionFelucca";
			spawner3.Respawn();

			Spawner spawner4 = new Spawner( 6, 5, 15, 0, 40, "Orc" );
			spawner4.MoveToWorld( new Point3D(  2812, 2322, 0  ), Map.Felucca );
			spawner4.WayPoint = point31;
			point31.MoveToWorld( new Point3D(  2757, 2234, 0  ), Map.Felucca );
			point31.NextPoint = point32;
			point32.MoveToWorld( new Point3D(  2673, 2211, 0  ), Map.Felucca );
			point32.NextPoint = point33;
			point33.MoveToWorld( new Point3D(  2635, 2103, 9  ), Map.Felucca );
			point33.NextPoint = point34;
			point34.MoveToWorld( new Point3D(  2689, 2116, 0  ), Map.Felucca );
			point34.NextPoint = point35;
			point35.MoveToWorld( new Point3D(  2728, 2116, 0  ), Map.Felucca );
			point35.NextPoint = point36;
			point36.MoveToWorld( new Point3D(  2770, 2136, 0  ), Map.Felucca );
			point36.NextPoint = point37;
			point37.MoveToWorld( new Point3D(  2720, 2136, 0  ), Map.Felucca );
			point37.NextPoint = point38;
			point38.MoveToWorld( new Point3D(  2703, 2164, 0  ), Map.Felucca );
			point38.NextPoint = point39;
			point39.MoveToWorld( new Point3D(  2652, 2162, 7  ), Map.Felucca );
			point39.NextPoint = point40;
			point40.MoveToWorld( new Point3D(  2683, 2100, 0  ), Map.Felucca );
			point40.NextPoint = point41;
			point41.MoveToWorld( new Point3D(  2687, 2160, 0  ), Map.Felucca );
			point41.NextPoint = point42;
			point42.MoveToWorld( new Point3D(  2673, 2194, 0  ), Map.Felucca );
			point42.NextPoint = point31;
			spawner4.Name = "BuccaneersDenInvasionFelucca";
			spawner4.Respawn();

			Spawner spawner5 = new Spawner( 5, 5, 15, 0, 30, "Orc");
			spawner5.MoveToWorld( new Point3D(  2600, 2048, 0  ), Map.Felucca );
			spawner5.WayPoint = point43;
			point43.MoveToWorld( new Point3D(  2634, 2094, 10  ), Map.Felucca );
			point43.NextPoint = point44;
			point44.MoveToWorld( new Point3D(  2685, 2115, 0  ), Map.Felucca );
			point44.NextPoint = point45;
			point45.MoveToWorld( new Point3D(  2735, 2115, 0  ), Map.Felucca );
			point45.NextPoint = point46;
			point46.MoveToWorld( new Point3D(  2723, 2187, 0  ), Map.Felucca );
			point46.NextPoint = point47;
			point47.MoveToWorld( new Point3D(  2699, 2162, 0  ), Map.Felucca );
			point47.NextPoint = point48;
			point48.MoveToWorld( new Point3D(  2685, 2164, 0  ), Map.Felucca );
			point48.NextPoint = point49;
			point49.MoveToWorld( new Point3D(  2673, 2191, 0  ), Map.Felucca );
			point49.NextPoint = point50;
			point50.MoveToWorld( new Point3D(  2673, 2215, 0  ), Map.Felucca );
			point50.NextPoint = point51;
			point51.MoveToWorld( new Point3D(  2706, 2237, 0  ), Map.Felucca );
			point51.NextPoint = point52;
			point52.MoveToWorld( new Point3D(  2609, 2280, 6  ), Map.Felucca );
			point52.NextPoint = point43;
			spawner5.Name = "BuccaneersDenInvasionFelucca";
			spawner5.Respawn();

			Spawner spawner6 = new Spawner( 1, 5, 15, 0, 10, "OrcishLord" );
			spawner6.MoveToWorld( new Point3D(  2840, 2112, 0  ), Map.Felucca );
			spawner6.WayPoint = point53;
			point53.MoveToWorld( new Point3D(  2759, 2126, 0  ), Map.Felucca );
			point53.NextPoint = point54;
			point54.MoveToWorld( new Point3D(  2707, 2116, 0  ), Map.Felucca );
			point54.NextPoint = point55;
			point55.MoveToWorld( new Point3D(  2681, 2115, 0  ), Map.Felucca );
			point55.NextPoint = point56;
			point56.MoveToWorld( new Point3D(  2685, 2164, 0  ), Map.Felucca );
			point56.NextPoint = point57;
			point57.MoveToWorld( new Point3D(  2673, 2191, 0  ), Map.Felucca );
			point57.NextPoint = point58;
			point58.MoveToWorld( new Point3D(  2673, 2211, 0  ), Map.Felucca );
			point58.NextPoint = point59;
			point59.MoveToWorld( new Point3D(  2757, 2234, 0  ), Map.Felucca );
			point59.NextPoint = point60;
			point60.MoveToWorld( new Point3D(  2673, 2211, 0  ), Map.Felucca );
			point60.NextPoint = point61;
			point61.MoveToWorld( new Point3D(  2673, 2191, 0  ), Map.Felucca );
			point61.NextPoint = point62;
			point62.MoveToWorld( new Point3D(  2689, 2164, 0  ), Map.Felucca );
			point62.NextPoint = point63;
			point63.MoveToWorld( new Point3D(  2723, 2187, 0  ), Map.Felucca );
			point63.NextPoint = point64;
			point64.MoveToWorld( new Point3D(  2725, 2193, 0  ), Map.Felucca );
			point64.NextPoint = point65;
			point65.MoveToWorld( new Point3D(  2731, 2193, 0  ), Map.Felucca );
			point65.NextPoint = point66;
			point66.MoveToWorld( new Point3D(  2731, 2187, 0  ), Map.Felucca );
			point66.NextPoint = point67;
			point67.MoveToWorld( new Point3D(  2731, 2193, 0  ), Map.Felucca );
			point67.NextPoint = point68;
			point68.MoveToWorld( new Point3D(  2725, 2193, 0  ), Map.Felucca );
			point68.NextPoint = point69;
			point69.MoveToWorld( new Point3D(  2723, 2127, 0  ), Map.Felucca );
			point69.NextPoint = point53;
			spawner6.Name = "BuccaneersDenInvasionFelucca";
			spawner6.Respawn();

			Spawner spawner7 = new Spawner( 1, 5, 15, 0, 0, "OrcCaptain" );
			spawner7.MoveToWorld( new Point3D(  2734, 2039, 0  ), Map.Felucca );
			spawner7.WayPoint = point70;
			point70.MoveToWorld( new Point3D(  2721, 2186, 0  ), Map.Felucca );
			point70.NextPoint = point71;
			point71.MoveToWorld( new Point3D(  2725, 2193, 0  ), Map.Felucca );
			point71.NextPoint = point72;
			point72.MoveToWorld( new Point3D(  2731, 2193, 0  ), Map.Felucca );
			point72.NextPoint = point73;
			point73.MoveToWorld( new Point3D(  2731, 2187, 0  ), Map.Felucca );
			point73.NextPoint = point74;
			point74.MoveToWorld( new Point3D(  2731, 2193, 0  ), Map.Felucca );
			point74.NextPoint = point75;
			point75.MoveToWorld( new Point3D(  2725, 2193, 0  ), Map.Felucca );
			point75.NextPoint = point70;
			spawner7.Name = "BuccaneersDenInvasionFelucca";
			spawner7.Respawn();

			Spawner spawner8 = new Spawner( 1, 10, 20, 0, 10, "OrcBrute" );
			spawner8.MoveToWorld( new Point3D(  2750, 1972, 0  ), Map.Felucca );
			spawner8.WayPoint = point76;
			point76.MoveToWorld( new Point3D(  2720, 2185, 0  ), Map.Felucca );
			point76.NextPoint = point77;
			point77.MoveToWorld( new Point3D(  2724, 2192, 0  ), Map.Felucca );
			point77.NextPoint = point78;
			point78.MoveToWorld( new Point3D(  2731, 2193, 0   ), Map.Felucca );
			point78.NextPoint = point79;
			point79.MoveToWorld( new Point3D(  2731, 2187, 0  ), Map.Felucca );
			point79.NextPoint = point80;
			point80.MoveToWorld( new Point3D(  2731, 2193, 0  ), Map.Felucca );
			point80.NextPoint = point81;
			point81.MoveToWorld( new Point3D(  2724, 2192, 0  ), Map.Felucca );
			point81.NextPoint = point76;
			spawner8.Name = "BuccaneersDenInvasionFelucca";
			spawner8.Respawn();

            Spawner spawner9 = new Spawner(1, 5, 15, 0, 1, "OrcCamp");
            spawner9.MoveToWorld(new Point3D(2642, 2170, 16), Map.Felucca);
            spawner9.Name = "BuccaneersDenInvasionFelucca";
            spawner9.Respawn();

            Spawner spawner10 = new Spawner(1, 5, 15, 0, 1, "OrcCamp");
            spawner10.MoveToWorld(new Point3D(2722, 2158, 0), Map.Felucca);
            spawner10.Name = "BuccaneersDenInvasionFelucca";
            spawner10.Respawn();

                                           World.Broadcast( 33, true, "Buccaneer's Den Felucca is under invasion." );
		               from.SendGump( new CityInvasion( from ) );
                                   	 break; 
                            }  
		case 2:
		{
			BuccaneersDenInvasionStone bucfel = new BuccaneersDenInvasionStone();
			bucfel.StopBuccaneersDenFelucca();
                                          World.Broadcast( 33, true, "Buccaneer's Den Felucca's invasion was successfully beaten back. No more invaders are left in the city." );
		              from.SendGump( new CityInvasion( from ) );
                                   	break; 
				}
			}
		}
	}
}