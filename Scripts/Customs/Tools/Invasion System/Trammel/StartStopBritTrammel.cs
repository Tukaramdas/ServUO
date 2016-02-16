using System;
using Server;
using Server.Items;
using Server.Mobiles;
using Server.Network; 
using System.Collections;

namespace Server.Gumps
{
	public class StartStopBrittram : Gump
	{
		private Mobile m_Mobile;
		public StartStopBrittram(Mobile from) : base(0,0)
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
                                    from.CloseGump( typeof( StartStopBrittram ) ); 
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

			point.Name = "BritInvasionTrammel";
			point1.Name = "BritInvasionTrammel";
			point2.Name = "BritInvasionTrammel";
			point3.Name = "BritInvasionTrammel";
			point4.Name = "BritInvasionTrammel";
			point5.Name = "BritInvasionTrammel";
			point6.Name = "BritInvasionTrammel";
			point7.Name = "BritInvasionTrammel";
			point8.Name = "BritInvasionTrammel";
			point9.Name = "BritInvasionTrammel";

			point10.Name = "BritInvasionTrammel";
			point11.Name = "BritInvasionTrammel";
			point12.Name = "BritInvasionTrammel";
			point13.Name = "BritInvasionTrammel";
			point14.Name = "BritInvasionTrammel";
			point15.Name = "BritInvasionTrammel";
			point16.Name = "BritInvasionTrammel";
			point17.Name = "BritInvasionTrammel";
			point18.Name = "BritInvasionTrammel";
			point19.Name = "BritInvasionTrammel";

			point20.Name = "BritInvasionTrammel";
			point21.Name = "BritInvasionTrammel";
			point22.Name = "BritInvasionTrammel";
			point23.Name = "BritInvasionTrammel";
			point24.Name = "BritInvasionTrammel";
			point25.Name = "BritInvasionTrammel";
			point26.Name = "BritInvasionTrammel";
			point27.Name = "BritInvasionTrammel";
			point28.Name = "BritInvasionTrammel";
			point29.Name = "BritInvasionTrammel";

			point30.Name = "BritInvasionTrammel";
			point31.Name = "BritInvasionTrammel";
			point32.Name = "BritInvasionTrammel";
			point33.Name = "BritInvasionTrammel";
			point34.Name = "BritInvasionTrammel";
			point35.Name = "BritInvasionTrammel";
			point36.Name = "BritInvasionTrammel";
			point37.Name = "BritInvasionTrammel";
			point38.Name = "BritInvasionTrammel";
			point39.Name = "BritInvasionTrammel";

			point40.Name = "BritInvasionTrammel";
			point41.Name = "BritInvasionTrammel";
			point42.Name = "BritInvasionTrammel";
			point43.Name = "BritInvasionTrammel";
			point44.Name = "BritInvasionTrammel";
			point45.Name = "BritInvasionTrammel";
			point46.Name = "BritInvasionTrammel";
			point47.Name = "BritInvasionTrammel";
			point48.Name = "BritInvasionTrammel";
			point49.Name = "BritInvasionTrammel";

			point50.Name = "BritInvasionTrammel";
			point51.Name = "BritInvasionTrammel";
			point52.Name = "BritInvasionTrammel";
			point53.Name = "BritInvasionTrammel";
			point54.Name = "BritInvasionTrammel";
			point55.Name = "BritInvasionTrammel";
			point56.Name = "BritInvasionTrammel";
			point57.Name = "BritInvasionTrammel";
			point58.Name = "BritInvasionTrammel";
			point59.Name = "BritInvasionTrammel";

			point60.Name = "BritInvasionTrammel";
			point61.Name = "BritInvasionTrammel";
			point62.Name = "BritInvasionTrammel";
			point63.Name = "BritInvasionTrammel";
			point64.Name = "BritInvasionTrammel";
			point65.Name = "BritInvasionTrammel";
			point66.Name = "BritInvasionTrammel";
			point67.Name = "BritInvasionTrammel";
			point68.Name = "BritInvasionTrammel";
			point69.Name = "BritInvasionTrammel";

