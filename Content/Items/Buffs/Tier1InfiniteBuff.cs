using System.Collections.Generic;
using Terraria;
using Terraria.ID;

namespace PhoenixsQOLAdditions.Content.Items.Buffs
{
	public abstract class Tier1InfiniteBuff : BaseInfiniteBuffs
	{
		protected abstract int BaseItem { get; }
		protected abstract List<int> IncompatibleBuffs { get; }
		protected sealed override int Rarity => ItemRarityID.Green;
		protected sealed override string TooltipString => PhoenixsQOLAdditions.GetText("ItemTooltip", "Tier1Buff", Lang.GetTooltip(BaseItem).GetLine(0));
		protected abstract void BuffEffect(Player player);

		public sealed override void UpdateInventory(Player player)
		{
			foreach(var buff in IncompatibleBuffs)
			{
				player.buffImmune[buff] = true;
			}
			BuffEffect(player);
		}

		public override void AddRecipes()
		{
			Recipe recipe = CreateRecipe();
			recipe.AddIngredient(BaseItem, 30);
			recipe.Register();
		}
	}
}
