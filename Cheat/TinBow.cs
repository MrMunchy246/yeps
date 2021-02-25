using Terraria.ID;
using Terraria.ModLoader;

namespace yeps.Items.weapons.Cheat
{
	public class TinBow : ModItem
	{
		public override void SetStaticDefaults() 
		{
			// DisplayName.SetDefault("TinBow");
			Tooltip.SetDefault("toatlly normal");
		}

		public override void SetDefaults() 
		{
			item.damage = 1; 
			item.width = 40; 
			item.height = 20; 
			item.useTime = 10; 
			item.useAnimation = 10; 
			item.useStyle = 2; 
			item.noMelee = true; 
			item.knockBack = 1000000; 
			item.autoReuse = true;
			item.value = 1; 
			item.rare = 11; 
			item.UseSound = SoundID.Item5;  
			item.shoot = mod.ProjectileType("HealthShot");
			item.shootSpeed = 20f;
		}
	}
}