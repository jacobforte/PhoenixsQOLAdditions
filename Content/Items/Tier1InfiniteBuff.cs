using System.Collections.Generic;
using System.Linq;
using Terraria;
using Terraria.ModLoader;
using Terraria.ID;

namespace PhoenixsQOLAdditions.Content.Items
{
	public abstract class Tier1InfiniteBuff : ModItem
	{
		public abstract int BaseItem { get; }
		public abstract List<int> IncompatibleBuffs { get; }
		public abstract int Value { get; }
		public abstract void BuffEffect(Player player);

		public sealed override void SetStaticDefaults()
		{
			var tooltip = Lang.GetTooltip(BaseItem);
			string text = tooltip.GetLine(0);

			Tooltip.SetDefault(PhoenixsQOLAdditions.GetText("ItemTooltip", "Tier1Buff", text));
		}

		public sealed override void SetDefaults()
		{
			Item.maxStack = 1;
			Item.value = Value;
			Item.rare = ItemRarityID.Green;
		}

		public sealed override void UpdateInventory(Player player)
		{
			base.UpdateInventory(player);
			if (!IncompatibleBuffs.Any(buff => player.HasBuff(buff)))
			{
				BuffEffect(player);
			}
		}

		public override void AddRecipes()
		{
			Recipe recipe = CreateRecipe();
			recipe.AddIngredient(BaseItem, 30);
			recipe.Register();
		}
	}
}
