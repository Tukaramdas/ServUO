using System;
using Server;
using Server.Gumps;

namespace Server.Gumps
{
	public class VacarJamesFinishGump : Gump
	{
		public VacarJamesFinishGump()
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
			this.AddLabel(48, 39, 255, @"What's this? Oh heavens! New material!");
			this.AddLabel(48, 55, 255, @"This is great! Here, you can have the");
			this.AddLabel(48, 71, 255, @"letter and give it to who you want.");
//			this.AddItem(12, 38, 4171);

		}
		

	}
}
