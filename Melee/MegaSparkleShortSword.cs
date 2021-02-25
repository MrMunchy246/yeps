using Terraria.ID;
using Terraria.ModLoader;

namespace yeps.Items.weapons.Melee
{
	public class MegaSparkleShortSword: ModItem
	{
		public override void SetStaticDefaults() 
		{
			// DisplayName.SetDefault("MegaSparkleShortSword");
			Tooltip.SetDefault("one of the many sparkling shortswords");
		}

		public override void SetDefaults() 
		{
			item.damage = 123;
			item.melee = true;
			item.width = 10;
			item.height = 10;
			item.useTime = 10;
			item.useAnimation = 10;
			item.useStyle = 3;
			item.knockBack = 10;
			item.value = 60000;
			item.rare = 6;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
		}

		public override void AddRecipes() 
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.Emerald, 10);
			recipe.AddIngredient(null, "SuperSparkleShortSword");
			recipe.AddIngredient(ItemID.LunarBar, 30);
			recipe.AddIngredient(ItemID.FragmentSolar, 15);
			recipe.AddTile(TileID.LunarCraftingStation);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}