using System;
using System.Collections;
using System.Collections.Generic;
using Server.Items;
using Server.Targeting;
using Server.ContextMenus;
using Server.Gumps;
using Server.Misc;
using Server.Network;
using Server.Spells;

namespace Server.Mobiles
{
	[CorpseName( "Erik's Corpse" )]
	public class ErikSullivan : Mobile
	{
                public virtual bool IsInvulnerable{ get{ return true; } }
		[Constructable]
		public ErikSullivan()
		{
			Name = "Erik Sullivan";
			Body = 0x190;
			CantWalk = false;
			Hue = 0x83F3;
			AddItem( new Server.Items.Boots() );
			AddItem( new Server.Items.RingmailLegs() );
			AddItem( new Server.Items.Kilt( 944 ) );
			AddItem( new Server.Items.BodySash( 944 ) );
			AddItem( new Server.Items.Cloak( 944 ) );
			AddItem( new Server.Items.NorseHelm() );
			AddItem( new Server.Items.RingmailChest() );
			AddItem( new Server.Items.LeatherGloves() );
			AddItem( new Server.Items.Cutlass() );

                        int hairHue = 1741;

			Utility.AssignRandomHair( this );
			
			Blessed = true;
			
			}



		public ErikSullivan( Serial serial ) : base( serial )
		{
		}

		public override void GetContextMenuEntries( Mobile from, List<ContextMenuEntry> list ) 
	        { 
	                base.GetContextMenuEntries( from, list ); 
        	        list.Add( new ErikSullivanEntry( from, this ) ); 
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

		public class ErikSullivanEntry : ContextMenuEntry
		{
			private Mobile m_Mobile;
			private Mobile m_Giver;
			
			public ErikSullivanEntry( Mobile from, Mobile giver ) : base( 6146, 3 )
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
					if ( ! mobile.HasGump( typeof( ErikSullivanGump ) ) )
					{
						mobile.SendGump( new ErikSullivanGump( mobile ));
						
					} 
				}
			}
		}

public override bool OnDragDrop( Mobile from, Item dropped )
		{          		
         	        Mobile m = from;
			PlayerMobile mobile = m as PlayerMobile;

			if ( mobile != null)
			{
				if( dropped is VacarsLoveLetter )
         		{
         			if(dropped.Amount!=1)
         			{
					this.PrivateOverheadMessage( MessageType.Regular, 1153, false, "There's not the right amount here!", mobile.NetState );
         				return false;
         			}

					dropped.Delete(); 
					mobile.AddToBackpack( new Gold( 500 ) );

					switch ( Utility.Random( 2 ) )
					{
                        case 0: mobile.AddToBackpack(new FortunateBlades()); break;
                        case 1: mobile.AddToBackpack(new MauloftheBeast()); break;
					} 				

         				mobile.SendGump( new ErikSullivanFinishGump());


				
					return true;
         		}
				else if ( dropped is AndorasBook )
				{
				this.PrivateOverheadMessage( MessageType.Regular, 1153, 1054071, mobile.NetState );
         			return false;
				}
         		else
         		{
					this.PrivateOverheadMessage( MessageType.Regular, 1153, false, "This isn't what I asked for, runt.", mobile.NetState );
     			}
			}
			return false;
		}
	}
}
