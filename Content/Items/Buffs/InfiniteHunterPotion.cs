using System.Collections.Generic;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace PhoenixsQOLAdditions.Content.Items.Buffs
{
	public class InfiniteHunterPotion : Tier1InfiniteBuff
	{
		protected override int BaseItem => ItemID.HunterPotion;

		protected override List<int> IncompatibleBuffs => new List<int> { BuffID.Hunter };

		protected override void BuffEffect(Player player)
		{
			if (ModContent.GetInstance<PhoenixsModConfig>().DangerBuffsEnabled)
			{
				player.detectCreature = true;
			}
		}
	}
}
