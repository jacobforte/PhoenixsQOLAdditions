using System.Collections.Generic;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace PhoenixsQOLAdditions.Content.Items
{
	public class InfiniteBewitchingTable : BaseInfiniteBuffs
	{
		protected override int Rarity => ItemRarityID.Green;

		protected override string TooltipString => PhoenixsQOLAdditions.GetText("ItemTooltip", "InfiniteBewitchingTable");

		protected override int Value => 5000;

		public sealed override void UpdateInventory(Player player)
		{
			player.buffImmune[BuffID.Bewitched] = true;
			player.maxMinions += 1;
		}

		public override void AddRecipes()
		{
			Recipe recipe = CreateRecipe();
			recipe.AddIngredient(ItemID.BewitchingTable, 5);
			recipe.Register();
		}
	}
}
