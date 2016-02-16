using System;
using Server;

namespace Server.Items
{
	public class AlchemistsProtector : Dagger
	{
		public override int LabelNumber{ get{ return 1070638; } }
		
		public override int InitMinHits{ get{ return 255; } }
		public override int InitMaxHits{ get{ return 255; } }

		[Constructable]
		public AlchemistsProtector()
		{
			Name = "Alchemists Protector";
			Hue = 0x290;
			SkillBonuses.SetValues( 0, SkillName.Magery, 10.0 );
			Attributes.LowerRegCost = 20;
			
			//Resistances.Poison = 10;
			//Attributes.RegenMana = 2;
			
			Attributes.BonusInt = 5;
			Attributes.LowerManaCost = 5;
			Attributes.SpellChanneling = 1;
		}

		public AlchemistsProtector( Serial serial ) : base( serial )
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