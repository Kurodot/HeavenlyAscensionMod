using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace HeavenlyAscension.Items.Parts.Blades
{
    public class SmallMythrilBlade : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Small Mythril Blade");
            Tooltip.SetDefault("A small blade casted from molten mythril");
        }
        public override void SetDefaults()
        {
            item.width = 24; // Hitbox Width
            item.height = 24; // Hitbox Height 
            item.value = 10000; // 10 | 00 | 00 | 00 : Platinum | Gold | Mythril | Bronze
            item.rare = 1; // Item Tier
            item.maxStack = 1; // The maximum number you can have of this item.
        }

        public override void AddRecipes()
        {
            ModRecipe r = new ModRecipe(mod);
            r.AddIngredient(null, "SmallBladeMold", 1);
            r.AddIngredient(ItemID.MythrilBar, 3);
            r.AddTile(TileID.AdamantiteForge);
            r.SetResult(this);
            r.AddRecipe();
        }
    }
}
