using System.Collections.Generic;
using Terraria;
using Terraria.ID;

namespace PhoenixsQOLAdditions.Content.Items.Buffs
{
	public class InfiniteDangersensePotion : Tier1InfiniteBuff
	{
		protected override int BaseItem => ItemID.TrapsightPotion;

		protected override List<int> IncompatibleBuffs => new List<int> { BuffID.Dangersense };

		protected override void BuffEffect(Player player)
		{
			player.dangerSense = PhoenixsQOLAdditions.DangerBuffsEnabled;
		}
	}
}
