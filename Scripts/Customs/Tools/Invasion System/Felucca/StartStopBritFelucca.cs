using System;
using Server;
using Server.Items;
using Server.Mobiles;
using Server.Network; 
using System.Collections;

namespace Server.Gumps
{
	public class StartStopBritfel : Gump
	{
		private Mobile m_Mobile;
		public StartStopBritfel(Mobile from) : base(0,0)
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
                                    from.CloseGump( typeof( StartStopBritfel ) ); 
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

			point.Name = "BritInvasionFelucca";
			point1.Name = "BritInvasionFelucca";
			point2.Name = "BritInvasionFelucca";
			point3.Name = "BritInvasionFelucca";
			point4.Name = "BritInvasionFelucca";
			point5.Name = "BritInvasionFelucca";
			point6.Name = "BritInvasionFelucca";
			point7.Name = "BritInvasionFelucca";
			point8.Name = "BritInvasionFelucca";
			point9.Name = "BritInvasionFelucca";

			point10.Name = "BritInvasionFelucca";
			point11.Name = "BritInvasionFelucca";
			point12.Name = "BritInvasionFelucca";
			point13.Name = "BritInvasionFelucca";
			point14.Name = "BritInvasionFelucca";
			point15.Name = "BritInvasionFelucca";
			point16.Name = "BritInvasionFelucca";
			point17.Name = "BritInvasionFelucca";
			point18.Name = "BritInvasionFelucca";
			point19.Name = "BritInvasionFelucca";

			point20.Name = "BritInvasionFelucca";
			point21.Name = "BritInvasionFelucca";
			point22.Name = "BritInvasionFelucca";
			point23.Name = "BritInvasionFelucca";
			point24.Name = "BritInvasionFelucca";
			point25.Name = "BritInvasionFelucca";
			point26.Name = "BritInvasionFelucca";
			point27.Name = "BritInvasionFelucca";
			point28.Name = "BritInvasionFelucca";
			point29.Name = "BritInvasionFelucca";

			point30.Name = "BritInvasionFelucca";
			point31.Name = "BritInvasionFelucca";
			point32.Name = "BritInvasionFelucca";
			point33.Name = "BritInvasionFelucca";
			point34.Name = "BritInvasionFelucca";
			point35.Name = "BritInvasionFelucca";
			point36.Name = "BritInvasionFelucca";
			point37.Name = "BritInvasionFelucca";
			point38.Name = "BritInvasionFelucca";
			point39.Name = "BritInvasionFelucca";

			point40.Name = "BritInvasionFelucca";
			point41.Name = "BritInvasionFelucca";
			point42.Name = "BritInvasionFelucca";
			point43.Name = "BritInvasionFelucca";
			point44.Name = "BritInvasionFelucca";
			point45.Name = "BritInvasionFelucca";
			point46.Name = "BritInvasionFelucca";
			point47.Name = "BritInvasionFelucca";
			point48.Name = "BritInvasionFelucca";
			point49.Name = "BritInvasionFelucca";

			point50.Name = "BritInvasionFelucca";
			point51.Name = "BritInvasionFelucca";
			point52.Name = "BritInvasionFelucca";
			point53.Name = "BritInvasionFelucca";
			point54.Name = "BritInvasionFelucca";
			point55.Name = "BritInvasionFelucca";
			point56.Name = "BritInvasionFelucca";
			point57.Name = "BritInvasionFelucca";
			point58.Name = "BritInvasionFelucca";
			point59.Name = "BritInvasionFelucca";

			point60.Name = "BritInvasionFelucca";
			point61.Name = "BritInvasionFelucca";
			point62.Name = "BritInvasionFelucca";
			point63.Name = "BritInvasionFelucca";
			point64.Name = "BritInvasionFelucca";
			point65.Name = "BritInvasionFelucca";
			point66.Name = "BritInvasionFelucca";
			point67.Name = "BritInvasionFelucca";
			point68.Name = "BritInvasionFelucca";
			point69.Name = "BritInvasionFelucca";

