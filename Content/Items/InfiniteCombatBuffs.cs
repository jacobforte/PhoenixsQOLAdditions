using System;
using System.Collections.Generic;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace PhoenixsQOLAdditions.Content.Items
{
	public sealed class InfiniteCombatBuffs : Tier2InfiniteBuff
	{
		protected override int Rarity => ItemRarityID.LightRed;
		protected override string TooltipString => PhoenixsQOLAdditions.GetText("ItemTooltip", "InfiniteCombatBuffs");
		protected override Dictionary<int, Type> GetParrentItemTypes()
		{
			return Buffs;
		}

		private static Dictionary<int, Type> Buffs = new Dictionary<int, Type>()
		{
			{ ModContent.ItemType<InfiniteBasicBuffs>(), typeof(InfiniteBasicBuffs) },
			{ ModContent.ItemType<InfiniteDamageBuffs>(), typeof(InfiniteDamageBuffs) },
			{ ModContent.ItemType<InfiniteDefenseBuffs>(), typeof(InfiniteDefenseBuffs) },
			{ ModContent.ItemType<InfiniteMagicBuffs>(), typeof(InfiniteMagicBuffs) },
			{ ModContent.ItemType<InfiniteTipsy>(), typeof(InfiniteTipsy) },
			{ ModContent.ItemType<InfiniteRangedBuffs>(), typeof(InfiniteRangedBuffs) },
			{ ModContent.ItemType<InfiniteArenaBuffs>(), typeof(InfiniteArenaBuffs) },
			{ ModContent.ItemType<InfiniteStationBuffs>(), typeof(InfiniteStationBuffs) }
		};
	}
}
