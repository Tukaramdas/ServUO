using System;
using System.Collections;
using System.Collections.Generic;
using Server;
using Solaris.ItemStore;							//for connection to resource store data objects

namespace Server.Items
{
	//item derived from BaseResourceKey
	public class WoodKey : BaseStoreKey
	{
		public override List<StoreEntry> EntryStructure
		{
			get
			{
				List<StoreEntry> entry = base.EntryStructure;
				
				entry.Add( new ResourceEntry( typeof( Board ), new Type[]{ typeof( Log ) }, "Plain" ) );
				entry.Add( new ResourceEntry( typeof( Kindling ), "Kindling" ) );
				entry.Add( new ResourceEntry( typeof( Shaft ), "Shaft" ) );
				entry.Add( new ResourceEntry( typeof( Feather ), "Feather" ) );
				entry.Add( new ResourceEntry( typeof( Arrow ), "Arrow" ) );
				entry.Add( new ResourceEntry( typeof( Bolt ), "Bolt" ) );
				
				
				return entry;
			}
		}

		
		[Constructable]
		public WoodKey() : base( 88 )		//hue 88
		{
			ItemID = 0x1BD9;			//pile of wood
			Name = "Wood Storage";
		}
		
		//this loads properties specific to the store, like the gump label, and whether it's a dynamic storage device
		protected override ItemStore GenerateItemStore()
		{
			//load the basic store info
			ItemStore store = base.GenerateItemStore();

			//properties of this storage device
			store.Label = "Wood Storage";
			
			store.Dynamic = false;
			store.OfferDeeds = true;
			
			return store;
		}
		
		//serial constructor
		public WoodKey( Serial serial ) : base( serial )
		{
		}
		
		//events
		
		public override void Serialize( GenericWriter writer )
		{
			base.Serialize( writer );
			
			writer.Write( 0 );
		}
		
		public override void Deserialize( GenericReader reader )
		{
			base.Deserialize( reader );
			
			int version = reader.ReadInt();
		}
	}



}