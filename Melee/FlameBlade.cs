using Terraria.ID;
using Terraria.ModLoader;

namespace yeps.Items.weapons.Melee
{
	public class FlameBlade : ModItem
	{
		public override void SetStaticDefaults() 
		{
			// DisplayName.SetDefault("FlameBlade");
			Tooltip.SetDefault("AAH! it's on fire!");
		}

		public override void SetDefaults() 
		{
			item.damage = 68;
			item.melee = true;
			item.width = 2;
			item.height = 2;
			item.useTime = 15;
			item.useAnimation = 15;
			item.useStyle = 1;
			item.shoot = 34;
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
			recipe.AddIngredient(ItemID.HellstoneBar, 20);
			recipe.AddIngredient(ItemID.Flamelash);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}