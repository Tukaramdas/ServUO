using System;
using Server;
using Server.Gumps;
using System.Collections;
using Server.Items;
using Server.Network;
using Server.Prompts;
using System.Text;
using Server.Mobiles;

namespace Server.Items
{
	public class SeaNavigator : Item
	{
		public override double DefaultWeight
		{
			get { return 1.0; }
		}

		[Constructable]
		public SeaNavigator() : base( 0x14F6 )
		{
			Name = "Sea Navigator";
            LootType = LootType.Blessed;
		}

		public override void OnDoubleClick( Mobile from )
		{
			if (!IsChildOf(from.Backpack))
			{
				from.SendLocalizedMessage(1042001);
			}
			else
			{
				from.CloseGump( typeof( dj_gump_ship1 ) );
				from.CloseGump( typeof( dj_gump_ship2 ) );
				from.CloseGump( typeof( dj_gump_ship3 ) );
				from.SendGump( new dj_gump_ship1( from ) );
			}
		}

		public SeaNavigator( Serial serial ) : base( serial )
		{
		}

		public override void Serialize( GenericWriter writer )
		{
			base.Serialize( writer );

			writer.Write( (int) 0 ); // version
		}

		public override void Deserialize( GenericReader reader )
		{
			base.Deserialize( reader );

			int version = reader.ReadInt();
		}
	}
}

