using System;
using System.Collections;
using Server.Items;
using Server.Targeting;
using Server.ContextMenus;
using Server.Gumps;
using Server.Misc;
using Server.Network;
using Server.Spells;
using Server.Engines.Quests;
using System.Collections.Generic; 


namespace Server.Mobiles
{
	[CorpseName( "Steff Corpse" )]
	public class Steff : Mobile
	{
                public virtual bool IsInvulnerable{ get{ return true; } }
                
		[Constructable]
		public Steff()
		{
			Name = "Lady Steff";
                        Title = "Jupiter Warrior";
			Body = 401;
			CantWalk = true;
			Hue = Utility.RandomSkinHue();
			AddItem( new Server.Items.Armsofjupiter() );
			AddItem( new Server.Items.FemaleChestofjupiter() );
			AddItem( new Server.Items.Gorgetofjupiter() );
			AddItem( new Server.Items.Leggingsofjupiter() );
			AddItem( new Server.Items.Glovesofjupiter() );
                        AddItem( new Server.Items.JupiterKatana() );
                        HairItemID = 8252;
                        int hairHue = 707;
			
			switch ( Utility.Random( 1 ) )
			{
				case 0: AddItem( new LongHair( hairHue ) ); break;
			} 
			Blessed = true;
			
		}
		public Steff( Serial serial ) : base( serial )
		{
		}

        	public override void GetContextMenuEntries(Mobile from, List<ContextMenuEntry> list) 
	        { 
	                base.GetContextMenuEntries( from, list ); 
        	        list.Add( new SteffEntry( from, this ) ); 
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

		public class SteffEntry : ContextMenuEntry
		{
			private Mobile m_Mobile;
			private Mobile m_Giver;
			
			public SteffEntry( Mobile from, Mobile giver ) : base( 6146, 3 )
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
					if ( ! mobile.HasGump( typeof( SteffQuestGump ) ) )
					{
						mobile.SendGump( new SteffQuestGump( mobile ));
						
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
				if( dropped is RingOfJupiter )
         			{
         			Container pack = from.Backpack;
	
				if ( pack != null && pack.ConsumeTotal( typeof( HydrogenAtom ), 1 ) )
				{
					if( 1 > Utility.RandomDouble() ) // 1 = 100% = chance to drop 
					switch ( Utility.Random( 8 ))  
					{ 
		
							case 0: mobile.AddToBackpack( new Armsofjupiter() ); break;
							case 1: mobile.AddToBackpack( new Chestofjupiter() ); break;
							case 2: mobile.AddToBackpack( new Gorgetofjupiter() ); break;
							case 3: mobile.AddToBackpack( new Helmetofjupiter() ); break;
							case 4: mobile.AddToBackpack( new Leggingsofjupiter() ); break;
							case 5: mobile.AddToBackpack( new Glovesofjupiter() ); break;
                            case 6: mobile.AddToBackpack( new FemaleChestofjupiter() ); break;
							case 7: mobile.AddToBackpack( new Skirtofjupiter() ); break;
						

					}
				
							return true;
				}
				else
				{
					from.SendMessage(0x22,"You also need a Hydrogen Atom  before you recieve a piece of armor.");
			
				}				
					return false;
         			}
				else if ( dropped is HydrogenAtom )
				{
					Container pack = from.Backpack;
					
					if ( pack != null && pack.ConsumeTotal( typeof( RingOfJupiter ), 1 ) )
					{
						if( 1 > Utility.RandomDouble() ) // 1 = 100% = chance to drop 
						switch ( Utility.Random( 6 ))  
						{
                            case 0: mobile.AddToBackpack(new Armsofjupiter()); break;
                            case 1: mobile.AddToBackpack(new Chestofjupiter()); break;
                            case 2: mobile.AddToBackpack(new Gorgetofjupiter()); break;
                            case 3: mobile.AddToBackpack(new Helmetofjupiter()); break;
                            case 4: mobile.AddToBackpack(new Leggingsofjupiter()); break;
                            case 5: mobile.AddToBackpack(new Glovesofjupiter()); break;
                            case 6: mobile.AddToBackpack(new FemaleChestofjupiter()); break;
                            case 7: mobile.AddToBackpack(new Skirtofjupiter()); break;
					
						}
				
							return true;
					}
					else
					{
						from.SendMessage(0x22,"You also need a RingOfJupitor before you recieve a piece of armor.");
			
					}				
						return false;
				}
         		else
         		{
					this.PrivateOverheadMessage( MessageType.Regular, 1153, false, "I have no need of this!", mobile.NetState );
     			}
			}
			return false;
		}
	}
}
