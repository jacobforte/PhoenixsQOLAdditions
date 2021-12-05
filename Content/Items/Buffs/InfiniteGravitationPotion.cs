using System.Collections.Generic;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace PhoenixsQOLAdditions.Content.Items.Buffs
{
	public class InfiniteGravitationPotion : Tier1InfiniteBuff
	{
		protected override int BaseItem => ItemID.GravitationPotion;

		protected override List<int> IncompatibleBuffs => new List<int> { BuffID.Gravitation };

		protected override void BuffEffect(Player player)
		{
			if (ModContent.GetInstance<PhoenixsModConfig>().GravityBuffEnabled)
			{
				player.gravControl = true;
			}
		}
	}
}
