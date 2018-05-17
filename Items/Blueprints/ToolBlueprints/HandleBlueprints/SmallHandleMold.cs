using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace HeavenlyAscension.Items.Blueprints.ToolBlueprints.HandleBlueprints
{
    public class SmallHandleMold  : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Small Handle Mold");
            Tooltip.SetDefault("A small mold to cast metals and stones in");
        }
        public override void SetDefaults()
        {
            item.width = 24; // Hitbox Width
            item.height = 24; // Hitbox Height 
            item.value = 25; // 10 | 00 | 00 | 00 : Platinum | Gold | Silver | Bronze
            item.rare = 3; // Item Tier
            item.maxStack = 99; // The maximum number you can have of this item.
        }

        public override void AddRecipes()
        {
            ModRecipe r = new ModRecipe(mod);
            r.AddIngredient(null, "SmallWoodenHandle", 1);
            r.AddIngredient(ItemID.ClayBlock, 10);
            r.AddTile(TileID.Furnaces);
            r.SetResult(this);
            r.AddRecipe();
        }
    }
}
