//////////////////////////////////
//				                //
//				                //
//				                //
//    Created by Lord Talon	    //
//     www.uohelmsdeep.com	    //
//				                //
//		                        //
//		                        //
//////////////////////////////////	

/* DESCRIPTION: A book when opened displays the Original PlayerGuide gump.
 */

using System;
using Server;
using Server.Gumps;
using Server.Network;
using Server.Mobiles;

namespace Server.Items
{
    public class OriginalPlayerGuide : Item
    {
        [Constructable]
        public OriginalPlayerGuide() : base(0xFF2)
        {
            Name = "Original Beginner's Guides - Read me!";
            Movable = true;
            Hue = 1925;
            LootType = LootType.Blessed;
        }

        public override void OnDoubleClick(Mobile from)
        {
           // from.LaunchBrowser("http://in-uo.net/info/guides");
            //from.CloseGump(typeof(Original PlayerGuidegump));
            from.SendGump(new OriginalPlayerGuideGump());
        }
    
        public OriginalPlayerGuide( Serial serial ) : base( serial )
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
