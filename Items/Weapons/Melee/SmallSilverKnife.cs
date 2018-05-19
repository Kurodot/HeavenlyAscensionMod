using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace HeavenlyAscension.Items.Weapons.Melee
{
    public class SmallSilverKnife : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Small Silver Knife");
            Tooltip.SetDefault("A small silver knife, probably better suited for werewolves than normal enemies. At least it's starting to make real dent's in their health!");
        }
        public override void SetDefaults()
        {
            item.damage = 6;
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