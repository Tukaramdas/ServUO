using System;
using System.Collections;
using System.Collections.Generic;
using Server.Items;
using Server.Gumps;

namespace Server.Items
{
	public class PsPriceStone : Item
	{
		private static PsPriceInfo[] m_Table;

		[Constructable]
		public PsPriceStone() : base( 0xEDC ) // 3804
		{
			Name = "a Powerscroll Price Stone";
			Movable = false;
			m_Table = PsPriceInfo.PsTable;

			Hue = 0x481; // pure white
			Visible = true;
		}

		public PsPriceStone( Serial serial ) : base( serial )
		{ 
		} 

		public override void OnDoubleClick( Mobile from )
		{
			if ( from.AccessLevel < AccessLevel.GameMaster )
				return;

			from.SendGump( new PSPriceGump( 0 ) );

			base.OnDoubleClick( from );
		}

		public override void Serialize( GenericWriter writer )
		{
			base.Serialize( writer );
			writer.Write( (int) 0 ); // version

			// stat prices
			writer.Write( (int)PsPriceInfo.Price25 );
			writer.Write( (int)PsPriceInfo.Price20 );
			writer.Write( (int)PsPriceInfo.Price15 );
			writer.Write( (int)PsPriceInfo.Price10 );
			writer.Write( (int)PsPriceInfo.Price5 );

			writer.Write( m_Table.Length );
			foreach ( PsPriceInfo fo in m_Table )
			{
				writer.Write( (int)fo.PsName );
				writer.Write( (int)fo.Price120 );
				writer.Write( (int)fo.Price115 );
				writer.Write( (int)fo.Price110 );
				writer.Write( (int)fo.Discount );
				writer.Write( (bool)fo.Enabled );
			}
		}

		public override void Deserialize( GenericReader reader )
		{
			base.Deserialize( reader );
			int version = reader.ReadInt();

			// stat scroll prices
			PsPriceInfo.Price25 = reader.ReadInt();
			PsPriceInfo.Price20 = reader.ReadInt();
			PsPriceInfo.Price15 = reader.ReadInt();
			PsPriceInfo.Price10 = reader.ReadInt();
			PsPriceInfo.Price5 = reader.ReadInt();

			int length = reader.ReadInt();
			m_Table = new PsPriceInfo[length];

			for ( int i = 0; i < length; i++ )
			{
				m_Table[i] = new PsPriceInfo( i, (SkillName)reader.ReadInt(), reader.ReadInt(), reader.ReadInt(), reader.ReadInt(), reader.ReadInt(), reader.ReadBool() );
			}
			
			PsPriceInfo.PsTable = m_Table;
		}

	}
}