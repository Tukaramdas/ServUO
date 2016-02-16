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
	[CorpseName( "Vacar's Corpse" )]
	public class VacarJames : Mobile
	{
                public virtual bool IsInvulnerable{ get{ return true; } }
		[Constructable]
		public VacarJames()
		{
			Name = "Vacar James";
			Body = 0x190;
			CantWalk = false;
			Hue = 0x83F5;
			AddItem( new Server.Items.Sandals() );
			AddItem( new Server.Items.Surcoat( 441 ) );
			AddItem( new Server.Items.ShortPants( 443 ) );
			AddItem( new Server.Items.BodySash() );
			AddItem( new Server.Items.Cap() );

                        int hairHue = 1741;

			switch ( Utility.Random( 1 ) )
			{
				case 0: AddItem( new ShortHair( hairHue ) ); break;
			} 
			
			Blessed = true;
			
			}



		public VacarJames( Serial serial ) : base( serial )
		{
		}

		public override void GetContextMenuEntries( Mobile from, List<ContextMenuEntry> list ) 
	        { 
	                base.GetContextMenuEntries( from, list ); 
        	        list.Add( new VacarJamesEntry( from, this ) ); 
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

		public class VacarJamesEntry : ContextMenuEntry
		{
			private Mobile m_Mobile;
			private Mobile m_Giver;
			
			public VacarJamesEntry( Mobile from, Mobile giver ) : base( 6146, 3 )
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
					if ( ! mobile.HasGump( typeof( VacarJamesGump ) ) )
					{
						mobile.SendGump( new VacarJamesGump( mobile ));
						
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
				if( dropped is AndorasBook )
         		{
         			if(dropped.Amount!=1)
         			{
					this.PrivateOverheadMessage( MessageType.Regular, 1153, false, "There's not the right amount here!", mobile.NetState );
         				return false;
         			}

					dropped.Delete(); 
					mobile.AddToBackpack( new Gold( 100 ) );
					mobile.AddToBackpack( new VacarsLoveLetter() );					

         				mobile.SendGump( new VacarJamesFinishGump());


				
					return true;
         		}
				else if ( dropped is AndorasBook )
				{
				this.PrivateOverheadMessage( MessageType.Regular, 1153, 1054071, mobile.NetState );
         			return false;
				}
         		else
         		{
					this.PrivateOverheadMessage( MessageType.Regular, 1153, false, "What is this crap? It's all crap!", mobile.NetState );
     			}
			}
			return false;
		}
	}
}
