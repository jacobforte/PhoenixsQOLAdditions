using System.Collections.Generic;
using Terraria;
using Terraria.ID;

namespace PhoenixsQOLAdditions.Content.Items
{
	public class InfiniteInvisibilityPotion : Tier1InfiniteBuff
	{
		protected override int BaseItem => ItemID.InvisibilityPotion;

		protected override List<int> IncompatibleBuffs => new List<int> { BuffID.Invisibility };

		protected override void BuffEffect(Player player)
		{
			if (PhoenixsQOLAdditions.InvisibilityBuffEnabled)
			{
				player.invis = true;
			}
		}
	}
}
