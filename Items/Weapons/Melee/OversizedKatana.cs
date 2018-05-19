using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace HeavenlyAscension.Items.Weapons.Melee
{
    public class OversizedKatana : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Oversized Katana");
            Tooltip.SetDefault("Slicing through code like butter.");
        }
        public override void SetDefaults()
        {
            item.damage = 1000000;
            item.melee = true;
            item.width = 32;
            item.height = 32;
            item.useTime = 50;
            item.useAnimation = 50;
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