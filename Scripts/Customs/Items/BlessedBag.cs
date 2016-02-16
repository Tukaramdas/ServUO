//Scripted By Starfox45634
using System; 
using Server; 
using Server.Items;

namespace Server.Items 
{ 
	public class BlessedBag : Bag 
	{ 
		[Constructable] 
		public BlessedBag() : this( 1 ) 
		{ 
		} 

		[Constructable] 
		public BlessedBag(int amount) 
		{ 
			Name = "A Magical Blessed Bag";
			Hue = 1195;
			LootType = LootType.Blessed;
		} 

		public BlessedBag( Serial serial ) : base( serial ) 
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
