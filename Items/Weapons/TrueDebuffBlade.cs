using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace SwordOverhaul.Items.Weapons
{
	public class TrueDebuffBlade : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("True Debuff Blade");
			Tooltip.SetDefault("Reduces enemies to antimatter.");
		}
		public override void SetDefaults()
		{
			item.damage = 88;
			item.melee = true;
			item.width = 100;
			item.height = 100;
			item.useTime = 15;
			item.useAnimation = 15;
			item.useStyle = 1;
			item.knockBack = 10;
			item.value = 500000;
			item.rare = 5;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(mod, "DebuffBlade2", 1);
			recipe.AddIngredient(mod, "VenomBlade", 1);
            recipe.AddIngredient(mod, "ShadowflameBlade", 1);
            recipe.AddIngredient(ItemID.BrokenHeroSword, 1);
			recipe.AddTile(26);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}

        public override void OnHitNPC(Player player, NPC target, int damage, float knockback, bool crit)
		{
			target.AddBuff(BuffID.OnFire, 120);
            target.AddBuff(BuffID.Frostburn, 120);
            target.AddBuff(BuffID.Poisoned, 120);
            target.AddBuff(BuffID.Midas, 120);
			target.AddBuff(BuffID.Confused, 120);
            target.AddBuff(69, 120);
			target.AddBuff(BuffID.CursedInferno, 120);
            target.AddBuff(BuffID.Venom, 120);
            target.AddBuff(153, 120);
		}
	}
}