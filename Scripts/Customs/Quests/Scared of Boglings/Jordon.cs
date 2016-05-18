//=================================================
//This script was created by Gizmo's Uo Quest Maker
//This script was created on 5/14/2016 20:24:59
//=================================================
using System;
using Server;
using Server.Items;
using Server.Mobiles;
using System.Collections;
using System.Collections.Generic;

namespace Server.Engines.Quests
{
	public class Jordon : MondainQuester
	{
        //private ArrayList m_SBInfos = new ArrayList();
        //protected override ArrayList SBInfos { get { return m_SBInfos; } }
        private readonly List<SBInfo> m_SBInfos = new List<SBInfo>();

        public override bool IsActiveVendor { get { return true; } }

		public override Type[] Quests
		{
			get{ return new Type[]
			{
				typeof( Tooscaredtoexplore )
			};}
		}

		[Constructable]
		public Jordon() : base("Jordon", "Quest GIver")
		{
			InitBody();
		}
		public override void InitSBInfo()
		{
			m_SBInfos.Add(new SBCobbler());
		}

		public Jordon(Serial serial) : base(serial)
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

		public override void InitBody()
		{
			InitStats(100, 100, 100);
			Female = false;
			Race = Race.Human;
			base.InitBody();
		}
		public override void InitOutfit()
		{
			AddItem( new Shirt() );
			AddItem( new LongPants() );
			AddItem( new Dagger() );
			AddItem( new Boots() );
		}
	}
}
