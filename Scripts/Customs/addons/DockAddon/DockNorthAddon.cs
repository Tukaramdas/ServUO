
////////////////////////////////////////
//                                    //
//   Generated by CEO's YAAAG - V1.2  //
// (Yet Another Arya Addon Generator) //
//                                    //
////////////////////////////////////////
using System;
using Server;
using Server.Items;

namespace Server.Items
{
	public class DockNorthAddon : BaseAddon
	{
        private static int[,] m_AddOnSimpleComponents = new int[,] {
			  {1997, -1, -4, 3}, {1997, -1, -6, 3}, {1997, -1, -3, 3}// 1	2	3	
			, {1997, -1, -5, 3}, {1997, 0, -3, 3}, {1997, 0, -5, 3}// 4	5	6	
			, {1997, 0, -6, 3}, {1997, 1, -3, 3}, {1997, 1, -4, 3}// 7	8	9	
			, {1997, 1, -5, 3}, {1997, 1, -6, 3}, {1997, 2, -3, 3}// 10	11	12	
			, {1997, 2, -4, 3}, {1997, 2, -5, 3}, {1997, 2, -6, 3}// 13	14	15	
			, {1997, 0, -4, 3}, {942, 3, -3, 0}, {942, -2, -3, 0}// 16	17	18	
			, {1997, -6, -4, 3}, {1997, -6, -6, 3}, {1997, -6, -5, 3}// 19	20	21	
			, {1997, -5, -5, 3}, {1997, -5, -6, 3}, {1997, -4, -4, 3}// 22	23	24	
			, {1997, -4, -5, 3}, {1997, -4, -6, 3}, {1997, -3, -4, 3}// 25	26	27	
			, {1997, -3, -5, 3}, {1997, -3, -6, 3}, {1997, -5, -4, 3}// 28	29	30	
			, {1997, -6, -3, 3}, {1997, -5, -3, 3}, {1997, -4, -3, 3}// 31	32	33	
			, {1997, -3, -3, 3}, {1997, -4, -6, 3}, {1997, -3, -6, 3}// 34	35	36	
			, {1997, -2, -6, 3}, {1997, -5, -6, 3}, {1997, -5, -4, 3}// 37	38	39	
			, {1997, -5, -3, 3}, {1997, -5, -5, 3}, {1997, -4, -3, 3}// 40	41	42	
			, {1997, -4, -4, 3}, {1997, -4, -5, 3}, {1997, -3, -3, 3}// 43	44	45	
			, {1997, -3, -5, 3}, {1997, -2, -3, 3}, {1997, -2, -4, 3}// 46	47	48	
			, {1997, -2, -5, 3}, {1997, -3, -4, 3}, {1997, 4, -4, 3}// 49	50	51	
			, {1997, 4, -6, 3}, {1997, 4, -5, 3}, {1997, 2, -4, 3}// 52	53	54	
			, {1997, 2, -6, 3}, {1997, 2, -3, 3}, {1997, 2, -5, 3}// 55	56	57	
			, {1997, 3, -3, 3}, {1997, 3, -4, 3}, {1997, 3, -5, 3}// 58	59	60	
			, {1997, 3, -6, 3}, {1997, 4, -3, 3}, {1997, 4, -3, 3}// 61	62	63	
			, {1997, 4, -5, 3}, {1997, 4, -6, 3}, {1997, 4, -4, 3}// 64	65	66	
			, {1997, -1, 6, 3}, {1997, -1, 7, 3}, {1997, 0, 7, 3}// 67	68	69	
			, {1997, 0, 6, 3}, {1997, 1, 7, 3}, {1997, 1, 6, 3}// 70	71	72	
			, {1997, 2, 7, 3}, {1997, 2, 6, 3}, {1997, -1, 0, 3}// 73	74	75	
			, {1997, -1, -2, 3}, {1997, -1, 1, 3}, {1997, -1, -1, 3}// 76	77	78	
			, {1997, 0, 1, 3}, {1997, 0, -1, 3}, {1997, 0, -2, 3}// 79	80	81	
			, {1997, 1, 1, 3}, {1997, 1, 0, 3}, {1997, 1, -1, 3}// 82	83	84	
			, {1997, 1, -2, 3}, {1997, 2, 1, 3}, {1997, 2, 0, 3}// 85	86	87	
			, {1997, 2, -1, 3}, {1997, 2, -2, 3}, {1997, 0, 0, 3}// 88	89	90	
			, {1997, -1, 4, 3}, {1997, -1, 2, 3}, {1997, -1, 5, 3}// 91	92	93	
			, {1997, -1, 3, 3}, {1997, 0, 5, 3}, {1997, 0, 3, 3}// 94	95	96	
			, {1997, 0, 2, 3}, {1997, 1, 5, 3}, {1997, 1, 4, 3}// 97	98	99	
			, {1997, 1, 3, 3}, {1997, 1, 2, 3}, {1997, 2, 5, 3}// 100	101	102	
			, {1997, 2, 4, 3}, {1997, 2, 3, 3}, {1997, 2, 2, 3}// 103	104	105	
			, {1997, 0, 4, 3}, {942, 2, 2, 0}, {1997, 5, -3, 3}// 106	107	108	
			, {1997, 5, -4, 3}, {1997, 5, -5, 3}, {1997, 5, -6, 3}// 109	110	111	
			, {1997, 6, -4, 3}, {1997, 6, -5, 3}, {1997, 6, -6, 3}// 112	113	114	
			, {1997, 7, -5, 3}, {1997, 7, -6, 3}, {1997, 7, -4, 3}// 115	116	117	
			, {1997, 5, -3, 3}, {1997, 5, -4, 3}, {1997, 5, -5, 3}// 118	119	120	
			, {1997, 5, -6, 3}, {1997, 6, -3, 3}, {1997, 7, -3, 3}// 121	122	123	
			, {942, 7, -6, 0}// 124	
		};

 
            
		public override BaseAddonDeed Deed
		{
			get
			{
				return new DockNorthAddonDeed();
			}
		}

		[ Constructable ]
		public DockNorthAddon()
		{

            for (int i = 0; i < m_AddOnSimpleComponents.Length / 4; i++)
                AddComponent( new AddonComponent( m_AddOnSimpleComponents[i,0] ), m_AddOnSimpleComponents[i,1], m_AddOnSimpleComponents[i,2], m_AddOnSimpleComponents[i,3] );


		}

		public DockNorthAddon( Serial serial ) : base( serial )
		{
		}


		public override void Serialize( GenericWriter writer )
		{
			base.Serialize( writer );
			writer.Write( 0 ); // Version
		}

		public override void Deserialize( GenericReader reader )
		{
			base.Deserialize( reader );
			int version = reader.ReadInt();
		}
	}

	public class DockNorthAddonDeed : BaseAddonDeed
	{
		public override BaseAddon Addon
		{
			get
			{
				return new DockNorthAddon();
			}
		}

		[Constructable]
		public DockNorthAddonDeed()
		{
			Name = "Dock (North)";
		}

		public DockNorthAddonDeed( Serial serial ) : base( serial )
		{
		}

		public override void Serialize( GenericWriter writer )
		{
			base.Serialize( writer );
			writer.Write( 0 ); // Version
		}

		public override void	Deserialize( GenericReader reader )
		{
			base.Deserialize( reader );
			int version = reader.ReadInt();
		}
	}
}