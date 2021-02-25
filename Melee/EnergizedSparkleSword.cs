using Terraria.ID;
using Terraria.ModLoader;

namespace yeps.Items.weapons.Melee
{
	public class EnergizedSparkleSword : ModItem
	{
		public override void SetStaticDefaults() 
		{
			// DisplayName.SetDefault("EnergizedSparkleSword");
			Tooltip.SetDefault("not to be confused with the sparkle sword");
		}

		public override void SetDefaults() 
		{
			item.damage = 21;
			item.melee = true;
			item.width = 1;
			item.height = 1;
			item.useTime = 30;
			item.useAnimation = 30;
			item.useStyle = 1;
			item.knockBack = 5;
			item.shoot = 116;
			item.shootSpeed = 20f;
			item.value = 100000;
			item.rare = 4;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
		}

		public override void AddRecipes() 
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(null, "SparkleEnergy",20);
			recipe.AddIngredient(ItemID.GoldBroadsword);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}