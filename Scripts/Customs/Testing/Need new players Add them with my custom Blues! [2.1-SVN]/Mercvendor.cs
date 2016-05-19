using System;
using System.Collections;
using System.Collections.Generic;
using Server;
using Server.ContextMenus;
using Server.Gumps;
using Server.Items;
using Server.Network;
using Server.Targeting;


namespace Server.Mobiles
{
	public class Mercvendor : BaseVendor
	{
		private List<SBInfo> m_SBInfos = new List<SBInfo>();
		protected override List<SBInfo> SBInfos{ get { return m_SBInfos; } }

		[Constructable]
		public Mercvendor() : base( "The GuildMaster" )
		{
			SetSkill( SkillName.ArmsLore, 64.0, 100.0 );
			SetSkill( SkillName.Anatomy, 90.0, 100.0 );
			
		}

		public override void InitSBInfo()
		{
			m_SBInfos.Add( new SBMercvendor() );
		}

		public override VendorShoeType ShoeType
		{
			get{ return Female ? VendorShoeType.ThighBoots : VendorShoeType.Boots; }
		}

		public override int GetShoeHue()
		{
			return 0;
		}

		public override void InitOutfit()
		{
			base.InitOutfit();
                           	 Item Robe =  new Robe( );			
                        	Robe.Name = "Britania Electric Co.";
                        	Robe.Movable = false; 
				Robe.Hue = 1109;
				AddItem( Robe );

			AddItem( Utility.RandomBool() ? (Item)new Longsword() : (Item)new Halberd() );
			AddItem( new Server.Items.PlateGloves() );
			AddItem( new Server.Items.PlateLegs() );
			AddItem( new Server.Items.PlateChest() );
			AddItem( new Server.Items.PlateArms() );
                        AddItem( new Server.Items.PlateGorget() );
		}


		public Mercvendor( Serial serial ) : base( serial )
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