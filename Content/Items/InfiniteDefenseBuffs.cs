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
			var dict = new Dictionary<int, Type>();
			dict.Add(ModContent.ItemType<InfiniteHeartreachPotion>(), typeof(InfiniteHeartreachPotion));
			dict.Add(ModContent.ItemType<InfiniteLifeforcePotion>(), typeof(InfiniteLifeforcePotion));
			dict.Add(ModContent.ItemType<InfiniteWarmthPotion>(), typeof(InfiniteWarmthPotion));
			dict.Add(ModContent.ItemType<InfiniteEndurancePotion>(), typeof(InfiniteEndurancePotion));
			return dict;
		}
	}
}
