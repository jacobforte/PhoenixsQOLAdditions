using System;
using System.Collections.Generic;
using Terraria.ID;
using Terraria.ModLoader;

namespace PhoenixsQOLAdditions.Content.Items.Buffs
{
	public sealed class InfiniteBattlerBuffs : Tier2InfiniteBuff
	{
		protected override int Rarity => ItemRarityID.Orange;
		protected override string TooltipString => PhoenixsQOLAdditions.GetText("ItemTooltip", "InfiniteBattlerBuffs");
		protected override Dictionary<int, Type> GetParrentItemTypes()
		{
			return Buffs;
		}

		private static Dictionary<int, Type> Buffs = new Dictionary<int, Type>()
		{
			{ ModContent.ItemType<InfiniteBattlePotion>(), typeof(InfiniteBattlePotion) },
			{ ModContent.ItemType<InfiniteWaterCandle>(), typeof(InfiniteWaterCandle) }
		};
	}
}
