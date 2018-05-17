using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace HeavenlyAscension.Items.Parts.Blades
{
    public class SmallSilverBlade : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Small Silver Blade");
            Tooltip.SetDefault("A small blade casted from molten silver");
        }
        public override void SetDefaults()
        {
            item.width = 24; // Hitbox Width
            item.height = 24; // Hitbox Height 
            item.value = 1200; // 10 | 00 | 00 | 00 : Platinum | Gold | Silver | Bronze
            item.rare = 1; // Item Tier
            item.maxStack = 1; // The maximum number you can have of this item.
        }

        public override void AddRecipes()
        {
            ModRecipe r = new ModRecipe(mod);
            r.AddIngredient(null, "SmallBladeMold", 1);
            r.AddIngredient(ItemID.SilverBar, 3);
            r.AddTile(TileID.Furnaces);
            r.SetResult(this);
            r.AddRecipe();
        }
    }
}