			point70.Name = "BritInvasionFelucca";
			point71.Name = "BritInvasionFelucca";
			point72.Name = "BritInvasionFelucca";
			point73.Name = "BritInvasionFelucca";
			point74.Name = "BritInvasionFelucca";
			point75.Name = "BritInvasionFelucca";
			point76.Name = "BritInvasionFelucca";
			point77.Name = "BritInvasionFelucca";
			point78.Name = "BritInvasionFelucca";
			point79.Name = "BritInvasionFelucca";
			point80.Name = "BritInvasionFelucca";
			point81.Name = "BritInvasionFelucca";


			Spawner spawner1 = new Spawner( 2, 5, 15, 30, 4, "Overseer" );
			spawner1.MoveToWorld( new Point3D(  1318, 1756, 10  ), Map.Felucca );
			spawner1.WayPoint = point;
			point.MoveToWorld( new Point3D(  1374, 1752, 1  ), Map.Felucca );
			point.NextPoint = point1;
			point1.MoveToWorld( new Point3D(  1440, 1697, 0  ), Map.Felucca );
			point1.NextPoint = point2;
			point2.MoveToWorld( new Point3D(  1462, 1657, 10  ), Map.Felucca );
			point2.NextPoint = point3;
			point3.MoveToWorld( new Point3D(  1482, 1605, 20  ), Map.Felucca );
			point3.NextPoint = point4;
			point4.MoveToWorld( new Point3D(  1424, 1603, 20  ), Map.Felucca );
			point4.NextPoint = point5;
			point5.MoveToWorld( new Point3D(  1413, 1662, 10  ), Map.Felucca );
			point5.NextPoint = point6;
			point6.MoveToWorld( new Point3D(  1418, 1697, 0  ), Map.Felucca );
			point6.NextPoint = point7;
			point7.MoveToWorld( new Point3D(  1481, 1697, 0  ), Map.Felucca );
			point7.NextPoint = point8;
			point8.MoveToWorld( new Point3D(  1418, 1699, 0  ), Map.Felucca );
			point8.NextPoint = point9;
			point9.MoveToWorld( new Point3D(  1420, 1726, 20  ), Map.Felucca );
			point9.NextPoint = point;
          			spawner1.Name = "BritInvasionFelucca";
			spawner1.Respawn();

			Spawner spawner2 = new Spawner( 2, 5, 15, 30, 20, "Overseer" );
			spawner2.MoveToWorld( new Point3D(  1363, 1801, 0  ), Map.Felucca );
			spawner2.WayPoint = point10;
			point10.MoveToWorld( new Point3D(  1373, 1751, 2  ), Map.Felucca );
			point10.NextPoint = point11;
			point11.MoveToWorld( new Point3D(  1408, 1745, 5  ), Map.Felucca );
			point11.NextPoint = point12;
			point12.MoveToWorld( new Point3D(  1419, 1669, 10  ), Map.Felucca );
			point12.NextPoint = point13;
			point13.MoveToWorld( new Point3D(  1475, 1650, 10  ), Map.Felucca );
			point13.NextPoint = point14;
			point14.MoveToWorld( new Point3D(  1513, 1650, 20  ), Map.Felucca );
			point14.NextPoint = point15;
			point15.MoveToWorld( new Point3D(  1513, 1629, 10  ), Map.Felucca );
			point15.NextPoint = point16;
			point16.MoveToWorld( new Point3D(  1420, 1627, 20  ), Map.Felucca );
			point16.NextPoint = point17;
			point17.MoveToWorld( new Point3D(  1330, 1625, 50  ), Map.Felucca );
			point17.NextPoint = point18;
			point18.MoveToWorld( new Point3D(  1420, 1625, 20  ), Map.Felucca );
			point18.NextPoint = point19;
			point19.MoveToWorld( new Point3D(  1420, 1725, 20  ), Map.Felucca );
			point19.NextPoint = point10;
			spawner2.Name = "BritInvasionFelucca";
			spawner2.Respawn();

