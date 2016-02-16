using System;
using System.Collections;
using System.IO;
using Server;
using Server.Mobiles; 
using Server.Items;
using Server.Commands; 
using Server.Network;
using Server.Gumps;

namespace Server.Commands 
{
	public static class PsPriceCommand
	{
		public static void Initialize()
		{
			CommandSystem.Register( "PSPrice", AccessLevel.Administrator, new CommandEventHandler( PSPrice_OnCommand ) );
			CommandSystem.Register( "CSPrice", AccessLevel.Administrator, new CommandEventHandler( CSPrice_OnCommand ) );
		}

		[Usage( "PSPrice" )]
		[Description( "Setting PowerScroll Prices." )]
		private static void PSPrice_OnCommand( CommandEventArgs e )
		{
			e.Mobile.SendGump( new PSPriceGump( 0 ) );
		}
		
		[Usage( "CSPrice" )]
		[Description( "Setting StatScroll Prices." )]
		private static void CSPrice_OnCommand( CommandEventArgs e )
		{
			e.Mobile.SendGump( new SetPsPriceGump( 200, false, 0 ) ); // 200 - dummy number indicating a stat scroll, must be greater than 0
		}
	}
}

namespace Server.Items
{
	public class PSPriceGump : Gump
	{
		public static readonly int GumpOffsetX = PropsConfig.GumpOffsetX;
		public static readonly int GumpOffsetY = PropsConfig.GumpOffsetY;

		public static readonly int TextHue = PropsConfig.TextHue;
		public static readonly int TextOffsetX = PropsConfig.TextOffsetX;

		public static readonly int OffsetGumpID = PropsConfig.OffsetGumpID;
		public static readonly int HeaderGumpID = PropsConfig.HeaderGumpID;
		public static readonly int 	EntryGumpID = PropsConfig.EntryGumpID;
		public static readonly int   BackGumpID = PropsConfig.BackGumpID;
		public static readonly int    SetGumpID = PropsConfig.SetGumpID;

		public static readonly int SetWidth = PropsConfig.SetWidth;
		public static readonly int SetOffsetX = PropsConfig.SetOffsetX, SetOffsetY = PropsConfig.SetOffsetY;
		public static readonly int SetButtonID1 = PropsConfig.SetButtonID1;
		public static readonly int SetButtonID2 = PropsConfig.SetButtonID2;

		public static readonly int PrevWidth = PropsConfig.PrevWidth;
		public static readonly int NextWidth = PropsConfig.NextWidth;

		public static readonly int PrevOffsetX = PropsConfig.PrevOffsetX, PrevOffsetY = PropsConfig.PrevOffsetY;
		public static readonly int PrevButtonID1 = PropsConfig.PrevButtonID1;
		public static readonly int PrevButtonID2 = PropsConfig.PrevButtonID2;

		public static readonly int NextOffsetX = PropsConfig.NextOffsetX, NextOffsetY = PropsConfig.NextOffsetY;
		public static readonly int NextButtonID1 = PropsConfig.NextButtonID1;
		public static readonly int NextButtonID2 = PropsConfig.NextButtonID2;

		public static readonly int OffsetSize = PropsConfig.OffsetSize;

		public static readonly int EntryHeight = PropsConfig.EntryHeight;
		public static readonly int BorderSize = PropsConfig.BorderSize;

		private static readonly int HeaderTextHue = 777;
		private static readonly int Width120 = 100;
		private static readonly int Width115 = 90;
		private static readonly int Width110 = 80;
		private static readonly int WidthDiscount = 50;
		private static readonly int WidthEnabled = 80;

		private static readonly int NameWidth = 107;
		private static readonly int ValueWidth = Width120 + BorderSize + Width115 + BorderSize + Width110 + BorderSize + WidthDiscount + BorderSize + WidthEnabled;
		private static readonly int EntryCount = 19;

		private static readonly int TotalWidth = OffsetSize + NameWidth + OffsetSize + ValueWidth + OffsetSize + SetWidth + OffsetSize;
		private static readonly int TotalHeight = OffsetSize + ((EntryHeight + OffsetSize) * (EntryCount + 1));

		private static readonly int BackWidth = BorderSize + TotalWidth + BorderSize;

		private int m_Page;


		public PSPriceGump( int page ) : base( GumpOffsetX, GumpOffsetY )
		{
			m_Page = page;

			Initialize( page );
		}

