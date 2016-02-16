using System;
using Server;
using Server.Network;
using Server.Misc;

namespace Server.Items
{
	[FlipableAttribute( 0x1515, 0x1530 )] 
	public class CloakOfInvisibility : Cloak 
	{ 

		
		[Constructable] 
		public CloakOfInvisibility() : base( 0x309 ) 
		{ 
			Name = "Cloak of Invisibility";
			Hue = 0x29B; 
		} 

		public override bool OnEquip( Mobile m ) 
		{ 
			m.Hidden = true;
			return true;
		} 

		public override bool Dye( Mobile from, DyeTub sender )
		{
			from.SendLocalizedMessage( 1042083 ); // You can not dye that.
			return false;
		}

		public override void OnRemoved( object parent ) 
		{ 
			if ( parent is Mobile ) 
			{ 
				Mobile m = (Mobile)parent;
				m.Hidden = false;
			} 
		} 

		public override void OnSingleClick( Mobile from ) 
		{ 
			this.LabelTo( from, Name ); 
		} 

		public CloakOfInvisibility( Serial serial ) : base( serial ) 
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
