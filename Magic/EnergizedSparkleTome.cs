using Terraria.ID;
using Terraria.ModLoader;

namespace yeps.Items.weapons.Magic
{
	public class EnergizedSparkleTome : ModItem
	{
		public override void SetStaticDefaults()
		{
			//DisplayName.SetDefault("EnergizedSparkleTome");
            Tooltip.SetDefault("not to be confused with the shiney tome");
        }
		public override void SetDefaults()
		{
			item.damage = 16;
			item.magic = true;
			item.width = 52;
			item.height = 52;
			item.mana = 5;
			item.useTime = 7;
			item.useAnimation = 7;
			item.useStyle = 5;
			item.noMelee = true; 
			item.knockBack = 3;
			item.value = 1000;
			item.rare = 5;
			item.UseSound = SoundID.Item12;
			item.autoReuse = true;
			item.shoot = 16;
			item.shootSpeed = 20f;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(null, "SparkleEnergy", 20);
			recipe.AddIngredient(ItemID.FallenStar, 5);
			recipe.AddTile(TileID.Anvils); 
			recipe.SetResult(this);
			recipe.AddRecipe();

		}
	}
}
