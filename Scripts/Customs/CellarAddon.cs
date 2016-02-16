using System;
using Server.Multis;
using Server.Network;
using Server.Gumps;
using Server.ContextMenus;
using System.Collections.Generic;
using Server.Items;

namespace Server.Items
{
    public class CellarAddon2 : BaseAddon, IChopable
    {
        public override BaseAddonDeed Deed { get { return m_Cellar; } }

        private Map n_Map;
        private BaseHouse m_House;
        private bool m_initialised;
        private CellarTeleporter3 m_topTeleporter;
        public CellarDeed2 m_Cellar;
        private int m_LandType;

        [Constructable]
        public CellarAddon2()
        {
            m_topTeleporter = new CellarTeleporter3();
            AddComponent(m_topTeleporter, 0, 0, 0);
        }

        public CellarAddon2(Serial serial)
            : base(serial)
        {
            this.m_initialised = true;
        }

        public override void OnMapChange()
        {
            base.OnMapChange();

            if (!this.m_initialised)
            {
                this.TryInitialise();
            }
        }

        public override void OnLocationChange(Point3D oldLoc)
        {
            base.OnLocationChange(oldLoc);

            if (!this.m_initialised)
            {
                this.TryInitialise();
            }
        }

        private void TryInitialise()
        {
            if (!this.m_initialised
                && this.Map != Map.Internal
                && this.Location != Point3D.Zero)
            {
                this.m_initialised = true;
                BaseHouse house = (BaseHouse.FindHouseAt((BaseAddon)this));
                m_House = house;
                n_Map = ((BaseAddon)this).Map;
                CellarDeed2 gt = (CellarDeed2)Deed;
                Point3D hsp = new Point3D(this.X, this.Y, this.Z);
                Sector s = n_Map.GetSector(hsp);
                int houseYOffset = this.Y - house.Y;
                int houseXOffset = this.X - house.X;
                int type = (int)gt.m_LandType;

                if (null != house.Area
                    && house.Area.Length > 0)
                {
                    //Find the minimum z value, so we can ensure it is all underground.
                    int minz = 150;
                    for (int i = 0; i < house.Area.Length; ++i)
                    {
                        Rectangle2D area = house.Area[i];
                        int width = area.Width;
                        int height = area.Height;
                        for (int rx = 0; rx < width; ++rx)
                        {
                            for (int ry = 0; ry < height; ++ry)
                            {
                                int vx = rx + area.X - houseXOffset;
                                int vy = ry + area.Y - houseYOffset;
                                minz = Math.Min(n_Map.GetAverageZ(vx, vy) - 40, minz);
                            }
                        }
                    }

                    minz = minz - this.Z;
                    //Place components
                    for (int i = 0; i < house.Area.Length; ++i)
                    {
                        Rectangle2D area = house.Area[i];
                        int width = area.Width;
                        int height = area.Height;
                        for (int rx = 0; rx < width; ++rx)
                        {
                            for (int ry = 0; ry < height; ++ry)
                            {
                                int vx = rx + area.X - houseXOffset;
                                int vy = ry + area.Y - houseYOffset;

                                AddComponent(new AddonComponent(type), vx, vy, minz);
                            }
                        }
                    }

                    this.m_topTeleporter.ZOffset = minz;
                    AddComponent(new CellarTeleporter4(-minz), 0, 0, minz);
                }
            }
        }

        public override void OnChop(Mobile from)
		{
            CellarDeed2 deed = new CellarDeed2();
			if ( from != null )
				from.AddToBackpack(deed);
            this.Delete();
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
        }
    }

    public class CellarDeed2 : BaseAddonDeed
    {
        public override BaseAddon Addon
        {
            get
            {
                CellarAddon2 cellarAddon = new CellarAddon2();
                cellarAddon.m_Cellar = this;
                return cellarAddon;
            }
        }

        public enum TypeOfLand
        {
            None = 0x000,
            Grass = 0x177D,
            Dirt = 0x31F4,
            Stone = 0x51a,
            Flagstone = 0x4ff,
            DStone = 0x521,
            Wood = 0x4b8
        }
        public TypeOfLand m_LandType;
        [CommandProperty(AccessLevel.GameMaster)]
        public TypeOfLand LandType
        {
            get { return m_LandType; }
            set { m_LandType = value; }
        }

        [Constructable]
        public CellarDeed2()
        {
            Name = "Cellar Deed";
        }

        public CellarDeed2(Serial serial)
            : base(serial)
        {
        }

        public override void OnDoubleClick(Mobile from)
        {
            if (m_LandType == TypeOfLand.None)
            {
                from.CloseGump(typeof(CGroundTypeGump));
                from.SendGump(new CGroundTypeGump(this)); 
                return;
            }
            else if (from.Z >= 15 || from.Z <= -15)
            {
                from.SendMessage("You must be on the first floor to add a cellar!");
                return;
            }
           
            base.OnDoubleClick(from);            
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
        }
    }

    public class CellarTeleporter3 : AddonComponent
    {
        public int ZOffset { get; set; }

        [Constructable]
        public CellarTeleporter3()
            : this(false)
        {
        }

        [Constructable]
        public CellarTeleporter3(bool creatures)
            : base(0xA97)
        {
            Movable = false;
            Visible = true;
        }

        public override void OnDoubleClick(Mobile from)
        {

            if (!from.InRange(this.GetWorldLocation(), 1))
            {
                from.LocalOverheadMessage(MessageType.Regular, 0x3B2, 1019045); // I can't reach that.
            }
            else
            {
                from.Z += ZOffset;
            }
        }

