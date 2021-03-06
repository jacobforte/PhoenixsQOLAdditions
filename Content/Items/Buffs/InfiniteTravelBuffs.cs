using Microsoft.Xna.Framework;
using Terraria;
using Terraria.GameContent.Creative;
using Terraria.ID;
using Terraria.ModLoader;

namespace PhoenixsQOLAdditions.Content.Items.Buffs
{
	public class InfiniteTravelBuffs : ModItem
	{
		public sealed override void SetStaticDefaults()
		{
			Tooltip.SetDefault(PhoenixsQOLAdditions.GetText("ItemTooltip", "InfiniteTravelBuffs"));
		}

		public override void SetDefaults()
		{
			CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 1;
			Item.CloneDefaults(ItemID.TeleportationPotion);
			Item.maxStack = 1;
			Item.consumable = false;
			Item.value = 0;
			Item.rare = ItemRarityID.Orange;
		}

		public override void ModifyResearchSorting(ref ContentSamples.CreativeHelper.ItemGroup itemGroup)
		{
			itemGroup = ContentSamples.CreativeHelper.ItemGroup.BuffPotion;
		}

		public override void UseStyle(Player player, Rectangle heldItemFrame)
		{
			if (player.itemTime == 0)
			{
				player.ApplyItemTime(Item);
			}
			else if (player.itemTime == 2)
			{
				if (Main.netMode == NetmodeID.SinglePlayer)
					player.TeleportationPotion();
				else if (Main.netMode == NetmodeID.MultiplayerClient && player.whoAmI == Main.myPlayer)
					NetMessage.SendData(MessageID.RequestTeleportationByServer);
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
