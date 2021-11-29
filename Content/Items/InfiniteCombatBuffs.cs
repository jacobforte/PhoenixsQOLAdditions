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
			var dict = new Dictionary<int, Type>();
			dict.Add(ModContent.ItemType<InfiniteBasicBuffs>(), typeof(InfiniteBasicBuffs));
			dict.Add(ModContent.ItemType<InfiniteCombatBuffs>(), typeof(InfiniteCombatBuffs));
			dict.Add(ModContent.ItemType<InfiniteDefenseBuffs>(), typeof(InfiniteDefenseBuffs));
			dict.Add(ModContent.ItemType<InfiniteMagicBuffs>(), typeof(InfiniteMagicBuffs));
			dict.Add(ModContent.ItemType<InfiniteTipsy>(), typeof(InfiniteTipsy));
			dict.Add(ModContent.ItemType<InfiniteRangedBuffs>(), typeof(InfiniteRangedBuffs));
			dict.Add(ModContent.ItemType<InfiniteStationBuffs>(), typeof(InfiniteStationBuffs));
			dict.Add(ModContent.ItemType<InfiniteArenaBuffs>(), typeof(InfiniteArenaBuffs));
			return dict;
		}
	}
}
