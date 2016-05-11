using System;

namespace Server.Items
{
    public class DragonLamp : BaseLight
    {
        [Constructable]
        public DragonLamp()
            : base(0x49C2)
        {
            this.Movable = false;
            this.Duration = TimeSpan.Zero; // Never burnt out
            this.Burning = false;
            this.Light = LightType.Circle300;
            this.Weight = 5.0;
        }

        public DragonLamp(Serial serial)
            : base(serial)
        {
        }

        public override int LitItemID
        {
            get
            {
                return 0x49C1;
            }
        }
        public override int UnlitItemID
        {
            get
            {
                return 0x49C2;
            }
        }
        public override void Serialize(GenericWriter writer)
        {
            base.Serialize(writer);
            writer.Write((int)0);
        }

        public override void Deserialize(GenericReader reader)
        {
            base.Deserialize(reader);
            int version = reader.ReadInt();
        }
    }
}