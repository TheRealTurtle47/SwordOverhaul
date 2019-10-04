using SwordOverhaul.Projectiles;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace SwordOverhaul.Items.Weapons
{
	public class prismaticspear : ModItem
	{
		public override void SetStaticDefaults() {
            DisplayName.SetDefault("Prismatic Spear");
			Tooltip.SetDefault(" Great Refractive Power");
		}

		public override void SetDefaults() {
			item.damage = 98;
			item.useStyle = 5;
			item.useAnimation = 18;
			item.useTime = 40;
			item.shootSpeed = 2f;
			item.knockBack = 7.8f;
			item.width = 32;
			item.height = 32;
			item.scale = 1f;
			item.rare = 7;
			item.value = Item.sellPrice(gold: 20);

			item.melee = true;
			item.noMelee = true; 
			item.noUseGraphic = true; 
			item.autoReuse = true; 

			item.UseSound = SoundID.Item1;
			item.shoot = mod.ProjectileType<prismaticspearprojectile>();
			item.shootSpeed = 10f;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.TitaniumBar, 10);
			recipe.AddIngredient(mod, "amethystspear", 1);
			recipe.AddIngredient(mod, "topazspear", 1);
			recipe.AddIngredient(mod, "sapphirespear", 1);
			recipe.AddIngredient(mod, "emeraldspear", 1);
			recipe.AddIngredient(mod, "rubyspear", 1);
			recipe.AddIngredient(mod, "diamondspear", 1);
			recipe.AddIngredient(mod, "PrismaticGem", 1);
			recipe.AddTile(134);
			recipe.SetResult(this);
			recipe.AddRecipe();

			recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.AdamantiteBar, 10);
			recipe.AddIngredient(mod, "amethystspear", 1);
			recipe.AddIngredient(mod, "topazspear", 1);
			recipe.AddIngredient(mod, "sapphirespear", 1);
			recipe.AddIngredient(mod, "emeraldspear", 1);
			recipe.AddIngredient(mod, "rubyspear", 1);
			recipe.AddIngredient(mod, "diamondspear", 1);
			recipe.AddIngredient(mod, "PrismaticGem", 1);
			recipe.AddTile(134);
			recipe.SetResult(this);
			recipe.AddRecipe();
		
			
		}

		public override bool CanUseItem(Player player) {
			
			return player.ownedProjectileCounts[item.shoot] < 1;
		}
	}
}