		private void Initialize( int page )
		{
			PsPriceInfo info;

			int count = PsPriceInfo.PsTable.Length - (page * EntryCount);

			if ( count < 0 )
				count = 0;
			else if ( count > EntryCount )
				count = EntryCount;

			int lastIndex = (page * EntryCount) + count - 1;

			if ( lastIndex >= 0 && lastIndex < PsPriceInfo.PsTable.Length && PsPriceInfo.PsTable[lastIndex] == null )
				--count;

			int totalHeight = OffsetSize + ((EntryHeight + OffsetSize) * (count + 1));

			AddPage( 0 );

			AddBackground( 0, 0, BackWidth, BorderSize + totalHeight + BorderSize, BackGumpID );
			AddImageTiled( BorderSize, BorderSize, TotalWidth, totalHeight, OffsetGumpID );

			int x = BorderSize + OffsetSize;
			int y = BorderSize + OffsetSize;

			int emptyWidth = TotalWidth - PrevWidth - NextWidth - (OffsetSize * 4);
			AddImageTiled( x, y, PrevWidth, EntryHeight, HeaderGumpID );


			if ( page > 0 )
			{
				AddButton( x + PrevOffsetX, y + PrevOffsetY, PrevButtonID1, PrevButtonID2, 1, GumpButtonType.Reply, 0 );
			}

			x += PrevWidth + OffsetSize;
			AddImageTiled( x, y, emptyWidth, EntryHeight, HeaderGumpID );

			x += NameWidth - PrevWidth + OffsetSize;
			AddLabelCropped( x + TextOffsetX, y, Width120 - TextOffsetX, EntryHeight, HeaderTextHue, "Price120" );
			x += Width120 + BorderSize;
			AddLabelCropped( x + TextOffsetX, y, Width115 - TextOffsetX, EntryHeight, HeaderTextHue, "Price115" );
			x += Width115 + BorderSize;
			AddLabelCropped( x + TextOffsetX, y, Width110 - TextOffsetX, EntryHeight, HeaderTextHue, "Price110" );
			x += Width110 + BorderSize;
			AddLabelCropped( x + TextOffsetX, y, WidthDiscount - TextOffsetX, EntryHeight, HeaderTextHue, "Discount" );
			x += WidthDiscount + BorderSize;
			AddLabelCropped( x + TextOffsetX, y, WidthEnabled - TextOffsetX, EntryHeight, HeaderTextHue, "Enabled" );
			x += WidthEnabled + OffsetSize;


//			x += emptyWidth + OffsetSize;
			AddImageTiled( x, y, NextWidth, EntryHeight, HeaderGumpID );

			if ( (page + 1) * EntryCount < PsPriceInfo.PsTable.Length )
			{
				AddButton( x + NextOffsetX, y + NextOffsetY, NextButtonID1, NextButtonID2, 2, GumpButtonType.Reply, 1 );
			}

			for ( int i = 0, index = page * EntryCount; i < count && index < PsPriceInfo.PsTable.Length; ++i, ++index )
			{
				x = BorderSize + OffsetSize;
				y += EntryHeight + OffsetSize;


				info = PsPriceInfo.PsTable[index] as PsPriceInfo;

				AddImageTiled( x, y, NameWidth, EntryHeight, EntryGumpID );
				AddLabelCropped( x + TextOffsetX, y, NameWidth - TextOffsetX, EntryHeight, TextHue, info.PsName.ToString() );
				x += NameWidth + OffsetSize;
				AddImageTiled( x, y, ValueWidth, EntryHeight, EntryGumpID );
				AddLabelCropped( x + TextOffsetX, y, Width120 - TextOffsetX, EntryHeight, TextHue, info.Price120.ToString() );
				x += Width120 + BorderSize;
				AddLabelCropped( x + TextOffsetX, y, Width115 - TextOffsetX, EntryHeight, TextHue, info.Price115.ToString() );
				x += Width115 + BorderSize;
				AddLabelCropped( x + TextOffsetX, y, Width110 - TextOffsetX, EntryHeight, TextHue, info.Price110.ToString() );
				x += Width110 + BorderSize;
				AddLabelCropped( x + TextOffsetX, y, WidthDiscount - TextOffsetX, EntryHeight, TextHue, info.Discount.ToString() );
				x += WidthDiscount + BorderSize;
				AddLabelCropped( x + TextOffsetX, y, WidthEnabled - TextOffsetX, EntryHeight, TextHue, info.Enabled.ToString() );
				x += WidthEnabled + OffsetSize;


				if ( SetGumpID != 0 )
					AddImageTiled( x, y, SetWidth, EntryHeight, SetGumpID );

				AddButton( x + SetOffsetX, y + SetOffsetY, SetButtonID1, SetButtonID2, i + 10, GumpButtonType.Reply, 0 );


			}
		}

