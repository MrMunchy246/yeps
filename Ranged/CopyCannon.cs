using Terraria.ID;
using Terraria.ModLoader;

namespace yeps.Items.weapons.Ranged
{
	public class CopyCannon : ModItem
	{
		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("CopyCannon");
			Tooltip.SetDefault("What will it shoot this time");
		}

		public override void SetDefaults()
		{
			item.damage = 1; 
			item.width = 40; 
			item.height = 20; 
			item.useTime = 10; 
			item.useAnimation = 10; 
			item.useStyle = 5; 
			item.noMelee = true; 
			item.knockBack = 0f; 
			item.value = 0; 
			item.rare = 1; 
			item.UseSound = SoundID.Item11; 
			item.autoReuse = true; 
			item.shoot = 93;
			item.shootSpeed = 20f; 
			item.ranged	= true;
		}

		public override void AddRecipes() 
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.DirtBlock);
			recipe.AddTile(TileID.WorkBenches);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}