using Terraria;
using Terraria.ModLoader;
using Terraria.ID;
using Terraria.GameContent.Creative;

namespace PhoenixsQOLAdditions.Content.Items.Buffs
{
	public abstract class BaseInfiniteBuffs : ModItem
	{
		protected abstract int Rarity { get; }
		protected abstract string TooltipString { get; }
		protected virtual string DisplayNameString { get; }

		public sealed override void SetStaticDefaults()
		{
			if (!string.IsNullOrEmpty(DisplayNameString))
			{
				DisplayName.SetDefault(DisplayNameString);
			}
			CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 1;
			Tooltip.SetDefault(TooltipString);
		}

		public sealed override void SetDefaults()
		{
			Item.maxStack = 1;
			Item.value = 0;
			Item.rare = Rarity;
		}

		public override void ModifyResearchSorting(ref ContentSamples.CreativeHelper.ItemGroup itemGroup)
		{
			itemGroup = ContentSamples.CreativeHelper.ItemGroup.BuffPotion;
		}

		public abstract override void AddRecipes();
	}
}
