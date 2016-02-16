using System;
using Server;
using Server.Items;
using Server.Mobiles;
using Server.Network; 
using System.Collections;

namespace Server.Gumps
{
	public class StartStopCovefel : Gump
	{	
		private Mobile m_Mobile;
		public StartStopCovefel(Mobile from) : base(0,0)
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

                                    from.CloseGump( typeof( StartStopCovefel ) ); 
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
			
			point.Name = "CoveInvasionFelucca";
			point1.Name = "CoveInvasionFelucca";
			point2.Name = "CoveInvasionFelucca";
			point3.Name = "CoveInvasionFelucca";
			point4.Name = "CoveInvasionFelucca";
			point5.Name = "CoveInvasionFelucca";
			point6.Name = "CoveInvasionFelucca";
			point7.Name = "CoveInvasionFelucca";
			point8.Name = "CoveInvasionFelucca";
			point9.Name = "CoveInvasionFelucca";

			point10.Name = "CoveInvasionFelucca";
			point11.Name = "CoveInvasionFelucca";
			point12.Name = "CoveInvasionFelucca";
			point13.Name = "CoveInvasionFelucca";
			point14.Name = "CoveInvasionFelucca";
			point15.Name = "CoveInvasionFelucca";
			point16.Name = "CoveInvasionFelucca";
			point17.Name = "CoveInvasionFelucca";
			point18.Name = "CoveInvasionFelucca";
			point19.Name = "CoveInvasionFelucca";

			point20.Name = "CoveInvasionFelucca";
			point21.Name = "CoveInvasionFelucca";
			point22.Name = "CoveInvasionFelucca";
			point23.Name = "CoveInvasionFelucca";
			point24.Name = "CoveInvasionFelucca";
			point25.Name = "CoveInvasionFelucca";
			point26.Name = "CoveInvasionFelucca";
			point27.Name = "CoveInvasionFelucca";
			point28.Name = "CoveInvasionFelucca";
			point29.Name = "CoveInvasionFelucca";

			point30.Name = "CoveInvasionFelucca";
			point31.Name = "CoveInvasionFelucca";
			point32.Name = "CoveInvasionFelucca";
			point33.Name = "CoveInvasionFelucca";
			point34.Name = "CoveInvasionFelucca";
			point35.Name = "CoveInvasionFelucca";
			point36.Name = "CoveInvasionFelucca";
			point37.Name = "CoveInvasionFelucca";
			
			Spawner spawner1 = new Spawner( 4, 5, 15, 0, 4, "OrcBomber" );
			spawner1.MoveToWorld( new Point3D( 2322, 1127, 0 ), Map.Felucca );
			spawner1.WayPoint = point;
			point.MoveToWorld( new Point3D( 2313, 1169, 0 ), Map.Felucca );
			point.NextPoint = point1;
			point1.MoveToWorld( new Point3D( 2285, 1210, 0 ), Map.Felucca );
			point1.NextPoint = point2;
			point2.MoveToWorld( new Point3D( 2253, 1210, 0 ), Map.Felucca );
			point2.NextPoint = point3;
			point3.MoveToWorld( new Point3D( 2236, 1216, 0 ), Map.Felucca );
			point3.NextPoint = point4;
			point4.MoveToWorld( new Point3D( 2236, 1196, 0 ), Map.Felucca );
			point4.NextPoint = point5;
			point5.MoveToWorld( new Point3D( 2243, 1196, 0 ), Map.Felucca );
			point5.NextPoint = point6;
			point6.MoveToWorld( new Point3D( 2243, 1182, 0 ), Map.Felucca );
			point6.NextPoint = point7;
			point7.MoveToWorld( new Point3D( 2227, 1166, 0 ), Map.Felucca );
			point7.NextPoint = point8;
			point8.MoveToWorld( new Point3D( 2221, 1205, 0 ), Map.Felucca );
			point8.NextPoint = point9;
			point9.MoveToWorld( new Point3D( 2237, 1210, 0 ), Map.Felucca );
			point9.NextPoint = point2;
          			spawner1.Name = "CoveInvasionFelucca";
			spawner1.Respawn();

