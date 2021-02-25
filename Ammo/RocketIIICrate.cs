using Terraria.ID;
using Terraria.ModLoader;

namespace yeps.Items.weapons.Ammo
{
	public class RocketIIICrate : ModItem
	{
		public override void SetStaticDefaults() 
		{
			DisplayName.SetDefault("Rocket III Crate");
		}

		public override void SetDefaults() 
		{
			item.damage = 65;
			item.ranged = true;
			item.width = 8;
			item.height = 8;
			item.consumable = false;
			item.knockBack = 4f;
			item.value = 1000;
			item.rare = 2;
			item.shoot = 6;
			item.shootSpeed = 5f;
			item.ammo = AmmoID.Rocket;
		}

		public override void AddRecipes() 
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.RocketIII, 3996);
			recipe.AddTile(TileID.CrystalBall);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}