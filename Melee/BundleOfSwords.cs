using Terraria.ID;
using Terraria.ModLoader;

namespace yeps.Items.weapons.Melee
{
	public class BundleOfSwords: ModItem
	{
		public override void SetStaticDefaults() 
		{
			// DisplayName.SetDefault("BundleOfSwords");
			Tooltip.SetDefault("it's not tied properly");
		}

		public override void SetDefaults() 
		{
			item.damage = 80;
			item.width = 4;
			item.height = 4;
			item.useTime = 30;
			item.useAnimation = 30;
			item.useStyle = 1;
			item.knockBack = 5;
			item.value = 1000;
			item.rare = 2;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
			item.shoot = 48;
			item.shootSpeed = 10f;
			item.melee = true;
		}

		public override void AddRecipes() 
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.ThrowingKnife, 100);
			recipe.AddIngredient(ItemID.RopeCoil, 2);
			recipe.AddTile(TileID.WorkBenches);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}