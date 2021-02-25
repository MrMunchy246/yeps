using Terraria.ID;
using Terraria.ModLoader;

namespace yeps.Items.weapons
{
	public class PetalStaff : ModItem
	{
		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("PetalStaff");
			Tooltip.SetDefault("how fitting");
		}

		public override void SetDefaults()
		{
			item.damage = 900; 
			item.width = 40; 
			item.height = 20; 
			item.useTime = 1; 
			item.useAnimation = 2; 
			item.useStyle = 5; 
			item.noMelee = true; 
			item.knockBack = 1; 
			item.value = 50000; 
			item.rare = 11; 
			item.UseSound = SoundID.Item42; 
			item.autoReuse = true; 
			item.shoot = 248; 
			item.shootSpeed = 50f;  
		}

		public override void AddRecipes() 
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(null, "ForceOfPlantera");
			recipe.AddTile(TileID.LunarCraftingStation);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}