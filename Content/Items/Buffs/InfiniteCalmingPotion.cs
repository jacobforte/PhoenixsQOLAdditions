using System.Collections.Generic;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace PhoenixsQOLAdditions.Content.Items.Buffs
{
	public class InfiniteCalmingPotion : Tier1InfiniteBuff
	{
		protected override int BaseItem => ItemID.CalmingPotion;

		protected override List<int> IncompatibleBuffs => new List<int> { BuffID.Calm };

		protected override void BuffEffect(Player player)
		{
			if (ModContent.GetInstance<PhoenixsModConfig>().PeaceEnabled)
			{
				player.calmed = true;
			}
		}
	}
}
