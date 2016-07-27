using System;
using Server.Gumps;
using Server.Targeting;
using Server.Network; // Added References
using Server.Mobiles; // Added

namespace Server.Spells.Eighth
{
    public class ResurrectionSpell : MagerySpell
    {
        private static readonly SpellInfo m_Info = new SpellInfo(
            "Resurrection", "An Corp",
            245,
            9062,
            Reagent.Bloodmoss,
            Reagent.Garlic,
            Reagent.Ginseng);
        public ResurrectionSpell(Mobile caster, Item scroll)
            : base(caster, scroll, m_Info)
        {
        }

        public override SpellCircle Circle
        {
            get
            {
                return SpellCircle.Eighth;
            }
        }
        public override bool CheckCast()
        {
            if (Engines.ConPVP.DuelContext.CheckSuddenDeath(this.Caster))
            {
                this.Caster.SendMessage(0x22, "You cannot cast this spell when in sudden death.");
                return false;
            }

            return base.CheckCast();
        }

        public override void OnCast()
        {
            this.Caster.Target = new InternalTarget(this);
        }

        public void Target(Mobile m)
        {
            if (!this.Caster.CanSee(m))
            {
                this.Caster.SendLocalizedMessage(500237); // Target can not be seen.
            }
            else if (m == this.Caster)
            {
                this.Caster.SendLocalizedMessage(501039); // Thou can not resurrect thyself.
            }
            else if (!this.Caster.Alive)
            {
                this.Caster.SendLocalizedMessage(501040); // The resurrecter must be alive.
            }/* REMOVED CHECK
            else if (m.Alive)
            {
                this.Caster.SendLocalizedMessage(501041); // Target is not dead.
            }*/
            else if (!this.Caster.InRange(m, 1))
            {
                this.Caster.SendLocalizedMessage(501042); // Target is not close enough.
            }/* REMOVED CHECK
            else if (!m.Player)
            {
                this.Caster.SendLocalizedMessage(501043); // Target is not a being.
            }*/
            else if (m.Map == null || !m.Map.CanFit(m.Location, 16, false, false))
            {
                this.Caster.SendLocalizedMessage(501042); // Target can not be resurrected at that location.
                m.SendLocalizedMessage(502391); // Thou can not be resurrected there!
            }
            else if (m.Region != null && m.Region.IsPartOf("Khaldun"))
            {
                this.Caster.SendLocalizedMessage(1010395); // The veil of death in this area is too strong and resists thy efforts to restore life.
            }
			else if ( m is PlayerMobile && m.Alive ) // Added check, check if PlayerMobile AND Alive instead of each
			{
				Caster.SendLocalizedMessage( 501041 ); // Target is not dead.
			}
			else if ( m is PlayerMobile && CheckBSequence( m, true ) ) // Added Check for PlayerMobile
            {
                SpellHelper.Turn(this.Caster, m);

                m.PlaySound(0x214);
                m.FixedEffect(0x376A, 10, 16);

                m.CloseGump(typeof(ResurrectGump));
                m.SendGump(new ResurrectGump(m, this.Caster));
            }
            else if ( m is BaseCreature && CheckBSequence( m, true ) ) // Added Check for BaseCreature, if they ARE, send this.
			{
				BaseCreature pet = (BaseCreature)m;
				Mobile master = pet.GetMaster();
                SpellHelper.Turn( Caster, m );
 
                m.PlaySound( 0x214 );
                m.FixedEffect( 0x376A, 10, 16 );
 
				if( master != null ) // Added safety check to avoid crashes with ghost pets without owners, yes they're supposed to disappear before this would be possible, but this would make it safe. I haven't checked this on my own server, remove the IF statement, not the bit inside if it crashes your server.
				{
					master.CloseGump(typeof(PetResurrectGump));
					master.SendGump(new PetResurrectGump(master, pet));
				}
            }

            this.FinishSequence();
        }

        private class InternalTarget : Target
        {
            private readonly ResurrectionSpell m_Owner;
            public InternalTarget(ResurrectionSpell owner)
                : base(1, false, TargetFlags.Beneficial)
            {
                this.m_Owner = owner;
            }

            protected override void OnTarget(Mobile from, object o)
            {
                if (o is Mobile)
                {
                    this.m_Owner.Target((Mobile)o);
                }
            }

            protected override void OnTargetFinish(Mobile from)
            {
                this.m_Owner.FinishSequence();
            }
        }
    }
}