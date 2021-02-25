using Terraria.ID;
using Terraria.ModLoader;

namespace yeps.Items.weapons.Melee
{
	public class CopyBlade: ModItem
	{
		public override void SetStaticDefaults() 
		{
			// DisplayName.SetDefault("CopyBlade");
			Tooltip.SetDefault("what does it do now?");
		}

		public override void SetDefaults() 
		{
			item.damage = 1;
			item.width = 4;
			item.height = 4;
			item.useTime = 20;
			item.useAnimation = 20;
			item.useStyle = 1;
			item.knockBack = 0;
			item.value = 0;
			item.rare = 1;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
			item.shoot = 95;
			item.shootSpeed = 20f;
			item.melee = true;
		}

		public override void AddRecipes() 
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.DirtBlock, 1);
			recipe.AddTile(TileID.WorkBenches);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}