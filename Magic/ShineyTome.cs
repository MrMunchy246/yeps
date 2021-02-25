using Terraria.ID;
using Terraria.ModLoader;

namespace yeps.Items.weapons.Magic
{
	public class ShineyTome : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Shiney Tome");
            Tooltip.SetDefault("I sware it's better");
        }
		public override void SetDefaults()
		{
			item.damage = 34;
			item.magic = true;
			item.width = 52;
			item.height = 52;
			item.mana = 2;
			item.scale -= 0.25f;
			item.useTime = 15;
			item.useAnimation = 15;
			item.useStyle = 5;
			item.noMelee = true; 
			item.knockBack = 3;
			item.value = 1000;
			item.rare = 1;
			item.UseSound = SoundID.Item12;
			item.autoReuse = true;
			item.shoot = 15;
			item.shootSpeed = 20f;
		}


		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.AmethystStaff);
			recipe.AddIngredient(ItemID.Amethyst, 10);
			recipe.AddTile(TileID.Anvils); 
			recipe.SetResult(this);
			recipe.AddRecipe();

		}
	}
}
