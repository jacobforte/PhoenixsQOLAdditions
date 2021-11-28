using System.Collections.Generic;
using Terraria;
using Terraria.ID;

namespace PhoenixsQOLAdditions.Content.Items
{
	public class InfiniteLifeforcePotion : Tier1InfiniteBuff
	{
		protected override int BaseItem => ItemID.LifeforcePotion;

		protected override List<int> IncompatibleBuffs => new List<int> { BuffID.Lifeforce };

		protected override int Value => 5000;

		protected override void BuffEffect(Player player)
		{
			player.lifeForce = true;
			player.statLifeMax2 += player.statLifeMax / 5 / 20 * 20;
		}
	}
}