			Spawner spawner2 = new Spawner( 4, 5, 15, 0, 10, "Orc" );
			spawner2.MoveToWorld( new Point3D(  2348, 1214, 0  ), Map.Felucca );
			spawner2.WayPoint = point10;
			point10.MoveToWorld( new Point3D(  2285, 1210, 0  ), Map.Felucca );
			point10.NextPoint = point11;
			point11.MoveToWorld( new Point3D(  2268, 1210, 0  ), Map.Felucca );
			point11.NextPoint = point12;
			point12.MoveToWorld( new Point3D(  2268, 1231, 0  ), Map.Felucca );
			point12.NextPoint = point13;
			point13.MoveToWorld( new Point3D(  2251, 1231, 0  ), Map.Felucca );
			point13.NextPoint = point14;
			point14.MoveToWorld( new Point3D(  2251, 1214, 0  ), Map.Felucca );
			point14.NextPoint = point15;
			point15.MoveToWorld( new Point3D( 2234, 1211, 0 ), Map.Felucca );
			point15.NextPoint = point16;
			point16.MoveToWorld( new Point3D( 2210, 1200, 0 ), Map.Felucca );
			point16.NextPoint = point17;
			point17.MoveToWorld( new Point3D( 2210, 1177, 0 ), Map.Felucca );
			point17.NextPoint = point18;
			point18.MoveToWorld( new Point3D( 2240, 1177, 0 ), Map.Felucca );
			point18.NextPoint = point19;
			point19.MoveToWorld( new Point3D( 2276, 1211, 0 ), Map.Felucca );
			point19.NextPoint = point11;
			spawner2.Name = "CoveInvasionFelucca";
			spawner2.Respawn();

			Spawner spawner3 = new Spawner( 6, 5, 15, 0, 0, "Orc" );
			spawner3.MoveToWorld( new Point3D( 2210, 1274, 0 ), Map.Felucca );
			spawner3.WayPoint = point20;
			point20.MoveToWorld( new Point3D( 2284, 1268, 0 ), Map.Felucca );
			point20.NextPoint = point21;
			point21.MoveToWorld( new Point3D( 2294, 1207, 0 ), Map.Felucca );
			point21.NextPoint = point22;
			point22.MoveToWorld( new Point3D( 2286, 1186, 0 ), Map.Felucca );
			point22.NextPoint = point23;
			point23.MoveToWorld( new Point3D( 2286, 1218, 0 ), Map.Felucca );
			point23.NextPoint = point22;
			spawner3.Name = "CoveInvasionFelucca";
			spawner3.Respawn();

			Spawner spawner4 = new Spawner( 4, 5, 15, 0, 20, "Orc" );
			spawner4.MoveToWorld( new Point3D( 2364, 1205, 5 ), Map.Felucca );
			spawner4.WayPoint = point24;
			point24.MoveToWorld( new Point3D( 2285, 1210, 0 ), Map.Felucca );
			point24.NextPoint = point25;
			point25.MoveToWorld( new Point3D( 2275, 1209, 0 ), Map.Felucca );
			point25.NextPoint = point26;
			point26.MoveToWorld( new Point3D( 2275, 1203, 0 ), Map.Felucca );
			point26.NextPoint = point27;
			point27.MoveToWorld( new Point3D( 2272, 1200, 2 ), Map.Felucca );
			point27.NextPoint = point28;
			point28.MoveToWorld( new Point3D( 2272, 1196, 20 ), Map.Felucca );
			point28.NextPoint = point29;
			point29.MoveToWorld( new Point3D( 2282, 1200, 20 ), Map.Felucca );
			point29.NextPoint = point30;
			point30.MoveToWorld( new Point3D( 2282, 1187, 20 ), Map.Felucca );
			point30.NextPoint = point31;
			point31.MoveToWorld( new Point3D( 2282, 1222, 20 ), Map.Felucca );
			point31.NextPoint = point32;
			point32.MoveToWorld( new Point3D( 2290, 1222, 20 ), Map.Felucca );
			point32.NextPoint = point33;
			point33.MoveToWorld( new Point3D( 2287, 1228, 20 ), Map.Felucca );
			point33.NextPoint = point34;
			point34.MoveToWorld( new Point3D( 2280, 1224, 20 ), Map.Felucca );
			point34.NextPoint = point35;
			point35.MoveToWorld( new Point3D( 2280, 1227, 7 ), Map.Felucca );
			point35.NextPoint = point36;
			point36.MoveToWorld( new Point3D( 2283, 1233, 0 ), Map.Felucca );
			point36.NextPoint = point37;
			point37.MoveToWorld( new Point3D( 2273, 1233, 0 ), Map.Felucca );
			point37.NextPoint = point26;
			spawner4.Name = "CoveInvasionFelucca";
			spawner4.Respawn();

