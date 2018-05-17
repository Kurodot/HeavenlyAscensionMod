using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace HeavenlyAscension.Items.Parts.Blades
{
    public class SmallHellstoneBlade : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Small Hellstone Blade");
            Tooltip.SetDefault("A small blade casted from molten hellstone");
        }
        public override void SetDefaults()
        {
            item.width = 24; // Hitbox Width
            item.height = 24; // Hitbox Height 
            item.value = 9500; // 10 | 00 | 00 | 00 : Platinum | Gold | Hellstone | Bronze
            item.rare = 1; // Item Tier
            item.maxStack = 1; // The maximum number you can have of this item.
        }

        public override void AddRecipes()
        {
            ModRecipe r = new ModRecipe(mod);
            r.AddIngredient(null, "SmallBladeMold", 1);
            r.AddIngredient(ItemID.HellstoneBar, 3);
            r.AddTile(TileID.Hellforge);
            r.AddTile(TileID.AdamantiteForge);
            r.SetResult(this);
            r.AddRecipe();
        }
    }
}
