using System;
using Server;

namespace Server.Items
{
	public class iBaby : Item, IBaby
	{
		[Constructable]
		public iBaby() : base( 0x1AE6 )
		{
			Weight = 2.0;
			Hue = 0x21D;
			Name = "a baby";
			Light = LightType.Empty;
		}

		public override void OnDoubleClick( Mobile from )
		{
			if ( !IsChildOf( from.Backpack ) )
			{
				from.PlaySound( 0x8E );
			}
			else
			{
				from.PlaySound( 0x8E );

			}
		}

		public bool Diaper( Mobile from, Diaper Diaper )
		{
			if ( Deleted || !from.CanSee( this ) ) return false;
			
			from.AddToBackpack( new DirtyDiaper () );

			return true;
		}

		public iBaby( Serial serial ) : base( serial )
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
