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
			return Buffs;
		}

		private static Dictionary<int, Type> Buffs = new Dictionary<int, Type>()
		{
			{ ModContent.ItemType<InfiniteIronskinPotion>(), typeof(InfiniteIronskinPotion) },
			{ ModContent.ItemType<InfiniteRegenerationPotion>(), typeof(InfiniteRegenerationPotion) },
			{ ModContent.ItemType<InfiniteSwiftnessPotion>(), typeof(InfiniteSwiftnessPotion) },
			{ ModContent.ItemType<InfiniteExquisitelyStuffed>(), typeof(InfiniteExquisitelyStuffed) }
		};
	}
}
