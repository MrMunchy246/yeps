using Terraria.ID;
using Terraria.ModLoader;

namespace yeps.Items.weapons.Ranged
{
	public class BigBang : ModItem
	{
		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("BigBang");
		}

		public override void SetDefaults()
		{
			item.damage = 14372; 
			item.width = 40; 
			item.height = 20; 
			item.useTime = 200; 
			item.useAnimation = 200; 
			item.useStyle = 5; 
			item.noMelee = true; 
			item.knockBack = 0f; 
			item.value = 0; 
			item.rare = 11; 
			item.UseSound = SoundID.Item69; 
			item.autoReuse = true; 
			item.shoot = 12;
			item.shootSpeed = 35f;  
			item.ranged = true;
			item.useAmmo = AmmoID.FallenStar;
		}

		public override void AddRecipes() 
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.FragmentSolar, 25);
			recipe.AddIngredient(ItemID.FragmentNebula, 25);
			recipe.AddIngredient(ItemID.FragmentVortex, 25);
			recipe.AddIngredient(ItemID.FragmentStardust, 25);
			recipe.AddIngredient(ItemID.LunarBar, 10);
			recipe.AddIngredient(ItemID.StarCannon);
			recipe.AddIngredient(null, "ClarospharicBar", 40);
			recipe.AddIngredient(null, "BoneMarrow", 5);
			recipe.AddTile(TileID.LunarCraftingStation);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}