			point70.Name = "BritInvasionTrammel";
			point71.Name = "BritInvasionTrammel";
			point72.Name = "BritInvasionTrammel";
			point73.Name = "BritInvasionTrammel";
			point74.Name = "BritInvasionTrammel";
			point75.Name = "BritInvasionTrammel";
			point76.Name = "BritInvasionTrammel";
			point77.Name = "BritInvasionTrammel";
			point78.Name = "BritInvasionTrammel";
			point79.Name = "BritInvasionTrammel";
			point80.Name = "BritInvasionTrammel";
			point81.Name = "BritInvasionTrammel";


			Spawner spawner1 = new Spawner( 2, 5, 15, 30, 4, "Overseer" );
			spawner1.MoveToWorld( new Point3D(  1318, 1756, 10  ), Map.Trammel );
			spawner1.WayPoint = point;
			point.MoveToWorld( new Point3D(  1374, 1752, 1  ), Map.Trammel );
			point.NextPoint = point1;
			point1.MoveToWorld( new Point3D(  1440, 1697, 0  ), Map.Trammel );
			point1.NextPoint = point2;
			point2.MoveToWorld( new Point3D(  1462, 1657, 10  ), Map.Trammel );
			point2.NextPoint = point3;
			point3.MoveToWorld( new Point3D(  1482, 1605, 20  ), Map.Trammel );
			point3.NextPoint = point4;
			point4.MoveToWorld( new Point3D(  1424, 1603, 20  ), Map.Trammel );
			point4.NextPoint = point5;
			point5.MoveToWorld( new Point3D(  1413, 1662, 10  ), Map.Trammel );
			point5.NextPoint = point6;
			point6.MoveToWorld( new Point3D(  1418, 1697, 0  ), Map.Trammel );
			point6.NextPoint = point7;
			point7.MoveToWorld( new Point3D(  1481, 1697, 0  ), Map.Trammel );
			point7.NextPoint = point8;
			point8.MoveToWorld( new Point3D(  1418, 1699, 0  ), Map.Trammel );
			point8.NextPoint = point9;
			point9.MoveToWorld( new Point3D(  1420, 1726, 20  ), Map.Trammel );
			point9.NextPoint = point;
          			spawner1.Name = "BritInvasionTrammel";
			spawner1.Respawn();

			Spawner spawner2 = new Spawner( 2, 5, 15, 30, 20, "Overseer" );
			spawner2.MoveToWorld( new Point3D(  1363, 1801, 0  ), Map.Trammel );
			spawner2.WayPoint = point10;
			point10.MoveToWorld( new Point3D(  1373, 1751, 2  ), Map.Trammel );
			point10.NextPoint = point11;
			point11.MoveToWorld( new Point3D(  1408, 1745, 5  ), Map.Trammel );
			point11.NextPoint = point12;
			point12.MoveToWorld( new Point3D(  1419, 1669, 10  ), Map.Trammel );
			point12.NextPoint = point13;
			point13.MoveToWorld( new Point3D(  1475, 1650, 10  ), Map.Trammel );
			point13.NextPoint = point14;
			point14.MoveToWorld( new Point3D(  1513, 1650, 20  ), Map.Trammel );
			point14.NextPoint = point15;
			point15.MoveToWorld( new Point3D(  1513, 1629, 10  ), Map.Trammel );
			point15.NextPoint = point16;
			point16.MoveToWorld( new Point3D(  1420, 1627, 20  ), Map.Trammel );
			point16.NextPoint = point17;
			point17.MoveToWorld( new Point3D(  1330, 1625, 50  ), Map.Trammel );
			point17.NextPoint = point18;
			point18.MoveToWorld( new Point3D(  1420, 1625, 20  ), Map.Trammel );
			point18.NextPoint = point19;
			point19.MoveToWorld( new Point3D(  1420, 1725, 20  ), Map.Trammel );
			point19.NextPoint = point10;
			spawner2.Name = "BritInvasionTrammel";
			spawner2.Respawn();

