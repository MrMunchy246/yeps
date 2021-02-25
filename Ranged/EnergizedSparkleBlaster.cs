using Terraria.ID;
using Terraria.ModLoader;

namespace yeps.Items.weapons.Ranged
{
	public class EnergizedSparkleBlaster : ModItem
	{
		public override void SetStaticDefaults() 
		{
			// DisplayName.SetDefault("EnergizedSparkleGun");
			Tooltip.SetDefault("not to be confused with the sparkle gun");
		}

		public override void SetDefaults() 
		{
			item.damage = 17; 
			item.ranged = true; 
			item.width = 40; 
			item.height = 20; 
			item.useTime = 10; 
			item.useAnimation = 10; 
			item.useStyle = 5; 
			item.noMelee = true; 
			item.knockBack = 8; 
			item.value = 30000; 
			item.rare = 6; 
			item.UseSound = SoundID.Item11; 
			item.autoReuse = true; 
			item.shoot = 14; 
			item.shootSpeed = 20f; 
			item.useAmmo = AmmoID.Bullet; 
		}

		public override void AddRecipes() 
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.Musket);
			recipe.AddIngredient(null, "SparkleEnergy", 20);
			recipe.AddTile(TileID.MythrilAnvil);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}