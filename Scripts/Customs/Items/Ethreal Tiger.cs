using System; 
using Server.Mobiles; 

namespace Server.Items 
{ 
	public class EtherealTiger : EtherealMount 
	{ 
		[Constructable] 
		public EtherealTiger() : base( 16071, 0x9844 ) 
		{ 
			Name = "Ehereal Tiger";
			ItemID = 9844;
			MountedID = 16071;
			RegularID = 0x9844;
			LootType = LootType.Blessed;
		} 

		public EtherealTiger( Serial serial ) : base( serial ) 
		{ 
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

			if ( Name != "Ethereal Tiger" )
				Name = "Ethereal Tiger";
		} 
	}
}

