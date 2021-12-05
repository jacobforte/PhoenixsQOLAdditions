using System.Collections.Generic;
using Terraria;
using Terraria.ID;

namespace PhoenixsQOLAdditions.Content.Items.Buffs
{
	public class InfiniteNightOwlPotion : Tier1InfiniteBuff
	{
		protected override int BaseItem => ItemID.NightOwlPotion;

		protected override List<int> IncompatibleBuffs => new List<int> { BuffID.NightOwl };

		protected override void BuffEffect(Player player)
		{
			player.nightVision = true;
		}
	}
}
