namespace Server.Items
{
    [FlipableAttribute(0x2AC0, 0x2AC3)]
    public class DrinkingFountain : Item
	{
		[Constructable]
		public DrinkingFountain() : base( 0x2AC3 )
		{
			Weight = 25.0;
            Name = "Drinking fountain";
		}

		public DrinkingFountain( Serial serial ) : base( serial ) { }

		public override void Serialize( GenericWriter writer ) { base.Serialize( writer ); writer.Write( 0 ); }

		public override void Deserialize( GenericReader reader ) { base.Deserialize( reader ); int version = reader.ReadInt(); }
	}
}