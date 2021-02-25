using Terraria.ID;
using Terraria.ModLoader;

namespace yeps.Items.weapons.Ranged
{
	public class FlameFlasher : ModItem
	{
		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("FlameBuster");
			Tooltip.SetDefault("ha ha, and they said I was crazy");
		}

		public override void SetDefaults()
		{
			item.damage = 464; 
			item.ranged = true; 
			item.width = 40; 
			item.height = 20; 
			item.useTime = 1; 
			item.useAnimation = 6; 
			item.useStyle = 5; 
			item.noMelee = true; 
			item.knockBack = 0.3f; 
			item.value = 1000000; 
			item.rare = 6; 
			item.UseSound = SoundID.Item88; 
			item.autoReuse = true; 
			item.shoot = 85; 
			item.shootSpeed = 10f; 
			item.useAmmo = AmmoID.Gel; 
		}

		public override void AddRecipes() 
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.Flamethrower);
			recipe.AddIngredient(ItemID.Gel, 20);
			recipe.AddIngredient(null, "ClarospharicBar", 10);
			recipe.AddTile(TileID.LunarCraftingStation);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}