using Terraria.ID;
using Terraria.ModLoader;

namespace yeps.Items.weapons.Ranged
{
	public class MegaSparkleBlaster : ModItem
	{
		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("MegaSparkleGun");
			Tooltip.SetDefault("now we're talking");
		}

		public override void SetDefaults()
		{
			item.damage = 117; 
			item.ranged = true; 
			item.width = 40; 
			item.height = 20; 
			item.useTime = 2; 
			item.useAnimation = 2; 
			item.useStyle = 5; 
			item.noMelee = true; 
			item.knockBack = 1; 
			item.value = 50000; 
			item.rare = 6; 
			item.UseSound = SoundID.Item11; 
			item.autoReuse = true; 
			item.shoot = 10; 
			item.shootSpeed = 40f; 
			item.useAmmo = AmmoID.Bullet; 
		}

		public override void AddRecipes() 
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.Emerald, 10);
			recipe.AddIngredient(ItemID.LunarBar, 30);
			recipe.AddIngredient(null, "SuperSparkleBlaster");
			recipe.AddIngredient(ItemID.FragmentVortex, 15);
			recipe.AddTile(TileID.LunarCraftingStation);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}