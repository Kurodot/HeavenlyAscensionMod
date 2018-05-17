using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace HeavenlyAscension.Items.ChalkSticks
{
    public class ChalkStick : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Chalk Stick");
            Tooltip.SetDefault("A stick of refined chalk, used to create basic blueprints");
        }
        public override void SetDefaults()
        {
            item.width = 24; // Hitbox Width
            item.height = 24; // Hitbox Height
            item.value = 3; // 10 | 00 | 00 | 00 : Platinum | Gold | Silver | Bronze
            item.rare = 1; // Item Tier
            item.maxStack = 5; // The maximum number you can have of this item.
        }

        public override void AddRecipes()
        {
            ModRecipe r = new ModRecipe(mod);
            r.AddIngredient(null, "Chalk", 3);
            r.AddTile(TileID.WorkBenches);
            r.SetResult(this);
            r.AddRecipe();
        }
    }
}
