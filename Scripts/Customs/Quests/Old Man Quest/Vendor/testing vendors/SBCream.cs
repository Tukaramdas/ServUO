using System;
using System.Collections.Generic;
using Server.Items;

namespace Server.Mobiles
{
    public class SBCream : SBInfo
    {
        private readonly List<GenericBuyInfo> m_BuyInfo = new InternalBuyInfo();
        private readonly IShopSellInfo m_SellInfo = new InternalSellInfo();
        public SBCream()
        {
        }

        public override IShopSellInfo SellInfo
        {
            get
            {
                return this.m_SellInfo;
            }
        }
        public override List<GenericBuyInfo> BuyInfo
        {
            get
            {
                return this.m_BuyInfo;
            }
        }

        public class InternalBuyInfo : List<GenericBuyInfo>
        {
            public InternalBuyInfo()
            {
                if (Core.AOS)
                    this.Add(new GenericBuyInfo(typeof(MonkRobe), 136, 20, 0x2687, 0x21E));
              //      this.Add(new GenericBuyInfo(typeof(Moisturizer), 5, 100, 0xF0E, 0)); 
               
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