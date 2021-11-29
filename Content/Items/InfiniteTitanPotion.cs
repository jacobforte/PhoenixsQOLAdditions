using System.Collections.Generic;
using Terraria;
using Terraria.ID;

namespace PhoenixsQOLAdditions.Content.Items
{
	public class InfiniteTitanPotion : Tier1InfiniteBuff
	{
		protected override int BaseItem => ItemID.TitanPotion;

		protected override List<int> IncompatibleBuffs => new List<int> { BuffID.Titan };

		protected override void BuffEffect(Player player)
		{
			player.kbBuff = true;
		}
	}
}
