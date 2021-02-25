using Terraria.ID;
using Terraria.ModLoader;

namespace yeps.Items.weapons.Ranged
{
	public class PlatinumCoinGun : ModItem
	{
		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("PlatinumCoinGun");
			Tooltip.SetDefault("infinite platinum coins");
		}

		public override void SetDefaults()
		{
			item.damage = 200; 
			item.ranged = true; 
			item.width = 40; 
			item.height = 20; 
			item.useTime = 8; 
			item.useAnimation = 8; 
			item.useStyle = 5; 
			item.noMelee = true; 
			item.knockBack = 1; 
			item.value = 1000000; 
			item.rare = 11; 
			item.UseSound = SoundID.Item11; 
			item.autoReuse = true; 
			item.shoot = 160; 
			item.shootSpeed = 10f; 
		}

		public override void AddRecipes() 
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.PlatinumCoin, 10);
			recipe.AddIngredient(null,"GoldCoinGun");
			recipe.AddTile(TileID.MythrilAnvil);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}