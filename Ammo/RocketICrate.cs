using Terraria.ID;
using Terraria.ModLoader;

namespace yeps.Items.weapons.Ammo
{
	public class RocketICrate : ModItem
	{
		public override void SetStaticDefaults() 
		{
			DisplayName.SetDefault("Rocket I Crate");
		}

		public override void SetDefaults() 
		{
			item.damage = 40;
			item.ranged = true;
			item.width = 8;
			item.height = 8;
			item.consumable = false;
			item.knockBack = 4f;
			item.value = 50;
			item.rare = 2;
			item.shoot = 0;
			item.shootSpeed = 5f;
			item.ammo = AmmoID.Rocket;
		}

		public override void AddRecipes() 
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.RocketI, 3996);
			recipe.AddTile(TileID.CrystalBall);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}