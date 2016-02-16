using System;
using Server;

namespace Server.Items
{
	public class BFPWestLS : BaseLight
	{
		public override int LitItemID{ get { return 0x937; } }
		public override int UnlitItemID{ get { return 0x935; } }
		
		[Constructable]
		public BFPWestLS() : base( 0x935 )
		{
			Movable = false;
			Duration = TimeSpan.Zero; // Never burnt out
			Burning = false;
			Light = LightType.Circle300;
			Weight = 200.0;
		}

		public BFPWestLS( Serial serial ) : base( serial )
		{
		}

		public override void Serialize( GenericWriter writer )
		{
			base.Serialize( writer );
			writer.Write( (int) 0 );
		}

		public override void Deserialize( GenericReader reader )
		{
			base.Deserialize( reader );
			int version = reader.ReadInt();
		}
	}

	public class BFPWestRS : BaseLight
	{
		public override int LitItemID{ get { return 0x93D; } }
		public override int UnlitItemID{ get { return 0x936; } }
		
		[Constructable]
		public BFPWestRS() : base( 0x936 )
		{
			Movable = false;
			Duration = TimeSpan.Zero; // Never burnt out
			Burning = false;
			Light = LightType.Circle300;
			Weight = 200.0;
		}

		public BFPWestRS( Serial serial ) : base( serial )
		{
		}

		public override void Serialize( GenericWriter writer )
		{
			base.Serialize( writer );
			writer.Write( (int) 0 );
		}

		public override void Deserialize( GenericReader reader )
		{
			base.Deserialize( reader );
			int version = reader.ReadInt();
		}
	}

	public class BFPNorthRS : BaseLight
	{
		public override int LitItemID{ get { return 0x945; } }
		public override int UnlitItemID{ get { return 0x943; } }
		
		[Constructable]
		public BFPNorthRS() : base( 0x943 )
		{
			Movable = false;
			Duration = TimeSpan.Zero; // Never burnt out
			Burning = false;
			Light = LightType.Circle300;
			Weight = 200.0;
		}

		public BFPNorthRS( Serial serial ) : base( serial )
		{
		}

		public override void Serialize( GenericWriter writer )
		{
			base.Serialize( writer );
			writer.Write( (int) 0 );
		}

		public override void Deserialize( GenericReader reader )
		{
			base.Deserialize( reader );
			int version = reader.ReadInt();
		}
	}

	public class BFPNorthLS : BaseLight
	{
		public override int LitItemID{ get { return 0x94B; } }
		public override int UnlitItemID{ get { return 0x944; } }
		
		[Constructable]
		public BFPNorthLS() : base( 0x944 )
		{
			Movable = false;
			Duration = TimeSpan.Zero; // Never burnt out
			Burning = false;
			Light = LightType.Circle300;
			Weight = 200.0;
		}

		public BFPNorthLS( Serial serial ) : base( serial )
		{
		}

		public override void Serialize( GenericWriter writer )
		{
			base.Serialize( writer );
			writer.Write( (int) 0 );
		}

		public override void Deserialize( GenericReader reader )
		{
			base.Deserialize( reader );
			int version = reader.ReadInt();
		}
	}

	public class SFPWestRS : BaseLight
	{
		public override int LitItemID{ get { return 0x959; } }
		public override int UnlitItemID{ get { return 0x952; } }
		
		[Constructable]
		public SFPWestRS() : base( 0x952 )
		{
			Movable = false;
			Duration = TimeSpan.Zero; // Never burnt out
			Burning = false;
			Light = LightType.Circle300;
			Weight = 200.0;
		}

		public SFPWestRS( Serial serial ) : base( serial )
		{
		}

		public override void Serialize( GenericWriter writer )
		{
			base.Serialize( writer );
			writer.Write( (int) 0 );
		}

		public override void Deserialize( GenericReader reader )
		{
			base.Deserialize( reader );
			int version = reader.ReadInt();
		}
	}

	public class SFPWestLS : BaseLight
	{
		public override int LitItemID{ get { return 0x953; } }
		public override int UnlitItemID{ get { return 0x951; } }
		
		[Constructable]
		public SFPWestLS() : base( 0x951 )
		{
			Movable = false;
			Duration = TimeSpan.Zero; // Never burnt out
			Burning = false;
			Light = LightType.Circle300;
			Weight = 200.0;
		}

		public SFPWestLS( Serial serial ) : base( serial )
		{
		}

		public override void Serialize( GenericWriter writer )
		{
			base.Serialize( writer );
			writer.Write( (int) 0 );
		}

		public override void Deserialize( GenericReader reader )
		{
			base.Deserialize( reader );
			int version = reader.ReadInt();
		}
	}

	public class SFPNorthRS : BaseLight
	{
		public override int LitItemID{ get { return 0x961; } }
		public override int UnlitItemID{ get { return 0x95F; } }
		
		[Constructable]
		public SFPNorthRS() : base( 0x95F )
		{
			Movable = false;
			Duration = TimeSpan.Zero; // Never burnt out
			Burning = false;
			Light = LightType.Circle300;
			Weight = 200.0;
		}

		public SFPNorthRS( Serial serial ) : base( serial )
		{
		}

		public override void Serialize( GenericWriter writer )
		{
			base.Serialize( writer );
			writer.Write( (int) 0 );
		}

		public override void Deserialize( GenericReader reader )
		{
			base.Deserialize( reader );
			int version = reader.ReadInt();
		}
	}

	public class SFPNorthLS : BaseLight
	{
		public override int LitItemID{ get { return 0x967; } }
		public override int UnlitItemID{ get { return 0x960; } }
		
		[Constructable]
		public SFPNorthLS() : base( 0x960 )
		{
			Movable = false;
			Duration = TimeSpan.Zero; // Never burnt out
			Burning = false;
			Light = LightType.Circle300;
			Weight = 200.0;
		}

		public SFPNorthLS( Serial serial ) : base( serial )
		{
		}

		public override void Serialize( GenericWriter writer )
		{
			base.Serialize( writer );
			writer.Write( (int) 0 );
		}

		public override void Deserialize( GenericReader reader )
		{
			base.Deserialize( reader );
			int version = reader.ReadInt();
		}
	}
}