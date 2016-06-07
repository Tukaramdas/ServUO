using System;
using Server;
using Server.Items;
using Server.Mobiles;
using Server.Network;
using Server.Gumps;
using Server.Misc;
using Server.SkillHandlers;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using Server.Targeting;
using Server.ContextMenus;
using Server.HuePickers;

namespace Server.Gumps
{
	public class SquireCustomizeGump : Gump
	{
		private Squire m_Squire;

		private class HairOrBeard
		{
			private int m_ItemID;
			private int m_Name;

			public int ItemID{ get{ return m_ItemID; } }
			public int Name{ get{ return m_Name; } }

			public HairOrBeard( int itemID, int name )
			{
				m_ItemID = itemID;
				m_Name = name;
			}
		}

		private static HairOrBeard[] m_HairStyles = new HairOrBeard[]
			{
				new HairOrBeard( 0x203B,	1011052 ),	// Short
				new HairOrBeard( 0x203C,	1011053 ),	// Long
				new HairOrBeard( 0x203D,	1011054 ),	// Ponytail
				new HairOrBeard( 0x2044,	1011055 ),	// Mohawk
				new HairOrBeard( 0x2045,	1011047 ),	// Pageboy
				new HairOrBeard( 0x204A,	1011050 ),	// Topknot
				new HairOrBeard( 0x2047,	1011396 ),	// Curly
				new HairOrBeard( 0x2048,	1011048 ),	// Receding
				new HairOrBeard( 0x2049,	1011049 )	// 2-tails
			};
			
		private static HairOrBeard[] m_ElfHairStyles = new HairOrBeard[]
			{
				new HairOrBeard( 0x2fc0,	1074386 ),	// Long Feather
				new HairOrBeard( 0x2fc1,	1074387 ),	// Short
				new HairOrBeard( 0x2fc2,	1074388 ),	// Mullet
				new HairOrBeard( 0x2fce,	1074391 ),	// Knob
				new HairOrBeard( 0x2fcf,	1074392 ),	// Braided
				new HairOrBeard( 0x2fd1,	1074394 ),	// Spiked
				new HairOrBeard( 0x2fcc,	1074385 ),	// Flower, Mid-Long
				new HairOrBeard( 0x2fd0,	1074390 ),	// Buns, Long
			};

		private static HairOrBeard[] m_BeardStyles = new HairOrBeard[]
			{
				new HairOrBeard( 0x2041,	1011062 ),	// Mustache
				new HairOrBeard( 0x203F,	1011060 ),	// Short beard
				new HairOrBeard( 0x204B,	1015321 ),	// Short Beard & Moustache
				new HairOrBeard( 0x203E,	1011061 ),	// Long beard
				new HairOrBeard( 0x204C,	1015322 ),	// Long Beard & Moustache
				new HairOrBeard( 0x2040,	1015323 ),	// Goatee
				new HairOrBeard( 0x204D,	1011401 )	// Vandyke
			};

		public SquireCustomizeGump( Squire squire ) : base( 50, 50 )
		{
			m_Squire = squire;

			AddBackground( 0, 0, 370, 370, 5054 );

			AddHtml( 10, 12, 350, 18, "<center>SQUIRE CUSTOMIZATION MENU</center>", false, false ); // <center>VENDOR CUSTOMIZATION MENU</center>

			AddHtmlLocalized( 10, 42, 150, 18, 1062459, 0x1, false, false ); // <CENTER>HAIR</CENTER>

			if ( squire.Race == Race.Elf )
			{
				for ( int i = 0; i < m_ElfHairStyles.Length; i++ )
				{
					HairOrBeard hair = m_ElfHairStyles[i];

					AddButton( 10, 70 + i * 20, 0xFA5, 0xFA7, 0x100 | i, GumpButtonType.Reply, 0 );
					AddHtmlLocalized( 45, 72 + i * 20, 110, 18, hair.Name, 0x7FFF, false, false );
				}

				AddButton( 10, 70 + m_ElfHairStyles.Length * 20, 0xFB1, 0xFB3, 2, GumpButtonType.Reply, 0 );
				AddHtmlLocalized( 45, 72 + m_ElfHairStyles.Length * 20, 110, 18, 1011403, 0x7FFF, false, false ); // Remove

				AddButton( 10, 70 + (m_ElfHairStyles.Length + 1) * 20, 0xFA5, 0xFA7, 3, GumpButtonType.Reply, 0 );
				AddHtmlLocalized( 45, 72 + (m_ElfHairStyles.Length + 1) * 20, 110, 18, 1011402, 0x7FFF, false, false ); // Color
			}
			else
			{
				for ( int i = 0; i < m_HairStyles.Length; i++ )
				{
					HairOrBeard hair = m_HairStyles[i];

					AddButton( 10, 70 + i * 20, 0xFA5, 0xFA7, 0x100 | i, GumpButtonType.Reply, 0 );
					AddHtmlLocalized( 45, 72 + i * 20, 110, 18, hair.Name, 0x7FFF, false, false );
				}

				AddButton( 10, 70 + m_HairStyles.Length * 20, 0xFB1, 0xFB3, 2, GumpButtonType.Reply, 0 );
				AddHtmlLocalized( 45, 72 + m_HairStyles.Length * 20, 110, 18, 1011403, 0x7FFF, false, false ); // Remove

				AddButton( 10, 70 + (m_HairStyles.Length + 1) * 20, 0xFA5, 0xFA7, 3, GumpButtonType.Reply, 0 );
				AddHtmlLocalized( 45, 72 + (m_HairStyles.Length + 1) * 20, 110, 18, 1011402, 0x7FFF, false, false ); // Color
			}

			if ( squire.Female )
			{
			}
			else if ( squire.Race == Race.Elf )
			{
			}
			else
			{
				AddHtmlLocalized( 160, 42, 210, 18, 1062460, 0x1, false, false ); // <CENTER>BEARD</CENTER>

				for ( int i = 0; i < m_BeardStyles.Length; i++ )
				{
					HairOrBeard beard = m_BeardStyles[i];

					AddButton( 160, 70 + i * 20, 0xFA5, 0xFA7, 0x200 | i, GumpButtonType.Reply, 0 );
					AddHtmlLocalized( 195, 72 + i * 20, 160, 18, beard.Name, 0x7FFF, false, false );
				}

				AddButton( 160, 70 + m_BeardStyles.Length * 20, 0xFB1, 0xFB3, 4, GumpButtonType.Reply, 0 );
				AddHtmlLocalized( 195, 72 + m_BeardStyles.Length * 20, 160, 18, 1011403, 0x7FFF, false, false ); // Remove

				AddButton( 160, 70 + (m_BeardStyles.Length + 1) * 20, 0xFA5, 0xFA7, 5, GumpButtonType.Reply, 0 );
				AddHtmlLocalized( 195, 72 + (m_BeardStyles.Length + 1) * 20, 160, 18, 1011402, 0x7FFF, false, false ); // Color
			}

			AddButton( 10, 340, 0xFA5, 0xFA7, 0, GumpButtonType.Reply, 0 );
			AddHtmlLocalized( 45, 342, 305, 18, 1060675, 0x7FFF, false, false ); // CLOSE
		}

		public override void OnResponse( NetState sender, RelayInfo info )
		{
			Mobile from = sender.Mobile;

			//if ( !m_Squire.CanInteractWith( from, true ) )
			//	return;

			switch ( info.ButtonID )
			{
				case 0: // CLOSE
				{
					m_Squire.SayTo( from, "Thank you, master, I think I like it this way!" ); // a little random speech

					break;
				}
				case 1: // Female/Male
				{
					if ( m_Squire.Female )
					{
						m_Squire.BodyValue = 400;
						m_Squire.Female = false;
					}
					else
					{
						m_Squire.BodyValue = 401;
						m_Squire.Female = true;

						m_Squire.FacialHairItemID = 0;
					}

					from.SendGump( new SquireCustomizeGump( m_Squire ) );

					break;
				}
				case 2: // Remove hair
				{
					m_Squire.HairItemID = 0;

					from.SendGump( new SquireCustomizeGump( m_Squire ) );

					break;
				}
				case 3: // Color hair
				{
					if ( m_Squire.HairItemID > 0 )
					{
						new SquireHuePicker( m_Squire, false, from ).SendTo( from.NetState );
					}
					else
					{
						from.SendGump( new SquireCustomizeGump( m_Squire ) );
					}

					break;
				}
				case 4: // Remove beard
				{
					m_Squire.FacialHairItemID = 0;

					from.SendGump( new SquireCustomizeGump( m_Squire ) );

					break;
				}
				case 5: // Color beard
				{
					if ( m_Squire.FacialHairItemID > 0 )
					{
						new SquireHuePicker( m_Squire, true, from ).SendTo( from.NetState );
					}
					else
					{
						from.SendGump( new SquireCustomizeGump( m_Squire ) );
					}

					break;
				}
				default:
				{
					int hairhue = 0;

					if ( (info.ButtonID & 0x100) != 0 ) // Hair style selected
					{
						int index = info.ButtonID & 0xFF;

						if ( m_Squire.Race == Race.Elf )
						{
							if ( index >= m_ElfHairStyles.Length )
								return;

							HairOrBeard hairStyle = m_ElfHairStyles[index];

							hairhue = m_Squire.HairHue;

							m_Squire.HairItemID = 0;
							m_Squire.ProcessDelta();

							m_Squire.HairItemID = hairStyle.ItemID;

							m_Squire.HairHue = hairhue;

							from.SendGump( new SquireCustomizeGump( m_Squire ) );
						}
						else
						{
							if ( index >= m_HairStyles.Length )
								return;

							HairOrBeard hairStyle = m_HairStyles[index];
							
							hairhue = m_Squire.HairHue;

							m_Squire.HairItemID = 0;
							m_Squire.ProcessDelta();

							m_Squire.HairItemID = hairStyle.ItemID;

							m_Squire.HairHue = hairhue;

							from.SendGump( new SquireCustomizeGump( m_Squire ) );
						}
					}
					else if ( (info.ButtonID & 0x200) != 0 ) // Beard style selected
					{
						if ( m_Squire.Female )
							return;

						int index = info.ButtonID & 0xFF;

						if ( index >= m_BeardStyles.Length )
							return;

						HairOrBeard beardStyle = m_BeardStyles[index];

						hairhue = m_Squire.FacialHairHue;

						m_Squire.FacialHairItemID = 0;
						m_Squire.ProcessDelta();

						m_Squire.FacialHairItemID = beardStyle.ItemID;

						m_Squire.FacialHairHue = hairhue;

						from.SendGump( new SquireCustomizeGump( m_Squire ) );
					}

					break;
				}
			}
		}

		private class SquireHuePicker : HuePicker
		{
			private Squire m_Squire;
			private bool m_FacialHair;
			private Mobile m_From;

			public SquireHuePicker( Squire squire, bool facialHair, Mobile from ) : base( 0xFAB )
			{
				m_Squire = squire;
				m_FacialHair = facialHair;
				m_From = from;
			}

			public override void OnResponse( int hue )
			{
				if ( m_FacialHair )
					m_Squire.FacialHairHue = hue;
				else
					m_Squire.HairHue = hue;

				m_From.SendGump( new SquireCustomizeGump( m_Squire ) );
			}
		}
	}
	
