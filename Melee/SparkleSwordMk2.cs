using Terraria.ID;
using Terraria.ModLoader;

namespace yeps.Items.weapons.Melee
{
	public class SparkleSwordMk2: ModItem
	{
		public override void SetStaticDefaults() 
		{
			// DisplayName.SetDefault("SparkleSwordMk2");
			Tooltip.SetDefault("one of the many sparkling swords");
		}

		public override void SetDefaults() 
		{
			item.damage = 27;
			item.melee = true;
			item.width = 2;
			item.height = 2;
			item.useTime = 25;
			item.useAnimation = 25;
			item.useStyle = 1;
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
			recipe.AddIngredient(null, "SparkleSword");
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}