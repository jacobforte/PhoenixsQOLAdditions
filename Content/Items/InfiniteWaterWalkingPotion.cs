using System.Collections.Generic;
using Terraria;
using Terraria.ID;

namespace PhoenixsQOLAdditions.Content.Items
{
	public class InfiniteWaterWalkingPotion : Tier1InfiniteBuff
	{
		protected override int BaseItem => ItemID.WaterWalkingPotion;

		protected override List<int> IncompatibleBuffs => new List<int> { BuffID.WaterWalking };

		protected override void BuffEffect(Player player)
		{
			player.waterWalk = true;
		}
	}
}
