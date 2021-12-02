using System.Collections.Generic;
using Terraria;
using Terraria.ID;

namespace PhoenixsQOLAdditions.Content.Items.Buffs
{
	public class InfiniteSummoningPotion : Tier1InfiniteBuff
	{
		protected override int BaseItem => ItemID.SummoningPotion;

		protected override List<int> IncompatibleBuffs => new List<int> { BuffID.Summoning };

		protected override void BuffEffect(Player player)
		{
			player.maxMinions += 1;
		}
	}
}
