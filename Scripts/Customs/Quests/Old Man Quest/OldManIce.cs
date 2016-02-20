using System;
using System.Collections;
using Server.Items;
using Server.Targeting;
using Server.ContextMenus;
using Server.Gumps;
using Server.Misc;
using Server.Network;
using Server.Spells;
using Server.Accounting;
using System.Collections.Generic;

namespace Server.Mobiles
{
	[CorpseName( "Old Man's Corpse" )]
	public class OldManIce : Mobile
	{
                public virtual bool IsInvulnerable{ get{ return true; } }
		[Constructable]
		public OldManIce()
		{
			Name = "Ice-God";
                        Title = "The Eldest Legend";
			Body = 0x190;
			CantWalk = true;
			Hue = 0x83F8;
			AddItem( new Server.Items.Robe( 1153 ) );
			AddItem( new Server.Items.ShortPants( 1153 ) );
			AddItem( new Server.Items.MagicWizardsHat( 1152 ) );
			
			SmallRedFlask fp = new SmallRedFlask();
			fp.Hue = 1150;
			fp.Name = "Old Man Wrinkle Cream";
                        AddItem( fp );
			

                        int hairHue = 1150;

			switch ( Utility.Random( 1 ) )
			{
				case 0: AddItem( new ShortHair( hairHue ) ); break;
			} 
			
			Blessed = true;
			
			}



		public OldManIce( Serial serial ) : base( serial )
		{
		}

        public override void GetContextMenuEntries(Mobile from, List<ContextMenuEntry> list) 
	        { 
	                base.GetContextMenuEntries( from, list ); 
        	        list.Add( new OldManIceEntry( from, this ) ); 
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

		public class OldManIceEntry : ContextMenuEntry
		{
			private Mobile m_Mobile;
			private Mobile m_Giver;
			
			public OldManIceEntry( Mobile from, Mobile giver ) : base( 6146, 3 )
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
					if ( ! mobile.HasGump( typeof( OldManIceQuestGump ) ) )
					{
						mobile.SendGump( new OldManIceQuestGump( mobile ));
						mobile.AddToBackpack( new WrinkleCreamEmpty() );
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
				if( dropped is WrinkleCreamFull )
			{
				if( dropped.Amount!=1)
				{
					this.PrivateOverheadMessage( MessageType.Regular, 1153, false, "AH! Now this is Old man Wrinkle material here!", mobile.NetState );
					return false;
				}
				
					dropped.Delete();
					mobile.SendGump( new OldManIceQuestGump2(m) );
					
 			if( 1 > Utility.RandomDouble() ) // 1 = 100% = chance to drop 
			switch ( Utility.Random( 1 ))  
			{ 
		
					case 0: mobile.AddToBackpack( new FrozenSwordOfTerror() ); break;

			}					
				
					return true;
         		}
				else if ( dropped is WrinkleCreamFull )
				{
				this.PrivateOverheadMessage( MessageType.Regular, 1153, 1054071, mobile.NetState );
         			return false;
				}
         		else
         		{
					this.PrivateOverheadMessage( MessageType.Regular, 1153, false, "How am I suposed to be using that on my face?", mobile.NetState );
     			}
			}
			return false;
		}
	}
}
				


				


