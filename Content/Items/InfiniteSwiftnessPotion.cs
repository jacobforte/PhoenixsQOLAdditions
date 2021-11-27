using System.Collections.Generic;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace PhoenixsQOLAdditions.Content.Items
{
	public class InfiniteSwiftnessPotion : Tier1InfiniteBuff
	{
		public override int BaseItem => ItemID.SwiftnessPotion;

		public override List<int> IncompatibleBuffs => new List<int> { BuffID.Swiftness };

		public override int Value => 5000;

		public override void BuffEffect(Player player)
		{
			player.moveSpeed += 0.25f;
		}
	}
}