			Spawner spawner3 = new Spawner( 2, 5, 15, 30, 20, "Overseer" );
			spawner3.MoveToWorld( new Point3D(  1349, 1533, 0  ), Map.Trammel );
			spawner3.WayPoint = point20;
			point20.MoveToWorld( new Point3D(  1425, 1532, 32  ), Map.Trammel );
			point20.NextPoint = point21;
			point21.MoveToWorld( new Point3D(  1479, 1542, 30  ), Map.Trammel );
			point21.NextPoint = point22;
			point22.MoveToWorld( new Point3D(  1479, 1572, 30  ), Map.Trammel );
			point22.NextPoint = point23;
			point23.MoveToWorld( new Point3D(  1493, 1577, 30  ), Map.Trammel );
			point23.NextPoint = point24;
			point24.MoveToWorld( new Point3D(  1519, 1579, 27  ), Map.Trammel );
			point24.NextPoint = point25;
			point25.MoveToWorld( new Point3D(  1565, 1579, 20  ), Map.Trammel );
			point25.NextPoint = point26;
			point26.MoveToWorld( new Point3D(  1567, 1630, 6  ), Map.Trammel );
			point26.NextPoint = point27;
			point27.MoveToWorld( new Point3D(  1536, 1630, 2  ), Map.Trammel );
			point27.NextPoint = point28;
			point28.MoveToWorld( new Point3D(  1443, 1622, 20  ), Map.Trammel );
			point28.NextPoint = point29;
			point29.MoveToWorld( new Point3D(  1438, 1587, 20  ), Map.Trammel );
			point29.NextPoint = point20;
			spawner3.Name = "BritInvasionTrammel";
			spawner3.Respawn();

			Spawner spawner4 = new Spawner( 2, 5, 15, 30, 50, "Overseer" );
			spawner4.MoveToWorld( new Point3D(  1385, 1385, 0  ), Map.Trammel );
			spawner4.WayPoint = point30;
			point30.MoveToWorld( new Point3D(  1428, 1528, 32  ), Map.Trammel );
			point30.NextPoint = point31;
			point31.MoveToWorld( new Point3D(  1503, 1535, 31  ), Map.Trammel );
			point31.NextPoint = point32;
			point32.MoveToWorld( new Point3D(  1499, 1578, 30  ), Map.Trammel );
			point32.NextPoint = point33;
			point33.MoveToWorld( new Point3D(  1485, 1602, 17  ), Map.Trammel );
			point33.NextPoint = point34;
			point34.MoveToWorld( new Point3D(  1485, 1632, 20  ), Map.Trammel );
			point34.NextPoint = point35;
			point35.MoveToWorld( new Point3D(  1518, 1630, 10  ), Map.Trammel );
			point35.NextPoint = point36;
			point36.MoveToWorld( new Point3D(  1541, 1630, 0  ), Map.Trammel );
			point36.NextPoint = point37;
			point37.MoveToWorld( new Point3D(  1532, 1673, 20  ), Map.Trammel );
			point37.NextPoint = point38;
			point38.MoveToWorld( new Point3D(  1491, 1670, 10  ), Map.Trammel );
			point38.NextPoint = point39;
			point39.MoveToWorld( new Point3D(  1483, 1603, 19  ), Map.Trammel );
			point39.NextPoint = point40;
			point40.MoveToWorld( new Point3D(  1463, 1602, 20  ), Map.Trammel );
			point40.NextPoint = point41;
			point41.MoveToWorld( new Point3D(  1464, 1572, 30  ), Map.Trammel );
			point41.NextPoint = point42;
			point42.MoveToWorld( new Point3D(  1432, 1571, 30  ), Map.Trammel );
			point42.NextPoint = point30;
			spawner4.Name = "BritInvasionTrammel";
			spawner4.Respawn();

