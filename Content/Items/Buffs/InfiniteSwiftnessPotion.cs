using System.Collections.Generic;
using Terraria;
using Terraria.ID;

namespace PhoenixsQOLAdditions.Content.Items.Buffs
{
	public class InfiniteSwiftnessPotion : Tier1InfiniteBuff
	{
		protected override int BaseItem => ItemID.SwiftnessPotion;

		protected override List<int> IncompatibleBuffs => new List<int> { BuffID.Swiftness };

		protected override void BuffEffect(Player player)
		{
			player.moveSpeed += 0.25f;
		}
	}
}
