using Terraria.ID;
using Terraria.ModLoader;

namespace yeps.Items.weapons.Magic
{
	public class MegaShineyTome : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Mega Shiney Tome");
            Tooltip.SetDefault("fires a giant fire ball");
        }
		public override void SetDefaults()
		{
			item.damage = 983;
			item.magic = true;
			item.width = 52;
			item.height = 52;
			item.mana = 30;
			item.useTime = 30;
			item.useAnimation = 30;
			item.useStyle = 5;
			item.scale -= 0.25f;
			item.noMelee = true; 
			item.knockBack = 3;
			item.value = 1000;
			item.rare = 5;
			item.UseSound = SoundID.Item20;
			item.autoReuse = true;
			item.shoot = mod.ProjectileType("BigBall");
			item.shootSpeed = 40f;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(null, "SuperShineyTome");
			recipe.AddIngredient(ItemID.Emerald, 10);
			recipe.AddIngredient(ItemID.LunarBar, 20);
			recipe.AddIngredient(ItemID.FragmentNebula, 10);
			recipe.AddTile(TileID.LunarCraftingStation); 
			recipe.SetResult(this);
			recipe.AddRecipe();

		}
	}
}