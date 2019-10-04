using SwordOverhaul.Projectiles;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace SwordOverhaul.Items.Weapons
{
	public class NightsSpinner : ModItem
	{
		public override void SetStaticDefaults()
		{
            DisplayName.SetDefault("Night's Spinner");
			Tooltip.SetDefault("The Power of Darkness");

			
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
			item.damage = 41;
			item.rare = 4;

			item.melee = true;
			item.channel = true;
			item.noMelee = true;
			item.noUseGraphic = true;

			item.UseSound = SoundID.Item1;
			item.value = Item.sellPrice(gold: 10);
			item.shoot = mod.ProjectileType<NightsSpinnerProjectile>();
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(3281, 1);
            recipe.AddIngredient(3282, 1);
			recipe.AddIngredient(3317, 1);
            recipe.AddIngredient(3280, 1);
			recipe.AddTile(26);
			recipe.SetResult(this);
			recipe.AddRecipe();
		
		
			recipe = new ModRecipe(mod);
			recipe.AddIngredient(3281, 1);
            recipe.AddIngredient(3282, 1);
			recipe.AddIngredient(3317, 1);
            recipe.AddIngredient(3279, 1);
			recipe.AddTile(26);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}