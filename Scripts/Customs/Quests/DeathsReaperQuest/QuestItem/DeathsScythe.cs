//Created By Milva

using System;
using Server;

namespace Server.Items
{	


    public class  DeathsScythe : Item
                               
	             {
		[Constructable]
		public DeathsScythe  () : base( 0x26BA)
		{                
			
                              Weight = 3;
                             Name = "Deaths Scythe";
                             Hue = 1157;
                            ItemID = 9914;   
                                                
		}

		public DeathsScythe  ( Serial serial ) : base(serial)
		{
		}

		public override void Serialize( GenericWriter writer )
		{
			base.Serialize( writer );

			writer.Write( (int)0 );
		}

		public override void Deserialize( GenericReader reader )
		{
			base.Deserialize( reader );

			int version = reader.ReadInt();
		}
	}
}