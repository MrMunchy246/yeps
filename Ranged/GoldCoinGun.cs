using Terraria.ID;
using Terraria.ModLoader;

namespace yeps.Items.weapons.Ranged
{
	public class GoldCoinGun : ModItem
	{
		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("GoldCoinGun");
			Tooltip.SetDefault("infinite gold coins");
		}

		public override void SetDefaults()
		{
			item.damage = 100; 
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
			item.shoot = 160; 
			item.shootSpeed = 10f; 
		}

		public override void AddRecipes() 
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.GoldCoin, 100);
			recipe.AddIngredient(null,"SilverCoinGun");
			recipe.AddTile(TileID.MythrilAnvil);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}