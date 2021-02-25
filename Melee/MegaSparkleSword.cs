using Terraria.ID;
using Terraria.ModLoader;

namespace yeps.Items.weapons.Melee
{
	public class MegaSparkleSword: ModItem
	{
		public override void SetStaticDefaults() 
		{
			// DisplayName.SetDefault("MegaSparkleSword");
			Tooltip.SetDefault("one of the many sparkling swords");
		}

		public override void SetDefaults() 
		{
			item.damage = 100;
			item.melee = true;
			item.width = 4;
			item.height = 4;
			item.useTime = 10;
			item.useAnimation = 10;
			item.useStyle = 1;
			item.knockBack = 10;
			item.value = 60000;
			item.rare = 6;
			item.UseSound = SoundID.Item1;
			item.shoot = 132;
			item.shootSpeed = 20f;
			item.autoReuse = true;
		}

		public override void AddRecipes() 
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.Emerald, 10);
			recipe.AddIngredient(null, "SuperSparkleSword");
			recipe.AddIngredient(ItemID.LunarBar, 30);
			recipe.AddIngredient(ItemID.FragmentSolar, 15);
			recipe.AddTile(TileID.LunarCraftingStation);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}