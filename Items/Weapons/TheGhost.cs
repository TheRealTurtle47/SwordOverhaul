using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace SwordOverhaul.Items.Weapons
{
	public class TheGhost : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("The Ghost");
			Tooltip.SetDefault("Enemies wont see it coming.");
		}
		public override void SetDefaults()
		{
			item.damage = 170;
			item.melee = true;
			item.width = 500;
			item.height = 500;
			item.useTime = 15;
			item.useAnimation = 15;
			item.useStyle = 1;
			item.knockBack = 15;
			item.value = 100000;
			item.rare = 6;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.TitaniumBar, 5);
            recipe.AddIngredient(ItemID.Ectoplasm, 5);
			recipe.AddTile(134);
			recipe.SetResult(this);
			recipe.AddRecipe();

			recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.AdamantiteBar, 5);
            recipe.AddIngredient(ItemID.Ectoplasm, 5);
			recipe.AddTile(134);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}

        public override void OnHitNPC(Player player, NPC target, int damage, float knockback, bool crit)
		{
			player.AddBuff(10, 300);
		}
	}
}
