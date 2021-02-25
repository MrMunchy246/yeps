using Terraria.ID;
using Terraria.ModLoader;

namespace yeps.Items.weapons.Melee
{
	public class BaseBallBat : ModItem
	{
		public override void SetStaticDefaults() 
		{
			// DisplayName.SetDefault("BaseBallBat");
			Tooltip.SetDefault("And she's out of here");
		}

		public override void SetDefaults() 
		{
			item.damage = 1;
			item.melee = true;
			item.width = 10;
			item.height = 10;
			item.useTime = 20;
			item.useAnimation = 20;
			item.useStyle = 1;
			item.knockBack = 9000000000000;
			item.value = 1000;
			item.rare = 2;
			item.UseSound = SoundID.Item10;
			item.autoReuse = true;
		}

		public override void AddRecipes() 
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.Wood, 100);
			recipe.AddIngredient(ItemID.IronBar, 30);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}