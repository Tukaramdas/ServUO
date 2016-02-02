using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace Server.Services.ChampionSystem
{
	public class ChampionSystem
	{
		private static bool m_Enabled = false;
		private static bool m_Initialized = false;
		private static readonly string m_Path = Path.Combine("Saves", "Champions", "ChampionSystem.bin");
		private static DateTime m_LastRotate;
		private static TimeSpan m_RotateDelay;
		private static List<ChampionSpawn> m_AllSpawns = new List<ChampionSpawn>();
		private static List<ChampionSpawn> m_DungeonSpawns = new List<ChampionSpawn>();
		private static List<ChampionSpawn> m_LostLandsSpawns = new List<ChampionSpawn>();

		private static void Configure()
		{
			m_Enabled = Config.Get("Champions.Enabled", true);
			m_RotateDelay = Config.Get("Champions.RotateDelay", TimeSpan.FromDays(1.0d));
			EventSink.WorldLoad += EventSink_WorldLoad;
			EventSink.WorldSave += EventSink_WorldSave;
		}

		private static void EventSink_WorldSave(WorldSaveEventArgs e)
		{
			Persistence.Serialize(
				m_Path,
				writer =>
				{
					writer.Write(0); // Version
					writer.Write(m_Initialized);
					writer.Write(m_LastRotate);
					writer.WriteItemList(m_AllSpawns);
					writer.WriteItemList(m_DungeonSpawns);
					writer.WriteItemList(m_LostLandsSpawns);
				});
		}

		private static void EventSink_WorldLoad()
		{
			Persistence.Deserialize(
				m_Path,
				reader =>
				{
					int version = reader.ReadInt();
					m_Initialized = reader.ReadBool();
					m_LastRotate = reader.ReadDateTime();
					m_AllSpawns.AddRange(reader.ReadItemList().Cast<ChampionSpawn>());
					m_DungeonSpawns.AddRange(reader.ReadItemList().Cast<ChampionSpawn>());
					m_LostLandsSpawns.AddRange(reader.ReadItemList().Cast<ChampionSpawn>());
				});
		}

		private static void Initialize()
		{
			if (m_Initialized || !m_Enabled)
				return;

			m_LastRotate = DateTime.UtcNow;

			ChampionSpawn spawn;

			// Dungeon Spawns

			// Deceit
			spawn = new ChampionSpawn();
			spawn.PossibleTypes = new ChampionSpawnType[] { ChampionSpawnType.UnholyTerror };
			spawn.MoveToWorld(new Point3D(5178, 708, 20), Map.Felucca);
			m_DungeonSpawns.Add(spawn);
			m_AllSpawns.Add(spawn);

			// Despise
			spawn = new ChampionSpawn();
			spawn.PossibleTypes = new ChampionSpawnType[] { ChampionSpawnType.VerminHorde };
			spawn.MoveToWorld(new Point3D(5557, 824, 65), Map.Felucca);
			m_DungeonSpawns.Add(spawn);
			m_AllSpawns.Add(spawn);

			// Destard
			spawn = new ChampionSpawn();
			spawn.PossibleTypes = new ChampionSpawnType[] { ChampionSpawnType.ColdBlood };
			spawn.MoveToWorld(new Point3D(5259, 837, 61), Map.Felucca);
			m_DungeonSpawns.Add(spawn);
			m_AllSpawns.Add(spawn);

			// Fire
			spawn = new ChampionSpawn();
			spawn.PossibleTypes = new ChampionSpawnType[] { ChampionSpawnType.Abyss };
			spawn.MoveToWorld(new Point3D(5814, 1350, 2), Map.Felucca);
			m_DungeonSpawns.Add(spawn);
			m_AllSpawns.Add(spawn);

			// Terathan Keep
			spawn = new ChampionSpawn();
			spawn.PossibleTypes = new ChampionSpawnType[] { ChampionSpawnType.Arachnid };
			spawn.MoveToWorld(new Point3D(5190, 1605, 20), Map.Felucca);
			m_DungeonSpawns.Add(spawn);
			m_AllSpawns.Add(spawn);

			// Abyssal Lair
			spawn = new ChampionSpawn();
			spawn.PossibleTypes = new ChampionSpawnType[] { ChampionSpawnType.Terror };
			spawn.MoveToWorld(new Point3D(6995, 733, 76), Map.Felucca);
			m_DungeonSpawns.Add(spawn);
			m_AllSpawns.Add(spawn);

			// Primeval Lich
			spawn = new ChampionSpawn();
			spawn.PossibleTypes = new ChampionSpawnType[] { ChampionSpawnType.Infuse };
			spawn.MoveToWorld(new Point3D(7000, 1004, 5), Map.Felucca);
			m_DungeonSpawns.Add(spawn);
			m_AllSpawns.Add(spawn);

			m_Initialized = true;
		}
	}
}
