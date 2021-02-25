using Terraria.ID;
using Terraria.ModLoader;

namespace yeps.Items.weapons.Melee
{
	public class ChlarospharicBlade : ModItem
	{
		public override void SetStaticDefaults() 
		{
			// DisplayName.SetDefault("ChlarosharicBlade");
			Tooltip.SetDefault("Can anyone even define chlarospharic?");
		}

		public override void SetDefaults() 
		{
			item.damage = 723;
			item.melee = true;
			item.width = 10;
			item.height = 10;
			item.useTime = 10;
			item.useAnimation = 10;
			item.useStyle = 1;
			item.shoot = 116;
			item.shootSpeed = 20f;
			item.knockBack = 10;
			item.scale = 2f;
			item.value = 60000;
			item.rare = 6;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
		}

		public override void AddRecipes() 
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(null, "ClarospharicBar", 10);
			recipe.AddIngredient(ItemID.BeamSword, 30);
			recipe.AddIngredient(ItemID.IceBlade, 15);
			recipe.AddTile(TileID.LunarCraftingStation);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}