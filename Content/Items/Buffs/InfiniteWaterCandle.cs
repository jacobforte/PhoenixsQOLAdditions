using System.Collections.Generic;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace PhoenixsQOLAdditions.Content.Items.Buffs
{
	// Can't use Tier1 Buff class because we needed a custom tooltip string.
	public class InfiniteWaterCandle : BaseInfiniteBuffs
	{
		protected override int Rarity => ItemRarityID.Green;

		protected override string TooltipString => PhoenixsQOLAdditions.GetText("ItemTooltip", "InfiniteWaterCandle");

		public sealed override void UpdateInventory(Player player)
		{
			if (ModContent.GetInstance<PhoenixsModConfig>().BattlerEnabled)
			{
				player.buffImmune[BuffID.WaterCandle] = true;
				player.ZoneWaterCandle = true;
			}
		}

		public override void AddRecipes()
		{
			Recipe recipe = CreateRecipe();
			recipe.AddIngredient(ItemID.WaterCandle, 10);
			recipe.Register();
		}
	}
}
