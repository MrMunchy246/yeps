using Terraria.ID;
using Terraria.ModLoader;

namespace yeps.Items.weapons.Ranged
{
	public class MegaSparkleBow : ModItem
	{
		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("MegaSparkleBow");
			Tooltip.SetDefault("NOTE: dispite it's looks it does NOT fire arrows from the sky");
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
			item.UseSound = SoundID.Item5; 
			item.autoReuse = true; 
			item.shoot = 10; 
			item.shootSpeed = 40f; 
			item.useAmmo = AmmoID.Arrow; 
		}

		public override void AddRecipes() 
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.Emerald, 10);
			recipe.AddIngredient(ItemID.LunarBar, 30);
			recipe.AddIngredient(null, "SuperSparkleShotBow");
			recipe.AddIngredient(ItemID.FragmentVortex, 15);
			recipe.AddTile(TileID.LunarCraftingStation);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}