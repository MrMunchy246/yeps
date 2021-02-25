using Terraria.ID;
using Terraria.ModLoader;

namespace yeps.Items.weapons.Ammo
{
	public class ClarospharicArrowQuiver : ModItem
	{
		public override void SetStaticDefaults() 
		{
			DisplayName.SetDefault("Clarospharic Arrow Quiver");
			Tooltip.SetDefault("super clarospharic");
		}

		public override void SetDefaults() 
		{
			item.damage = 45;
			item.ranged = true;
			item.width = 8;
			item.height = 8;
			item.consumable = false;
			item.knockBack = 16f;
			item.value = 0;
			item.rare = 2;
			item.shoot = mod.ProjectileType("ClarospharicArrow");
			item.shootSpeed = 20f;
			item.ammo = AmmoID.Arrow;
		}


		public override void AddRecipes() 
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(null, "ClarospharicArrow", 3996);
			recipe.AddTile(TileID.CrystalBall);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}