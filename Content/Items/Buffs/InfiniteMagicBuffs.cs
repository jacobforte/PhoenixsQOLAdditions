using System;
using System.Collections.Generic;
using Terraria.ID;
using Terraria.ModLoader;

namespace PhoenixsQOLAdditions.Content.Items.Buffs
{
	public sealed class InfiniteMagicBuffs : Tier2InfiniteBuff
	{
		protected override int Rarity => ItemRarityID.Orange;
		protected override string TooltipString => PhoenixsQOLAdditions.GetText("ItemTooltip", "InfiniteMagicBuffs");
		protected override Dictionary<int, Type> GetParrentItemTypes()
		{
			return Buffs;
		}

		private static Dictionary<int, Type> Buffs = new Dictionary<int, Type>()
		{
			{ ModContent.ItemType<InfiniteMagicPowerPotion>(), typeof(InfiniteMagicPowerPotion) },
			{ ModContent.ItemType<InfiniteManaRegenerationPotion>(), typeof(InfiniteManaRegenerationPotion) }
		};
	}
}
