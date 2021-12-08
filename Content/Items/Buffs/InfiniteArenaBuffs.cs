using System;
using System.Collections.Generic;
using Terraria.ID;
using Terraria.ModLoader;

namespace PhoenixsQOLAdditions.Content.Items.Buffs
{
	public sealed class InfiniteArenaBuffs : Tier2InfiniteBuff
	{
		protected override int Rarity => ItemRarityID.Orange;
		protected override string TooltipString => PhoenixsQOLAdditions.GetText("ItemTooltip", "InfiniteArenaBuffs");
		protected override Dictionary<int, Type> GetParrentItemTypes()
		{
			return Buffs;
		}

		private static Dictionary<int, Type> Buffs = new Dictionary<int, Type>()
		{
			{ ModContent.ItemType<InfiniteHoney>(), typeof(InfiniteHoney) },
			{ ModContent.ItemType<InfiniteStarInABottle>(), typeof(InfiniteStarInABottle) },
			{ ModContent.ItemType<InfiniteCampfire>(), typeof(InfiniteCampfire) },
			{ ModContent.ItemType<InfiniteHeartLantern>(), typeof(InfiniteHeartLantern) },
			{ ModContent.ItemType<InfiniteBastStatue>(), typeof(InfiniteBastStatue) }
		};
	}
}
