using Terraria;
using Terraria.GameContent.Creative;
using Terraria.ID;
using Terraria.ModLoader;

namespace PhoenixsQOLAdditions.Content.Items.HealingMana
{
	public abstract class BaseRestoPotion : ModItem
	{
		protected abstract int BaseItemType { get; }

		public sealed override void SetStaticDefaults()
		{
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
			if (Item.healLife > 0)
			{
				itemGroup = ContentSamples.CreativeHelper.ItemGroup.LifePotions;
			}
			else
			{
				itemGroup = ContentSamples.CreativeHelper.ItemGroup.ManaPotions;
			}
		}

		public override void AddRecipes()
		{
			Recipe recipe = CreateRecipe();
			recipe.AddIngredient(BaseItemType, 30);
			recipe.Register();
		}
	}
}
