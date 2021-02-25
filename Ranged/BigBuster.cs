using Terraria.ID;
using Terraria.ModLoader;

namespace yeps.Items.weapons.Ranged
{
	public class BigBuster : ModItem
	{
		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("BigBuster");
			Tooltip.SetDefault("ya better walk the plank");
		}

		public override void SetDefaults()
		{
			item.damage = 3417; 
			item.ranged = true; 
			item.width = 40; 
			item.height = 20; 
			item.useTime = 40; 
			item.useAnimation = 40; 
			item.useStyle = 5; 
			item.noMelee = true; 
			item.knockBack = 30; 
			item.value = 50000; 
			item.rare = 6; 
			item.UseSound = SoundID.Item61; 
			item.autoReuse = true; 
			item.shoot = 162; 
			item.shootSpeed = 20f;  
		}

		public override void AddRecipes() 
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.Cannon);
			recipe.AddIngredient(ItemID.Cannonball, 30);
			recipe.AddIngredient(null, "ClarospharicBar", 10);
			recipe.AddIngredient(ItemID.Musket);
			recipe.AddTile(TileID.MythrilAnvil);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}