#region Script Header
/*                                     _____              
    _______ _______ ________ ___ _____ __  /______ _______
    __  __ `/_  __ `/__  __ `__ \_  _ \_  __/_  _ \_  ___/
    _  /_/ / / /_/ / _  / / / / //  __// /_  /  __// /__  
    _\__, /  \__,_/  /_/ /_/ /_/ \___/ \__/  \___/ \___/  
    /____/                                                
    
    Feel Free To Make Changes And Redistribute As You Like
*/
#endregion

using System;

using Server;
using Server.Engines.Quests;
using Server.Engines.Quests.Hag;
using Server.Gumps;
using Server.Items;
using Server.Mobiles;
using Server.Network;
using Server.Targeting;

namespace Server.Items
{
    [Flipable(0x14F5, 0x14F6)]
    public class ScoutSpyGlass : Item, IUsesRemaining // Uses Remaining
    {
        private int m_UsesRemaining;

        [CommandProperty(AccessLevel.GameMaster)]
        public int UsesRemaining
        {
            get { return m_UsesRemaining; }
            set { m_UsesRemaining = value; InvalidateProperties(); }
        }

        public bool ShowUsesRemaining { get { return true; } set { } }

        [Constructable]
        public ScoutSpyGlass()
            : base(0x14F5)
        {
            Name = "scout spyglass";
            Movable = true;
            UsesRemaining = Utility.Random(20, 35);
            ShowUsesRemaining = true;
            Weight = 3.0;
        }

