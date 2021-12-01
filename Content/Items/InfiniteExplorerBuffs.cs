using System;
using System.Collections.Generic;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace PhoenixsQOLAdditions.Content.Items
{
	public sealed class InfiniteExplorerBuffs : Tier2InfiniteBuff
	{
		protected override int Rarity => ItemRarityID.LightRed;
		protected override string TooltipString => PhoenixsQOLAdditions.GetText("ItemTooltip", "InfiniteExplorerBuffs");
		protected override Dictionary<int, Type> GetParrentItemTypes()
		{
			return Buffs;
		}

		private static Dictionary<int, Type> Buffs = new Dictionary<int, Type>()
		{
			{ ModContent.ItemType<InfiniteBasicBuffs>(), typeof(InfiniteBasicBuffs) },
			{ ModContent.ItemType<InfiniteGatheringBuffs>(), typeof(InfiniteGatheringBuffs) },
			{ ModContent.ItemType<InfiniteAquaticBuffs>(), typeof(InfiniteAquaticBuffs) },
			{ ModContent.ItemType<InfiniteBuilderPotion>(), typeof(InfiniteBuilderPotion) }
		};
	}
}