		public override void OnResponse( NetState state, RelayInfo info )
		{
			Mobile from = state.Mobile;
			
			switch ( info.ButtonID )
			{
				case 0: // Closed
				{
					break;
				}
				case 1: // Previous
				{
					if ( m_Page > 0 )
						from.SendGump( new PSPriceGump( m_Page - 1 ) );

					break;
				}
				case 2: // Next
				{
					if ( (m_Page + 1) * EntryCount < PsPriceInfo.PsTable.Length )
						from.SendGump( new PSPriceGump( m_Page + 1 ) );

					break;
				}
				default:
				{
					int index = ( m_Page * EntryCount ) + ( info.ButtonID - 10 );

					if ( index >= 0 && index < PsPriceInfo.PsTable.Length )
					{
						from.SendGump( new SetPsPriceGump( index, true, m_Page ) );
					}

					break;
				}
			}
		}
	}

	public class SetPsPriceGump : Gump
	{
		public static readonly int GumpOffsetX = PropsConfig.GumpOffsetX;
		public static readonly int GumpOffsetY = PropsConfig.GumpOffsetY;

		public static readonly int TextHue = PropsConfig.TextHue;
		public static readonly int TextOffsetX = PropsConfig.TextOffsetX;

		public static readonly int OffsetGumpID = PropsConfig.OffsetGumpID;
		public static readonly int 	EntryGumpID = PropsConfig.EntryGumpID;
		public static readonly int   BackGumpID = PropsConfig.BackGumpID;
		public static readonly int    SetGumpID = PropsConfig.SetGumpID;

		public static readonly int SetWidth = PropsConfig.SetWidth;
		public static readonly int SetOffsetX = PropsConfig.SetOffsetX, SetOffsetY = PropsConfig.SetOffsetY;
		public static readonly int SetButtonID1 = PropsConfig.SetButtonID1;
		public static readonly int SetButtonID2 = PropsConfig.SetButtonID2;

		public static readonly int OffsetSize = PropsConfig.OffsetSize;

		public static readonly int EntryHeight = PropsConfig.EntryHeight;
		public static readonly int BorderSize = PropsConfig.BorderSize;

		private static readonly int HeaderTextHue = 777;

		private static readonly int NameWidth = 107;
		private static readonly int ValueWidth = 128;
		private static readonly int EntryCount = 5;

		private static readonly int TotalWidth = OffsetSize + NameWidth + OffsetSize + ValueWidth + OffsetSize + SetWidth + OffsetSize;
		private static readonly int TotalHeight = OffsetSize + ((EntryHeight + OffsetSize) * (EntryCount + 1));

		private static readonly int BackWidth = BorderSize + TotalWidth + BorderSize;

		private int m_Skill;
		private bool m_IsPs;
		private int m_Page;

		public SetPsPriceGump( int skill, bool isPs, int page ) : base( GumpOffsetX, GumpOffsetY )
		{
			string name = "";
			string sval = "";
			m_Skill = skill;
			m_IsPs = isPs;
			m_Page = page;
			int bt = 10;

			AddPage( 0 );

			AddBackground( 0, 0, BackWidth, BorderSize + TotalHeight + BorderSize, BackGumpID );
			AddImageTiled( BorderSize, BorderSize, TotalWidth, TotalHeight, OffsetGumpID );

			int x = BorderSize + OffsetSize;
			int y = BorderSize + OffsetSize;

			AddLabelCropped( x + TextOffsetX, y, NameWidth - TextOffsetX, EntryHeight, HeaderTextHue, isPs ? ((SkillName)skill).ToString() : "StatCapScroll" );

			for ( int i = 0; i < 5; i++ )
			{
				x = BorderSize + OffsetSize;
				y += EntryHeight + OffsetSize;

				if ( isPs )
				{
					PsPriceInfo info = PsPriceInfo.PsTable[skill] as PsPriceInfo;
	
					switch ( i )
					{
						case 0: name = "Price120"; sval = info.Price120.ToString(); break;
						case 1: name = "Price115"; sval = info.Price115.ToString(); break;
						case 2: name = "Price110"; sval = info.Price110.ToString(); break;
						case 3: name = "Discount"; sval = info.Discount.ToString(); break;
						case 4: name = "Enabled"; sval = info.Enabled.ToString(); break;
					}
				}
				else
				{
					bt = 20;

					switch ( i )
					{
						case 0: name = "Stat+25"; sval = PsPriceInfo.StatPriceInfo( 250 ).ToString(); break;
						case 1: name = "Stat+20"; sval = PsPriceInfo.StatPriceInfo( 245 ).ToString(); break;
						case 2: name = "Stat+15"; sval = PsPriceInfo.StatPriceInfo( 240 ).ToString(); break;
						case 3: name = "Stat+10"; sval = PsPriceInfo.StatPriceInfo( 235 ).ToString(); break;
						case 4: name = "Stat+5"; sval = PsPriceInfo.StatPriceInfo( 230 ).ToString(); break;
					}
				}


				AddImageTiled( x, y, NameWidth, EntryHeight, EntryGumpID );
				AddLabelCropped( x + TextOffsetX, y, NameWidth - TextOffsetX, EntryHeight, TextHue, name );
				x += NameWidth + OffsetSize;
				AddImageTiled( x, y, ValueWidth, EntryHeight, EntryGumpID );
				AddLabelCropped( x + TextOffsetX, y, ValueWidth - TextOffsetX, EntryHeight, TextHue, sval );
				x += ValueWidth + OffsetSize;

				if ( SetGumpID != 0 )
					AddImageTiled( x, y, SetWidth, EntryHeight, SetGumpID );

				AddButton( x + SetOffsetX, y + SetOffsetY, SetButtonID1, SetButtonID2, i + bt, GumpButtonType.Reply, 0 );

			}
		}

