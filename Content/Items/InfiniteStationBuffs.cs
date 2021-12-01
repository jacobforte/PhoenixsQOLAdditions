using System;
using System.Collections.Generic;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace PhoenixsQOLAdditions.Content.Items
{
	public sealed class InfiniteStationBuffs : Tier2InfiniteBuff
	{
		protected override int Rarity => ItemRarityID.Orange;
		protected override string TooltipString => PhoenixsQOLAdditions.GetText("ItemTooltip", "InfiniteStationBuffs");
		protected override Dictionary<int, Type> GetParrentItemTypes()
		{
			return Buffs;
		}

		private static Dictionary<int, Type> Buffs = new Dictionary<int, Type>()
		{
			{ ModContent.ItemType<InfiniteAmmoReservationPotion>(), typeof(InfiniteCrystalBall) },
			{ ModContent.ItemType<InfiniteAmmoBox>(), typeof(InfiniteAmmoBox) },
			{ ModContent.ItemType<InfiniteSharpeningStation>(), typeof(InfiniteSharpeningStation) },
			{ ModContent.ItemType<InfiniteBewitchingTable>(), typeof(InfiniteBewitchingTable) },
			{ ModContent.ItemType<InfiniteCake>(), typeof(InfiniteCake) }
		};
	}
}
