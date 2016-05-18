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
	[CorpseName( "Sita's corpse" )]
	public class Sita : Mobile
	{
		public virtual bool IsInvulnerable{ get{ return true; } }
		[Constructable]
        public Sita()
        {
            Name = "Sita";
            Title = "The Princess";
            Body = 0x191;
            Direction = Direction.East;
            CantWalk = true;
            Hue = Utility.RandomSkinHue();
            Blessed = true;

            FancyDress fd = new FancyDress();
            fd.Hue = 84;
            AddItem(fd);

            Sandals s = new Sandals();
            s.Hue = 84;
            AddItem(s);

            AddItem(new LongHair(52));

        }
		
		public Sita( Serial serial ) : base( serial )
		{
		}

        public override void GetContextMenuEntries(Mobile from, List<ContextMenuEntry> list)
		{
			base.GetContextMenuEntries( from, list );
			list.Add( new SitaEntry( from, this ) );
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
		
		public class SitaEntry : ContextMenuEntry
		{
			private Mobile m_Mobile;
			private Mobile m_Giver;
			
			public SitaEntry( Mobile from, Mobile giver ) : base( 6146, 3 )
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
					if ( ! mobile.HasGump( typeof( SitaGump ) ) )
					{
						mobile.SendGump( new SitaGump( mobile ));
						
					}
				}
			}
		}
		
		public override bool OnDragDrop( Mobile from, Item dropped )
		{
			Mobile m = from;
			PlayerMobile mobile = m as PlayerMobile;
			
			
			
			if( mobile != null )
			{
				if( dropped is RavanasHead)
				{
					dropped.Delete();
					mobile.AddToBackpack( new RavanasEarrings() );
                    //mobile.SendGump( new SitaGump( mobile ));
                    mobile.SendMessage("Thank you so much. Now I can return home.");
                    this.PrivateOverheadMessage(MessageType.Regular, 1153, false, "Thank you so much. Now I can return home.", mobile.NetState);
                    
                    return true;
				}
				
					else
					{
						mobile.SendMessage("I have no need for this item.");
					}
				}
			else
				{
					this.PrivateOverheadMessage( MessageType.Regular, 1153, false, "I have no need for this item.", mobile.NetState );
				}
		return false;
		}
	}
}