		public override void OnResponse( NetState state, RelayInfo info )
		{
			Mobile from = state.Mobile;

			switch ( info.ButtonID )
			{
				case 0: // Closed
				{
					if ( m_IsPs )
						from.SendGump( new PSPriceGump( m_Page ) );

					break;
				}
				default:
				{
					if ( m_Skill >= 0 )
						from.SendGump( new PsPriceEntryGump( m_Skill, info.ButtonID - 10, m_Page ) );

					break;
				}
			}
		}

	}

	public class PsPriceEntryGump : Gump
	{
		public static readonly int GumpOffsetX = PropsConfig.GumpOffsetX;
		public static readonly int GumpOffsetY = PropsConfig.GumpOffsetY;

		public static readonly int TextHue = PropsConfig.TextHue;
		public static readonly int TextOffsetX = PropsConfig.TextOffsetX;

		public static readonly int OffsetGumpID = PropsConfig.OffsetGumpID;
		public static readonly int HeaderGumpID = PropsConfig.HeaderGumpID;
		public static readonly int  EntryGumpID = PropsConfig.EntryGumpID;
		public static readonly int   BackGumpID = PropsConfig.BackGumpID;
		public static readonly int    SetGumpID = PropsConfig.SetGumpID;

		public static readonly int SetWidth = PropsConfig.SetWidth;
		public static readonly int SetOffsetX = PropsConfig.SetOffsetX, SetOffsetY = PropsConfig.SetOffsetY;
		public static readonly int SetButtonID1 = PropsConfig.SetButtonID1;
		public static readonly int SetButtonID2 = PropsConfig.SetButtonID2;

		public static readonly int PrevWidth = PropsConfig.PrevWidth;
		public static readonly int NextWidth = PropsConfig.NextWidth;

		public static readonly int OffsetSize = PropsConfig.OffsetSize;

		public static readonly int EntryHeight = PropsConfig.EntryHeight;
		public static readonly int BorderSize = PropsConfig.BorderSize;

		private static readonly int EntryWidth = 212;

		private static readonly int TotalWidth = OffsetSize + EntryWidth + OffsetSize + SetWidth + OffsetSize;
		private static readonly int TotalHeight = OffsetSize + (2 * (EntryHeight + OffsetSize));

		private static readonly int BackWidth = BorderSize + TotalWidth + BorderSize;
		private static readonly int BackHeight = BorderSize + TotalHeight + BorderSize;

		private static string[] m_Names = new string[]{ "True", "False" };

		private int m_Skill;
		private int m_Button;
		private int m_Page;
		private bool m_IsPs;

