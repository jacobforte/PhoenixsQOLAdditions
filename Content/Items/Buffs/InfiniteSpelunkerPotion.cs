using System.Collections.Generic;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace PhoenixsQOLAdditions.Content.Items.Buffs
{
	public class InfiniteSpelunkerPotion : Tier1InfiniteBuff
	{
		protected override int BaseItem => ItemID.SpelunkerPotion;

		protected override List<int> IncompatibleBuffs => new List<int> { BuffID.Spelunker };

		protected override void BuffEffect(Player player)
		{
			if (ModContent.GetInstance<PhoenixsModConfig>().SpelunkerBuffEnabled)
			{
				player.findTreasure = true;
			}
		}
	}
}