        public CellarTeleporter3(Serial serial)
            : base(serial)
        {
        }

        public override void Serialize(GenericWriter writer)
        {
            base.Serialize(writer);

            writer.Write((int)1); // version

            writer.Write(this.ZOffset);
        }

        public override void Deserialize(GenericReader reader)
        {
            base.Deserialize(reader);

            int version = reader.ReadInt();

            switch (version)
            {
                case 1:
                    this.ZOffset = reader.ReadInt();
                    break;
            }
        }
    }
    public class CellarTeleporter4 : AddonComponent
    {
        private int m_zOffset;

        [Constructable]
        public CellarTeleporter4(int zOffset)
            : this(zOffset, false)
        {
        }

        [Constructable]
        public CellarTeleporter4(int zOffset, bool creatures)
            : base(0x71F)
        {
            Movable = false;
            Visible = true;
            this.m_zOffset = zOffset;
        }

        public override bool OnMoveOver(Mobile m)
        {
            m.Z += m_zOffset;

            return false;
        }

        public CellarTeleporter4(Serial serial)
            : base(serial)
        {
        }

        public override void Serialize(GenericWriter writer)
        {
            base.Serialize(writer);
            writer.Write((int)1); // version

            writer.Write(this.m_zOffset);
        }

        public override void Deserialize(GenericReader reader)
        {
            base.Deserialize(reader);

            int version = reader.ReadInt();

            switch (version)
            {
                case 1:
                    this.m_zOffset = reader.ReadInt();
                    break;
            }
        }
    }
    public class CGroundTypeGump : Gump
    {
        public CellarDeed2 m_Cellar;

        public CGroundTypeGump(CellarDeed2 Cellar)
            : base(50, 50)
        {
            m_Cellar = Cellar;
            Closable = true;
            Disposable = true;
            Dragable = true;
            Resizable = false;

            AddPage(0);

            AddBackground(30, 29, 130, 190, 5120);
            AddImageTiled(35, 58, 130, 10, 5121);
            AddHtml(37, 34, 276, 19, @"<BASEFONT COLOR=WHITE>Cellar Ground Type</BASEFONT>", (bool)false, (bool)false);
            AddLabel(65, 65, 1149, @"Grass");
            AddImageTiledButton(45, 65, 11400, 11400, (int)Buttons.Grass, GumpButtonType.Reply, 0, 11400, 0, 10, 10, 0);
            AddLabel(65, 90, 1149, @"Dirt");
            AddImageTiledButton(45, 90, 11400, 11400, (int)Buttons.Dirt, GumpButtonType.Reply, 0, 11400, 0, 10, 10, 0);
            AddLabel(65, 115, 1149, @"Stone");
            AddImageTiledButton(45, 115, 11400, 11400, (int)Buttons.Stone, GumpButtonType.Reply, 0, 11400, 0, 10, 10, 0);
            AddLabel(65, 140, 1149, @"Dark Stone");
            AddImageTiledButton(45, 140, 11400, 11400, (int)Buttons.DStone, GumpButtonType.Reply, 0, 11400, 0, 10, 10, 0);
            AddLabel(65, 165, 1149, @"Flagstone");
            AddImageTiledButton(45, 165, 11400, 11400, (int)Buttons.Flagstone, GumpButtonType.Reply, 0, 11400, 0, 10, 10, 0);
            AddLabel(65, 190, 1149, @"Wood");
            AddImageTiledButton(45, 190, 11400, 11400, (int)Buttons.Wood, GumpButtonType.Reply, 0, 11400, 0, 10, 10, 0);
        }

        public enum Buttons
        {
            Grass,
            Dirt,
            Stone,
            DStone,
            Flagstone,
            Wood
        }

        public override void OnResponse(NetState state, RelayInfo info)
        {
            Mobile from = state.Mobile;

            if (from == null)
                return;

            switch (info.ButtonID) // Close
            {
                case (int)Buttons.Grass:
                    {
                        m_Cellar.m_LandType = Server.Items.CellarDeed2.TypeOfLand.Grass;
                        from.SendMessage("You have chosen Grass.");
                        return;
                    }
                    break;
                case (int)Buttons.Dirt:
                    {
                        m_Cellar.m_LandType = Server.Items.CellarDeed2.TypeOfLand.Dirt;
                        from.SendMessage("You have chosen Dirt.");
                        return;
                    }
                case (int)Buttons.Stone:
                    {
                        m_Cellar.m_LandType = Server.Items.CellarDeed2.TypeOfLand.Stone;
                        from.SendMessage("You have chosen Stone Pavers.");
                        return;
                    }
                    break;
                case (int)Buttons.DStone:
                    {
                        m_Cellar.m_LandType = Server.Items.CellarDeed2.TypeOfLand.DStone;
                        from.SendMessage("You have chosen Stone Pavers.");
                        return;
                    }
                    break;
                case (int)Buttons.Flagstone:
                    {
                        m_Cellar.m_LandType = Server.Items.CellarDeed2.TypeOfLand.Flagstone;
                        from.SendMessage("You have chosen Flagstone.");
                        return;
                    }
                    break;
                case (int)Buttons.Wood:
                    {
                        m_Cellar.m_LandType = Server.Items.CellarDeed2.TypeOfLand.Wood;
                        from.SendMessage("You have chosen Wood.");
                        return;
                    }
                default:
                    return; //CLOSE
            }
        }
    }
}