		public PsPriceEntryGump( int skill, int button, int page ) : base( GumpOffsetX, GumpOffsetY )
		{
			m_Skill = skill;
			m_Button = button;
			m_Page = page;
			string title = "";
			string initialText = "";
			bool setbool = false;
			int bt = 0;

			if ( button < 10 ) // PowerScroll
			{
				m_IsPs = true;
				PsPriceInfo info = PsPriceInfo.PsTable[skill] as PsPriceInfo;
				title = ((SkillName)skill).ToString();
	
				switch ( button )
				{
					case 0: { title = title + " Price120"; initialText = info.Price120.ToString(); break; }
					case 1: { title = title + " Price115"; initialText = info.Price115.ToString(); break; }
					case 2: { title = title + " Price110"; initialText = info.Price110.ToString(); break; }
					case 3: { title = title + " Discount"; initialText = info.Discount.ToString(); break; }
					default: { title = title + " Enabled = " + info.Enabled.ToString(); setbool = true; break; }
				}
			}
			else // StatScroll
			{
				m_IsPs = false;
				bt = 10;

				switch ( button )
				{
					case 10: title = "Stat+25"; initialText = PsPriceInfo.StatPriceInfo( 250 ).ToString(); break;
					case 11: title = "Stat+20"; initialText = PsPriceInfo.StatPriceInfo( 245 ).ToString(); break;
					case 12: title = "Stat+15"; initialText = PsPriceInfo.StatPriceInfo( 240 ).ToString(); break;
					case 13: title = "Stat+10"; initialText = PsPriceInfo.StatPriceInfo( 235 ).ToString(); break;
					default: title = "Stat+5"; initialText = PsPriceInfo.StatPriceInfo( 230 ).ToString(); break;
				}
			}

			if ( !setbool )
			{
				AddPage( 0 );
	
				AddBackground( 0, 0, BackWidth, BackHeight, BackGumpID );
				AddImageTiled( BorderSize, BorderSize, TotalWidth, TotalHeight, OffsetGumpID );
	
				int x = BorderSize + OffsetSize;
				int y = BorderSize + OffsetSize;
	
				AddImageTiled( x, y, EntryWidth, EntryHeight, EntryGumpID );
				AddLabelCropped( x + TextOffsetX, y, EntryWidth - TextOffsetX, EntryHeight, TextHue, title );
				x += EntryWidth + OffsetSize;
	
				if ( SetGumpID != 0 )
					AddImageTiled( x, y, SetWidth, EntryHeight, SetGumpID );
	
				x = BorderSize + OffsetSize;
				y += EntryHeight + OffsetSize;
	
				AddImageTiled( x, y, EntryWidth, EntryHeight, EntryGumpID );
				AddTextEntry( x + TextOffsetX, y, EntryWidth - TextOffsetX, EntryHeight, TextHue, 0, initialText );
				x += EntryWidth + OffsetSize;
	
				if ( SetGumpID != 0 )
					AddImageTiled( x, y, SetWidth, EntryHeight, SetGumpID );
	
				AddButton( x + SetOffsetX, y + SetOffsetY, SetButtonID1, SetButtonID2, 1 + bt, GumpButtonType.Reply, 0 );
			}
			else
			{
				AddPage( 0 );

				int totalHeight = OffsetSize + ( 4 * (EntryHeight + OffsetSize));
				int backHeight = BorderSize + totalHeight + BorderSize;

				AddBackground( 0, 0, BackWidth, backHeight, BackGumpID );
				AddImageTiled( BorderSize, BorderSize, TotalWidth, totalHeight, OffsetGumpID );

				int x = BorderSize + OffsetSize;
				int y = BorderSize + OffsetSize;

				int emptyWidth = TotalWidth - PrevWidth - NextWidth - ( OffsetSize * 4 );

				AddImageTiled( x, y, PrevWidth, EntryHeight, HeaderGumpID );

				x += PrevWidth + OffsetSize;
				AddImageTiled( x, y, emptyWidth, EntryHeight, HeaderGumpID );

				x += emptyWidth + OffsetSize;
				AddImageTiled( x, y, NextWidth, EntryHeight, HeaderGumpID );


				AddRect( 0, title, 0 );

				for ( int i = 0; i < 2; ++i )
					AddRect( i + 1, m_Names[i], i + 2 );
			}
		}

		private void AddRect( int index, string str, int button )
		{
			int x = BorderSize + OffsetSize;
			int y = BorderSize + OffsetSize + ((index + 1) * (EntryHeight + OffsetSize));

			AddImageTiled( x, y, EntryWidth, EntryHeight, EntryGumpID );
			AddLabelCropped( x + TextOffsetX, y, EntryWidth - TextOffsetX, EntryHeight, TextHue, str );

			x += EntryWidth + OffsetSize;

			if ( SetGumpID != 0 )
				AddImageTiled( x, y, SetWidth, EntryHeight, SetGumpID );

			if ( button != 0 )
				AddButton( x + SetOffsetX, y + SetOffsetY, SetButtonID1, SetButtonID2, button, GumpButtonType.Reply, 0 );
		}

