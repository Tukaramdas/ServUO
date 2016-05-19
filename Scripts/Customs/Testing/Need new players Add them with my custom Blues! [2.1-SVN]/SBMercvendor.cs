using System;
using System.Collections;
using System.Collections.Generic;
using Server.Items;

namespace Server.Mobiles
{
	public class SBMercvendor : SBInfo
	{
		private List<GenericBuyInfo> m_BuyInfo = new InternalBuyInfo();
		private IShopSellInfo m_SellInfo = new InternalSellInfo();

		public SBMercvendor()
		{
		}

		public override IShopSellInfo SellInfo { get { return m_SellInfo; } }
		public override List<GenericBuyInfo> BuyInfo { get { return m_BuyInfo; } }

		public class InternalBuyInfo : List<GenericBuyInfo>
		{
			public InternalBuyInfo()
			{
				Add( new AnimalBuyInfo( 1, typeof( OrderGuard ), 1600, 10, 5, 0 ) );
				Add( new AnimalBuyInfo( 1, typeof( YoungPlayer ), 10000, 10, 5, 0 ) );
				Add( new AnimalBuyInfo( 1, typeof( FriendlyPlayer ), 30000, 10, 5, 0 ) );
				Add( new AnimalBuyInfo( 1, typeof( SpawnHelper ), 50000, 10, 5, 0 ) );
				Add( new AnimalBuyInfo( 1, typeof( SpawnHelperMage ), 60000, 10, 5, 0 ) );
				
			}
		}

		public class InternalSellInfo : GenericSellInfo
		{
			public InternalSellInfo()
			{
			}
		}
	}
}
