//Creator Warloxx with EditPlus 3
using System;
using Server.Network;
using Server.Items;
using Server.Mobiles;

namespace Server.Items
{
	public class HalloweenCostumeEight : Item
	{
		int bodyadjust = 0;

		[Constructable]
		public HalloweenCostumeEight() : base( 0xF13 )
		{
			Movable = true;
			Name = "Mummy Gem";
		}

		public HalloweenCostumeEight(Serial serial) : base(serial){}
		public override void Serialize( GenericWriter writer ) {base.Serialize( writer ); writer.Write( (int) 0 );}
		public override void Deserialize( GenericReader reader ) { base.Deserialize( reader ); int version = reader.ReadInt();}

		public override void OnDoubleClick( Mobile from )
		{
			if ( !( IsChildOf( from.Backpack ) ) ) from.SendMessage( "That has to be in your pack to be able to use it" );
			else if ( from.Mounted ) from.SendMessage( "You can not use this while riding" );
			else if ( bodyadjust != from.BodyMod && from.BodyMod != 0 ) from.SendMessage( "You can not use this while all ready morphed" );
			else
			{
				if ( bodyadjust == 0 && (from.BodyValue == 0x190 || from.BodyValue == 0x191 || from.BodyValue == 605 || from.BodyValue == 606 ))
				{
					from.BodyMod = 154;
					bodyadjust = from.BodyMod;
					from.PlaySound( 1105 );
				  	Effects.SendLocationParticles( EffectItem.Create( from.Location, from.Map, EffectItem.DefaultDuration ), 0x376A, 1, 29, 0x47D, 2, 9962, 0 );
				  	Effects.SendLocationParticles( EffectItem.Create( new Point3D( from.X, from.Y, from.Z - 7 ), from.Map, EffectItem.DefaultDuration ), 0x37C4, 1, 29, 0x47D, 2, 9502, 0 );

				}
				else if(bodyadjust == from.BodyMod)
				{
					from.BodyMod = 0;
					bodyadjust = from.BodyMod;
					from.PlaySound( 1105 );
					Effects.SendLocationParticles( EffectItem.Create( from.Location, from.Map, EffectItem.DefaultDuration ), 0x376A, 1, 29, 0x47D, 2, 9962, 0 );
					Effects.SendLocationParticles( EffectItem.Create( new Point3D( from.X, from.Y, from.Z - 7 ), from.Map, EffectItem.DefaultDuration ), 0x37C4, 1, 29, 0x47D, 2, 9502, 0 );
					
					this.Delete(); 
				}
				else bodyadjust = 0;
			}
		}
	}
}