//////////////////////////////////
//				                //
//				                //
//				                //
// Just testing gump settings   //
//				                //
//	                        	//
//				                //
//////////////////////////////////	

using System;
using Server;
using Server.Gumps;
using Server.Network;
using Server.Mobiles;

namespace Server.Items
{
    public class GumpTest1 : Item
    {
        [Constructable]
        public GumpTest1() : base(0xFF2)
        {
            Name = "Gump Test Book 1";
            Movable = true;
            Hue = 1925;
            LootType = LootType.Blessed;
        }

        public override void OnDoubleClick(Mobile from)
        {
           
            from.SendGump(new GumpTest1Gump());
           
        }
    
        public GumpTest1( Serial serial ) : base( serial )
            {
            }

        public override void Serialize( GenericWriter writer )
		    {
			base.Serialize( writer );
			writer.WriteEncodedInt( (int) 0 ); // version
		    }

		public override void Deserialize( GenericReader reader )
		    {
			base.Deserialize( reader );

			int version = reader.ReadEncodedInt();
		    }
	    }
    }
