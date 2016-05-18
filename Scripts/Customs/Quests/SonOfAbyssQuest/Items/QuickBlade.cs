/////////// Scripted By TALON NYTE ///////////

using System;
using Server;
using Server.Misc; // for ColorCycling

namespace Server.Items
{ 
	public class QuickBlade: Katana
	{
		
		public override int ArtifactRarity{ get{ return 40; } }
                public override int InitMinHits{ get{ return 255; } }
		public override int InitMaxHits{ get{ return 255; } }
                
		public override int AosStrengthReq{ get{ return 25; } }
		public override int AosMinDamage{ get{ return 20; } }
		public override int AosMaxDamage{ get{ return 40; } }
		public override int AosSpeed{ get{ return 40; } }

		public override int OldStrengthReq{ get{ return 10; } }
		public override int OldMinDamage{ get{ return 10; } }
		public override int OldMaxDamage{ get{ return 15; } }
		public override int OldSpeed{ get{ return 20; } }

		public override int DefHitSound{ get{ return 0x23B; } }
		public override int DefMissSound{ get{ return 0x23A; } }
	
	

		[Constructable]
		public QuickBlade()

		{
                        Name = "QuickBlade";
                        //ColorCycling.Add(this,1140,1177,TimeSpan.FromSeconds(0.3),CCType.ForwardLoop);
			//Hue = 0x76D;
            WeaponAttributes.SelfRepair = 5;
            WeaponAttributes.HitLightning = 35;
            WeaponAttributes.HitHarm = 20;
			WeaponAttributes.HitLeechStam = 25;
            WeaponAttributes.HitPoisonArea = 45;
            Attributes.Luck = 150;
			Attributes.WeaponSpeed = 40;
			Attributes.WeaponDamage = 50;
			Attributes.SpellChanneling = 1;
			Attributes.CastSpeed = 2;
            Attributes.CastRecovery = 3;
            LootType = LootType.Blessed;
		}

		public QuickBlade( Serial serial ) : base( serial )
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
                        //ColorCycling.Add(this,1140,1177,TimeSpan.FromSeconds(0.1),CCType.ForwardLoop); 
			int version = reader.ReadInt();
		}
	}
}