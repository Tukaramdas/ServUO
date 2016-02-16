using System;
using Server.Network;
using Server.Items;

namespace Server.Items
{
	[FlipableAttribute( 0x27A6, 0x27F1 )]
	public class OrcTetsubo : BaseBashing
	{
		public override WeaponAbility PrimaryAbility{ get{ return WeaponAbility.WhirlwindAttack; } }
		public override WeaponAbility SecondaryAbility{ get{ return WeaponAbility.ArmorIgnore; } }

		public override int AosStrengthReq{ get{ return 120; } }
		public override int AosMinDamage{ get{ return 55; } }
		public override int AosMaxDamage{ get{ return 60; } }
		public override int AosSpeed{ get{ return 45; } }

		public override int OldStrengthReq{ get{ return 120; } }
		public override int OldMinDamage{ get{ return 55; } }
		public override int OldMaxDamage{ get{ return 60; } }
		public override int OldSpeed{ get{ return 45; } }

		public override int DefHitSound{ get{ return 0x233; } }
		public override int DefMissSound{ get{ return 0x238; } }

		public override int InitMinHits{ get{ return 60; } }
		public override int InitMaxHits{ get{ return 65; } }

		public override WeaponAnimation DefAnimation{ get{ return WeaponAnimation.Bash2H; } }

		[Constructable]
		public OrcTetsubo() : base( 0x27A6 )
		{
                        Name = "Orcbat";
			Weight = 8.0;
			Layer = Layer.TwoHanded;
		}

		public OrcTetsubo( Serial serial ) : base( serial )
		{
		}

		public override void Serialize( GenericWriter writer )
		{
			base.Serialize( writer );

			writer.Write( (int) 0 ); // version
		}

		public override void Deserialize( GenericReader reader )
		{
			base.Deserialize( reader );

			int version = reader.ReadInt();
		}
	}
}