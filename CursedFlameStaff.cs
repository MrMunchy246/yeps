using Terraria.ID;
using Terraria.ModLoader;

namespace yeps.Items.weapons
{
	public class CursedFlameStaff : ModItem
	{
		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("CursedFlameStaff");
			Tooltip.SetDefault("ow, it burns");
		}

		public override void SetDefaults()
		{
			item.damage = 200; 
			item.width = 40; 
			item.height = 20; 
			item.useTime = 2; 
			item.useAnimation = 2; 
			item.useStyle = 5; 
			item.noMelee = true; 
			item.knockBack = 1; 
			item.value = 50000; 
			item.rare = 11; 
			item.UseSound = SoundID.Item20; 
			item.autoReuse = true; 
			item.shoot = 95; 
			item.shootSpeed = 40f;  
		}

		public override void AddRecipes() 
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(null, "ForceOfEaterOfWorlds");
			recipe.AddTile(TileID.MythrilAnvil);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}