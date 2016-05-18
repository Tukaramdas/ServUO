/////////// Scripted By TALON NYTE ///////////

using System;
using System.Collections;
using System.Collections.Generic;
using Server.Items;
using Server.Targeting;
using Server.ContextMenus;
using Server.Gumps;
using Server.Misc;

namespace Server.Mobiles
{
	[CorpseName( "Lord Onyx corpse" )]
	public class LordOnyx : Mobile
	{
                public virtual bool IsInvulnerable{ get{ return true; } }
		[Constructable]
		public LordOnyx()
		{
			Name = "Lord Onyx";
            Title = "Quest Giver";
            Body = 0x190;
			CantWalk = true;
			Hue = Utility.RandomSkinHue();
			AddItem( new Boots() );
			AddItem( new HoodedShroudOfShadows()); 
			AddItem( new QuickBlade() );
                        HairItemID = 8252;
			
			Blessed = true;
		}

		public LordOnyx( Serial serial ) : base( serial )
		{
		}

		public override void GetContextMenuEntries( Mobile from, List<ContextMenuEntry> list ) 
	        { 
	                base.GetContextMenuEntries( from, list ); 
        	        list.Add( new LordOnyxEntry( from, this ) ); 
	        } 

		public override void Serialize( GenericWriter writer )
		{
			base.Serialize( writer );
			writer.Write( (int) 0 );
		}

		public override void Deserialize( GenericReader reader )
		{
			base.Deserialize( reader );
			int version = reader.ReadInt();
		}

		public class LordOnyxEntry : ContextMenuEntry
		{
			private Mobile m_Mobile;
			private Mobile m_Giver;
			
			public LordOnyxEntry( Mobile from, Mobile giver ) : base( 6146, 3 )
			{
				m_Mobile = from;
				m_Giver = giver;
			}

			public override void OnClick()
			{
				

                          if( !( m_Mobile is PlayerMobile ) )
					return;
				
				PlayerMobile mobile = (PlayerMobile) m_Mobile;

				{
					if ( !mobile.HasGump( typeof( SonOfAbyssQuestGump ) ) )
						mobile.SendGump( new SonOfAbyssQuestGump( m_Mobile ));
				}
			}
		}

		public override bool OnDragDrop( Mobile from, Item dropped )
		{          		
         	        Mobile m = from;
			PlayerMobile mobile = m as PlayerMobile;

			if ( mobile != null)
			{
				if( dropped is RegenerationCrystal)
         			{
         				if(dropped.Amount!=1)
         				{
						//this.PrivateOverheadMessage( MessageType.Regular, 1153, false, "That is not the amount I asked for. I said 12!", mobile.NetState );
         					return false;
         				}

					dropped.Delete();
					switch ( Utility.Random( 8 ) )
					{
						case 0: mobile.AddToBackpack( new AbyssArms() ); break;
						case 1: mobile.AddToBackpack( new AbyssChest() ); break;
						case 2: mobile.AddToBackpack( new AbyssGloves() ); break;
						case 3: mobile.AddToBackpack( new AbyssGorget() ); break;
						case 4: mobile.AddToBackpack( new AbyssLegs() ); break;
						case 5: mobile.AddToBackpack( new AbyssSkirt() ); break;
						case 6: mobile.AddToBackpack( new FemaleAbyssChest() ); break;
                        case 7: mobile.AddToBackpack( new AbyssShield() ); break; 
					}
				
					return true;
         			}
         			else
         			{
					//this.PrivateOverheadMessage( MessageType.Regular, 1153, false, "What is this?", mobile.NetState );
     				}
			}
			return false;
		}
	}
}
