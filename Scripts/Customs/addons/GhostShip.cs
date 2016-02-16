/////////////////////////////////////////////////
//                                             //
// Automatically generated by the              //
// AddonGenerator script by Arya               //
//                                             //
/////////////////////////////////////////////////
using System;
using System.Collections.Generic;

namespace Server.Items
{
    public class GhostShip : BaseAddon
    {
        private DateTime m_DeleteTime;
        private readonly Timer m_Timer;

        //Make lists containing the spawned mobiles and items, needed for the boat decay and emerge timer
        private List<Mobile> m_Spawns = new List<Mobile>();
        private List<Item> m_Items = new List<Item>();

        [CommandProperty(AccessLevel.GameMaster)]
        public DateTime DeleteTime { get { return m_DeleteTime; } }

        [Constructable]
        public GhostShip()
        {
            AddonComponent ac;
            ac = new AddonComponent(1973);
            AddComponent(ac, -10, -4, 12);
            ac = new AddonComponent(1848);
            ac.Hue = 1118;
            AddComponent(ac, -9, -4, 12);
            ac = new AddonComponent(1848);
            ac.Hue = 1118;
            AddComponent(ac, -8, -4, 12);
            ac = new AddonComponent(1848);
            ac.Hue = 1118;
            AddComponent(ac, -7, -4, 12);
            ac = new AddonComponent(1848);
            ac.Hue = 1118;
            AddComponent(ac, -6, -4, 12);
            ac = new AddonComponent(1848);
            ac.Hue = 1118;
            AddComponent(ac, -5, -4, 12);
            ac = new AddonComponent(1848);
            ac.Hue = 1118;
            AddComponent(ac, -4, -4, 12);
            ac = new AddonComponent(1848);
            ac.Hue = 1118;
            AddComponent(ac, -3, -4, 12);
            ac = new AddonComponent(1848);
            ac.Hue = 1118;
            AddComponent(ac, -2, -4, 12);
            ac = new AddonComponent(1848);
            ac.Hue = 1118;
            AddComponent(ac, -1, -4, 12);
            ac = new AddonComponent(1848);
            ac.Hue = 1118;
            AddComponent(ac, 0, -4, 12);
            ac = new AddonComponent(1848);
            ac.Hue = 1118;
            AddComponent(ac, 1, -4, 12);
            ac = new AddonComponent(1848);
            ac.Hue = 1118;
            AddComponent(ac, 2, -4, 12);
            ac = new AddonComponent(1848);
            ac.Hue = 1118;
            AddComponent(ac, 3, -4, 12);
            ac = new AddonComponent(1973);
            ac.Hue = 1118;
            AddComponent(ac, -10, 4, 12);
            ac = new AddonComponent(1848);
            ac.Hue = 1118;
            AddComponent(ac, -9, 4, 12);
            ac = new AddonComponent(1848);
            ac.Hue = 1118;
            AddComponent(ac, -8, 4, 12);
            ac = new AddonComponent(1848);
            ac.Hue = 1118;
            AddComponent(ac, -7, 4, 12);
            ac = new AddonComponent(1848);
            ac.Hue = 1118;
            AddComponent(ac, -6, 4, 12);
            ac = new AddonComponent(1848);
            ac.Hue = 1118;
            AddComponent(ac, -5, 4, 12);
            ac = new AddonComponent(1848);
            ac.Hue = 1118;
            AddComponent(ac, -4, 4, 12);
            ac = new AddonComponent(1848);
            ac.Hue = 1118;
            AddComponent(ac, -3, 4, 12);
            ac = new AddonComponent(1848);
            ac.Hue = 1118;
            AddComponent(ac, -2, 4, 12);
            ac = new AddonComponent(1848);
            ac.Hue = 1118;
            AddComponent(ac, -1, 4, 12);
            ac = new AddonComponent(1848);
            ac.Hue = 1118;
            AddComponent(ac, 0, 4, 12);
            ac = new AddonComponent(1848);
            ac.Hue = 1118;
            AddComponent(ac, 1, 4, 12);
            ac = new AddonComponent(1848);
            ac.Hue = 1118;
            AddComponent(ac, 2, 4, 12);
            ac = new AddonComponent(1848);
            ac.Hue = 1118;
            AddComponent(ac, 3, 4, 12);
            ac = new AddonComponent(1973);
            AddComponent(ac, -10, -3, 12);
            ac = new AddonComponent(1204);
            AddComponent(ac, -9, -3, 12);
            ac = new AddonComponent(1200);
            AddComponent(ac, -8, -3, 12);
            ac = new AddonComponent(1200);
            AddComponent(ac, -7, -3, 12);
            ac = new AddonComponent(1200);
            AddComponent(ac, -6, -3, 12);
            ac = new AddonComponent(1200);
            AddComponent(ac, -5, -3, 12);
            ac = new AddonComponent(1200);
            AddComponent(ac, -4, -3, 12);
            ac = new AddonComponent(1200);
            AddComponent(ac, -3, -3, 12);
            ac = new AddonComponent(1200);
            AddComponent(ac, -2, -3, 12);
            ac = new AddonComponent(1200);
            AddComponent(ac, -1, -3, 12);
            ac = new AddonComponent(1200);
            AddComponent(ac, 0, -3, 12);
            ac = new AddonComponent(1200);
            AddComponent(ac, 1, -3, 12);
            ac = new AddonComponent(1200);
            AddComponent(ac, 2, -3, 12);
            ac = new AddonComponent(1200);
            AddComponent(ac, 3, -3, 12);
            ac = new AddonComponent(1973);
            AddComponent(ac, -10, -1, 12);
            ac = new AddonComponent(1973);
            AddComponent(ac, -10, -2, 12);
            ac = new AddonComponent(1973);
            AddComponent(ac, -10, 0, 12);
            ac = new AddonComponent(1973);
            AddComponent(ac, -10, 1, 12);
            ac = new AddonComponent(1973);
            AddComponent(ac, -10, 2, 12);
            ac = new AddonComponent(1197);
            AddComponent(ac, -9, 2, 12);
            ac = new AddonComponent(1197);
            AddComponent(ac, -9, 1, 12);
            ac = new AddonComponent(1197);
            AddComponent(ac, -9, 0, 12);
            ac = new AddonComponent(1197);
            AddComponent(ac, -9, -1, 12);
            ac = new AddonComponent(1197);
            AddComponent(ac, -9, -2, 12);
            ac = new AddonComponent(1195);
            AddComponent(ac, -8, -2, 12);
            ac = new AddonComponent(1195);
            AddComponent(ac, -8, -1, 12);
            ac = new AddonComponent(1195);
            AddComponent(ac, -8, 0, 12);
            ac = new AddonComponent(1195);
            AddComponent(ac, -8, 1, 12);
            ac = new AddonComponent(1195);
            AddComponent(ac, -8, 2, 12);
            ac = new AddonComponent(1195);
            AddComponent(ac, -7, -2, 12);
            ac = new AddonComponent(1195);
            AddComponent(ac, -7, -1, 12);
            ac = new AddonComponent(1195);
            AddComponent(ac, -7, 0, 12);
            ac = new AddonComponent(1195);
            AddComponent(ac, -7, 1, 12);
            ac = new AddonComponent(1195);
            AddComponent(ac, -7, 2, 12);
            ac = new AddonComponent(1195);
            AddComponent(ac, -6, -2, 12);
            ac = new AddonComponent(1195);
            AddComponent(ac, -6, -1, 12);
            ac = new AddonComponent(1195);
            AddComponent(ac, -6, 0, 12);
            ac = new AddonComponent(1195);
            AddComponent(ac, -6, 1, 12);
            ac = new AddonComponent(1195);
            AddComponent(ac, -6, 2, 12);
            ac = new AddonComponent(1195);
            AddComponent(ac, -5, -2, 12);
            ac = new AddonComponent(1195);
            AddComponent(ac, -5, -1, 12);
            ac = new AddonComponent(1195);
            AddComponent(ac, -5, 0, 12);
            ac = new AddonComponent(1195);
            AddComponent(ac, -5, 1, 12);
            ac = new AddonComponent(1195);
            AddComponent(ac, -5, 2, 12);
            ac = new AddonComponent(1195);
            AddComponent(ac, -4, -2, 12);
            ac = new AddonComponent(1195);
            AddComponent(ac, -4, -1, 12);
            ac = new AddonComponent(1195);
            AddComponent(ac, -4, 0, 12);
            ac = new AddonComponent(1195);
            AddComponent(ac, -4, 1, 12);
            ac = new AddonComponent(1195);
            AddComponent(ac, -4, 2, 12);
            ac = new AddonComponent(1195);
            AddComponent(ac, -3, -2, 12);
            ac = new AddonComponent(1195);
            AddComponent(ac, -3, -1, 12);
            ac = new AddonComponent(1195);
            AddComponent(ac, -3, 0, 12);
            ac = new AddonComponent(1195);
            AddComponent(ac, -3, 1, 12);
            ac = new AddonComponent(1195);
            AddComponent(ac, -3, 2, 12);
            ac = new AddonComponent(1195);
            AddComponent(ac, -2, -2, 12);
            ac = new AddonComponent(1195);
            AddComponent(ac, -2, -1, 12);
            ac = new AddonComponent(1195);
            AddComponent(ac, -2, 0, 12);
            ac = new AddonComponent(1195);
            AddComponent(ac, -2, 1, 12);
            ac = new AddonComponent(1195);
            AddComponent(ac, -2, 2, 12);
            ac = new AddonComponent(1195);
            AddComponent(ac, -1, -2, 12);
            ac = new AddonComponent(1195);
            AddComponent(ac, -1, -1, 12);
            ac = new AddonComponent(1195);
            AddComponent(ac, -1, 0, 12);
            ac = new AddonComponent(1195);
            AddComponent(ac, -1, 1, 12);
            ac = new AddonComponent(1195);
            AddComponent(ac, -1, 2, 12);
            ac = new AddonComponent(1195);
            AddComponent(ac, 0, -2, 12);
            ac = new AddonComponent(1195);
            AddComponent(ac, 0, -1, 12);
            ac = new AddonComponent(1195);
            AddComponent(ac, 0, 0, 12);
            ac = new AddonComponent(1195);
            AddComponent(ac, 0, 1, 12);
            ac = new AddonComponent(1195);
            AddComponent(ac, 0, 2, 12);
            ac = new AddonComponent(1195);
            AddComponent(ac, 1, -2, 12);
            ac = new AddonComponent(1195);
            AddComponent(ac, 1, -1, 12);
            ac = new AddonComponent(1195);
            AddComponent(ac, 1, 0, 12);
            ac = new AddonComponent(1195);
            AddComponent(ac, 1, 1, 12);
            ac = new AddonComponent(1195);
            AddComponent(ac, 1, 2, 12);
            ac = new AddonComponent(1195);
            AddComponent(ac, 2, -2, 12);
            ac = new AddonComponent(1195);
            AddComponent(ac, 2, -1, 12);
            ac = new AddonComponent(1195);
            AddComponent(ac, 2, 0, 12);
            ac = new AddonComponent(1195);
            AddComponent(ac, 2, 1, 12);
            ac = new AddonComponent(1195);
            AddComponent(ac, 2, 2, 12);
            ac = new AddonComponent(1195);
            AddComponent(ac, 3, -2, 12);
            ac = new AddonComponent(1195);
            AddComponent(ac, 3, -1, 12);
            ac = new AddonComponent(1195);
            AddComponent(ac, 3, 0, 12);
            ac = new AddonComponent(1195);
            AddComponent(ac, 3, 1, 12);
            ac = new AddonComponent(1195);
            AddComponent(ac, 3, 2, 12);
            ac = new AddonComponent(1973);
            AddComponent(ac, -10, 3, 12);
            ac = new AddonComponent(1197);
            AddComponent(ac, -9, 3, 12);
            ac = new AddonComponent(1198);
            AddComponent(ac, -8, 3, 12);
            ac = new AddonComponent(1198);
            AddComponent(ac, -7, 3, 12);
            ac = new AddonComponent(1198);
            AddComponent(ac, -6, 3, 12);
            ac = new AddonComponent(1198);
            AddComponent(ac, -5, 3, 12);
            ac = new AddonComponent(1198);
            AddComponent(ac, -4, 3, 12);
            ac = new AddonComponent(1198);
            AddComponent(ac, -3, 3, 12);
            ac = new AddonComponent(1198);
            AddComponent(ac, -2, 3, 12);
            ac = new AddonComponent(1198);
            AddComponent(ac, -1, 3, 12);
            ac = new AddonComponent(1198);
            AddComponent(ac, 0, 3, 12);
            ac = new AddonComponent(1198);
            AddComponent(ac, 1, 3, 12);
            ac = new AddonComponent(1198);
            AddComponent(ac, 2, 3, 12);
            ac = new AddonComponent(1198);
            AddComponent(ac, 3, 3, 12);
            ac = new AddonComponent(1848);
            AddComponent(ac, -10, 3, 17);
            ac = new AddonComponent(1848);
            AddComponent(ac, -10, 2, 17);
            ac = new AddonComponent(1848);
            AddComponent(ac, -10, 1, 17);
            ac = new AddonComponent(1848);
            AddComponent(ac, -10, 0, 17);
            ac = new AddonComponent(1848);
            AddComponent(ac, -10, -2, 17);
            ac = new AddonComponent(1848);
            AddComponent(ac, -10, -1, 17);
            ac = new AddonComponent(1848);
            AddComponent(ac, -10, -3, 17);
            ac = new AddonComponent(1848);
            AddComponent(ac, -10, -4, 17);
            ac = new AddonComponent(1848);
            ac.Hue = 1118;
            AddComponent(ac, -9, -4, 17);
            ac = new AddonComponent(1848);
            ac.Hue = 1118;
            AddComponent(ac, -8, -4, 17);
            ac = new AddonComponent(1848);
            ac.Hue = 1118;
            AddComponent(ac, -7, -4, 17);
            ac = new AddonComponent(1848);
            ac.Hue = 1118;
            AddComponent(ac, -6, -4, 17);
            ac = new AddonComponent(1848);
            ac.Hue = 1118;
            AddComponent(ac, -5, -4, 17);
            ac = new AddonComponent(1848);
            ac.Hue = 1118;
            AddComponent(ac, -4, -4, 17);
            ac = new AddonComponent(1848);
            ac.Hue = 1118;
            AddComponent(ac, -3, -4, 17);
            ac = new AddonComponent(1848);
            ac.Hue = 1118;
            AddComponent(ac, 0, -4, 17);
            ac = new AddonComponent(1848);
            ac.Hue = 1118;
            AddComponent(ac, 1, -4, 17);
            ac = new AddonComponent(1848);
            ac.Hue = 1118;
            AddComponent(ac, 2, -4, 17);
            ac = new AddonComponent(1848);
            ac.Hue = 1118;
            AddComponent(ac, 3, -4, 17);
            ac = new AddonComponent(1848);
            ac.Hue = 1118;
            AddComponent(ac, -10, 4, 17);
            ac = new AddonComponent(1848);
            ac.Hue = 1118;
            AddComponent(ac, -9, 4, 17);
            ac = new AddonComponent(1848);
            ac.Hue = 1118;
            AddComponent(ac, -8, 4, 17);
            ac = new AddonComponent(1848);
            ac.Hue = 1118;
            AddComponent(ac, -7, 4, 17);
            ac = new AddonComponent(1848);
            ac.Hue = 1118;
            AddComponent(ac, -6, 4, 17);
            ac = new AddonComponent(1848);
            ac.Hue = 1118;
            AddComponent(ac, -5, 4, 17);
            ac = new AddonComponent(1848);
            ac.Hue = 1118;
            AddComponent(ac, -4, 4, 17);
            ac = new AddonComponent(1848);
            ac.Hue = 1118;
            AddComponent(ac, -3, 4, 17);
            ac = new AddonComponent(1848);
            ac.Hue = 1118;
            AddComponent(ac, 1, 4, 17);
            ac = new AddonComponent(1848);
            ac.Hue = 1118;
            AddComponent(ac, 2, 4, 17);
            ac = new AddonComponent(1848);
            ac.Hue = 1118;
            AddComponent(ac, 3, 4, 17);
            ac = new AddonComponent(1848);
            ac.Hue = 1118;
            AddComponent(ac, 0, 4, 17);
            ac = new AddonComponent(15960);
            ac.Hue = 1058;
            AddComponent(ac, -10, 3, 33);
            ac = new AddonComponent(15961);
            ac.Hue = 1058;
            AddComponent(ac, -10, 2, 22);
            ac = new AddonComponent(15964);
            ac.Hue = 1058;
            AddComponent(ac, -10, -4, 0);
            ac = new AddonComponent(15963);
            ac.Hue = 1058;
            AddComponent(ac, -10, -2, 11);
            ac = new AddonComponent(15962);
            ac.Hue = 1058;
            AddComponent(ac, -10, 0, 22);
            ac = new AddonComponent(16011);
            ac.Hue = 1058;
            AddComponent(ac, -10, -4, 22);
            ac = new AddonComponent(16011);
            ac.Hue = 1058;
            AddComponent(ac, -10, -3, 22);
            ac = new AddonComponent(16011);
            ac.Hue = 1058;
            AddComponent(ac, -10, -2, 22);
            ac = new AddonComponent(16011);
            ac.Hue = 1058;
            AddComponent(ac, -10, -1, 22);
            ac = new AddonComponent(16011);
            ac.Hue = 1058;
            AddComponent(ac, -10, 1, 22);
            ac = new AddonComponent(16011);
            ac.Hue = 1058;
            AddComponent(ac, -10, 2, 22);
            ac = new AddonComponent(16011);
            ac.Hue = 1058;
            AddComponent(ac, -10, 3, 22);
            ac = new AddonComponent(16011);
            ac.Hue = 1058;
            AddComponent(ac, -10, 4, 22);
            ac = new AddonComponent(16044);
            ac.Hue = 1058;
            AddComponent(ac, 0, 4, 23);
            ac = new AddonComponent(16044);
            ac.Hue = 1058;
            AddComponent(ac, 1, 4, 23);
            ac = new AddonComponent(16044);
            ac.Hue = 1058;
            AddComponent(ac, 2, 4, 23);
            ac = new AddonComponent(16044);
            ac.Hue = 1058;
            AddComponent(ac, 3, 4, 23);
            ac = new AddonComponent(16044);
            ac.Hue = 1058;
            AddComponent(ac, -3, 4, 22);
            ac = new AddonComponent(16044);
            ac.Hue = 1058;
            AddComponent(ac, -4, 4, 22);
            ac = new AddonComponent(16044);
            ac.Hue = 1058;
            AddComponent(ac, -5, 4, 22);
            ac = new AddonComponent(16044);
            ac.Hue = 1058;
            AddComponent(ac, -6, 4, 22);
            ac = new AddonComponent(16044);
            ac.Hue = 1058;
            AddComponent(ac, -7, 4, 22);
            ac = new AddonComponent(16044);
            ac.Hue = 1058;
            AddComponent(ac, -8, 4, 22);
            ac = new AddonComponent(16044);
            ac.Hue = 1058;
            AddComponent(ac, -9, 4, 22);
            ac = new AddonComponent(16044);
            ac.Hue = 1058;
            AddComponent(ac, -9, -4, 22);
            ac = new AddonComponent(16044);
            ac.Hue = 1058;
            AddComponent(ac, -8, -4, 22);
            ac = new AddonComponent(16044);
            ac.Hue = 1058;
            AddComponent(ac, -7, -4, 22);
            ac = new AddonComponent(16044);
            ac.Hue = 1058;
            AddComponent(ac, -6, -4, 22);
            ac = new AddonComponent(16044);
            ac.Hue = 1058;
            AddComponent(ac, -5, -4, 22);
            ac = new AddonComponent(16044);
            ac.Hue = 1058;
            AddComponent(ac, -4, -4, 22);
            ac = new AddonComponent(16044);
            ac.Hue = 1058;
            AddComponent(ac, -3, -4, 22);
            ac = new AddonComponent(16044);
            ac.Hue = 1058;
            AddComponent(ac, 0, -4, 23);
            ac = new AddonComponent(16044);
            ac.Hue = 1058;
            AddComponent(ac, 1, -4, 23);
            ac = new AddonComponent(16044);
            ac.Hue = 1058;
            AddComponent(ac, 2, -4, 23);
            ac = new AddonComponent(16044);
            ac.Hue = 1058;
            AddComponent(ac, 3, -4, 23);
            ac = new AddonComponent(6916);
            AddComponent(ac, -1, -1, 12);
            ac = new AddonComponent(6918);
            AddComponent(ac, -2, 4, 17);
            ac = new AddonComponent(6920);
            AddComponent(ac, 0, -2, 12);
            ac = new AddonComponent(6919);
            AddComponent(ac, -9, 0, 12);
            ac = new AddonComponent(6913);
            AddComponent(ac, -1, -4, 17);
            ac = new AddonComponent(6915);
            AddComponent(ac, -10, 1, 25);
            ac = new AddonComponent(6917);
            AddComponent(ac, -9, -3, 12);
            ac = new AddonComponent(6917);
            AddComponent(ac, -2, -4, 17);
            ac = new AddonComponent(5369);
            AddComponent(ac, -5, -3, 12);
            ac = new AddonComponent(5370);
            AddComponent(ac, -4, -3, 12);
            ac = new AddonComponent(933);
            AddComponent(ac, -3, 4, 24);
            ac = new AddonComponent(933);
            AddComponent(ac, 0, 4, 25);
            ac = new AddonComponent(933);
            AddComponent(ac, -3, -4, 24);
            ac = new AddonComponent(933);
            AddComponent(ac, 0, -4, 25);
            ac = new AddonComponent(2211);
            ac.Hue = 1057;
            AddComponent(ac, -1, -3, 12);
            ac = new AddonComponent(2211);
            ac.Hue = 1057;
            AddComponent(ac, -2, -3, 12);
            ac = new AddonComponent(6915);
            AddComponent(ac, -9, 4, 25);
            ac = new AddonComponent(1848);
            AddComponent(ac, 7, -3, 17);
            ac = new AddonComponent(16011);
            ac.Hue = 1058;
            AddComponent(ac, 8, -4, 23);
            ac = new AddonComponent(1848);
            ac.Hue = 1118;
            AddComponent(ac, 4, -4, 12);
            ac = new AddonComponent(1848);
            ac.Hue = 1118;
            AddComponent(ac, 5, -4, 12);
            ac = new AddonComponent(1848);
            ac.Hue = 1118;
            AddComponent(ac, 6, -4, 12);
            ac = new AddonComponent(1848);
            ac.Hue = 1118;
            AddComponent(ac, 4, 4, 12);
            ac = new AddonComponent(1848);
            ac.Hue = 1118;
            AddComponent(ac, 5, 4, 12);
            ac = new AddonComponent(1848);
            ac.Hue = 1118;
            AddComponent(ac, 6, 4, 12);
            ac = new AddonComponent(1200);
            AddComponent(ac, 4, -3, 12);
            ac = new AddonComponent(1200);
            AddComponent(ac, 5, -3, 12);
            ac = new AddonComponent(1200);
            AddComponent(ac, 6, -3, 12);
            ac = new AddonComponent(1195);
            AddComponent(ac, 4, -2, 12);
            ac = new AddonComponent(1195);
            AddComponent(ac, 4, -1, 12);
            ac = new AddonComponent(1195);
            AddComponent(ac, 4, 0, 12);
            ac = new AddonComponent(1195);
            AddComponent(ac, 4, 1, 12);
            ac = new AddonComponent(1195);
            AddComponent(ac, 4, 2, 12);
            ac = new AddonComponent(1195);
            AddComponent(ac, 5, -2, 12);
            ac = new AddonComponent(1195);
            AddComponent(ac, 5, -1, 12);
            ac = new AddonComponent(1195);
            AddComponent(ac, 5, 0, 12);
            ac = new AddonComponent(1195);
            AddComponent(ac, 5, 1, 12);
            ac = new AddonComponent(1195);
            AddComponent(ac, 5, 2, 12);
            ac = new AddonComponent(1195);
            AddComponent(ac, 6, -2, 12);
            ac = new AddonComponent(1195);
            AddComponent(ac, 6, -1, 12);
            ac = new AddonComponent(1195);
            AddComponent(ac, 6, 0, 12);
            ac = new AddonComponent(1195);
            AddComponent(ac, 6, 1, 12);
            ac = new AddonComponent(1195);
            AddComponent(ac, 6, 2, 12);
            ac = new AddonComponent(1198);
            AddComponent(ac, 4, 3, 12);
            ac = new AddonComponent(1198);
            AddComponent(ac, 5, 3, 12);
            ac = new AddonComponent(1198);
            AddComponent(ac, 6, 3, 12);
            ac = new AddonComponent(1972);
            ac.Hue = 1118;
            AddComponent(ac, 7, 4, 12);
            ac = new AddonComponent(1972);
            AddComponent(ac, 7, 3, 12);
            ac = new AddonComponent(1972);
            AddComponent(ac, 7, 2, 12);
            ac = new AddonComponent(1972);
            AddComponent(ac, 7, 1, 12);
            ac = new AddonComponent(1972);
            AddComponent(ac, 7, -1, 12);
            ac = new AddonComponent(1972);
            AddComponent(ac, 7, 0, 12);
            ac = new AddonComponent(1972);
            AddComponent(ac, 7, -4, 12);
            ac = new AddonComponent(1972);
            AddComponent(ac, 7, -3, 12);
            ac = new AddonComponent(1972);
            AddComponent(ac, 7, -2, 12);
            ac = new AddonComponent(1972);
            AddComponent(ac, 8, -4, 17);
            ac = new AddonComponent(1972);
            AddComponent(ac, 8, -3, 17);
            ac = new AddonComponent(1972);
            AddComponent(ac, 8, -2, 17);
            ac = new AddonComponent(1972);
            AddComponent(ac, 8, -1, 17);
            ac = new AddonComponent(1972);
            AddComponent(ac, 8, 0, 17);
            ac = new AddonComponent(1972);
            AddComponent(ac, 8, 1, 17);
            ac = new AddonComponent(1972);
            AddComponent(ac, 8, 2, 17);
            ac = new AddonComponent(1972);
            AddComponent(ac, 8, 3, 17);
            ac = new AddonComponent(1972);
            ac.Hue = 1118;
            AddComponent(ac, 8, 4, 17);
            ac = new AddonComponent(1848);
            AddComponent(ac, 7, -4, 17);
            ac = new AddonComponent(1848);
            AddComponent(ac, 7, -2, 17);
            ac = new AddonComponent(1848);
            AddComponent(ac, 7, -1, 17);
            ac = new AddonComponent(1848);
            AddComponent(ac, 7, 0, 17);
            ac = new AddonComponent(1848);
            AddComponent(ac, 7, 1, 17);
            ac = new AddonComponent(1848);
            AddComponent(ac, 7, 2, 17);
            ac = new AddonComponent(1848);
            ac.Hue = 1118;
            AddComponent(ac, 4, -4, 17);
            ac = new AddonComponent(1848);
            ac.Hue = 1118;
            AddComponent(ac, 5, -4, 17);
            ac = new AddonComponent(1848);
            ac.Hue = 1118;
            AddComponent(ac, 6, -4, 17);
            ac = new AddonComponent(15959);
            ac.Hue = 1058;
            AddComponent(ac, 7, 0, 23);
            ac = new AddonComponent(1848);
            ac.Hue = 1118;
            AddComponent(ac, 4, 4, 17);
            ac = new AddonComponent(1848);
            ac.Hue = 1118;
            AddComponent(ac, 5, 4, 17);
            ac = new AddonComponent(1848);
            ac.Hue = 1118;
            AddComponent(ac, 6, 4, 17);
            ac = new AddonComponent(16011);
            ac.Hue = 1058;
            AddComponent(ac, 7, -4, 23);
            ac = new AddonComponent(16011);
            ac.Hue = 1058;
            AddComponent(ac, 8, -3, 23);
            ac = new AddonComponent(1848);
            ac.Hue = 1118;
            AddComponent(ac, 7, 4, 17);
            ac = new AddonComponent(1848);
            AddComponent(ac, 7, 3, 17);
            ac = new AddonComponent(15984);
            ac.Hue = 1058;
            AddComponent(ac, 7, 4, 45);
            ac = new AddonComponent(15985);
            ac.Hue = 1058;
            AddComponent(ac, 7, 2, 34);
            ac = new AddonComponent(15988);
            ac.Hue = 1058;
            AddComponent(ac, 8, -3, 12);
            ac = new AddonComponent(15987);
            ac.Hue = 1058;
            AddComponent(ac, 7, -2, 12);
            ac = new AddonComponent(16011);
            ac.Hue = 1058;
            AddComponent(ac, 7, -3, 23);
            ac = new AddonComponent(16011);
            ac.Hue = 1058;
            AddComponent(ac, 8, -2, 23);
            ac = new AddonComponent(16011);
            ac.Hue = 1058;
            AddComponent(ac, 7, -2, 23);
            ac = new AddonComponent(16011);
            ac.Hue = 1058;
            AddComponent(ac, 8, -1, 23);
            ac = new AddonComponent(16011);
            ac.Hue = 1058;
            AddComponent(ac, 7, -1, 23);
            ac = new AddonComponent(16011);
            ac.Hue = 1058;
            AddComponent(ac, 8, 0, 23);
            ac = new AddonComponent(16011);
            ac.Hue = 1058;
            AddComponent(ac, 8, 1, 23);
            ac = new AddonComponent(16011);
            ac.Hue = 1058;
            AddComponent(ac, 8, 2, 23);
            ac = new AddonComponent(16011);
            ac.Hue = 1058;
            AddComponent(ac, 8, 3, 23);
            ac = new AddonComponent(16011);
            ac.Hue = 1058;
            AddComponent(ac, 8, 4, 23);
            ac = new AddonComponent(16011);
            ac.Hue = 1058;
            AddComponent(ac, 7, 4, 23);
            ac = new AddonComponent(16011);
            ac.Hue = 1058;
            AddComponent(ac, 7, 1, 23);
            ac = new AddonComponent(16011);
            ac.Hue = 1058;
            AddComponent(ac, 7, 2, 23);
            ac = new AddonComponent(16011);
            ac.Hue = 1058;
            AddComponent(ac, 7, 3, 23);
            ac = new AddonComponent(16044);
            ac.Hue = 1058;
            AddComponent(ac, 4, 4, 23);
            ac = new AddonComponent(16044);
            ac.Hue = 1058;
            AddComponent(ac, 5, 4, 23);
            ac = new AddonComponent(16044);
            ac.Hue = 1058;
            AddComponent(ac, 6, 4, 23);
            ac = new AddonComponent(16044);
            ac.Hue = 1058;
            AddComponent(ac, 4, -4, 23);
            ac = new AddonComponent(16044);
            ac.Hue = 1058;
            AddComponent(ac, 5, -4, 23);
            ac = new AddonComponent(16044);
            ac.Hue = 1058;
            AddComponent(ac, 6, -4, 23);
            ac = new AddonComponent(6920);
            AddComponent(ac, 7, 1, 26);
            ac = new AddonComponent(6918);
            AddComponent(ac, 8, 0, 26);
            ac = new AddonComponent(1853);
            ac.Hue = 1118;
            AddComponent(ac, 8, -4, 22);
            ac = new AddonComponent(1856);
            ac.Hue = 1118;
            AddComponent(ac, 8, 4, 22);
            ac = new AddonComponent(1863);
            ac.Hue = 1118;
            AddComponent(ac, 9, -4, 22);
            ac = new AddonComponent(1861);
            ac.Hue = 1118;
            AddComponent(ac, 9, 4, 22);
            ac = new AddonComponent(1850);
            ac.Hue = 1118;
            AddComponent(ac, 9, -3, 22);
            ac = new AddonComponent(1850);
            ac.Hue = 1118;
            AddComponent(ac, 9, -2, 22);
            ac = new AddonComponent(1850);
            ac.Hue = 1118;
            AddComponent(ac, 9, -1, 22);
            ac = new AddonComponent(1848);
            ac.Hue = 1118;
            AddComponent(ac, 9, 0, 22);
            ac = new AddonComponent(1850);
            ac.Hue = 1118;
            AddComponent(ac, 9, 1, 22);
            ac = new AddonComponent(1850);
            ac.Hue = 1118;
            AddComponent(ac, 9, 2, 22);
            ac = new AddonComponent(1850);
            ac.Hue = 1118;
            AddComponent(ac, 9, 3, 22);
            ac = new AddonComponent(1852);
            ac.Hue = 1118;
            AddComponent(ac, 8, -3, 22);
            ac = new AddonComponent(1852);
            ac.Hue = 1118;
            AddComponent(ac, 8, -2, 22);
            ac = new AddonComponent(1852);
            ac.Hue = 1118;
            AddComponent(ac, 8, -1, 22);
            ac = new AddonComponent(1852);
            ac.Hue = 1118;
            AddComponent(ac, 8, 0, 22);
            ac = new AddonComponent(1852);
            ac.Hue = 1118;
            AddComponent(ac, 8, 1, 22);
            ac = new AddonComponent(1852);
            ac.Hue = 1118;
            AddComponent(ac, 8, 2, 22);
            ac = new AddonComponent(1852);
            ac.Hue = 1118;
            AddComponent(ac, 8, 3, 22);
            ac = new AddonComponent(8757);
            AddComponent(ac, 10, 0, 27);
            ac = new AddonComponent(6918);
            AddComponent(ac, 7, -4, 26);

            m_DeleteTime = DateTime.Now + TimeSpan.FromMinutes(30.0);

            m_Timer = new DeleteTimer(m_Spawns, m_Items, m_DeleteTime);
            m_Timer.Start();
        }

