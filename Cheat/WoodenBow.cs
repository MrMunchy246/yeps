using Terraria.ID;
using Terraria.ModLoader;

namespace yeps.Items.weapons.Cheat
{
	public class WoodnBow : ModItem
	{
		public override void SetStaticDefaults() 
		{
			// DisplayName.SetDefault("WoodenBow");
			Tooltip.SetDefault("toatlly normal");
		}

		public override void SetDefaults() 
		{
			item.damage = 93766453; 
			item.width = 40; 
			item.height = 20; 
			item.useTime = 1; 
			item.useAnimation = 1; 
			item.useStyle = 2; 
			item.noMelee = true; 
			item.knockBack = 4346756; 
			item.autoReuse = true;
			item.value = 10000; 
			item.rare = 11; 
			item.UseSound = SoundID.Item5; 
			item.shoot = 140; 
			item.shootSpeed = 45f; 
		}
	}
}