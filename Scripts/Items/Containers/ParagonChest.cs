using System;
using System.Collections.Generic;

namespace Server.Items
{
    [Flipable]
    public class ParagonChest : LockableContainer
    {
        private static readonly int[] m_ItemIDs = new int[]
        {
            0x9AB, 0xE40, 0xE41, 0xE7C
        };
        private static readonly int[] m_Hues = new int[]
        {
            0x0, 0x455, 0x47E, 0x89F, 0x8A5, 0x8AB,
            0x966, 0x96D, 0x972, 0x973, 0x979
        };
        private string m_Name;
        [Constructable]
        public ParagonChest(string name, int level)
            : base(Utility.RandomList(m_ItemIDs))
        {
            this.m_Name = name;
            this.Hue = Utility.RandomList(m_Hues);
            this.Fill(level);
        }

        public ParagonChest(Serial serial)
            : base(serial)
        {
        }

        public override void OnSingleClick(Mobile from)
        {
            this.LabelTo(from, 1063449, this.m_Name);
        }

        public override void GetProperties(ObjectPropertyList list)
        {
            base.GetProperties(list);

            list.Add(1063449, this.m_Name);
        }

        public void Flip()
        {
            switch ( this.ItemID )
            {
                case 0x9AB :
                    this.ItemID = 0xE7C;
                    break;
                case 0xE7C :
                    this.ItemID = 0x9AB;
                    break;
                case 0xE40 :
                    this.ItemID = 0xE41;
                    break;
                case 0xE41 :
                    this.ItemID = 0xE40;
                    break;
            }
        }

        public override void Serialize(GenericWriter writer)
        {
            base.Serialize(writer);

            writer.Write((int)0); // version

            writer.Write(this.m_Name);
        }

        public override void Deserialize(GenericReader reader)
        {
            base.Deserialize(reader);

            int version = reader.ReadInt();

            this.m_Name = Utility.Intern(reader.ReadString());
        }

        private static void GetRandomAOSStats(out int attributeCount, out int min, out int max)
        {
            int rnd = Utility.Random(15);

            if (rnd < 1)
            {
                attributeCount = Utility.RandomMinMax(2, 6);
                min = 20;
                max = 70;
            }
            else if (rnd < 3)
            {
                attributeCount = Utility.RandomMinMax(2, 4);
                min = 20;
                max = 50;
            }
            else if (rnd < 6)
            {
                attributeCount = Utility.RandomMinMax(2, 3);
                min = 20;
                max = 40;
            }
            else if (rnd < 10)
            {
                attributeCount = Utility.RandomMinMax(1, 2);
                min = 10;
                max = 30;
            }
            else
            {
                attributeCount = 1;
                min = 10;
                max = 20;
            }
        }

