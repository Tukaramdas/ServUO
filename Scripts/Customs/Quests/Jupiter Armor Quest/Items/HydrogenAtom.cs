using System;
using Server;

namespace Server.Items
{
	public class HydrogenAtom : Item
	{
		public override double DefaultWeight
		{
			get { return 0.1; }
		}

		[Constructable]
		public HydrogenAtom() : this( 1 )
		{
			Weight = 1.0;
                        Hue = 1152;
                        Name = "Hydrogen Atom";
		}

		[Constructable]
		public HydrogenAtom( int amount ) : base( 0xF26 )
		{
			
		}

		public HydrogenAtom( Serial serial ) : base( serial )
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