using Terraria.ID;
using Terraria.ModLoader;

namespace yeps.Items.weapons.Ranged
{
	public class Flamelasher : ModItem
	{
		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Flamelasher");
			Tooltip.SetDefault("burn them all.");
		}

		public override void SetDefaults()
		{
			item.damage = 75; 
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
			item.UseSound = SoundID.Item11; 
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
			recipe.AddIngredient(ItemID.HallowedBar, 15);
			recipe.AddTile(TileID.MythrilAnvil);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}