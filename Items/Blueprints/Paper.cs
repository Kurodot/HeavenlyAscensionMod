using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace HeavenlyAscension.Items.Blueprints
{
    public class Paper  : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Paper");
            Tooltip.SetDefault("Basic paper capable of being used for basic designs");
        }
        public override void SetDefaults()
        {
            item.width = 24; // Hitbox Width
            item.height = 24; // Hitbox Height
            item.value = 1;
            item.rare = 1; // Item Tier
            item.maxStack = 99; // The maximum number you can have of this item.
        }

        public override void AddRecipes()
        {
            ModRecipe r = new ModRecipe(mod);
            r.AddIngredient(ItemID.Bone, 1);
            r.AddIngredient(ItemID.Gel, 10);
            r.AddTile(TileID.WorkBenches);
            r.SetResult(this);
            r.AddRecipe();
        }
    }
}
