using Terraria.ID;
using Terraria.ModLoader;

namespace yeps.Items.weapons.Magic
{
	public class CatBomber : ModItem
	{
		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("CatBomber");
			Tooltip.SetDefault("meow");
		}

		public override void SetDefaults()
		{
			item.damage = 567; 
			item.magic = true;
			item.mana = 15;
			item.width = 40; 
			item.height = 20; 
			item.useTime = 10; 
			item.useAnimation = 10; 
			item.useStyle = 5; 
			item.noMelee = true; 
			item.knockBack = 10; 
			item.value = 100000; 
			item.UseSound = SoundID.Item58;
			item.rare = 11; 
			item.autoReuse = true; 
			item.shoot = 502;
			item.shootSpeed = 20f;  
		}

		public override void AddRecipes() 
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.Meowmere);
			recipe.AddIngredient(ItemID.LunarBar, 5);
			recipe.AddIngredient(ItemID.SpellTome);
			recipe.AddIngredient(null, "ClarospharicBar", 10);
			recipe.AddTile(TileID.MythrilAnvil);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}