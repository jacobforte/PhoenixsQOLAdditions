using System.Collections.Generic;
using Terraria;
using Terraria.GameContent.Creative;
using Terraria.ID;
using Terraria.ModLoader;

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
			string baseTooltipString = "";
			if (baseTooltip.Lines > 0)
			{
				baseTooltipString = baseTooltip?.GetLine(0);
			}
			Tooltip.SetDefault(PhoenixsQOLAdditions.GetText("ItemTooltip", "InfiniteConsumable", baseTooltipString));
		}

		public override void SetDefaults()
		{
			Item.CloneDefaults(BaseItemType);
			Item.maxStack = 1;
			Item.consumable = false;
			Item.value = 0;
			Item.rare = ItemRarityID.Green;
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
