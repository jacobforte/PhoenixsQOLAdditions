using System.Collections.Generic;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace PhoenixsQOLAdditions.Content.Items.Buffs
{
	public class InfiniteDangersensePotion : Tier1InfiniteBuff
	{
		protected override int BaseItem => ItemID.TrapsightPotion;

		protected override List<int> IncompatibleBuffs => new List<int> { BuffID.Dangersense };

		protected override void BuffEffect(Player player)
		{
			if (ModContent.GetInstance<PhoenixsModConfig>().DangerBuffsEnabled)
			{
				player.dangerSense = true;
			}
		}
	}
}