			Spawner spawner5 = new Spawner( 4, 5, 15, 0, 8, "OrcishLord" );
			spawner5.MoveToWorld( new Point3D( 2219, 1117, 17 ), Map.Felucca );
                        spawner5.Name = "CoveInvasionFelucca";
			spawner5.Respawn();

                        Spawner spawner6 = new Spawner( 3, 5, 15, 0, 8, "OrcishMage" );
			spawner6.MoveToWorld( new Point3D( 2322, 1127, 0 ), Map.Felucca );
                        spawner6.Name = "CoveInvasionFelucca";
			spawner6.Respawn();
   
                        Spawner spawner7 = new Spawner( 3, 5, 15, 0, 8, "OrcishLord" );
			spawner7.MoveToWorld( new Point3D( 2348, 1214, 0 ), Map.Felucca );
                        spawner7.Name = "CoveInvasionFelucca";
			spawner7.Respawn();
   
                        Spawner spawner8 = new Spawner( 3, 5, 15, 0, 8, "OrcishMage" );
			spawner8.MoveToWorld( new Point3D( 2210, 1274, 0 ), Map.Felucca );
                        spawner8.Name = "CoveInvasionFelucca";
			spawner8.Respawn();
   
                        Spawner spawner9 = new Spawner( 3, 5, 15, 0, 8, "OrcishLord" );
			spawner9.MoveToWorld( new Point3D( 2364, 1205, 5 ), Map.Felucca );
                        spawner9.Name = "CoveInvasionFelucca";
			spawner9.Respawn();

                        Spawner spawner10 = new Spawner( 3, 5, 15, 0, 20, "OrcScout" );
			spawner10.MoveToWorld( new Point3D( 2348, 1214, 0 ), Map.Felucca );
                        spawner10.Name = "CoveInvasionFelucca";
			spawner10.Respawn();
   
                        Spawner spawner11 = new Spawner( 1, 5, 15, 0, 1, "OrcCamp" );
			spawner11.MoveToWorld( new Point3D( 2348, 1214, 0 ), Map.Felucca );
                        spawner11.Name = "CoveInvasionFelucca";
			spawner11.Respawn();
   
                        Spawner spawner12 = new Spawner( 2, 5, 15, 0, 8, "OrcishLord" );
			spawner12.MoveToWorld( new Point3D( 2225, 1168, 0 ), Map.Felucca );
                        spawner12.Name = "CoveInvasionFelucca";
			spawner12.Respawn();
   
                        Spawner spawner13 = new Spawner( 2, 5, 15, 0, 8, "OrcishMage" );
			spawner13.MoveToWorld( new Point3D( 2216, 1190, 0 ), Map.Felucca );
                        spawner13.Name = "CoveInvasionFelucca";
			spawner13.Respawn();
   
                        Spawner spawner14 = new Spawner( 2, 5, 15, 0, 8, "OrcishLord" );
			spawner14.MoveToWorld( new Point3D( 2234, 1210, 0 ), Map.Felucca );
                        spawner14.Name = "CoveInvasionFelucca";
			spawner14.Respawn();
   
