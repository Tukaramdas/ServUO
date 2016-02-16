using System;
using System.Collections;
using System.Collections.Generic;
using Server.Mobiles;
using Server.Multis;

namespace Server.Items
{
    public class BoneContainer : BaseContainer, ITelekinesisable, IDyable
    {
        private bool is_dyable = false;  // Allow Dyable Bones

        [CommandProperty(AccessLevel.GameMaster)]
        public bool Dyable
        {
            get { return is_dyable; }
            set { is_dyable = value; }
        }

        [Constructable]
        public BoneContainer(bool can_dye, bool can_move, bool do_lift)
            : base(0x0ECA + Utility.Random(9))
        {
            is_dyable = can_dye;
            Movable = can_move;
            LiftOverride = do_lift;
            Weight = 5.0;
        }

        [Constructable]
        public BoneContainer(bool can_dye, bool can_move)
            : this(can_dye, can_move, false)
        {
        }

        [Constructable]
        public BoneContainer()
            : this(false, true, false)
        {
        }

        public override int DefaultGumpID { get { return 0x9; } }  //Corpse Gump

        public override void AddNameProperty(ObjectPropertyList list)
        {
            // Generic Name Override. Keep Name Classic.
            string name = this.Name;
            if (name == null)
                list.Add(LabelNumber);
            else
                list.Add(name);
        }

        public override void GetProperties(ObjectPropertyList list)
        {
            // Properties List Diplay Classic Data.
            AddNameProperty(list);
            list.Add(1050044, "{0}\t{1}", TotalItems, TotalWeight); // ~1_COUNT~ items, ~2_WEIGHT~ stones
        }

        public bool Dye(Mobile from, DyeTub sender)
        {
            if (Deleted || !is_dyable)
                return false;  //  Fail for !Dyable and Delete
            Hue = sender.DyedHue;
            return true;
        }

        public virtual void OnTelekinesis(Mobile from)
        {
            // We can Tele the Normal Bones as Well.
            Effects.SendLocationParticles(EffectItem.Create(Location, Map, EffectItem.DefaultDuration), 0x376A, 9, 32, 5022);
            Effects.PlaySound(Location, Map, 0x1F5);
        }

        public BoneContainer(Serial serial)
            : base(serial)
        {
        }

        public override void Serialize(GenericWriter writer)
        {
            base.Serialize(writer);
            writer.Write((int)1);
        }

        public override void Deserialize(GenericReader reader)
        {
            base.Deserialize(reader);
            int version = reader.ReadInt();

        }
    }


    public class FillableBoneContainer : FillableContainer, IDyable
    {
        public override bool IsLockable { get { return false; } }
        public override bool IsTrapable { get { return false; } }
        /*  Would be nice to trap these fake corpses, but Respawn() is not 
            overridable, and IsTrapable makes traps randomly.  If we set
            Respawn() in fillable containers to virtual we can over ride it here
            and make the traps turn on and off with a boolean. */

        private bool is_dyable = false;   // Allow Dyable Bones

        [CommandProperty(AccessLevel.GameMaster)]
        public bool Dyable
        {
            get { return is_dyable; }
            set { is_dyable = value; }
        }

        [Constructable]
        public FillableBoneContainer(bool can_dye)
            : base(0x0ECA + Utility.Random(9))
        {
            is_dyable = can_dye;
            Weight = 5.0;
        }

        [Constructable]
        public FillableBoneContainer()
            : this(false)
        {
        }

        public override int DefaultGumpID { get { return 0x9; } }

        public override void AcquireContent()
        {
            if (m_Content != null)
                return;

            m_Content = FillableContent.FighterGuild;  // Fighter Imitation Corpse.

            if (m_Content != null)
                Respawn();
        }

        public bool Dye(Mobile from, DyeTub sender)
        {
            if (Deleted || !is_dyable)
                return false;
            Hue = sender.DyedHue;
            return true;
        }

        public override void AddNameProperty(ObjectPropertyList list)
        {
            string name = this.Name;
            if (name == null)
                list.Add(LabelNumber);
            else
                list.Add(name);
        }

        public override void GetProperties(ObjectPropertyList list)
        {
            AddNameProperty(list);
            list.Add(1050044, "{0}\t{1}", TotalItems, TotalWeight); // ~1_COUNT~ items, ~2_WEIGHT~ stones
        }

        public FillableBoneContainer(Serial serial)
            : base(serial)
        {
        }

        public override void Serialize(GenericWriter writer)
        {
            base.Serialize(writer);
            writer.Write((int)1);
        }

        public override void Deserialize(GenericReader reader)
        {
            base.Deserialize(reader);
            int version = reader.ReadInt();

        }
    }
}