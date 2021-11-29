using System;
using System.Collections.Generic;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace PhoenixsQOLAdditions.Content.Items
{
	public sealed class InfiniteBattlerBuffs : Tier2InfiniteBuff
	{
		protected override int Rarity => ItemRarityID.Orange;
		protected override string TooltipString => PhoenixsQOLAdditions.GetText("ItemTooltip", "InfiniteBattlerBuffs");
		protected override Dictionary<int, Type> GetParrentItemTypes()
		{
			var dict = new Dictionary<int, Type>();
			dict.Add(ModContent.ItemType<InfiniteBattlePotion>(), typeof(InfiniteBattlePotion));
			dict.Add(ModContent.ItemType<InfiniteWaterCandle>(), typeof(InfiniteWaterCandle));
			return dict;
		}
	}
}
