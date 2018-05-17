using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace HeavenlyAscension.Items.Parts.Blades
{
    public class SmallCobaltBlade : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Small Cobalt Blade");
            Tooltip.SetDefault("A small blade casted from molten cobalt");
        }
        public override void SetDefaults()
        {
            item.width = 24; // Hitbox Width
            item.height = 24; // Hitbox Height 
            item.value = 5000; // 10 | 00 | 00 | 00 : Platinum | Gold | Cobalt | Bronze
            item.rare = 1; // Item Tier
            item.maxStack = 1; // The maximum number you can have of this item.
        }

        public override void AddRecipes()
        {
            ModRecipe r = new ModRecipe(mod);
            r.AddIngredient(null, "SmallBladeMold", 1);
            r.AddIngredient(ItemID.CobaltBar, 3);
            r.AddTile(TileID.AdamantiteForge);
            r.SetResult(this);
            r.AddRecipe();
        }
    }
}
