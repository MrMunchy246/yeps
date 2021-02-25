using Terraria.ID;
using Terraria.ModLoader;

namespace yeps.Items.weapons
{
	public class SkullOfSkulls: ModItem
	{
		public override void SetStaticDefaults() 
		{
			// DisplayName.SetDefault("Skull Of Skulls");
			Tooltip.SetDefault("nyeeheheey");
		}

		public override void SetDefaults() 
		{
			item.damage = 200;
			item.width = 4;
			item.height = 4;
			item.useTime = 2;
			item.useAnimation = 10;
			item.useStyle = 5;
			item.knockBack = 10;
			item.value = 60000;
			item.rare = 6;
			item.UseSound = SoundID.Item20;
			item.shoot = 585;
			item.shootSpeed = 40f;
			item.autoReuse = true;
		}

		public override void AddRecipes() 
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(null, "ForceOfSkeletron");
			recipe.AddTile(TileID.MythrilAnvil);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}