        public override void OnDoubleClick(Mobile from)
        {
            if (IsChildOf(from.Backpack))
            {
                int hours, minutes;
                Clock.GetTime(Map, Location.X, Location.Y, out hours, out minutes);

                if (hours <= 19)
                {
                    #region Spawn Random Ambush

                    switch (Utility.Random(3))
                    {
                        case 0:
                            {
                                from.SendMessage("*As your gaze scans the horizon, you notice a group of brigands closing in*");

                                #region Define Mobiles To Spawn
                                // I've reserved spawn01-spawn09; however, you can add as many variables as you like as long as they are unique

                                Mobile spawn01 = new Brigand();
                                Mobile spawn02 = new Brigand();
                                Mobile spawn03 = new Brigand();
                                Mobile spawn04 = new Brigand();
                                Mobile spawn05 = new Brigand();
                                Mobile spawn06 = new Brigand();

                                #endregion

                                switch (Utility.Random(2))
                                {
                                    case 1:
                                        {
                                            /// <summary>
                                            /// Don't forget to plug in the spawn variables you add above below:
                                            /// </summary>
                                            spawn01.MoveToWorld(new Point3D(from.X + 10, from.Y, from.Z), from.Map);
                                            spawn02.MoveToWorld(new Point3D(from.X + 10, from.Y, from.Z), from.Map);
                                            spawn03.MoveToWorld(new Point3D(from.X + 15, from.Y, from.Z), from.Map);
                                            spawn04.MoveToWorld(new Point3D(from.X, from.Y + 10, from.Z), from.Map);
                                            spawn05.MoveToWorld(new Point3D(from.X, from.Y + 15, from.Z), from.Map);
                                            spawn06.MoveToWorld(new Point3D(from.X, from.Y + 15, from.Z), from.Map);
                                            break;
                                        }
                                    case 0:
                                        {
                                            switch (Utility.Random(4))
                                            {
                                                case 0: from.SendMessage("*As your gaze scans the horizon, all seems too quiet*"); break;
                                                case 1: from.SendMessage("*As your gaze scans the horizon, you hear breaking branches in the distance*"); break;

                                                // Sometimes a subspawn is the perfect ambiance/ detail to role-playing on a server
                                                case 2: from.SendMessage("*You notice the ground moving beneath your feet*");
                                                    Mobile subspawn01 = new Rat();
                                                    subspawn01.MoveToWorld(new Point3D(from.X, from.Y, from.Z), from.Map); break;

                                                case 3: from.SendMessage("*As your gaze scans the horizon, you feel confident all is well*"); break;
                                            }
                                            break;
                                        }
                                }
                                break;
                            }
                        case 1:
                            {
                                from.SendMessage("*As your gaze scans the horizon, you notice an Ettin patrol nearby*");

                                #region Define Mobiles To Spawn
                                // I've reserved spawn11-spawn19; however, you can add as many variables as you like as long as they are unique

                                Mobile spawn11 = new Ettin();
                                Mobile spawn12 = new Ettin();
                                Mobile spawn13 = new Ettin();
                                Mobile spawn14 = new Ettin();
                                Mobile spawn15 = new Ettin();
                                Mobile spawn16 = new Ettin();

                                #endregion

                                switch (Utility.Random(2))
                                {
                                    case 1:
                                        {
                                            /// <summary>
                                            /// Don't forget to plug in the spawn variables you add above below:
                                            /// </summary>
                                            spawn11.MoveToWorld(new Point3D(from.X + 10, from.Y, from.Z), from.Map);
                                            spawn12.MoveToWorld(new Point3D(from.X + 10, from.Y, from.Z), from.Map);
                                            spawn13.MoveToWorld(new Point3D(from.X + 15, from.Y, from.Z), from.Map);
                                            spawn14.MoveToWorld(new Point3D(from.X, from.Y + 10, from.Z), from.Map);
                                            spawn15.MoveToWorld(new Point3D(from.X, from.Y + 15, from.Z), from.Map);
                                            spawn16.MoveToWorld(new Point3D(from.X, from.Y + 15, from.Z), from.Map);
                                            break;
                                        }
                                    case 0:
                                        {
                                            switch (Utility.Random(2, 4))
                                            {
                                                case 0: from.SendMessage("*As your gaze scans the horizon, all seems too quiet*"); break;
                                                case 1: from.SendMessage("*As your gaze scans the horizon, you hear breaking branches in the distance*"); break;

                                                // Sometimes a subspawn is the perfect ambiance/ detail to role-playing on a server
                                                case 2: from.SendMessage("*You notice the ground moving beneath your feet*");
                                                    Mobile subspawn11 = new Rat();
                                                    subspawn11.MoveToWorld(new Point3D(from.X, from.Y, from.Z), from.Map); break;

                                                case 3: from.SendMessage("*As your gaze scans the horizon, you feel confident all is well*"); break;
                                            }
                                            break;
                                        }
                                }
                                break;
                            }
                        case 2: // This case makes the Scout Spyglass act like a normal Spyglass
                            {
                                if (hours < 5 || hours > 17)
                                {
                                    from.SendLocalizedMessage(1055040); // You gaze up into the glittering night sky.  With great care, you compose a chart of the most prominent star patterns.
                                }
                                else
                                {
                                    from.SendLocalizedMessage(1055039); // You gaze up into the sky, but it is not dark enough to see any stars.
                                }
                                break;
                            }
                    }

                    #endregion
                }
                else
                {
                    #region Spawn Random Ambush

                    switch (Utility.Random(3))
                    {
                        case 0:
                            {
                                from.SendMessage("*As your gaze scans the horizon, you notice a group of black bears closing in*");

                                #region Define Mobiles To Spawn
                                // I've reserved spawn21-spawn29; however, you can add as many variables as you like as long as they are unique

                                Mobile spawn21 = new BlackBear();
                                Mobile spawn22 = new BlackBear();
                                Mobile spawn23 = new BlackBear();
                                Mobile spawn24 = new BlackBear();
                                Mobile spawn25 = new BlackBear();
                                Mobile spawn26 = new BlackBear();

                                #endregion

                                switch (Utility.Random(2))
                                {
                                    case 1:
                                        {
                                            /// <summary>
                                            /// Don't forget to plug in the spawn variables you add above below:
                                            /// </summary>
                                            spawn21.MoveToWorld(new Point3D(from.X + 10, from.Y, from.Z), from.Map);
                                            spawn22.MoveToWorld(new Point3D(from.X + 15, from.Y, from.Z), from.Map);
                                            spawn23.MoveToWorld(new Point3D(from.X + 20, from.Y, from.Z), from.Map);
                                            spawn24.MoveToWorld(new Point3D(from.X, from.Y + 10, from.Z), from.Map);
                                            spawn25.MoveToWorld(new Point3D(from.X, from.Y + 15, from.Z), from.Map);
                                            spawn26.MoveToWorld(new Point3D(from.X, from.Y + 20, from.Z), from.Map);
                                            break;
                                        }
                                    case 0:
                                        {
                                            switch (Utility.Random(4))
                                            {
                                                case 0: from.SendMessage("*As your gaze scans the horizon, all seems too quiet*"); break;
                                                case 1: from.SendMessage("*As your gaze scans the horizon, you hear breaking branches in the distance*"); break;

                                                // Sometimes a subspawn is the perfect ambiance/ detail to role-playing on a server
                                                case 2: from.SendMessage("*You notice the ground moving beneath your feet*");
                                                    Mobile subspawn21 = new Rat();
                                                    subspawn21.MoveToWorld(new Point3D(from.X, from.Y, from.Z), from.Map); break;

                                                case 3: from.SendMessage("*As your gaze scans the horizon, you feel confident all is well*"); break;
                                            }
                                            break;
                                        }
                                }
                                break;
                            }
                        case 1:
                            {
                                from.SendMessage("*As your gaze scans the horizon, you notice an Fire Gargoyle patrol nearby*");

                                #region Define Mobiles To Spawn
                                // I've reserved spawn31-spawn39; however, you can add as many variables as you like as long as they are unique

                                Mobile spawn31 = new FireGargoyle();
                                Mobile spawn32 = new FireSteed();
                                Mobile spawn33 = new FireGargoyle();
                                Mobile spawn34 = new FireSteed();
                                Mobile spawn35 = new FireGargoyle();
                                Mobile spawn36 = new FireBeetle();

                                #endregion

                                switch (Utility.Random(2))
                                {
                                    case 1:
                                        {
                                            /// <summary>
                                            /// Don't forget to plug in the spawn variables you add above below:
                                            /// </summary>
                                            spawn31.MoveToWorld(new Point3D(from.X + 10, from.Y, from.Z), from.Map);
                                            spawn32.MoveToWorld(new Point3D(from.X + 15, from.Y, from.Z), from.Map);
                                            spawn33.MoveToWorld(new Point3D(from.X + 15, from.Y, from.Z), from.Map);
                                            spawn34.MoveToWorld(new Point3D(from.X, from.Y + 10, from.Z), from.Map);
                                            spawn35.MoveToWorld(new Point3D(from.X, from.Y + 10, from.Z), from.Map);
                                            spawn36.MoveToWorld(new Point3D(from.X, from.Y + 15, from.Z), from.Map);
                                            break;
                                        }
                                    case 0:
                                        {
                                            switch (Utility.Random(4))
                                            {
                                                case 0: from.SendMessage("*As your gaze scans the horizon, all seems too quiet*"); break;
                                                case 1: from.SendMessage("*As your gaze scans the horizon, you hear breaking branches in the distance*"); break;

                                                // Sometimes a subspawn is the perfect ambiance/ detail to role-playing on a server
                                                case 2: from.SendMessage("*You notice the ground moving beneath your feet*");
                                                    Mobile subspawn31 = new Rat();
                                                    subspawn31.MoveToWorld(new Point3D(from.X, from.Y, from.Z), from.Map); break;

                                                case 3: from.SendMessage("*As your gaze scans the horizon, you feel confident all is well*"); break;
                                            }
                                            break;
                                        }
                                }
                                break;
                            }
                        case 2: // This case makes the Scout Spyglass act like a normal Spyglass
                            {
                                if (hours < 5 || hours > 17)
                                {
                                    from.SendLocalizedMessage(1055040); // You gaze up into the glittering night sky.  With great care, you compose a chart of the most prominent star patterns.
                                }
                                else
                                {
                                    from.SendLocalizedMessage(1055039); // You gaze up into the sky, but it is not dark enough to see any stars.
                                }
                                break;
                            }
                    }

                    #endregion
                }

                --this.UsesRemaining;

                if (this.UsesRemaining == 0)
                {
                    this.Delete();
                }
            }
            else
            {
                from.SendLocalizedMessage(1042001); // That must be in your pack for you to use it.
            }
        }

        public override void GetProperties(ObjectPropertyList list)
        {
            base.GetProperties(list);

            list.Add(1060584, m_UsesRemaining.ToString()); // uses remaining: ~1_val~
        }

        public ScoutSpyGlass(Serial serial)
            : base(serial)
        {
        }

        public override void Serialize(GenericWriter writer)
        {
            base.Serialize(writer);

            writer.Write((int)0); // Current Version

            writer.Write((int)m_UsesRemaining);
        }

        public override void Deserialize(GenericReader reader)
        {
            base.Deserialize(reader);

            int version = reader.ReadInt();

            m_UsesRemaining = reader.ReadInt();
        }
    }
}