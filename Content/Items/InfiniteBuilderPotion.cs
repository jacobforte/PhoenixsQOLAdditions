using System.Collections.Generic;
using Terraria;
using Terraria.ID;

namespace PhoenixsQOLAdditions.Content.Items
{
	public class InfiniteBuilderPotion : Tier1InfiniteBuff
	{
		protected override int BaseItem => ItemID.BuilderPotion;

		protected override List<int> IncompatibleBuffs => new List<int> { BuffID.Builder };

		protected override int Value => 5000;

		protected override void BuffEffect(Player player)
		{
			player.wallSpeed += 0.25f;
			player.tileSpeed += 0.25f;
			player.blockRange += 1;
		}
	}
}
