using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace HeavenlyAscension.Items.Blueprints.ToolBlueprints.BladeBlueprints
{
    public class SmallBladeBlueprint  : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Small Blade Blueprint");
            Tooltip.SetDefault("A small blueprint with a blade design chalked on it");
        }
        public override void SetDefaults()
        {
            item.width = 24; // Hitbox Width
            item.height = 24; // Hitbox Height
            item.value = 20; // 10 | 00 | 00 | 00 : Platinum | Gold | Silver | Bronze
            item.rare = 2; // Item Tier
            item.maxStack = 99; // The maximum number you can have of this item.
        }

        public override void AddRecipes()
        {
            ModRecipe r = new ModRecipe(mod);
            r.AddIngredient(null, "EmptySmallBlueprint", 1);
            r.AddIngredient(null, "ChalkStick", 1);
            r.AddTile(TileID.WorkBenches);
            r.SetResult(this);
            r.AddRecipe();
        }
    }
}
