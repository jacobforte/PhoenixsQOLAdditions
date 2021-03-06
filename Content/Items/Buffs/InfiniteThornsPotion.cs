using System.Collections.Generic;
using Terraria;
using Terraria.ID;

namespace PhoenixsQOLAdditions.Content.Items.Buffs
{
	public class InfiniteThornsPotion : Tier1InfiniteBuff
	{
		protected override int BaseItem => ItemID.ThornsPotion;

		protected override List<int> IncompatibleBuffs => new List<int> { BuffID.Thorns };

		protected override void BuffEffect(Player player)
		{
			if (player.thorns < 1f)
				player.thorns = 1f;
		}
	}
}
