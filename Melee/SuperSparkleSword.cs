using Terraria.ID;
using Terraria.ModLoader;

namespace yeps.Items.weapons.Melee
{
	public class SuperSparkleSword: ModItem
	{
		public override void SetStaticDefaults() 
		{
			// DisplayName.SetDefault("SuperSparkleSword");
			Tooltip.SetDefault("one of the many sparkling swords");
		}

		public override void SetDefaults() 
		{
			item.damage = 67;
			item.melee = true;
			item.width = 3;
			item.height = 3;
			item.useTime = 15;
			item.useAnimation = 15;
			item.useStyle = 1;
			item.knockBack = 10;
			item.value = 50000;
			item.rare = 5;
			item.UseSound = SoundID.Item1;
			item.shoot = 451;
			item.shootSpeed = 20f;
			item.autoReuse = true;
		}

		public override void AddRecipes() 
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.Ruby, 10);
			recipe.AddIngredient(null, "SparkleSwordMk3");
			recipe.AddIngredient(ItemID.BeetleHusk, 5);
			recipe.AddTile(TileID.MythrilAnvil);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}