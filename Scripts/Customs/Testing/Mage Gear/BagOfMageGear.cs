using System;
using Server;
using Server.Items;

namespace Server.Items
{
	public class BagOfMageGear : Bag
	{

		[Constructable]
		public BagOfMageGear()
		{
            RewardBelt rb = new RewardBelt();
            //rb.Identified = true;
            DropItem(rb);
            RewardBoots ra = new RewardBoots();
            //ra.Identified = true;
            DropItem(ra);
            RewardGlasses rg = new RewardGlasses();
            rg.Identified = true;
            DropItem(rg);
            RewardSash rs = new RewardSash();
            //rs.Identified = true;
            DropItem(rs);
            RewardShirt rt = new RewardShirt();
            //rt.Identified = true;
            DropItem(rt);
            
		}

        public BagOfMageGear(Serial serial)
            : base(serial)
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