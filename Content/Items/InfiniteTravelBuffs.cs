using Microsoft.Xna.Framework;
using System.Collections.Generic;
using Terraria;
using Terraria.Audio;
using Terraria.GameInput;
using Terraria.ID;
using Terraria.Localization;
using Terraria.Map;
using Terraria.ModLoader;

namespace PhoenixsQOLAdditions.Content.Items
{
	public class InfiniteTravelBuffs : ModItem
	{
		public sealed override void SetStaticDefaults()
		{
			Tooltip.SetDefault(PhoenixsQOLAdditions.GetText("ItemTooltip", "InfiniteTravelBuffs"));
		}

		public override void SetDefaults()
		{
			Item.CloneDefaults(ItemID.TeleportationPotion);
			Item.maxStack = 1;
			Item.consumable = false;
			Item.value = 0;
			Item.rare = 3;
		}

		public override void UseStyle(Player player, Rectangle heldItemFrame)
		{
			if (player.itemTime == 0)
			{
				player.ApplyItemTime(Item);
			}
			else if (player.itemTime == 2)
			{
				if (Main.netMode == 0)
					player.TeleportationPotion();
				else if (Main.netMode == 1 && player.whoAmI == Main.myPlayer)
					NetMessage.SendData(73);
			}
		}

		public override void AddRecipes()
		{
			Recipe recipe = CreateRecipe();
			recipe.AddIngredient(ModContent.ItemType<InfiniteWormholePotion>(), 1);
			recipe.AddIngredient(ModContent.ItemType<InfiniteReturnPotion>(), 1);
			recipe.AddIngredient(ModContent.ItemType<InfiniteTeleportationPotion>(), 1);
			recipe.Register();
		}
	}
}
