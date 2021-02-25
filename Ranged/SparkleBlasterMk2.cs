using Terraria.ID;
using Terraria.ModLoader;

namespace yeps.Items.weapons.Ranged
{
	public class SparkleBlasterMk2 : ModItem
	{
		public override void SetStaticDefaults() 
		{
			// DisplayName.SetDefault("SparkleGunMk2");
			Tooltip.SetDefault("pew pew");
		}

		public override void SetDefaults() 
		{
			item.damage = 20; 
			item.ranged = true; 
			item.width = 40; 
			item.height = 20; 
			item.useTime = 15; 
			item.useAnimation = 15; 
			item.useStyle = 5; 
			item.noMelee = true; 
			item.knockBack = 6; 
			item.value = 20000; 
			item.rare = 2; 
			item.UseSound = SoundID.Item11; 
			item.autoReuse = true; 
			item.shoot = 10; 
			item.shootSpeed = 14f; 
			item.useAmmo = AmmoID.Bullet; 
		}

		public override void AddRecipes() 
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.Sapphire, 10);
			recipe.AddIngredient(null, "SparkleBlaster");
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}