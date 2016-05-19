//=================================================
//This script was created by Gizmo's Uo Quest Maker
//This script was created on 8/30/2008 4:22:54 AM
//=================================================
using System;
using Server;
using Server.Items;
using Server.Mobiles;
using System.Collections;
using System.Collections.Generic;

namespace Server.Engines.Quests
{
	public class Veronica : MondainQuester
	{
        //private ArrayList m_SBInfos = new ArrayList();
        //protected override ArrayList SBInfos { get { return m_SBInfos; } }
        private readonly List<SBInfo> m_SBInfos = new List<SBInfo>();

        public override bool IsActiveVendor { get { return true; } }

		public override Type[] Quests
		{
			get{ return new Type[]
			{
				typeof( IntotheDarkness )
			};}
		}

		[Constructable]
		public Veronica() : base("Veronica", "The Provisioner")
		{
			InitBody();
		}
		public override void InitSBInfo()
		{
			m_SBInfos.Add(new SBProvisioner());
		}

		public Veronica(Serial serial) : base(serial)
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
			Female = true;
			Race = Race.Human;
			base.InitBody();
		}
		public override void InitOutfit()
		{
			FloppyHat head = new FloppyHat();
			head.Hue = 1175;
			AddItem( head );
			PlainDress chest = new PlainDress();
			chest.Hue = 1175;
			AddItem( chest );
			AddItem( new GoldNecklace() );
			Spellbook lefthand = new Spellbook();
			lefthand.Hue = 1217;
			AddItem( lefthand );
			Sandals feet = new Sandals();
			feet.Hue = 1175;
			AddItem( feet );
		}
	}
}
