#define USE_TOKENS
using System; 
using Server; 
using Server.Gumps; 
using Server.Network; 
using Server.Menus; 
using Server.Menus.Questions; 
using Server.Mobiles; 
using System.Collections; 

namespace Daat99MasterLooterSystem
{ 
   	public class MasterLooterTokenLedgerDeed : Item 
   	{ 
      	[Constructable] 
      	public MasterLooterTokenLedgerDeed() : base( 0x14F0 ) 
      	{ 
			Weight = 1.0;  
        	Movable = true;
        	Name="Master Looter Token Ledger deed";   
      	}

      	public MasterLooterTokenLedgerDeed( Serial serial ) : base( serial ) {  } 
		
		public override void OnDoubleClick( Mobile from ) 
      	{
			if ( !IsChildOf( from.Backpack ) )
				from.SendLocalizedMessage( 1042001 ); // That must be in your pack for you to use it.
			else
			{
				MasterLooterBackpack backpack = Daat99MasterLootersUtils.GetMasterLooter(from as PlayerMobile);
				if ( backpack == null )
					from.SendMessage("You must have your Master Looter in your backpack!");
				else if ( backpack.TokenLedger )
					from.SendMessage("You already have token ledger enabled on your master looter backpack.");
				else if ( !this.Deleted && !backpack.Deleted )
				{
					backpack.TokenLedger = true;
					this.Delete();
					from.SendMessage("You enabled the token ledger on your master looter backpack.");
				}
			}
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