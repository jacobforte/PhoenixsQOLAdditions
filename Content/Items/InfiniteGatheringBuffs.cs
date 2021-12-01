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
			return Buffs;
		}

		private static Dictionary<int, Type> Buffs = new Dictionary<int, Type>()
		{
			{ ModContent.ItemType<InfiniteSpelunkerPotion>(), typeof(InfiniteSpelunkerPotion) },
			{ ModContent.ItemType<InfiniteNightOwlPotion>(), typeof(InfiniteNightOwlPotion) },
			{ ModContent.ItemType<InfiniteObsidianSkinPotion>(), typeof(InfiniteObsidianSkinPotion) },
			{ ModContent.ItemType<InfiniteMiningPotion>(), typeof(InfiniteMiningPotion) },
			{ ModContent.ItemType<InfiniteShinePotion>(), typeof(InfiniteShinePotion) }
		};
	}
}
