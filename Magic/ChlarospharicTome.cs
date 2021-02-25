using Terraria.ID;
using Terraria.ModLoader;

namespace yeps.Items.weapons.Magic
{
	public class ClarospharicTome : ModItem
	{
		public override void SetStaticDefaults()
		{
			//DisplayName.SetDefault("ClarosparicTome");
            Tooltip.SetDefault("What does chlarosparic even mean");
        }
		public override void SetDefaults()
		{
			item.damage = 475;
			item.magic = true;
			item.width = 52;
			item.height = 52;
			item.mana = 10;
			item.useTime = 7;
			item.useAnimation = 7;
			item.useStyle = 5;
			item.noMelee = true; 
			item.knockBack = 3;
			item.value = 1000;
			item.rare = 5;
			item.UseSound = SoundID.Item28;
			item.autoReuse = true;
			item.shoot = 79;
			item.shootSpeed = 20f;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(null, "ClarospharicBar", 10);
			recipe.AddIngredient(ItemID.SpellTome);
			recipe.AddIngredient(ItemID.IceRod);
			recipe.AddIngredient(ItemID.Bell);
			recipe.AddIngredient(ItemID.Harp);
			recipe.AddTile(TileID.LunarCraftingStation); 
			recipe.SetResult(this);
			recipe.AddRecipe();

		}
	}
}