			Spawner spawner3 = new Spawner( 2, 5, 15, 30, 20, "Overseer" );
			spawner3.MoveToWorld( new Point3D(  1349, 1533, 0  ), Map.Felucca );
			spawner3.WayPoint = point20;
			point20.MoveToWorld( new Point3D(  1425, 1532, 32  ), Map.Felucca );
			point20.NextPoint = point21;
			point21.MoveToWorld( new Point3D(  1479, 1542, 30  ), Map.Felucca );
			point21.NextPoint = point22;
			point22.MoveToWorld( new Point3D(  1479, 1572, 30  ), Map.Felucca );
			point22.NextPoint = point23;
			point23.MoveToWorld( new Point3D(  1493, 1577, 30  ), Map.Felucca );
			point23.NextPoint = point24;
			point24.MoveToWorld( new Point3D(  1519, 1579, 27  ), Map.Felucca );
			point24.NextPoint = point25;
			point25.MoveToWorld( new Point3D(  1565, 1579, 20  ), Map.Felucca );
			point25.NextPoint = point26;
			point26.MoveToWorld( new Point3D(  1567, 1630, 6  ), Map.Felucca );
			point26.NextPoint = point27;
			point27.MoveToWorld( new Point3D(  1536, 1630, 2  ), Map.Felucca );
			point27.NextPoint = point28;
			point28.MoveToWorld( new Point3D(  1443, 1622, 20  ), Map.Felucca );
			point28.NextPoint = point29;
			point29.MoveToWorld( new Point3D(  1438, 1587, 20  ), Map.Felucca );
			point29.NextPoint = point20;
			spawner3.Name = "BritInvasionFelucca";
			spawner3.Respawn();

			Spawner spawner4 = new Spawner( 2, 5, 15, 30, 50, "Overseer" );
			spawner4.MoveToWorld( new Point3D(  1385, 1385, 0  ), Map.Felucca );
			spawner4.WayPoint = point30;
			point30.MoveToWorld( new Point3D(  1428, 1528, 32  ), Map.Felucca );
			point30.NextPoint = point31;
			point31.MoveToWorld( new Point3D(  1503, 1535, 31  ), Map.Felucca );
			point31.NextPoint = point32;
			point32.MoveToWorld( new Point3D(  1499, 1578, 30  ), Map.Felucca );
			point32.NextPoint = point33;
			point33.MoveToWorld( new Point3D(  1485, 1602, 17  ), Map.Felucca );
			point33.NextPoint = point34;
			point34.MoveToWorld( new Point3D(  1485, 1632, 20  ), Map.Felucca );
			point34.NextPoint = point35;
			point35.MoveToWorld( new Point3D(  1518, 1630, 10  ), Map.Felucca );
			point35.NextPoint = point36;
			point36.MoveToWorld( new Point3D(  1541, 1630, 0  ), Map.Felucca );
			point36.NextPoint = point37;
			point37.MoveToWorld( new Point3D(  1532, 1673, 20  ), Map.Felucca );
			point37.NextPoint = point38;
			point38.MoveToWorld( new Point3D(  1491, 1670, 10  ), Map.Felucca );
			point38.NextPoint = point39;
			point39.MoveToWorld( new Point3D(  1483, 1603, 19  ), Map.Felucca );
			point39.NextPoint = point40;
			point40.MoveToWorld( new Point3D(  1463, 1602, 20  ), Map.Felucca );
			point40.NextPoint = point41;
			point41.MoveToWorld( new Point3D(  1464, 1572, 30  ), Map.Felucca );
			point41.NextPoint = point42;
			point42.MoveToWorld( new Point3D(  1432, 1571, 30  ), Map.Felucca );
			point42.NextPoint = point30;
			spawner4.Name = "BritInvasionFelucca";
			spawner4.Respawn();

