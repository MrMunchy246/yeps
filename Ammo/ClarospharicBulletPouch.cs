using Terraria.ID;
using Terraria.ModLoader;

namespace yeps.Items.weapons.Ammo
{
	public class ClarospharicBulletPouch : ModItem
	{
		public override void SetStaticDefaults() 
		{
			DisplayName.SetDefault("Clarospharic Bullet Pouch");
		}

		public override void SetDefaults() 
		{
			item.damage = 45;
			item.ranged = true;
			item.width = 8;
			item.height = 8;
			item.consumable = false;
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
			recipe.AddIngredient(null, "ClarospharicBullet", 3996);
			recipe.AddTile(TileID.CrystalBall);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}