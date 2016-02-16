using System;
using Server;
using Server.Gumps;

namespace Server.Gumps
{
	public class AcarasFinishGump : Gump
	{
		public AcarasFinishGump()
			: base( 200, 200 )
		{
			this.Closable=true;
			this.Disposable=true;
			this.Dragable=true;
			this.Resizable=false;
			this.AddPage(0);
			this.AddBackground(0, 0, 353, 118, 9270);
			this.AddAlphaRegion( 2, 2, 349, 114 );
//			this.AddItem(297, 38, 4168);
			this.AddLabel(118, 15, 1149, @"The Fair Elain");
			this.AddLabel(48, 39, 255, @"Perfect fit! Brings out my eyes! Yes, the");
			this.AddLabel(48, 55, 255, @"ring. Take it. It's not worth the fake gold");
			this.AddLabel(48, 71, 255, @"it was made with, if you ask me...");
//			this.AddItem(12, 38, 4171);

		}
		

	}
}
