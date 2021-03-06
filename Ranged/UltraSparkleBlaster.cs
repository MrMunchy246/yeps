using Terraria.ID;
using Terraria.ModLoader;

namespace yeps.Items.weapons.Ranged
{
	public class UltraSparkleBlaster : ModItem
	{
		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("UltraSparkleGun");
			Tooltip.SetDefault("RIP headphone users");
		}

		public override void SetDefaults()
		{
			item.damage = 578; 
			item.ranged = true; 
			item.width = 40; 
			item.height = 20; 
			item.useTime = 1; 
			item.useAnimation = 1; 
			item.useStyle = 5; 
			item.noMelee = true; 
			item.knockBack = 1; 
			item.value = 50000000; 
			item.rare = 11; 
			item.UseSound = SoundID.Item10; 
			item.autoReuse = true; 
			item.shoot = 10; 
			item.shootSpeed = 50f; 
			item.useAmmo = AmmoID.Bullet; 
		}
		public override void AddRecipes() 
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.Diamond, 10);
			recipe.AddIngredient(ItemID.BeetleHusk, 20);
			recipe.AddIngredient(ItemID.VortexBeater);
			recipe.AddIngredient(ItemID.LunarBar, 30);
			recipe.AddIngredient(null, "SparkleBlaster");
			recipe.AddIngredient(null, "SparkleBlasterMk2");
			recipe.AddIngredient(null, "SparkleBlasterMk3");
			recipe.AddIngredient(null, "MegaSparkleBlaster");
			recipe.AddIngredient(null, "SuperSparkleBlaster");
			recipe.AddIngredient(ItemID.FragmentSolar, 30);
			recipe.AddIngredient(ItemID.FragmentNebula, 30);
			recipe.AddIngredient(ItemID.FragmentStardust, 30);
			recipe.AddIngredient(ItemID.FragmentVortex, 30);
			recipe.AddTile(TileID.LunarCraftingStation);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}