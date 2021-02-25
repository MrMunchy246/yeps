using Terraria.ID;
using Terraria.ModLoader;

namespace yeps.Items.weapons.Ammo
{
	public class ClarospharicArrow : ModItem
	{
		public override void SetStaticDefaults() 
		{
			DisplayName.SetDefault("Clarospharic Arrow");
			Tooltip.SetDefault("super clarospharic");
		}

		public override void SetDefaults() 
		{
			item.damage = 45;
			item.ranged = true;
			item.width = 8;
			item.height = 8;
			item.maxStack = 9999;
			item.consumable = true;
			item.knockBack = 1f;
			item.value = 0;
			item.rare = 2;
			item.shoot = mod.ProjectileType("ClarospharicArrow");
			item.shootSpeed = 20f;
			item.ammo = AmmoID.Arrow;
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
