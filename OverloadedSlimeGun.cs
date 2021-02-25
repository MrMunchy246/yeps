using Terraria.ID;
using Terraria.ModLoader;

namespace yeps.Items.weapons
{
	public class OverloadedSlimeGun : ModItem
	{
		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("OverloadedSlimeGun");
			Tooltip.SetDefault("slather slime on top of all your eneimes");
		}

		public override void SetDefaults()
		{
			item.width = 40; 
			item.height = 20; 
			item.useTime = 2; 
			item.useAnimation = 2; 
			item.useStyle = 5; 
			item.noMelee = true; 
			item.knockBack = 1; 
			item.value = 50000; 
			item.rare = 6; 
			item.UseSound = SoundID.Item21; 
			item.autoReuse = true; 
			item.shoot = 406; 
			item.shootSpeed = 40f; 
		}

		public override void AddRecipes() 
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(null, "ForceOfKingSlime");
			recipe.AddTile(TileID.MythrilAnvil);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}