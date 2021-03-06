using System.Collections.Generic;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace PhoenixsQOLAdditions.Content.Items.Buffs
{
	public class InfiniteInvisibilityPotion : Tier1InfiniteBuff
	{
		protected override int BaseItem => ItemID.InvisibilityPotion;

		protected override List<int> IncompatibleBuffs => new List<int> { BuffID.Invisibility };

		protected override void BuffEffect(Player player)
		{
			if (ModContent.GetInstance<PhoenixsModConfig>().InvisibilityBuffEnabled)
			{
				player.invis = true;
			}
		}
	}
}