			Spawner spawner5 = new Spawner( 3, 5, 15, 30, 90, "Overseer" );
			spawner5.MoveToWorld( new Point3D(  1270, 2060, 0  ), Map.Felucca );
			spawner5.WayPoint = point43;
			point43.MoveToWorld( new Point3D(  1373, 1809, 0  ), Map.Felucca );
			point43.NextPoint = point44;
			point44.MoveToWorld( new Point3D(  1368, 1750, 5  ), Map.Felucca );
			point44.NextPoint = point45;
			point45.MoveToWorld( new Point3D(  1403, 1747, 3  ), Map.Felucca );
			point45.NextPoint = point46;
			point46.MoveToWorld( new Point3D(  1423, 1698, 0  ), Map.Felucca );
			point46.NextPoint = point47;
			point47.MoveToWorld( new Point3D(  1481, 1699, 0  ), Map.Felucca );
			point47.NextPoint = point48;
			point48.MoveToWorld( new Point3D(  1504, 1705, 20  ), Map.Felucca );
			point48.NextPoint = point49;
			point49.MoveToWorld( new Point3D(  1557, 1699, 30  ), Map.Felucca );
			point49.NextPoint = point50;
			point50.MoveToWorld( new Point3D(  1569, 1636, 5  ), Map.Felucca );
			point50.NextPoint = point51;
			point51.MoveToWorld( new Point3D(  1617, 1636, 35  ), Map.Felucca );
			point51.NextPoint = point52;
			point52.MoveToWorld( new Point3D(  1601, 1691, 10  ), Map.Felucca );
			point52.NextPoint = point53;
			point53.MoveToWorld( new Point3D(  1589, 1724, 20  ), Map.Felucca );
			point53.NextPoint = point54;
			point54.MoveToWorld( new Point3D(  1533, 1724, 20  ), Map.Felucca );
			point54.NextPoint = point55;
			point55.MoveToWorld( new Point3D(  1533, 1647, 20  ), Map.Felucca );
			point55.NextPoint = point56;
			point56.MoveToWorld( new Point3D(  1569, 1595, 23  ), Map.Felucca );
			point56.NextPoint = point57;
			point57.MoveToWorld( new Point3D(  1571, 1530, 39  ), Map.Felucca );
			point57.NextPoint = point58;
			point58.MoveToWorld( new Point3D(  1432, 1573, 30  ), Map.Felucca );
			point58.NextPoint = point59;
			point59.MoveToWorld( new Point3D(  1429, 1531, 35  ), Map.Felucca );
			point59.NextPoint = point60;
			point60.MoveToWorld( new Point3D(  1437, 1588, 20  ), Map.Felucca );
			point60.NextPoint = point61;
			point61.MoveToWorld( new Point3D(  1420, 1627, 20  ), Map.Felucca );
			point61.NextPoint = point62;
			point62.MoveToWorld( new Point3D(  1420, 1728, 20  ), Map.Felucca );
			point62.NextPoint = point44;
			spawner5.Name = "BritInvasionFelucca";
			spawner5.Respawn();

			Spawner spawner6 = new Spawner( 3, 5, 15, 0, 10, "Overseer" );
			spawner6.MoveToWorld( new Point3D(  1435, 1498, 34  ), Map.Felucca );
			spawner6.WayPoint = point63;
			point63.MoveToWorld( new Point3D(  1429, 1537, 29  ), Map.Felucca );
			point63.NextPoint = point64;
			point64.MoveToWorld( new Point3D(  1432, 1572, 30  ), Map.Felucca );
			point64.NextPoint = point65;
			point65.MoveToWorld( new Point3D(  1437, 1588, 20  ), Map.Felucca );
			point65.NextPoint = point66;
			point66.MoveToWorld( new Point3D(  1424, 1590, 20  ), Map.Felucca );
			point66.NextPoint = point67;
			point67.MoveToWorld( new Point3D(  1424, 1625, 20  ), Map.Felucca );
			point67.NextPoint = point68;
			point68.MoveToWorld( new Point3D(  1463, 1625, 20  ), Map.Felucca );
			point68.NextPoint = point69;
			point69.MoveToWorld( new Point3D(  1463, 1573, 30  ), Map.Felucca );
			point69.NextPoint = point64;
			spawner6.Name = "BritInvasionFelucca";
			spawner6.Respawn();

			Spawner spawner7 = new Spawner( 3, 5, 15, 30, 0, "Overseer" );
			spawner7.MoveToWorld( new Point3D(  1351, 1757, 17  ), Map.Felucca );
			spawner7.WayPoint = point70;
			point70.MoveToWorld( new Point3D(  1373, 1753, 3  ), Map.Felucca );
			point70.NextPoint = point71;
			point71.MoveToWorld( new Point3D(  1420, 1699, 0  ), Map.Felucca );
			point71.NextPoint = point72;
			point72.MoveToWorld( new Point3D(  1447, 1696, 0  ), Map.Felucca );
			point72.NextPoint = point73;
			point73.MoveToWorld( new Point3D(  1447, 1679, 0  ), Map.Felucca );
			point73.NextPoint = point74;
			point74.MoveToWorld( new Point3D(  1434, 1667, 10  ), Map.Felucca );
			point74.NextPoint = point75;
			point75.MoveToWorld( new Point3D(  1417, 1668, 10  ), Map.Felucca );
			point75.NextPoint = point71;
			spawner7.Name = "BritInvasionFelucca";
			spawner7.Respawn();

