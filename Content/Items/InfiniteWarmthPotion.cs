using System.Collections.Generic;
using Terraria;
using Terraria.ID;

namespace PhoenixsQOLAdditions.Content.Items
{
	public class InfiniteWarmthPotion : Tier1InfiniteBuff
	{
		protected override int BaseItem => ItemID.WarmthPotion;

		protected override List<int> IncompatibleBuffs => new List<int> { BuffID.Warmth };

		protected override void BuffEffect(Player player)
		{
			player.resistCold = true;
		}
	}
}