                        Spawner spawner15 = new Spawner( 2, 5, 15, 0, 8, "OrcishMage" );
			spawner15.MoveToWorld( new Point3D( 2277, 1200, 20 ), Map.Felucca );
                        spawner15.Name = "CoveInvasionFelucca";
			spawner15.Respawn();
   
                        Spawner spawner16 = new Spawner( 1, 5, 15, 0, 1, "OrcCamp" );
			spawner16.MoveToWorld( new Point3D( 2295, 1203, 0 ), Map.Felucca );
                        spawner16.Name = "CoveInvasionFelucca";
			spawner16.Respawn();
   
                        Spawner spawner17 = new Spawner( 10, 5, 15, 0, 25, "Orc" );
			spawner17.MoveToWorld( new Point3D( 2295, 1203, 0 ), Map.Felucca );
                        spawner17.Name = "CoveInvasionFelucca";
			spawner17.Respawn();
   
                        Spawner spawner18 = new Spawner( 1, 5, 15, 0, 1, "OrcCamp" );
			spawner18.MoveToWorld( new Point3D( 2301, 1229, 0 ), Map.Felucca );
                        spawner18.Name = "CoveInvasionFelucca";
			spawner18.Respawn();
   
                        Spawner spawner19 = new Spawner( 1, 5, 15, 0, 1, "OrcCamp" );
			spawner19.MoveToWorld( new Point3D( 2223, 1151, 0 ), Map.Felucca );
                        spawner19.Name = "CoveInvasionFelucca";
			spawner19.Respawn();
   
                        Spawner spawner20 = new Spawner( 10, 5, 15, 0, 15, "Orc" );
			spawner20.MoveToWorld( new Point3D( 2224, 1181, 0 ), Map.Felucca );
                        spawner20.Name = "CoveInvasionFelucca";
			spawner20.Respawn();
   
                        Spawner spawner21 = new Spawner( 10, 5, 15, 0, 15, "Orc" );
			spawner21.MoveToWorld( new Point3D( 2247, 1219, 0 ), Map.Felucca );
                        spawner21.Name = "CoveInvasionFelucca";
			spawner21.Respawn();
   
                        Spawner spawner22 = new Spawner( 5, 5, 15, 0, 15, "Orc" );
			spawner22.MoveToWorld( new Point3D( 2224, 1181, 0 ), Map.Felucca );
                        spawner22.Name = "CoveInvasionFelucca";
			spawner22.Respawn();
   
                        Spawner spawner23 = new Spawner( 3, 5, 15, 0, 10, "OrcScout" );
			spawner23.MoveToWorld( new Point3D( 2299, 1252, 0 ), Map.Felucca );
                        spawner23.Name = "CoveInvasionFelucca";
			spawner23.Respawn();
   
                        Spawner spawner24 = new Spawner( 3, 5, 15, 0, 8, "OrcishMage" );
			spawner24.MoveToWorld( new Point3D( 2257, 1204, 0 ), Map.Felucca );
                        spawner24.Name = "CoveInvasionFelucca";
			spawner24.Respawn();
   
                        Spawner spawner25 = new Spawner( 5, 5, 15, 0, 10, "Orc" );
			spawner25.MoveToWorld( new Point3D( 2222, 1129, 0 ), Map.Felucca );
                        spawner25.Name = "CoveInvasionFelucca";
			spawner25.Respawn();
   
                        Spawner spawner26 = new Spawner( 5, 5, 15, 0, 10, "Orc" );
			spawner26.MoveToWorld( new Point3D( 2271, 1218, 0 ), Map.Felucca );
                        spawner26.Name = "CoveInvasionFelucca";
			spawner26.Respawn();
   
                        Spawner spawner27 = new Spawner( 5, 5, 15, 0, 10, "Orc" );
			spawner27.MoveToWorld( new Point3D( 2233, 1240, 0 ), Map.Felucca );
                        spawner27.Name = "CoveInvasionFelucca";
			spawner27.Respawn();
   
                        Spawner spawner28 = new Spawner( 2, 5, 15, 0, 5, "OrcBomber" );
			spawner28.MoveToWorld( new Point3D( 2289, 1222, 20 ), Map.Felucca );
                        spawner28.Name = "CoveInvasionFelucca";
			spawner28.Respawn();
   
