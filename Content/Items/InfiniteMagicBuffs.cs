using System;
using System.Collections.Generic;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace PhoenixsQOLAdditions.Content.Items
{
	public sealed class InfiniteMagicBuffs : Tier2InfiniteBuff
	{
		protected override int Rarity => ItemRarityID.Orange;
		protected override string TooltipString => PhoenixsQOLAdditions.GetText("ItemTooltip", "InfiniteMagicBuffs");
		protected override Dictionary<int, Type> GetParrentItemTypes()
		{
			var dict = new Dictionary<int, Type>();
			dict.Add(ModContent.ItemType<InfiniteMagicPowerPotion>(), typeof(InfiniteMagicPowerPotion));
			dict.Add(ModContent.ItemType<InfiniteManaRegenerationPotion>(), typeof(InfiniteManaRegenerationPotion));
			return dict;
		}
	}
}
