using Terraria.ID;
using Terraria.ModLoader;

namespace yeps.Items.weapons.Ammo
{
	public class InfiniteMudBallPouch : ModItem
	{
		public override void SetStaticDefaults() 
		{
			//DisplayName.SetDefault("InfiniteMudBallPouch");
			Tooltip.SetDefault("Whack balls of mud at high velocity");
		}

		public override void SetDefaults() 
		{
			item.damage = 12;
			item.ranged = true;
			item.width = 8;
			item.height = 8;
			item.consumable = false;
			item.knockBack = 1f;
			item.value = 0;
			item.rare = 2;
			item.shoot = 39;
			item.shootSpeed = 20f;
			item.ammo = AmmoID.Bullet;
		}


		public override void AddRecipes() 
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(null, "MudBall", 3996);
			recipe.AddTile(TileID.WorkBenches);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}
