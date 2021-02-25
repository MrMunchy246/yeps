using Terraria.ID;
using Terraria.ModLoader;

namespace yeps.Items.weapons
{
	public class WoodenBow : ModItem
	{
		public override void SetStaticDefaults() 
		{
			// DisplayName.SetDefault("WoodenBow");
			Tooltip.SetDefault("toatlly normal");
		}

		public override void SetDefaults() 
		{
			item.damage = 9376; 
			item.width = 40; 
			item.height = 20; 
			item.useTime = 20; 
			item.useAnimation = 20; 
			item.useStyle = 5; 
			item.noMelee = true; 
			item.knockBack = 4; 
			item.value = 10000; 
			item.rare = 1; 
			item.UseSound = SoundID.Item5; 
			item.reuseDelay = 200;
			item.shoot = 140; 
			item.shootSpeed = 40f; 
		}

		public override void AddRecipes() 
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(null, "BreakereakerearkerBlade");
			recipe.AddIngredient(null, "CursedFlameStaff");
			recipe.AddIngredient(null, "IchorStaff");
			recipe.AddIngredient(null, "OverloadedSlimeGun");
			recipe.AddIngredient(null, "QueenBeeGun");
			recipe.AddIngredient(null, "SkullOfSkulls");
			recipe.AddIngredient(null, "TheEye");
			recipe.AddTile(TileID.MythrilAnvil);
			recipe.SetResult(this);
			recipe.AddRecipe();
			
			recipe = new ModRecipe(mod);
			recipe.AddIngredient(null, "ForceOfPrehardmode");
			recipe.AddTile(TileID.MythrilAnvil); 
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}