using System.Collections.Generic;
using Terraria;
using Terraria.ID;

namespace PhoenixsQOLAdditions.Content.Items.Buffs
{
	public class InfiniteIronskinPotion : Tier1InfiniteBuff
	{
		protected override int BaseItem => ItemID.IronskinPotion;

		protected override List<int> IncompatibleBuffs => new List<int> { BuffID.Ironskin };

		protected override void BuffEffect(Player player)
		{
			player.statDefense += 8;
		}
	}
}
