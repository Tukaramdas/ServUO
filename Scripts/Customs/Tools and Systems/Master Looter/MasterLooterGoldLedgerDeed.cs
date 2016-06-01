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
   	public class MasterLooterGoldLedgerDeed : Item 
   	{ 
      	[Constructable] 
      	public MasterLooterGoldLedgerDeed() : base( 0x14F0 ) 
      	{ 
			Weight = 1.0;  
        	Movable = true;
        	Name="Master Looter Gold Ledger deed";   
      	}

      	public MasterLooterGoldLedgerDeed( Serial serial ) : base( serial ) {  } 
		
		public override void OnDoubleClick( Mobile from ) 
      	{
			if ( !IsChildOf( from.Backpack ) )
				from.SendLocalizedMessage( 1042001 ); // That must be in your pack for you to use it.
			else
			{
				MasterLooterBackpack backpack = Daat99MasterLootersUtils.GetMasterLooter(from as PlayerMobile);
				if ( backpack == null )
					from.SendMessage("You must have your Master Looter in your backpack!");
				else if ( backpack.GoldLedger )
					from.SendMessage("You already have gold ledger enabled on your master looter backpack.");
				else if ( !this.Deleted && !backpack.Deleted )
				{
					backpack.GoldLedger = true;
					this.Delete();
					from.SendMessage("You enabled the gold ledger on your master looter backpack.");
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
