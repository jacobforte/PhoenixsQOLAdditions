using System;
using System.Collections.Generic;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace PhoenixsQOLAdditions.Content.Items
{
	public sealed class InfiniteArenaBuffs : Tier2InfiniteBuff
	{
		protected override int Rarity => ItemRarityID.Orange;
		protected override string TooltipString => PhoenixsQOLAdditions.GetText("ItemTooltip", "InfiniteArenaBuffs");
		protected override Dictionary<int, Type> GetParrentItemTypes()
		{
			var dict = new Dictionary<int, Type>();
			dict.Add(ModContent.ItemType<InfiniteAmmoReservationPotion>(), typeof(InfiniteCrystalBall));
			dict.Add(ModContent.ItemType<InfiniteAmmoBox>(), typeof(InfiniteAmmoBox));
			dict.Add(ModContent.ItemType<InfiniteSharpeningStation>(), typeof(InfiniteSharpeningStation));
			dict.Add(ModContent.ItemType<InfiniteBewitchingTable>(), typeof(InfiniteBewitchingTable));
			dict.Add(ModContent.ItemType<InfiniteCake>(), typeof(InfiniteCake));
			return dict;
		}
	}
}
