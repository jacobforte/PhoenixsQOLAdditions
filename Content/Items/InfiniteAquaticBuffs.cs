using System;
using System.Collections.Generic;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace PhoenixsQOLAdditions.Content.Items
{
	public sealed class InfiniteAquaticBuffs : Tier2InfiniteBuff
	{
		protected override int Rarity => ItemRarityID.Orange;
		protected override string TooltipString => PhoenixsQOLAdditions.GetText("ItemTooltip", "InfiniteAquaticBuffs");
		protected override Dictionary<int, Type> GetParrentItemTypes()
		{
			var dict = new Dictionary<int, Type>();
			dict.Add(ModContent.ItemType<InfiniteGillsPotion>(), typeof(InfiniteGillsPotion));
			dict.Add(ModContent.ItemType<InfiniteWaterWalkingPotion>(), typeof(InfiniteWaterWalkingPotion));
			dict.Add(ModContent.ItemType<InfiniteFlipperPotion>(), typeof(InfiniteFlipperPotion));
			return dict;
		}
	}
}
