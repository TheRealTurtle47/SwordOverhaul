using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace SwordOverhaul.Items.Weapons
{
	public class DebuffBlade2 : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Debuff Blade 2");
			Tooltip.SetDefault("Reduces enemies beyond nothing.");
		}
		public override void SetDefaults()
		{
			item.damage = 19;
			item.melee = true;
			item.width = 500;
			item.height = 500;
			item.useTime = 20;
			item.useAnimation = 20;
			item.useStyle = 1;
			item.knockBack = 5;
			item.value = 100000;
			item.rare = 3;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(mod, "DebuffBlade1", 1);
			recipe.AddIngredient(mod, "IchorBlade", 1);
            recipe.AddIngredient(mod, "CursedBlade", 1);
            recipe.AddIngredient(ItemID.Bone, 1);
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
		}
	}
}