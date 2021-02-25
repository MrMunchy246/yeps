using Terraria.ID;
using Terraria.ModLoader;

namespace yeps.Items.weapons
{
	public class MoonLordsRemnant : ModItem
	{
		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("MoonLordsRemnent");
			Tooltip.SetDefault("make sure to stand still while using. \n" +
			"it work better that way");
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
			item.UseSound = SoundID.Item124; 
			item.autoReuse = true; 
			item.shoot = 641; 
			item.shootSpeed = 40f;  
		}

		public override void AddRecipes() 
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(null, "ForceOfMoonLord");
			recipe.AddTile(TileID.LunarCraftingStation);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}