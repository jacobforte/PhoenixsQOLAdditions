using System.Collections.Generic;
using Terraria;
using Terraria.GameContent.Creative;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.Utilities;

namespace PhoenixsQOLAdditions.Content.Items.AmmoWeapons
{
	public abstract class BaseInfiniteAmmo : ModItem
	{
		protected abstract int BaseItemType { get; }

		public sealed override void SetStaticDefaults()
		{
			DisplayName.SetDefault(PhoenixsQOLAdditions.GetText("DisplayName", "Infinite", Lang.GetItemName(BaseItemType)));

			CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 1;
			var baseTooltip = Lang.GetTooltip(BaseItemType);
			List<string> baseTooltipList = new();
			for (int i = 0; i < baseTooltip.Lines; i++)
			{
				baseTooltipList.Add(baseTooltip?.GetLine(i));
			}
			var baseTooltipString = string.Join("\n", baseTooltipList);
			Tooltip.SetDefault(PhoenixsQOLAdditions.GetText("ItemTooltip", "InfiniteConsumable", baseTooltipString));
		}

		public override void SetDefaults()
		{
			Item.CloneDefaults(BaseItemType);
			Item.maxStack = 1;
			Item.consumable = false;
			Item.value = 0;
			Item.rare = ItemRarityID.Green;
			Item.notAmmo = false;
			Item.createTile = -1;
			Item.buffType = 0;
			Item.buffTime = 0;
		}

		public override bool? PrefixChance(int pre, UnifiedRandom rand)
		{
			return false;
		}

		public override void ModifyResearchSorting(ref ContentSamples.CreativeHelper.ItemGroup itemGroup)
		{
			itemGroup = ContentSamples.CreativeHelper.ItemGroup.Ammo;
		}

		public override void AddRecipes()
		{
			Recipe recipe = CreateRecipe();
			recipe.AddIngredient(BaseItemType, 3996);
			recipe.Register();
		}
	}
}
