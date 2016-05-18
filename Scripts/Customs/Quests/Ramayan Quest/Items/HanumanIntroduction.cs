using System;
using Server.Network;
using Server.Prompts;
using Server.Items;

namespace Server.Items
{
	public class HanumanIntroduction : Item
	{
		[Constructable]
		public HanumanIntroduction() : base( 0x14F0 )
		{
			base.Weight = 1.0;
			base.Name = "Letter of Introduction from Hanuman (Decays in 6 Hrs)";  //Change the name if you do not want it to self delete
            new InternalTimer(this).Start();  //Remark out this line if you do not want it to self delete
            Hue = 84;
		}
        //Begin timer 
		public HanumanIntroduction( Serial serial ) : base( serial )
		{
		}
        private class InternalTimer : Timer         
        {
            private Item m_Item;
            public InternalTimer(Item item) : base(TimeSpan.FromSeconds(21600.0))
            {
                m_Item = item;
                Priority = TimerPriority.TwoFiftyMS;
            }
            protected override void OnTick()
            {
                m_Item.Delete();
            }
        }
        //End timer.  Remark out this whole section to remove timer.
        public override void Serialize( GenericWriter writer )
		{
			base.Serialize( writer );
            new InternalTimer(this).Start();   //Remark out this line if you do not want it to self delete
            writer.Write( (int) 0 ); // version
		}

		public override void Deserialize( GenericReader reader )
		{
			base.Deserialize( reader );

			int version = reader.ReadInt();
		}

		public override void OnDoubleClick( Mobile m )
		{
			m.SendMessage("Letter of Introduction from Hanuman (Decays in 6 Hrs)");
		}
	}
}


