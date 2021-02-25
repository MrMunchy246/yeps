using Terraria.ID;
using Terraria.ModLoader;

namespace yeps.Items.weapons.Melee
{
	public class ExplosiveBunnyWacker : ModItem
	{
		public override void SetStaticDefaults() 
		{
			// DisplayName.SetDefault("ExplosiveBunnyWacker");
			Tooltip.SetDefault("GET DOWN!");
		}

		public override void SetDefaults() 
		{
			item.damage = 350;
			item.melee = true;
			item.width = 2;
			item.height = 2;
			item.useTime = 15;
			item.useAnimation = 15;
			item.useStyle = 1;
			item.shoot = 281;
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
			recipe.AddIngredient(ItemID.ExplosiveBunny, 20);
			recipe.AddIngredient(ItemID.HallowedBar, 12);
			recipe.AddIngredient(ItemID.BeetleHusk, 14);
			recipe.AddTile(TileID.MythrilAnvil);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}