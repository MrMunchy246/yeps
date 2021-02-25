using Terraria.ID;
using Terraria.ModLoader;

namespace yeps.Items.weapons.Ranged
{
	public class DirtGun : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Mudgun");
            Tooltip.SetDefault("This is an even better idea!");
        }
		public override void SetDefaults()
		{
			item.damage = 56;
			item.ranged = true;
			item.width = 52;
			item.height = 52;
			item.useTime = 16;
			item.useAnimation = 16;
			item.useStyle = 5;
			item.noMelee = true; 
			item.knockBack = 5;
			item.value = 1000;
			item.rare = 0;
			item.UseSound = SoundID.Item11;
			item.useAmmo = mod.ProjectileType("MudBall"); 
			item.autoReuse = true;
			item.shoot = 39;
			item.shootSpeed = 20f;
		}


		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.DirtBlock, 15);
			recipe.AddIngredient(ItemID.WaterBucket, 3);
			recipe.AddIngredient(ItemID.Sandgun);
			recipe.AddTile(TileID.Anvils); 
			recipe.SetResult(this);
			recipe.AddRecipe();

		}
	}
}
