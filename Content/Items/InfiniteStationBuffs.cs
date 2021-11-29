using System;
using System.Collections.Generic;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace PhoenixsQOLAdditions.Content.Items
{
	public sealed class InfiniteStationBuffs : Tier2InfiniteBuff
	{
		protected override int Rarity => ItemRarityID.Orange;
		protected override string TooltipString => PhoenixsQOLAdditions.GetText("ItemTooltip", "InfiniteStationBuffs");
		protected override Dictionary<int, Type> GetParrentItemTypes()
		{
			var dict = new Dictionary<int, Type>();
			dict.Add(ModContent.ItemType<InfiniteHoney>(), typeof(InfiniteHoney));
			dict.Add(ModContent.ItemType<InfiniteStarInABottle>(), typeof(InfiniteStarInABottle));
			dict.Add(ModContent.ItemType<InfiniteCampfire>(), typeof(InfiniteCampfire));
			dict.Add(ModContent.ItemType<InfiniteHeartLantern>(), typeof(InfiniteHeartLantern));
			dict.Add(ModContent.ItemType<InfiniteBastStatue>(), typeof(InfiniteBastStatue));
			return dict;
		}
	}
}
