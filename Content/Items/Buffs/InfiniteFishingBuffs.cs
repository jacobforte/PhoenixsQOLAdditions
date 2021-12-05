using System;
using System.Collections.Generic;
using Terraria.ID;
using Terraria.ModLoader;

namespace PhoenixsQOLAdditions.Content.Items.Buffs
{
	public sealed class InfiniteFishingBuffs : Tier2InfiniteBuff
	{
		protected override int Rarity => ItemRarityID.Orange;
		protected override string TooltipString => PhoenixsQOLAdditions.GetText("ItemTooltip", "InfiniteFishingBuffs");
		protected override Dictionary<int, Type> GetParrentItemTypes()
		{
			return Buffs;
		}

		private static Dictionary<int, Type> Buffs = new Dictionary<int, Type>()
		{
			{ ModContent.ItemType<InfiniteFishingPotion>(), typeof(InfiniteFishingPotion) },
			{ ModContent.ItemType<InfiniteSonarPotion>(), typeof(InfiniteSonarPotion) },
			{ ModContent.ItemType<InfiniteCratePotion>(), typeof(InfiniteCratePotion) }
		};
	}
}
