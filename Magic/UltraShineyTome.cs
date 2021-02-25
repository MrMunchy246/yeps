using Terraria.ID;
using Terraria.ModLoader;

namespace yeps.Items.weapons.Magic
{
	public class UltraShineyTome : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Ultra Shiney Tome");
            Tooltip.SetDefault("Summons a swarm of phantom phoenixes");
        }
		public override void SetDefaults()
		{
			item.damage = 659;
			item.magic = true;
			item.width = 52;
			item.height = 52;
			item.mana = 5;
			item.scale -= 0.25f;
			item.useTime = 3;
			item.useAnimation = 3;
			item.useStyle = 5;
			item.noMelee = true; 
			item.knockBack = 3;
			item.value = 1000;
			item.rare = 11;
			item.UseSound = SoundID.Item20;
			item.autoReuse = true;
			item.shoot = 706;
			item.shootSpeed = 25f;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.Diamond, 10);
			recipe.AddIngredient(ItemID.BeetleHusk, 20);
			recipe.AddIngredient(ItemID.LastPrism);
			recipe.AddIngredient(ItemID.CopperShortsword);
			recipe.AddIngredient(null, "SuperShineyTome");
			recipe.AddIngredient(null, "MegaShineyTome");
			recipe.AddIngredient(null, "ShineyTomeMk3");
			recipe.AddIngredient(null, "ShineyTomeMk2");
			recipe.AddIngredient(null, "ShineyTome");
			recipe.AddIngredient(ItemID.LunarBar, 30);
			recipe.AddIngredient(ItemID.FragmentSolar, 15);
			recipe.AddIngredient(ItemID.FragmentNebula, 15);
			recipe.AddIngredient(ItemID.FragmentStardust, 15);
			recipe.AddIngredient(ItemID.FragmentVortex, 15);
			recipe.SetResult(this);
			recipe.AddRecipe();

		}
	}
}