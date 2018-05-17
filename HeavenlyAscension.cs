using Terraria.ModLoader;

namespace HeavenlyAscension
{
	class HeavenlyAscension : Mod
	{
		public HeavenlyAscension()
		{
			Properties = new ModProperties()
			{
				Autoload = true,
				AutoloadGores = true,
				AutoloadSounds = true
			};
		}
	}
}
