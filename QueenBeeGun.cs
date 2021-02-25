using Terraria.ID;
using Terraria.ModLoader;

namespace yeps.Items.weapons
{
	public class QueenBeeGun : ModItem
	{
		public override void SetStaticDefaults()
		{
			//DisplayName.SetDefault("QueenBeeGun");
            Tooltip.SetDefault("BEEEEEEES, NOT THE BEEES");
        }
		public override void SetDefaults()
		{
			item.damage = 200;
			item.width = 52;
			item.height = 52;
			item.useTime = 3;
			item.useAnimation = 3;
			item.useStyle = 5;
			item.noMelee = true; 
			item.knockBack = 3;
			item.value = 1000;
			item.rare = 11;
			item.UseSound = SoundID.Item11;
			item.autoReuse = true;
			item.shoot = 181;
			item.shootSpeed = 40f;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(null, "ForceOfQueenBee");
			recipe.AddTile(TileID.MythrilAnvil); 
			recipe.SetResult(this);
			recipe.AddRecipe();

		}
	}
}