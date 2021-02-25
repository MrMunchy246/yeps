using Terraria.ID;
using Terraria.ModLoader;

namespace yeps.Items.weapons.Ammo
{
	public class MudBall : ModItem
	{
		public override void SetStaticDefaults() 
		{
			DisplayName.SetDefault("MudBall");
			Tooltip.SetDefault("Whack balls of mud at high velocity");
		}

		public override void SetDefaults() 
		{
			item.damage = 12;
			item.ranged = true;
			item.width = 8;
			item.height = 8;
			item.maxStack = 9999;
			item.consumable = true;
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
			recipe.AddIngredient(ItemID.MudBlock, 10);
			recipe.AddTile(TileID.WorkBenches);
			recipe.SetResult(this, 10);
			recipe.AddRecipe();
		}
	}
}
