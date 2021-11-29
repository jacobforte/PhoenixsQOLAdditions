using System;
using System.Collections.Generic;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace PhoenixsQOLAdditions.Content.Items
{
	public sealed class InfiniteDamageBuffs : Tier2InfiniteBuff
	{
		protected override int Rarity => ItemRarityID.Orange;
		protected override string TooltipString => PhoenixsQOLAdditions.GetText("ItemTooltip", "InfiniteDamageBuffs");
		protected override Dictionary<int, Type> GetParrentItemTypes()
		{
			var dict = new Dictionary<int, Type>();
			dict.Add(ModContent.ItemType<InfiniteRagePotion>(), typeof(InfiniteRagePotion));
			dict.Add(ModContent.ItemType<InfiniteWrathPotion>(), typeof(InfiniteWrathPotion));
			dict.Add(ModContent.ItemType<InfiniteSwiftnessPotion>(), typeof(InfiniteTitanPotion));
			dict.Add(ModContent.ItemType<InfiniteThornsPotion>(), typeof(InfiniteThornsPotion));
			dict.Add(ModContent.ItemType<InfiniteInfernoPotion>(), typeof(InfiniteInfernoPotion));
			dict.Add(ModContent.ItemType<InfiniteEndurancePotion>(), typeof(InfiniteEndurancePotion));
			return dict;
		}
	}
}
