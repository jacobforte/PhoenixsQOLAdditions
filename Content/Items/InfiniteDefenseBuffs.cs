using System;
using System.Collections.Generic;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace PhoenixsQOLAdditions.Content.Items
{
	public sealed class InfiniteDefenseBuffs : Tier2InfiniteBuff
	{
		protected override int Rarity => ItemRarityID.Orange;
		protected override string TooltipString => PhoenixsQOLAdditions.GetText("ItemTooltip", "InfiniteDefenseBuffs");
		protected override Dictionary<int, Type> GetParrentItemTypes()
		{
			return Buffs;
		}

		private static Dictionary<int, Type> Buffs = new Dictionary<int, Type>()
		{
			{ ModContent.ItemType<InfiniteHeartreachPotion>(), typeof(InfiniteHeartreachPotion) },
			{ ModContent.ItemType<InfiniteLifeforcePotion>(), typeof(InfiniteLifeforcePotion) },
			{ ModContent.ItemType<InfiniteWarmthPotion>(), typeof(InfiniteWarmthPotion) },
			{ ModContent.ItemType<InfiniteEndurancePotion>(), typeof(InfiniteEndurancePotion) }
		};
	}
}
