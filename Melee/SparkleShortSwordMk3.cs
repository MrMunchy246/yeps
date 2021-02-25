using Terraria.ID;
using Terraria.ModLoader;

namespace yeps.Items.weapons.Melee
{
	public class SparkleShortSwordMk3: ModItem
	{
		public override void SetStaticDefaults() 
		{
			// DisplayName.SetDefault("SparkleShortSwordMk3");
			Tooltip.SetDefault("one of the many sparkling shortswords");
		}

		public override void SetDefaults() 
		{
			item.damage = 53;
			item.melee = true;
			item.width = 10;
			item.height = 10;
			item.useTime = 20;
			item.useAnimation = 20;
			item.useStyle = 3;
			item.knockBack = 1;
			item.value = 30000;
			item.rare = 3;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
		}

		public override void AddRecipes() 
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.Topaz, 10);
			recipe.AddIngredient(null, "SparkleShortSwordMk2");
			recipe.AddIngredient(ItemID.SoulofMight, 20);
			recipe.AddIngredient(ItemID.SoulofSight, 20);
			recipe.AddIngredient(ItemID.SoulofFright, 20);
			recipe.AddTile(TileID.MythrilAnvil);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}