	public enum SquireLorePage
	{
		Stats,
		Skills,
		Switches
	}
	
	public class SquireLoreGump : Gump
	{
		private int SkillID;
		private SquireLorePage m_Page;
		
		public int GetButtonID( int type, int index )
		{
			return 1 + (index * 15) + type;
		}
		
		private static string FormatSkill( BaseCreature c, SkillName name )
		{
			Skill skill = c.Skills[name];

			return String.Format( "<basefont color = #A3D7FF><div align=right>{0:F1}</div></basefont>", skill.Base ); //Changed from Value to Base 1.8.8
		}

		private static string FormatAttributes( int cur, int max )
		{
			if ( max == 0 )
				return "<basefont color = #A3D7FF><div align=right>---</div></basefont>";

			return String.Format( "<basefont color = #A3D7FF><div align=right>{0}/{1}</div></basefont>", cur, max );
		}

		private static string FormatStat( int val )
		{
			if ( val == 0 )
				return "<basefont color = #A3D7FF><div align=right>---</div></basefont>";

			return String.Format( "<basefont color = #A3D7FF><div align=right>{0}</div></basefont>", val );
		}

		private static string FormatDouble( double val )
		{
			if ( val == 0 )
				return "<basefont color = #A3D7FF><div align=right>---</div></basefont>";

			return String.Format( "<basefont color = #A3D7FF><div align=right>{0:F1}</div></basefont>", val );
		}

		private static string FormatElement( int val )
		{
			if ( val <= 0 )
				return "<basefont color = #A3D7FF><div align=right>---</div></basefont>";

			return String.Format( "<basefont color = #A3D7FF><div align=right>{0}%</div></basefont>", val );
		}

		#region Mondain's Legacy
		private static string FormatDamage( int min, int max )
		{
			if ( min <= 0 || max <= 0 )
				return "<basefont color = #A3D7FF><div align=right>---</div></basefont>";

			return String.Format( "<basefont color = #A3D7FF><div align=right>{0}-{1}</div></basefont>", min, max );
		}
		#endregion
		
		private const int LabelColor = 0x7FFF;
		private Mobile m_Squire;
		private Mobile m_From;
		
