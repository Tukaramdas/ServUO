using System;
using System.Collections;
using System.Collections.Generic;
using Server;
using Server.ContextMenus;
using Server.Gumps;
using Server.Items;
using Server.Network;
using Server.Targeting;


namespace Server.Mobiles
{
	public class InnMaid : BaseVendor
	{
		private List<SBInfo> m_SBInfos = new List<SBInfo>(); 
		protected override List<SBInfo> SBInfos{ get { return m_SBInfos; } } 

		public override void InitSBInfo()
		{
			m_SBInfos.Add( new SBBarkeeper() ); 
		}

		[Constructable]
		public InnMaid() : base( "The Maid" )
		{

			Body = 401; 
			Name = NameList.RandomName( "female" );


		}

		public override void InitOutfit()
		{
			base.InitOutfit();

			Item doublet = new Doublet();
			doublet.Hue = 24;
			AddItem( doublet );

			Item leatherskirt = new LeatherSkirt();
			leatherskirt.Hue = 24;
			AddItem( leatherskirt );

			Item booty = new FurBoots();
			booty.Hue = 24;
			AddItem( booty );

			AddItem( Utility.RandomBool() ? (Item)new Lantern() : (Item)new Candle() );
		}

		private class StableEntry : ContextMenuEntry
		{
			private InnMaid m_Maid;
			private Mobile m_From;

			public StableEntry( InnMaid Maid, Mobile from ) : base( 6126, 12 )
			{
				m_Maid = Maid;
				m_From = from;
			}

			public override void OnClick()
			{
				m_Maid.BeginStable( m_From );
			}
		}

		private class ClaimListGump : Gump
		{
			private InnMaid m_Maid;
			private Mobile m_From;
			private List<BaseBlue> m_List;

			public ClaimListGump( InnMaid Maid, Mobile from, List<BaseBlue> list ) : base( 50, 50 )
			{
				m_Maid = Maid;
				m_From = from;
				m_List = list;

				from.CloseGump( typeof( ClaimListGump ) );

				AddPage( 0 );

				AddBackground( 0, 0, 325, 50 + (list.Count * 20), 9250 );
				AddAlphaRegion( 5, 5, 315, 40 + (list.Count * 20) );

				AddHtml( 15, 15, 275, 20, "<BASEFONT COLOR=#FFFFFF>Select a pet to retrieve from the stables:</BASEFONT>", false, false );

				for ( int i = 0; i < list.Count; ++i )
				{
					BaseBlue pet = list[i];

					if ( pet == null || pet.Deleted )
						continue;

					AddButton( 15, 39 + (i * 20), 10006, 10006, i + 1, GumpButtonType.Reply, 0 );
					AddHtml( 32, 35 + (i * 20), 275, 18, String.Format( "<BASEFONT COLOR=#C0C0EE>{0}</BASEFONT>", pet.Name ), false, false );
				}
			}

			public override void OnResponse( NetState sender, RelayInfo info )
			{
				int index = info.ButtonID - 1;

				if ( index >= 0 && index < m_List.Count )
					m_Maid.EndClaimList( m_From, m_List[index] );
			}
		}

		private class ClaimAllEntry : ContextMenuEntry
		{
			private InnMaid m_Maid;
			private Mobile m_From;

			public ClaimAllEntry( InnMaid Maid, Mobile from ) : base( 6127, 12 )
			{
				m_Maid = Maid;
				m_From = from;
			}

			public override void OnClick()
			{
				m_Maid.Claim( m_From );
			}
		}

		public override void AddCustomContextEntries( Mobile from, List<ContextMenuEntry> list )
		{
			if ( from.Alive )
			{
				list.Add( new StableEntry( this, from ) );

				if ( from.Stabled.Count > 0 )
					list.Add( new ClaimAllEntry( this, from ) );
			}

			base.AddCustomContextEntries( from, list );
		}

		public static int GetMaxStabled( Mobile from )
		{

			int max;

			max = 10;

			return max;

		}

		private class StableTarget : Target
		{
			private InnMaid m_Maid;

			public StableTarget( InnMaid Maid ) : base( 12, false, TargetFlags.None )
			{
				m_Maid = Maid;
			}

