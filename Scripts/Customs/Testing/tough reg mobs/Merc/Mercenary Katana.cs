using System;
using Server;

namespace Server.Items
{ 
	public class MercenaryKatana: Katana
	{
		public override int LabelNumber{ get{ return 1061099; } } // Mercenary Katana
		
        	//public override int InitMinHits{ get{ return 6600; } }
		//public override int InitMaxHits{ get{ return 6600; } }
                
		public override int AosMinDamage{ get{ return 11; } }
		public override int AosMaxDamage{ get{ return 17; } }
		public override int AosSpeed{ get{ return 46; } }
		public override float MlSpeed{ get{ return 2.25f; } }

		public override int OldStrengthReq{ get{ return 10; } }
		public override int OldMinDamage{ get{ return 5; } }
		public override int OldMaxDamage{ get{ return 26; } }
		public override int OldSpeed{ get{ return 58; } }

		public override int DefHitSound{ get{ return 0x23B; } }
		public override int DefMissSound{ get{ return 0x23A; } }
	
	

		[Constructable]
		public MercenaryKatana()

		{
                        Name = "Mercenary Katana";
			Hue = 0x497;

			Attributes.AttackChance = 15;
			//Attributes.BonusStr = 6;
			Attributes.WeaponDamage = 60;
			Attributes.WeaponSpeed = 35;
			//Attributes.Luck = 120;
			Attributes.SpellChanneling = 1;
			WeaponAttributes.HitFireball = 47;
			WeaponAttributes.HitHarm = 30;
			WeaponAttributes.HitLeechHits = 43;
			WeaponAttributes.HitLowerDefend = 25;
			
		}

		public MercenaryKatana( Serial serial ) : base( serial )
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