			Spawner spawner5 = new Spawner( 3, 5, 15, 30, 90, "Overseer" );
			spawner5.MoveToWorld( new Point3D(  1270, 2060, 0  ), Map.Trammel );
			spawner5.WayPoint = point43;
			point43.MoveToWorld( new Point3D(  1373, 1809, 0  ), Map.Trammel );
			point43.NextPoint = point44;
			point44.MoveToWorld( new Point3D(  1368, 1750, 5  ), Map.Trammel );
			point44.NextPoint = point45;
			point45.MoveToWorld( new Point3D(  1403, 1747, 3  ), Map.Trammel );
			point45.NextPoint = point46;
			point46.MoveToWorld( new Point3D(  1423, 1698, 0  ), Map.Trammel );
			point46.NextPoint = point47;
			point47.MoveToWorld( new Point3D(  1481, 1699, 0  ), Map.Trammel );
			point47.NextPoint = point48;
			point48.MoveToWorld( new Point3D(  1504, 1705, 20  ), Map.Trammel );
			point48.NextPoint = point49;
			point49.MoveToWorld( new Point3D(  1557, 1699, 30  ), Map.Trammel );
			point49.NextPoint = point50;
			point50.MoveToWorld( new Point3D(  1569, 1636, 5  ), Map.Trammel );
			point50.NextPoint = point51;
			point51.MoveToWorld( new Point3D(  1617, 1636, 35  ), Map.Trammel );
			point51.NextPoint = point52;
			point52.MoveToWorld( new Point3D(  1601, 1691, 10  ), Map.Trammel );
			point52.NextPoint = point53;
			point53.MoveToWorld( new Point3D(  1589, 1724, 20  ), Map.Trammel );
			point53.NextPoint = point54;
			point54.MoveToWorld( new Point3D(  1533, 1724, 20  ), Map.Trammel );
			point54.NextPoint = point55;
			point55.MoveToWorld( new Point3D(  1533, 1647, 20  ), Map.Trammel );
			point55.NextPoint = point56;
			point56.MoveToWorld( new Point3D(  1569, 1595, 23  ), Map.Trammel );
			point56.NextPoint = point57;
			point57.MoveToWorld( new Point3D(  1571, 1530, 39  ), Map.Trammel );
			point57.NextPoint = point58;
			point58.MoveToWorld( new Point3D(  1432, 1573, 30  ), Map.Trammel );
			point58.NextPoint = point59;
			point59.MoveToWorld( new Point3D(  1429, 1531, 35  ), Map.Trammel );
			point59.NextPoint = point60;
			point60.MoveToWorld( new Point3D(  1437, 1588, 20  ), Map.Trammel );
			point60.NextPoint = point61;
			point61.MoveToWorld( new Point3D(  1420, 1627, 20  ), Map.Trammel );
			point61.NextPoint = point62;
			point62.MoveToWorld( new Point3D(  1420, 1728, 20  ), Map.Trammel );
			point62.NextPoint = point44;
			spawner5.Name = "BritInvasionTrammel";
			spawner5.Respawn();

			Spawner spawner6 = new Spawner( 3, 5, 15, 0, 10, "Overseer" );
			spawner6.MoveToWorld( new Point3D(  1435, 1498, 34  ), Map.Trammel );
			spawner6.WayPoint = point63;
			point63.MoveToWorld( new Point3D(  1429, 1537, 29  ), Map.Trammel );
			point63.NextPoint = point64;
			point64.MoveToWorld( new Point3D(  1432, 1572, 30  ), Map.Trammel );
			point64.NextPoint = point65;
			point65.MoveToWorld( new Point3D(  1437, 1588, 20  ), Map.Trammel );
			point65.NextPoint = point66;
			point66.MoveToWorld( new Point3D(  1424, 1590, 20  ), Map.Trammel );
			point66.NextPoint = point67;
			point67.MoveToWorld( new Point3D(  1424, 1625, 20  ), Map.Trammel );
			point67.NextPoint = point68;
			point68.MoveToWorld( new Point3D(  1463, 1625, 20  ), Map.Trammel );
			point68.NextPoint = point69;
			point69.MoveToWorld( new Point3D(  1463, 1573, 30  ), Map.Trammel );
			point69.NextPoint = point64;
			spawner6.Name = "BritInvasionTrammel";
			spawner6.Respawn();

			Spawner spawner7 = new Spawner( 3, 5, 15, 30, 0, "Overseer" );
			spawner7.MoveToWorld( new Point3D(  1351, 1757, 17  ), Map.Trammel );
			spawner7.WayPoint = point70;
			point70.MoveToWorld( new Point3D(  1373, 1753, 3  ), Map.Trammel );
			point70.NextPoint = point71;
			point71.MoveToWorld( new Point3D(  1420, 1699, 0  ), Map.Trammel );
			point71.NextPoint = point72;
			point72.MoveToWorld( new Point3D(  1447, 1696, 0  ), Map.Trammel );
			point72.NextPoint = point73;
			point73.MoveToWorld( new Point3D(  1447, 1679, 0  ), Map.Trammel );
			point73.NextPoint = point74;
			point74.MoveToWorld( new Point3D(  1434, 1667, 10  ), Map.Trammel );
			point74.NextPoint = point75;
			point75.MoveToWorld( new Point3D(  1417, 1668, 10  ), Map.Trammel );
			point75.NextPoint = point71;
			spawner7.Name = "BritInvasionTrammel";
			spawner7.Respawn();

