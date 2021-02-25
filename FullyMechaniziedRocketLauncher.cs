using Terraria.ID;
using Terraria.ModLoader;

namespace yeps.Items.weapons
{
	public class FullyMechaniziedRocketLauncher : ModItem
	{
		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("FullyMechaniziedRocketLauncher");
			Tooltip.SetDefault("wow that's alot of damage");
		}

		public override void SetDefaults()
		{
			item.damage = 500; 
			item.width = 40; 
			item.height = 20; 
			item.useTime = 2; 
			item.useAnimation = 2; 
			item.useStyle = 5; 
			item.noMelee = true; 
			item.knockBack = 1; 
			item.value = 50000; 
			item.rare = 11; 
			item.UseSound = SoundID.Item61; 
			item.autoReuse = true; 
			item.shoot = 169; 
			item.shootSpeed = 40f;  
		}

		public override void AddRecipes() 
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(null, "ForceOfMechanical");
			recipe.AddTile(TileID.LunarCraftingStation);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}