        public GhostShip(Serial serial) : base(serial)
        {
        }

        public List<Mobile> Spawnlist
        {
            get { return m_Spawns; }
        }

        public List<Item> Itemlist
        {
            get { return m_Items; }
        }

        private class DeleteTimer : Timer
        {
            private readonly List<Mobile> m_Spawns;
            private readonly List<Item> m_Items;

            public DeleteTimer(List<Mobile> spawns, List<Item> items, DateTime time)
                : base(time - DateTime.Now)
            {
                m_Items = items;
                m_Spawns = spawns;
                Priority = TimerPriority.OneMinute;
            }

            protected override void OnTick()
            {
                for (int i = 0; i < m_Items.Count; i++) //Delete the boat and any items inside
                {
                    Item item = m_Items[i];
                    item.Delete();
                }

                for (int i = 0; i < m_Spawns.Count; i++) //If any spawns still exist, delete them
                {
                    Mobile m = m_Spawns[i];
                    m.Delete();
                }
            }
        }

        public override void Serialize(GenericWriter writer)
        {
            base.Serialize(writer);
            writer.Write(0); // Version

            writer.Write( m_Spawns );
            writer.Write( m_Items );
            writer.WriteDeltaTime (m_DeleteTime );
        }

        public override void Deserialize(GenericReader reader)
        {
            base.Deserialize(reader);
            int version = reader.ReadInt();

            m_Spawns = reader.ReadStrongMobileList();
            m_Items = reader.ReadStrongItemList();
            m_DeleteTime = reader.ReadDeltaTime();
        }
    }
}