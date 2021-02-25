using Terraria.ID;
using Terraria.ModLoader;

namespace yeps.Items.weapons.Ranged
{
	public class SparkleBowMk3 : ModItem
	{
		public override void SetStaticDefaults() 
		{
			// DisplayName.SetDefault("SparkleBowMk3");
			Tooltip.SetDefault("now with faster arrows");
		}

		public override void SetDefaults() 
		{
			item.damage = 30; 
			item.ranged = true; 
			item.width = 40; 
			item.height = 20; 
			item.useTime = 10; 
			item.useAnimation = 10; 
			item.useStyle = 5; 
			item.noMelee = true; 
			item.knockBack = 8; 
			item.value = 30000; 
			item.rare = 3; 
			item.UseSound = SoundID.Item5; 
			item.autoReuse = true; 
			item.shoot = 10; 
			item.shootSpeed = 12f; 
			item.useAmmo = AmmoID.Arrow; 
		}

		public override void AddRecipes() 
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.Topaz, 10);
			recipe.AddIngredient(ItemID.SoulofSight, 10);
			recipe.AddIngredient(ItemID.SoulofMight, 10);
			recipe.AddIngredient(ItemID.SoulofFright, 10);
			recipe.AddIngredient(null, "SparkleBowMk2");
			recipe.AddTile(TileID.MythrilAnvil);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}