namespace Server.Gumps
{
	public class dj_gump_ship1 : Gump
	{
		public dj_gump_ship1( Mobile from ) : base( 0, 0 )
		{
			this.Closable=true;
			this.Disposable=true;
			this.Dragable=true;
			this.Resizable=false;
			this.AddPage(0);
			this.AddImage(144, 127, 2702);
			this.AddButton(191, 146, 10850, 10850, 1, GumpButtonType.Reply, 1);		// GO ONE
			this.AddButton(263, 132, 10810, 10810, 2, GumpButtonType.Reply, 1);		// GO SLOW
			this.AddButton(335, 146, 10830, 10830, 3, GumpButtonType.Reply, 1);		// GO NORMAL
			this.AddButton(266, 220, 11320, 11320, 5, GumpButtonType.Reply, 1);		// STOP
			this.AddButton(191, 289, 2151, 2151, 6, GumpButtonType.Reply, 1);		// 180
			this.AddButton(181, 223, 22403, 22403, 7, GumpButtonType.Reply, 1);		// TURN LEFT
			this.AddButton(356, 225, 22404, 22404, 8, GumpButtonType.Reply, 1);		// TURN RIGHT
			this.AddButton(254, 164, 4500, 4500, 9, GumpButtonType.Reply, 1);		// MOVE FORWARD
			this.AddButton(254, 250, 4504, 4504, 10, GumpButtonType.Reply, 1);		// MOVE BACK
			this.AddButton(210, 207, 4506, 4506, 11, GumpButtonType.Reply, 1);		// MOVE LEFT
			this.AddButton(296, 207, 4502, 4502, 12, GumpButtonType.Reply, 1);		// MOVE RIGHT
			this.AddButton(217, 171, 4507, 4507, 13, GumpButtonType.Reply, 1);		// MOVE FORWARD LEFT
			this.AddButton(291, 171, 4501, 4501, 14, GumpButtonType.Reply, 1);		// MOVE FORWARD RIGHT
			this.AddButton(217, 243, 4505, 4505, 15, GumpButtonType.Reply, 1);		// MOVE BACKWARD LEFT
			this.AddButton(290, 243, 4503, 4503, 16, GumpButtonType.Reply, 1);		// MOVE BACKWARD RIGHT
			this.AddButton(356, 303, 9906, 9906, 4, GumpButtonType.Reply, 1);		// DROP ANCHOR
			this.AddButton(355, 282, 9900, 9900, 17, GumpButtonType.Reply, 1);		// RAISE ANCHOR
			this.AddLabel(237, 303, 71, "NORMAL SPEED");
		}
		public override void OnResponse( NetState state, RelayInfo info ) 
		{
			Mobile from = state.Mobile; 
			switch ( info.ButtonID )
			{
				case 0: { break; }

				case 1:
				{
					from.SendGump( new dj_gump_ship2( from ) );
					break;
				} 	 
				case 2: 
				{
					from.SendGump( new dj_gump_ship3( from ) );
					break;
				} 
				case 3: 
				{
					from.SendGump( new dj_gump_ship1( from ) );
					break;
				} 
				case 4: 
				{
					int[] commandz = new int[] { 0x006A };
					from.DoSpeech( "Drop The Anchor", commandz, 0, 52 );
					from.SendGump( new dj_gump_ship1( from ) );
					break;
				}
				case 5:
				{
					int[] commandz = new int[] { 0x004F };
					from.DoSpeech( "Furl The Sails", commandz, 0, 52 );
					from.SendGump( new dj_gump_ship1( from ) );
					break;
				} 	 
				case 6: 
				{
					int[] commandz = new int[] { 0x0067 };
					from.DoSpeech( "Bring Us About", commandz, 0, 52 );
					from.SendGump( new dj_gump_ship1( from ) );
					break;
				} 
				case 7:
				{
					int[] commandz = new int[] { 0x0066 };
					from.DoSpeech( "Turn Port Side", commandz, 0, 52 );
					from.SendGump( new dj_gump_ship1( from ) );
					break;
				} 
				case 8:
				{
					int[] commandz = new int[] { 0x0065 };
					from.DoSpeech( "Turn Starboard Side", commandz, 0, 52 );
					from.SendGump( new dj_gump_ship1( from ) );
					break;
				}
				case 9:
				{
					int[] commandz = new int[] { 0x0045 };
					from.DoSpeech( "Sail Us Forward", commandz, 0, 52 );
					from.SendGump( new dj_gump_ship1( from ) );
					break;
				} 	 
				case 10:
				{
					int[] commandz = new int[] { 0x0046 };
					from.DoSpeech( "Sail Us Backward", commandz, 0, 52 );
					from.SendGump( new dj_gump_ship1( from ) );
					break;
				} 
				case 11:
				{
					int[] commandz = new int[] { 0x0047 };
					from.DoSpeech( "Sail Us To The Left", commandz, 0, 52 );
					from.SendGump( new dj_gump_ship1( from ) );
					break;
				} 
				case 12:
				{
					int[] commandz = new int[] { 0x0048 };
					from.DoSpeech( "Sail Us To The Right", commandz, 0, 52 );
					from.SendGump( new dj_gump_ship1( from ) );
					break;
				}
				case 13:
				{
					int[] commandz = new int[] { 0x004B };
					from.DoSpeech( "Sail Us Forward And To The Left", commandz, 0, 52 );
					from.SendGump( new dj_gump_ship1( from ) );
					break;
				} 	 
				case 14:
				{
					int[] commandz = new int[] { 0x004C };
					from.DoSpeech( "Sail Us Forward And To The Right", commandz, 0, 52 );
					from.SendGump( new dj_gump_ship1( from ) );
					break;
				} 
				case 15:
				{
					int[] commandz = new int[] { 0x004D };
					from.DoSpeech( "Sail Us Back And To The Left", commandz, 0, 52 );
					from.SendGump( new dj_gump_ship1( from ) );
					break;
				} 
				case 16:
				{
					int[] commandz = new int[] { 0x004E };
					from.DoSpeech( "Sail Us Back And To The Right", commandz, 0, 52 );
					from.SendGump( new dj_gump_ship1( from ) );
					break;
				}
				case 17: 
				{
					int[] commandz = new int[] { 0x006B };
					from.DoSpeech( "Raise The Anchor", commandz, 0, 52 );
					from.SendGump( new dj_gump_ship1( from ) );
					break;
				}
			}
		}
	}
////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
	public class dj_gump_ship2 : Gump
	{
		public dj_gump_ship2( Mobile from ) : base( 0, 0 )
		{
			this.Closable=true;
			this.Disposable=true;
			this.Dragable=true;
			this.Resizable=false;
			this.AddPage(0);
			this.AddImage(144, 127, 2702);
			this.AddButton(191, 146, 10850, 10850, 1, GumpButtonType.Reply, 1);		// GO ONE
			this.AddButton(263, 132, 10810, 10810, 2, GumpButtonType.Reply, 1);		// GO SLOW
			this.AddButton(335, 146, 10830, 10830, 3, GumpButtonType.Reply, 1);		// GO NORMAL
			this.AddButton(266, 220, 11320, 11320, 5, GumpButtonType.Reply, 1);		// STOP
			this.AddButton(191, 289, 2151, 2151, 6, GumpButtonType.Reply, 1);		// 180
			this.AddButton(181, 223, 22403, 22403, 7, GumpButtonType.Reply, 1);		// TURN LEFT
			this.AddButton(356, 225, 22404, 22404, 8, GumpButtonType.Reply, 1);		// TURN RIGHT
			this.AddButton(254, 164, 4500, 4500, 9, GumpButtonType.Reply, 1);		// MOVE FORWARD
			this.AddButton(254, 250, 4504, 4504, 10, GumpButtonType.Reply, 1);		// MOVE BACK
			this.AddButton(210, 207, 4506, 4506, 11, GumpButtonType.Reply, 1);		// MOVE LEFT
			this.AddButton(296, 207, 4502, 4502, 12, GumpButtonType.Reply, 1);		// MOVE RIGHT
			this.AddButton(217, 171, 4507, 4507, 13, GumpButtonType.Reply, 1);		// MOVE FORWARD LEFT
			this.AddButton(291, 171, 4501, 4501, 14, GumpButtonType.Reply, 1);		// MOVE FORWARD RIGHT
			this.AddButton(217, 243, 4505, 4505, 15, GumpButtonType.Reply, 1);		// MOVE BACKWARD LEFT
			this.AddButton(290, 243, 4503, 4503, 16, GumpButtonType.Reply, 1);		// MOVE BACKWARD RIGHT
			this.AddButton(356, 303, 9906, 9906, 4, GumpButtonType.Reply, 1);		// DROP ANCHOR
			this.AddButton(355, 282, 9900, 9900, 17, GumpButtonType.Reply, 1);		// RAISE ANCHOR
			this.AddLabel(252, 303, 32, "MOVE ONE");
		}
		public override void OnResponse( NetState state, RelayInfo info ) 
		{
			Mobile from = state.Mobile; 
			switch ( info.ButtonID )
			{
				case 0: { break; }

				case 1:
				{
					from.SendGump( new dj_gump_ship2( from ) );
					break;
				} 	 
				case 2: 
				{
					from.SendGump( new dj_gump_ship3( from ) );
					break;
				} 
				case 3: 
				{
					from.SendGump( new dj_gump_ship1( from ) );
					break;
				} 
				case 4: 
				{
					int[] commandz = new int[] { 0x006A };
					from.DoSpeech( "Drop The Anchor", commandz, 0, 52 );
					from.SendGump( new dj_gump_ship2( from ) );
					break;
				}
				case 5:
				{
					int[] commandz = new int[] { 0x004F };
					from.DoSpeech( "Furl The Sails", commandz, 0, 52 );
					from.SendGump( new dj_gump_ship2( from ) );
					break;
				} 	 
				case 6: 
				{
					int[] commandz = new int[] { 0x0067 };
					from.DoSpeech( "Bring Us About", commandz, 0, 52 );
					from.SendGump( new dj_gump_ship2( from ) );
					break;
				} 
				case 7:
				{
					int[] commandz = new int[] { 0x0066 };
					from.DoSpeech( "Turn Port Side", commandz, 0, 52 );
					from.SendGump( new dj_gump_ship2( from ) );
					break;
				} 
				case 8:
				{
					int[] commandz = new int[] { 0x0065 };
					from.DoSpeech( "Turn Starboard Side", commandz, 0, 52 );
					from.SendGump( new dj_gump_ship2( from ) );
					break;
				}
				case 9:
				{
					int[] commandz = new int[] { 0x005A };
					from.DoSpeech( "Bring Us Forward A Bit", commandz, 0, 52 );
					from.SendGump( new dj_gump_ship2( from ) );
					break;
				} 	 
				case 10:
				{
					int[] commandz = new int[] { 0x005B };
					from.DoSpeech( "Bring Us Backward A Bit", commandz, 0, 52 );
					from.SendGump( new dj_gump_ship2( from ) );
					break;
				} 
				case 11:
				{
					int[] commandz = new int[] { 0x0058 };
					from.DoSpeech( "Bring Us To The Left A Bit", commandz, 0, 52 );
					from.SendGump( new dj_gump_ship2( from ) );
					break;
				} 
				case 12:
				{
					int[] commandz = new int[] { 0x0059 };
					from.DoSpeech( "Bring Us To The Right A Bit", commandz, 0, 52 );
					from.SendGump( new dj_gump_ship2( from ) );
					break;
				}
				case 13:
				{
					int[] commandz = new int[] { 0x005C };
					from.DoSpeech( "Bring Us Forward And To The Left A Bit", commandz, 0, 52 );
					from.SendGump( new dj_gump_ship2( from ) );
					break;
				} 	 
				case 14:
				{
					int[] commandz = new int[] { 0x005D };
					from.DoSpeech( "Bring Us Forward And To The Right A Bit", commandz, 0, 52 );
					from.SendGump( new dj_gump_ship2( from ) );
					break;
				} 
				case 15:
				{
					int[] commandz = new int[] { 0x005F };
					from.DoSpeech( "Bring Us Back And To The Left A Bit", commandz, 0, 52 );
					from.SendGump( new dj_gump_ship2( from ) );
					break;
				} 
				case 16:
				{
					int[] commandz = new int[] { 0x005E };
					from.DoSpeech( "Bring Us Back And To The Right A Bit", commandz, 0, 52 );
					from.SendGump( new dj_gump_ship2( from ) );
					break;
				}
				case 17: 
				{
					int[] commandz = new int[] { 0x006B };
					from.DoSpeech( "Raise The Anchor", commandz, 0, 52 );
					from.SendGump( new dj_gump_ship2( from ) );
					break;
				}
			}
		}
	}
////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
	public class dj_gump_ship3 : Gump
	{
		public dj_gump_ship3( Mobile from ) : base( 0, 0 )
		{
			this.Closable=true;
			this.Disposable=true;
			this.Dragable=true;
			this.Resizable=false;
			this.AddPage(0);
			this.AddImage(144, 127, 2702);
			this.AddButton(191, 146, 10850, 10850, 1, GumpButtonType.Reply, 1);		// GO ONE
			this.AddButton(263, 132, 10810, 10810, 2, GumpButtonType.Reply, 1);		// GO SLOW
			this.AddButton(335, 146, 10830, 10830, 3, GumpButtonType.Reply, 1);		// GO NORMAL
			this.AddButton(266, 220, 11320, 11320, 5, GumpButtonType.Reply, 1);		// STOP
			this.AddButton(191, 289, 2151, 2151, 6, GumpButtonType.Reply, 1);		// 180
			this.AddButton(181, 223, 22403, 22403, 7, GumpButtonType.Reply, 1);		// TURN LEFT
			this.AddButton(356, 225, 22404, 22404, 8, GumpButtonType.Reply, 1);		// TURN RIGHT
			this.AddButton(254, 164, 4500, 4500, 9, GumpButtonType.Reply, 1);		// MOVE FORWARD
			this.AddButton(254, 250, 4504, 4504, 10, GumpButtonType.Reply, 1);		// MOVE BACK
			this.AddButton(210, 207, 4506, 4506, 11, GumpButtonType.Reply, 1);		// MOVE LEFT
			this.AddButton(296, 207, 4502, 4502, 12, GumpButtonType.Reply, 1);		// MOVE RIGHT
			this.AddButton(217, 171, 4507, 4507, 13, GumpButtonType.Reply, 1);		// MOVE FORWARD LEFT
			this.AddButton(291, 171, 4501, 4501, 14, GumpButtonType.Reply, 1);		// MOVE FORWARD RIGHT
			this.AddButton(217, 243, 4505, 4505, 15, GumpButtonType.Reply, 1);		// MOVE BACKWARD LEFT
			this.AddButton(290, 243, 4503, 4503, 16, GumpButtonType.Reply, 1);		// MOVE BACKWARD RIGHT
			this.AddButton(356, 303, 9906, 9906, 4, GumpButtonType.Reply, 1);		// DROP ANCHOR
			this.AddButton(355, 282, 9900, 9900, 17, GumpButtonType.Reply, 1);		// RAISE ANCHOR
			this.AddLabel(243, 303, 98, "SLOW SPEED");
		}
		public override void OnResponse( NetState state, RelayInfo info ) 
		{
			Mobile from = state.Mobile; 
			switch ( info.ButtonID )
			{
				case 0: { break; }

				case 1:
				{
					from.SendGump( new dj_gump_ship2( from ) );
					break;
				} 	 
				case 2: 
				{
					from.SendGump( new dj_gump_ship3( from ) );
					break;
				} 
				case 3: 
				{
					from.SendGump( new dj_gump_ship1( from ) );
					break;
				} 
				case 4: 
				{
					int[] commandz = new int[] { 0x006A };
					from.DoSpeech( "Drop The Anchor", commandz, 0, 52 );
					from.SendGump( new dj_gump_ship3( from ) );
					break;
				}
				case 5:
				{
					int[] commandz = new int[] { 0x004F };
					from.DoSpeech( "Furl The Sails", commandz, 0, 52 );
					from.SendGump( new dj_gump_ship3( from ) );
					break;
				} 	 
				case 6: 
				{
					int[] commandz = new int[] { 0x0067 };
					from.DoSpeech( "Bring Us About", commandz, 0, 52 );
					from.SendGump( new dj_gump_ship3( from ) );
					break;
				} 
				case 7:
				{
					int[] commandz = new int[] { 0x0066 };
					from.DoSpeech( "Turn Port Side", commandz, 0, 52 );
					from.SendGump( new dj_gump_ship3( from ) );
					break;
				} 
				case 8:
				{
					int[] commandz = new int[] { 0x0065 };
					from.DoSpeech( "Turn Starboard Side", commandz, 0, 52 );
					from.SendGump( new dj_gump_ship3( from ) );
					break;
				}
				case 9:
				{
					int[] commandz = new int[] { 0x0052 };
					from.DoSpeech( "Sail Us Forward", commandz, 0, 52 );
					from.SendGump( new dj_gump_ship3( from ) );
					break;
				} 	 
				case 10:
				{
					int[] commandz = new int[] { 0x0053 };
					from.DoSpeech( "Sail Us Backward", commandz, 0, 52 );
					from.SendGump( new dj_gump_ship3( from ) );
					break;
				} 
				case 11:
				{
					int[] commandz = new int[] { 0x0050 };
					from.DoSpeech( "Sail Us To The Left", commandz, 0, 52 );
					from.SendGump( new dj_gump_ship3( from ) );
					break;
				} 
				case 12:
				{
					int[] commandz = new int[] { 0x0051 };
					from.DoSpeech( "Sail Us To The Right", commandz, 0, 52 );
					from.SendGump( new dj_gump_ship3( from ) );
					break;
				}
				case 13:
				{
					int[] commandz = new int[] { 0x0054 };
					from.DoSpeech( "Sail Us Forward And To The Left", commandz, 0, 52 );
					from.SendGump( new dj_gump_ship3( from ) );
					break;
				} 	 
				case 14:
				{
					int[] commandz = new int[] { 0x0055 };
					from.DoSpeech( "Sail Us Forward And To The Right", commandz, 0, 52 );
					from.SendGump( new dj_gump_ship3( from ) );
					break;
				} 
				case 15:
				{
					int[] commandz = new int[] { 0x0057 };
					from.DoSpeech( "Sail Us Back And To The Left", commandz, 0, 52 );
					from.SendGump( new dj_gump_ship3( from ) );
					break;
				} 
				case 16:
				{
					int[] commandz = new int[] { 0x0056 };
					from.DoSpeech( "Sail Us Back And To The Right", commandz, 0, 52 );
					from.SendGump( new dj_gump_ship3( from ) );
					break;
				}
				case 17: 
				{
					int[] commandz = new int[] { 0x006B };
					from.DoSpeech( "Raise The Anchor", commandz, 0, 52 );
					from.SendGump( new dj_gump_ship3( from ) );
					break;
				}
			}
		}
	}
}