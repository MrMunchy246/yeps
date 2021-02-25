using Terraria.ID;
using Terraria.ModLoader;

namespace yeps.Items.weapons.Melee
{
	public class SparkleShortSwordMk2: ModItem
	{
		public override void SetStaticDefaults() 
		{
			// DisplayName.SetDefault("SparkleShortSwordMk2");
			Tooltip.SetDefault("one of the many sparkling shortswords");
		}

		public override void SetDefaults() 
		{
			item.damage = 45;
			item.melee = true;
			item.width = 10;
			item.height = 10;
			item.useTime = 25;
			item.useAnimation = 25;
			item.useStyle = 3;
			item.knockBack = 3;
			item.value = 20000;
			item.rare = 2;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
		}

		public override void AddRecipes() 
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.Sapphire, 10);
			recipe.AddIngredient(null, "SparkleShortSword");
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}