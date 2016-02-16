using System;
using Server;
using Server.Gumps;

namespace Server.Gumps
{
	public class AlecsanderFinishGump : Gump
	{
		public AlecsanderFinishGump()
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
			this.AddLabel(48, 39, 255, @"Ah! Many thanks, my friend! Here, as I said,");
			this.AddLabel(48, 55, 255, @"an heirloom that's been in my family for");
			this.AddLabel(48, 71, 255, @"generations. Now to find Elain!");
//			this.AddItem(12, 38, 4171);

		}
		

	}
}
