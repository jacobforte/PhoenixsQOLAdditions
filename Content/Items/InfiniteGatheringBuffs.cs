using System;
using System.Collections.Generic;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace PhoenixsQOLAdditions.Content.Items
{
	public sealed class InfiniteGatheringBuffs : Tier2InfiniteBuff
	{
		protected override int Rarity => ItemRarityID.Orange;
		protected override string TooltipString => PhoenixsQOLAdditions.GetText("ItemTooltip", "InfiniteGatheringBuffs");
		protected override Dictionary<int, Type> GetParrentItemTypes()
		{
			var dict = new Dictionary<int, Type>();
			dict.Add(ModContent.ItemType<InfiniteSpelunkerPotion>(), typeof(InfiniteSpelunkerPotion));
			dict.Add(ModContent.ItemType<InfiniteNightOwlPotion>(), typeof(InfiniteNightOwlPotion));
			dict.Add(ModContent.ItemType<InfiniteObsidianSkinPotion>(), typeof(InfiniteObsidianSkinPotion));
			dict.Add(ModContent.ItemType<InfiniteMiningPotion>(), typeof(InfiniteMiningPotion));
			dict.Add(ModContent.ItemType<InfiniteShinePotion>(), typeof(InfiniteShinePotion));
			return dict;
		}
	}
}
