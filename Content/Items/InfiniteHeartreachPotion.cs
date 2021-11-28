using System.Collections.Generic;
using Terraria;
using Terraria.ID;

namespace PhoenixsQOLAdditions.Content.Items
{
	public class InfiniteHeartreachPotion : Tier1InfiniteBuff
	{
		protected override int BaseItem => ItemID.HeartreachPotion;

		protected override List<int> IncompatibleBuffs => new List<int> { BuffID.Heartreach };

		protected override int Value => 5000;

		protected override void BuffEffect(Player player)
		{
			player.lifeMagnet = true;
		}
	}
}
