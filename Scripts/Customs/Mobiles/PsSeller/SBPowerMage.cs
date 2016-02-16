/***
* Project : Vendor selling random PowerScrolls and StatCapScrolls
* Description :
*	-	a vendor selling several random PowerScrolls and StatCapScrolls,
* 	
* Create Date : Dec 12, 2008
* Created by : Hawkins
*
* Updated : Dec 14, 2008
* - code simplified
*
***/
using System;
using System.Collections;
using System.Collections.Generic;
using Server;
using Server.Items;
using Server.Engines.CannedEvil;

namespace Server.Mobiles
{
	public class SBPowerMage : SBInfo
	{
		private List<GenericBuyInfo> m_BuyInfo = new InternalBuyInfo();
		private IShopSellInfo m_SellInfo = new InternalSellInfo();

		public SBPowerMage()
		{
		}

		public override IShopSellInfo SellInfo { get { return m_SellInfo; } }
		public override List<GenericBuyInfo> BuyInfo { get { return m_BuyInfo; } }

		public class InternalBuyInfo : List<GenericBuyInfo>
		{
			PrepareSales ps = new PrepareSales();

			public InternalBuyInfo()
			{
				// random 120, 115 and 110 PS
				if ( ps.CreatedRandomPS() )
				{
					for ( int i = 0; i < ps.Num; i++ )
					{
						Add( new GenericBuyInfo( typeof( PowerScroll ), ps.PSItems[i].ItemPrice, 1, 0x14F0, 0x481, new object[] { ps.PSItems[i].ItemName, ps.PSItems[i].PSValue } ) );
					}
				}

				// some random 105 PS
				Add( new GenericBuyInfo( typeof( PowerScroll ), 5000, 1, 0x14F0, 0x481, new object[] { ps.GetSkillName(), 105.0 } ) );
				Add( new GenericBuyInfo( typeof( PowerScroll ), 5000, 1, 0x14F0, 0x481, new object[] { ps.GetSkillName(), 105.0 } ) );

				// StatCapScrolls (if any)
				if ( ps.CSnumber > 0 && ps.CreatedRandomCS() )
				{
					for ( int i = 0; i < ps.CSnumber; i++ )
					{
						Add( new GenericBuyInfo( typeof( StatCapScroll ), ps.CSItems[i].CSPrice, 1, 0x14F0, 0x481, new object[] { ps.CSItems[i].CSLevel } ) );
					}
				}
			}
		}

		public class InternalSellInfo : GenericSellInfo
		{
			public InternalSellInfo()
			{
				Add( typeof( PowerScroll ), 5000 ); 
			}
		}
	}

	public class PrepareSales
	{
		private bool m_NoCraft = false; // set to true = will not generate Smith and Tailor PS
		private int m_Num = Utility.RandomMinMax( 2, 5 ); // number of PS to be created
		private PsItems[] m_Items;

		private int m_CSnumber = 1; // number of StatCapScroll to be created, 0 = will not generate StatCapScroll
		private CsItems[] m_CSItems;

		public bool NoCraft {	get{ return m_NoCraft; } }
		public int Num {	get{ return m_Num; } }
		public PsItems[] PSItems {	get{ return m_Items; } }
		public int CSnumber {	get{ return m_CSnumber; } }
		public CsItems[] CSItems {	get{ return m_CSItems; } }

		public PrepareSales()
		{
		}

		public bool CreatedRandomPS()
		{
			List<PsPriceInfo> list = new List<PsPriceInfo>();
			PsItems[] psItems = new PsItems[m_Num];

			foreach ( PsPriceInfo fo in PsPriceInfo.PsTable )
			{
				if ( fo.Enabled && !( m_NoCraft && ( fo.PsName == SkillName.Blacksmith || fo.PsName == SkillName.Tailoring ) ) )
					list.Add( new PsPriceInfo( fo.PsID, fo.PsName, fo.Price120, fo.Price115, fo.Price110, fo.Discount, fo.Enabled ) );
			}

			int rand;
			int price;
			double value;

			PsPriceInfo info;

			for ( int i = 0; i < m_Num; i++ )
			{
				rand = Utility.RandomMinMax( 0, list.Count - 1 );
				info = (PsPriceInfo)list[rand];
				value = GetSkillValue();

				price = PsPriceInfo.GetPriceInfo( info.PsName, value );

				psItems[i] = new PsItems( info.PsName, value, price );
			}
			
			m_Items = psItems;
			return true;
		}

		public bool CreatedRandomCS()
		{
			if ( !( m_CSnumber > 0) )
				return false;

			// to reduce the chance of generating a StatCapScroll
			if ( Utility.RandomDouble() > 0.2 )
				return false;

			m_CSItems = new CsItems[m_CSnumber];
				
			for ( int i = 0; i < m_CSnumber; i++ )
			{
				m_CSItems[i] = GetStatLevel();
				
				if ( m_CSItems[i] == null )
					return false;
			}
			
			return true;
		}

		public CsItems GetStatLevel()
		{
			double random = Utility.RandomDouble();

			if ( 0.1 >= random )
				return new CsItems( 250, PsPriceInfo.Price25 ); // Price of +25
			else if ( 0.25 >= random )
				return new CsItems( 245, PsPriceInfo.Price20 ); // Price of +20
			else if ( 0.45 >= random )
				return new CsItems( 240, PsPriceInfo.Price15 ); // Price of +15
			else if ( 0.70 >= random )
				return new CsItems( 235, PsPriceInfo.Price10 ); // Price of +10
			else
				return new CsItems( 230, PsPriceInfo.Price5 ); // Price of +5
		}

		public double GetSkillValue()
		{
			double random = Utility.RandomDouble();

			if ( 0.05 >= random )
				return 120.0;
			else if ( 0.4 >= random )
				return 115.0;
			else
				return 110.0;
		}

		public SkillName GetSkillName()
		{
			List<SkillName> skills = PowerScroll.Skills;
			SkillName skillName;

			if ( m_NoCraft )
			{
				do
				{
					skillName = skills[Utility.Random( skills.Count )];
				} while ( skillName == SkillName.Blacksmith || skillName == SkillName.Tailoring );

				return skillName;
			}

			return skills[Utility.Random( skills.Count )];
		}
	}

	public class CsItems
	{
		private int m_Level;
		private int m_Price;
		
		public CsItems( int level, int price )
		{
			m_Level = level;
			m_Price = price;
		}

		public int CSLevel {	get{ return m_Level; } }
		public int CSPrice {	get{ return m_Price; } }
	}

	public class PsItems
	{
		private SkillName m_Skill;
		private double m_Value;
		private int m_Price;
		
		public PsItems( SkillName skill, double value, int price )
		{
			m_Skill = skill;
			m_Value = value;
			m_Price = price;
		}

		public SkillName ItemName {	get{ return m_Skill; } }
		public double PSValue {	get{ return m_Value; } }
		public int ItemPrice {	get{ return m_Price; } }
	}

}