		public override void OnResponse( NetState state, RelayInfo info )
		{
			Mobile from = state.Mobile;

//			from.SendMessage( "I received! {0}", info.ButtonID ); // for debug

			switch ( info.ButtonID )
			{
				case 0: // Closed
				{
					if ( m_IsPs )
						from.SendGump( new PSPriceGump( m_Page ) );

					break;
				}

				case 1:
				{
					TextRelay text = info.GetTextEntry( 0 );

					int value;
					bool parsed = Int32.TryParse( text.Text, out value );

					if ( parsed )
					{
						value = ( value > 100000000 ? 100000000 : value );
						PsPriceInfo fo = PsPriceInfo.PsTable[m_Skill] as PsPriceInfo;
						PsPriceInfo ps;

						switch ( m_Button )
						{
							case 0: { ps = new PsPriceInfo( m_Skill, (SkillName)m_Skill, ( value > 20000 ) ? value : 20000, fo.Price115, fo.Price110, fo.Discount, fo.Enabled ); break; }
							case 1: { ps = new PsPriceInfo( m_Skill, (SkillName)m_Skill, fo.Price120, ( value > 1000 ) ? value : fo.Price115, fo.Price110, fo.Discount, fo.Enabled ); break; }
							case 2: { ps = new PsPriceInfo( m_Skill, (SkillName)m_Skill, fo.Price120, fo.Price115, ( value > 1000 ) ? value : fo.Price110, fo.Discount, fo.Enabled ); break; }
							default: { ps = new PsPriceInfo( m_Skill, (SkillName)m_Skill, fo.Price120, fo.Price115, fo.Price110, ( value >=0 && value < 100 ) ? value : fo.Discount, fo.Enabled ); break; }
						}

						PsPriceInfo.UpdatePriceInfo( m_Skill, ps );
					}

					from.SendGump( new PSPriceGump( m_Page ) );
					break;
				}

				default:
				{
					if ( info.ButtonID == 2 || info.ButtonID == 3 )
					{ 
						bool bval = false;

						if ( info.ButtonID == 2 )
							bval = true;

						PsPriceInfo fo = PsPriceInfo.PsTable[m_Skill] as PsPriceInfo;
						if ( fo.Enabled != bval )
						{
							PsPriceInfo ps = new PsPriceInfo( m_Skill, (SkillName)m_Skill, fo.Price120, fo.Price115, fo.Price110, fo.Discount, bval );
							PsPriceInfo.UpdatePriceInfo( m_Skill, ps );
						}

						from.SendGump( new PSPriceGump( m_Page ) );
					}
					else if ( info.ButtonID == 11 ) // StatScrolls
					{
						TextRelay text = info.GetTextEntry( 0 );

						int value;
						bool parsed = Int32.TryParse( text.Text, out value );
	
						if ( parsed )
						{
							value = ( value > 100000000 ? 100000000 : value );

							switch ( m_Button )
							{
								case 10: PsPriceInfo.Price25 = value; break;
								case 11: PsPriceInfo.Price20 = value; break;
								case 12: PsPriceInfo.Price15 = value; break;
								case 13: PsPriceInfo.Price10 = value; break;
								case 14: PsPriceInfo.Price5 = value; break;
							}
						}

						from.SendGump( new SetPsPriceGump( m_Skill, false, m_Page ) );
					}

					break;
				}
			}
		}

	}

	public class PsPriceInfo
	{
		private int m_SeqID;
		private SkillName m_SkillName;
		private int m_Price120;
		private int m_Price115;
		private int m_Price110;
		private int m_Discount;
		private bool m_Enabled;

		// for statscrolls
		private static int m_Price25;
		private static int m_Price20;
		private static int m_Price15;
		private static int m_Price10;
		private static int m_Price5;

		public int PsID {	get{ return m_SeqID; } }
		public SkillName PsName {	get{ return m_SkillName; } }
		public int Price120 {	get{ return m_Price120; } }
		public int Price115 {	get{ return m_Price115; } }
		public int Price110 {	get{ return m_Price110; } }
		public int Discount {	get{ return m_Discount; } }
		public bool Enabled {	get{ return m_Enabled; } }

		// for statscrolls
		public static int Price25
		{
			get{ return m_Price25; }
			set{ m_Price25 = value > 100000000 ? 100000000 : value; }
		}

		public static int Price20
		{
			get{ return m_Price20; }
			set{ m_Price20 = value > 100000000 ? 100000000 : value; }
		}

		public static int Price15
		{
			get{ return m_Price15; }
			set{ m_Price15 = value > 100000000 ? 100000000 : value; }
		}

		public static int Price10
		{
			get{ return m_Price10; }
			set{ m_Price10 = value > 100000000 ? 100000000 : value; }
		}