			Spawner spawner8 = new Spawner( 3, 10, 20, 30, 10, "Overseer" );
			spawner8.MoveToWorld( new Point3D(  1370, 1749, 3  ), Map.Trammel );
			spawner8.WayPoint = point76;
			point76.MoveToWorld( new Point3D(  1405, 1746, 5  ), Map.Trammel );
			point76.NextPoint = point77;
			point77.MoveToWorld( new Point3D(  1420, 1699, 0  ), Map.Trammel );
			point77.NextPoint = point78;
			point78.MoveToWorld( new Point3D(  1447, 1696, 0  ), Map.Trammel );
			point78.NextPoint = point79;
			point79.MoveToWorld( new Point3D(  1447, 1679, 0  ), Map.Trammel );
			point79.NextPoint = point80;
			point80.MoveToWorld( new Point3D(  1426, 1666, 10  ), Map.Trammel );
			point80.NextPoint = point81;
			point81.MoveToWorld( new Point3D(  1417, 1668, 10  ), Map.Trammel );
			point81.NextPoint = point77;
			spawner8.Name = "BritInvasionTrammel";
			spawner8.Respawn();
   
                        Spawner spawner9 = new Spawner( 5, 10, 20, 30, 20, "RunicGolem" );
			spawner9.MoveToWorld( new Point3D(  1374, 1793, 2  ), Map.Trammel );
                        spawner9.Name = "BritInvasionTrammel";
			spawner9.Respawn();
   
                        Spawner spawner10 = new Spawner( 5, 10, 20, 30, 20, "RunicGolem" );
			spawner10.MoveToWorld( new Point3D( 1345, 1751, 20 ), Map.Trammel );
                        spawner10.Name = "BritInvasionTrammel";
			spawner10.Respawn();
   
                        Spawner spawner11 = new Spawner( 7, 10, 20, 30, 25, "RunicGolem" );
			spawner11.MoveToWorld( new Point3D( 1436, 1534, 35 ), Map.Trammel );
                        spawner11.Name = "BritInvasionTrammel";
			spawner11.Respawn();

                        Spawner spawner12 = new Spawner( 2, 1, 21, 30, 1, "MetalDaemon" );
			spawner12.MoveToWorld( new Point3D( 1523, 1513, 8 ), Map.Trammel );
                        spawner12.Name = "BritInvasionTrammel";
			spawner12.Respawn();
   
                        Spawner spawner13 = new Spawner( 5, 10, 20, 30, 10, "RunicGolem" );
			spawner13.MoveToWorld( new Point3D( 1576, 1529, 39 ), Map.Trammel );
                        spawner13.Name = "BritInvasionTrammel";
			spawner13.Respawn();
   
                        Spawner spawner14 = new Spawner( 4, 10, 20, 30, 10, "RunicGolem" );
			spawner14.MoveToWorld( new Point3D( 1546, 1579, 20 ), Map.Trammel );
                        spawner14.Name = "BritInvasionTrammel";
			spawner14.Respawn();

                        Spawner spawner15 = new Spawner( 4, 10, 20, 30, 10, "RunicGolem" );
			spawner15.MoveToWorld( new Point3D( 1539, 1630, 0 ), Map.Trammel );
                        spawner15.Name = "BritInvasionTrammel";
			spawner15.Respawn();

                        Spawner spawner16 = new Spawner( 4, 10, 20, 30, 10, "RunicGolem" );
			spawner16.MoveToWorld( new Point3D( 1535, 1673, 20 ), Map.Trammel );
                        spawner16.Name = "BritInvasionTrammel";
			spawner16.Respawn();

                        Spawner spawner17 = new Spawner( 4, 10, 20, 30, 10, "RunicGolem" );
			spawner17.MoveToWorld( new Point3D( 1524, 1707, 20 ), Map.Trammel );
                        spawner17.Name = "BritInvasionTrammel";
			spawner17.Respawn();
   
                        Spawner spawner18 = new Spawner( 4, 10, 20, 30, 10, "RunicGolem" );
			spawner18.MoveToWorld( new Point3D( 1477, 1758, -2 ), Map.Trammel );
                        spawner18.Name = "BritInvasionTrammel";
			spawner18.Respawn();

