using Terraria.ID;
using Terraria.ModLoader;

namespace yeps.Items.weapons.Melee
{
	public class SuperSparkleShortSword: ModItem
	{
		public override void SetStaticDefaults() 
		{
			// DisplayName.SetDefault("SuperSparkleShortSword");
			Tooltip.SetDefault("one of the many sparkling shortswords");
		}

		public override void SetDefaults() 
		{
			item.damage = 77;
			item.melee = true;
			item.width = 10;
			item.height = 10;
			item.useTime = 15;
			item.useAnimation = 15;
			item.useStyle = 3;
			item.knockBack = 10;
			item.value = 50000;
			item.rare = 5;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
		}

		public override void AddRecipes() 
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.Ruby, 10);
			recipe.AddIngredient(null, "SparkleShortSwordMk3");
			recipe.AddIngredient(ItemID.BeetleHusk, 5);
			recipe.AddTile(TileID.MythrilAnvil);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}