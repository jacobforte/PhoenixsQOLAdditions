using System;
using System.Collections.Generic;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace PhoenixsQOLAdditions.Content.Items
{
	public sealed class InfiniteBasicBuffs : Tier2InfiniteBuff
	{
		protected override int Rarity => ItemRarityID.Orange;
		protected override string TooltipString => PhoenixsQOLAdditions.GetText("ItemTooltip", "InfiniteBasicBuffs");
		protected override Dictionary<int, Type> GetParrentItemTypes()
		{
			var dict = new Dictionary<int, Type>();
			dict.Add(ModContent.ItemType<InfiniteIronskinPotion>(), typeof(InfiniteIronskinPotion));
			dict.Add(ModContent.ItemType<InfiniteRegenerationPotion>(), typeof(InfiniteRegenerationPotion));
			dict.Add(ModContent.ItemType<InfiniteSwiftnessPotion>(), typeof(InfiniteSwiftnessPotion));
			dict.Add(ModContent.ItemType<InfiniteExquisitelyStuffed>(), typeof(InfiniteExquisitelyStuffed));
			return dict;
		}
	}
}
