using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace HeavenlyAscension.Items.Blueprints
{
    public class EmptySmallBlueprint  : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Small Blueprint");
            Tooltip.SetDefault("A empty blueprint that can be used to design things");
        }
        public override void SetDefaults()
        {
            item.width = 24; // Hitbox Width
            item.height = 24; // Hitbox Height
            item.value = 15; // 10 | 00 | 00 | 00 : Platinum | Gold | Silver | Bronze
            item.rare = 2; // Item Tier
            item.UseSound = SoundID.Item1; // Sound effect of item on use 
            item.autoReuse = true; // Do you want to torture people with clicking? Set to false
            item.maxStack = 99; // The maximum number you can have of this item.
        }

        public override void AddRecipes()
        {
            ModRecipe r = new ModRecipe(mod);
            r.AddIngredient(null, "Paper", 1);
            r.AddIngredient(ItemID.BlueDye, 1);
            r.AddTile(TileID.WorkBenches);
            r.SetResult(this);
            r.AddRecipe();
        }
    }
}
