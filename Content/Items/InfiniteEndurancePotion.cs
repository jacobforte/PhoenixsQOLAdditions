using System.Collections.Generic;
using Terraria;
using Terraria.ID;

namespace PhoenixsQOLAdditions.Content.Items
{
	public class InfiniteEndurancePotion : Tier1InfiniteBuff
	{
		protected override int BaseItem => ItemID.EndurancePotion;

		protected override List<int> IncompatibleBuffs => new List<int> { BuffID.Endurance };

		protected override void BuffEffect(Player player)
		{
			player.endurance += 0.1f;
		}
	}
}
