using System.Collections.Generic;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace PhoenixsQOLAdditions.Content.Items
{
	public class InfiniteRegenerationPotion : Tier1InfiniteBuff
	{
		public override int BaseItem => ItemID.RegenerationPotion;

		public override List<int> IncompatibleBuffs => new List<int> { BuffID.Regeneration };

		public override int Value => 5000;

		public override void BuffEffect(Player player)
		{
			player.lifeRegen += 1;
		}
	}
}
