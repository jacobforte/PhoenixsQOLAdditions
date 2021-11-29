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
			var dict = new Dictionary<int, Type>();
			dict.Add(ModContent.ItemType<InfiniteBasicBuffs>(), typeof(InfiniteBasicBuffs));
			dict.Add(ModContent.ItemType<InfiniteGatheringBuffs>(), typeof(InfiniteGatheringBuffs));
			dict.Add(ModContent.ItemType<InfiniteAquaticBuffs>(), typeof(InfiniteAquaticBuffs));
			dict.Add(ModContent.ItemType<InfiniteBuilderPotion>(), typeof(InfiniteBuilderPotion));
			return dict;
		}
	}
}
