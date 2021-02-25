using Terraria.ID;
using Terraria.ModLoader;

namespace yeps.Items.weapons.Ranged
{
	public class SparkleBlaster : ModItem
	{
		public override void SetStaticDefaults() 
		{
			// DisplayName.SetDefault("SparkleGun");
			Tooltip.SetDefault("Bang Bang goes the gun");
		}

		public override void SetDefaults() 
		{
			item.damage = 10; 
			item.ranged = true; 
			item.width = 40; 
			item.height = 20; 
			item.useTime = 20; 
			item.useAnimation = 20; 
			item.useStyle = 5; 
			item.noMelee = true; 
			item.knockBack = 4; 
			item.value = 10000; 
			item.rare = 1; 
			item.UseSound = SoundID.Item11; 
			item.autoReuse = true; 
			item.shoot = 10; 
			item.shootSpeed = 20f; 
			item.useAmmo = AmmoID.Bullet; 
		}

		public override void AddRecipes() 
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.Amethyst, 10);
			recipe.AddIngredient(ItemID.CopperBar, 5);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}