		public override void OnResponse( NetState sender, RelayInfo info )
		{
			int buttonID = info.ButtonID - 1;

			int index = buttonID / 15;
			int type = buttonID % 15;
			
			BaseCreature c = ((BaseCreature)m_Squire);
			
			switch( type )
			{
				default:
				{
					m_From.CloseGump( typeof( SquireLoreGump ) );
					break;
				}
				case 1:
				{
					switch( index )
					{
						default:
						{
							m_From.CloseGump( typeof( SquireLoreGump ) );
							break;
						}
						case 1:
						{
							switch ( c.Skills[SkillName.Wrestling].Lock )
							{
								case SkillLock.Up: c.Skills[SkillName.Wrestling].SetLockNoRelay( SkillLock.Down ); c.Skills[SkillName.Wrestling].Update(); break;
								case SkillLock.Down: c.Skills[SkillName.Wrestling].SetLockNoRelay( SkillLock.Locked ); c.Skills[SkillName.Wrestling].Update(); break;
								case SkillLock.Locked: c.Skills[SkillName.Wrestling].SetLockNoRelay( SkillLock.Up ); c.Skills[SkillName.Wrestling].Update(); break;
							}
						}
						break;
						case 2:
						{
							switch ( c.Skills[SkillName.Tactics].Lock )
							{
								case SkillLock.Up: c.Skills[SkillName.Tactics].SetLockNoRelay( SkillLock.Down ); c.Skills[SkillName.Tactics].Update(); break;
								case SkillLock.Down: c.Skills[SkillName.Tactics].SetLockNoRelay( SkillLock.Locked ); c.Skills[SkillName.Tactics].Update(); break;
								case SkillLock.Locked: c.Skills[SkillName.Tactics].SetLockNoRelay( SkillLock.Up ); c.Skills[SkillName.Tactics].Update(); break;
							}
						}
						break;
						case 3:
						{
							switch ( c.Skills[SkillName.MagicResist].Lock )
							{
								case SkillLock.Up: c.Skills[SkillName.MagicResist].SetLockNoRelay( SkillLock.Down ); c.Skills[SkillName.MagicResist].Update(); break;
								case SkillLock.Down: c.Skills[SkillName.MagicResist].SetLockNoRelay( SkillLock.Locked ); c.Skills[SkillName.MagicResist].Update(); break;
								case SkillLock.Locked: c.Skills[SkillName.MagicResist].SetLockNoRelay( SkillLock.Up ); c.Skills[SkillName.MagicResist].Update(); break;
							}
						}
						break;
						case 4:
						{
							switch ( c.Skills[SkillName.Anatomy].Lock )
							{
								case SkillLock.Up: c.Skills[SkillName.Anatomy].SetLockNoRelay( SkillLock.Down ); c.Skills[SkillName.Anatomy].Update(); break;
								case SkillLock.Down: c.Skills[SkillName.Anatomy].SetLockNoRelay( SkillLock.Locked ); c.Skills[SkillName.Anatomy].Update(); break;
								case SkillLock.Locked: c.Skills[SkillName.Anatomy].SetLockNoRelay( SkillLock.Up ); c.Skills[SkillName.Anatomy].Update(); break;
							}
						}
						break;
						case 5:
						{
							switch ( c.Skills[SkillName.Swords].Lock )
							{
								case SkillLock.Up: c.Skills[SkillName.Swords].SetLockNoRelay( SkillLock.Down ); c.Skills[SkillName.Swords].Update(); break;
								case SkillLock.Down: c.Skills[SkillName.Swords].SetLockNoRelay( SkillLock.Locked ); c.Skills[SkillName.Swords].Update(); break;
								case SkillLock.Locked: c.Skills[SkillName.Swords].SetLockNoRelay( SkillLock.Up ); c.Skills[SkillName.Swords].Update(); break;
							}
						}
						break;
						case 6:
						{
							switch ( c.Skills[SkillName.Macing].Lock )
							{
								case SkillLock.Up: c.Skills[SkillName.Macing].SetLockNoRelay( SkillLock.Down ); c.Skills[SkillName.Macing].Update(); break;
								case SkillLock.Down: c.Skills[SkillName.Macing].SetLockNoRelay( SkillLock.Locked ); c.Skills[SkillName.Macing].Update(); break;
								case SkillLock.Locked: c.Skills[SkillName.Macing].SetLockNoRelay( SkillLock.Up ); c.Skills[SkillName.Macing].Update(); break;
							}
						}
						break;
						case 7:
						{
							switch ( c.Skills[SkillName.Fencing].Lock )
							{
								case SkillLock.Up: c.Skills[SkillName.Fencing].SetLockNoRelay( SkillLock.Down ); c.Skills[SkillName.Fencing].Update(); break;
								case SkillLock.Down: c.Skills[SkillName.Fencing].SetLockNoRelay( SkillLock.Locked ); c.Skills[SkillName.Fencing].Update(); break;
								case SkillLock.Locked: c.Skills[SkillName.Fencing].SetLockNoRelay( SkillLock.Up ); c.Skills[SkillName.Fencing].Update(); break;
							}
						}
						break;
						case 8:
						{
							switch ( c.Skills[SkillName.Archery].Lock )
							{
								case SkillLock.Up: c.Skills[SkillName.Archery].SetLockNoRelay( SkillLock.Down ); c.Skills[SkillName.Archery].Update(); break;
								case SkillLock.Down: c.Skills[SkillName.Archery].SetLockNoRelay( SkillLock.Locked ); c.Skills[SkillName.Archery].Update(); break;
								case SkillLock.Locked: c.Skills[SkillName.Archery].SetLockNoRelay( SkillLock.Up ); c.Skills[SkillName.Archery].Update(); break;
							}
						}
						break;
						case 9:
						{
							switch ( c.Skills[SkillName.Parry].Lock )
							{
								case SkillLock.Up: c.Skills[SkillName.Parry].SetLockNoRelay( SkillLock.Down ); c.Skills[SkillName.Parry].Update(); break;
								case SkillLock.Down: c.Skills[SkillName.Parry].SetLockNoRelay( SkillLock.Locked ); c.Skills[SkillName.Parry].Update(); break;
								case SkillLock.Locked: c.Skills[SkillName.Parry].SetLockNoRelay( SkillLock.Up ); c.Skills[SkillName.Parry].Update(); break;
							}
						}
						break;
						case 10:
						{
							switch ( c.Skills[SkillName.Healing].Lock )
							{
								case SkillLock.Up: c.Skills[SkillName.Healing].SetLockNoRelay( SkillLock.Down ); c.Skills[SkillName.Healing].Update(); break;
								case SkillLock.Down: c.Skills[SkillName.Healing].SetLockNoRelay( SkillLock.Locked ); c.Skills[SkillName.Healing].Update(); break;
								case SkillLock.Locked: c.Skills[SkillName.Healing].SetLockNoRelay( SkillLock.Up ); c.Skills[SkillName.Healing].Update(); break;
							}
						}
						break;
						case 11:
						{
							switch ( c.Skills[SkillName.Veterinary].Lock )
							{
								case SkillLock.Up: c.Skills[SkillName.Veterinary].SetLockNoRelay( SkillLock.Down ); c.Skills[SkillName.Veterinary].Update(); break;
								case SkillLock.Down: c.Skills[SkillName.Veterinary].SetLockNoRelay( SkillLock.Locked ); c.Skills[SkillName.Veterinary].Update(); break;
								case SkillLock.Locked: c.Skills[SkillName.Veterinary].SetLockNoRelay( SkillLock.Up ); c.Skills[SkillName.Veterinary].Update(); break;
							}
						}
						break;
						case 12:
						{
							switch ( c.Skills[SkillName.EvalInt].Lock )
							{
								case SkillLock.Up: c.Skills[SkillName.EvalInt].SetLockNoRelay( SkillLock.Down ); c.Skills[SkillName.EvalInt].Update(); break;
								case SkillLock.Down: c.Skills[SkillName.EvalInt].SetLockNoRelay( SkillLock.Locked ); c.Skills[SkillName.EvalInt].Update(); break;
								case SkillLock.Locked: c.Skills[SkillName.EvalInt].SetLockNoRelay( SkillLock.Up ); c.Skills[SkillName.EvalInt].Update(); break;
							}
						}
						break;
						case 13:
						{
							switch ( c.Skills[SkillName.Meditation].Lock )
							{
								case SkillLock.Up: c.Skills[SkillName.Meditation].SetLockNoRelay( SkillLock.Down ); c.Skills[SkillName.Meditation].Update(); break;
								case SkillLock.Down: c.Skills[SkillName.Meditation].SetLockNoRelay( SkillLock.Locked ); c.Skills[SkillName.Meditation].Update(); break;
								case SkillLock.Locked: c.Skills[SkillName.Meditation].SetLockNoRelay( SkillLock.Up ); c.Skills[SkillName.Meditation].Update(); break;
							}
						}
						break;
						case 14:
						{
							switch ( c.Skills[SkillName.AnimalLore].Lock )
							{
								case SkillLock.Up: c.Skills[SkillName.AnimalLore].SetLockNoRelay( SkillLock.Down ); c.Skills[SkillName.AnimalLore].Update(); break;
								case SkillLock.Down: c.Skills[SkillName.AnimalLore].SetLockNoRelay( SkillLock.Locked ); c.Skills[SkillName.AnimalLore].Update(); break;
								case SkillLock.Locked: c.Skills[SkillName.AnimalLore].SetLockNoRelay( SkillLock.Up ); c.Skills[SkillName.AnimalLore].Update(); break;
							}
						}
						break;
						case 15:
						{
							switch ( c.Skills[SkillName.Hiding].Lock )
							{
								case SkillLock.Up: c.Skills[SkillName.Hiding].SetLockNoRelay( SkillLock.Down ); c.Skills[SkillName.Hiding].Update(); break;
								case SkillLock.Down: c.Skills[SkillName.Hiding].SetLockNoRelay( SkillLock.Locked ); c.Skills[SkillName.Hiding].Update(); break;
								case SkillLock.Locked: c.Skills[SkillName.Hiding].SetLockNoRelay( SkillLock.Up ); c.Skills[SkillName.Hiding].Update(); break;
							}
						}
						break;
						case 16:
						{
							switch ( c.Skills[SkillName.Focus].Lock )
							{
								case SkillLock.Up: c.Skills[SkillName.Focus].SetLockNoRelay( SkillLock.Down ); c.Skills[SkillName.Focus].Update(); break;
								case SkillLock.Down: c.Skills[SkillName.Focus].SetLockNoRelay( SkillLock.Locked ); c.Skills[SkillName.Focus].Update(); break;
								case SkillLock.Locked: c.Skills[SkillName.Focus].SetLockNoRelay( SkillLock.Up ); c.Skills[SkillName.Focus].Update(); break;
							}
						}
						break;
						case 17:
						{
							switch ( c.Skills[SkillName.Musicianship].Lock )
							{
								case SkillLock.Up: c.Skills[SkillName.Musicianship].SetLockNoRelay( SkillLock.Down ); c.Skills[SkillName.Musicianship].Update(); break;
								case SkillLock.Down: c.Skills[SkillName.Musicianship].SetLockNoRelay( SkillLock.Locked ); c.Skills[SkillName.Musicianship].Update(); break;
								case SkillLock.Locked: c.Skills[SkillName.Musicianship].SetLockNoRelay( SkillLock.Up ); c.Skills[SkillName.Musicianship].Update(); break;
							}
						}
						break;
						case 18:
						{
							switch ( c.Skills[SkillName.Peacemaking].Lock )
							{
								case SkillLock.Up: c.Skills[SkillName.Peacemaking].SetLockNoRelay( SkillLock.Down ); c.Skills[SkillName.Peacemaking].Update(); break;
								case SkillLock.Down: c.Skills[SkillName.Peacemaking].SetLockNoRelay( SkillLock.Locked ); c.Skills[SkillName.Peacemaking].Update(); break;
								case SkillLock.Locked: c.Skills[SkillName.Peacemaking].SetLockNoRelay( SkillLock.Up ); c.Skills[SkillName.Peacemaking].Update(); break;
							}
						}
						break;
						case 19:
						{
							switch ( c.Skills[SkillName.Discordance].Lock )
							{
								case SkillLock.Up: c.Skills[SkillName.Discordance].SetLockNoRelay( SkillLock.Down ); c.Skills[SkillName.Discordance].Update(); break;
								case SkillLock.Down: c.Skills[SkillName.Discordance].SetLockNoRelay( SkillLock.Locked ); c.Skills[SkillName.Discordance].Update(); break;
								case SkillLock.Locked: c.Skills[SkillName.Discordance].SetLockNoRelay( SkillLock.Up ); c.Skills[SkillName.Discordance].Update(); break;
							}
						}
						break;
						case 20:
						{
							switch ( c.Skills[SkillName.Provocation].Lock )
							{
								case SkillLock.Up: c.Skills[SkillName.Provocation].SetLockNoRelay( SkillLock.Down ); c.Skills[SkillName.Provocation].Update(); break;
								case SkillLock.Down: c.Skills[SkillName.Provocation].SetLockNoRelay( SkillLock.Locked ); c.Skills[SkillName.Provocation].Update(); break;
								case SkillLock.Locked: c.Skills[SkillName.Provocation].SetLockNoRelay( SkillLock.Up ); c.Skills[SkillName.Provocation].Update(); break;
							}
						}
						break;
						case 21:
						{
							switch ( c.Skills[SkillName.Stealing].Lock )
							{
								case SkillLock.Up: c.Skills[SkillName.Stealing].SetLockNoRelay( SkillLock.Down ); c.Skills[SkillName.Stealing].Update(); break;
								case SkillLock.Down: c.Skills[SkillName.Stealing].SetLockNoRelay( SkillLock.Locked ); c.Skills[SkillName.Stealing].Update(); break;
								case SkillLock.Locked: c.Skills[SkillName.Stealing].SetLockNoRelay( SkillLock.Up ); c.Skills[SkillName.Stealing].Update(); break;
							}
						}
						break;
						case 22:
						{
							switch ( c.Skills[SkillName.Lockpicking].Lock )
							{
								case SkillLock.Up: c.Skills[SkillName.Lockpicking].SetLockNoRelay( SkillLock.Down ); c.Skills[SkillName.Lockpicking].Update(); break;
								case SkillLock.Down: c.Skills[SkillName.Lockpicking].SetLockNoRelay( SkillLock.Locked ); c.Skills[SkillName.Lockpicking].Update(); break;
								case SkillLock.Locked: c.Skills[SkillName.Lockpicking].SetLockNoRelay( SkillLock.Up ); c.Skills[SkillName.Lockpicking].Update(); break;
							}
						}
						break;
						case 23:
						{
							switch ( c.Skills[SkillName.SpiritSpeak].Lock )
							{
								case SkillLock.Up: c.Skills[SkillName.SpiritSpeak].SetLockNoRelay( SkillLock.Down ); c.Skills[SkillName.SpiritSpeak].Update(); break;
								case SkillLock.Down: c.Skills[SkillName.SpiritSpeak].SetLockNoRelay( SkillLock.Locked ); c.Skills[SkillName.SpiritSpeak].Update(); break;
								case SkillLock.Locked: c.Skills[SkillName.SpiritSpeak].SetLockNoRelay( SkillLock.Up ); c.Skills[SkillName.SpiritSpeak].Update(); break;
							}
						}
						break;
						case 24:
						{
							switch ( c.Skills[SkillName.Poisoning].Lock )
							{
								case SkillLock.Up: c.Skills[SkillName.Poisoning].SetLockNoRelay( SkillLock.Down ); c.Skills[SkillName.Poisoning].Update(); break;
								case SkillLock.Down: c.Skills[SkillName.Poisoning].SetLockNoRelay( SkillLock.Locked ); c.Skills[SkillName.Poisoning].Update(); break;
								case SkillLock.Locked: c.Skills[SkillName.Poisoning].SetLockNoRelay( SkillLock.Up ); c.Skills[SkillName.Poisoning].Update(); break;
							}
						}
						break;
						case 25: // Added 1.9.6
						{
							switch ( c.Skills[SkillName.Chivalry].Lock )
							{
								case SkillLock.Up: c.Skills[SkillName.Chivalry].SetLockNoRelay( SkillLock.Down ); c.Skills[SkillName.Chivalry].Update(); break;
								case SkillLock.Down: c.Skills[SkillName.Chivalry].SetLockNoRelay( SkillLock.Locked ); c.Skills[SkillName.Chivalry].Update(); break;
								case SkillLock.Locked: c.Skills[SkillName.Chivalry].SetLockNoRelay( SkillLock.Up ); c.Skills[SkillName.Chivalry].Update(); break;
							}
						}
						break;
					}
					m_From.CloseGump( typeof( SquireLoreGump ) );
					m_From.SendGump( new SquireLoreGump( ((BaseCreature)m_Squire), m_From, SquireLorePage.Skills ) );
					break;
				}
				case 2:
				{
					switch( index )
					{
						default:
						{
							m_From.CloseGump( typeof( SquireLoreGump ) );
							break;
						}
						case 1:
						{
							m_From.CloseGump( typeof( SquireLoreGump ) );
							m_From.SendGump( new SquireLoreGump( ((BaseCreature)m_Squire), m_From, SquireLorePage.Skills ) );
							break;
						}
						case 2:
						{
							m_From.CloseGump( typeof( SquireLoreGump ) );
							m_From.SendGump( new SquireLoreGump( ((BaseCreature)m_Squire), m_From, SquireLorePage.Stats ) );
							break;
						}
						case 3:
						{
							m_From.CloseGump( typeof( SquireLoreGump ) );
							m_From.SendGump( new SquireLoreGump( ((BaseCreature)m_Squire), m_From, SquireLorePage.Switches ) );
							break;
						}
					}
					break;
				}
				case 3:
				{
					switch( index )
					{
						default:
						{
							m_From.CloseGump( typeof( SquireLoreGump ) );
							break;
						}
						case 1:
						{
							((Squire)m_Squire).m_Inspectable = false;
							break;
						}
						case 2:
						{
							((Squire)m_Squire).m_Inspectable = true;
							break;
						}
						case 3:
						{
							((Squire)m_Squire).m_AutoPickupAmmo = false;
							break;
						}
						case 4:
						{
							((Squire)m_Squire).m_AutoPickupAmmo = true;
							break;
						}
						case 5:
						{
							((Squire)m_Squire).m_SquireBeQuiet = false;
							break;
						}
						case 6:
						{
							((Squire)m_Squire).m_SquireBeQuiet = true;
							break;
						}
						case 7:
						{
							((Squire)m_Squire).m_DesperateMasterRun = false;
							break;
						}
						case 8:
						{
							((Squire)m_Squire).m_DesperateMasterRun = true;
							break;
						}
						case 9:
						{
							((Squire)m_Squire).m_AutoUseHealthPotion = false;
							break;
						}
						case 10:
						{
							((Squire)m_Squire).m_AutoUseHealthPotion = true;
							break;
						}
						case 11:
						{
							((Squire)m_Squire).m_AutoUsePowerScroll = false;
							break;
						}
						case 12:
						{
							((Squire)m_Squire).m_AutoUsePowerScroll = true;
							break;
						}
						case 13:
						{
							((Squire)m_Squire).m_AutoEquipLoot = false;
							break;
						}
						case 14:
						{
							((Squire)m_Squire).m_AutoEquipLoot = true;
							break;
						}
						case 15:
						{
							((Squire)m_Squire).m_AutoRezAlly = false;
							break;
						}
						case 16:
						{
							((Squire)m_Squire).m_AutoRezAlly = true;
							break;
						}
						case 17:
						{
							((Squire)m_Squire).m_AutoCastCloseWounds = false;
							break;
						}
						case 18:
						{
							((Squire)m_Squire).m_AutoCastCloseWounds = true;
							break;
						}
						case 19:
						{
							((Squire)m_Squire).m_AutoCastCleanseByFire = false;
							break;
						}
						case 20:
						{
							((Squire)m_Squire).m_AutoCastCleanseByFire = true;
							break;
						}
						case 21: // Begin 1.9.7
						{
							((Squire)m_Squire).m_AutoCastCleanseByFireMaster = false;
							break;
						}
						case 22:
						{
							((Squire)m_Squire).m_AutoCastCleanseByFireMaster = true;
							break;
						}
						case 23:
						{
							((Squire)m_Squire).m_AutoCastCleanseByFireAlly = false;
							break;
						}
						case 24:
						{
							((Squire)m_Squire).m_AutoCastCleanseByFireAlly = true;
							break;
						}
						case 25:
						{
							((Squire)m_Squire).m_AutoCastCloseWoundsMaster = false;
							break;
						}
						case 26:
						{
							((Squire)m_Squire).m_AutoCastCloseWoundsMaster = true;
							break;
						}
						case 27:
						{
							((Squire)m_Squire).m_AutoCastCloseWoundsAlly = false;
							break;
						}
						case 28:
						{
							((Squire)m_Squire).m_AutoCastCloseWoundsAlly = true;
							break;
						} // End 1.9.7
					}
					m_From.CloseGump( typeof( SquireLoreGump ) );
					m_From.SendGump( new SquireLoreGump( ((BaseCreature)m_Squire), m_From, SquireLorePage.Switches ) );
					break;
				}
				case 4:
				{
					switch( index )
					{
						default:
						{
							m_From.CloseGump( typeof( SquireLoreGump ) );
							break;
						}
						case 1:
						{
							((Squire)m_Squire).m_AutoHealSelf = false;
							break;
						}
						case 2:
						{
							((Squire)m_Squire).m_AutoHealSelf = true;
							break;
						}
						case 3:
						{
							((Squire)m_Squire).m_AutoHealMaster = false;
							break;
						}
						case 4:
						{
							((Squire)m_Squire).m_AutoHealMaster = true;
							break;
						}
						case 5:
						{
							((Squire)m_Squire).m_AutoHealOther = false;
							break;
						}
						case 6:
						{
							((Squire)m_Squire).m_AutoHealOther = true;
							break;
						}
						case 7:
						{
							((Squire)m_Squire).m_AutoHealAnimals = false;
							break;
						}
						case 8:
						{
							((Squire)m_Squire).m_AutoHealAnimals = true;
							break;
						}
						case 9:
						{
							((Squire)m_Squire).m_AutoUseCurePotion = false;
							break;
						}
						case 10:
						{
							((Squire)m_Squire).m_AutoUseCurePotion = true;
							break;
						}
						case 11:
						{
							((Squire)m_Squire).m_AutoUseTScroll = false;
							break;
						}
						case 12:
						{
							((Squire)m_Squire).m_AutoUseTScroll = true;
							break;
						}
						case 13: // Begin 1.9.2
						{
							((Squire)m_Squire).m_AutoUseSpiritSpeak = false;
							break;
						}
						case 14:
						{
							((Squire)m_Squire).m_AutoUseSpiritSpeak = true;
							break;
						}
						case 15:
						{
							((Squire)m_Squire).m_AutoRezMaster = false;
							break;
						}
						case 16:
						{
							((Squire)m_Squire).m_AutoRezMaster = true;
							break;
						} // End 1.9.2
					}
					m_From.CloseGump( typeof( SquireLoreGump ) );
					m_From.SendGump( new SquireLoreGump( ((BaseCreature)m_Squire), m_From, SquireLorePage.Switches ) );
					break;
				}
			}
		}
		
