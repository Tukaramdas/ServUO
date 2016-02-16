using System;
using System.Collections;
using System.Collections.Generic;
using Server;
using Server.Items;
using Server.Targeting;
using Server.ContextMenus;
using Server.Gumps;
using Server.Misc;
using Server.Network;
using Server.Spells;
using Server.Mobiles;

namespace Server.Mobiles
{
	[CorpseName( "Acaras's Corpse" )]
	public class Acaras : BaseCreature
	{

		[Constructable]
		public Acaras() : base( AIType.AI_Mage, FightMode.Aggressor, 10, 1, 0.2, 0.4 )
		{
			Name = "Acaras";
                        Title = "the Mage";
			Body = 0x190;
			CantWalk = false;
			Hue = 0x83F8;

			SetStr( 150, 200 );
			SetDex( 100, 200 );
			SetInt( 175, 250 );

			SetHits( 100, 140 );

			SetDamage( 8, 14 );

			SetDamageType( ResistanceType.Physical, 100 );

			SetResistance( ResistanceType.Physical, 40 );
			SetResistance( ResistanceType.Fire, 30 );
			SetResistance( ResistanceType.Cold, 20 );
			SetResistance( ResistanceType.Poison, 20 );
			SetResistance( ResistanceType.Energy, 25 );

			SetSkill( SkillName.MagicResist, 85.0 );
			SetSkill( SkillName.Tactics, 70.0 );
			SetSkill( SkillName.Wrestling, 70.0 );
			SetSkill( SkillName.Anatomy, 50.0 );
			SetSkill( SkillName.Magery, 90.0 );
			SetSkill( SkillName.Meditation, 80.0 );
			SetSkill( SkillName.EvalInt, 90.0 );

			Fame = 1500;
			Karma = 0;

			VirtualArmor = 25;

			PackGold( 40, 85 );
			PackReg( 5 );
			PackReg( 5 );

			int amount = Utility.RandomMinMax( 1, 3 );

			switch ( Utility.Random( 8 ) )
			{
				case 0: PackItem( new Dagger() ); break;
				case 1: PackItem( new Shirt() ); break;
				case 2: PackGem( 2 ); break;
				case 3: PackItem( new SewingKit() ); break;
				case 4: PackItem( new LeatherGloves() ); break;
				case 5: PackItem( new AcarasRing() ); break;
				case 6: PackItem( new Lute() ); break;
				case 7: PackItem( new ScribesPen() ); break;
			}

			AddItem( new Server.Items.Boots() );
			AddItem( new Server.Items.LongPants( 12 ) );
			AddItem( new Server.Items.Shirt() );

			Utility.AssignRandomHair( this ); 
			
			
		}



		public Acaras( Serial serial ) : base( serial )
		{
		}

		public override void GetContextMenuEntries( Mobile from, List<ContextMenuEntry> list ) 
	        { 
	                base.GetContextMenuEntries( from, list ); 
        	        list.Add( new AcarasEntry( from, this ) ); 
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

		public class AcarasEntry : ContextMenuEntry
		{
			private Mobile m_Mobile;
			private Mobile m_Giver;
			
			public AcarasEntry( Mobile from, Mobile giver ) : base( 6146, 3 )
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
					if ( ! mobile.HasGump( typeof( AcarasGump ) ) )
					{
						mobile.SendGump( new AcarasGump( mobile ));
						
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
				if( dropped is Robe )
         		{
         			if(dropped.Amount!=1)
         			{
					this.PrivateOverheadMessage( MessageType.Regular, 1153, false, "There's not the right amount here!", mobile.NetState );
         				return false;
         			}

					dropped.Delete(); 
					mobile.AddToBackpack( new Gold( 100 ) );
         				mobile.AddToBackpack( new AcarasRing() );
         				mobile.SendGump( new AcarasFinishGump() );


				
					return true;
         		}
				else if ( dropped is AcarasRing)
				{
				this.PrivateOverheadMessage( MessageType.Regular, 1153, 1054071, mobile.NetState );
         			return false;
				}
         		else
         		{
					this.PrivateOverheadMessage( MessageType.Regular, 1153, false, "I don't need that. I need a new robe.", mobile.NetState );
     			}
			}
			return false;
		}
	}
}
