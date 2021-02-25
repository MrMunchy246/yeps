using Terraria.ID;
using Terraria.ModLoader;

namespace yeps.Items.weapons.Melee
{
	public class StickyGrenadeWacker : ModItem
	{
		public override void SetStaticDefaults() 
		{
			// DisplayName.SetDefault("StickyGrenadeWacker");
			Tooltip.SetDefault("GET DOWN!");
		}

		public override void SetDefaults() 
		{
			item.damage = 60;
			item.melee = true;
			item.width = 2;
			item.height = 2;
			item.useTime = 15;
			item.useAnimation = 15;
			item.useStyle = 1;
			item.shoot = 397;
			item.shootSpeed = 10f;
			item.knockBack = 10;
			item.value = 20000;
			item.rare = 4;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
			item.useTurn = true;
		}

		public override void AddRecipes() 
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.StickyGrenade, 20);
			recipe.AddIngredient(ItemID.IronBar, 12);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}