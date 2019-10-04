using SwordOverhaul.Projectiles;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace SwordOverhaul.Items.Weapons
{
	public class AmethystYoyo : ModItem
	{
		public override void SetStaticDefaults()
		{
            DisplayName.SetDefault("Amethsyt Yoyo");
			Tooltip.SetDefault("Shiny");

			
			ItemID.Sets.Yoyo[item.type] = true;
			ItemID.Sets.GamepadExtraRange[item.type] = 15;
			ItemID.Sets.GamepadSmartQuickReach[item.type] = true;
		}

		public override void SetDefaults()
		{
			item.useStyle = 5;
			item.width = 24;
			item.height = 24;
			item.useAnimation = 25;
			item.useTime = 25;
			item.shootSpeed = 16f;
			item.knockBack = 2.5f;
			item.damage = 15;
			item.rare = 3;

			item.melee = true;
			item.channel = true;
			item.noMelee = true;
			item.noUseGraphic = true;

			item.UseSound = SoundID.Item1;
			item.value = Item.sellPrice(silver: 50);
			item.shoot = mod.ProjectileType<AmethystYoyoProjectile>();
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.Amethyst, 8);
			recipe.AddIngredient(ItemID.TinBar, 10);   
			recipe.AddTile(16);
			recipe.SetResult(this);
			recipe.AddRecipe();
		
		
			recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.Amethyst, 8);
			recipe.AddIngredient(ItemID.CopperBar, 10);   
			recipe.AddTile(16);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}