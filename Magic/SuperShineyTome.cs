using Terraria.ID;
using Terraria.ModLoader;

namespace yeps.Items.weapons.Magic
{
	public class SuperShineyTome : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Super Shiney Tome");
            Tooltip.SetDefault("fires a gungir speare straight from odin himself");
        }
		public override void SetDefaults()
		{
			item.damage = 267;
			item.magic = true;
			item.width = 52;
			item.height = 52;
			item.mana = 15;
			item.scale -= 0.25f;
			item.useTime = 20;
			item.useAnimation = 20;
			item.useStyle = 5;
			item.noMelee = true; 
			item.knockBack = 3;
			item.value = 1000;
			item.rare = 5;
			item.UseSound = SoundID.Item18;
			item.autoReuse = true;
			item.shoot = mod.ProjectileType("GungirSpear");
			item.shootSpeed = 20f;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(null, "ShineyTomeMk3");
			recipe.AddIngredient(ItemID.Ruby, 10);
			recipe.AddIngredient(ItemID.BeetleHusk, 10);
			recipe.AddTile(TileID.MythrilAnvil); 
			recipe.SetResult(this);
			recipe.AddRecipe();

		}
	}
}