                        Spawner spawner19 = new Spawner( 4, 10, 20, 30, 10, "RunicGolem" );
			spawner19.MoveToWorld( new Point3D( 1441, 1763, -2 ), Map.Trammel );
                        spawner19.Name = "BritInvasionTrammel";
			spawner19.Respawn();
   
                        Spawner spawner20 = new Spawner( 2, 10, 10, 30, 10, "IronDragon" );
			spawner20.MoveToWorld( new Point3D( 1386, 1626, 30 ), Map.Trammel );
                        spawner20.Name = "BritInvasionTrammel";
			spawner20.Respawn();

                        Spawner spawner21 = new Spawner( 2, 10, 10, 30, 10, "MechGargoyle" );
			spawner21.MoveToWorld( new Point3D( 1401, 1745, 2 ), Map.Trammel );
                        spawner21.Name = "BritInvasionTrammel";
			spawner21.Respawn();
   
                        Spawner spawner29 = new Spawner( 2, 10, 10, 30, 10, "MechGargoyle" );
			spawner29.MoveToWorld( new Point3D( 1429, 1567, 30 ), Map.Trammel );
                        spawner29.Name = "BritInvasionTrammel";
			spawner29.Respawn();

                        Spawner spawner22 = new Spawner( 2, 10, 10, 30, 10, "MechGargoyle" );
			spawner22.MoveToWorld( new Point3D( 1476, 1537, 30 ), Map.Trammel );
                        spawner22.Name = "BritInvasionTrammel";
			spawner22.Respawn();

                        Spawner spawner23 = new Spawner( 2, 10, 10, 30, 10, "MechGargoyle" );
			spawner23.MoveToWorld( new Point3D( 1532, 1530, 40 ), Map.Trammel );
                        spawner23.Name = "BritInvasionTrammel";
			spawner23.Respawn();

                        Spawner spawner24 = new Spawner( 2, 10, 10, 30, 10, "MechGargoyle" );
			spawner24.MoveToWorld( new Point3D( 1513, 1582, 20 ), Map.Trammel );
                        spawner24.Name = "BritInvasionTrammel";
			spawner24.Respawn();

                        Spawner spawner25 = new Spawner( 2, 10, 10, 30, 10, "MechGargoyle" );
			spawner25.MoveToWorld( new Point3D( 1513, 1628, 10 ), Map.Trammel );
                        spawner25.Name = "BritInvasionTrammel";
			spawner25.Respawn();

                        Spawner spawner26 = new Spawner( 2, 10, 10, 30, 10, "MechGargoyle" );
			spawner26.MoveToWorld( new Point3D( 1512, 1673, 20 ), Map.Trammel );
                        spawner26.Name = "BritInvasionTrammel";
			spawner26.Respawn();

                        Spawner spawner27 = new Spawner( 2, 10, 10, 30, 10, "MechGargoyle" );
			spawner27.MoveToWorld( new Point3D( 1502, 1705, 20 ), Map.Trammel );
                        spawner27.Name = "BritInvasionTrammel";
			spawner27.Respawn();

                        Spawner spawner28 = new Spawner( 5, 20, 20, 30, 20, "MechGargoyle" );
			spawner28.MoveToWorld( new Point3D( 1455, 1734, 0 ), Map.Trammel );
                        spawner28.Name = "BritInvasionTrammel";
			spawner28.Respawn();

                        Spawner spawner30 = new Spawner( 1, 1, 1, 30, 1, "IronDragon" );
			spawner30.MoveToWorld( new Point3D( 1523, 1476, 20 ), Map.Trammel );
                        spawner30.Name = "BritInvasionTrammel";
			spawner30.Respawn();
   
                        Spawner spawner31 = new Spawner( 2, 10, 10, 30, 10, "ExodusOverseer" );
			spawner31.MoveToWorld( new Point3D( 1420, 1697, 0 ), Map.Trammel );
                        spawner31.Name = "BritInvasionTrammel";
			spawner31.Respawn();

                        Spawner spawner32 = new Spawner( 2, 10, 10, 30, 10, "ExodusOverseer" );
			spawner32.MoveToWorld( new Point3D( 1419, 1626, 20 ), Map.Trammel );
                        spawner32.Name = "BritInvasionTrammel";
			spawner32.Respawn();