			protected override void OnTarget( Mobile from, object targeted )
			{
				if ( targeted is BaseBlue )
					m_Maid.EndStable( from, (BaseBlue)targeted );
				else if ( targeted == from )
					m_Maid.SayTo( from, "Hah! This isn't a stable!" ); // HA HA HA! Sorry, I am not an inn.
				else
					m_Maid.SayTo( from, "That can't stay at our fine establishment!" ); // You can't stable that!
			}
		}

		private void CloseClaimList( Mobile from )
		{
			from.CloseGump( typeof( ClaimListGump ) );
		}

		public void BeginClaimList( Mobile from )
		{
			if ( Deleted || !from.CheckAlive() )
				return;

			List<BaseBlue> list = new List<BaseBlue>();

			for ( int i = 0; i < from.Stabled.Count; ++i )
			{
				BaseBlue pet = from.Stabled[i] as BaseBlue;

				if ( pet == null || pet.Deleted )
				{
					pet.IsStabled = false;
					from.Stabled.RemoveAt( i );
					--i;
					continue;
				}

				list.Add( pet );
			}

			if ( list.Count > 0 )
				from.SendGump( new ClaimListGump( this, from, list ) );
			else
				SayTo( from, "Sorry, that person isn't here now" ); // But I have no animals stabled with me at the moment!
		}

		public void EndClaimList( Mobile from, BaseBlue pet )
		{
			if ( pet == null || pet.Deleted || from.Map != this.Map || !from.Stabled.Contains( pet ) || !from.CheckAlive() )
				return;

			if ( !from.InRange( this, 14 ) )
			{
				SayTo( from, "Tell him/her to come closer" ); // That is too far away.
				return;
			}

			if ( CanClaim( from, pet ) )
			{
                DoClaim( from, pet );

				from.Stabled.Remove( pet );

				SayTo( from, "Here you got M'lord" ); // Here you go... and good day to you!
			}
			else
			{
				SayTo( from, "Your party seems to be too big at the moment" ); // ~1_NAME~ remained in the stables because you have too many followers.
			}
		}

		public void BeginStable( Mobile from )
		{
			if ( Deleted || !from.CheckAlive() )
				return;

			Container bank = from.FindBankNoCreate();

			if ( ( from.Backpack == null || from.Backpack.GetAmount( typeof( Gold ) ) < 500 ) && ( bank == null || bank.GetAmount( typeof( Gold ) ) < 500 ) )
			{
				SayTo( from, "But who will pay for his stay?" ); // Thou dost not have enough gold, not even in thy bank account.
			}
			else
			{
				/* I charge 30 gold per pet for a real week's stable time.
										 * I will withdraw it from thy bank account.
										 * Which animal wouldst thou like to stable here?
										 */
				SayTo( from, "We charge 500 gold per day for a room at our fine establishment, who wishes to stay here?");

				from.Target = new StableTarget( this );
			}
		}

		public void EndStable( Mobile from, BaseBlue pet )
		{
			if ( Deleted || !from.CheckAlive() )
				return;

			if ( !pet.Controlled )
			{
				SayTo( from, "That cannot stay here!" ); // You can't stable that!
			}
			else if ( pet.ControlMaster != from )
			{
				SayTo( from, "He doesn't follow your orders!" ); // You do not own that pet!
			}
			else if ( pet.IsDeadPet )
			{
				SayTo( from, "A ghost!!!!" ); // Living pets only, please.
			}
			else if ( pet.Summoned )
			{
				SayTo( from, 502673 ); // I can not stable summoned creatures.
			}
			#region Mondain's Legacy
			else if ( pet.Allured )
			{
				SayTo( from, 1048053 ); // You can't stable that!
			}
			#endregion
			else if ( (pet is PackLlama || pet is PackHorse || pet is Beetle) && (pet.Backpack != null && pet.Backpack.Items.Count > 0) )
			{
				SayTo( from, 1042563 ); // You need to unload your pet.
			}
			else if ( pet.Combatant != null && pet.InRange( pet.Combatant, 12 ) && pet.Map == pet.Combatant.Map )
			{
				SayTo( from, "That person is at war right now!" ); // I'm sorry.  Your pet seems to be busy.
			}
			else if ( from.Stabled.Count >= GetMaxStabled( from ) )
			{
				SayTo( from, "Sorry, our Inn is full!" ); // You have too many pets in the stables!
			}
			else
			{
				Container bank = from.FindBankNoCreate();

				if ( ( from.Backpack != null && from.Backpack.ConsumeTotal( typeof( Gold ), 500 ) ) || ( bank != null && bank.ConsumeTotal( typeof( Gold ), 500 ) ) )
				{
					pet.ControlTarget = null;
					pet.ControlOrder = OrderType.Stay;
					pet.Internalize();

					pet.SetControlMaster( null );
					pet.SummonMaster = null;

					pet.IsStabled = true;

					from.Stabled.Add( pet );

					SayTo( from, "Enjoy your stay!" ); // [AOS: Your pet has been stabled.] Very well, thy pet is stabled. Thou mayst recover it by saying 'claim' to me. In one real world week, I shall sell it off if it is not claimed!
				}
				else
				{
					SayTo( from, 502677 ); // But thou hast not the funds in thy bank account!
				}
			}
		}

