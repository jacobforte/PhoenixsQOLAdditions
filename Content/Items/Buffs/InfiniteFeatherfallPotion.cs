using System.Collections.Generic;
using Terraria;
using Terraria.ID;

namespace PhoenixsQOLAdditions.Content.Items.Buffs
{
	public class InfiniteFeatherfallPotion : Tier1InfiniteBuff
	{
		protected override int BaseItem => ItemID.FeatherfallPotion;

		protected override List<int> IncompatibleBuffs => new List<int> { BuffID.Featherfall };

		protected override void BuffEffect(Player player)
		{
			if (PhoenixsQOLAdditions.FeatherFallBuffEnabled)
			{
				player.slowFall = true;
			}
		}
	}
}
