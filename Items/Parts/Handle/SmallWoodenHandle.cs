using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace HeavenlyAscension.Items.Parts.Handle
{
    public class SmallWoodenHandle : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Small Wooden Handle");
            Tooltip.SetDefault("A small handle carved from wood");
        }
        public override void SetDefaults()
        {
            item.width = 24; // Hitbox Width
            item.height = 24; // Hitbox Height
            item.value = 1; // 10 | 00 | 00 | 00 : Platinum | Gold | Silver | Bronze
            item.rare = 1; // Item Tier
            item.maxStack = 1; // The maximum number you can have of this item.
        }

        public override void AddRecipes()
        {
            ModRecipe r = new ModRecipe(mod);
            r.AddIngredient(null, "SmallHandleBlueprint", 1);
            r.AddIngredient(ItemID.Wood, 1);
            r.AddTile(TileID.WorkBenches);
            r.SetResult(this);
            r.AddRecipe();
        }
    }
}
