using System.Collections.Generic;
using Terraria;
using Terraria.ID;

namespace PhoenixsQOLAdditions.Content.Items
{
	public class InfiniteGravitationPotion : Tier1InfiniteBuff
	{
		protected override int BaseItem => ItemID.GravitationPotion;

		protected override List<int> IncompatibleBuffs => new List<int> { BuffID.Gravitation };

		protected override int Value => 5000;

		protected override void BuffEffect(Player player)
		{
			player.gravControl = true;
		}
	}
}
