using System.Collections.Generic;
using Terraria;
using Terraria.ID;

namespace PhoenixsQOLAdditions.Content.Items
{
	public class InfiniteGravitationPotion : Tier1InfiniteBuff
	{
		protected override int BaseItem => ItemID.GravitationPotion;

		protected override List<int> IncompatibleBuffs => new List<int> { BuffID.Gravitation };

		protected override void BuffEffect(Player player)
		{
			if (PhoenixsQOLAdditions.GravityBuffEnabled)
			{
				player.gravControl = true;
			}
		}
	}
}
