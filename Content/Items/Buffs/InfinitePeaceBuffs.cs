using System;
using System.Collections.Generic;
using Terraria.ID;
using Terraria.ModLoader;

namespace PhoenixsQOLAdditions.Content.Items.Buffs
{
	public sealed class InfinitePeaceBuffs : Tier2InfiniteBuff
	{
		protected override int Rarity => ItemRarityID.Orange;
		protected override string TooltipString => PhoenixsQOLAdditions.GetText("ItemTooltip", "InfinitePeaceBuffs");
		protected override Dictionary<int, Type> GetParrentItemTypes()
		{
			return Buffs;
		}

		private static Dictionary<int, Type> Buffs = new Dictionary<int, Type>()
		{
			{ ModContent.ItemType<InfiniteCalmingPotion>(), typeof(InfiniteCalmingPotion) },
			{ ModContent.ItemType<InfinitePeaceCandle>(), typeof(InfinitePeaceCandle) },
			{ ModContent.ItemType<InfiniteSunflower>(), typeof(InfiniteSunflower) }
		};
	}
}