        public void Claim( Mobile from )
        {
            Claim( from, null );
        }

		public void Claim( Mobile from, string petName )
		{
			if ( Deleted || !from.CheckAlive() )
				return;

			bool claimed = false;
			int stabled = 0;

			bool claimByName = ( petName != null );

			for ( int i = 0; i < from.Stabled.Count; ++i )
			{
				BaseBlue pet = from.Stabled[i] as BaseBlue;

				if ( pet == null || pet.Deleted )
				{
					pet.IsStabled = false;
					from.Stabled.RemoveAt( i );
					--i;
					continue;
				}

				++stabled;

				if ( claimByName && !Insensitive.Equals( pet.Name, petName ) )
					continue;

				if ( CanClaim( from, pet ) )
				{
                    DoClaim( from, pet );

					from.Stabled.RemoveAt( i );
					--i;

					claimed = true;
				}
				else
				{
					SayTo( from, 1049612, pet.Name ); // ~1_NAME~ remained in the stables because you have too many followers.
				}
			}

			if ( claimed )
				SayTo( from, 1042559 ); // Here you go... and good day to you!
			else if ( stabled == 0 )
				SayTo( from, "But, our Inn is empty at the moment!" ); // But I have no animals stabled with me at the moment!
			else if ( claimByName )
				BeginClaimList( from );
		}

        public bool CanClaim( Mobile from, BaseBlue pet )
        {
            return ((from.Followers + pet.ControlSlots) <= from.FollowersMax);
        }

        private void DoClaim( Mobile from, BaseBlue pet )
        {
            pet.SetControlMaster( from );

            if ( pet.Summoned )
                pet.SummonMaster = from;

            pet.ControlTarget = from;
            pet.ControlOrder = OrderType.Follow;

            pet.MoveToWorld( from.Location, from.Map );

            pet.IsStabled = false;

        }

		public override bool HandlesOnSpeech( Mobile from )
		{
			return true;
		}

		public override void OnSpeech( SpeechEventArgs e )
		{
			if ( !e.Handled && e.HasKeyword( 0x0008 ) ) // *stable*
			{
				e.Handled = true;

				CloseClaimList( e.Mobile );
				BeginStable( e.Mobile );
			}
			else if ( !e.Handled && e.HasKeyword( 0x0009 ) ) // *claim*
			{
				e.Handled = true;

				CloseClaimList( e.Mobile );

				int index = e.Speech.IndexOf( ' ' );

				if ( index != -1 )
					Claim( e.Mobile, e.Speech.Substring( index ).Trim() );
                else
                    Claim( e.Mobile );
			}
			else
			{
				base.OnSpeech( e );
			}
		}

		public InnMaid( Serial serial ) : base( serial )
		{
		}

		public override void Serialize( GenericWriter writer )
		{
			base.Serialize( writer );

			writer.Write( (int) 0 ); // version
		}

		public override void Deserialize( GenericReader reader )
		{
			base.Deserialize( reader );

			int version = reader.ReadInt();
		}
	}
}