using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace HeavenlyAscension.Items.Rocks
{
    public class Chalk : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Chalk");
            Tooltip.SetDefault("A chunk of chalk, used in designing and blueprints");
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
            item.createTile = mod.TileType("ChalkTile");
            item.maxStack = 999;
        }
    }
}