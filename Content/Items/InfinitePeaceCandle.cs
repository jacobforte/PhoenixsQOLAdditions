using System.Collections.Generic;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace PhoenixsQOLAdditions.Content.Items
{
	public class InfinitePeaceCandle : BaseInfiniteBuffs
	{
		protected override int Rarity => ItemRarityID.Green;

		protected override string TooltipString => PhoenixsQOLAdditions.GetText("ItemTooltip", "InfinitePeaceCandle");

		protected override int Value => 100;

		public sealed override void UpdateInventory(Player player)
		{
			player.buffImmune[BuffID.PeaceCandle] = true;
			player.ZonePeaceCandle = true;
		}

		public override void AddRecipes()
		{
			Recipe recipe = CreateRecipe();
			recipe.AddIngredient(ItemID.PeaceCandle, 10);
			recipe.Register();
		}
	}
}
