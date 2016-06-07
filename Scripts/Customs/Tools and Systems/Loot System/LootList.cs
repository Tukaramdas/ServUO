using System;
using System.Reflection;
using System.IO;
using Server;
using Server.Items;

using Server.Gumps;
using Server.Network;
using Server.Mobiles;
using Server.Commands;
using Server.Prompts;
using Server.Targeting;


namespace Server
{
	public class ArtifactList
	{
		static int index;
		static Type type;

		public static Type[] ArtifactTypes = new Type[]
        {
            typeof( SuperSlayerDeeds ),typeof( LesserSlayerDeed ),typeof( SlayerRemovalDeed ),typeof( RAD ),
            typeof(ArtifactDeed),typeof(RandomArtifactDeed),typeof(AllDyeTubsAll),typeof(MinorArtifactDeed)

            /*
 typeof( SquirrelStatue ),typeof( SnowLeopardStatue ),typeof( SilverbackGorillaStatue ),typeof( SilverWolfStatue ),
 typeof( RuneBeetleStatue ),typeof( SeaHorseStatue ),typeof( TimberWolfStatue ),typeof( VampireBatStatue ),
 typeof( HellcatStatue ),typeof( HellHoundStatue ),typeof( NightmareStatue ),typeof( PantherStatue ),
 typeof( GiantSilverSnakeStatue ),typeof( GiantSnakeStatue ),typeof( GiantSpiderStatue ),typeof( GrayWolfStatue ),
 typeof( GiantFrogStatue ),typeof( GiantIceSnakeStatue ),typeof( GiantLavaSnakeStatue ),typeof( GiantScorpionStatue ),
 typeof( DogHoundStatue ),typeof( DreadSpiderStatue ),typeof( FerretStatue ),typeof( FrostSpiderStatue ),
 typeof( BillyGoatStatue ),typeof( BlackWidowSpiderStatue ),typeof( CougarStatue ),typeof( DireWolfStatue ),
 typeof( PoisonElementalStatue ),typeof( SandVortexStatue ),typeof( SnowElementalStatue ),typeof( WaterElementalStatue ),
 typeof( AcidElementalStatue ),typeof( BloodElementalStatue ),typeof( FireElementalStatue ),typeof( IceElementalStatue ),
 typeof( SkeletonStatue ),typeof( ZombieStatue ),typeof( LordBlackthornStatue ),typeof( EvilMageStatue ),
 typeof( MummyStatue ),typeof( RottingCorpseStatue ),typeof( SkeletonKnightStatue ),typeof( SkeletonMageStatue ),
 typeof( GhoulStatue ),typeof( HeadlessStatue ),typeof( LicheLordStatue ),typeof( LicheStatue ),
 typeof( TerathanWarriorStatue ),typeof( TitanStatue ),typeof( WyvernStatue ),typeof( GhostStatue ),
 typeof( SwampTentaclesStatue ),typeof( TerathanAvengerStatue ),typeof( TerathanDroneStatue ),typeof( TerathanQueenStatue ),
 typeof( SolenWarriorStatue ),typeof( SolenWorkerStatue ),typeof( StoneGargoyleStatue ),typeof( StoneHarpyStatue ),
 typeof( OrcStatue ),typeof( RatmanStatue ),typeof( SlimeStatue ),typeof( SolenQueenStatue ),
 typeof( OphidianWarriorStatue ),typeof( OrcCaptainStatue ),typeof( OrcLordStatue ),typeof( OrcShamanStatue ),
 typeof( OphidianArchmageStatue ),typeof( OphidianKnightStatue ),typeof( OphidianMageStatue ),typeof( OphidianQueenStatue ),
 typeof( ElderDaemonStatue ),typeof( KrakenStatue ),typeof( MongbatStatue ),typeof( OgreLordStatue ),
 typeof( DragonStatue ),typeof( GazerStatue ),typeof( IceFiendDaemonStatue ),typeof( ImpStatue ),
 typeof( CorpserStatue ),typeof( CyclopsStatue ),typeof( DaemonStatue )
 */
            /*
		//Paragon
			typeof( ), 
			typeof( ),

		//ToTArti
			typeof( ),  
			typeof( ),		

		//Gargish
			typeof( ),
			typeof( ),

		//Armors
			typeof( ),
			typeof( ),

		//Jewels
			typeof( ),
			typeof( ),
	
		//Shields
			typeof( ),
			typeof( ),
			
			
		//Weapons
			typeof( ),
			typeof( ),	
			
		//Bows
			typeof( ),
			typeof( ),
			
		//Clothing	
			typeof( ),
			typeof( ),
			
		//Robes	
			typeof( ),
			typeof( ),
			
		//Other 
			typeof( ),
			typeof( )
*/
		};
		public static Type[] Artifacts{ get{ return ArtifactTypes; } }

		public static Item RandomArtifact()
		{
			index = Utility.Random( ArtifactTypes.Length );
			type = ArtifactTypes[index];
			return Activator.CreateInstance( type )as Item;
		}
	}
}


