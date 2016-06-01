using System;
using Server.Engines.Craft;
using Server.Mobiles;
using Server.Targeting;

namespace Server.Items
{
    public class LobsterTrap : Item
    {
        public LobsterTrap() : base( 0x44D0 )
        {
            this.Weight = 1.0;
        }

        public override void OnDoubleClick(Mobile from)
        {
            if (this.IsChildOf(from.Backpack))
            {
				from.Target = new TrapTarget( from, this );
				//TODO: Find localiztion for this.
            }
            else
            {
                from.SendLocalizedMessage(1042001); // That must be in your pack for you to use it.
            }
        }
        
        private class TrapTarget : Target
        {
            private readonly Mobile m_Fisher;
            private readonly Item m_Trap;
            
            public TrapTarget (Mobile fisher, Item trap ) : base( 6, true, TargetFlags.None )
            {
                this.m_Fisher = fisher;
                this.m_Trap = trap;
            }

            protected override void OnTarget( Mobile from, object target )
            {
            }
        }

        public LobsterTrap(Serial serial) : base(serial)
        {
        }

        public override void Serialize(GenericWriter writer)
        {
            base.Serialize(writer);

            writer.Write((int)0); // version
        }

        public override void Deserialize(GenericReader reader)
        {
            base.Deserialize(reader);

            int version = reader.ReadInt();

            switch ( version )
            {
                case 0:
                {
                        break;
                }
            }
        }
    }
}