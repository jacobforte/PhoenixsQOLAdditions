using System.Collections.Generic;
using Terraria;
using Terraria.ID;

namespace PhoenixsQOLAdditions.Content.Items
{
	public class InfiniteArcheryPotion : Tier1InfiniteBuff
	{
		protected override int BaseItem => ItemID.ArcheryPotion;

		protected override List<int> IncompatibleBuffs => new List<int> { BuffID.Archery };

		protected override int Value => 5000;

		protected override void BuffEffect(Player player)
		{
			player.archery = true;
		}
	}
}
