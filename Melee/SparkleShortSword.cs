using Terraria.ID;
using Terraria.ModLoader;

namespace yeps.Items.weapons.Melee
{
	public class SparkleShortSword : ModItem
	{
		public override void SetStaticDefaults() 
		{
			// DisplayName.SetDefault("SparkleShortSword");
			Tooltip.SetDefault("one of the many sparkling shortswords");
		}

		public override void SetDefaults() 
		{
			item.damage = 30;
			item.melee = true;
			item.width = 10;
			item.height = 10;
			item.useTime = 30;
			item.useAnimation = 30;
			item.useStyle = 3;
			item.knockBack = 1;
			item.value = 10000;
			item.rare = 1;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
		}

		public override void AddRecipes() 
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.Amethyst, 10);
			recipe.AddIngredient(ItemID.CopperShortsword);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}