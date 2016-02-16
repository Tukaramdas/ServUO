#define USE_TOKENS
using Server;
using Server.Mobiles;
using Server.Items;
using System;
using Server.ContextMenus;
using System.Collections.Generic;

namespace Daat99MasterLooterSystem
{
	public class MasterLooterLedgerContextMenu : ContextMenuEntry
	{
		private PlayerMobile player;
		private MasterLooterBackpack backpack;
		public MasterLooterLedgerContextMenu( Mobile from, Item item ) : base( 99, 1 )
		{
			player = from as PlayerMobile;
			backpack = item as MasterLooterBackpack;
		}
		public override void OnClick()
		{
			if ( backpack == null || !backpack.IsOwner(player)  )
				return;
			MasterLooterLedgerGump.SendGump(player, backpack);
		}
	}

	public class MasterLooterSetupContextMenu : ContextMenuEntry
	{
		private PlayerMobile player;
		private MasterLooterBackpack backpack;
		public MasterLooterSetupContextMenu( Mobile from, Item item ) : base( 97, 2 )
		{
			player = from as PlayerMobile;
			backpack = item as MasterLooterBackpack;
		}
		public override void OnClick()
		{
			if ( backpack == null || !backpack.IsOwner(player)  )
				return;
			MasterLooterSetupGump.SendGump(player, backpack, 0);
		}
	}

	public class MasterLooterFillContextMenu : ContextMenuEntry
	{
		private PlayerMobile player;
		private MasterLooterBackpack backpack;
		public MasterLooterFillContextMenu( Mobile from, Item item ) : base( 6230, 3 )
		{
			player = from as PlayerMobile;
			backpack = item as MasterLooterBackpack;
		}
		public override void OnClick()
		{
			if ( backpack == null || !backpack.IsOwner(player)  )
				return;
			backpack.AddCurrencyFromBackpack(player);
		}
	}
}

