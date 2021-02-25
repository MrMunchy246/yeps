using Terraria.ID;
using Terraria.ModLoader;

namespace yeps.Items.weapons
{
	public class SharkCannon : ModItem
	{
		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("SharkCannon");
			Tooltip.SetDefault("finally having some representation amogst the others");
		}

		public override void SetDefaults()
		{
			item.damage = 2000; 
			item.width = 40; 
			item.height = 20; 
			item.useTime = 10; 
			item.useAnimation = 10; 
			item.useStyle = 5; 
			item.noMelee = true; 
			item.knockBack = 5f; 
			item.value = 100000; 
			item.rare = 2; 
			item.UseSound = SoundID.Item11; 
			item.autoReuse = true; 
			item.shoot = 408;
			item.shootSpeed = 40f;  
			item.scale -= 0.35f;
		}

		public override void AddRecipes() 
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(null, "ForceOfDuke");
			recipe.AddTile(TileID.LunarCraftingStation);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}