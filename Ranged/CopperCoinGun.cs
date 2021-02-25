using Terraria.ID;
using Terraria.ModLoader;

namespace yeps.Items.weapons.Ranged
{
	public class CopperCoinGun : ModItem
	{
		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("CopperCoinGun");
			Tooltip.SetDefault("infinite copper coins");
		}

		public override void SetDefaults()
		{
			item.damage = 25; 
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
			item.shoot = 158; 
			item.shootSpeed = 10f; 
		}

		public override void AddRecipes() 
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.CopperCoin, 100);
			recipe.AddIngredient(ItemID.CoinGun);
			recipe.AddTile(TileID.MythrilAnvil);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}