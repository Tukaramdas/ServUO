using System;
using Server.Network;
using Server.Targeting;

namespace Server.Items
{
	public class MagicHammer : Item
	{
		[Constructable]
		public MagicHammer() : base( 0x0FB4 )
		{
			Name = "a Magic Hammer";
            Hue = 1195;
			Weight = 1.0;
		}

		public MagicHammer( Serial serial ) : base( serial )
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

		public override void OnDoubleClick( Mobile from )
		{
			from.SendMessage( "What should I use these Magic Hammer on?"); 

			from.Target = new InternalTarget( this );
		}

		private class InternalTarget : Target
		{
			private MagicHammer m_Item;

			public InternalTarget( MagicHammer item ) : base( 1, false, TargetFlags.None )
			{
				m_Item = item;
			}

			protected override void OnTarget( Mobile from, object targeted )
			{
			
				if ( targeted is crushingtarget )
				{
					from.Animate( 12, 5, 1, true, false, 0 );
					from.PlaySound( 0x42 );	
					Item item = (Item)targeted;
					item.ItemID = 0x13A7;
					item.Hue = 2315;
					//item.FixedParticles( 0x376A, 9, 32, 0x13AF, EffectLayer.Waist );
					Effects.SendLocationParticles( EffectItem.Create( item.Location, item.Map, EffectItem.DefaultDuration ), 0x3728, 9, 32, 0x13AF );
					
				}
			}
		}
	}
}