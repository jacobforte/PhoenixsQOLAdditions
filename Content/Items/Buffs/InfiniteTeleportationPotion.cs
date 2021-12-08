using Microsoft.Xna.Framework;
using Terraria;
using Terraria.GameContent.Creative;
using Terraria.ID;
using Terraria.ModLoader;

namespace PhoenixsQOLAdditions.Content.Items.Buffs
{
	public class InfiniteTeleportationPotion : ModItem
	{
		public sealed override void SetStaticDefaults()
		{
			CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 1;
			Tooltip.SetDefault(PhoenixsQOLAdditions.GetText("ItemTooltip", "InfiniteTeleportationPotion"));
		}

		public override void SetDefaults()
		{
			Item.CloneDefaults(ItemID.TeleportationPotion);
			Item.maxStack = 1;
			Item.consumable = false;
			Item.value = 0;
			Item.rare = ItemRarityID.Green;
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
			recipe.AddIngredient(ItemID.TeleportationPotion, 30);
			recipe.Register();
		}
	}
}