                        Spawner spawner29 = new Spawner( 2, 5, 15, 0, 5, "OrcBomber" );
			spawner29.MoveToWorld( new Point3D( 2281, 1192, 20 ), Map.Felucca );
                        spawner29.Name = "CoveInvasionFelucca";
			spawner29.Respawn();
   
                        Spawner spawner30 = new Spawner( 1, 5, 15, 0, 1, "OrcCamp" );
			spawner30.MoveToWorld( new Point3D( 2303, 1131, 0 ), Map.Felucca );
                        spawner30.Name = "CoveInvasionFelucca";
			spawner30.Respawn();
   
                        Spawner spawner31 = new Spawner( 5, 5, 15, 0, 10, "Orc" );
			spawner31.MoveToWorld( new Point3D( 2292, 1110, 0 ), Map.Felucca );
                        spawner31.Name = "CoveInvasionFelucca";
			spawner31.Respawn();
   
                        Spawner spawner32 = new Spawner( 5, 5, 15, 0, 10, "Orc" );
			spawner32.MoveToWorld( new Point3D( 2347, 1151, 5 ), Map.Felucca );
                        spawner32.Name = "CoveInvasionFelucca";
			spawner32.Respawn();
   
                        Spawner spawner33 = new Spawner( 5, 5, 15, 0, 10, "Orc" );
			spawner32.MoveToWorld( new Point3D( 2361, 1183, 10 ), Map.Felucca );
                        spawner33.Name = "CoveInvasionFelucca";
			spawner33.Respawn();
   
                        Spawner spawner34 = new Spawner( 5, 5, 15, 0, 10, "Orc" );
			spawner34.MoveToWorld( new Point3D( 2351, 1245, 10 ), Map.Felucca );
                        spawner34.Name = "CoveInvasionFelucca";
			spawner34.Respawn();
   
                        Spawner spawner35 = new Spawner( 1, 2, 2, 0, 2, "LordOrcalis" );
			spawner35.MoveToWorld( new Point3D( 2213, 1115, 40 ), Map.Felucca );
                        spawner35.Name = "CoveInvasionFelucca";
			spawner35.Respawn();
   
                        Spawner spawner36 = new Spawner( 2, 5, 15, 0, 5, "OrcBomber" );
			spawner36.MoveToWorld( new Point3D( 2270, 1127, 40 ), Map.Felucca );
                        spawner36.Name = "CoveInvasionFelucca";
			spawner36.Respawn();

                        Spawner spawner37 = new Spawner( 3, 5, 15, 0, 10, "OrcScout" );
			spawner37.MoveToWorld( new Point3D( 2270, 1127, 40 ), Map.Felucca );
                        spawner37.Name = "CoveInvasionFelucca";
			spawner37.Respawn();
   
                        Spawner spawner38 = new Spawner( 10, 20, 20, 0, 20, "OrcBomber" );
			spawner38.MoveToWorld( new Point3D( 2253, 1193, -2 ), Map.Felucca );
                        spawner38.Name = "CoveInvasionFelucca";
			spawner38.Respawn();
   
                        Spawner spawner39 = new Spawner( 10, 20, 20, 0, 20, "OrcBomber" );
			spawner39.MoveToWorld( new Point3D( 2225, 1141, 0 ), Map.Felucca );
                        spawner39.Name = "CoveInvasionFelucca";
			spawner39.Respawn();


                                           World.Broadcast( 33, true, "Cove Felucca is under invasion." );
		               from.SendGump( new CityInvasion( from ) );
                                   	 break; 
                            }  
		case 2:
		{
			CoveInvasionStone covefel = new CoveInvasionStone();
			covefel.StopCoveFelucca();
                                          World.Broadcast( 33, true, "Cove Felucca's invasion was successfully beaten back. No more invaders are left in the city." );
		              from.SendGump( new CityInvasion( from ) );
                                   	break; 
				}
			}
		}
	}
}
