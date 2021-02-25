using Terraria.ID;
using Terraria.ModLoader;

namespace yeps.Items.weapons.Magic
{
	public class MinorTomeOfPurity : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Minor Tome of Purity");
			Tooltip.SetDefault("Fires some purification powder");
		}

		public override void SetDefaults()
		{
			item.damage = 0; 
			item.magic = true;
			item.mana = 15;
			item.width = 40; 
			item.height = 20; 
			item.useTime = 10; 
			item.useAnimation = 10; 
			item.useStyle = 5; 
			item.noMelee = true; 
			item.knockBack = 1; 
			item.value = 0; 
			item.UseSound = SoundID.Item8;
			item.rare = 1; 
			item.autoReuse = true; 
			item.shoot = 10;
			item.shootSpeed = 10f;  
		}

		public override void AddRecipes() 
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.PurificationPowder, 30);
			recipe.AddIngredient(ItemID.SpellTome);
			recipe.AddTile(TileID.CrystalBall);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}