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
	[CorpseName( "Alecsander's Corpse" )]
	public class Alecsander : Mobile
	{
                public virtual bool IsInvulnerable{ get{ return true; } }
		[Constructable]
		public Alecsander()
		{
			Name = "Alecsander";
			Body = 0x190;
			CantWalk = true;
			Hue = 0x83F8;
			AddItem( new Server.Items.Boots() );
			AddItem( new Server.Items.FancyShirt( 21 ) );
			AddItem( new Server.Items.LongPants( 20 ) );
			AddItem( new Server.Items.Cloak( 518 ) );
			AddItem( new Server.Items.FeatheredHat( 1 ) );

                        int hairHue = 1741;

			switch ( Utility.Random( 1 ) )
			{
				case 0: AddItem( new ShortHair( hairHue ) ); break;
			} 
			
			Blessed = true;
			
			}



		public Alecsander( Serial serial ) : base( serial )
		{
		}

		public override void GetContextMenuEntries( Mobile from, List<ContextMenuEntry> list ) 
	        { 
	                base.GetContextMenuEntries( from, list ); 
        	        list.Add( new AlecsanderEntry( from, this ) ); 
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

		public class AlecsanderEntry : ContextMenuEntry
		{
			private Mobile m_Mobile;
			private Mobile m_Giver;
			
			public AlecsanderEntry( Mobile from, Mobile giver ) : base( 6146, 3 )
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
					if ( ! mobile.HasGump( typeof( AlecsanderGump ) ) )
					{
						mobile.SendGump( new AlecsanderGump( mobile ));
						
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
					mobile.AddToBackpack( new Gold( 1500 ) );

					switch ( Utility.Random( 7 ) )
					{
						case 0: mobile.AddToBackpack( new GoldenGoblet() ); break;
                        case 1: mobile.AddToBackpack(new NordicVikingSword()); break;
						case 2: mobile.AddToBackpack( new SmallUrn() ); break;
						case 3: mobile.AddToBackpack( new Basket() ); break;
						case 4: mobile.AddToBackpack( new FunkyMushroom() ); break;
						case 5: mobile.AddToBackpack( new CloakOfInvisibility() ); break;
                        case 6: mobile.AddToBackpack(new DreadPirateBoots()); break;
					} 					

         				mobile.SendGump( new AlecsanderFinishGump());


				
					return true;
         		}
				else if ( dropped is VacarsLoveLetter )
				{
				this.PrivateOverheadMessage( MessageType.Regular, 1153, 1054071, mobile.NetState );
         			return false;
				}
         		else
         		{
					this.PrivateOverheadMessage( MessageType.Regular, 1153, false, "Nooo! I need that love letter!", mobile.NetState );
     			}
			}
			return false;
		}
	}
}
