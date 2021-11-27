using System.Collections.Generic;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace PhoenixsQOLAdditions.Content.Items
{
	public class InfiniteIronskinPotion : Tier1InfiniteBuff
	{
		public override int BaseItem => ItemID.IronskinPotion;

		public override List<int> IncompatibleBuffs => new List<int> { BuffID.Ironskin };

		public override int Value => 5000;

		public override void BuffEffect(Player player)
		{
			player.statDefense += 8;
		}
	}
}
