using Terraria.ID;
using Terraria.ModLoader;

namespace yeps.Items.weapons.Magic
{
	public class CopyTome : ModItem
	{
		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("CopyTome");
			Tooltip.SetDefault("what is it now");
		}

		public override void SetDefaults()
		{
			item.damage = 1; 
			item.magic = true;
			item.mana = 1;
			item.width = 40; 
			item.height = 20; 
			item.useTime = 10; 
			item.useAnimation = 10; 
			item.useStyle = 5; 
			item.noMelee = true; 
			item.knockBack = 1; 
			item.value = 0; 
			item.UseSound = SoundID.Item8;
			item.rare = 1; 
			item.autoReuse = true; 
			item.shoot = 145;
			item.shootSpeed = 20f;  
		}

		public override void AddRecipes() 
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.DirtBlock);
			recipe.AddTile(TileID.WorkBenches);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}