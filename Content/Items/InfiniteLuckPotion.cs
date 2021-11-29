using System.Collections.Generic;
using Terraria;
using Terraria.ID;

namespace PhoenixsQOLAdditions.Content.Items
{
	public class InfiniteLuckPotion : Tier1InfiniteBuff
	{
		protected override int BaseItem => ItemID.LuckPotionGreater;

		protected override List<int> IncompatibleBuffs => new List<int> { BuffID.Lucky };

		protected override void BuffEffect(Player player)
		{
			player.luckPotion += 3;
		}
	}
}
