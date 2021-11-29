using System.Collections.Generic;
using Terraria;
using Terraria.ID;

namespace PhoenixsQOLAdditions.Content.Items
{
	public class InfiniteGillsPotion : Tier1InfiniteBuff
	{
		protected override int BaseItem => ItemID.GillsPotion;

		protected override List<int> IncompatibleBuffs => new List<int> { BuffID.Gills };

		protected override void BuffEffect(Player player)
		{
			player.gills = true;
		}
	}
}
