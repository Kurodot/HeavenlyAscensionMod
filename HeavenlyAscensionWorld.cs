using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.GameContent.Generation;
using Terraria.World.Generation;
using System.Collections.Generic;
using System;
using Terraria.ModLoader.IO;
using System.IO;


namespace HeavenlyAscension
{
	public class HeavenlyAscensionWorld : ModWorld
	{
		public static int biomeTiles = 0;
		public override void ModifyWorldGenTasks(List<GenPass> tasks, ref float totalWeight)
		{
			int ShiniesIndex = tasks.FindIndex(genpass => genpass.Name.Equals("Shinies"));
			if(ShiniesIndex != -1)
			{
				tasks.Insert(ShiniesIndex + 1, new PassLegacy("Chalk being marked", delegate (GenerationProgress progress)
				{
					progress.Message = "Marking the world with chalk";
					for(int i = 0; i < (int)((double)(Main.maxTilesX * Main.maxTilesY) * 6E-05); i++)
					{
						WorldGen.TileRunner(
							WorldGen.genRand.Next(0, Main.maxTilesX),
							WorldGen.genRand.Next((int)WorldGen.worldSurfaceLow, Main.maxTilesY),
							(double)WorldGen.genRand.Next(6, 12),
							WorldGen.genRand.Next(4, 12),
							mod.TileType("ChalkTile"),
							false,
							0f,
							0f,
							false,
							true);
					}
				}));
			}
		}
	}
}