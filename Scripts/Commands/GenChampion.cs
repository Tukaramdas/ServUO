using System;
using Server.Services.ChampionSystem;

namespace Server.Commands
{
    public class GenChampionSpawn
    {
        public static void Initialize()
        {
			CommandSystem.Register("GenChampions", AccessLevel.Administrator, new CommandEventHandler(Champ_OnCommand));
			CommandSystem.Register("DeleteChampions", AccessLevel.Administrator, new CommandEventHandler(DeleteChamp_OnCommand));
		}

		[Usage("GenChampions")]
		[Description("Install ChampionSpawnController at 1415 1695 0.")]
		public static void Champ_OnCommand(CommandEventArgs e)
		{
			throw new NotImplementedException();
		}

		[Usage("DeleteChampions")]
		[Description("Remove ChampionSpawnController")]
		public static void DeleteChamp_OnCommand(CommandEventArgs e)
		{
			WeakEntityCollection.Delete("champ");
		}
	}
}