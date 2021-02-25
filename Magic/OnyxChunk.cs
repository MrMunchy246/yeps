using Terraria.ID;
using Terraria.ModLoader;

namespace yeps.Items.weapons.Magic
{
	public class OnyxChunk : ModItem
	{
		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("OnyxChunck");
			Tooltip.SetDefault("Lauches a peice of onyx");
		}

		public override void SetDefaults()
		{
			item.damage = 476; 
			item.width = 40; 
			item.height = 20; 
			item.magic = true;
			item.useTime = 10; 
			item.useAnimation = 10; 
			item.useStyle = 5; 
			item.noUseGraphic = true;
			item.mana = 5;
			item.noMelee = true; 
			item.knockBack = 10f; 
			item.value = 100000; 
			item.rare = 11; 
			item.UseSound = SoundID.Item39; 
			item.autoReuse = true; 
			item.shoot = 661;
			item.shootSpeed = 20f;  
		}

		public override void AddRecipes() 
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.Diamond, 12);
			recipe.AddIngredient(ItemID.Obsidian, 15);
			recipe.AddIngredient(null, "ClarospharicBar", 20);
			recipe.AddTile(TileID.MythrilAnvil);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}