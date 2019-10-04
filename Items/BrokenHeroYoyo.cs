using Terraria.ID;
using Terraria.ModLoader;

namespace SwordOverhaul.Items
{
	public class BrokenHeroYoyo : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Broken Hero Yoyo");
		}

		public override void SetDefaults()
		{
			item.width = 20;
			item.height = 20;
			item.maxStack = 5;
			item.value = 10000;
			item.rare = 5;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.BrokenHeroSword, 1);
			recipe.SetResult(this);
            recipe.AddTile(134);
			recipe.AddRecipe();
		}
	}
}