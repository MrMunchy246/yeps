using Terraria.ID;
using Terraria.ModLoader;

namespace yeps.Items.weapons.Magic
{
	public class ShineyTomeMk3 : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Shiney Tome Mk3");
            Tooltip.SetDefault("fires a song note");
        }
		public override void SetDefaults()
		{
			item.damage = 96;
			item.magic = true;
			item.width = 52;
			item.height = 52;
			item.mana = 10;
			item.scale -= 0.25f;
			item.useTime = 7;
			item.useAnimation = 7;
			item.useStyle = 5;
			item.noMelee = true; 
			item.knockBack = 3;
			item.value = 1000;
			item.rare = 5;
			item.UseSound = SoundID.Item26;
			item.autoReuse = true;
			item.shoot = 76;
			item.shootSpeed = 20f;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(null, "ShineyTomeMk2");
			recipe.AddIngredient(ItemID.Topaz, 10);
			recipe.AddIngredient(ItemID.SoulofMight);
			recipe.AddIngredient(ItemID.SoulofSight);
			recipe.AddIngredient(ItemID.SoulofFright);
			recipe.AddTile(TileID.MythrilAnvil); 
			recipe.SetResult(this);
			recipe.AddRecipe();

		}
	}
}