		public SquireLoreGump( BaseCreature c, Mobile from, SquireLorePage page ) : base( 250, 50 )
		{
			m_Squire = c;
			m_From = from;
			m_Page = page;
			
			from.CloseGump( typeof( SquireLoreGump ) );
			
			AddPage( 0 );

			// Moved to each individual page.
			/*
			AddBackground( 0, 0, 420, 372, 5054 );
			AddImageTiled( 10, 10, 400, 352, 2624 );
			AddAlphaRegion( 10, 10, 400, 352 );
			*/

			AddHtml( 100, 14, 210, 18, String.Format( "<basefont color = #FFFFFF><center><i>{0}</i></center></basefont>", c.Name ), false, false );

			int pages = ( Core.AOS ? 5 : 3 );
			int buttonID1, buttonID2;

			#region Stats Page
			if ( page == SquireLorePage.Stats )
			{
				// Added 1.9.7
				// Background Setup
				AddBackground( 0, 0, 420, 372, 5054 );
				AddImageTiled( 10, 10, 400, 352, 2624 );
				AddAlphaRegion( 10, 10, 400, 352 );
					
				//First Half
				AddHtml( 20, 40, 160, 18, "<basefont color = #FFD57A>Attributes</basefont>", false, false ); // Attributes

				AddHtmlLocalized( 20, 58, 160, 18, 1049578, LabelColor, false, false ); // Hits
				AddHtml( 127, 58, 75, 18, FormatAttributes( c.Hits, c.HitsMax ), false, false );

				AddHtmlLocalized( 20, 76, 160, 18, 1049579, LabelColor, false, false ); // Stamina
				AddHtml( 127, 76, 75, 18, FormatAttributes( c.Stam, c.StamMax ), false, false );

				AddHtmlLocalized( 20, 94, 160, 18, 1049580, LabelColor, false, false ); // Mana
				AddHtml( 127, 94, 75, 18, FormatAttributes( c.Mana, c.ManaMax ), false, false );

				AddHtmlLocalized( 20, 112, 160, 18, 1028335, LabelColor, false, false ); // Strength
				AddHtml( 167, 112, 35, 18, FormatStat( c.Str ), false, false );

				AddHtmlLocalized( 20, 130, 160, 18, 3000113, LabelColor, false, false ); // Dexterity
				AddHtml( 167, 130, 35, 18, FormatStat( c.Dex ), false, false );

				AddHtmlLocalized( 20, 148, 160, 18, 3000112, LabelColor, false, false ); // Intelligence
				AddHtml( 167, 148, 35, 18, FormatStat( c.Int ), false, false );
				// Added 1.9.7
				AddHtml( 20, 166, 160, 18, "<basefont color = #FFD57A>Tithing Points: </basefont>", false, false ); // Team Added 1.9.7
				AddHtml( 107, 166, 160, 18, "<basefont color = #FFFFFF>" + ((Squire)c).TithingPoints + "</basefont>", false, false );
				
				// Moved Damages Section Down By Two Spaces 1.9.7
				AddHtml( 20, 220, 160, 18, "<basefont color = #FFD57A>Damage</basefont>", false, false ); // Damage

				AddHtmlLocalized( 20, 238, 160, 18, 1061646, LabelColor, false, false ); // Physical
				AddHtml( 167, 238, 35, 18, FormatElement( c.PhysicalDamage ), false, false );

				AddHtmlLocalized( 20, 256, 160, 18, 1061647, LabelColor, false, false ); // Fire
				AddHtml( 167, 256, 35, 18, FormatElement( c.FireDamage ), false, false );

				AddHtmlLocalized( 20, 274, 160, 18, 1061648, LabelColor, false, false ); // Cold
				AddHtml( 167, 274, 35, 18, FormatElement( c.ColdDamage ), false, false );

				AddHtmlLocalized( 20, 292, 160, 18, 1061649, LabelColor, false, false ); // Poison
				AddHtml( 167, 292, 35, 18, FormatElement( c.PoisonDamage ), false, false );

				AddHtmlLocalized( 20, 310, 160, 18, 1061650, LabelColor, false, false ); // Energy
				AddHtml( 167, 310, 35, 18, FormatElement( c.EnergyDamage ), false, false );
				
				//Middle Display
				AddHtml( 125, 28, 160, 18, "<basefont color = #FFD57A><center>Stats</center></basefont>", false, false );
				
				//Second Half
				AddHtml( 220, 40, 160, 18, "<basefont color = #FFD57A>Loyalty Rating</basefont>", false, false ); // Loyalty Rating
				AddHtmlLocalized( 220, 58, 160, 18, (!c.Controlled || c.Loyalty == 0) ? 1061643 : 1049595 + (c.Loyalty / 10), LabelColor, false, false );
				
				if ( c is Squire )
				{
					AddHtml( 220, 76, 160, 18, "<basefont color = #FFD57A>Master's Nickname</basefont>", false, false ); // Loyalty Rating
					AddHtml( 220, 94, 160, 18, "<basefont color = #FFFFFF>" + ((Squire)c).m_MasterNickname + "</basefont>", false, false );
				
					AddHtml( 220, 112, 160, 18, "<basefont color = #FFD57A>" + ((Squire)c).Name + "'s Nickname</basefont>", false, false ); // Loyalty Rating
					AddHtml( 220, 130, 160, 18, "<basefont color = #FFFFFF>" + ((Squire)c).m_SquireNickname + "</basefont>", false, false );
					
					AddHtml( 220, 148, 160, 18, "<basefont color = #FFD57A>" + ((Squire)c).Name + "'s Title</basefont>", false, false );
					AddHtml( 220, 166, 160, 18, "<basefont color = #FFFFFF>" + ((Squire)c).Title + "</basefont>", false, false );
					
					AddHtml( 220, 184, 160, 18, "<basefont color = #FFD57A>" + ((Squire)c).Name + "'s Team</basefont>", false, false ); // Team Added 1.9.7
					AddHtml( 220, 202, 160, 18, "<basefont color = #FFFFFF>" + ((Squire)c).m_SquireTeam + "</basefont>", false, false );
				}
				// Moved Resistances Down 1.9.7
				AddHtml( 220, 220, 160, 18, "<basefont color = #FFD57A>Resistances</basefont>", false, false ); // Resistances

				AddHtmlLocalized( 220, 238, 160, 18, 1061646, LabelColor, false, false ); // Physical
				AddHtml( 357, 238, 35, 18, FormatElement( c.PhysicalResistance ), false, false );

				AddHtmlLocalized( 220, 256, 160, 18, 1061647, LabelColor, false, false ); // Fire
				AddHtml( 357, 256, 35, 18, FormatElement( c.FireResistance ), false, false );

				AddHtmlLocalized( 220, 274, 160, 18, 1061648, LabelColor, false, false ); // Cold
				AddHtml( 357, 274, 35, 18, FormatElement( c.ColdResistance ), false, false );

				AddHtmlLocalized( 220, 292, 160, 18, 1061649, LabelColor, false, false ); // Poison
				AddHtml( 357, 292, 35, 18, FormatElement( c.PoisonResistance ), false, false );

				AddHtmlLocalized( 220, 310, 160, 18, 1061650, LabelColor, false, false ); // Energy
				AddHtml( 357, 310, 35, 18, FormatElement( c.EnergyResistance ), false, false );

				//Navigation
				AddHtml( 347, 20, 160, 18, "<basefont color = #FFD57A>Skills</basefont>", false, false );
				AddButton( 377, 22, 5601, 5605, GetButtonID( 2, 1 ), GumpButtonType.Reply, 0 );
				
				if( ( c.Controlled && from == c.ControlMaster ) || from.AccessLevel >= AccessLevel.GameMaster )
				{
					AddHtml( 40, 20, 160, 18, "<basefont color = #FFD57A>Switches</basefont>", false, false );
					AddButton( 20, 21, 5603, 5607, GetButtonID( 2, 3 ), GumpButtonType.Reply, 0 );
				}
			}
			#endregion

			#region Skills
			if ( page == SquireLorePage.Skills )
			{
				// Added 1.9.7
				// Background Setup
				AddBackground( 0, 0, 420, 372, 5054 );
				AddImageTiled( 10, 10, 400, 352, 2624 );
				AddAlphaRegion( 10, 10, 400, 352 );
				
				//First Half
				AddHtml( 20, 40, 160, 18, "<basefont color = #FFD57A>Combat Skills</basefont>", false, false ); // Combat Ratings

				AddHtmlLocalized( 20, 58, 160, 18, 1044103, LabelColor, false, false ); // Wrestling
				AddHtml( 167, 58, 35, 18, FormatSkill( c, SkillName.Wrestling ), false, false );
				if ( ( c.Controlled && m_From == c.ControlMaster ) || m_From.AccessLevel >= AccessLevel.GameMaster )
				{
					switch ( c.Skills[SkillName.Wrestling].Lock )
					{
						default:
						case SkillLock.Up: AddButton( 204, 62, 0x983, 0x983, GetButtonID( 1, 1 ), GumpButtonType.Reply, 0 ); break;
						case SkillLock.Down: AddButton( 204, 62, 0x985, 0x985, GetButtonID( 1, 1 ), GumpButtonType.Reply, 0 ); break;
						case SkillLock.Locked: AddButton( 204, 61, 0x82C, 0x82C, GetButtonID( 1, 1 ), GumpButtonType.Reply, 0 ); break;
					}
				}

				AddHtmlLocalized( 20, 76, 160, 18, 1044087, LabelColor, false, false ); // Tactics
				AddHtml( 167, 76, 35, 18, FormatSkill( c, SkillName.Tactics ), false, false );
				if ( ( c.Controlled && m_From == c.ControlMaster ) || m_From.AccessLevel >= AccessLevel.GameMaster )
				{
					switch ( c.Skills[SkillName.Tactics].Lock )
					{
						default:
						case SkillLock.Up: AddButton( 204, 80, 0x983, 0x983, GetButtonID( 1, 2 ), GumpButtonType.Reply, 0 ); break;
						case SkillLock.Down: AddButton( 204, 80, 0x985, 0x985, GetButtonID( 1, 2 ), GumpButtonType.Reply, 0 ); break;
						case SkillLock.Locked: AddButton( 204, 79, 0x82C, 0x82C, GetButtonID( 1, 2 ), GumpButtonType.Reply, 0 ); break;
					}
				}

				AddHtmlLocalized( 20, 94, 160, 18, 1044086, LabelColor, false, false ); // Magic Resistance
				AddHtml( 167, 94, 35, 18, FormatSkill( c, SkillName.MagicResist ), false, false );
				if ( ( c.Controlled && m_From == c.ControlMaster ) || m_From.AccessLevel >= AccessLevel.GameMaster )
				{
					switch ( c.Skills[SkillName.MagicResist].Lock )
					{
						default:
						case SkillLock.Up: AddButton( 204, 98, 0x983, 0x983, GetButtonID( 1, 3 ), GumpButtonType.Reply, 0 ); break;
						case SkillLock.Down: AddButton( 204, 98, 0x985, 0x985, GetButtonID( 1, 3 ), GumpButtonType.Reply, 0 ); break;
						case SkillLock.Locked: AddButton( 204, 97, 0x82C, 0x82C, GetButtonID( 1, 3 ), GumpButtonType.Reply, 0 ); break;
					}
				}

				AddHtmlLocalized( 20, 112, 160, 18, 1044061, LabelColor, false, false ); // Anatomy
				AddHtml( 167, 112, 35, 18, FormatSkill( c, SkillName.Anatomy ), false, false );
				if ( ( c.Controlled && m_From == c.ControlMaster ) || m_From.AccessLevel >= AccessLevel.GameMaster )
				{
					switch ( c.Skills[SkillName.Anatomy].Lock )
					{
						default:
						case SkillLock.Up: AddButton( 204, 116, 0x983, 0x983, GetButtonID( 1, 4 ), GumpButtonType.Reply, 0 ); break;
						case SkillLock.Down: AddButton( 204, 116, 0x985, 0x985, GetButtonID( 1, 4 ), GumpButtonType.Reply, 0 ); break;
						case SkillLock.Locked: AddButton( 204, 115, 0x82C, 0x82C, GetButtonID( 1, 4 ), GumpButtonType.Reply, 0 ); break;
					}
				}
				
				AddHtml( 20, 130, 160, 18, "<basefont color = #FFFFFF>Swordsmanship</basefont>", false, false ); // Swords
				AddHtml( 167, 130, 35, 18, FormatSkill( c, SkillName.Swords ), false, false );
				if ( ( c.Controlled && m_From == c.ControlMaster ) || m_From.AccessLevel >= AccessLevel.GameMaster )
				{
					switch ( c.Skills[SkillName.Swords].Lock )
					{
						default:
						case SkillLock.Up: AddButton( 204, 134, 0x983, 0x983, GetButtonID( 1, 5 ), GumpButtonType.Reply, 0 ); break;
						case SkillLock.Down: AddButton( 204, 134, 0x985, 0x985, GetButtonID( 1, 5 ), GumpButtonType.Reply, 0 ); break;
						case SkillLock.Locked: AddButton( 204, 133, 0x82C, 0x82C, GetButtonID( 1, 5 ), GumpButtonType.Reply, 0 ); break;
					}
				}
				
				AddHtml( 20, 148, 160, 18, "<basefont color = #FFFFFF>Macefighting</basefont>", false, false ); // Macing
				AddHtml( 167, 148, 35, 18, FormatSkill( c, SkillName.Macing ), false, false );
				if ( ( c.Controlled && m_From == c.ControlMaster ) || m_From.AccessLevel >= AccessLevel.GameMaster )
				{
					switch ( c.Skills[SkillName.Macing].Lock )
					{
						default:
						case SkillLock.Up: AddButton( 204, 152, 0x983, 0x983, GetButtonID( 1, 6 ), GumpButtonType.Reply, 0 ); break;
						case SkillLock.Down: AddButton( 204, 152, 0x985, 0x985, GetButtonID( 1, 6 ), GumpButtonType.Reply, 0 ); break;
						case SkillLock.Locked: AddButton( 204, 151, 0x82C, 0x82C, GetButtonID( 1, 6 ), GumpButtonType.Reply, 0 ); break;
					}
				}
				
				AddHtml( 20, 166, 160, 18, "<basefont color = #FFFFFF>Fencing</basefont>", false, false ); // Fencing
				AddHtml( 167, 166, 35, 18, FormatSkill( c, SkillName.Fencing ), false, false );
				if ( ( c.Controlled && m_From == c.ControlMaster ) || m_From.AccessLevel >= AccessLevel.GameMaster )
				{
					switch ( c.Skills[SkillName.Fencing].Lock )
					{
						default:
						case SkillLock.Up: AddButton( 204, 170, 0x983, 0x983, GetButtonID( 1, 7 ), GumpButtonType.Reply, 0 ); break;
						case SkillLock.Down: AddButton( 204, 170, 0x985, 0x985, GetButtonID( 1, 7 ), GumpButtonType.Reply, 0 ); break;
						case SkillLock.Locked: AddButton( 204, 169, 0x82C, 0x82C, GetButtonID( 1, 7 ), GumpButtonType.Reply, 0 ); break;
					}
				}
				
				AddHtml( 20, 184, 160, 18, "<basefont color = #FFFFFF>Archery</basefont>", false, false ); // Archery
				AddHtml( 167, 184, 35, 18, FormatSkill( c, SkillName.Archery ), false, false );
				if ( ( c.Controlled && m_From == c.ControlMaster ) || m_From.AccessLevel >= AccessLevel.GameMaster )
				{
					switch ( c.Skills[SkillName.Archery].Lock )
					{
						default:
						case SkillLock.Up: AddButton( 204, 188, 0x983, 0x983, GetButtonID( 1, 8 ), GumpButtonType.Reply, 0 ); break;
						case SkillLock.Down: AddButton( 204, 188, 0x985, 0x985, GetButtonID( 1, 8 ), GumpButtonType.Reply, 0 ); break;
						case SkillLock.Locked: AddButton( 204, 187, 0x82C, 0x82C, GetButtonID( 1, 8 ), GumpButtonType.Reply, 0 ); break;
					}
				}
				
				AddHtml( 20, 202, 160, 18, "<basefont color = #FFFFFF>Parrying</basefont>", false, false ); // Parrying
				AddHtml( 167, 202, 35, 18, FormatSkill( c, SkillName.Parry ), false, false );
				if ( ( c.Controlled && m_From == c.ControlMaster ) || m_From.AccessLevel >= AccessLevel.GameMaster )
				{
					switch ( c.Skills[SkillName.Parry].Lock )
					{
						default:
						case SkillLock.Up: AddButton( 204, 206, 0x983, 0x983, GetButtonID( 1, 9 ), GumpButtonType.Reply, 0 ); break;
						case SkillLock.Down: AddButton( 204, 206, 0x985, 0x985, GetButtonID( 1, 9 ), GumpButtonType.Reply, 0 ); break;
						case SkillLock.Locked: AddButton( 204, 205, 0x82C, 0x82C, GetButtonID( 1, 9 ), GumpButtonType.Reply, 0 ); break;
					}
				}
				// Added 1.9.6
				AddHtml( 20, 220, 160, 18, "<basefont color = #FFFFFF>Chivalry</basefont>", false, false ); // Chivalry
				AddHtml( 167, 220, 35, 18, FormatSkill( c, SkillName.Chivalry ), false, false );
				if ( ( c.Controlled && m_From == c.ControlMaster ) || m_From.AccessLevel >= AccessLevel.GameMaster )
				{
					switch ( c.Skills[SkillName.Chivalry].Lock )
					{
						default:
						case SkillLock.Up: AddButton( 204, 224, 0x983, 0x983, GetButtonID( 1, 25 ), GumpButtonType.Reply, 0 ); break;
						case SkillLock.Down: AddButton( 204, 224, 0x985, 0x985, GetButtonID( 1, 25 ), GumpButtonType.Reply, 0 ); break;
						case SkillLock.Locked: AddButton( 204, 223, 0x82C, 0x82C, GetButtonID( 1, 25 ), GumpButtonType.Reply, 0 ); break;
					}
				}
				// Begin Adjusted Down 1.9.6
				AddHtml( 20, 238, 160, 18, "<basefont color = #FFD57A>Healing Abilities</basefont>", false, false ); // Healing Abilities
				
				AddHtml( 20, 256, 160, 18, "<basefont color = #FFFFFF>Healing</basefont>", false, false ); // Healing
				AddHtml( 167, 256, 35, 18, FormatSkill( c, SkillName.Healing ), false, false );
				if ( ( c.Controlled && m_From == c.ControlMaster ) || m_From.AccessLevel >= AccessLevel.GameMaster )
				{
					switch ( c.Skills[SkillName.Healing].Lock )
					{
						default:
						case SkillLock.Up: AddButton( 204, 260, 0x983, 0x983, GetButtonID( 1, 10 ), GumpButtonType.Reply, 0 ); break;
						case SkillLock.Down: AddButton( 204, 260, 0x985, 0x985, GetButtonID( 1, 10 ), GumpButtonType.Reply, 0 ); break;
						case SkillLock.Locked: AddButton( 204, 259, 0x82C, 0x82C, GetButtonID( 1, 10 ), GumpButtonType.Reply, 0 ); break;
					}
				}
				
				AddHtml( 20, 274, 160, 18, "<basefont color = #FFFFFF>Veterinary</basefont>", false, false ); // Veterinary
				AddHtml( 167, 274, 35, 18, FormatSkill( c, SkillName.Veterinary ), false, false );
				if ( ( c.Controlled && m_From == c.ControlMaster ) || m_From.AccessLevel >= AccessLevel.GameMaster )
				{
					switch ( c.Skills[SkillName.Veterinary].Lock )
					{
						default:
						case SkillLock.Up: AddButton( 204, 278, 0x983, 0x983, GetButtonID( 1, 11 ), GumpButtonType.Reply, 0 ); break;
						case SkillLock.Down: AddButton( 204, 278, 0x985, 0x985, GetButtonID( 1, 11 ), GumpButtonType.Reply, 0 ); break;
						case SkillLock.Locked: AddButton( 204, 277, 0x82C, 0x82C, GetButtonID( 1, 11 ), GumpButtonType.Reply, 0 ); break;
					}
				}
				// End Adjusted Down 1.9.6
				//Middle Display
				AddHtml( 125, 28, 160, 18, "<basefont color = #FFD57A><center>Skills</center></basefont>", false, false );
				
				//Secnd Half
				AddHtml( 220, 40, 160, 18, "<basefont color = #FFD57A>Lore & Knowledge</basefont>", false, false ); // Lore & Knowledge

				AddHtmlLocalized( 220, 58, 160, 18, 1044076, LabelColor, false, false ); // Evaluating Intelligence
				AddHtml( 357, 58, 35, 18,FormatSkill( c, SkillName.EvalInt ), false, false );
				if ( ( c.Controlled && m_From == c.ControlMaster ) || m_From.AccessLevel >= AccessLevel.GameMaster )
				{
					switch ( c.Skills[SkillName.EvalInt].Lock )
					{
						default:
						case SkillLock.Up: AddButton( 394, 62, 0x983, 0x983, GetButtonID( 1, 12 ), GumpButtonType.Reply, 0 ); break;
						case SkillLock.Down: AddButton( 394, 62, 0x985, 0x985, GetButtonID( 1, 12 ), GumpButtonType.Reply, 0 ); break;
						case SkillLock.Locked: AddButton( 394, 61, 0x82C, 0x82C, GetButtonID( 1, 12 ), GumpButtonType.Reply, 0 ); break;
					}
				}
				
				AddHtmlLocalized( 220, 76, 160, 18, 1044106, LabelColor, false, false ); // Meditation
				AddHtml( 357, 76, 35, 18, FormatSkill( c, SkillName.Meditation ), false, false );
				if ( ( c.Controlled && m_From == c.ControlMaster ) || m_From.AccessLevel >= AccessLevel.GameMaster )
				{
					switch ( c.Skills[SkillName.Meditation].Lock )
					{
						default:
						case SkillLock.Up: AddButton( 394, 80, 0x983, 0x983, GetButtonID( 1, 13 ), GumpButtonType.Reply, 0 ); break;
						case SkillLock.Down: AddButton( 394, 80, 0x985, 0x985, GetButtonID( 1, 13 ), GumpButtonType.Reply, 0 ); break;
						case SkillLock.Locked: AddButton( 394, 79, 0x82C, 0x82C, GetButtonID( 1, 13 ), GumpButtonType.Reply, 0 ); break;
					}
				}
				
				AddHtml( 220, 94, 160, 18, "<basefont color = #FFFFFF>Animal Lore</basefont>", false, false ); // Animal Lore
				AddHtml( 357, 94, 35, 18, FormatSkill( c, SkillName.AnimalLore ), false, false );
				if ( ( c.Controlled && m_From == c.ControlMaster ) || m_From.AccessLevel >= AccessLevel.GameMaster )
				{
					switch ( c.Skills[SkillName.AnimalLore].Lock )
					{
						default:
						case SkillLock.Up: AddButton( 394, 98, 0x983, 0x983, GetButtonID( 1, 14 ), GumpButtonType.Reply, 0 ); break;
						case SkillLock.Down: AddButton( 394, 98, 0x985, 0x985, GetButtonID( 1, 14 ), GumpButtonType.Reply, 0 ); break;
						case SkillLock.Locked: AddButton( 394, 97, 0x82C, 0x82C, GetButtonID( 1, 14 ), GumpButtonType.Reply, 0 ); break;
					}
				}
				
				AddHtml( 220, 112, 160, 18, "<basefont color = #FFD57A>Miscellaneous</basefont>", false, false ); // Misc
				
				AddHtml( 220, 130, 160, 18, "<basefont color = #FFFFFF>Focus</basefont>", false, false ); // Focus
				AddHtml( 357, 130, 35, 18, FormatSkill( c, SkillName.Focus ), false, false );
				if ( ( c.Controlled && m_From == c.ControlMaster ) || m_From.AccessLevel >= AccessLevel.GameMaster )
				{
					switch ( c.Skills[SkillName.Focus].Lock )
					{
						default:
						case SkillLock.Up: AddButton( 394, 134, 0x983, 0x983, GetButtonID( 1, 16 ), GumpButtonType.Reply, 0 ); break;
						case SkillLock.Down: AddButton( 394, 134, 0x985, 0x985, GetButtonID( 1, 16 ), GumpButtonType.Reply, 0 ); break;
						case SkillLock.Locked: AddButton( 394, 133, 0x82C, 0x82C, GetButtonID( 1, 16 ), GumpButtonType.Reply, 0 ); break;
					}
				}
				// Added 1.9.2
				AddHtml( 220, 148, 160, 18, "<basefont color = #FFFFFF>Spirit Speak</basefont>", false, false ); // Spirit Speak
				AddHtml( 357, 148, 35, 18, FormatSkill( c, SkillName.SpiritSpeak ), false, false );
				if ( ( c.Controlled && m_From == c.ControlMaster ) || m_From.AccessLevel >= AccessLevel.GameMaster )
				{
					switch ( c.Skills[SkillName.SpiritSpeak].Lock )
					{
						default:
						case SkillLock.Up: AddButton( 394, 152, 0x983, 0x983, GetButtonID( 1, 23 ), GumpButtonType.Reply, 0 ); break;
						case SkillLock.Down: AddButton( 394, 152, 0x985, 0x985, GetButtonID( 1, 23 ), GumpButtonType.Reply, 0 ); break;
						case SkillLock.Locked: AddButton( 394, 151, 0x82C, 0x82C, GetButtonID( 1, 23 ), GumpButtonType.Reply, 0 ); break;
					}
				}
				//The rest was adjusted downwards
				AddHtml( 220, 166, 160, 18, "<basefont color = #FFD57A>Barding</basefont>", false, false ); // Barding
				
				AddHtml( 220, 184, 160, 18, "<basefont color = #FFFFFF>Musicianship</basefont>", false, false ); // Musicianship
				AddHtml( 357, 184, 35, 18, FormatSkill( c, SkillName.Musicianship ), false, false );
				if ( ( c.Controlled && m_From == c.ControlMaster ) || m_From.AccessLevel >= AccessLevel.GameMaster )
				{
					switch ( c.Skills[SkillName.Musicianship].Lock )
					{
						default:
						case SkillLock.Up: AddButton( 394, 188, 0x983, 0x983, GetButtonID( 1, 17 ), GumpButtonType.Reply, 0 ); break;
						case SkillLock.Down: AddButton( 394, 188, 0x985, 0x985, GetButtonID( 1, 17 ), GumpButtonType.Reply, 0 ); break;
						case SkillLock.Locked: AddButton( 394, 187, 0x82C, 0x82C, GetButtonID( 1, 17 ), GumpButtonType.Reply, 0 ); break;
					}
				}
				
				AddHtml( 220, 202, 160, 18, "<basefont color = #FFFFFF>Peacemaking</basefont>", false, false ); // Peacemaking
				AddHtml( 357, 202, 35, 18, FormatSkill( c, SkillName.Peacemaking ), false, false );
				if ( ( c.Controlled && m_From == c.ControlMaster ) || m_From.AccessLevel >= AccessLevel.GameMaster )
				{
					switch ( c.Skills[SkillName.Peacemaking].Lock )
					{
						default:
						case SkillLock.Up: AddButton( 394, 206, 0x983, 0x983, GetButtonID( 1, 18 ), GumpButtonType.Reply, 0 ); break;
						case SkillLock.Down: AddButton( 394, 206, 0x985, 0x985, GetButtonID( 1, 18 ), GumpButtonType.Reply, 0 ); break;
						case SkillLock.Locked: AddButton( 394, 205, 0x82C, 0x82C, GetButtonID( 1, 18 ), GumpButtonType.Reply, 0 ); break;
					}
				}
				
				AddHtml( 220, 220, 160, 18, "<basefont color = #FFFFFF>Discordance</basefont>", false, false ); // Discordance
				AddHtml( 357, 220, 35, 18, FormatSkill( c, SkillName.Discordance ), false, false );
				if ( ( c.Controlled && m_From == c.ControlMaster ) || m_From.AccessLevel >= AccessLevel.GameMaster )
				{
					switch ( c.Skills[SkillName.Discordance].Lock )
					{
						default:
						case SkillLock.Up: AddButton( 394, 224, 0x983, 0x983, GetButtonID( 1, 19 ), GumpButtonType.Reply, 0 ); break;
						case SkillLock.Down: AddButton( 394, 224, 0x985, 0x985, GetButtonID( 1, 19 ), GumpButtonType.Reply, 0 ); break;
						case SkillLock.Locked: AddButton( 394, 223, 0x82C, 0x82C, GetButtonID( 1, 19 ), GumpButtonType.Reply, 0 ); break;
					}
				}
				
				AddHtml( 220, 238, 160, 18, "<basefont color = #FFFFFF>Provocation</basefont>", false, false ); // Provocation
				AddHtml( 357, 238, 35, 18, FormatSkill( c, SkillName.Provocation ), false, false );
				if ( ( c.Controlled && m_From == c.ControlMaster ) || m_From.AccessLevel >= AccessLevel.GameMaster )
				{
					switch ( c.Skills[SkillName.Provocation].Lock )
					{
						default:
						case SkillLock.Up: AddButton( 394, 242, 0x983, 0x983, GetButtonID( 1, 20 ), GumpButtonType.Reply, 0 ); break;
						case SkillLock.Down: AddButton( 394, 242, 0x985, 0x985, GetButtonID( 1, 20 ), GumpButtonType.Reply, 0 ); break;
						case SkillLock.Locked: AddButton( 394, 241, 0x82C, 0x82C, GetButtonID( 1, 20 ), GumpButtonType.Reply, 0 ); break;
					}
				}
				
				AddHtml( 220, 256, 160, 18, "<basefont color = #FFD57A>Thievery</basefont>", false, false ); // Thievery
				
				AddHtml( 220, 274, 160, 18, "<basefont color = #FFFFFF>Hiding</basefont>", false, false ); // Hiding
				AddHtml( 357, 274, 35, 18, FormatSkill( c, SkillName.Hiding ), false, false );
				if ( ( c.Controlled && m_From == c.ControlMaster ) || m_From.AccessLevel >= AccessLevel.GameMaster )
				{
					switch ( c.Skills[SkillName.Hiding].Lock )
					{
						default:
						case SkillLock.Up: AddButton( 394, 278, 0x983, 0x983, GetButtonID( 1, 15 ), GumpButtonType.Reply, 0 ); break;
						case SkillLock.Down: AddButton( 394, 278, 0x985, 0x985, GetButtonID( 1, 15 ), GumpButtonType.Reply, 0 ); break;
						case SkillLock.Locked: AddButton( 394, 277, 0x82C, 0x82C, GetButtonID( 1, 15 ), GumpButtonType.Reply, 0 ); break;
					}
				}
				
				AddHtml( 220, 292, 160, 18, "<basefont color = #FFFFFF>Stealing</basefont>", false, false ); // Stealing
				AddHtml( 357, 292, 35, 18, FormatSkill( c, SkillName.Stealing ), false, false );
				if ( ( c.Controlled && m_From == c.ControlMaster ) || m_From.AccessLevel >= AccessLevel.GameMaster )
				{
					switch ( c.Skills[SkillName.Stealing].Lock )
					{
						default:
						case SkillLock.Up: AddButton( 394, 296, 0x983, 0x983, GetButtonID( 1, 21 ), GumpButtonType.Reply, 0 ); break;
						case SkillLock.Down: AddButton( 394, 296, 0x985, 0x985, GetButtonID( 1, 21 ), GumpButtonType.Reply, 0 ); break;
						case SkillLock.Locked: AddButton( 394, 295, 0x82C, 0x82C, GetButtonID( 1, 21 ), GumpButtonType.Reply, 0 ); break;
					}
				}
				
				AddHtml( 220, 310, 160, 18, "<basefont color = #FFFFFF>Lockpicking</basefont>", false, false ); // Lockpicking
				AddHtml( 357, 310, 35, 18, FormatSkill( c, SkillName.Lockpicking ), false, false );
				if ( ( c.Controlled && m_From == c.ControlMaster ) || m_From.AccessLevel >= AccessLevel.GameMaster )
				{
					switch ( c.Skills[SkillName.Lockpicking].Lock )
					{
						default:
						case SkillLock.Up: AddButton( 394, 314, 0x983, 0x983, GetButtonID( 1, 22 ), GumpButtonType.Reply, 0 ); break;
						case SkillLock.Down: AddButton( 394, 314, 0x985, 0x985, GetButtonID( 1, 22 ), GumpButtonType.Reply, 0 ); break;
						case SkillLock.Locked: AddButton( 394, 313, 0x82C, 0x82C, GetButtonID( 1, 22 ), GumpButtonType.Reply, 0 ); break;
					}
				}
				// Added 1.9.5
				AddHtml( 220, 328, 160, 18, "<basefont color = #FFFFFF>Poisoning</basefont>", false, false ); // Poisoning
				AddHtml( 357, 328, 35, 18, FormatSkill( c, SkillName.Poisoning ), false, false );
				if ( ( c.Controlled && m_From == c.ControlMaster ) || m_From.AccessLevel >= AccessLevel.GameMaster )
				{
					switch ( c.Skills[SkillName.Poisoning].Lock )
					{
						default:
						case SkillLock.Up: AddButton( 394, 332, 0x983, 0x983, GetButtonID( 1, 24 ), GumpButtonType.Reply, 0 ); break;
						case SkillLock.Down: AddButton( 394, 332, 0x985, 0x985, GetButtonID( 1, 24 ), GumpButtonType.Reply, 0 ); break;
						case SkillLock.Locked: AddButton( 394, 331, 0x82C, 0x82C, GetButtonID( 1, 24 ), GumpButtonType.Reply, 0 ); break;
					}
				}
				
				//Navigation
				AddHtml( 40, 20, 160, 18, "<basefont color = #FFD57A>Stats</basefont>", false, false );
				AddButton( 20, 21, 5603, 5607, GetButtonID( 2, 2 ), GumpButtonType.Reply, 0 );
				
				if( ( c.Controlled && from == c.ControlMaster ) || from.AccessLevel >= AccessLevel.GameMaster )
				{
					AddHtml( 327, 20, 160, 18, "<basefont color = #FFD57A>Switches</basefont>", false, false );
					AddButton( 377, 22, 5601, 5605, GetButtonID( 2, 3 ), GumpButtonType.Reply, 0 );
				}
			}
			else if ( page == SquireLorePage.Switches )
			{
				// Added 1.9.7
				// Background Setup
				AddBackground( 0, 0, 420, 452, 5054 );
				AddImageTiled( 10, 10, 400, 432, 2624 );
				AddAlphaRegion( 10, 10, 400, 432 );
				
				if ( c is Squire && ( ( c.Controlled && from == c.ControlMaster ) || from.AccessLevel >= AccessLevel.GameMaster ) )
				{
					//First Display
					AddHtml( 20, 40, 160, 18, "<basefont color = #FFD57A>Inspectable</basefont>", false, false ); // Inspectable
					if ( ((Squire)c).m_Inspectable == true )
					{
						AddHtml( 20, 58, 160, 18, "<basefont color = #FFFFFF>True</basefont>", false, false ); // True
						AddButton( 60, 62, 0x983, 0x983, GetButtonID( 3, 1 ), GumpButtonType.Reply, 0 );
					}
					else
					{
						AddHtml( 20, 58, 160, 18, "<basefont color = #FFFFFF>False</basefont>", false, false ); // False
						AddButton( 60, 62, 0x985, 0x985, GetButtonID( 3, 2 ), GumpButtonType.Reply, 0 );
					}
					
					AddHtml( 20, 76, 160, 18, "<basefont color = #FFD57A>Auto Pickup Ammo</basefont>", false, false ); // Inspectable
					if ( ((Squire)c).m_AutoPickupAmmo == true )
					{
						AddHtml( 20, 94, 160, 18, "<basefont color = #FFFFFF>True</basefont>", false, false ); // True
						AddButton( 60, 98, 0x983, 0x983, GetButtonID( 3, 3 ), GumpButtonType.Reply, 0 );
					}
					else
					{
						AddHtml( 20, 94, 160, 18, "<basefont color = #FFFFFF>False</basefont>", false, false ); // False
						AddButton( 60, 98, 0x985, 0x985, GetButtonID( 3, 4 ), GumpButtonType.Reply, 0 );
					}
					
					AddHtml( 20, 112, 160, 18, "<basefont color = #FFD57A>Be Quiet</basefont>", false, false ); // Inspectable
					if ( ((Squire)c).m_SquireBeQuiet == true )
					{
						AddHtml( 20, 130, 160, 18, "<basefont color = #FFFFFF>True</basefont>", false, false ); // True
						AddButton( 60, 134, 0x983, 0x983, GetButtonID( 3, 5 ), GumpButtonType.Reply, 0 );
					}
					else
					{
						AddHtml( 20, 130, 160, 18, "<basefont color = #FFFFFF>False</basefont>", false, false ); // False
						AddButton( 60, 134, 0x985, 0x985, GetButtonID( 3, 6 ), GumpButtonType.Reply, 0 );
					}
					
					AddHtml( 20, 148, 160, 18, "<basefont color = #FFD57A>Desperate Master Run</basefont>", false, false ); // Inspectable
					if ( ((Squire)c).m_DesperateMasterRun == true )
					{
						AddHtml( 20, 166, 160, 18, "<basefont color = #FFFFFF>True</basefont>", false, false ); // True
						AddButton( 60, 170, 0x983, 0x983, GetButtonID( 3, 7 ), GumpButtonType.Reply, 0 );
					}
					else
					{
						AddHtml( 20, 166, 160, 18, "<basefont color = #FFFFFF>False</basefont>", false, false ); // False
						AddButton( 60, 170, 0x985, 0x985, GetButtonID( 3, 8 ), GumpButtonType.Reply, 0 );
					}
					
					AddHtml( 20, 184, 160, 18, "<basefont color = #FFD57A>Auto Use Health Potion</basefont>", false, false ); // Inspectable
					if ( ((Squire)c).m_AutoUseHealthPotion == true )
					{
						AddHtml( 20, 202, 160, 18, "<basefont color = #FFFFFF>True</basefont>", false, false ); // True
						AddButton( 60, 206, 0x983, 0x983, GetButtonID( 3, 9 ), GumpButtonType.Reply, 0 );
					}
					else
					{
						AddHtml( 20, 202, 160, 18, "<basefont color = #FFFFFF>False</basefont>", false, false ); // False
						AddButton( 60, 206, 0x985, 0x985, GetButtonID( 3, 10 ), GumpButtonType.Reply, 0 );
					}
					
					AddHtml( 20, 220, 160, 18, "<basefont color = #FFD57A>Auto Use Power Scroll</basefont>", false, false ); // Inspectable
					if ( ((Squire)c).m_AutoUsePowerScroll == true ) //Fixed 1.9.1 I overlooked this and left it set to AutoUseHealthPotion as a determining switch.
					{
						AddHtml( 20, 238, 160, 18, "<basefont color = #FFFFFF>True</basefont>", false, false ); // True
						AddButton( 60, 242, 0x983, 0x983, GetButtonID( 3, 11 ), GumpButtonType.Reply, 0 );
					}
					else
					{
						AddHtml( 20, 238, 160, 18, "<basefont color = #FFFFFF>False</basefont>", false, false ); // False
						AddButton( 60, 242, 0x985, 0x985, GetButtonID( 3, 12 ), GumpButtonType.Reply, 0 );
					}
					
					AddHtml( 20, 256, 160, 18, "<basefont color = #FFD57A>Auto Equip Loot</basefont>", false, false ); // Inspectable
					if ( ((Squire)c).m_AutoEquipLoot == true )
					{
						AddHtml( 20, 274, 160, 18, "<basefont color = #FFFFFF>True</basefont>", false, false ); // True
						AddButton( 60, 278, 0x983, 0x983, GetButtonID( 3, 13 ), GumpButtonType.Reply, 0 );
					}
					else
					{
						AddHtml( 20, 274, 160, 18, "<basefont color = #FFFFFF>False</basefont>", false, false ); // False
						AddButton( 60, 278, 0x985, 0x985, GetButtonID( 3, 14 ), GumpButtonType.Reply, 0 );
					}
					
					AddHtml( 20, 292, 160, 18, "<basefont color = #FFD57A>Auto Rez Ally</basefont>", false, false ); // Inspectable
					if ( ((Squire)c).m_AutoRezAlly == true )
					{
						AddHtml( 20, 310, 160, 18, "<basefont color = #FFFFFF>True</basefont>", false, false ); // True
						AddButton( 60, 314, 0x983, 0x983, GetButtonID( 3, 15 ), GumpButtonType.Reply, 0 );
					}
					else
					{
						AddHtml( 20, 310, 160, 18, "<basefont color = #FFFFFF>False</basefont>", false, false ); // False
						AddButton( 60, 314, 0x985, 0x985, GetButtonID( 3, 16 ), GumpButtonType.Reply, 0 );
					}
					// Renamed 1.9.7
					AddHtml( 20, 328, 160, 22, "<basefont color = #FFD57A>Close Wounds Self</basefont>", false, false ); // Inspectable
					if ( ((Squire)c).m_AutoCastCloseWounds == true )
					{
						AddHtml( 20, 346, 160, 18, "<basefont color = #FFFFFF>True</basefont>", false, false ); // True
						AddButton( 60, 350, 0x983, 0x983, GetButtonID( 3, 17 ), GumpButtonType.Reply, 0 );
					}
					else
					{
						AddHtml( 20, 346, 160, 18, "<basefont color = #FFFFFF>False</basefont>", false, false ); // False
						AddButton( 60, 350, 0x985, 0x985, GetButtonID( 3, 18 ), GumpButtonType.Reply, 0 );
					}
					// Added 1.9.7
					AddHtml( 20, 364, 160, 18, "<basefont color = #FFD57A>Close Wounds Master</basefont>", false, false ); // Inspectable
					if ( ((Squire)c).m_AutoCastCloseWoundsMaster == true )
					{
						AddHtml( 20, 382, 160, 18, "<basefont color = #FFFFFF>True</basefont>", false, false ); // True
						AddButton( 60, 386, 0x983, 0x983, GetButtonID( 3, 25 ), GumpButtonType.Reply, 0 );
					}
					else
					{
						AddHtml( 20, 382, 160, 18, "<basefont color = #FFFFFF>False</basefont>", false, false ); // False
						AddButton( 60, 386, 0x985, 0x985, GetButtonID( 3, 26 ), GumpButtonType.Reply, 0 );
					}
					// Added 1.9.7
					AddHtml( 20, 400, 160, 18, "<basefont color = #FFD57A>Close Wounds Ally</basefont>", false, false ); // Inspectable
					if ( ((Squire)c).m_AutoCastCloseWoundsAlly == true )
					{
						AddHtml( 20, 418, 160, 18, "<basefont color = #FFFFFF>True</basefont>", false, false ); // True
						AddButton( 60, 422, 0x983, 0x983, GetButtonID( 3, 27 ), GumpButtonType.Reply, 0 );
					}
					else
					{
						AddHtml( 20, 418, 160, 18, "<basefont color = #FFFFFF>False</basefont>", false, false ); // False
						AddButton( 60, 422, 0x985, 0x985, GetButtonID( 3, 28 ), GumpButtonType.Reply, 0 );
					}
					
					//Second Display
					AddHtml( 220, 40, 160, 18, "<basefont color = #FFD57A>Auto Heal Self</basefont>", false, false ); // Inspectable
					if ( ((Squire)c).m_AutoHealSelf == true )
					{
						AddHtml( 220, 58, 160, 18, "<basefont color = #FFFFFF>True</basefont>", false, false ); // True
						AddButton( 260, 62, 0x983, 0x983, GetButtonID( 4, 1 ), GumpButtonType.Reply, 0 );
					}
					else
					{
						AddHtml( 220, 58, 160, 18, "<basefont color = #FFFFFF>False</basefont>", false, false ); // False
						AddButton( 260, 62, 0x985, 0x985, GetButtonID( 4, 2 ), GumpButtonType.Reply, 0 );
					}
					
					AddHtml( 220, 76, 160, 18, "<basefont color = #FFD57A>Auto Heal Master</basefont>", false, false ); // Inspectable
					if ( ((Squire)c).m_AutoHealMaster == true )
					{
						AddHtml( 220, 94, 160, 18, "<basefont color = #FFFFFF>True</basefont>", false, false ); // True
						AddButton( 260, 98, 0x983, 0x983, GetButtonID( 4, 3 ), GumpButtonType.Reply, 0 );
					}
					else
					{
						AddHtml( 220, 94, 160, 18, "<basefont color = #FFFFFF>False</basefont>", false, false ); // False
						AddButton( 260, 98, 0x985, 0x985, GetButtonID( 4, 4 ), GumpButtonType.Reply, 0 );
					}
					
					AddHtml( 220, 112, 160, 18, "<basefont color = #FFD57A>Auto Heal Others</basefont>", false, false ); // Inspectable
					if ( ((Squire)c).m_AutoHealOther == true )
					{
						AddHtml( 220, 130, 160, 18, "<basefont color = #FFFFFF>True</basefont>", false, false ); // True
						AddButton( 260, 134, 0x983, 0x983, GetButtonID( 4, 5 ), GumpButtonType.Reply, 0 );
					}
					else
					{
						AddHtml( 220, 130, 160, 18, "<basefont color = #FFFFFF>False</basefont>", false, false ); // False
						AddButton( 260, 134, 0x985, 0x985, GetButtonID( 4, 6 ), GumpButtonType.Reply, 0 );
					}
					
					AddHtml( 220, 148, 160, 18, "<basefont color = #FFD57A>Auto Heal Animals</basefont>", false, false ); // Inspectable
					if ( ((Squire)c).m_AutoHealAnimals == true )
					{
						AddHtml( 220, 166, 160, 18, "<basefont color = #FFFFFF>True</basefont>", false, false ); // True
						AddButton( 260, 170, 0x983, 0x983, GetButtonID( 4, 7 ), GumpButtonType.Reply, 0 );
					}
					else
					{
						AddHtml( 220, 166, 160, 18, "<basefont color = #FFFFFF>False</basefont>", false, false ); // False
						AddButton( 260, 170, 0x985, 0x985, GetButtonID( 4, 8 ), GumpButtonType.Reply, 0 );
					}
					
					AddHtml( 220, 186, 160, 18, "<basefont color = #FFD57A>Auto Use Cure Potion</basefont>", false, false ); // Inspectable
					if ( ((Squire)c).m_AutoUseCurePotion == true )
					{
						AddHtml( 220, 204, 160, 18, "<basefont color = #FFFFFF>True</basefont>", false, false ); // True
						AddButton( 260, 208, 0x983, 0x983, GetButtonID( 4, 9 ), GumpButtonType.Reply, 0 );
					}
					else
					{
						AddHtml( 220, 204, 160, 18, "<basefont color = #FFFFFF>False</basefont>", false, false ); // False
						AddButton( 260, 208, 0x985, 0x985, GetButtonID( 4, 10 ), GumpButtonType.Reply, 0 );
					}
					
					AddHtml( 220, 220, 160, 18, "<basefont color = #FFD57A>Auto Use Training Contract</basefont>", false, false ); // Inspectable
					if ( ((Squire)c).m_AutoUseTScroll == true )
					{
						AddHtml( 220, 238, 160, 18, "<basefont color = #FFFFFF>True</basefont>", false, false ); // True
						AddButton( 260, 242, 0x983, 0x983, GetButtonID( 4, 11 ), GumpButtonType.Reply, 0 );
					}
					else
					{
						AddHtml( 220, 238, 160, 18, "<basefont color = #FFFFFF>False</basefont>", false, false ); // False
						AddButton( 260, 242, 0x985, 0x985, GetButtonID( 4, 12 ), GumpButtonType.Reply, 0 );
					}
					
					AddHtml( 220, 256, 160, 18, "<basefont color = #FFD57A>Auto Spirit Speak</basefont>", false, false ); // Inspectable
					if ( ((Squire)c).m_AutoUseSpiritSpeak == true )
					{
						AddHtml( 220, 274, 160, 18, "<basefont color = #FFFFFF>True</basefont>", false, false ); // True
						AddButton( 260, 278, 0x983, 0x983, GetButtonID( 4, 13 ), GumpButtonType.Reply, 0 );
					}
					else
					{
						AddHtml( 220, 274, 160, 18, "<basefont color = #FFFFFF>False</basefont>", false, false ); // False
						AddButton( 260, 278, 0x985, 0x985, GetButtonID( 4, 14 ), GumpButtonType.Reply, 0 );
					}
					
					AddHtml( 220, 292, 160, 18, "<basefont color = #FFD57A>Auto Rez Master</basefont>", false, false ); // Inspectable
					if ( ((Squire)c).m_AutoRezMaster == true )
					{
						AddHtml( 220, 310, 160, 18, "<basefont color = #FFFFFF>True</basefont>", false, false ); // True
						AddButton( 260, 314, 0x983, 0x983, GetButtonID( 4, 15 ), GumpButtonType.Reply, 0 );
					}
					else
					{
						AddHtml( 220, 310, 160, 18, "<basefont color = #FFFFFF>False</basefont>", false, false ); // False
						AddButton( 260, 314, 0x985, 0x985, GetButtonID( 4, 16 ), GumpButtonType.Reply, 0 );
					}
					// Renamed 1.9.7
					AddHtml( 220, 328, 160, 18, "<basefont color = #FFD57A>Cleanse By Fire Self</basefont>", false, false ); // Inspectable
					if ( ((Squire)c).m_AutoCastCleanseByFire == true )
					{
						AddHtml( 220, 346, 160, 18, "<basefont color = #FFFFFF>True</basefont>", false, false ); // True
						AddButton( 260, 350, 0x983, 0x983, GetButtonID( 3, 19 ), GumpButtonType.Reply, 0 );
					}
					else
					{
						AddHtml( 220, 346, 160, 18, "<basefont color = #FFFFFF>False</basefont>", false, false ); // False
						AddButton( 260, 350, 0x985, 0x985, GetButtonID( 3, 20 ), GumpButtonType.Reply, 0 );
					}
					// Added 1.9.7
					AddHtml( 220, 364, 160, 18, "<basefont color = #FFD57A>Cleanse By Fire Master</basefont>", false, false ); // Inspectable
					if ( ((Squire)c).m_AutoCastCleanseByFireMaster == true )
					{
						AddHtml( 220, 382, 160, 18, "<basefont color = #FFFFFF>True</basefont>", false, false ); // True
						AddButton( 260, 386, 0x983, 0x983, GetButtonID( 3, 21 ), GumpButtonType.Reply, 0 );
					}
					else
					{
						AddHtml( 220, 382, 160, 18, "<basefont color = #FFFFFF>False</basefont>", false, false ); // False
						AddButton( 260, 386, 0x985, 0x985, GetButtonID( 3, 22 ), GumpButtonType.Reply, 0 );
					}
					// Added 1.9.7
					AddHtml( 220, 400, 160, 18, "<basefont color = #FFD57A>Cleanse By Fire Ally</basefont>", false, false ); // Inspectable
					if ( ((Squire)c).m_AutoCastCleanseByFireAlly == true )
					{
						AddHtml( 220, 418, 160, 18, "<basefont color = #FFFFFF>True</basefont>", false, false ); // True
						AddButton( 260, 422, 0x983, 0x983, GetButtonID( 3, 23 ), GumpButtonType.Reply, 0 );
					}
					else
					{
						AddHtml( 220, 418, 160, 18, "<basefont color = #FFFFFF>False</basefont>", false, false ); // False
						AddButton( 260, 422, 0x985, 0x985, GetButtonID( 3, 24 ), GumpButtonType.Reply, 0 );
					}
				}
				
				//Middle Display
				AddHtml( 125, 28, 160, 18, "<basefont color = #FFD57A><center>Switches</center></basefont>", false, false );
				
				//Navigation
				AddHtml( 40, 20, 160, 18, "<basefont color = #FFD57A>Stats</basefont>", false, false );
				AddButton( 20, 21, 5603, 5607, GetButtonID( 2, 2 ), GumpButtonType.Reply, 0 );
				
				AddHtml( 347, 20, 160, 18, "<basefont color = #FFD57A>Skills</basefont>", false, false );
				AddButton( 377, 22, 5601, 5605, GetButtonID( 2, 1), GumpButtonType.Reply, 0 );
			}
			#endregion
		}
	}
}