using Terraria.ID;
using Terraria.ModLoader;

namespace yeps.Items.weapons.Magic
{
	public class ShineyTomeMk2 : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Shiney Tome Mk2");
            Tooltip.SetDefault("fires a barrage of stars");
        }
		public override void SetDefaults()
		{
			item.damage = 54;
			item.magic = true;
			item.width = 52;
			item.height = 52;
			item.mana = 5;
			item.scale -= 0.25f;
			item.useTime = 10;
			item.useAnimation = 10;
			item.useStyle = 5;
			item.noMelee = true; 
			item.knockBack = 3;
			item.value = 1000;
			item.rare = 2;
			item.UseSound = SoundID.Item12;
			item.autoReuse = true;
			item.shoot = 503;
			item.shootSpeed = 20f;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(null, "ShineyTome");
			recipe.AddIngredient(ItemID.Sapphire, 10);
			recipe.AddTile(TileID.Anvils); 
			recipe.SetResult(this);
			recipe.AddRecipe();

		}
	}
}
