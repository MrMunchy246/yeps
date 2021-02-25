using Terraria.ID;
using Terraria.ModLoader;

namespace yeps.Items.weapons.Ranged
{
	public class SilverCoinGun : ModItem
	{
		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("SilverCoinGun");
			Tooltip.SetDefault("infinite silver coins");
		}

		public override void SetDefaults()
		{
			item.damage = 50; 
			item.ranged = true; 
			item.width = 40; 
			item.height = 20; 
			item.useTime = 8; 
			item.useAnimation = 8; 
			item.useStyle = 5; 
			item.noMelee = true; 
			item.knockBack = 1; 
			item.value = 50000; 
			item.rare = 8; 
			item.UseSound = SoundID.Item11; 
			item.autoReuse = true; 
			item.shoot = 159; 
			item.shootSpeed = 10f; 
		}

		public override void AddRecipes() 
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.SilverCoin, 100);
			recipe.AddIngredient(null,"CopperCoinGun");
			recipe.AddTile(TileID.MythrilAnvil);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}