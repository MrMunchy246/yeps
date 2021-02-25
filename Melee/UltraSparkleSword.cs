using Terraria.ID;
using Terraria.ModLoader;

namespace yeps.Items.weapons.Melee
{
	public class UltraSparkleSword: ModItem
	{
		public override void SetStaticDefaults() 
		{
			// DisplayName.SetDefault("UltraSparkleSword");
			Tooltip.SetDefault("It's very loud");
		}

		public override void SetDefaults() 
		{
			item.damage = 848;
			item.melee = true;
			item.width = 5;
			item.height = 5;
			item.useTime = 5;
			item.useAnimation = 5;
			item.useStyle = 1;
			item.knockBack = 10;
			item.value = 100000000;
			item.rare = 11;
			item.UseSound = SoundID.Item23;
			item.shoot = 660;
			item.shootSpeed = 30f;
			item.autoReuse = true;
		}

		public override void AddRecipes() 
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.Diamond, 10);
			recipe.AddIngredient(ItemID.BeetleHusk, 20);
			recipe.AddIngredient(ItemID.Meowmere);
			recipe.AddIngredient(ItemID.CopperShortsword);
			recipe.AddIngredient(null, "SuperSparkleSword");
			recipe.AddIngredient(null, "MegaSparkleSword");
			recipe.AddIngredient(null, "SparkleSwordMk3");
			recipe.AddIngredient(null, "SparkleSwordMk2");
			recipe.AddIngredient(null, "SparkleSword");
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