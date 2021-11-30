using System;
using System.Collections.Generic;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace PhoenixsQOLAdditions.Content.Items
{
	public sealed class InfiniteFishingBuffs : Tier2InfiniteBuff
	{
		protected override int Rarity => ItemRarityID.Orange;
		protected override string TooltipString => PhoenixsQOLAdditions.GetText("ItemTooltip", "InfiniteFishingBuffs");
		protected override Dictionary<int, Type> GetParrentItemTypes()
		{
			var dict = new Dictionary<int, Type>();
			dict.Add(ModContent.ItemType<InfiniteFishingPotion>(), typeof(InfiniteFishingPotion));
			dict.Add(ModContent.ItemType<InfiniteSonarPotion>(), typeof(InfiniteSonarPotion));
			dict.Add(ModContent.ItemType<InfiniteCratePotion>(), typeof(InfiniteCratePotion));
			return dict;
		}
	}
}
