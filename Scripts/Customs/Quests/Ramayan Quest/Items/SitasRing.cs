//=================================================
//This script was created by Gizmo's Uo Quest Maker
//This script was created on 5/15/2016 09:07:46
//=================================================

using System;
using Server;

namespace Server.Items
{
	public class SitasRing : SilverRing
	{

		[Constructable]
		public SitasRing()
		{
			Name = "Sita's Ring";
            this.Movable = false;
        }

		public SitasRing( Serial serial ) : base( serial )
		{
		}
        public override void OnDoubleClick(Mobile from)
        {
            base.OnDoubleClick(from); 
          
            // if (IsChildOf(from.Backpack) && from.InRange(new Point3D(498, 2012, 2), Map.Trammel, 2))
            // if (IsChildOf(from.Backpack) && from (new Point3D(498, 2012, 2), Map.Trammel))
            // I was trying to make the ring only work from a certian location. Gave up and made it spawn where I wanted it to be used. :) 

                        if (from != null) 
            {
                from.MoveToWorld(new Point3D(5259, 1840, 0), Map.Trammel);   
                this.Delete(); 
            }
        }
        public override void Serialize( GenericWriter writer )
		{
			base.Serialize( writer );

			writer.Write( (int) 0 );
		}

		public override void Deserialize(GenericReader reader)
		{
			base.Deserialize( reader );

			int version = reader.ReadInt();
		}

	}
}
