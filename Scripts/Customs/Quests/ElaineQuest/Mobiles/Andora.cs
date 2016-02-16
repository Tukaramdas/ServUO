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
	[CorpseName( "Andora's Corpse" )]
	public class Andora : Mobile
	{
                public virtual bool IsInvulnerable{ get{ return true; } }
		[Constructable]
		public Andora()
		{
			Name = "Andora";
                        Title = "the Ranger";
			Body = 0x191;
			CantWalk = false;
			Hue = 0x83F8;
			AddItem( new Server.Items.ThighBoots() );
			AddItem( new Server.Items.Shirt( 3 ) );
			AddItem( new Server.Items.ShortPants( 5 ) );
			AddItem( new Server.Items.Cloak( 168 ) );
			AddItem( new Server.Items.LeatherGloves() );
			AddItem( new Server.Items.LeatherChest() );
			AddItem( new Server.Items.CompositeBow() );

                        int hairHue = 1741;

			Utility.AssignRandomHair( this );
			
			Blessed = true;
			
			}



		public Andora( Serial serial ) : base( serial )
		{
		}

		public override void GetContextMenuEntries( Mobile from, List<ContextMenuEntry> list ) 
	        { 
	                base.GetContextMenuEntries( from, list ); 
        	        list.Add( new AndoraEntry( from, this ) ); 
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

		public class AndoraEntry : ContextMenuEntry
		{
			private Mobile m_Mobile;
			private Mobile m_Giver;
			
			public AndoraEntry( Mobile from, Mobile giver ) : base( 6146, 3 )
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
					if ( ! mobile.HasGump( typeof( AndoraGump ) ) )
					{
						mobile.SendGump( new AndoraGump( mobile ));
						
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
				if( dropped is AcarasRing )
         		{
         			if(dropped.Amount!=1)
         			{
					this.PrivateOverheadMessage( MessageType.Regular, 1153, false, "There's not the right amount here!", mobile.NetState );
         				return false;
         			}

					dropped.Delete(); 
					mobile.AddToBackpack( new Gold( 1200 ) );
         				mobile.AddToBackpack( new AndorasBook() );
         				mobile.SendGump( new AndoraFinishGump() );


				
					return true;
         		}
				else if ( dropped is Whip)
				{
				this.PrivateOverheadMessage( MessageType.Regular, 1153, 1054071, mobile.NetState );
         			return false;
				}
         		else
         		{
					this.PrivateOverheadMessage( MessageType.Regular, 1153, false, "Bring me the insolent mage's ring.", mobile.NetState );
     			}
			}
			return false;
		}
	}
}