			Spawner spawner8 = new Spawner( 3, 10, 20, 30, 10, "Overseer" );
			spawner8.MoveToWorld( new Point3D(  1370, 1749, 3  ), Map.Felucca );
			spawner8.WayPoint = point76;
			point76.MoveToWorld( new Point3D(  1405, 1746, 5  ), Map.Felucca );
			point76.NextPoint = point77;
			point77.MoveToWorld( new Point3D(  1420, 1699, 0  ), Map.Felucca );
			point77.NextPoint = point78;
			point78.MoveToWorld( new Point3D(  1447, 1696, 0  ), Map.Felucca );
			point78.NextPoint = point79;
			point79.MoveToWorld( new Point3D(  1447, 1679, 0  ), Map.Felucca );
			point79.NextPoint = point80;
			point80.MoveToWorld( new Point3D(  1426, 1666, 10  ), Map.Felucca );
			point80.NextPoint = point81;
			point81.MoveToWorld( new Point3D(  1417, 1668, 10  ), Map.Felucca );
			point81.NextPoint = point77;
			spawner8.Name = "BritInvasionFelucca";
			spawner8.Respawn();
   
                        Spawner spawner9 = new Spawner( 5, 10, 20, 30, 20, "RunicGolem" );
			spawner9.MoveToWorld( new Point3D(  1374, 1793, 2  ), Map.Felucca );
                        spawner9.Name = "BritInvasionFelucca";
			spawner9.Respawn();
   
                        Spawner spawner10 = new Spawner( 5, 10, 20, 30, 20, "RunicGolem" );
			spawner10.MoveToWorld( new Point3D( 1345, 1751, 20 ), Map.Felucca );
                        spawner10.Name = "BritInvasionFelucca";
			spawner10.Respawn();
   
                        Spawner spawner11 = new Spawner( 7, 10, 20, 30, 25, "RunicGolem" );
			spawner11.MoveToWorld( new Point3D( 1436, 1534, 35 ), Map.Felucca );
                        spawner11.Name = "BritInvasionFelucca";
			spawner11.Respawn();

                        Spawner spawner12 = new Spawner( 2, 1, 21, 30, 1, "MetalDaemon" );
			spawner12.MoveToWorld( new Point3D( 1523, 1513, 8 ), Map.Felucca );
                        spawner12.Name = "BritInvasionFelucca";
			spawner12.Respawn();
   
                        Spawner spawner13 = new Spawner( 5, 10, 20, 30, 10, "RunicGolem" );
			spawner13.MoveToWorld( new Point3D( 1576, 1529, 39 ), Map.Felucca );
                        spawner13.Name = "BritInvasionFelucca";
			spawner13.Respawn();
   
                        Spawner spawner14 = new Spawner( 4, 10, 20, 30, 10, "RunicGolem" );
			spawner14.MoveToWorld( new Point3D( 1546, 1579, 20 ), Map.Felucca );
                        spawner14.Name = "BritInvasionFelucca";
			spawner14.Respawn();

                        Spawner spawner15 = new Spawner( 4, 10, 20, 30, 10, "RunicGolem" );
			spawner15.MoveToWorld( new Point3D( 1539, 1630, 0 ), Map.Felucca );
                        spawner15.Name = "BritInvasionFelucca";
			spawner15.Respawn();

                        Spawner spawner16 = new Spawner( 4, 10, 20, 30, 10, "RunicGolem" );
			spawner16.MoveToWorld( new Point3D( 1535, 1673, 20 ), Map.Felucca );
                        spawner16.Name = "BritInvasionFelucca";
			spawner16.Respawn();

                        Spawner spawner17 = new Spawner( 4, 10, 20, 30, 10, "RunicGolem" );
			spawner17.MoveToWorld( new Point3D( 1524, 1707, 20 ), Map.Felucca );
                        spawner17.Name = "BritInvasionFelucca";
			spawner17.Respawn();
   
                        Spawner spawner18 = new Spawner( 4, 10, 20, 30, 10, "RunicGolem" );
			spawner18.MoveToWorld( new Point3D( 1477, 1758, -2 ), Map.Felucca );
                        spawner18.Name = "BritInvasionFelucca";
			spawner18.Respawn();

