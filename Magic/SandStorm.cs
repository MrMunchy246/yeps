using Terraria.ID;
using Terraria.ModLoader;

namespace yeps.Items.weapons.Magic
{
	public class SandStorm : ModItem
	{
		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("SandStorm");
			Tooltip.SetDefault("summons a fun storm");
		}

		public override void SetDefaults()
		{
			item.damage = 457; 
			item.width = 40; 
			item.height = 20; 
			item.magic = true;
			item.useTime = 10; 
			item.useAnimation = 10; 
			item.useStyle = 5; 
			item.noMelee = true; 
			item.knockBack = 1; 
			item.mana = 13;
			item.value = 100000; 
			item.rare = 11; 
			item.UseSound = SoundID.Item124; 
			item.autoReuse = true; 
			item.shoot = 656;
			item.shootSpeed = 0f; 
		}

		public override void AddRecipes() 
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.SandBlock, 15);
			recipe.AddIngredient(null, "ClarospharicBar", 20);
			recipe.AddTile(TileID.MythrilAnvil);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}