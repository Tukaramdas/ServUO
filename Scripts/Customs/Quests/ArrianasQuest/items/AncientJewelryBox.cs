using System;
using Server;
using Server.Gumps;
using Server.Network;
using System.Collections;
using Server.Multis;
using Server.Mobiles;


namespace Server.Items
{

	public class AncientJewelryBox : Item
	{
		[Constructable]
		public AncientJewelryBox() : this( null )
		{
		}

		[Constructable]
		public AncientJewelryBox ( string name ) : base ( 0x9A8 )
		{
			Name = "Ancient Jewelry Box";
			LootType = LootType.Blessed;
			Hue = 1288;
		}

		public AncientJewelryBox ( Serial serial ) : base ( serial )
		{
		}


        public override void OnDoubleClick(Mobile m)
        {
            Item a = m.Backpack.FindItemByType(typeof(ArrianasDiamond));
            if (a != null)
            {
                Item b = m.Backpack.FindItemByType(typeof(ArrianasClips));
                if (b != null)
                {
                    Item c = m.Backpack.FindItemByType(typeof(ArrianasHoops));
                    if (c != null)
                    {
                        Item d = m.Backpack.FindItemByType(typeof(AncientJewelryBox));
                        if (d != null)
                        {
                            m.AddToBackpack(new DiamondHoopEarrings());
                            a.Delete();
                            b.Delete();
                            c.Delete();
                            d.Delete();
                            Item e = m.Backpack.FindItemByType(typeof(GrandpaTamsJournal));
                            if (e != null)
                            {
                                e.Delete();
                            }
                            Item f = m.Backpack.FindItemByType(typeof(UncleJohnsBook));
                            if (f != null)
                            {
                                f.Delete();
                            }
                            m.SendMessage("You Combine the knowledge of Arriana's ancestry into a Heirloom");
                            this.Delete();
                        }
                        else
                        {
                            m.SendMessage("You are missing something...");
                        }
                    }
                }
            }
        }

        public override void Serialize ( GenericWriter writer)
		{
			base.Serialize ( writer );

			writer.Write ( (int) 0);
		}

		public override void Deserialize( GenericReader reader )
		{
			base.Deserialize ( reader );

			int version = reader.ReadInt();
		}
	}
}