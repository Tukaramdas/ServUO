
using System;
using Server;

namespace Server.Items
{
	public class EmberBlade : VikingSword
	{
		public override int ArtifactRarity{ get{ return 45; } }
	
		private LightSource light;
		public override int InitMinHits{ get{ return 255; } }
		public override int InitMaxHits{ get{ return 255; } }

		[Constructable]
		public EmberBlade()
		{
			
			
			Name = "The Ember Blade";
			Weight = 7.0;
			Hue = 1493;
			//Hue = 2502;
			Light = LightType.Circle300;
			Slayer = SlayerName.Silver;
			Attributes.WeaponSpeed = 10;
			Attributes.WeaponDamage = 15;
			WeaponAttributes.UseBestSkill = 1;
			WeaponAttributes.HitFireball = 25;
			
				
		}

		public override void GetDamageTypes( Mobile wielder, out int phys, out int fire, out int cold, out int pois, out int nrgy, out int direct, out int chaos )
		{
			fire = 100;
			cold = phys = pois = nrgy = direct = chaos = 0;
		}

		public EmberBlade( Serial serial ) : base( serial )
		{
		}
		public override void OnRemoved( object parent )
		{
			if( light != null && parent is Mobile )
			{
				light.Delete();
			}
			base.OnRemoved( parent );
		}


		public override void Serialize( GenericWriter writer )
		{
			base.Serialize( writer );
			writer.Write( (int) 0 );
			writer.Write( light );

		}
		
		public override void Deserialize(GenericReader reader)
		{
			base.Deserialize( reader );
			int version = reader.ReadInt();
			light = reader.ReadItem() as LightSource;

		}
	}
}