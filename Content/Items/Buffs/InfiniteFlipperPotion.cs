using System.Collections.Generic;
using Terraria;
using Terraria.ID;

namespace PhoenixsQOLAdditions.Content.Items.Buffs
{
	public class InfiniteFlipperPotion : Tier1InfiniteBuff
	{
		protected override int BaseItem => ItemID.FlipperPotion;

		protected override List<int> IncompatibleBuffs => new List<int> { BuffID.Flipper };

		protected override void BuffEffect(Player player)
		{
			player.ignoreWater = true;
			player.accFlipper = true;
		}
	}
}