                        Spawner spawner19 = new Spawner( 4, 10, 20, 30, 10, "RunicGolem" );
			spawner19.MoveToWorld( new Point3D( 1441, 1763, -2 ), Map.Felucca );
                        spawner19.Name = "BritInvasionFelucca";
			spawner19.Respawn();
   
                        Spawner spawner20 = new Spawner( 2, 10, 10, 30, 10, "IronDragon" );
			spawner20.MoveToWorld( new Point3D( 1386, 1626, 30 ), Map.Felucca );
                        spawner20.Name = "BritInvasionFelucca";
			spawner20.Respawn();

                        Spawner spawner21 = new Spawner( 2, 10, 10, 30, 10, "MechGargoyle" );
			spawner21.MoveToWorld( new Point3D( 1401, 1745, 2 ), Map.Felucca );
                        spawner21.Name = "BritInvasionFelucca";
			spawner21.Respawn();
   
                        Spawner spawner29 = new Spawner( 2, 10, 10, 30, 10, "MechGargoyle" );
			spawner29.MoveToWorld( new Point3D( 1429, 1567, 30 ), Map.Felucca );
                        spawner29.Name = "BritInvasionFelucca";
			spawner29.Respawn();

                        Spawner spawner22 = new Spawner( 2, 10, 10, 30, 10, "MechGargoyle" );
			spawner22.MoveToWorld( new Point3D( 1476, 1537, 30 ), Map.Felucca );
                        spawner22.Name = "BritInvasionFelucca";
			spawner22.Respawn();

                        Spawner spawner23 = new Spawner( 2, 10, 10, 30, 10, "MechGargoyle" );
			spawner23.MoveToWorld( new Point3D( 1532, 1530, 40 ), Map.Felucca );
                        spawner23.Name = "BritInvasionFelucca";
			spawner23.Respawn();

                        Spawner spawner24 = new Spawner( 2, 10, 10, 30, 10, "MechGargoyle" );
			spawner24.MoveToWorld( new Point3D( 1513, 1582, 20 ), Map.Felucca );
                        spawner24.Name = "BritInvasionFelucca";
			spawner24.Respawn();

                        Spawner spawner25 = new Spawner( 2, 10, 10, 30, 10, "MechGargoyle" );
			spawner25.MoveToWorld( new Point3D( 1513, 1628, 10 ), Map.Felucca );
                        spawner25.Name = "BritInvasionFelucca";
			spawner25.Respawn();

                        Spawner spawner26 = new Spawner( 2, 10, 10, 30, 10, "MechGargoyle" );
			spawner26.MoveToWorld( new Point3D( 1512, 1673, 20 ), Map.Felucca );
                        spawner26.Name = "BritInvasionFelucca";
			spawner26.Respawn();

                        Spawner spawner27 = new Spawner( 2, 10, 10, 30, 10, "MechGargoyle" );
			spawner27.MoveToWorld( new Point3D( 1502, 1705, 20 ), Map.Felucca );
                        spawner27.Name = "BritInvasionFelucca";
			spawner27.Respawn();

                        Spawner spawner28 = new Spawner( 5, 20, 20, 30, 20, "MechGargoyle" );
			spawner28.MoveToWorld( new Point3D( 1455, 1734, 0 ), Map.Felucca );
                        spawner28.Name = "BritInvasionFelucca";
			spawner28.Respawn();

                        Spawner spawner30 = new Spawner( 1, 1, 1, 30, 1, "IronDragon" );
			spawner30.MoveToWorld( new Point3D( 1523, 1476, 20 ), Map.Felucca );
                        spawner30.Name = "BritInvasionFelucca";
			spawner30.Respawn();
   
                        Spawner spawner31 = new Spawner( 2, 10, 10, 30, 10, "ExodusOverseer" );
			spawner31.MoveToWorld( new Point3D( 1420, 1697, 0 ), Map.Felucca );
                        spawner31.Name = "BritInvasionFelucca";
			spawner31.Respawn();

                        Spawner spawner32 = new Spawner( 2, 10, 10, 30, 10, "ExodusOverseer" );
			spawner32.MoveToWorld( new Point3D( 1419, 1626, 20 ), Map.Felucca );
                        spawner32.Name = "BritInvasionFelucca";
			spawner32.Respawn();