        private void Fill(int level)
        {
            this.TrapType = TrapType.ExplosionTrap;
            this.TrapPower = level * 25;
            this.TrapLevel = level;
            this.Locked = true;

            switch ( level )
            {
                case 1:
                    this.RequiredSkill = 36;
                    break;
                case 2:
                    this.RequiredSkill = 76;
                    break;
                case 3:
                    this.RequiredSkill = 84;
                    break;
                case 4:
                    this.RequiredSkill = 92;
                    break;
                case 5:
                    this.RequiredSkill = 100;
                    break;
            }

            this.LockLevel = this.RequiredSkill - 10;
            this.MaxLockLevel = this.RequiredSkill + 40;

            this.DropItem(new Gold(level * 200));

            for (int i = 0; i < level; ++i)
                this.DropItem(Loot.RandomScroll(0, 63, SpellbookType.Regular));

            for (int i = 0; i < level * 2; ++i)
            {
                Item item;

                if (Core.AOS)
                    item = Loot.RandomArmorOrShieldOrWeaponOrJewelry();
                else
                    item = Loot.RandomArmorOrShieldOrWeapon();

                if (item is BaseWeapon)
                {
                    BaseWeapon weapon = (BaseWeapon)item;

                    if (Core.AOS)
                    {
                        int attributeCount;
                        int min, max;

                        GetRandomAOSStats(out attributeCount, out min, out max);

                        BaseRunicTool.ApplyAttributesTo(weapon, attributeCount, min, max);
                    }
                    else
                    {
                        weapon.DamageLevel = (WeaponDamageLevel)Utility.Random(6);
                        weapon.AccuracyLevel = (WeaponAccuracyLevel)Utility.Random(6);
                        weapon.DurabilityLevel = (WeaponDurabilityLevel)Utility.Random(6);
                    }

                    this.DropItem(item);
                }
                else if (item is BaseArmor)
                {
                    BaseArmor armor = (BaseArmor)item;

                    if (Core.AOS)
                    {
                        int attributeCount;
                        int min, max;

                        GetRandomAOSStats(out attributeCount, out min, out max);

                        BaseRunicTool.ApplyAttributesTo(armor, attributeCount, min, max);
                    }
                    else
                    {
                        armor.ProtectionLevel = (ArmorProtectionLevel)Utility.Random(6);
                        armor.Durability = (ArmorDurabilityLevel)Utility.Random(6);
                    }

                    this.DropItem(item);
                }
                else if (item is BaseHat)
                {
                    BaseHat hat = (BaseHat)item;

                    if (Core.AOS)
                    {
                        int attributeCount;
                        int min, max;

                        GetRandomAOSStats(out attributeCount, out min, out max);

                        BaseRunicTool.ApplyAttributesTo(hat, attributeCount, min, max);
                    }

                    this.DropItem(item);
                }
                else if (item is BaseJewel)
                {
                    int attributeCount;
                    int min, max;

                    GetRandomAOSStats(out attributeCount, out min, out max);

                    BaseRunicTool.ApplyAttributesTo((BaseJewel)item, attributeCount, min, max);

                    this.DropItem(item);
                }
            }

            for (int i = 0; i < level; i++)
            {
                Item item = Loot.RandomPossibleReagent();
                item.Amount = Utility.RandomMinMax(40, 60);
                this.DropItem(item);
            }

            for (int i = 0; i < level; i++)
            {
                Item item = Loot.RandomGem();
                this.DropItem(item);
            }

            this.DropItem(new TreasureMap(level + 1, (Utility.RandomBool() ? Map.Felucca : Map.Trammel)));
            //  this.DropItem(new PowerScroll(), 120);  
            switch (Utility.Random(38))
            {
                case 0: DropItem(new PowerScroll(SkillName.Swords, 120)); break;
                case 1: DropItem(new PowerScroll(SkillName.Fencing, 120)); break;
                case 2: DropItem(new PowerScroll(SkillName.Archery, 120)); break;
                case 3: DropItem(new PowerScroll(SkillName.Parry, 120)); break;
                case 4: DropItem(new PowerScroll(SkillName.Tactics, 120)); break;
                case 5: DropItem(new PowerScroll(SkillName.Anatomy, 120)); break;
                case 6: DropItem(new PowerScroll(SkillName.Healing, 120)); break;
                case 7: DropItem(new PowerScroll(SkillName.Magery, 120)); break;
                case 8: DropItem(new PowerScroll(SkillName.Meditation, 120)); break;
                case 9: DropItem(new PowerScroll(SkillName.EvalInt, 120)); break;
                case 10: DropItem(new PowerScroll(SkillName.MagicResist, 120)); break;
                case 11: DropItem(new PowerScroll(SkillName.AnimalTaming, 120)); break;
                case 12: DropItem(new PowerScroll(SkillName.AnimalLore, 120)); break;
                case 13: DropItem(new PowerScroll(SkillName.Veterinary, 120)); break;
                case 14: DropItem(new PowerScroll(SkillName.Musicianship, 120)); break;
                case 15: DropItem(new PowerScroll(SkillName.Provocation, 120)); break;
                case 16: DropItem(new PowerScroll(SkillName.Discordance, 120)); break;
                case 17: DropItem(new PowerScroll(SkillName.Peacemaking, 120)); break;
                case 18: DropItem(new PowerScroll(SkillName.Chivalry, 120)); break;
                case 19: DropItem(new PowerScroll(SkillName.Focus, 120)); break;
                case 20: DropItem(new PowerScroll(SkillName.Necromancy, 120)); break;
                case 21: DropItem(new PowerScroll(SkillName.Stealing, 120)); break;
                case 22: DropItem(new PowerScroll(SkillName.Stealth, 120)); break;
                case 23: DropItem(new PowerScroll(SkillName.Macing, 120)); break;
                case 24: DropItem(new PowerScroll(SkillName.Wrestling, 120)); break;
                case 25: DropItem(new PowerScroll(SkillName.Blacksmith, 120)); break;
                case 26: DropItem(new PowerScroll(SkillName.Tailoring, 120)); break;
                case 27: DropItem(new PowerScroll(SkillName.Tinkering, 120)); break;
                case 28: DropItem(new PowerScroll(SkillName.Mining, 120)); break;
                case 29: DropItem(new PowerScroll(SkillName.Carpentry, 120)); break;
                case 30: DropItem(new PowerScroll(SkillName.Alchemy, 120)); break;
                case 31: DropItem(new PowerScroll(SkillName.Fletching, 120)); break;
                case 32: DropItem(new PowerScroll(SkillName.Inscribe, 120)); break;
                case 33: DropItem(new PowerScroll(SkillName.Cooking, 120)); break;
                case 34: DropItem(new PowerScroll(SkillName.Cartography, 120)); break;
                case 35: DropItem(new PowerScroll(SkillName.Lumberjacking, 120)); break;
                case 36: DropItem(new PowerScroll(SkillName.Lockpicking, 120)); break;
                case 37: DropItem(new PowerScroll(SkillName.Fishing, 120)); break;
            }

        }
    }
}