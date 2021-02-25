using Terraria.ID;
using Terraria.ModLoader;

namespace yeps.Items.weapons.Magic
{
	public class ElectrospharicEnergyCannon : ModItem
	{
		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("ElectrospharicEnergyCannon");
			Tooltip.SetDefault("what makes chlorospharic spharic");
		}

		public override void SetDefaults()
		{
			item.damage = 367; 
			item.width = 40; 
			item.height = 20; 
			item.magic = true;
			item.useTime = 10; 
			item.useAnimation = 10; 
			item.useStyle = 5; 
			item.noMelee = true; 
			item.knockBack = 14f; 
			item.value = 100000; 
			item.rare = 6; 
			item.UseSound = SoundID.Item92; 
			item.autoReuse = true; 
			item.shoot = 443;
			item.shootSpeed = 20f;  
			item.mana = 15;
		}

		public override void AddRecipes() 
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.MartianConduitPlating, 30);
			recipe.AddIngredient(null, "ClarospharicBar", 10);
			recipe.AddTile(TileID.MythrilAnvil);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}