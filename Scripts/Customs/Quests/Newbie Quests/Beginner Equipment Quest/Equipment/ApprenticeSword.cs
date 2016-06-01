using Server;
using System;
using Server.Items;

namespace Server.Items
{
	public class ApprenticeSword : Katana
	{ 
				
		public override int InitMinHits{ get{ return 150; } }
		public override int InitMaxHits{ get{ return 150; } }

        public override int AosMinDamage { get { return 20; } }
        public override int AosMaxDamage { get { return 25; } }
        public override int AosSpeed { get { return 56; } }

        public override int OldStrengthReq { get { return 10; } }
        public override int OldMinDamage { get { return 20; } }
        public override int OldMaxDamage { get { return 25; } }
        public override int OldSpeed { get { return 68; } }

        [Constructable]
		public ApprenticeSword()
		{
			Hue = 57;
			Name = "Apprentice Sword";
			Weight = 10;

            WeaponAttributes.UseBestSkill = 1;
			Attributes.SpellChanneling = 1;
			Attributes.WeaponDamage = 35;
			Attributes.WeaponSpeed = 20;
			Attributes.Luck = 50;
            Slayer = SlayerName.Silver;

			LootType = LootType.Blessed;
			
		} 
		
		public ApprenticeSword( Serial serial ) : base( serial )
		{
		}

		public override void Serialize( GenericWriter writer )
		{
			base.Serialize( writer );

			writer.Write( (int) 0 );
		}

		public override void Deserialize(GenericReader reader)
		{
			base.Deserialize( reader );

			int version = reader.ReadInt();

		}
	}
}
