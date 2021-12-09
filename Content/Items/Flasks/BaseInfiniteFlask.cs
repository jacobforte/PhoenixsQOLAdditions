using Terraria;
using Terraria.GameContent.Creative;
using Terraria.ID;
using Terraria.ModLoader;

namespace PhoenixsQOLAdditions.Content.Items.Flasks
{
	public abstract class BaseInfiniteFlask : ModItem
	{
		protected abstract int BaseItemType { get; }
		//protected abstract int BaseBuffType { get; }
		protected abstract byte MeleeEnchant { get; }

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
			Tooltip.SetDefault(PhoenixsQOLAdditions.GetText("ItemTooltip", "Tier1Buff", baseTooltipString));
		}

		public override void SetDefaults()
		{
			Item.maxStack = 1;
			Item.consumable = false;
			Item.value = 0;
			Item.rare = ItemRarityID.Green;
		}

		public override void UpdateInventory(Player player)
		{
			for (int i = 71; i <= 79; i++)
			{
				player.buffImmune[i] = true;
			}

			player.meleeEnchant = MeleeEnchant;
		}

		public override void ModifyResearchSorting(ref ContentSamples.CreativeHelper.ItemGroup itemGroup)
		{
			itemGroup = ContentSamples.CreativeHelper.ItemGroup.Flask;
		}

		public override void AddRecipes()
		{
			Recipe recipe = CreateRecipe();
			recipe.AddIngredient(BaseItemType, 30);
			recipe.Register();
		}
	}
}
