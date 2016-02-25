using System;
using System.Collections.Generic;
using Server.Items;


namespace Server.Mobiles
{
    public class SBFacialVendor : SBInfo
    {
        private readonly List<GenericBuyInfo> m_BuyInfo = new InternalBuyInfo();
        private readonly IShopSellInfo m_SellInfo = new InternalSellInfo();
        public SBFacialVendor()
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
                Add(new GenericBuyInfo("Moisturizer", typeof(Moisturizer), 100, 20, 0xE2b, 0)); 

            }
        }

        public class InternalSellInfo : GenericSellInfo
        {
            public InternalSellInfo()
            {
                Add(typeof(Moisturizer), 3);




            }
        }
    }
}





/*
 * using System;
using System.Collections.Generic;
using Server.Items;

namespace Server.Mobiles
{
    public class SBFacialVendor : SBInfo
    {
        private readonly List<GenericBuyInfo> m_BuyInfo = new InternalBuyInfo();
        private readonly IShopSellInfo m_SellInfo = new InternalSellInfo();
        public SBFacialVendor()
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
            //        this.Add(new GenericBuyInfo(typeof(MonkRobe), 136, 20, 0x2687, 0x21E));
                    this.Add(new GenericBuyInfo(typeof(Moisturizer), 100, 20, 0xE2b, 0)); 
            }
        }

        public class InternalSellInfo : GenericSellInfo
        {
            public InternalSellInfo()
            {
                Add(typeof(Moisturizer), 3);
            }
        }
    }
}
*/