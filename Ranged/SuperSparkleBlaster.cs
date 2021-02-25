using Terraria.ID;
using Terraria.ModLoader;

namespace yeps.Items.weapons.Ranged
{
	public class SuperSparkleBlaster : ModItem
	{
		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("SuperSparkleGun");
			Tooltip.SetDefault("now it's super");
		}

		public override void SetDefaults()
		{
			item.damage = 40; 
			item.ranged = true; 
			item.width = 40; 
			item.height = 20; 
			item.useTime = 5; 
			item.useAnimation = 5; 
			item.useStyle = 5; 
			item.noMelee = true; 
			item.knockBack = 15; 
			item.value = 40000; 
			item.rare = 4; 
			item.UseSound = SoundID.Item11; 
			item.autoReuse = true; 
			item.shoot = 10; 
			item.shootSpeed = 10f; 
			item.useAmmo = AmmoID.Bullet; 
		}

		public override void AddRecipes() 
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.Ruby, 10);
			recipe.AddIngredient(ItemID.BeetleHusk, 10);
			recipe.AddIngredient(null, "SparkleBlasterMk3");
			recipe.AddTile(TileID.MythrilAnvil);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}