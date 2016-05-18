//Scripted By Milva

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
	[CorpseName( "deaths reaper corpse" )]
	public class DeathsReaper : Mobile
	{
                public virtual bool IsInvulnerable{ get{ return true; } }
		[Constructable]
		public DeathsReaper ()
		{
			Name = "Deaths Reaper ";
            Title = "Quest Giver";
            Body = 400;
			CantWalk = true;
			Hue = 1102;
                                                Blessed = true;

	                    BoneLegs bl = new BoneLegs();
                        bl.Hue = 1107;
                        bl.Name = "Death Reaper Legs";
                        bl.LootType = LootType.Blessed;
                        AddItem( bl );

                        BoneChest bc = new BoneChest();
                        bc.Hue = 1107;
                        bc.Name = "Death Reaper Chest";
                        bc.LootType = LootType.Blessed;
                        AddItem( bc );

                        BoneArms ba = new BoneArms();
                        ba.Hue = 1107;
                        ba.Name = "Death Reaper Arms";
                        ba.LootType = LootType.Blessed;
                        AddItem( ba );

                        TribalMask tm = new TribalMask();
                        tm.Hue = 1107;
                        tm.Name = "Death Reaper Mask";
                        tm.LootType = LootType.Blessed;
                        AddItem( tm );

                     
          //             Item Scythe = new Item( 9914 ); 
          //             Scythe.Name = "Deaths Scythe ";
          //             Scythe.Hue = 1157;
          //              Scythe.Layer = Layer.OneHanded;
          //             Scythe.LootType = LootType.Blessed;
          //             AddItem( Scythe );

                      Container pack = new Backpack();
                       
           }

        public DeathsReaper(Serial serial)
            : base(serial)
		{
		}

		public override void GetContextMenuEntries( Mobile from,List<ContextMenuEntry>list) 
	        { 
	                base.GetContextMenuEntries( from, list ); 
        	        list.Add( new DeathsReaperEntry( from, this ) ); 
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

		public class DeathsReaperEntry : ContextMenuEntry

		{
			private Mobile m_Mobile;
			private Mobile m_Giver;
			
			public DeathsReaperEntry( Mobile from, Mobile giver ) : base( 6146, 3 )
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
                    if (!mobile.HasGump(typeof(DeathsReaperQuestGump)))
					{
                        mobile.SendGump(new DeathsReaperQuestGump(mobile));
						
					} 
				}
			}
		}

		public override bool OnDragDrop( Mobile from, Item dropped )
		{          		
         	        Mobile m = from;
			PlayerMobile mobile = m as PlayerMobile;
                        Account acct=(Account)from.Account;
                        bool DeathsScytheRecieved = Convert.ToBoolean(acct.GetTag("DeathsScytheRecieved"));

			if ( mobile != null)
			{
                if (dropped is DeathsScythe)
            
         		{
         			if(dropped.Amount!=1)
         			{
					this.PrivateOverheadMessage( MessageType.Regular, 1153, false, "please bring me that special deaths scythe!", mobile.NetState );
         				return false;
         			}
                    if (!DeathsScytheRecieved) //added account tag check
		                {
					dropped.Delete(); 
					mobile.AddToBackpack( new  GoreFireplaceAddonDeed() );
					mobile.SendMessage( "Thank you for your help!" );
                    acct.SetTag("BloodyDeathScythe", "true");

				
         		        }
				else //what to do if account has already been tagged
         			{
         				mobile.SendMessage("You are so kind to have taken the time to help me obtain my deaths scythe.");
         				mobile.AddToBackpack( new Gold( 400 ) );
         				dropped.Delete();
         			}
         		}
         		else
         		{
					this.PrivateOverheadMessage( MessageType.Regular, 1153, false, "Why on earth would I want to have that?", mobile.NetState );
     			}
			}
			return false;
		}
	}
}
