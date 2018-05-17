using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace HeavenlyAscension.Items.CraftingStations
{
    public class BlueprintStationItem : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Blueprint Station");
            Tooltip.SetDefault("A station used to design blueprints.");
        }
        public override void SetDefaults()
        {
            item.width = 12;
            item.height = 12;
            item.useTime = 20;
            item.useAnimation = 20;
            item.rare = 1;
            item.useStyle = 1;
            item.value = 0;
            item.UseSound = SoundID.Item1;
            item.autoReuse = true;
            item.consumable = true;
            item.createTile = mod.TileType("BlueprintStation");
            item.maxStack = 99;
        }
    }
}