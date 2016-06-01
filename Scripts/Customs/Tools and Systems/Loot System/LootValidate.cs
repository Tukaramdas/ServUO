using System;
using System.Collections;
using Server.Items;
using Server.Misc;
using Server;
using Server.Gumps;

namespace Server.Mobiles
{
	public class ArtifactValidate
	{
		private static int multip = 1;
		private static float percent = 0;

		public static void ArtiChance(Mobile m, BaseCreature bc)
		{
			int karma = Math.Abs( bc.Karma );
			int fame = bc.Fame;
			int hits = bc.HitsMax;
			int stam = bc.StamMax;
			int mana = bc.ManaMax;

			float artichance = multip*( 20*(hits+stam+mana) / 1500);  //Original was 5500 (1,000 is 13% Fan Dancer, 15% Demons)(800 is 15% Fan Dancers, 17% Demons, 26% Dragon)
            			
			if( artichance > 100 )  // original was >
			artichance = 100;
			artichance -= 0;
			if( artichance < 0 )
			artichance = 100;    //Original was 0          
			percent = artichance/100;
			m.SendMessage( "You have a {0}% chance of receiving a bonus loot item from this creature.", percent*100);

		}
		public static void GiveArtifact(BaseCreature bc)
		{

//**Begin Artifact Randomness**\\
			if ( percent > Utility.RandomDouble() ) // 0.7 = 70% = chance to drop

			bc.PackItem(ArtifactList.RandomArtifact());
			
		}
		public static void MultiP(int size)
		{
			multip = size;
		}
	}
}
