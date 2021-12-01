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
			return Buffs;
		}

		private static Dictionary<int, Type> Buffs = new Dictionary<int, Type>()
		{
			{ ModContent.ItemType<InfiniteGillsPotion>(), typeof(InfiniteGillsPotion) },
			{ ModContent.ItemType<InfiniteWaterWalkingPotion>(), typeof(InfiniteWaterWalkingPotion) },
			{ ModContent.ItemType<InfiniteFlipperPotion>(), typeof(InfiniteFlipperPotion) }
		};
	}
}
