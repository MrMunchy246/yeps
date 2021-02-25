using Terraria.ID;
using Terraria.ModLoader;

namespace yeps.Items.weapons.Ammo
{
	public class InfiniteGelPack : ModItem
	{
		public override void SetStaticDefaults() 
		{
			//DisplayName.SetDefault("InfiniteGelPack");
			Tooltip.SetDefault("man i hate it when my flamethrower runs out of gel");
		}

		public override void SetDefaults() 
		{
			item.damage = 5;
			item.ranged = true;
			item.width = 8;
			item.height = 8;
			item.consumable = false;
			item.knockBack = 1f;
			item.value = 0;
			item.rare = 2;
			item.ammo = AmmoID.Gel;
		}


		public override void AddRecipes() 
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.Gel, 3996);
			recipe.AddTile(TileID.CrystalBall);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}
