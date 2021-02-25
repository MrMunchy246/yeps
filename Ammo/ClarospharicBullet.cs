using Terraria.ID;
using Terraria.ModLoader;

namespace yeps.Items.weapons.Ammo
{
	public class ClarospharicBullet : ModItem
	{
		public override void SetStaticDefaults() 
		{
			DisplayName.SetDefault("Clarospharic Bullet");
			Tooltip.SetDefault("would it be called clarosphic or clarosphine?");
		}

		public override void SetDefaults() 
		{
			item.damage = 45;
			item.ranged = true;
			item.width = 8;
			item.height = 8;
			item.maxStack = 9999;
			item.consumable = true;
			item.knockBack = 16f;
			item.value = 1;
			item.rare = 2;
			item.shoot = mod.ProjectileType("ClarospharicBullet");
			item.shootSpeed = 40f;
			item.ammo = AmmoID.Bullet;
		}

		public override void AddRecipes() 
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(null, "ClarospharicBar");
			recipe.AddTile(TileID.WorkBenches);
			recipe.SetResult(this, 100);
			recipe.AddRecipe();
		}
	}
}
