using System;
using System.Collections.Generic;
using Server.Items;


namespace Server.Mobiles 
{ 
    public class SBCostumeVendor : SBInfo
    {
        private readonly List<GenericBuyInfo> m_BuyInfo = new InternalBuyInfo();
        private readonly IShopSellInfo m_SellInfo = new InternalSellInfo();
        public SBCostumeVendor()
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
                Add(new GenericBuyInfo("Abyssmal Horror Gem", typeof(HalloweenCostumeOne), 10, 999, 0xF13, 0));
                Add(new GenericBuyInfo("Gargoyle Gem", typeof(HalloweenCostumeTwo), 10, 999, 0xF13, 0));
                Add(new GenericBuyInfo("Shade Gem", typeof(HalloweenCostumeThree), 10, 999, 0xF13, 0));
                Add(new GenericBuyInfo("Giant Black Widow Gem", typeof(HalloweenCostumeFour), 10, 999, 0xF13, 0));
                Add(new GenericBuyInfo("Slime Gem", typeof(HalloweenCostumeFive), 10, 999, 0xF13, 0));
                Add(new GenericBuyInfo("Succubus Gem", typeof(HalloweenCostumeSix), 10, 999, 0xF13, 0));
                Add(new GenericBuyInfo("Gazer Gem", typeof(HalloweenCostumeSeven), 10, 999, 0xF13, 0));
                Add(new GenericBuyInfo("Mummy Gem", typeof(HalloweenCostumeEight), 10, 999, 0xF13, 0));
                Add(new GenericBuyInfo("Skeleton Gem", typeof(HalloweenCostumeNine), 10, 999, 0xF13, 0));
                Add(new GenericBuyInfo("Pixie Gem", typeof(HalloweenCostumeTen), 10, 999, 0xF13, 0));
            }
        }

        public class InternalSellInfo : GenericSellInfo
        {
            public InternalSellInfo()
            {
                Add(typeof(HalloweenCostumeOne), 3);
                Add(typeof(HalloweenCostumeTwo), 3);
                Add(typeof(HalloweenCostumeThree), 3);
                Add(typeof(HalloweenCostumeFour), 3);
                Add(typeof(HalloweenCostumeFive), 3);
                Add(typeof(HalloweenCostumeSix), 3);
                Add(typeof(HalloweenCostumeSeven), 3);
                Add(typeof(HalloweenCostumeEight), 3);
                Add(typeof(HalloweenCostumeNine), 3);
                Add(typeof(HalloweenCostumeTen), 3);



            }
        }
    }
}