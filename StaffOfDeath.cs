using Terraria.ID;
using Terraria.ModLoader;

namespace yeps.Items.weapons
{
	public class StaffOfDeath : ModItem
	{
		public override void SetStaticDefaults()
		{
			//DisplayName.SetDefault("StaffOfDeath");
            Tooltip.SetDefault("basiclly kills you");
        }
		public override void SetDefaults()
		{
			item.damage = 700;
			item.magic = true;
			item.width = 52;
			item.height = 52;
			item.mana = 1;
			item.useTime = 3;
			item.useAnimation = 3;
			item.useStyle = 5;
			item.noMelee = true; 
			item.knockBack = 3;
			item.value = 1000;
			item.rare = 11;
			item.UseSound = SoundID.Item20;
			item.autoReuse = true;
			item.shoot = 465;
			item.shootSpeed = 1f;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.CopperBar, 10);
			recipe.AddIngredient(null, "LightningRod");
			recipe.SetResult(this);
			recipe.AddRecipe();

		}
	}
}