		public static int Price5
		{
			get{ return m_Price5; }
			set{ m_Price5 = value > 100000000 ? 100000000 : value; }
		}

		public static PsPriceInfo[] PsTable
		{
			get{ return m_PsTable; }
			set{ m_PsTable = value; }
		}


		public PsPriceInfo( int seqID, SkillName skill, int price120, int price115, int price110, int discount, bool enabled )
		{
			m_SeqID = seqID;
			m_SkillName = skill;
			m_Price120 = price120;
			m_Price115 = price115;
			m_Price110 = price110;
			m_Discount = discount;
			m_Enabled = enabled;

			m_Price25 = 1200000;
      m_Price20 = 680000;
      m_Price15 = 360000;
      m_Price10 = 120000;
     	m_Price5 = 50000;
    } 

		// all PS120 prices shall not set to less than 1000
		// PS120 with prices set lower than 1000 will be zeroized
		// PS115 and PS110 prices set to less than 2000 will trigger auto-pricing based on PS120
		private static PsPriceInfo[] m_PsTable = new PsPriceInfo[55]
		{
			//							seq#	SkillName					Price:120				115			110		Dis.	Enabled
			new PsPriceInfo(  0, SkillName.Alchemy,				300000,		1000,		1000,		0,	true ),
			new PsPriceInfo(  1, SkillName.Anatomy,       640000,   1000,   1000,   0,  true ),
			new PsPriceInfo(  2, SkillName.AnimalLore,    820000,   1000,   1000,   0,  true ),
			new PsPriceInfo(  3, SkillName.ItemID,        60000,    1000,   1000,   0,  false ),
			new PsPriceInfo(  4, SkillName.ArmsLore,      210000,   1000,   1000,   0,  true ),
			new PsPriceInfo(  5, SkillName.Parry,         500000,   1000,   1000,   0,  true ),
      new PsPriceInfo(  6, SkillName.Begging,       200000,   1000,   1000,   0,  false ),
      new PsPriceInfo(  7, SkillName.Blacksmith,    1200000,  1000,   1000,   0,  true ),
      new PsPriceInfo(  8, SkillName.Fletching,     180000,   1000,   1000,   0,  true ),
      new PsPriceInfo(  9, SkillName.Peacemaking,   360000,   1000,   1000,   0,  true ),
      new PsPriceInfo( 10, SkillName.Camping,       100000,   1000,   1000,   0,  false ),
      new PsPriceInfo( 11, SkillName.Carpentry,     280000,   1000,   1000,   0,  true ),
      new PsPriceInfo( 12, SkillName.Cartography,   260000,   1000,   1000,   0,  true ),
      new PsPriceInfo( 13, SkillName.Cooking,       120000,   1000,   1000,   0,  true ),
      new PsPriceInfo( 14, SkillName.DetectHidden,  100000,   1000,   1000,   0,  true ),
      new PsPriceInfo( 15, SkillName.Discordance,   900000,   1000,   1000,   0,  true ),
      new PsPriceInfo( 16, SkillName.EvalInt,       1100000,  1000,   1000,   0,  true ),
      new PsPriceInfo( 17, SkillName.Healing,       360000,   1000,   1000,   0,  true ),
      new PsPriceInfo( 18, SkillName.Fishing,       280000,   1000,   1000,   0,  true ),
      new PsPriceInfo( 19, SkillName.Forensics,     120000,   1000,   1000,   0,  false ),
      new PsPriceInfo( 20, SkillName.Herding,       180000,   1000,   1000,   0,  false ),
      new PsPriceInfo( 21, SkillName.Hiding,        160000,   1000,   1000,   0,  true ),
      new PsPriceInfo( 22, SkillName.Provocation,   680000,   1000,   1000,   0,  true ),
      new PsPriceInfo( 23, SkillName.Inscribe,      730000,   1000,   1000,   0,  true ),
      new PsPriceInfo( 24, SkillName.Lockpicking,   280000,   1000,   1000,   0,  true ),
      new PsPriceInfo( 25, SkillName.Magery,        1200000,  1000,   1000,   0,  true ),
      new PsPriceInfo( 26, SkillName.MagicResist,   880000,   1000,   1000,   0,  true ),
      new PsPriceInfo( 27, SkillName.Tactics,       230000,   1000,   1000,   0,  true ),
      new PsPriceInfo( 28, SkillName.Snooping,      800000,   1000,   1000,   0,  true ),
      new PsPriceInfo( 29, SkillName.Musicianship,  800000,   1000,   1000,   0,  true ),
      new PsPriceInfo( 30, SkillName.Poisoning,     620000,   1000,   1000,   0,  true ),
      new PsPriceInfo( 31, SkillName.Archery,       860000,   1000,   1000,   0,  true ),
      new PsPriceInfo( 32, SkillName.SpiritSpeak,   360000,   1000,   1000,   0,  true ),
      new PsPriceInfo( 33, SkillName.Stealing,      240000,   1000,   1000,   0,  true ),
      new PsPriceInfo( 34, SkillName.Tailoring,     620000,   1000,   1000,   0,  true ),
      new PsPriceInfo( 35, SkillName.AnimalTaming,  1000000,  1000,   1000,   0,  true ),
      new PsPriceInfo( 36, SkillName.TasteID,       80000,    1000,   1000,   0,  false ),
      new PsPriceInfo( 37, SkillName.Tinkering,     310000,   1000,   1000,   0,  true ),
      new PsPriceInfo( 38, SkillName.Tracking,      140000,   1000,   1000,   0,  false ),
      new PsPriceInfo( 39, SkillName.Veterinary,    710000,   1000,   1000,   0,  true ),
      new PsPriceInfo( 40, SkillName.Swords,        680000,   1000,   1000,   0,  true ),
      new PsPriceInfo( 41, SkillName.Macing,        220000,   1000,   1000,   0,  true ),
      new PsPriceInfo( 42, SkillName.Fencing,       820000,   1000,   1000,   0,  true ),
      new PsPriceInfo( 43, SkillName.Wrestling,     900000,   1000,   1000,   0,  true ),
      new PsPriceInfo( 44, SkillName.Lumberjacking, 460000,   1000,   1000,   0,  true ),
      new PsPriceInfo( 45, SkillName.Mining,        280000,   1000,   1000,   0,  true ),
      new PsPriceInfo( 46, SkillName.Meditation,    180000,   1000,   1000,   0,  true ),
      new PsPriceInfo( 47, SkillName.Stealth,       160000,   1000,   1000,   0,  true ),
      new PsPriceInfo( 48, SkillName.RemoveTrap,    220000,   1000,   1000,   0,  true ),
      new PsPriceInfo( 49, SkillName.Necromancy,    720000,   1000,   1000,   0,  true ),
      new PsPriceInfo( 50, SkillName.Focus,         180000,   1000,   1000,   0,  true ),
      new PsPriceInfo( 51, SkillName.Chivalry,      540000,   1000,   1000,   0,  true ),
      new PsPriceInfo( 52, SkillName.Bushido,       820000,   1000,   1000,   0,  true ),
      new PsPriceInfo( 53, SkillName.Ninjitsu,      280000,   1000,   1000,   0,  true ),
      new PsPriceInfo( 54, SkillName.Spellweaving,  900000,   1000,   1000,   0,  true ),
    };

