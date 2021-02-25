using Terraria.ID;
using Terraria.ModLoader;

namespace yeps.Items.weapons.Ranged
{
	public class SparkleBowMk2 : ModItem
	{
		public override void SetStaticDefaults() 
		{
			// DisplayName.SetDefault("SparkleBowMk2");
			Tooltip.SetDefault("even stronger!");
		}

		public override void SetDefaults() 
		{
			item.damage = 20; 
			item.ranged = true; 
			item.width = 40; 
			item.height = 20; 
			item.useTime = 15; 
			item.useAnimation = 15; 
			item.useStyle = 5; 
			item.noMelee = true; 
			item.knockBack = 6; 
			item.value = 20000; 
			item.rare = 2; 
			item.UseSound = SoundID.Item5; 
			item.autoReuse = true; 
			item.shoot = 5; 
			item.shootSpeed = 14f; 
			item.useAmmo = AmmoID.Arrow; 
		}

		public override void AddRecipes() 
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.Sapphire, 10);
			recipe.AddIngredient(null, "SparkleBow");
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}