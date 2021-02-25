using Terraria.ID;
using Terraria.ModLoader;

namespace yeps.Items.weapons.Magic
{
	public class TomeOfPurity : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Greater Tome of Purity");
			Tooltip.SetDefault("Fires a green clentaminator shot");
		}

		public override void SetDefaults()
		{
			item.damage = 0; 
			item.magic = true;
			item.mana = 15;
			item.width = 40; 
			item.height = 20; 
			item.useTime = 5; 
			item.useAnimation = 5; 
			item.useStyle = 5; 
			item.noMelee = true; 
			item.knockBack = 1; 
			item.value = 0; 
			item.UseSound = SoundID.Item8;
			item.rare = 1; 
			item.autoReuse = true; 
			item.shoot = 145;
			item.shootSpeed = 20f;  
		}

		public override void AddRecipes() 
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.GreenSolution, 999);
			recipe.AddIngredient(null, "MinorTomeOfPurity");
			recipe.AddTile(TileID.CrystalBall);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}