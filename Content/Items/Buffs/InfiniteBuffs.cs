using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using Terraria;
using Terraria.Audio;
using Terraria.GameContent.Creative;
using Terraria.GameInput;
using Terraria.ID;
using Terraria.Localization;
using Terraria.Map;
using Terraria.ModLoader;

namespace PhoenixsQOLAdditions.Content.Items.Buffs
{
	public class InfiniteBuffs : ModItem
	{
		private Dictionary<int, Type> _ParrentItemTypes;
		private Dictionary<int, Type> ParrentItemTypes
		{
			get
			{
				if (_ParrentItemTypes == null)
				{
					_ParrentItemTypes = new Dictionary<int, Type>();
					_ParrentItemTypes.Add(ModContent.ItemType<InfiniteExplorerBuffs>(), typeof(InfiniteExplorerBuffs));
					_ParrentItemTypes.Add(ModContent.ItemType<InfiniteCombatBuffs>(), typeof(InfiniteCombatBuffs));
					_ParrentItemTypes.Add(ModContent.ItemType<InfiniteFishingBuffs>(), typeof(InfiniteFishingBuffs));
					_ParrentItemTypes.Add(ModContent.ItemType<InfiniteFlightBuffs>(), typeof(InfiniteFlightBuffs));
					_ParrentItemTypes.Add(ModContent.ItemType<InfiniteInvisibilityPotion>(), typeof(InfiniteInvisibilityPotion));
					_ParrentItemTypes.Add(ModContent.ItemType<InfiniteLuckPotion>(), typeof(InfiniteLuckPotion));
					_ParrentItemTypes.Add(ModContent.ItemType<InfiniteBattlerBuffs>(), typeof(InfiniteBattlerBuffs));
					_ParrentItemTypes.Add(ModContent.ItemType<InfinitePeaceBuffs>(), typeof(InfinitePeaceBuffs));
				}
				return _ParrentItemTypes;
			}
		}

		public sealed override void SetStaticDefaults()
		{
			CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 1;
			Tooltip.SetDefault(PhoenixsQOLAdditions.GetText("ItemTooltip", "InfiniteBuffs"));
		}

		public override void SetDefaults()
		{
			Item.CloneDefaults(ItemID.TeleportationPotion);
			Item.maxStack = 1;
			Item.consumable = false;
			Item.value = 0;
			Item.rare = ItemRarityID.Purple;
		}

		public override void ModifyResearchSorting(ref ContentSamples.CreativeHelper.ItemGroup itemGroup)
		{
			itemGroup = ContentSamples.CreativeHelper.ItemGroup.BuffPotion;
		}

		public sealed override void UpdateInventory(Player player)
		{
			foreach (var parrentItemType in ParrentItemTypes)
			{
				Type type = parrentItemType.Value;
				if (!player.HasItem(parrentItemType.Key))
				{
					dynamic item = Activator.CreateInstance(type);
					item.UpdateInventory(player);
				}
			}
		}

		public sealed override void AddRecipes()
		{
			Recipe recipe = CreateRecipe();
			foreach (var parrentItemType in ParrentItemTypes)
			{
				recipe.AddIngredient(parrentItemType.Key);
			}
			recipe.AddIngredient(ModContent.ItemType<InfiniteTravelBuffs>(), 1);
			recipe.AddTile(TileID.TinkerersWorkbench);
			recipe.Register();
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
	}
}
