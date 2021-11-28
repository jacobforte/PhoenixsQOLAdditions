using System.Collections.Generic;
using Terraria;
using Terraria.ID;

namespace PhoenixsQOLAdditions.Content.Items
{
	public class InfiniteFeatherfallPotion : Tier1InfiniteBuff
	{
		protected override int BaseItem => ItemID.FeatherfallPotion;

		protected override List<int> IncompatibleBuffs => new List<int> { BuffID.Featherfall };

		protected override int Value => 5000;

		protected override void BuffEffect(Player player)
		{
			player.slowFall = true;
		}
	}
}
