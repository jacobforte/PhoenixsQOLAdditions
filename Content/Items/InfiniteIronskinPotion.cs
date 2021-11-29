using System.Collections.Generic;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace PhoenixsQOLAdditions.Content.Items
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
