using SwordOverhaul.Projectiles;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace SwordOverhaul.Items.Weapons
{
	public class sapphirespear : ModItem
	{
		public override void SetStaticDefaults() {
            DisplayName.SetDefault("Sapphire Spear");
			Tooltip.SetDefault("Sharp!");
		}

		public override void SetDefaults() {
			item.damage = 18;
			item.useStyle = 5;
			item.useAnimation = 18;
			item.useTime = 30;
			item.shootSpeed = 3.7f;
			item.knockBack = 6.5f;
			item.width = 32;
			item.height = 32;
			item.scale = 1f;
			item.rare = 4;
			item.value = Item.sellPrice(silver: 75);

			item.melee = true;
			item.noMelee = true; 
			item.noUseGraphic = true; 
			item.autoReuse = true; 

			item.UseSound = SoundID.Item1;
			item.shoot = mod.ProjectileType<sapphirespearprojectile>();
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.Sapphire, 8);
			recipe.AddIngredient(ItemID.SilverBar, 10);   
			recipe.AddTile(16);
			recipe.SetResult(this);
			recipe.AddRecipe();
		
		
			recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.Sapphire, 8);
			recipe.AddIngredient(ItemID.TungstenBar, 10);   
			recipe.AddTile(16);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}

		public override bool CanUseItem(Player player) {
			
			return player.ownedProjectileCounts[item.shoot] < 1;
		}
	}
}