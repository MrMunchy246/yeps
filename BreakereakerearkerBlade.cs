using Terraria.ID;
using Terraria.ModLoader;

namespace yeps.Items.weapons
{
	public class BreakereakerearkerBlade: ModItem
	{
		public override void SetStaticDefaults() 
		{
			// DisplayName.SetDefault("Breakereakerearker Blade");
			Tooltip.SetDefault("That's one large sword");
		}

		public override void SetDefaults() 
		{
			item.damage = 300;
			item.width = 4;
			item.height = 4;
			item.useTime = 10;
			item.useAnimation = 10;
			item.useStyle = 1;
			item.knockBack = 10;
			item.value = 60000;
			item.rare = 11;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
			item.scale = 2f;
		}

		public override void AddRecipes() 
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(null, "ForceOfWallOfFlesh");
			recipe.AddTile(TileID.MythrilAnvil);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}