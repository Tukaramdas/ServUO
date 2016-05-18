using System;
using Server.Network;
using Server.Targeting;

namespace Server.Items
{
	public interface IBaby
	{
		bool Diaper( Mobile from, Diaper diaper );
	}

	public class Diaper : Item
	{
		[Constructable]
		public Diaper() : base( 0x1915 )
		{
			Weight = 1.0;
			Name = "a clean diaper";
		}

		public Diaper( Serial serial ) : base( serial )
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
			from.SendMessage("What baby should I use this on?");
			from.Target = new InternalTarget( this );

		}

		private class InternalTarget : Target
		{
			private Diaper m_Item;

			public InternalTarget( Diaper item ) : base( 1, false, TargetFlags.None )
			{
				m_Item = item;
			}

			protected override void OnTarget( Mobile from, object targeted )
			{
				if ( m_Item.Deleted ) return;

				/*if ( targeted is Item && !((Item)targeted).IsStandardLoot() )
				{
					from.SendMessage("Those are for babies");
				}
				else */if ( targeted is IBaby )
				{
					IBaby obj = (IBaby)targeted;

					if ( obj.Diaper( from, m_Item ) )
						from.PlaySound( 0x57 );
						m_Item.Delete();
				}
				else
				{
					from.SendMessage("Those are for babies");
				}
			}
		}
	}
}