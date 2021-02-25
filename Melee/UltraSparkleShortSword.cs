using Terraria.ID;
using Terraria.ModLoader;

namespace yeps.Items.weapons.Melee
{
	public class UltraSparkleShortSword: ModItem
	{
		public override void SetStaticDefaults() 
		{
			// DisplayName.SetDefault("UltraSparkleShortSword");
			Tooltip.SetDefault("It's very loud");
		}

		public override void SetDefaults() 
		{
			item.damage = 748;
			item.melee = true;
			item.width = 20;
			item.height = 20;
			item.useTime = 5;
			item.useAnimation = 5;
			item.useStyle = 3;
			item.knockBack = 10;
			item.value = 100000000;
			item.rare = 11;
			item.UseSound = SoundID.Item24;
			item.autoReuse = true;
		}

		public override void AddRecipes() 
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.Diamond, 10);
			recipe.AddIngredient(ItemID.BeetleHusk, 20);
			recipe.AddIngredient(ItemID.Meowmere);
			recipe.AddIngredient(ItemID.CopperShortsword);
			recipe.AddIngredient(null, "SuperSparkleShortSword");
			recipe.AddIngredient(null, "MegaSparkleShortSword");
			recipe.AddIngredient(null, "SparkleShortSwordMk3");
			recipe.AddIngredient(null, "SparkleShortSwordMk2");
			recipe.AddIngredient(null, "SparkleShortSword");
			recipe.AddIngredient(ItemID.LunarBar, 30);
			recipe.AddIngredient(ItemID.FragmentSolar, 15);
			recipe.AddIngredient(ItemID.FragmentNebula, 15);
			recipe.AddIngredient(ItemID.FragmentStardust, 15);
			recipe.AddIngredient(ItemID.FragmentVortex, 15);
			recipe.AddTile(TileID.LunarCraftingStation);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}