                        Spawner spawner33 = new Spawner( 30, 150, 150, 30, 150, "Golem" );
			spawner33.MoveToWorld( new Point3D( 1475, 1651, 10 ), Map.Felucca );
                        spawner33.Name = "BritInvasionFelucca";
			spawner33.Respawn();

                        Spawner spawner34 = new Spawner( 2, 10, 10, 30, 10, "ExodusOverseer" );
			spawner34.MoveToWorld( new Point3D( 1461, 1583, 20 ), Map.Felucca );
                        spawner34.Name = "BritInvasionFelucca";
			spawner34.Respawn();

                        Spawner spawner35 = new Spawner( 2, 10, 10, 30, 10, "ExodusOverseer" );
			spawner35.MoveToWorld( new Point3D( 1484, 1613, 20 ), Map.Felucca );
                        spawner35.Name = "BritInvasionFelucca";
			spawner35.Respawn();

                        Spawner spawner36 = new Spawner( 30, 150, 150, 30, 150, "Overseer" );
			spawner36.MoveToWorld( new Point3D( 1475, 1657, 10 ), Map.Felucca );
                        spawner36.Name = "BritInvasionFelucca";
			spawner36.Respawn();

                        Spawner spawner37 = new Spawner( 2, 5, 5, 30, 5, "ExodusOverseer" );
			spawner37.MoveToWorld( new Point3D( 1478, 1704, 20 ), Map.Felucca );
                        spawner37.Name = "BritInvasionFelucca";
			spawner37.Respawn();

                        Spawner spawner38 = new Spawner( 2, 5, 5, 30, 5, "ExodusOverseer" );
			spawner38.MoveToWorld( new Point3D( 1454, 1698, 20 ), Map.Felucca );
                        spawner38.Name = "BritInvasionFelucca";
			spawner38.Respawn();

                        Spawner spawner39 = new Spawner( 2, 5, 5, 30, 5, "ExodusOverseer" );
			spawner39.MoveToWorld( new Point3D( 1512, 1641, 20 ), Map.Felucca );
                        spawner39.Name = "BritInvasionFelucca";
			spawner39.Respawn();

                        Spawner spawner40 = new Spawner( 4, 5, 5, 30, 5, "RunicGolem" );
			spawner40.MoveToWorld( new Point3D( 1523, 1453, 15 ), Map.Felucca );
                        spawner40.Name = "BritInvasionFelucca";
			spawner40.Respawn();
   
                        Spawner spawner41 = new Spawner( 2, 10, 10, 30, 4, "MechGargoyle" );
			spawner41.MoveToWorld( new Point3D( 1524, 1441, 15 ), Map.Felucca );
                        spawner41.Name = "BritInvasionFelucca";
			spawner41.Respawn();
   
                        Spawner spawner42 = new Spawner( 8, 10, 10, 30, 20, "ExodusOverseer" );
			spawner42.MoveToWorld( new Point3D( 1524, 1446, 15 ), Map.Felucca );
                        spawner42.Name = "BritInvasionFelucca";
			spawner42.Respawn();

                        Spawner spawner43 = new Spawner( 8, 10, 10, 30, 20, "ExodusOverseer" );
			spawner43.MoveToWorld( new Point3D( 1525, 1427, 15 ), Map.Felucca );
                        spawner43.Name = "BritInvasionFelucca";
			spawner43.Respawn();
   
                        Spawner spawner44 = new Spawner( 1, 1, 1, 30, 1, "IronDragon" );
			spawner44.MoveToWorld( new Point3D( 1518, 1428, 15 ), Map.Felucca );
                        spawner44.Name = "BritInvasionFelucca";
			spawner44.Respawn();
   
                        Spawner spawner45 = new Spawner( 2, 1, 21, 30, 1, "MetalDaemon" );
			spawner45.MoveToWorld( new Point3D( 1516, 1434, 15 ), Map.Felucca );
                        spawner45.Name = "BritInvasionFelucca";
			spawner45.Respawn();
   
                        Spawner spawner46 = new Spawner( 8, 1, 1, 30, 10, "ExodusOverseer" );
			spawner46.MoveToWorld( new Point3D( 1529, 1427, 35 ), Map.Felucca );
                        spawner46.Name = "BritInvasionFelucca";
			spawner46.Respawn();
   
