using Terraria.ID;
using Terraria.ModLoader;

namespace yeps.Items.weapons.Ranged
{
	public class SparkleBow : ModItem
	{
		public override void SetStaticDefaults() 
		{
			// DisplayName.SetDefault("SparkleBow");
			Tooltip.SetDefault("We've got bows now");
		}

		public override void SetDefaults() 
		{
			item.damage = 10; 
			item.ranged = true; 
			item.width = 40; 
			item.height = 20; 
			item.useTime = 20; 
			item.useAnimation = 20; 
			item.useStyle = 5; 
			item.noMelee = true; 
			item.knockBack = 4; 
			item.value = 10000; 
			item.rare = 1; 
			item.UseSound = SoundID.Item5; 
			item.autoReuse = true; 
			item.shoot = 1; 
			item.shootSpeed = 20f; 
			item.useAmmo = AmmoID.Arrow; 
		}

		public override void AddRecipes() 
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.Amethyst, 10);
			recipe.AddIngredient(ItemID.CopperBow, 5);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}