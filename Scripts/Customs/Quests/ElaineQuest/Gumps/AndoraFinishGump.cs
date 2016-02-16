using System;
using Server;
using Server.Gumps;

namespace Server.Gumps
{
	public class AndoraFinishGump : Gump
	{
		public AndoraFinishGump()
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
			this.AddLabel(48, 39, 255, @"Yes, the ring. I can't give up my best");
			this.AddLabel(48, 55, 255, @"blade, though. Take this book to Vacar. He");
			this.AddLabel(48, 71, 255, @"should find it to his liking and help you.");
//			this.AddItem(12, 38, 4171);

		}
		

	}
}
