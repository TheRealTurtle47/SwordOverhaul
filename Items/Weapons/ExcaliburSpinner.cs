using SwordOverhaul.Projectiles;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace SwordOverhaul.Items.Weapons
{
	public class ExcaliburSpinner : ModItem
	{
		public override void SetStaticDefaults()
		{
            DisplayName.SetDefault("Excalibur Spinner");
			Tooltip.SetDefault("The Power of Light");

			
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
			item.damage = 61;
			item.rare = 5;

			item.melee = true;
			item.channel = true;
			item.noMelee = true;
			item.noUseGraphic = true;

			item.UseSound = SoundID.Item1;
			item.value = Item.sellPrice(gold: 20);
			item.shoot = mod.ProjectileType<ExcaliburSpinnerProjectile>();
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(1225, 20);
            recipe.AddIngredient(mod, "BrokenHeroYoyo", 1);
			recipe.AddTile(134);
			recipe.SetResult(this);
			recipe.AddRecipe();
		
		
			
		}
	}
}