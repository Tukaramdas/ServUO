using System;
using Server.Items;

namespace Server.Items
{
	public class FunkyMushroom : Item
	{
		[Constructable]
		public FunkyMushroom() : base( 0xD18 )
        {
         Movable = true; 
         Hue = 0; 
         Name = "A strange looking mushroom";
         LootType = LootType.Blessed; 
      } 


      public FunkyMushroom( Serial serial ) : base( serial ) 
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



      public override void OnDoubleClick( Mobile from ) 
      	{ 
         	if ( !from.InRange( GetWorldLocation(), 2 ) ) 
        	{ 
            		from.SendLocalizedMessage( 500446 ); // That is too far away. 
         	} 
         	else 
		{
			if ( from.Mounted == true )
			{
				from.SendLocalizedMessage( 1042561 );
			}

			else
         		{ 
           		 	if ( from.BodyValue == 0x190 ) 
           			{ 
              				from.BodyMod = 0x191; 
               		//		from.HueMod = 0x0; 
               				from.PlaySound( 61 );
					from.PlaySound( 813 );
				//	this.Delete();
            			} 
           			else 
            			{  
                  			from.BodyMod = 0x190;
				  //      	from.HueMod = 0x0; 
                  			from.PlaySound( 61 );
					from.PlaySound( 1087 );
				//	this.Delete();
				}
  			}
		} 
	} 
 
	}
}	