                        Spawner spawner47 = new Spawner( 2, 1, 1, 30, 10, "MetalDaemon" );
			spawner47.MoveToWorld( new Point3D( 1525, 1418, 35 ), Map.Felucca );
                        spawner47.Name = "BritInvasionFelucca";
			spawner47.Respawn();
   
                        Spawner spawner48 = new Spawner( 2, 5, 5, 30, 5, "RunicGolem" );
			spawner48.MoveToWorld( new Point3D( 1526, 1417, 15 ), Map.Felucca );
                        spawner48.Name = "BritInvasionFelucca";
			spawner48.Respawn();
   
                        Spawner spawner49 = new Spawner( 1, 1, 1, 30, 1, "IronDragon" );
			spawner49.MoveToWorld( new Point3D( 1524, 1415, 56 ), Map.Felucca );
                        spawner49.Name = "BritInvasionFelucca";
			spawner49.Respawn();
   
                        Spawner spawner50 = new Spawner( 6, 1, 1, 30, 10, "RunicGolem" );
			spawner50.MoveToWorld( new Point3D( 1526, 1417, 55 ), Map.Felucca );
                        spawner50.Name = "BritInvasionFelucca";
			spawner50.Respawn();
   
                        Spawner spawner51 = new Spawner( 6, 1, 1, 30, 10, "ExodusOverseer" );
			spawner51.MoveToWorld( new Point3D( 1529, 1427, 55 ), Map.Felucca );
                        spawner51.Name = "BritInvasionFelucca";
			spawner51.Respawn();
   
                        Spawner spawner52 = new Spawner( 1, 1, 1, 30, 1, "IronDragon" );
			spawner52.MoveToWorld( new Point3D( 1530, 1423, 55 ), Map.Felucca );
                        spawner52.Name = "BritInvasionFelucca";
			spawner52.Respawn();
   
                        Spawner spawner53 = new Spawner( 2, 1, 1, 30, 1, "MechGargoyle" );
			spawner53.MoveToWorld( new Point3D( 1533, 1415, 56 ), Map.Felucca );
                        spawner53.Name = "BritInvasionFelucca";
			spawner53.Respawn();
   
                        Spawner spawner54 = new Spawner( 1, 1, 1, 30, 1, "BlackthornClone" );
			spawner54.MoveToWorld( new Point3D( 1540, 1415, 55 ), Map.Felucca );
                        spawner54.Name = "BritInvasionFelucca";
			spawner54.Respawn();
   
                        Spawner spawner55 = new Spawner( 4, 5, 5, 30, 5, "RunicGolem" );
			spawner55.MoveToWorld( new Point3D( 1537, 1516, 32 ), Map.Felucca );
                        spawner55.Name = "BritInvasionFelucca";
			spawner55.Respawn();
   //<---------
                        Spawner spawner56 = new Spawner( 1, 1, 1, 30, 1, "IronDragon" );
			spawner56.MoveToWorld( new Point3D( 1517, 1433, -25 ), Map.Felucca );
                        spawner56.Name = "BritInvasionFelucca";
			spawner56.Respawn();
   
                        Spawner spawner57 = new Spawner( 3, 2, 2, 30, 2, "ExodusOverseer" );
			spawner57.MoveToWorld( new Point3D( 1517, 1433, -25 ), Map.Felucca );
                        spawner57.Name = "BritInvasionFelucca";
			spawner57.Respawn();
   
                        Spawner spawner58 = new Spawner( 4, 10, 10, 30, 10, "MetalDaemon" );
			spawner58.MoveToWorld( new Point3D( 6045, 1400, 30 ), Map.Felucca );
                        spawner58.Name = "BritInvasionFelucca";
			spawner58.Respawn();
   
                                           World.Broadcast( 33, true, "Britian Felucca is under invasion." );
		               from.SendGump( new CityInvasion( from ) );
                                   	 break; 
                            }  
		case 2:
		{
			BritInvasionStone britfel = new BritInvasionStone();
			britfel.StopBritFelucca();
                                          World.Broadcast( 33, true, "Britian Felucca's invasion was successfully beaten back. No more invaders are left in the city." );
  		              from.SendGump( new CityInvasion( from ) );
                                          
                                   	break; 
				}
			}
		}
	}
}
