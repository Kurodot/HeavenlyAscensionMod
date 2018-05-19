using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace HeavenlyAscension.Items.Weapons.Melee
{
    public class SmallStoneKnife : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Small Stone Knife");
            Tooltip.SetDefault("A small stone knife, pretty basic in design. But it's an upgrade.");
        }
        public override void SetDefaults()
        {
            item.damage = 4;
            item.melee = true;
            item.width = 16;
            item.height = 16;
            item.useTime = 10;
            item.useAnimation = 10;
            item.useStyle = 3;
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