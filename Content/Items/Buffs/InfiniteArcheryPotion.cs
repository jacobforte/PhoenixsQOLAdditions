using System.Collections.Generic;
using Terraria;
using Terraria.ID;

namespace PhoenixsQOLAdditions.Content.Items.Buffs
{
	public class InfiniteArcheryPotion : Tier1InfiniteBuff
	{
		protected override int BaseItem => ItemID.ArcheryPotion;

		protected override List<int> IncompatibleBuffs => new List<int> { BuffID.Archery };

		protected override void BuffEffect(Player player)
		{
			player.archery = true;
		}
	}
}