                        Spawner spawner33 = new Spawner( 30, 150, 150, 30, 150, "Golem" );
			spawner33.MoveToWorld( new Point3D( 1475, 1651, 10 ), Map.Trammel );
                        spawner33.Name = "BritInvasionTrammel";
			spawner33.Respawn();

                        Spawner spawner34 = new Spawner( 2, 10, 10, 30, 10, "ExodusOverseer" );
			spawner34.MoveToWorld( new Point3D( 1461, 1583, 20 ), Map.Trammel );
                        spawner34.Name = "BritInvasionTrammel";
			spawner34.Respawn();

                        Spawner spawner35 = new Spawner( 2, 10, 10, 30, 10, "ExodusOverseer" );
			spawner35.MoveToWorld( new Point3D( 1484, 1613, 20 ), Map.Trammel );
                        spawner35.Name = "BritInvasionTrammel";
			spawner35.Respawn();

                        Spawner spawner36 = new Spawner( 30, 150, 150, 30, 150, "Overseer" );
			spawner36.MoveToWorld( new Point3D( 1475, 1657, 10 ), Map.Trammel );
                        spawner36.Name = "BritInvasionTrammel";
			spawner36.Respawn();

                        Spawner spawner37 = new Spawner( 2, 5, 5, 30, 5, "ExodusOverseer" );
			spawner37.MoveToWorld( new Point3D( 1478, 1704, 20 ), Map.Trammel );
                        spawner37.Name = "BritInvasionTrammel";
			spawner37.Respawn();

                        Spawner spawner38 = new Spawner( 2, 5, 5, 30, 5, "ExodusOverseer" );
			spawner38.MoveToWorld( new Point3D( 1454, 1698, 20 ), Map.Trammel );
                        spawner38.Name = "BritInvasionTrammel";
			spawner38.Respawn();

                        Spawner spawner39 = new Spawner( 2, 5, 5, 30, 5, "ExodusOverseer" );
			spawner39.MoveToWorld( new Point3D( 1512, 1641, 20 ), Map.Trammel );
                        spawner39.Name = "BritInvasionTrammel";
			spawner39.Respawn();

                        Spawner spawner40 = new Spawner( 4, 5, 5, 30, 5, "RunicGolem" );
			spawner40.MoveToWorld( new Point3D( 1523, 1453, 15 ), Map.Trammel );
                        spawner40.Name = "BritInvasionTrammel";
			spawner40.Respawn();
   
                        Spawner spawner41 = new Spawner( 2, 10, 10, 30, 4, "MechGargoyle" );
			spawner41.MoveToWorld( new Point3D( 1524, 1441, 15 ), Map.Trammel );
                        spawner41.Name = "BritInvasionTrammel";
			spawner41.Respawn();
   
                        Spawner spawner42 = new Spawner( 8, 10, 10, 30, 20, "ExodusOverseer" );
			spawner42.MoveToWorld( new Point3D( 1524, 1446, 15 ), Map.Trammel );
                        spawner42.Name = "BritInvasionTrammel";
			spawner42.Respawn();

                        Spawner spawner43 = new Spawner( 8, 10, 10, 30, 20, "ExodusOverseer" );
			spawner43.MoveToWorld( new Point3D( 1525, 1427, 15 ), Map.Trammel );
                        spawner43.Name = "BritInvasionTrammel";
			spawner43.Respawn();
   
                        Spawner spawner44 = new Spawner( 1, 1, 1, 30, 1, "IronDragon" );
			spawner44.MoveToWorld( new Point3D( 1518, 1428, 15 ), Map.Trammel );
                        spawner44.Name = "BritInvasionTrammel";
			spawner44.Respawn();
   
                        Spawner spawner45 = new Spawner( 2, 1, 21, 30, 1, "MetalDaemon" );
			spawner45.MoveToWorld( new Point3D( 1516, 1434, 15 ), Map.Trammel );
                        spawner45.Name = "BritInvasionTrammel";
			spawner45.Respawn();
   
                        Spawner spawner46 = new Spawner( 8, 1, 1, 30, 10, "ExodusOverseer" );
			spawner46.MoveToWorld( new Point3D( 1529, 1427, 35 ), Map.Trammel );
                        spawner46.Name = "BritInvasionTrammel";
			spawner46.Respawn();
   
