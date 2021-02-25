using Terraria.ID;
using Terraria.ModLoader;

namespace yeps.Items.weapons
{
	public class TheEye: ModItem
	{
		public override void SetStaticDefaults() 
		{
			// DisplayName.SetDefault("TheEye");
			Tooltip.SetDefault("Only its gaze can kill some of of your most dangerouse enemies \n" +
			"now you are the evil presence");
		}

		public override void SetDefaults() 
		{
			item.damage = 200;
			item.width = 4;
			item.height = 4;
			item.useTime = 10;
			item.useAnimation = 10;
			item.useStyle = 5;
			item.knockBack = 10;
			item.value = 60000;
			item.rare = 6;
			item.UseSound = SoundID.Item103;
			item.shoot = 476;
			item.shootSpeed = 20f;
			item.autoReuse = true;
		}

		public override void AddRecipes() 
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(null, "ForceOfEyeOfCthulhu");
			recipe.AddTile(TileID.MythrilAnvil);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}