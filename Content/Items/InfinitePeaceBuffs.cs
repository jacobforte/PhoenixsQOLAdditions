using System;
using System.Collections.Generic;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace PhoenixsQOLAdditions.Content.Items
{
	public sealed class InfinitePeaceBuffs : Tier2InfiniteBuff
	{
		protected override int Rarity => ItemRarityID.Orange;
		protected override string TooltipString => PhoenixsQOLAdditions.GetText("ItemTooltip", "InfinitePeaceBuffs");
		protected override Dictionary<int, Type> GetParrentItemTypes()
		{
			var dict = new Dictionary<int, Type>();
			dict.Add(ModContent.ItemType<InfiniteCalmingPotion>(), typeof(InfiniteCalmingPotion));
			dict.Add(ModContent.ItemType<InfinitePeaceCandle>(), typeof(InfinitePeaceCandle));
			dict.Add(ModContent.ItemType<InfiniteSunflower>(), typeof(InfiniteSunflower));
			return dict;
		}
	}
}
