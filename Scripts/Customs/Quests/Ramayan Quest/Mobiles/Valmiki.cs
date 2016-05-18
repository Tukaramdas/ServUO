//=================================================
//This script was created by Gizmo's Uo Quest Maker
//This script was created on 5/15/2016 09:30:21
//=================================================
using System;
using Server;
using Server.Items;
using Server.Mobiles;
using System.Collections;
using System.Collections.Generic;

namespace Server.Engines.Quests
{
	public class Valmiki : MondainQuester
	{
        //private ArrayList m_SBInfos = new ArrayList();
        //protected override ArrayList SBInfos { get { return m_SBInfos; } }
        private readonly List<SBInfo> m_SBInfos = new List<SBInfo>();

        public override Type[] Quests
		{
			get{ return new Type[]
			{
				typeof( Ramayan )
			};}
		}

		[Constructable]
		public Valmiki() : base("Valmiki", "The Storyteller")
		{
			InitBody();
		}
		public Valmiki(Serial serial) : base(serial)
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
			AddItem( new Robe() );
			AddItem( new Sandals() );
		}


    }


}

