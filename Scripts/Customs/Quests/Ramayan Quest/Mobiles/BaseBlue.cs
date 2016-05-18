/*
 * 
 * * This script is the work originally released by deides on RunUO 3SEP11. 
 * runuo.com/community/threads/need-new-players-add-them-with-my-custom-blues-2-1-svn.488880/
 * I did some edits to his 'spawnhelper.cs to make my 'monkey' army.
 * You will need this BaseBlue.cs file for the MonkeyArmy.cs to work. If you are already using that
 * script package simply delete one of the BaseBlue.cs scripts, it does not matter which one. I did no edits on this script.
 * I take that back - on line 40 I had to remark out a reference to "townsperson". Don't know what it is for but it gave an error.
 * Tukaram 16MAY2016
 * 
 * */



using System; 
using System.Collections; 
using Server;
using Server.Misc; 
using Server.Items; 
using Server.Mobiles;
using Server.Gumps;
using Server.Custom;
using Server.Targeting;


namespace Server.Mobiles 
{ 
	public class BaseBlue : BaseCreature 
	{ 


		public BaseBlue(AIType ai, FightMode fm, int PR, int FR, double AS, double PS) : base( ai, fm, PR, FR, AS, PS )
		{
			SpeechHue = Utility.RandomDyedHue(); 
			Hue = Utility.RandomSkinHue();
//			RangePerception = BaseCreature.DefaultRangePerception;
		}

		public override bool IsEnemy( Mobile m )
		{
            		if ( m is BaseBlue || m is BaseVendor || m is PlayerVendor || m is TownCrier ) //|| m is Townsperson )

				return false;

			if ( m is PlayerMobile && !m.Criminal )

				return false;

			if ( m is BaseCreature )
			{
				BaseCreature c = (BaseCreature)m;
				
				if( c.Controlled || c.Allured || c.Karma >= 0 )

					return false;

				if( c.FightMode == FightMode.Aggressor || c.FightMode == FightMode.None )

					return true;
			}	

			return true;
		}

		public virtual bool HealsYoungPlayers{ get{ return true; } }

		public virtual bool CheckResurrect( Mobile m )
		{
			return true;
		}

		public DateTime m_NextResurrect;
		public static TimeSpan ResurrectDelay = TimeSpan.FromSeconds( 20.0 );

		public virtual void OfferResurrection( Mobile m )
		{
			Direction = GetDirectionTo( m );
			Say("An Corp");

			m.PlaySound(0x1F2);
			m.FixedEffect( 0x376A, 10, 16 );

			m.CloseGump( typeof( ResurrectGump ) );
			m.SendGump( new ResurrectGump( m, ResurrectMessage.Healer ) );
		}

		public virtual void OfferHeal( PlayerMobile m )
		{
			Direction = GetDirectionTo( m );

	//		if ( m.CheckYoungHealTime() )
			if ( DateTime.Now >= m_NextResurrect )
			{
				Say("Here's some help"); // You look like you need some healing my child.
				Say("In Vas Mani");

				m.PlaySound( 0x1F2 );
				m.FixedEffect( 0x376A, 9, 32 );

				m.Hits = (m.Hits + 50);
				m_NextResurrect = DateTime.Now + ResurrectDelay;
			}
			else
			{
				Say("You should be good"); // I can do no more for you at this time.
			}
		}

		public override void OnMovement( Mobile m, Point3D oldLocation )
		{
			if ( !m.Frozen && DateTime.Now >= m_NextResurrect && InRange( m, 4 ) && !InRange( oldLocation, 4 ) && InLOS( m ) )
			{
				if ( !m.Alive )
				{
					m_NextResurrect = DateTime.Now + ResurrectDelay;

					if ( m.Map == null || !m.Map.CanFit( m.Location, 16, false, false ) )
					{
						m.SendLocalizedMessage( 502391 ); // Thou can not be resurrected there!
					}
					else if ( CheckResurrect( m ) )
					{
						OfferResurrection( m );
					}
				}
				else if ( this.HealsYoungPlayers && m.Hits < m.HitsMax && m is PlayerMobile || m is BaseBlue )
				{
					OfferHeal( (PlayerMobile) m );
				}
			}
		}



		public override void OnThink()
		{
			base.OnThink();
			
			
			// Chug pots
			if ( this.Poisoned )
			{
				GreaterCurePotion m_CPot = (GreaterCurePotion)this.Backpack.FindItemByType( typeof ( GreaterCurePotion ) );
				if ( m_CPot != null )
					m_CPot.Drink( this );
			}

			if ( this.Hits <= (this.HitsMax * .7) ) // Will try to use heal pots if he's at or below 70% health
			{
				GreaterHealPotion m_HPot = (GreaterHealPotion)this.Backpack.FindItemByType( typeof ( GreaterHealPotion ) );
				if ( m_HPot != null )
					m_HPot.Drink( this );
			}
			
			if ( this.Stam <= (this.StamMax * .25) ) // Will use a refresh pot if he's at or below 25% stam
			{
				TotalRefreshPotion m_RPot = (TotalRefreshPotion)this.Backpack.FindItemByType( typeof ( TotalRefreshPotion) );
				if ( m_RPot != null )
					m_RPot.Drink( this );
			}
			
		}



		public BaseBlue( Serial serial ) : base( serial ) 
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