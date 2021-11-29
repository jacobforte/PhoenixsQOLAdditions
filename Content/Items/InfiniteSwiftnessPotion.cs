using System.Collections.Generic;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace PhoenixsQOLAdditions.Content.Items
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
