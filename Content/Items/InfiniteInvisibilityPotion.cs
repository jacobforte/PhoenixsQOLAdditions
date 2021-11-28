using System.Collections.Generic;
using Terraria;
using Terraria.ID;

namespace PhoenixsQOLAdditions.Content.Items
{
	public class InfiniteInvisibilityPotion : Tier1InfiniteBuff
	{
		protected override int BaseItem => ItemID.InvisibilityPotion;

		protected override List<int> IncompatibleBuffs => new List<int> { BuffID.Invisibility };

		protected override int Value => 5000;

		protected override void BuffEffect(Player player)
		{
			player.invis = true;
		}
	}
}
