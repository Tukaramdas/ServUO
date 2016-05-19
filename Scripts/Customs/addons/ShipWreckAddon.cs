
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
	public class ShipWreckAddon : BaseAddon
	{
        private static int[,] m_AddOnSimpleComponents = new int[,] {
			  {18370, -3, -2, 0}, {18372, -2, -3, 0}, {13458, -1, -2, 0}// 1	2	3	
			, {6047, -1, -3, 0}, {6054, -2, -3, 0}, {6051, -2, -2, 0}// 4	5	6	
			, {8124, -1, -2, 0}, {3117, -3, -3, 0}, {18368, -3, 0, 0}// 7	8	9	
			, {18374, -4, 0, 0}, {18367, -3, 1, 0}, {18380, -5, 0, 0}// 10	11	12	
			, {18369, -3, -1, 0}, {18379, -5, 1, 0}, {18365, -2, 2, 0}// 13	14	15	
			, {18366, -3, 2, 0}, {18373, -3, 1, 0}, {18378, -4, 2, 0}// 16	17	18	
			, {18373, -4, 1, 0}, {18385, -6, -1, 0}, {18383, -7, 0, 0}// 19	20	21	
			, {18360, -4, -1, 0}, {18387, -7, 0, 0}, {13458, -1, -1, 0}// 22	23	24	
			, {13458, -1, 0, 0}, {13458, -1, 1, 0}, {6050, -1, 2, 0}// 25	26	27	
			, {6051, -2, 1, 0}, {6052, -2, 0, 0}, {6056, -2, 2, 0}// 28	29	30	
			, {6052, -2, -1, 0}, {8124, -1, 0, 0}, {8124, -1, 1, 0}// 31	32	33	
			, {3117, -3, 2, 0}, {3117, -4, 2, 0}, {3117, -4, 3, 0}// 34	35	36	
			, {3117, -6, 2, 0}, {13458, 0, -2, 0}, {6048, 0, -3, 0}// 37	38	39	
			, {6053, 1, -3, 0}, {6046, 1, -2, 0}, {8133, 1, -2, 0}// 40	41	42	
			, {18599, 6, -3, 0}, {3117, 7, -3, 0}, {3117, 7, -2, 0}// 43	44	45	
			, {3117, 4, -3, 0}, {13458, 0, 1, 0}, {13458, 0, 0, 0}// 46	47	48	
			, {13458, 0, -1, 0}, {6050, 0, 2, 0}, {6055, 1, 2, 0}// 49	50	51	
			, {6045, 1, 1, 0}, {6046, 1, 0, 0}, {6046, 1, -1, 0}// 52	53	54	
			, {8133, 1, 2, 0}, {8133, 1, 0, 0}, {18685, 5, 0, 0}// 55	56	57	
			, {18684, 4, 0, 0}, {18696, 3, 2, 0}, {18691, 4, 1, 0}// 58	59	60	
			, {18596, 6, 0, 0}, {18680, 6, -1, 0}, {18686, 7, 0, 0}// 61	62	63	
			, {18692, 5, 1, 0}, {18693, 6, 1, 0}, {18697, 4, 2, 0}// 64	65	66	
			, {18694, 7, 1, 0}, {18687, 8, 0, 0}, {18673, 8, -1, 0}// 67	68	69	
			, {3117, 4, 2, 0}, {3117, 8, 0, 0}// 70	71	
		};

 
            
		public override BaseAddonDeed Deed
		{
			get
			{
				return new ShipWreckAddonDeed();
			}
		}

		[ Constructable ]
		public ShipWreckAddon()
		{

            for (int i = 0; i < m_AddOnSimpleComponents.Length / 4; i++)
                AddComponent( new AddonComponent( m_AddOnSimpleComponents[i,0] ), m_AddOnSimpleComponents[i,1], m_AddOnSimpleComponents[i,2], m_AddOnSimpleComponents[i,3] );


		}

		public ShipWreckAddon( Serial serial ) : base( serial )
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

	public class ShipWreckAddonDeed : BaseAddonDeed
	{
		public override BaseAddon Addon
		{
			get
			{
				return new ShipWreckAddon();
			}
		}

		[Constructable]
		public ShipWreckAddonDeed()
		{
			Name = "ShipWreck";
		}

		public ShipWreckAddonDeed( Serial serial ) : base( serial )
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