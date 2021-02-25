using Terraria.ID;
using Terraria.ModLoader;

namespace yeps.Items.weapons.Melee
{
	public class CursedFlameBlade : ModItem
	{
		public override void SetStaticDefaults() 
		{
			// DisplayName.SetDefault("CursedFlameBlade");
			Tooltip.SetDefault("now it's green");
		}

		public override void SetDefaults() 
		{
			item.damage = 168;
			item.melee = true;
			item.width = 2;
			item.height = 2;
			item.useTime = 15;
			item.useAnimation = 15;
			item.useStyle = 1;
			item.shoot = 95;
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
			recipe.AddIngredient(ItemID.HallowedBar, 20);
			recipe.AddIngredient(ItemID.SoulofSight, 35);
			recipe.AddIngredient(null, "FlameBlade");
			recipe.AddTile(TileID.MythrilAnvil);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}