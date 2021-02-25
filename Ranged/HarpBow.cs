using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace yeps.Items.weapons.Ranged
{
	public class HarpBow : ModItem
	{
		public override void SetStaticDefaults() {
			Tooltip.SetDefault("This weapon does something special with <right>.");
		}

		public override void SetDefaults() {
			item.damage = 50;
			item.melee = true;
			item.width = 40;
			item.height = 40;
			item.useTime = 20;
			item.useAnimation = 20;
			item.useStyle = 5;
			item.knockBack = 6;
			item.value = 10000;
			item.rare = ItemRarityID.Green;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
			item.shoot = 1; 
			item.shootSpeed = 50f; 
		}
		public override bool AltFunctionUse(Player player) {
			return true;
		}

		public override bool CanUseItem(Player player) {
			if (player.altFunctionUse == 2) {
				item.useStyle = 5;
				item.useTime = 20;
				item.useAnimation = 20;
				item.damage = 50;
				item.shoot = 1;
			}
			else {
				item.useStyle = 5;
				item.useTime = 40;
				item.useAnimation = 40;
				item.damage = 100;
				item.shoot = 76;
			}
			return base.CanUseItem(player);
		}
	}
}