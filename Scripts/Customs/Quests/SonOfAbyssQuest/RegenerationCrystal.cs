/////////// Scripted By TALON NYTE ///////////

using System;
using Server;

namespace Server.Items
{
	public class RegenerationCrystal : Item
	{
		public override double DefaultWeight
		{
			get { return 0.1; }
		}

		[Constructable]
		public RegenerationCrystal() : this( 1 )
		{
		}

		[Constructable]
		public RegenerationCrystal( int amount ) : base( 0xF10 )
		{
                        Name = "RegenerationCrystal" ;
			Stackable = true;
			Amount = amount;
		}

		public RegenerationCrystal( Serial serial ) : base( serial )
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