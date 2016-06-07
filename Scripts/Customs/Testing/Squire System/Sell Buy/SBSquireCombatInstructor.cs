using System;
using System.Collections.Generic;
using Server.Items;

namespace Server.Mobiles
{
	public class SBSquireCombatInstructor : SBInfo
	{
		private List<GenericBuyInfo> m_BuyInfo = new InternalBuyInfo();
		private IShopSellInfo m_SellInfo = new InternalSellInfo();

		public SBSquireCombatInstructor()
		{
		}

		public override IShopSellInfo SellInfo { get { return m_SellInfo; } }
		public override List<GenericBuyInfo> BuyInfo { get { return m_BuyInfo; } }

		public class InternalBuyInfo : List<GenericBuyInfo>
		{
			public InternalBuyInfo()
			{
				Add( new GenericBuyInfo( "an wrestling training contract", typeof( SWrestlingContract ), 300, 10, 0x14F0, 0 ) );
				Add( new GenericBuyInfo( "an tactics training contract", typeof( STacticsContract ), 300, 10, 0x14F0, 0 ) );
				Add( new GenericBuyInfo( "an magic resistance training contract", typeof( SMagicResistContract ), 300, 10, 0x14F0, 0 ) );
				Add( new GenericBuyInfo( "an anatomy training contract", typeof( SAnatomyContract ), 300, 10, 0x14F0, 0 ) );
				Add( new GenericBuyInfo( "an swordsmanship training contract", typeof( SSwordsContract ), 300, 10, 0x14F0, 0 ) );
				Add( new GenericBuyInfo( "an macefighting training contract", typeof( SMacingContract ), 300, 10, 0x14F0, 0 ) );
				Add( new GenericBuyInfo( "an fencing training contract", typeof( SFencingContract ), 300, 10, 0x14F0, 0 ) );
				Add( new GenericBuyInfo( "an archery training contract", typeof( SArcheryContract ), 300, 10, 0x14F0, 0 ) );
				Add( new GenericBuyInfo( "an parrying training contract", typeof( SParryContract ), 300, 10, 0x14F0, 0 ) );
				Add( new GenericBuyInfo( "an evaluate intelligence training contract", typeof( SEvalIntContract ), 300, 10, 0x14F0, 0 ) );
				Add( new GenericBuyInfo( "an meditation training contract", typeof( SMeditationContract ), 300, 10, 0x14F0, 0 ) );
				Add( new GenericBuyInfo( "an focus training contract", typeof( SFocusContract ), 300, 10, 0x14F0, 0 ) );
				Add( new GenericBuyInfo( "an chivalry training contract", typeof( SChivalryContract ), 300, 10, 0x14F0, 0 ) ); // Added 1.9.6
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
