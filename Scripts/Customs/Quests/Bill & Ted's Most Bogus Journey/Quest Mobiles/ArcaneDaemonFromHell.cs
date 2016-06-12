using System;
using Server.Items;

namespace Server.Mobiles

{
    [CorpseName(" corpse of a ArcaneDaemonFromHell")]
    public class ArcaneDaemonFromHell : ArcaneDaemon
    {
        [Constructable]
        public ArcaneDaemonFromHell() : base()
        {
            Name = "ArcaneDaemon";
            Title = "of B&T's Most Excelent Adventure";
            Hue = 0;
            //Body = ; // Uncomment these lines and input values
            //BaseSoundID = ; // To use your own custom body and sound.

            SetStr(380);
            SetDex(110);
            SetInt(100);

            SetHits(800);
            SetDamage(12, 25);

            SetDamageType(ResistanceType.Physical, 40);

            SetSkill(SkillName.MagicResist, 100.0);
            SetSkill(SkillName.Tactics, 87.0);
            SetSkill(SkillName.Wrestling, 40.0);
            SetSkill(SkillName.DetectHidden, 60);

            SetResistance(ResistanceType.Physical, 50, 60);
            SetResistance(ResistanceType.Fire, 44, 50);
            SetResistance(ResistanceType.Cold, 35, 40);
            SetResistance(ResistanceType.Poison, 25, 30);
            SetResistance(ResistanceType.Energy, 15, 20);

            Fame = 24000;
            Karma = -24000;

            VirtualArmor = 30;

            PackGold(2000);
            PackItem(new Longsword());
            PackItem(new HellKey2());

        }
        public override bool HasBreath { get { return true; } }
     //   public override Poison HitPoison { get { return Poison.Greater; } }
        public override bool AlwaysMurderer { get { return true; } }

        public ArcaneDaemonFromHell(Serial serial) : base(serial)
        {
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
