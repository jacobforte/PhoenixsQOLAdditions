using System.Collections.Generic;
using Terraria;
using Terraria.ID;

namespace PhoenixsQOLAdditions.Content.Items.Buffs
{
	public class InfiniteRegenerationPotion : Tier1InfiniteBuff
	{
		protected override int BaseItem => ItemID.RegenerationPotion;

		protected override List<int> IncompatibleBuffs => new List<int> { BuffID.Regeneration };

		protected override void BuffEffect(Player player)
		{
			player.lifeRegen += 4;
		}
	}
}
