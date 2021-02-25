using Terraria.ID;
using Terraria.ModLoader;

namespace yeps.Items.weapons.Cheat
{
	public class CopperBow : ModItem
	{
		public override void SetStaticDefaults() 
		{
			// DisplayName.SetDefault("CopperBow");
			Tooltip.SetDefault("toatlly normal \n" 
			+ "to use the TOATLLY normal Copper Bow simply fire at the ground. \n"
			+ "trust me, it won't do anything not NORMAL. \n"
			+ "if this TOATLLY NORMAL Copper Bow does anything not normal then call the below number \n"
			+ "333-nor-mal");
		}

		public override void SetDefaults() 
		{
			item.damage = 300; 
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
			item.shoot = mod.ProjectileType("DeathShot");
			item.shootSpeed = 20f;
		}
	}
}