                        Spawner spawner47 = new Spawner( 2, 1, 1, 30, 10, "MetalDaemon" );
			spawner47.MoveToWorld( new Point3D( 1525, 1418, 35 ), Map.Trammel );
                        spawner47.Name = "BritInvasionTrammel";
			spawner47.Respawn();
   
                        Spawner spawner48 = new Spawner( 2, 5, 5, 30, 5, "RunicGolem" );
			spawner48.MoveToWorld( new Point3D( 1526, 1417, 15 ), Map.Trammel );
                        spawner48.Name = "BritInvasionTrammel";
			spawner48.Respawn();
   
                        Spawner spawner49 = new Spawner( 1, 1, 1, 30, 1, "IronDragon" );
			spawner49.MoveToWorld( new Point3D( 1524, 1415, 56 ), Map.Trammel );
                        spawner49.Name = "BritInvasionTrammel";
			spawner49.Respawn();
   
                        Spawner spawner50 = new Spawner( 6, 1, 1, 30, 10, "RunicGolem" );
			spawner50.MoveToWorld( new Point3D( 1526, 1417, 55 ), Map.Trammel );
                        spawner50.Name = "BritInvasionTrammel";
			spawner50.Respawn();
   
                        Spawner spawner51 = new Spawner( 6, 1, 1, 30, 10, "ExodusOverseer" );
			spawner51.MoveToWorld( new Point3D( 1529, 1427, 55 ), Map.Trammel );
                        spawner51.Name = "BritInvasionTrammel";
			spawner51.Respawn();
   
                        Spawner spawner52 = new Spawner( 1, 1, 1, 30, 1, "IronDragon" );
			spawner52.MoveToWorld( new Point3D( 1530, 1423, 55 ), Map.Trammel );
                        spawner52.Name = "BritInvasionTrammel";
			spawner52.Respawn();
   
                        Spawner spawner53 = new Spawner( 2, 1, 1, 30, 1, "MechGargoyle" );
			spawner53.MoveToWorld( new Point3D( 1533, 1415, 56 ), Map.Trammel );
                        spawner53.Name = "BritInvasionTrammel";
			spawner53.Respawn();
   
                        Spawner spawner54 = new Spawner( 1, 1, 1, 30, 1, "BlackthornClone" );
			spawner54.MoveToWorld( new Point3D( 1540, 1415, 55 ), Map.Trammel );
                        spawner54.Name = "BritInvasionTrammel";
			spawner54.Respawn();
   
                        Spawner spawner55 = new Spawner( 4, 5, 5, 30, 5, "RunicGolem" );
			spawner55.MoveToWorld( new Point3D( 1537, 1516, 32 ), Map.Trammel );
                        spawner55.Name = "BritInvasionTrammel";
			spawner55.Respawn();
   //<---------
                        Spawner spawner56 = new Spawner( 1, 1, 1, 30, 1, "IronDragon" );
			spawner56.MoveToWorld( new Point3D( 1517, 1433, -25 ), Map.Trammel );
                        spawner56.Name = "BritInvasionTrammel";
			spawner56.Respawn();
   
                        Spawner spawner57 = new Spawner( 3, 2, 2, 30, 2, "ExodusOverseer" );
			spawner57.MoveToWorld( new Point3D( 1517, 1433, -25 ), Map.Trammel );
                        spawner57.Name = "BritInvasionTrammel";
			spawner57.Respawn();
   
                        Spawner spawner58 = new Spawner( 4, 10, 10, 30, 10, "MetalDaemon" );
			spawner58.MoveToWorld( new Point3D( 6045, 1400, 30 ), Map.Trammel );
                        spawner58.Name = "BritInvasionTrammel";
			spawner58.Respawn();
   
                                           World.Broadcast( 33, true, "Britian Trammel is under invasion." );
		               from.SendGump( new CityInvasion( from ) );
                                   	 break; 
                            }  
		case 2:
		{
			BritInvasionStone brittram = new BritInvasionStone();
			brittram.StopBritTrammel();
                                          World.Broadcast( 33, true, "Britian Trammel's invasion was successfully beaten back. No more invaders are left in the city." );
  		              from.SendGump( new CityInvasion( from ) );
                                          
                                   	break; 
				}
			}
		}
	}
}
