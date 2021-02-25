using Terraria.ID;
using Terraria.ModLoader;

namespace yeps.Items.weapons.Magic
{
	public class SporeCloud : ModItem
	{
		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("SporeCloud");
			Tooltip.SetDefault("eww it's gross");
		}

		public override void SetDefaults()
		{
			item.damage = 487; 
			item.mana = 30;
			item.width = 40; 
			item.height = 20; 
			item.magic = true;
			item.useTime = 10; 
			item.useAnimation = 10; 
			item.useStyle = 5; 
			item.noMelee = true; 
			item.knockBack = 1f; 
			item.value = 100000; 
			item.noUseGraphic = true;
			item.rare = 11; 
			item.UseSound = SoundID.Item39; 
			item.autoReuse = true; 
			item.shoot = 567;
			item.shootSpeed = 40f;
		}

		public override void AddRecipes() 
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.Vine, 12);
			recipe.AddIngredient(ItemID.JungleSpores, 15);
			recipe.AddIngredient(null, "ClarospharicBar", 20);
			recipe.AddTile(TileID.MythrilAnvil);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}