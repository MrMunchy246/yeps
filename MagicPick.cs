using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace yeps.Items.weapons
{
	public class MagicPick : ModItem
	{
		public override void SetStaticDefaults() {
			Tooltip.SetDefault("Magical");
		}

		public override void SetDefaults() {
			item.damage = 35;
			item.melee = true;
			item.magic = true;
			item.width = 40;
			item.height = 40;
			item.useTime = 15;
			item.useAnimation = 15;
			item.useStyle = 1;
			item.knockBack = 3;
			item.autoReuse = true;
			item.value = 15000;
			item.rare = ItemRarityID.Green;
			item.UseSound = SoundID.Item1;
			item.shoot = 617; 
			item.shootSpeed = 10f; 
		}
		public override bool AltFunctionUse(Player player) 
		{
			return true;
		}
        public override bool CanUseItem(Player player)
        {
            if (player.altFunctionUse == 2)
            {
                item.mana = 12;
				item.useStyle = 5;
				item.shoot = 617; 
				item.shootSpeed = 20f; 
				item.magic = true;
            }
            else
            {
				item.shoot = 0;
				item.shootSpeed = 0;
				item.useStyle = 1;
				item.width = 40;
				item.height = 40;
				item.melee = true;
				item.pick = 109;
            }
            if (player.ownedProjectileCounts[(ProjectileID.NebulaArcanum)] < 5)
            {
                return base.CanUseItem(player);
            }
            return false;
			}
        public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
        {
            int mode = 0;
            if (player.altFunctionUse == 2)
            {
                mode = 1;
            }
            Projectile.NewProjectile(position.X, position.Y, speedX, speedY, ProjectileID.NebulaArcanum, damage, knockBack, player.whoAmI, mode, type);
            return false;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(null, "SparkleEnergy");
			recipe.AddIngredient(ItemID.ManaCrystal, 15);
			recipe.AddTile(TileID.Furnaces); 
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}