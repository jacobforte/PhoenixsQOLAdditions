using System.Collections.Generic;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace PhoenixsQOLAdditions.Content.Items
{
	public class InfiniteMiningPotion : Tier1InfiniteBuff
	{
		protected override int BaseItem => ItemID.MiningPotion;

		protected override List<int> IncompatibleBuffs => new List<int> { BuffID.Mining };

		protected override void BuffEffect(Player player)
		{
			player.pickSpeed -= 0.25f;
		}
	}
}
