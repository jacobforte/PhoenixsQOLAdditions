using System.Collections.Generic;
using Terraria;
using Terraria.ID;

namespace PhoenixsQOLAdditions.Content.Items.Buffs
{
	public class InfiniteLifeforcePotion : Tier1InfiniteBuff
	{
		protected override int BaseItem => ItemID.LifeforcePotion;

		protected override List<int> IncompatibleBuffs => new List<int> { BuffID.Lifeforce };

		protected override void BuffEffect(Player player)
		{
			player.lifeForce = true;
			player.statLifeMax2 += player.statLifeMax / 5 / 20 * 20;
		}
	}
}
