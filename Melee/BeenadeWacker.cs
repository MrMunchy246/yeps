using Terraria.ID;
using Terraria.ModLoader;

namespace yeps.Items.weapons.Melee
{
	public class BeenadeWacker : ModItem
	{
		public override void SetStaticDefaults() 
		{
			// DisplayName.SetDefault("BeenadeWacker");
			Tooltip.SetDefault("BEEEEEEEEEEES");
		}

		public override void SetDefaults() 
		{
			item.damage = 57;
			item.melee = true;
			item.width = 2;
			item.height = 2;
			item.useTime = 15;
			item.useAnimation = 15;
			item.useStyle = 1;
			item.shoot = 183;
			item.shootSpeed = 10f;
			item.knockBack = 13;
			item.value = 20000;
			item.rare = 4;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
			item.useTurn = true;
		}

		public override void AddRecipes() 
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.Beenade, 20);
			recipe.AddIngredient(ItemID.BeeWax, 12);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}