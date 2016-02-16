using System;
using Server;

namespace Server.Items
{
	public class MagesRazor : WarCleaver
	{
		public override int ArtifactRarity{ get{ return 75; } }
		
		public override int InitMinHits{ get{ return 255; } }
		public override int InitMaxHits{ get{ return 255; } }

		[Constructable]
		public MagesRazor()
		{
			
			
			Name = "Mages Razor";
			Weight = 5.0;
			Hue = 1792;
			WeaponAttributes.HitLeechMana = 45;
			Attributes.WeaponSpeed = 20;
			Attributes.SpellChanneling = 1;
			WeaponAttributes.UseBestSkill = 1;
			Slayer = SlayerName.Fey;	
		}

		public override void GetDamageTypes( Mobile wielder, out int phys, out int fire, out int cold, out int pois, out int nrgy, out int direct, out int chaos )
		{
			nrgy = chaos = 50;
			cold = phys = pois = fire = direct = 0;
		}

		public MagesRazor( Serial serial ) : base( serial )
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