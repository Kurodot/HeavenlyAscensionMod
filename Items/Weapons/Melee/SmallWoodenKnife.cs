using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace HeavenlyAscension.Items.Weapons.Melee
{
    public class SmallWoodenKnife : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Small Wooden Knife");
            Tooltip.SetDefault("A small wooden knife, pretty basic in design. But it's a start");
        }
        public override void SetDefaults()
        {
            item.damage = 8;
            item.melee = true;
            item.width = 16;
            item.height = 16;
            item.useTime = 20;
            item.useAnimation = 20;
            item.useStyle = 1;
            item.knockBack = 6;
            item.value = 10;
            item.rare = 0;
            item.UseSound = SoundID.Item1;
            item.autoReuse = false;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(null, "SmallWoodenBlade", 1);
            recipe.AddIngredient(null, "SmallWoodenGuard", 1);
            recipe.AddIngredient(null, "SmallWoodenHandle", 1);
            recipe.AddTile(TileID.WorkBenches);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}