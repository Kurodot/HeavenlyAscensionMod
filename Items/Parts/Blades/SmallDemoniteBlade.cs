using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace HeavenlyAscension.Items.Parts.Blades
{
    public class SmallDemoniteBlade : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Small Demonite Blade");
            Tooltip.SetDefault("A small blade casted from molten demonite");
        }
        public override void SetDefaults()
        {
            item.width = 24; // Hitbox Width
            item.height = 24; // Hitbox Height 
            item.value = 7500; // 10 | 00 | 00 | 00 : Platinum | Gold | Demonite | Bronze
            item.rare = 1; // Item Tier
            item.maxStack = 1; // The maximum number you can have of this item.
        }

        public override void AddRecipes()
        {
            ModRecipe r = new ModRecipe(mod);
            r.AddIngredient(null, "SmallBladeMold", 1);
            r.AddIngredient(ItemID.DemoniteBar, 3);
            r.AddTile(TileID.Furnaces);
            r.SetResult(this);
            r.AddRecipe();
        }
    }
}