		public static void UpdatePriceInfo( int skill, PsPriceInfo info )
		{
			m_PsTable[skill] = info;
		}

		public static int GetPriceInfo( SkillName skill, double value )
		{
			PsPriceInfo info = null;
			int price;
			foreach ( PsPriceInfo ppi in PsTable )
			{
				if ( ppi.PsName == skill )
					info = ppi;
			}

			if ( info == null )
				return 0;

			if ( value == 120.0 )
			{
				price = info.Price120;
				price = (int)( price - price * info.Discount / 100 );
				price = (int)( price / 1000 ) * 1000;
			}
			else if ( value == 115.0 )
			{
				price = ( info.Price115 > 2000 ? info.Price115 : (int)( info.Price120 / 2 ) ); // Price115 =  Price120 / 2
				price = (int)( price - price * info.Discount / 100 ); // to handle discount
				price = (int)( price / 1000 ) * 1000; // to truncate last 3 digits to 0s

			}
			else if ( value == 110 )
			{
				price = ( info.Price115 > 2000 ? info.Price110 : (int)( info.Price120 / 6 ) ); // Price110 = Price120 / 6
				price = (int)( price - price * info.Discount / 100 ); // to handle discount
				price = (int)( price / 1000 ) * 1000; // to truncate last 3 digits to 0s
			}
			else
			{
				price = 20000; // 105 PS
			}

			return price;
		}

		public static int StatPriceInfo( int value )
		{
			int price;

			switch ( value )
			{
				case 250: { price = m_Price25; break; }
				case 245: { price = m_Price20; break; }
				case 240: { price = m_Price15; break; }
				case 235: { price = m_Price10; break; }
				default: { price = m_Price5; break; }
			}

			return price;
		}
  }

}